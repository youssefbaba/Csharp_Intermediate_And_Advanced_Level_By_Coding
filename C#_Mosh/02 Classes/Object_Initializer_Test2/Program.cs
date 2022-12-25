namespace Object_Initializer_Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              - link1 : https://www.csharptutorial.net/csharp-tutorial/csharp-object-initializer/
              - link2 : https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
              - I can combine constructor with object initializer
            */
            Person person1 = new Person();
            Console.WriteLine($"{nameof(person1)} : FirstName = {person1.FirstName ?? "null"} , LastName = {person1.LastName ?? "null"} , Age = {person1.Age}");
            person1.FirstName = "John";
            person1.LastName = "Doe";
            person1.Age = 45;
            Console.WriteLine($"{nameof(person1)} : FirstName = {person1.FirstName} , LastName = {person1.LastName} , Age = {person1.Age}");

            Person person2 = new Person("Youssef", "Baba");
            person2.Age = 25;
            Console.WriteLine($"{nameof(person2)} : FirstName = {person2.FirstName} , LastName = {person2.LastName} , Age = {person2.Age}");


            Person person3 = new Person // using object initializer to initialze the object
            {
                FirstName = "Mohamed",
                LastName = "Zidani",
                Age = 26,
            };
            Console.WriteLine($"{nameof(person3)} : FirstName = {person3.FirstName} , LastName = {person3.LastName} , Age = {person3.Age}");

            Person person4 = new Person("Sam", "Huge") // Combination between constructor and object initializer
            {
                Age = 30,
            };
            Console.WriteLine($"{nameof(person4)} : FirstName = {person4.FirstName} , LastName = {person4.LastName} , Age = {person4.Age}");



            Matrix matrix = new Matrix(3, 3)
            {
                [0, 0] = 1,
                [0, 1] = 2,
                [0, 2] = 3,
                [1, 0] = 4,
                [1, 1] = 5,
                [1, 2] = 6,
                [2, 0] = 7,
                [2, 1] = 8,
                [2, 2] = 9,
            };

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }
                Console.WriteLine();
            }


            // we invoke a constructor followed by lines of assignment statements.
            Cat cat1 = new Cat();
            cat1.Age = 20;
            cat1.Name = "Tom";
            Console.WriteLine($"cat1 : Age = {cat1.Age} , Name = {cat1.Name}");

            // we use Object initializer , without having to invoke a constructor followed by lines of assignment statements.
            Cat cat2 = new Cat { Age = 25, Name = "Jerry" };
            Console.WriteLine($"cat2 : Age = {cat2.Age} , Name = {cat2.Name}");

            // we invoke a constructor followed by lines of assignment statements.
            Cat cat3 = new Cat("Maya");
            cat3.Age = 10;
            Console.WriteLine($"cat3 : Age = {cat3.Age} , Name = {cat3.Name}");

            // we combine between constructor and object initiaizer
            Cat cat4 = new Cat("Maika") { Age = 15 };
            Console.WriteLine($"cat4 : Age = {cat4.Age} , Name = {cat4.Name}");


            Form form = new Form(2, 2)
            {
                [0, 0] = 10,
                [0, 1] = 20,
                [1, 0] = 10,
                [1, 1] = 20,
            };

            for (int  i = 0;  i < 2;  i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{form[i ,j]} ");
                }
                Console.WriteLine();
            }

            IndexersExample thing = new IndexersExample(4)
            {
                Name = "object one",
                Size = Math.PI,
                [0] = '1',
                [1] = 'I',
                [2] = '9',
                [3] = 'E',
            };
        }
    }
}