namespace Collections_Part0
{
    public class ListCollection
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(89);
            numbers.Add(2);
            numbers.AddRange(new List<int> { 100, 48, 3, 46, 71 });
            numbers[8] = 1;
            int number = numbers[8];
            Console.WriteLine(number);
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            numbers.Insert(3, 189);
            numbers.InsertRange(6, new List<int> { 13, 75, 46 });
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            numbers.Remove(89);
            numbers.RemoveAt(4);
            numbers.RemoveRange(2, 4);
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            numbers.AddRange(new List<int> { 100, 18, 79 });
            Console.WriteLine($"Max value in the list = {numbers.Max()}");
            Console.WriteLine($"Min value in the list = {numbers.Min()}");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            numbers.Sort();
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            numbers.Reverse();
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}