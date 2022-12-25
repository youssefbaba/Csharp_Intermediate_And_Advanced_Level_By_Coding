using System.ComponentModel;

namespace Interfaces_Part1
{
    public class Calculator : Interface2  // Calculator class implements interface Interface2
    {
        // Methods
        // First way :
        public void Add(int number1, int number2)  // Implementaion which is mandatory
        {
            Console.WriteLine(number1 + number2);
        }
        public void Sub(int number1, int number2)  // Implementaion which is mandatory
        {
            Console.WriteLine(number1 - number2);
        }


        /*
        //Second way :
        void Interface1.Add(int number1, int number2)  // Accessible only by reference created by using instance of type Calculator
        {
            Console.WriteLine(number1 + number2);
        }
        void Interface2.Sub(int number1, int number2)  // Accessible only by reference created by using instance of type Calculator
        {
            Console.WriteLine(number1 - number2);
        }
        */
    }
}