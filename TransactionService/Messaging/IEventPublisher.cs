using TransactionService.Models;
using System.Threading.Tasks;

namespace TransactionService.Messaging
{
    public interface IEventPublisher
    {
        Task PublishTransactionCreatedEvent(TransactionCreatedEvent evt);
    }
}
