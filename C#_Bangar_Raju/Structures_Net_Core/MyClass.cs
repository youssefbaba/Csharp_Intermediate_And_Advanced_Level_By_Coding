namespace Structures_Net_Core
{
    public class MyClass
    {
        // Fields
        public int Number = 10;
        public string Sentence;

        // Methods
        public void Display()
        {
            Console.WriteLine($"Display method inside a class : Number = {Number} , Sentence = {Sentence ?? "null"}");
        }
    }
}
