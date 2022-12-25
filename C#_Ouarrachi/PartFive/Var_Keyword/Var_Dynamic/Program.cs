namespace Var_Dynamic
{
    public class Program
    {
        static void Main(string[] args)
        {
            object testObject;
            dynamic testDynamic; // under the hood dynamic dynamic behaves like object type
            //var testVar; // compile-time error , because implicitly typed variable must be initialized.


            /*
            var testVar = 2;        // Compile-time error , because we cannot change testVar from int to double (strongly typed)
            testVar = 3.1;
            */

            var testVar = 2.1;
            testVar = 3.1;


            testDynamic = 1;
            testDynamic = testDynamic + 2.1;
            Console.WriteLine(testDynamic);

            try
            {
                testDynamic.SayHi();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            //testVar.SayHi();    //  Compile-time error, because double does not contain a definition of SayHi method


            dynamic testDynamic1 = new Person();
            var testVar1 = new Person();


            testDynamic1.FirstName = "David";  // There is no intellisense here , and type checking is enforced at run-tiem
            testDynamic1.LastName = "Huge";
            testDynamic1.SayHello();


            testVar1.FirstName = "Marks";     // There is an intellisense here , and type checking is enforced at compile-time
            testVar1.LastName = "Gavi";
            testVar1.SayHello();

            testDynamic1 = "Hi"; // No error , all things correct.
            //testVar1 = "Hi";     // Compile-time error , because we cannot implicitly convert string to Person
            Console.WriteLine(testDynamic1);


            dynamic testDynamic2 = "";
            var testVar2 = "";


            Console.WriteLine(GetMessage());


            var testVar3 = 1.1M;
            decimal myMoney = 1.1M;


            List<List<Person>> rounds = new List<List<Person>>();  // long names of type , so we can use var keyword in this case
            foreach (List<Person> round in rounds)
            {
            }
            var rounds1 = new List<List<Person>>();  // mush simpler and sweet
            foreach (var round in rounds1)
            {
            }


            var myItem = new { FirstName = "John", Email = "John@gmail.com" };  // Anonymous Type , we can use var keyword in this case
            Console.WriteLine($"Hello {myItem.FirstName} your email is {myItem.Email}");


            var myObject = new[]
            {
                new { FirstName = "John", Email = "John@gmail.com" },
                new { FirstName = "David", Email = "David@gmail.com" },
                new { FirstName = "Sam", Email = "Sam@gmail.com" }
            };      // Anonymous Collection , we can use var keyword in this case
            foreach (var item in myObject)
            {
                Console.WriteLine($"FirstName = {item.FirstName} - Email =  {item.Email}");
            }

            string[] cars = new string[] { "Toyota", "Honda", "Fiat", "Ford" };
            var selectedCars = from car in cars where car.Length >= 5 select new { Name = car, Len = car.Length };  // LINQ , we can use var keyword in this case
            foreach (var car in selectedCars)
            {
                Console.WriteLine($"Name = {car.Name} - Length = {car.Len}");
            }

        }
        //static var GetMessage()  // we cannot use var as retutn type of method , because it can't infer it based on signature of method
        static dynamic GetMessage()  // we can use dynamic as retutn type of method.
        {
            return "This is a test";
        }
    }
}