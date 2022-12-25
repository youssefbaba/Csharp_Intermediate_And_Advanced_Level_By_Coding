namespace Collections_Part6
{
    public class CompareEmployee : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x.Salary > y.Salary)
            {
                return 1;
            }
            else if (x.Salary < y.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
