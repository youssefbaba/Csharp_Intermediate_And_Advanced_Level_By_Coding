using System.Collections;

namespace Collections_Part1
{
    public class ArrayListCollection
    {
        static void Main(string[] args)
        {
            // First way to increase the size of an array :
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[numbers.Length * 2];
            numbers.CopyTo(numbers2, 0);
            numbers2[0] = 6;
            for (int i = 0; i < numbers2.Length; i++)
            {
                Console.WriteLine(numbers2[i] );
            }


            Console.WriteLine();

            // Second way to increase the size of an array :
            int[] values = new int[5] { 10, 20, 30, 40, 50 };
            Array.Resize(ref values, values.Length * 2);
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine();

            ArrayList arrayList = new ArrayList(); // starts from 0 and then 4 and then 4*2=8 and then 8*2=16 and then 16*2=32 and so on .....
            Console.WriteLine($"Capacity = {arrayList.Capacity}"); // 0
            Console.WriteLine($"Count = {arrayList.Count}"); // 0
            arrayList.Add(10);
            Console.WriteLine($"Capacity = {arrayList.Capacity}"); // 4 
            Console.WriteLine($"Count = {arrayList.Count}"); // 1
            arrayList.AddRange(new ArrayList { "Hello", true, null, 'c', new Program() });
            Console.WriteLine($"Capacity = {arrayList.Capacity}"); // 8 
            Console.WriteLine($"Count = {arrayList.Count}"); // 6
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine($"Item {i} = {arrayList[i]}");
            }

            Console.WriteLine();

            ArrayList arrayList1 = new ArrayList(3); // starts from 3 and then 3*2=6 and then 6*2=12 and then 12*2=24 and so on .....
            Console.WriteLine($"Capacity = {arrayList1.Capacity}"); // 3
            Console.WriteLine($"Count = {arrayList1.Count}"); // 0
            arrayList1.Add(10);
            Console.WriteLine($"Capacity = {arrayList1.Capacity}"); // 3
            Console.WriteLine($"Count = {arrayList1.Count}"); // 1
            arrayList1.AddRange(new ArrayList { "Hello", true, null, 'c', new Program() });
            Console.WriteLine($"Capacity = {arrayList1.Capacity}"); // 6 
            Console.WriteLine($"Count = {arrayList1.Count}"); // 6
            arrayList1.Add(12.5);
            Console.WriteLine($"Capacity = {arrayList1.Capacity}"); // 12
            Console.WriteLine($"Count = {arrayList1.Count}"); // 7
            int index = 0;
            Console.WriteLine("Display items of arrayList1 before inserting item into the middle : ");
            foreach (object item in arrayList1)
            {
                Console.WriteLine($"item {index} = {item}");
                index++;
            }
            arrayList1.Insert(3, 300.5);
            //arrayList1.InsertRange(3, new ArrayList { 100, "World", false, 'b' });
            index = 0;
            Console.WriteLine("Display items of arrayList1 after inserting an item into the middle : ");
            foreach (object item in arrayList1)
            {
                Console.WriteLine($"item {index} = {item}");
                index++;
            }
            arrayList1.Remove(null);
            //arrayList1.RemoveAt(4);
            //arrayList1.RemoveRange(4, 3);
            index = 0;
            Console.WriteLine("Display items of arrayList1 after removing an item from the middle : ");
            foreach (object item in arrayList1)
            {
                Console.WriteLine($"item {index} = {item}");
                index++;
            }
        }
    }
}
