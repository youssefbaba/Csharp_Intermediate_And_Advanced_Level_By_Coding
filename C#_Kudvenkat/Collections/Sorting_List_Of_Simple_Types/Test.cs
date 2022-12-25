namespace Sorting_List_Of_Simple_Types
{
    public class Test
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };
            Console.WriteLine("------ Numbers Before Sorting ------");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            


            Console.WriteLine("------ Numbers After Sorting in ascending order ------");
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("------ Numbers After Sorting in descending order------");
            numbers.Reverse();
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine();


            List<string> cars = new List<string> { "Toyota", "Honda", "Ford", "Fiat", "Peugeot", "Renault" };
            Console.WriteLine("------ Cars Before Sorting ------");
            foreach (string car in cars)
            {
                Console.Write($"'{car}' ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("------ Cars After Sorting in ascending order ------");
            cars.Sort();
            foreach (string car in cars)
            {
                Console.Write($"'{car}' ");
            }
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("------ Numbers After Sorting in descending order------");
            cars.Reverse();
            foreach (string car in cars)
            {
                Console.Write($"'{car}' ");
            }
            Console.WriteLine();
            Console.WriteLine();







        }
    }
}