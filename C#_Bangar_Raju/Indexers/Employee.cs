namespace Indexers
{
    public class Employee
    {
        // Fields
        int _employeeId; // this field is private by default
        string _employeeName;
        string _job;
        double _salary;
        string _departementName;
        string _location;

        // Constructors
        public Employee(int employeeId, string employeeName, string job, double salary, string departementName, string location)
        {
            _employeeId = employeeId;
            _employeeName = employeeName;
            _job = job;
            _salary = salary;
            _departementName = departementName;
            _location = location;
        }


        /*
        
         - Indexers is a membere of class that make your instance behaves like an virtual array.

        <modifiers> <type> this[<parameters list>]
        {
          get { // Statements }  // Get Accessor
          set { // Statements }  // Set Accessor
        }

        */

        // Indexers
        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        return _employeeId;
                    case 2:
                        return _employeeName;
                    case 3:
                        return _job;
                    case 4:
                        return _salary;
                    case 5:
                        return _departementName;
                    case 6:
                        return _location;
                    default:
                        return null;
                }
            }

            set
            {
                switch (index)
                {
                    case 1:
                        _employeeId = (int)value; 
                        break;
                    case 2:
                        _employeeName = (string)value;
                        break;
                    case 3:
                        _job = (string)value;
                        break;
                    case 4:
                        _salary = (double)value; 
                        break;
                    case 5:
                        _departementName = (string)value;
                        break;
                    case 6:
                        _location = (string)value;
                        break;
                }
            }
        }
    }
}
