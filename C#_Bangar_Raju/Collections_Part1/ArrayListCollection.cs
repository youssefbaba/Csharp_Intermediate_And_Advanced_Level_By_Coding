using System.Collections;

namespace Collections_Part1
{
    public class ArrayListCollection
    {
        static void Main(string[] args)
        {

            /*
             
             - Array :
                - Fixed length ( Not possible to increase the size of array )
                - Not possible to insert items into the middle of the array
                - Not possible to delete or Remove items from the middle of the array
             - Collections : 
                - Variable length ( It is possible to increase the size of collection )
                - we can insert items into the middle of collection
                - we can delete or Remove items from the middle of collection
            
             
             */
            int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            Console.Write("array1 : ");
            foreach (int item in array1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            int[] array2 = new int[10];
            Array.Copy(array1 , array2 , array1.Length);
            Console.Write("array2 : ");
            foreach (int item in array2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            Array.Resize(ref array1, 10);
            Console.Write("array3 : ");
            foreach (int item in array1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.WriteLine("<---------------------------------------------------->");

            //ArrayList arrayList = new ArrayList(3);  // capacity = 3 6 12 24 ........  
            ArrayList arrayList = new ArrayList();  // capacity = 0 4 8 16 32 .........
            Console.WriteLine($"Capacity of arrayList : {arrayList.Capacity}");
            Console.Write($"arrayList : [ ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            arrayList.Add(100);
            arrayList.Add(200);
            Console.WriteLine($"Capacity of arrayList : {arrayList.Capacity}");
            Console.Write($"arrayList : [ ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            arrayList.Add("Youssef");
            Console.WriteLine($"Capacity of arrayList : {arrayList.Capacity}");
            Console.Write($"arrayList : [ ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            arrayList.Add(300);
            arrayList.Add(400);
            arrayList.Add(500);
            Console.WriteLine($"Capacity of arrayList : {arrayList.Capacity}");
            Console.Write($"arrayList : [ ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            arrayList.Insert(3, 250);
            Console.Write($"arrayList : [ ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"]");
            Console.WriteLine();
            //arrayList.Remove("Youssef");
            arrayList.RemoveAt(2);
            Console.Write($"arrayList : [ ");
            foreach (var item in arrayList)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"]");
            Console.WriteLine();







        }
    }
}