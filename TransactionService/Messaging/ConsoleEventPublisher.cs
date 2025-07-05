using System;
using System.Threading.Tasks;
using TransactionService.Models;
using System.Text.Json;

namespace TransactionService.Messaging
{
    public class ConsoleEventPublisher : IEventPublisher
    {
        public Task PublishTransactionCreatedEvent(TransactionCreatedEvent evt)
        {
            var json = JsonSerializer.Serialize(evt, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Console.WriteLine("Publishing TransactionCreatedEvent:");
            Console.WriteLine(json);

            return Task.CompletedTask;
        }
    }
}
