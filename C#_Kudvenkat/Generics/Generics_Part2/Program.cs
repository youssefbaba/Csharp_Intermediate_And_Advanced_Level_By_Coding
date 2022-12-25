namespace Generics_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] array = new int[] { 5, 3, 8, 4, 6 };
            //string[] array = new string[] { "Toyota", "Honda", "Ford", "BMW" };
            Employee[] array = new Employee[] {
                new Employee { Id = 5 , Name = "John"},
                new Employee { Id = 3 , Name = "Marks"},
                new Employee { Id = 8 , Name = "David"},
                new Employee { Id = 4 , Name = "Daniel"},
                new Employee { Id = 6 , Name = "Sam"}
            };


            //SortArray<int> sortArray = new SortArray<int>();
            //SortArray<string> sortArray = new SortArray<string>();
            SortArray<Employee> sortArray = new SortArray<Employee>();
            sortArray.BubbleSort(array);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}