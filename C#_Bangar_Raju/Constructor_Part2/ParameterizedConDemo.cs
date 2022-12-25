namespace Constructor_Part2
{
    internal class ParameterizedConDemo
    {
        // Fields
        int _age; // default value of age is 0
        string _name; // default value of name is null

        // Constructors
        public ParameterizedConDemo() // Explicit parameterless constructuor (overload1)
        {
        }
        public ParameterizedConDemo(int age , string name) // Explicit Paramerterized constructor (overload2)
        {
            Console.WriteLine($"Parameterized constructor is called");
            _age = age;
            _name = name;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Age = {_age} , Name = {_name ?? "null"}");
        }
        static void Main()
        {
            ParameterizedConDemo parameterizedConDemo1 = new ParameterizedConDemo();
            ParameterizedConDemo parameterizedConDemo2 = new ParameterizedConDemo(25 ,"Youssef Baba");
            ParameterizedConDemo parameterizedConDemo3 = new ParameterizedConDemo(30 , "Mohamed Zidani");

            parameterizedConDemo1.Display();
            parameterizedConDemo2.Display();    
            parameterizedConDemo3.Display();    
        }
    }
}
