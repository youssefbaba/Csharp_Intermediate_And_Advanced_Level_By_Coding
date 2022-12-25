namespace PrintDataBase
{
    public class Employee
    {
        // Fields
        private string _employeeName;


        // Methods
        public void Print() 
        {
            Console.WriteLine("Printing from PrintDataBase");
        }
        public string GetName() 
        {
            return $"{_employeeName}";
        }
        public void PrintName()
        {
            Console.WriteLine($"Employee Name passed as {_employeeName}");
        }
        private void PrintPrivate()
        {
            Console.WriteLine($"Printing from PrintDataBasePrivate");
        }


        // Properties
        public string EmployeeName { get => _employeeName; }
        public static string StaticEmployeeName { get => "Static property employeeName"; }
    }
}