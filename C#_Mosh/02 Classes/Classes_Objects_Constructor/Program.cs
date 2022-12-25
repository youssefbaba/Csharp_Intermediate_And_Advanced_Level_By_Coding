
namespace Classes_Objects_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://www.youtube.com/watch?v=Us2i7D-urgs&list=PLAC325451207E3105&index=19
             */
            Car car = new Car();
            car.DisplayDetails();


            Customer customer1 = new Customer();
            customer1.PrintFullName();
            Customer customer2 = new Customer("Youssef" ,"Baba");
            customer2.PrintFullName();

        }
    }
}