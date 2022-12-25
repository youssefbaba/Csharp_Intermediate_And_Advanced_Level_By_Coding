namespace Interfaces_Part1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(20, 10);
            obj.Sub(20, 10);

            //Interface1 interface1 = new Interface1();    // we cannot create an instance of interface


            /*
            Interface2 interface2 = new ImplementationClass();
            interface2.Add(20, 10);
            interface2.Sub(20, 10);


            Interface1 interface1 = new ImplementationClass();
            interface1.Add(20, 10);
            */




        }
    }
}