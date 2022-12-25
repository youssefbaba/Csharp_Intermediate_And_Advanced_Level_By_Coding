using Generics_Part;
using System.Collections;

namespace Generics_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Use Generic Class
            Console.WriteLine("Use Generic Class");
            GenericClass<int> genericClass = new GenericClass<int>();
            Console.WriteLine($"10 and 20 are equal ? {genericClass.AreEqual(10 , 20)}");
            Console.WriteLine($"100 and 100 are equal ? {genericClass.AreEqual(100 ,100)}");
            GenericClass<string> genericClass1 = new GenericClass<string>();
            Console.WriteLine($"'Youssef' and 'Ahmed' are equal ? {genericClass1.AreEqual("Youssef", "Ahmed")}");
            Console.WriteLine($"'Youssef' and 'Youssef are equal ? {genericClass1.AreEqual("Youssef", "Youssef")}");

            Console.WriteLine();

            // Use Generic Method
            Console.WriteLine("Use Generic Method");
            GenericMethod genericMethod = new GenericMethod();
            Console.WriteLine($"10 and 20 are equal ? {genericMethod.AreEqual<int>(10, 20)}");
            Console.WriteLine($"100 and 100 are equal ? {genericMethod.AreEqual<int>(100, 100)}");
            GenericMethod genericMethod1 = new GenericMethod();
            Console.WriteLine($"'Youssef' and 'Ahmed' are equal ? {genericMethod1.AreEqual<string>("Youssef", "Ahmed")}");
            Console.WriteLine($"'Youssef' and 'Youssef are equal ? {genericMethod1.AreEqual<string>("Youssef", "Youssef")}");
            Console.WriteLine();


            Salaries salaries = new Salaries();
            //ArrayList salaryList =  salaries.GetSalaries();
            List<float> salaryList =  salaries.GetSalaries();
            //float salary = (float)salaryList[1];  // Unboxing : we must casting to double because boxing has been from double to object
            float salary = salaryList[1]; 
            salary = salary + (salary * 0.02f);
            Console.WriteLine($"Salary = {salary}");


        }

    }
}