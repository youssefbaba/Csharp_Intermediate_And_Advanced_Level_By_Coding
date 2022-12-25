namespace PartialClassTest2
{
    public partial class PartialCar : IVehicle
    {
        public void Show()
        {
            Console.WriteLine("Vehicle");
        }
    }
}
