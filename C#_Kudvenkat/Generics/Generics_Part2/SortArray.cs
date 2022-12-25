namespace Generics_Part2
{
    internal class SortArray<T> where T : IComparable<T>
    {
        public void BubbleSort(T[] array) 
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0) 
                    {
                        Swap(array, j);
                    }
                }
            }
        }
        private static void Swap(T[] array, int j)
        {
            T temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
