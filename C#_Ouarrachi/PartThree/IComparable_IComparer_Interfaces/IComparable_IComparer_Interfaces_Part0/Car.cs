namespace IComparable_IComparer_Interfaces_Part0
{

    public class Car : IComparable<Car>
    {
        // Constructors
        public Car(int id, string color, double price)
        {
            Id = id;
            Color = color;
            Price = price;
        }


        // Methods
        // First Way
        public int CompareTo(Car? other)
        {
            return Price.CompareTo(other.Price);
        }

        /*
        // Second Way
        public int CompareTo(Car? other)
        {
            if (Price == other.Price)
            {
                return 0;
            }
            if (Price < other.Price)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        */

        // Properties
        public int Id { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

    }
    //public class Car : IComparable
    //{
    //    // Constructors
    //    public Car(int id, string color, double price)
    //    {
    //        Id = id;
    //        Color = color;
    //        Price = price;
    //    }


    //    // Methods

    //    // First Way
    //    public int CompareTo(object? obj)
    //    {
    //        Car car = obj as Car;
    //        return Price.CompareTo(car.Price);
    //    }


    //    /*
    //    // Second Way
    //    public int CompareTo(object? obj)
    //    {

    //        Car car1 = obj as Car;
    //        Car car2 = obj as Car;
    //        if (car1.Price == car2.Price)
    //        {
    //            return 0;
    //        }
    //        if (car1.Price < car2.Price)
    //        {
    //            return -1;
    //        }
    //        else
    //        {
    //            return 1;
    //        }
    //    }
    //    */

    //    // Properties
    //    public int Id { get; set; }
    //    public string Color { get; set; }
    //    public double Price { get; set; }

    //}
}
