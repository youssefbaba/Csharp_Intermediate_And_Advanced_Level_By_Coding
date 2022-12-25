namespace Objects_Create_Instances_Of_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/object-oriented/objects
             - The managed heap memory is the memory managed by the .NET runtime and cleaned by the garbage collection.
             - The stack memory is not garbage collected ,During the execution of a method, the stackalloc operator allocates a block of memory on the stack. The memory is deallocated automatically when the method returns (ends).
             - Equals method : 
                - If the current instance is a reference type, the Equals(Object) method tests for reference equality.
                - If the current instance is a value type, the Equals(Object) method tests for value equality .
            */

            Person person1 = new Person("Youssef" ,25); // person1 is a refference type
            Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}"); // person1 Name = Youssef , Age = 25


            Person person2 = person1;
            person2.Name = "Mohamed";
            person2.Age = 30;


            Person person3 = new Person("Youssef", 25);
            //Person person3 = new Person("John", 40);


            Console.WriteLine($"person2 Name = {person2.Name} , Age = {person2.Age}"); // person2 Name = Mohamed  , Age = 30
            Console.WriteLine($"person1 Name = {person1.Name} , Age = {person1.Age}"); // person1 Name = Mohamed  , Age = 30


            Employee employee1 = new Employee(1, "Youssef"); // employee1 is a value type
            Console.WriteLine($"employee1 Id = {employee1.Id} , Name = {employee1.Name}"); // employee1 Id = 1 , Name = Youssef


            Employee employee2 = employee1;
            employee2.Id = 2;
            employee2.Name = "Mohamed";


            Employee employee3 = new Employee(1, "Youssef");



            Console.WriteLine($"employee2 Id = {employee2.Id} , Name = {employee2.Name}"); // employee2 Id = 1 , Name = Mohamed
            Console.WriteLine($"employee1 Id = {employee1.Id} , Name = {employee1.Name}"); // employee1 Id = 1 , Name = Youssef


            if (person1.Equals(person2))
            {
                Console.WriteLine($"The two class instances (person1 and person2) refer to the same location in memory .");
            }
            else
            {
                Console.WriteLine($"The two class instances (person1 and person2) don't refer to the same location in memory .");
            }
            if (person1.Equals(person3))
            {
                Console.WriteLine($"The two class instances (person1 and person3) refer to the same location in memory .");
            }
            else
            {
                Console.WriteLine($"The two class instances (person1 and person3) don't refer to the same location in memory .");
            }


            if (employee1.Equals(employee2))
            {
                Console.WriteLine($"The two struct instances (employee1 and employee2) are the same type and represent the same value.");
            }
            else
            {
                Console.WriteLine($"The two struct instances (employee1 and employee2) aren't the same type or don't represent the same value .");
            }
            if (employee1.Equals(employee3))
            {
                Console.WriteLine($"The two struct instances (employee1 and employee3) are the same type and represent the same value.");
            }
            else
            {
                Console.WriteLine($"The two struct instances (employee1 and employee3) aren't the same type or don't represent the same value .");
            }
        }
    }
}