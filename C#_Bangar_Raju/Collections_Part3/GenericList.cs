namespace Collections_Part3
{
    internal class GenericList
    {
        static void Main(string[] args)
        {
            /*
             
             - Array : Type safe but fixed length
             - Non Generic Collection (ArrayList , HashTbale , .....) : Auto resizing but not type safe
             - Generic Collection ( List ) : Type safe and Auto resizing

            */
            // Creating a list of elements by using collection initializer syntax.
            //List<double> listMarks = new List<double>() { 15.75, 13.5, 18.5, 16, 17.5, 14.25 };
            // Creating a list of elements by using Add() method.
            List<double> listMarks = new List<double>();
            listMarks.Add(15.75);
            listMarks.Add(13.5);
            listMarks.Add(18.5);
            listMarks.Add(16);
            listMarks.Add(17.5);
            listMarks.Add(14.25);
            Console.Write($"ListMarks : [ ");
            foreach (double value in listMarks)
            {
                Console.Write($"{value} ");
            }
            Console.Write($"]");
            Console.WriteLine();

            //List<string> listCars = new List<string>() { "Ford", "Toyota", "Honda", "Audi", "Nissan", "BMW" };
            List<string> listCars = new List<string>();
            listCars.Add("Ford");
            listCars.Add("Toyota");
            listCars.Add("Honda");
            listCars.Add("Audi");
            listCars.Add("Nissan");
            listCars.Add("BMW");
            Console.Write($"ListCars : [ ");
            for (int i = 0; i < listCars.Count; i++)
            {
                Console.Write($"{listCars[i]} ");
            }
            Console.Write($"]");
            Console.WriteLine();

            List<Customer> customers = new List<Customer>()
            {
                new Customer(1 , "John Doe" , 1200.00),
                new Customer(2 , "Mark Huge" , 500.00),
                new Customer(3 , "Jean Bernard" , 1000.00),
                new Customer(4 , "Xavi Alonso" , 20000.00),
                new Customer(5 , "Jordi Alba" , 800.00),
                new Customer(6 , "Gerard Messi" , 900.00),
            };

            Console.Write($"ListCustomers : [ ");
            foreach (Customer customer in customers)
            {
                Console.Write($"({customer.Id} , {customer.Name} , {customer.Balance}) ");
            }
            Console.Write($"]");
            Console.WriteLine();

            customers.Insert(2, new Customer(7, "David Pedri" , 2500.00));
            Console.Write($"ListCustomers : [ ");
            foreach (Customer customer in customers)
            {
                Console.Write($"({customer.Id} , {customer.Name} , {customer.Balance}) ");
            }
            Console.Write($"]");
            Console.WriteLine();

            customers.RemoveAt(2);
            Console.Write($"ListCustomers : [ ");
            foreach (Customer customer in customers)
            {
                Console.Write($"({customer.Id} , {customer.Name} , {customer.Balance}) ");
            }
            Console.Write($"]");
            Console.WriteLine();
        }
    }
}