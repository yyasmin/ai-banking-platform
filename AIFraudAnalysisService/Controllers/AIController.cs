using Microsoft.AspNetCore.Mvc;
using AIFraudAnalysisService.Models;

namespace AIFraudAnalysisService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AIController : ControllerBase
    {
        [HttpPost]
        public IActionResult AnalyzeTransaction([FromBody] TransactionCreatedEvent transaction)
        {
            var fakeResponse = new
            {
                isSuspicious = true,
                reason = "Fake AI analysis: transaction amount unusually high compared to usual patterns."
            };

            Console.WriteLine("FAKE AI RESPONSE:");
            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(fakeResponse, new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            }));

            return Ok(fakeResponse);
        }
    }
}
