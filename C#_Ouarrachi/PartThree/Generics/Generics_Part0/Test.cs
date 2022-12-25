namespace Generics_Part0
{
    public class Test
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

            GenericList<int> listIntNumbers = new GenericList<int>();
            listIntNumbers.Add(10);
            listIntNumbers.Add(20);
            listIntNumbers.Add(30);


            GenericList<double> listDoubleNumbers = new GenericList<double>();
            listDoubleNumbers.Add(10.5);
            listDoubleNumbers.Add(20.8);
            listDoubleNumbers.Add(30.9);


            GenericList<string> listNames = new GenericList<string>();
            listNames.Add("David");
            listNames.Add("Marks");
            listNames.Add("Jim");


            GenericList<User> listUsers = new GenericList<User>();
            listUsers.Add(new User { Name = "David", Age = 25 });
            listUsers.Add(new User { Name = "Jim", Age = 18 });
            listUsers.Add(new User { Name = "Sam", Age = 75 });


            GenericDictionary<string, User> dictionaryUsers = new GenericDictionary<string, User>();
            dictionaryUsers.Add("David", new User { Name = "David", Age = 25 });
            dictionaryUsers.Add("Jim", new User { Name = "Jim", Age = 18 });
            dictionaryUsers.Add("Sam", new User { Name = "Sam", Age = 75 });


        }
        static T[] Sort<T>(T[] intArray)   // Generic method
        {
            Array.Sort(intArray);
            return intArray;
        }

        static bool AreEquals<T, U>(T value1, U value2)
        {
            return value1.Equals(value2);
        }
        static void ReturnTypes<T, U, V>(T value1, U value2 , V value3)
        {
            Console.WriteLine($"type of T = {value1.GetType().Name} , type of U = {value2.GetType().Name} , type of V = {value3.GetType().Name}");
        }

    }
}
