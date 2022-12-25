namespace Interfaces_Part1
{
    internal interface Interface1
    {
        // Fields
        static int Age;
        //string Name; Interfaces connot contain instance fields


        // Methods
        void Add(int number1, int number2); // by default it is public and abstract.
    }
}
