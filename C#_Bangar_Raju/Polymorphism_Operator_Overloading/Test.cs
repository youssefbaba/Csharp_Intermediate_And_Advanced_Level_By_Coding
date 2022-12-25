using System.Globalization;

namespace Polymorphism_Operator_Overloading
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------- Test1 --------------");

            Rectangle rectangle1 = new Rectangle(10, 20);
            Rectangle rectangle2 = new Rectangle(20, 40);
            Console.WriteLine(rectangle1 + rectangle2); // Width = 30 , Height = 60
            Console.WriteLine(rectangle1 * rectangle2);  // Width = 200 , Height = 800
            rectangle2 += rectangle1; // Implicit operator overloading  :  rectangle2 = rectangle2 + rectangle1
            Console.WriteLine(rectangle2);  // Width = 30 , Height = 60
            rectangle2 *= rectangle1; // Implicit operator overloading  :  rectangle2 = rectangle2 * rectangle1
            Console.WriteLine(rectangle2); // Width = 300 , Height = 1200
            Console.WriteLine(rectangle2++); // Width = 301 , Height = 1201
            Console.WriteLine(rectangle2--); // Width = 300 , Height = 1200
            Console.WriteLine(rectangle1 >= rectangle2); // False
            Console.WriteLine(rectangle1 <= rectangle2); // True
            Console.WriteLine(rectangle1 < rectangle2); // True
            Console.WriteLine(rectangle1 > rectangle2); // False
            Console.WriteLine("#######");
            Console.WriteLine(rectangle1 == rectangle2); // False
            Console.WriteLine(rectangle1 != rectangle2); // False
            rectangle1 = 10; // Implicit casting
            Console.WriteLine(rectangle1);  // Width = 10 , Height = 10
            string text = (string)rectangle2; // Explicit casting
            Console.WriteLine(text); // Width = 300 , Height = 1200

            Console.WriteLine("---------------- Test2 --------------");

            Fractional fractional1 = new Fractional(3, 2);
            Fractional fractional2 = new Fractional(4, 5);
            Console.WriteLine(fractional1);
            Console.WriteLine(fractional2);
            Console.WriteLine(fractional1 + fractional2);
            Console.WriteLine(fractional1 + 2);
            fractional1++;
            Console.WriteLine(fractional1);
            Console.WriteLine(fractional1 < fractional2);
            Console.WriteLine(fractional1 > fractional2);
            Console.WriteLine(fractional1 == fractional2);
            Console.WriteLine(fractional1 != fractional2);
            Fractional fractional3 = 10;
            Console.WriteLine(fractional3);
            double fractionalValue = (double)fractional2;
            Console.WriteLine(fractionalValue);

            Console.WriteLine("---------------- Test3 --------------");

            BankAcount bankAcount1 = new BankAcount(120 , "Youssef Baba");
            BankAcount bankAcount2 = new BankAcount(100 , "Mohamed Zidani");
            BankAcount bankAcount3 = bankAcount1 + bankAcount2;
            Console.WriteLine($"{nameof(bankAcount3)} : Owner : {bankAcount3.Owner} , Money = {bankAcount3.Money}");
            BankAcount bankAcount4 = bankAcount1 + 500;
            Console.WriteLine($"{nameof(bankAcount4)} : Owner : {bankAcount4.Owner} , Money = {bankAcount4.Money}");




        }
    }
}