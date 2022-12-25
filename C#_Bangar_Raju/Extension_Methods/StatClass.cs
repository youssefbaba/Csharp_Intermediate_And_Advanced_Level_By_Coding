namespace Extension_Methods
{
    public static class StatClass  // Mandatory is static
    {
        public static void Test3(this ExtensionMethods obj, int number)
        {
            Console.WriteLine($"Name = {obj.Name}");
            Console.WriteLine($"Method 3 : {number}");
        }

        public static long Factorial(this int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
        public static string ToProper(this string oldString)
        {
            if (oldString.Trim().Length > 0)
            {
                string newString = string.Empty;
                oldString = oldString.Trim().ToLower();
                string[] stringArray = oldString.Split(' ');
                foreach (string str in stringArray)
                {
                    newString = string.Concat(newString, string.Concat(string.Concat(str[0].ToString().ToUpper(), str.Substring(1)), " "));
                }
                return newString.Trim();
            }
            return oldString;
        }
    }
}
