namespace Structures_Net_Core
{
    public class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Class -----");
            MyClass myClass = new MyClass(); // the new keyword is mendatory
            //MyClass myClass ; // Error because the new keyword is mendatory to declaring the instance of type class
            myClass.Display();



            Console.WriteLine("----- Struct -----");
            MyStructure myStructure = new MyStructure();  // the new keyword is only optional to declaring the instance of type structure
            myStructure.Display();


            MyStructure myStructure1;  // i don't use constructor
            myStructure1.Number = 100;
            myStructure1.Sentence = "Baba";
            myStructure1.Display();


            //MyStructure myStructure2; // No error because the new keyword is only optional
            //myStructure2.Display();

            MyStructure myStructure2 = new MyStructure(300 ,"John");
            myStructure2.Display();






        }
    }
}
