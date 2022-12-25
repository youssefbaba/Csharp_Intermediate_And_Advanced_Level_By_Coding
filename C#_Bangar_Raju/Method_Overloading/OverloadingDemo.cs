
using System.Globalization;

namespace Method_Overloading
{

    // Method overloading is a method with the same name but diffrent number or type or order or kind of (value , ref , out) parameters
    internal class OverloadingDemo
    {
        public void Test()
        {
            Console.WriteLine("First method");
        }
        public void Test(int value)
        {
            Console.WriteLine("Second method");
        }
        public void Test(string text)
        {
            Console.WriteLine("Third method");
        }
        public void Test(int value , string text)
        {
            Console.WriteLine("Fourth method");
        }
        public void Test( string text , int value)
        {
            Console.WriteLine("Fifth method");
        }
        public void Test(int[] values)
        {
            Console.WriteLine("Sixth method");
        }
        /*
         // return type and params keyword don't take in consideration for making overloading method
        public int Test(int[] values)
        {
            Console.WriteLine("Seventh method");
        }
                public void Test(params int[] values)
        {
            Console.WriteLine("Eighth method");
        }
         */
        public void Test(string text, out int value)
        {
            value = 0;
            Console.WriteLine("Ninth method");
        }

    }
}
