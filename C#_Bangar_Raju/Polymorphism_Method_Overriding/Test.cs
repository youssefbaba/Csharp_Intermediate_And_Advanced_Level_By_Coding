namespace Polymorphism_Method_Overriding
{
    internal class Test
    {
        static void Main(string[] args)
        {
            LoadChild child = new LoadChild();
            LoadParent parent = new LoadParent();

            child.Show();
            child.Show(10);
            child.Show("Hello");

            child.Test();
        }
    }
}