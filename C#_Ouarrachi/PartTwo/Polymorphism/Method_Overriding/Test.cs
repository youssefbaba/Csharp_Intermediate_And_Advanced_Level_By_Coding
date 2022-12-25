namespace Method_Overriding
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Developer();
            Employee employee2 = new Designer();
            Employee employee3 = new Manager();
            employee1.Display();
            employee2.Display();
            employee3.Display();
        }
    }
}
