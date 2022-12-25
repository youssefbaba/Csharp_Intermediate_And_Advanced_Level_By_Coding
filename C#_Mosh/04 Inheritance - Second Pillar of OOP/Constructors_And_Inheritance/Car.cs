namespace Constructors
{
    public class Car : Vehicle
    {
        // Constructors
        public Car()
        {
            Console.WriteLine("Car is being initialized.");
        }

        //public Car(string registrationNumber)  // => public Car(string registrationNumber):base()
        //{
        //    Console.WriteLine($"Car is being initialized. {registrationNumber}");
        //}

        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine($"Car is being initialized. {registrationNumber}");
        }
    }
}
