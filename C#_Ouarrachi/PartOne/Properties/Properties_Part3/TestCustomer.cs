﻿using System.Drawing;

namespace Properties_Part3
{
    public class TestCustomer
    {
        /*
         - First Advantage of properties is : Access restriction => Readonly property , Writeonly property , ReadWrite property
         - Second Advantage of properties is : Conditional access , Conditional assignement .
         
         */
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, false, "John", 5000.00, Cities.Tanger, "Tanger-Tetouan-Al Hoceima");
            //customer.CustomerId = 102; // Can't be assigned as the property is read only
            //Console.WriteLine($"Customer Id = {customer.CustomerId}");
            if (customer.Status == true)
            {
                Console.WriteLine($"Customer status = Active");
            }
            else
            {
                Console.WriteLine($"Customer status = In-Active");
            }
            Console.WriteLine($"Customer name = {customer.CustomerName}");
            customer.CustomerName += " Doe";  // Assignment failed , so below statement prints old CustomerName only
            Console.WriteLine($"Modified customer name = {customer.CustomerName}");
            Console.WriteLine($"Customer balance = {customer.Balance}");
            customer.Balance -= 3000;  // Assignment failed , so below statement prints old Balance only
            Console.WriteLine($"Modified Customer balance = {customer.Balance}");


            Console.WriteLine();


            customer.Status = true;
            if (customer.Status == true)
            {
                Console.WriteLine($"Customer status = Active");
            }
            else
            {
                Console.WriteLine($"Customer status = In-Active");
            }
            customer.CustomerName += " Doe";  // Assignment succed , so below statement prints new CustomerName 
            Console.WriteLine($"Modified customer name = {customer.CustomerName}");
            customer.Balance -= 3000;  // Assignment succed , so below statement prints new Balance
            Console.WriteLine($"Modified Customer balance = {customer.Balance}");
            customer.Balance -= 1600; // Assignment failed , so below statement prints old Balance only
            Console.WriteLine($"Modified Customer balance = {customer.Balance}");
            customer.Balance -= 1200; // Assignment succed , so below statement prints new Balance
            Console.WriteLine($"Modified Customer balance = {customer.Balance}");
            Console.WriteLine($"Current customer city = {customer.City}");
            customer.City = Cities.CasaBlanca;
            Console.WriteLine($"Modified customer city = {customer.City}");
            Console.WriteLine($"Current customer state = {customer.State}");
            // customer.State = "Casablanca-Settat"; // Invalid because current class not child class of Customer class
            Console.WriteLine($"Modified customer state = {customer.State}");
            Console.WriteLine($"Current customer country = {customer.Country}");

        }
    }
}