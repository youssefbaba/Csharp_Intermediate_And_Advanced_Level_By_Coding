
namespace Object_Oriented_Programming
{
    public class Transaction
    {
        // Fields :
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        // Constructor : 
        public Transaction(decimal amount , DateTime date , string note )
        {
            Amount = amount;
            Date = date;
            Notes = note;
        }
    }
}
