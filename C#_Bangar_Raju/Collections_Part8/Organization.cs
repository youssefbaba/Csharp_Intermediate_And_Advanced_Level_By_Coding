using System.Collections;

namespace Collections_Part8
{
    public class Organization : IEnumerable
    {
        // Fields
        List<Employee> employees = new List<Employee>();


        // Methods
        public void Add(Employee emp)
        {
            employees.Add(emp);
        }
        /*
        public IEnumerator GetEnumerator()
        {
            return employees.GetEnumerator();
        }
        */
        public IEnumerator GetEnumerator()
        {
            return new OrganizationEnumerator(this);
        }


        // Properties 
        public int Counter
        {
            get
            {
                return employees.Count;
            }
        }


        // Indexers
        public Employee this[int index]
        {
            get
            {
                return employees[index];
            }
        }
    }
}
