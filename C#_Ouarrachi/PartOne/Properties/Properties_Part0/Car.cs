namespace Properties_Part0
{
    public class Car
    {
        //Fields
        string _id;
        string _color;
        double _price;
        static int _numberSeat;


        // Constructors
        public Car(string id, string color, double price)
        {
            _id = id;
            _color = color;
            _price = price;
        }


        // Properties
        public int Id { get; }  // Read-only auto-implemented property
        public string Color { get; set; }  // Read-Write auto implemented property
        //public double Price {set; }   // Compiletime error : Auto-implemented properties must have get accessors
        public double Price { get; set; }  // Read-Write auto implemented property
        public static int NumberSeat { get; set; } = 4;
    }
}
