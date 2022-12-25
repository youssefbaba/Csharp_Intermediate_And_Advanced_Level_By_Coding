using System;
namespace Structures_Net_Framework
{
    public class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Class -----");
            MyClass myClass = new MyClass();  // the new keyword is mandatory
            //MyClass myClass;  // Error because the new keyword is mandatory to creating the instance of type class
            myClass.Display();



            Console.WriteLine("----- Struct -----");
            //MyStructure myStructure = new MyStructure(); // new keyword is only optional to creating the instance of type structure
            MyStructure myStructure = new MyStructure(); // here we use only implicit parameterless constructor to initialize struct's fields
            myStructure.Display();


            MyStructure myStructure1 = new MyStructure(); // here we use implicit parameterless constructor and assignement to initialize struct's fields
            myStructure1.Number = 30;
            myStructure1.Display();


            MyStructure myStructure2;
            //myStructure1.Display(); // Error because doesn't initiaze the Number and Sentence fields
            myStructure2.Number = 40;
            myStructure2.Sentence = "Youssef";
            myStructure2.Display();



            //MyStructure myStructure3; // No error because the new keyword is only optional
            //myStructure3.Display();


            MyStructure myStructure4 = new MyStructure(200 , "Hello");
            myStructure4.Display();




            Coords coords;
            //Console.WriteLine($"X = {coords.X} , Y = {coords.Y}"); //  Error because i use unassigned local variable
            coords.X = 2;
            coords.Y = 4;
            Console.WriteLine($"X = {coords.X} , Y = {coords.Y}");





        }
    }
}
