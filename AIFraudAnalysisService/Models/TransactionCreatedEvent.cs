namespace AIFraudAnalysisService.Models
{
    public class TransactionCreatedEvent
    {
        public string TransactionId { get; set; }
        public string FromAccountId { get; set; }
        public string ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
