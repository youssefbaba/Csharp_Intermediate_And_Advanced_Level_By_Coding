namespace IComparable_IComparer_Interfaces_Part1
{
    public class Customer : IComparable
    //public class Customer : IComparable<Customer>
    {
        // Properties 
        public int IdCustomer { get; set; }
        public string NameCustomer { get; set; }
        public double BalanceCustomer { get; set; }

        public int CompareTo(object? obj)
        {
            return BalanceCustomer.CompareTo(((Customer)obj).BalanceCustomer);
            
        }

        //public int CompareTo(Customer? other)
        //{
        //    return BalanceCustomer.CompareTo(other.BalanceCustomer);
        //}


    }
}
