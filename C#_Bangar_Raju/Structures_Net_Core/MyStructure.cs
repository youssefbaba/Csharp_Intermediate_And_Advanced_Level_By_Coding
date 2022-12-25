namespace Structures_Net_Core
{
    public struct MyStructure // <modifiers> <struct keyword> <name> { // Define members here ...}
    {
        // Fields
        public int Number = 30;
        public string Sentence;

        // Constuctors
        public MyStructure() // in C# 10.0 or greater we can define explicitly parameterless constructor
        {
            Sentence = "Undefined";
        }
        public MyStructure(int number , string sentence)
        {
            Number = number;
            Sentence = sentence;
        }

        // Methods
        public void Display()
        {
            Console.WriteLine($"Display method inside a class : Number = {Number} , Sentence = {Sentence ?? "null"}");
        }
    }
}
