using System;
using System.CodeDom;

namespace Structures_Net_Framework
{
    public struct MyStructure // <modifiers> <struct keyword> <name> { // Define members here ...}
    {
        // Fields
        //public int Number = 10;  // fields cannot be initialized at declaration time in C# version smaller than 10.0
        public int Number;  
        public string Sentence;

        /*
        public MyStructure() // cannot be explicitly define parameterless constructor in C# version smaller than 10.0
        {

        }
        */
        public MyStructure(int number , string sentence)
        {
            Number = number;
            Sentence = sentence;
        }


        // Methods
        public void Display()
        {
            Console.WriteLine($"Display method inside a structure : Number = {Number} , Sentence = {Sentence ?? "null"}");

        }
    }

    public struct Coords
    {
        // Fields
        public int X;
        public int Y;
    }
}
