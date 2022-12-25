
using System.Threading.Tasks.Sources;

namespace kinds_Of_Variable_In_A_Class
{
    internal class VariablesDemo
    {

        /*
         - Instance variables
         - Static variables
         - Constants variables
         - Readonly variables
         - The memory of instance variable is going to be allocated only if i create instance of the class.
         - Static variable is initialized immediately once the execution of a class start.
         - The behavior of constant variable is similar to the behavior of static variable
         - The only difference between constant variable and static variable is static variable can be modified where as constant variable cannot be modified
         - The behavior of Readonly variable is similar to the behavior of Instance variable
         - The only difference between Readonly variable and Instance variable is Instance variable can be modified where as Readonly variable cannot be modified after initialization of it
         - Single copy : Static variable , Constant variable
         - Multiple copy :  Instance variable , Readonly variable
         - Single copy modifiable : Static variable
         - Single copy not modifiable : Constant variable
         - Multiple copy modifiable : Instance variable
         - Multiple copy not modifiable : Readonly variable

         */

        // Fields
        public int InstanceVariable; // Instance variable
        public static int StaticVariable; // Static variable 
        static int _counter = 0;
        public const float Pi = 3.14f;  // Constant variable
        public readonly bool Flag;  // Readonly variable

        // Constructors
        static VariablesDemo() // Static constructor
        {
            Console.WriteLine("Static constructor is called.");
            StaticVariable = 2000;
        }
        public VariablesDemo(int instanceVariable , bool flag) // Instance constructor
        {
            InstanceVariable = instanceVariable;
            Flag = flag;
            Console.WriteLine($"Object {_counter} is created.");
            _counter++;
        }

        // Methods
        public static void Print()
        {
            string staticVariable; // Static variable because i declare it under static block

            Console.WriteLine(StaticVariable);
            VariablesDemo variablesDemo = new VariablesDemo(120 , false);
            Console.WriteLine(variablesDemo.InstanceVariable);
            Console.WriteLine(Pi);
            Console.WriteLine(variablesDemo.Flag);
        }
        public void Display()
        {
            Console.WriteLine(StaticVariable);
            Console.WriteLine(InstanceVariable);
            Console.WriteLine(Pi);
            Console.WriteLine(Flag);
        }
    }
}
