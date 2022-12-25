namespace StaticClass
{
    public class InstanceClass
    {
        // Fields
        string _id;
        string _color;
        double _price;
        static int _numberSeat; // Static field


        // Constructors
        public InstanceClass() // Instance Constructor
        {
        }
        public InstanceClass(string id , string color , double price , int numberSeat) // Instance Constructor
        {
            _id= id;
            _color= color;  
            _price= price;
            Console.WriteLine($"Instance Constructor Invoked.");
        }
        static InstanceClass() // Static Constructor
        {
            _numberSeat = 4;
            Console.WriteLine($"Static Constructor Invoked.");
        }

        // Methods
        public void Test1() // Instance Method
        {
            Console.WriteLine("Instance Method.");
            // Some statement here ...
        }
        public static void Test2() // Static Method
        {
            Console.WriteLine("Static Method.");
            // Some statements here ...
        }

    }
}
