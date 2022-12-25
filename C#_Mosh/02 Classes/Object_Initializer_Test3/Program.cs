namespace Object_Initializer_Test3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
         
             - link1 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
             - The compiler processes object initializers by first accessing the parameterless instance constructor and then processing the member initializations.
             
             */
            Student student1 = new Student();
            Console.WriteLine(student1);


            Student student2 = new Student();
            student2.Id = 2;
            student2.FirstName = "John";
            student2.LastName = "Doe";
            Console.WriteLine(student2);


            Student student3 = new Student() // Combination between constructor and object initializer
            {
                Id = 3,
                FirstName = "Chris",
                LastName = "Huge",
            };
            Console.WriteLine(student3);


            Student student4 = new Student("Sam", "Bernard");
            student4.Id = 4;
            Console.WriteLine(student4);


            Student student5 = new Student("Alice", "Gavi") // Combination between constructor and object initializer
            {
                Id = 5,
            };
            Console.WriteLine(student5);


            Student student6 = new Student
            {
                Id = 6,
                FirstName = "Xavi",
                LastName = "Alonso",
            };
            Console.WriteLine(student6);


            Student student7 = new Student("Lio" , "Messi");
            Console.WriteLine(student7);


            Student student8 = new Student
            {
                FirstName = "Youssef",
                LastName = "Kante",
            };
            Console.WriteLine(student8);


            Student student9 = new Student
            {
                Id = 9
            };
            Console.WriteLine(student9);


            BaseBallTeam baseBallTeam = new BaseBallTeam
            {
                [1] = "John Doe",
                ["C"] = "Sam Huge",
                [3] = "Chris Gavi",
                ["2B"] = "Jim Bernard",
                [5] = "Thomas Alonso",
                ["SS"] = "Alice Pereira",
                [7] = "Pepe Mosh",
                ["CF"] = "Sergio Ramos",
                [9] = "David Torres",
            };

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{baseBallTeam[i]}");
            }

        }
    }
}