namespace System
{
    public static class StringExtensions
    {
        public static string Shorten(this string str, int numberWords)
        {
            if (numberWords < 0)
            {
                throw new ArgumentOutOfRangeException("The number of words should be greater than or equal zero.");
            }
            if (numberWords == 0)
            {
                return string.Empty;
            }
            string[] words = str.Split(' ');
            if (words.Length <= numberWords)
            {
                return str;
            }
            return string.Join(" ", words.Take(numberWords)) + "...";
        }
    }
}