namespace Generics_Part0
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intNumbers = new int[] { 10, 5, 86, 3, 47, 65 };
            Console.WriteLine("Before Sorting : ");
            foreach (int item in intNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (int item in Sort(intNumbers))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            double[] doublenumbers = new double[] { 10.4, 5.1, 86.89, 3.4, 47.7, 65.49 };
            Console.WriteLine("Before Sorting : ");
            foreach (double item in doublenumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (double item in Sort(doublenumbers))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            string[] names = new string[] { "David", "Jim", "Sam", "Marks", "Adam", "Kaka" };
            Console.WriteLine("Before Sorting : ");
            foreach (string item in names)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (string item in Sort(names))
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            User[] users = new User[] {

                new User{Name ="David" , Age = 25 },
                new User{Name ="Jim" , Age = 18 },
                new User{Name ="Sam" , Age = 75 },
                new User{Name ="Marks" , Age = 45 },
                new User{Name ="Adam" , Age = 26 },
                new User{Name ="Kaka" , Age =  17},
            };
            Console.WriteLine("Before Sorting : ");
            foreach (User item in users)
            {
                Console.WriteLine($"Name = {item.Name} - Age = {item.Age}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Sorting : ");
            foreach (User item in Sort(users))
            {
                Console.WriteLine($"Name = {item.Name} - Age = {item.Age}");
            }
        }
        static int[] Sort(int[] intArray)
        {
            Array.Sort(intArray);
            return intArray;
        }
        static double[] Sort(double[] doubleArray)
        {
            Array.Sort(doubleArray);
            return doubleArray;
        }
        static string[] Sort(string[] stringArray)
        {
            Array.Sort(stringArray);
            return stringArray;
        }
        static User[] Sort(User[] users)
        {
            Array.Sort(users);
            return users;
        }
    }
}