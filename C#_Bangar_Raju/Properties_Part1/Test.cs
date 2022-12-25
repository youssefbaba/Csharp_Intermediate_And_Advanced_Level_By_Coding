namespace Properties_Part1
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Console.WriteLine($"Old radius = {circle.Radius}");  // Calling the get accesor of property
            //circle.Radius = 10.21;
            circle.Radius = 50.12; // Calling the set accesor of property
            Console.WriteLine($"New radius = {circle.Radius}");
            

         
        }
    }
}