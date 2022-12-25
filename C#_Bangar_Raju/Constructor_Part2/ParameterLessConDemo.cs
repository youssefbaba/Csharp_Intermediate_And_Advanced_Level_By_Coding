namespace Constructor_Part2
{
    class ParameterLessConDemo // by default is internal
    {
        // Fields 
        int _amount; // by default is private
        string _name; // by default is private

        // Methods
        void Display() // by default is private
        {
            Console.WriteLine($"Value of amount is = {_amount} and name is = {_name ?? "null"}");
        }
        static void Main()
        {
            ParameterLessConDemo parameterLessConDemo = new ParameterLessConDemo();
            parameterLessConDemo.Display();
            Console.WriteLine("----------------------------");
            ParameterLessConDemoTwo parameterLessConDemoTwo = new ParameterLessConDemoTwo();
            parameterLessConDemoTwo.Print();

        }
    }
    class ParameterLessConDemoTwo // by default is internal
    {
        // Fields 
        int _number;  // by default is private
        bool _ischeck; // by default is private

        // Constructors
        public ParameterLessConDemoTwo() // Explicit parameter less constructor called
        {
            Console.WriteLine("Explicit parameter less constructor called");
        }

        // Methods
        public void Print()
        {
            Console.WriteLine($"Value of number is = {_number} and ischeck = {_ischeck}");
        }
    }
}
