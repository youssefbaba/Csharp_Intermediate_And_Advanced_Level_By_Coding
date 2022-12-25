namespace kinds_Of_Variable_In_A_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VariablesDemo.Print();
            VariablesDemo variablesDemo1 = new VariablesDemo(100 , false);
            VariablesDemo variablesDemo2 = new VariablesDemo(200 , true);
            variablesDemo1.Display();
            variablesDemo2.Display();
            Console.WriteLine(variablesDemo1.InstanceVariable);
            Console.WriteLine(variablesDemo2.InstanceVariable);
            Console.WriteLine(variablesDemo1.Flag);
            Console.WriteLine(variablesDemo2.Flag);
            Console.WriteLine(VariablesDemo.StaticVariable);
            Console.WriteLine(VariablesDemo.Pi);
        }
    }
}