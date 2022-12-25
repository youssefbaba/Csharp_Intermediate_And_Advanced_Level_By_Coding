namespace IComparable_IComparer_Interfaces_Part0
{
    public class TestNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(103);
            numbers.Add(106);
            numbers.Add(101);
            numbers.Add(105);
            numbers.Add(102);
            numbers.Add(104);
            Console.WriteLine("Before sorting the list of numbers : ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            numbers.Sort();
            Console.WriteLine("After sorting the list of numbers in ascending order : ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            numbers.Reverse();
            Console.WriteLine("After sorting the list of numbers in descending order : ");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }


            List<string> names = new List<string>();
            names.Add("David");
            names.Add("Sam");
            names.Add("Jim");
            names.Add("Adam");
            Console.WriteLine("Before sorting the list of names : ");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
            names.Sort();
            Console.WriteLine("After sorting the list of names in ascending order : ");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }
            Console.WriteLine();
            names.Reverse();
            Console.WriteLine("After sorting the list of names in descending order : ");
            foreach (string name in names)
            {
                Console.Write($"{name} ");
            }

        }
    }
}