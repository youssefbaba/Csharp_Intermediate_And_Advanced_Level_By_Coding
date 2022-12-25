namespace Constructor_Part1
{
    internal class Program
    {
        // Fields
        int _value;
        string _text;
        bool _ischeck;
        static void Main(string[] args)
        {
            Program program = new Program(); // calling implicit constructor (parameterless constructor)
            Console.WriteLine($"Value = {program._value}");
            Console.WriteLine($"Text = {program._text ?? "null"}");
            Console.WriteLine($"Ischeck = {program._ischeck}");
        }
    }
}