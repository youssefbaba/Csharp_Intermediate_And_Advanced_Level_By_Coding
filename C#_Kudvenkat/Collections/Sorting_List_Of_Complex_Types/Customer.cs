namespace Sorting_List_Of_Complex_Types
{
    public class Customer : IComparable<Customer>
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }

        
        // first way for comparison based on customer Balance : 
        public int CompareTo(Customer? other)
        {
            return Balance.CompareTo(other.Balance);
        }
        

        /*
        // second way for comparison based on customer Balance :  
        public int CompareTo(Customer? other)
        {
            if (Balance > other.Balance)
            {
                return 1;
            }
            else if (Balance < other.Balance)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        */


        /*
        // Comparison based on customer Name
        public int CompareTo(Customer? other)
        {
            return Name.CompareTo(other.Name);
        }
        */


    }
}
