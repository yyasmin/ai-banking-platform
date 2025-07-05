using Microsoft.AspNetCore.Mvc;
using TransactionService.Models;
using TransactionService.Messaging;

namespace TransactionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : ControllerBase
    {
        private readonly IEventPublisher _publisher;

        public TransactionController(IEventPublisher publisher)
        {
            _publisher = publisher;
        }

        [HttpPost]
        public async Task<IActionResult> CreateTransaction([FromBody] TransactionRequest request)
        {
            var evt = new TransactionCreatedEvent
            {
                TransactionId = Guid.NewGuid().ToString(),
                FromAccountId = request.FromAccountId,
                ToAccountId = request.ToAccountId,
                Amount = request.Amount,
                Currency = request.Currency,
                Location = request.Location,
                Timestamp = DateTime.UtcNow
            };

            await _publisher.PublishTransactionCreatedEvent(evt);

            return Accepted(new
            {
                Message = "Transaction created event published.",
                TransactionId = evt.TransactionId
            });
        }
    }
}
