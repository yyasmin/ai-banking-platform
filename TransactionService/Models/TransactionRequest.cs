namespace TransactionService.Models
{
    public class TransactionRequest
    {
        public string FromAccountId { get; set; }
        public string ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Location { get; set; }
    }
}
