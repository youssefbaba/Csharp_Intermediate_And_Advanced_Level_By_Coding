namespace PartialClassTest2
{
    public class Program
    {
        static void Main(string[] args)
        {

            /*
             - All the parts spread across different files , must use the partial keyword
             - All the parts spread across different files , must have the same access modifier
             - If any of the parts are declared abstract, then the entire type is considered abstract
             - If any of the part are declared sealed , then the entire type is considered sealed
             - If any of the parts inherit a class , then the entire type inherits that class
             - Csharp does not support multiple class inheritance , Different parts of the partial class , must not specify different base classes.
             - Different parts of the partial class can specify different base interfaces , and the final type implements all of the interface listed by all of the partial declarations
             - Any members that are declared in a partial definition are vailable to all of the other parts of the partial class
             */


            // SamplePartialClass obj = new SamplePartialClass();  // Error : SamplePartialClass is abstract , so we cannot create an instance of the abstract class
            SamplePartialClass obj = new SamplePartialClass();
            obj.Display();

            PartialCar car = new PartialCar();
            car.Print();
            car.Show();

            SamplePartialClass obj1 = new SamplePartialClass(1 , "David Geta");
            obj1.PrintData();


        }
    }
}