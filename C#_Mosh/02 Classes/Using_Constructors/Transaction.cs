
namespace Using_Constructors
{
    public class Transaction
    {
        // Fields
        public int Amount { get; set; }
        public DateTime Date { get; set; }

        public string Description { get; set; }
        public Transaction(int amount, DateTime date, string description)
        {
            Amount = amount;
            Date = date;
            Description = description;  
        }
    }
}
