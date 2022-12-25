namespace PartialClassTest2
{
    public partial class PartialCar : ITruck
    {
        public void Print()
        {
            Console.WriteLine("Truck");
        }
    }
}
