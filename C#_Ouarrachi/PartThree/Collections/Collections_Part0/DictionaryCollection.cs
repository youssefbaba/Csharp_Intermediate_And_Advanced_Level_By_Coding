namespace Collections_Part0
{
    public class DictionaryCollection
    {
        static void Main(string[] args)
        {
            // for dictionary key must be unique
            Dictionary<int, string> dictionaryYears = new Dictionary<int, string>();
            dictionaryYears.Add(1, "January"); 
            dictionaryYears.Add(2, "February"); 
            dictionaryYears.Add(3, "March"); 
            dictionaryYears.Add(4, "April"); 
            dictionaryYears.Add(5, "May");
            dictionaryYears.Add(6, "June");
            dictionaryYears.Add(7, "Not Found");
            dictionaryYears[7] = "July";
            Console.WriteLine($"Seventh month is = {dictionaryYears[7]}");
            Console.WriteLine($"Number of elements = {dictionaryYears.Count}");
            Console.WriteLine("Display elements by using keys : ");
            foreach (int key in dictionaryYears.Keys)
            {
                Console.WriteLine($"{key} : {dictionaryYears[key]}");
            }
            Console.WriteLine("Display elements by using values : ");
            foreach (string value in dictionaryYears.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("Display elements by using keyvalue : ");
            foreach (KeyValuePair<int , string> keyValue in dictionaryYears)
            {
                Console.WriteLine($"{keyValue.Key} : {keyValue.Value}");
            }
            Console.WriteLine();
            dictionaryYears.Remove(7);
            foreach (int key in dictionaryYears.Keys)
            {
                Console.WriteLine($"{key} : {dictionaryYears[key]}");
            }
            Console.WriteLine();
            dictionaryYears.Clear();
            foreach (int key in dictionaryYears.Keys)
            {
                Console.WriteLine($"{key} : {dictionaryYears[key]}");
            }


        }
    }
}