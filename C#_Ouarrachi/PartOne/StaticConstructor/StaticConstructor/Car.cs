namespace StaticConstructor
{
    public class Car
    {
        // Fields
        string _id;
        double _price;
        static int _numberSeat;


        // Constructors
        public Car()
        {
        }
        public Car(string id , double price)
        {
            Console.WriteLine("Instance Constructor Invoked.");
            _id = id;
            _price = price;
        }
        static Car()
        {
            Console.WriteLine("Static Constructor Invoked.");
            _numberSeat = 4;
        }

        public static void NumberSeat()
        {
            Console.WriteLine($"Number of Seat = {_numberSeat}");
        }
    }
}
