namespace IComparable_IComparer_Interfaces_Part0
{
    public class Testcar
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(1, "Yellow", 150000.00);
            Car car2 = new Car(2, "Red", 100000.00);
            Car car3 = new Car(3, "Green", 140000.00);
            Car car4 = new Car(4, "Blue", 120000.00);
            Car car5 = new Car(5, "Pink", 90000.00);
            List<Car> listCars = new List<Car> { car1, car2, car3, car4, car5 };
            Console.WriteLine("Before Sorting : ");
            foreach (Car car in listCars)
            {
                Console.WriteLine($"Id = {car.Id} - Color = {car.Color} - Price = {car.Price}");
            }
            Console.WriteLine();
            listCars.Sort();
            Console.WriteLine("After Sorting the list based on price in ascending order : ");
            foreach (Car car in listCars)
            {
                Console.WriteLine($"Id = {car.Id} - Color = {car.Color} - Price = {car.Price}");
            }
            Console.WriteLine();
            listCars.Reverse();
            Console.WriteLine("After Sorting the list based on price in descending order : ");
            foreach (Car car in listCars)
            {
                Console.WriteLine($"Id = {car.Id} - Color = {car.Color} - Price = {car.Price}");
            }
            Console.WriteLine();
            listCars.Sort(new CompareCar());
            Console.WriteLine("After Sorting the list based on color in ascending order : ");
            foreach (Car car in listCars)
            {
                Console.WriteLine($"Id = {car.Id} - Color = {car.Color} - Price = {car.Price}");
            }
        }
    }
}
