namespace Object_Oriented_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes?WT.mc_id=csharpnotebook-35129-website
             */
            //BankAccount account = new BankAccount("Youssef", -1000); // Throw an exception because initial balance is negative
            BankAccount account = new BankAccount("Youssef", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance");

            //BankAccount account1 = new BankAccount("Hassna" , 2000);
            //Console.WriteLine($"Account {account1.Number} was created for {account1.Owner} with {account1.Balance} initial balance");

            //account.MakeDesposit(-500, DateTime.Now, "Stealing"); // Throw an exception because amount of deposit is negative
            account.MakeDesposit(500, DateTime.Now, "Payment for rent");

            //account.MakeWithDrawal(-200, DateTime.Now, "Sealing"); // Throw an exception because Amount of withdrawal is negative
            account.MakeWithDrawal(200, DateTime.Now, "Phone");

            Console.WriteLine(account.Balance);

            Console.WriteLine(account.GetAccountHistory());


            /*
             
             BankAccount acc = new BankAccount("Mohamed", 6000);

            // Test that the initial balances must be positive.
            try
            {
                BankAccount invalidAccount = new BankAccount("Invalid", -100);
            }
            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.Message);
                return;
            }

            // Test for a negative balance.
            try
            {
                acc.MakeWithDrawal(20000, DateTime.Now , "Test for negative balance");
            }
            catch (InvalidOperationException exp)
            {
                Console.WriteLine(exp.Message);
                return;
            }

            acc.MakeWithDrawal(200, DateTime.Now, "Phone");
            Console.WriteLine(acc.Balance);

             */






        }
    }
}