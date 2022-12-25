namespace Properties_Part0
{
    public class Employee
    {
        // Fields
        string _name;
        double _salary;


        // Constructors
        public Employee(string name , double salary)
        {
            _name = name;
            _salary = salary;
        }


        // Properties
        public string Name{ get { return _name; } }     // Read-only property
        public double Salary { set { _salary = value; } }   // Write-only property
    }
}
