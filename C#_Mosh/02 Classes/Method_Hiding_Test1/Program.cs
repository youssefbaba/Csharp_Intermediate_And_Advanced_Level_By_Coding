namespace Method_Hiding_Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            - link1 : https://www.youtube.com/watch?v=0FhagHE3nw8&list=PLAC325451207E3105&index=22
             - Convert from Base to Derived is explicit so i need casting
             - Convert from Derived to Base is implicit

            */
            /*
             
             Parent obj = new Child();
             - Even though your reference is of the Parent type, the underlying object is Child and any overridden members in the derived class Child will be used instead of those on Base, even though you are trying to use Parent.
             - In the case of member hiding using the new keyword, if you have a reference to the base type it will skip any derived classes that are hiding the members .
       
             */

            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.FirstName = "Full";
            fullTimeEmployee.LastName = "Time";
            fullTimeEmployee.YearlyIncome = 120000;
            fullTimeEmployee.PrintFullName();


            PartTimeEmployee partTimeEmployeeOne = new PartTimeEmployee();
            partTimeEmployeeOne.FirstName = "Part";
            partTimeEmployeeOne.LastName = "Time";
            partTimeEmployeeOne.HourlyIncome = 1000;
            //partTimeEmployeeOne.PrintFullName();
            ((Employee)partTimeEmployeeOne).PrintFullName(); // Method two to invoke a hidden base class member from derived class


            Employee partTimeEmployeeTwo = new PartTimeEmployee();  // Method three to invoke a hidden base class member from derived class
            partTimeEmployeeTwo.FirstName = "Youssef";
            partTimeEmployeeTwo.LastName = "Baba";
            partTimeEmployeeTwo.PrintFullName();

        }
    }
}