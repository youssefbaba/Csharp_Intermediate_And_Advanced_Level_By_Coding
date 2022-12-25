namespace Var_Keyword_Part2
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             
             - var keyword is an implicit way to defining data type , in simple words var keyword looks at the right hand side and accordingly creates data type at left hand side.
             - var keyword define data type statically (cannot be changed) and not on run-time.
             - Use of var keyword :
                - Use var keyword when you have long type names (code unreadable) , makes code more readable .
                - Use of var keyword when you're not sure about type of data will be stored in a variable.
                - The var keyword was created to handle declarations when the type is not known , such as generics types , lambdas and query expressions.
                - Use in Anonymous Types and Anonymous Collections.    
             - Restrictions :
                - var keyword cannot be used on fields at class scope.
                - var typed variable cannot bi initialized with a null value.
                - var typed variable cannot be used as method parameters or as a return type of method.
                - Don't use var for simple local variable types that are knonw to you.

            */

            int value1 = 10;    // Explicit(direct) declaration of data type , we are directly defining the data type.
            var value2 = 20;    // Implicit(Undirect) declaration of data type , the compiler looks at the data which is present at right hand side and creates appropriate data type during the compilation process.
            //var amount = null;    // Compile-time error , because the variable that has var keyword cannot bi initialized with a null value.

            // var keyword is not something like object which can point towards any other data during run-time , it is strongly typed :
            var value3 = "Hello World";  // value3 is string data type
            //value3 = 10;                // Compile-time error ,  because we connot change the type of value3 from string to int , value3 it's going to store only string values.
            value3 = "qwerty";
            Console.WriteLine(value3);
            object object1 = 123;
            Console.WriteLine($"Type = {object1.GetType().Name} - Value = {object1}");
            object1 = "azerty";
            Console.WriteLine($"Type = {object1.GetType().Name} - Value = {object1}");
            object1 = true;
            Console.WriteLine($"Type = {object1.GetType().Name} - Value = {object1}");


            // Explicit defining data types are simpler and more readable as compare to the implicit definititon of data type :
            string name = "Youssef Baba";   // more simpler and readable , in this case using fixed type is best practice.
            var fullName = "Youssef Baba";  // unreadbale , in this case using var keyword is bad practice.


            // Use var keyword when you have long type names (code unreadable) , makes code more readable : 
            SomeBigClassToDoSomething<string, int> obj = new SomeBigClassToDoSomething<string, int>();      // lots of typing here , because we have a long type name.
            var obj1 = new SomeBigClassToDoSomething<string, int>();    // in this case using var keyword is best practice , to make code short and more readable.
            obj1.CustomerName = "CustomerName";  // Strongly typed


            // Use var keyword in LINQ :
            string[] cars = new string[] { "Honda", "Toyota", "Mercedes", "Fiat", "Ford" };
            IEnumerable<MyData> data = from car in cars where car.Length >= 5 select new MyData { Value = car, Len = car.Length };   // a lots of work here 
            foreach (MyData dt in data)
            {
                Console.WriteLine($"Name = {dt.Value} - Length =  {dt.Len}");
            }
            Console.WriteLine();
            var selectedCars = from car in cars where car.Length >= 5 select new { Value = car, Len = car.Length };
            foreach (var car in selectedCars)
            {
                Console.WriteLine($"Name = {car.Value} - Length =  {car.Len}");
            }


            // Use var keyword with anonymous types and anonymous collections :
            var myItem = new { FirstName = "David", LastName = "Pedri", Email = "David@gmail.com" };     // Anonymous Type
            Console.WriteLine($"Full Name = {myItem.FirstName} {myItem.LastName} - Email = {myItem.Email}");
            var array = new[] 
            {
                new { FirstName = "David", LastName = "Pedri", Email = "David@gmail.com" },
                new { FirstName = "Sam", LastName = "Gavi", Email = "Sam@gmail.com" },
                new { FirstName = "Jim", LastName = "Alves", Email = "Jim@gmail.com" }
            };  // Anonymous Collection
            foreach (var item in array)
            {
                Console.WriteLine($"FullName = {item.FirstName} {item.LastName} & Email = {item.Email}");
            }
        }
    }
    public class SomeBigClassToDoSomething<T, U>
    {
        // Fields
        //var age;    // Compile-time error , because var keyword cannot be used on fields at class scope.


        // Properties
        public string CustomerName { get; set; }
    }
    public class MyData
    {
        // Properties
        public string Value { get; set; }
        public int Len { get; set; }

    }

}