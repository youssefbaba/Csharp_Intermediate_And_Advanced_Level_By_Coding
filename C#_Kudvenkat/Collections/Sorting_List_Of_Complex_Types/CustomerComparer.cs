namespace Sorting_List_Of_Complex_Types
{
    public class CustomerComparer : IComparer<Customer>
    {
        // Comparison based on Customer Name :
        public int Compare(Customer? customer1, Customer? customer2)
        {
            return customer1.Name.CompareTo(customer2.Name);
        }

    }
}
