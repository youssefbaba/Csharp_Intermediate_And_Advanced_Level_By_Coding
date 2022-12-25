namespace Interfaces_Part2
{
    internal class Test
    {
        static void Main(string[] args)
        {
            MultipleInheritance multipleInheritance = new MultipleInheritance();
            multipleInheritance.Test();

            Interface1 interface1 = new MultipleInheritance();
            Interface2 interface2 = new MultipleInheritance();
            interface1.Show();
            interface2.Show();

        }
    }
}