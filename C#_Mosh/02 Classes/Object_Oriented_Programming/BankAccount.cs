
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Object_Oriented_Programming
{
    public class BankAccount
    {

        /*
            It has a 10-digit number that uniquely identifies the bank account.
            It has a string that stores the name or names of the owners.
            The balance can be retrieved.
            It accepts deposits.
            It accepts withdrawals.
            The initial balance must be positive.
            Withdrawals can't result in a negative balance.
         */

        // Fields : 
        public string Number { get; } // Read Only
        public string Owner { get; set; } // Read and Write
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (Transaction transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }
                return balance;
            }

        } // Read Only

        private static int accountNumberSeed = 1234567890;

        public List<Transaction> allTransactions = new List<Transaction>();

        // Constructor
        /*
         
            - The this keyword is only required when a local variable or parameter has the same name as that field or property.
            public BankAccount(string Owner , decimal Balance)
            {
                this.Owner = Owner;
                this.Balance = Balance;
            }

         */
        public BankAccount(string name, decimal initialBalance)
        {
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            Owner = name; // this keyword not necessary
            MakeDesposit(initialBalance, DateTime.Now, "Initial balance");
        }

        // Methods : 
        public void MakeDesposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive.");
            }
            Transaction desposit = new Transaction(amount, date, note);
            allTransactions.Add(desposit);
        }
        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive.");
            }
            if ((Balance - amount) < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            Transaction withDrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withDrawal);
        }

        public string GetAccountHistory()
        {
            StringBuilder report = new StringBuilder();
            decimal balance = 0;

            // Date\t\tAmount\tBalance\tNote
            report.AppendLine($"Date:\t\t\tAmount:\t\tBalence:\tNote:");
            foreach (Transaction transaction in allTransactions)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()}\t\t{transaction.Amount}\t\t{balance}\t\t{transaction.Notes}");
            }
            return report.ToString();
        }
    }
}
