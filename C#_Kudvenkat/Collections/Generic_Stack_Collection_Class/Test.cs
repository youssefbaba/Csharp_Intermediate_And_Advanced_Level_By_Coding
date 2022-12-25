using System.Runtime.CompilerServices;

namespace Generic_Stack_Collection_Class
{
    public class Test
    {
        static void Main(string[] args)
        {
            /*
             - Stack is a LIFP generic collection class that is present in the System.Collections.Generic namespace
             */
            User user1 = new User { Id = 101, Name = "Valarie", Gender = "Female" };
            User user2 = new User { Id = 102, Name = "John", Gender = "Male" };
            User user3 = new User { Id = 103, Name = "Adele", Gender = "Female" };
            User user4 = new User { Id = 104, Name = "David", Gender = "Male" };
            User user5 = new User { Id = 105, Name = "Marks", Gender = "Male" };


            Stack<User> stackUsers = new Stack<User>();


            Console.WriteLine("------ Adding the items at the top of the stackUsers Stack and display them ------");
            stackUsers.Push(user1); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user3); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user2); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user4); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user5); // inserts an item a the top of the stackUsers Stack
            Console.WriteLine($"Total items in the stackUsers Stack : {stackUsers.Count}");
            foreach (User user in stackUsers)
            {
                Console.WriteLine($"Id = {user.Id} , Name = {user.Name} , Gender = {user.Gender}");
            }
            Console.WriteLine();


            User user6 = stackUsers.Pop(); // Removes and returns the item at the top of the stackUsers Stack
            Console.WriteLine($"Id = {user6.Id} , Name = {user6.Name} , Gender = {user6.Gender}");
            Console.WriteLine($"Total items left in the stackUsers Stack : {stackUsers.Count}");
            Console.WriteLine();

            User user7 = stackUsers.Pop(); // Removes and returns the item at the top of the stackUsers Stack
            Console.WriteLine($"Id = {user7.Id} , Name = {user7.Name} , Gender = {user7.Gender}");
            Console.WriteLine($"Total items left in the stackUsers Stack : {stackUsers.Count}");
            Console.WriteLine();

            User user8 = stackUsers.Pop(); // Removes and returns the item at the top of the stackUsers Stack
            Console.WriteLine($"Id = {user8.Id} , Name = {user8.Name} , Gender = {user8.Gender}");
            Console.WriteLine($"Total items left in the stackUsers Stack : {stackUsers.Count}");
            Console.WriteLine();


            User user9 = stackUsers.Pop(); // Removes and returns the item at the top of the stackUsers Stack
            Console.WriteLine($"Id = {user9.Id} , Name = {user9.Name} , Gender = {user9.Gender}");
            Console.WriteLine($"Total items left in the stackUsers Stack : {stackUsers.Count}");
            Console.WriteLine();


            User user10 = stackUsers.Pop(); // Removes and returns the item at the top of the stackUsers Stack
            Console.WriteLine($"Id = {user10.Id} , Name = {user10.Name} , Gender = {user10.Gender}");
            Console.WriteLine($"Total items left in the stackUsers Stack : {stackUsers.Count}");
            Console.WriteLine();


            Console.WriteLine("------ Adding the items at the top of the stackUsers Stack and display them ------");
            stackUsers.Push(user5); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user4); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user3); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user2); // inserts an item a the top of the stackUsers Stack
            stackUsers.Push(user1); // inserts an item a the top of the stackUsers Stack
            Console.WriteLine($"Total items in the stackUsers Stack : {stackUsers.Count}");
            foreach (User user in stackUsers)
            {
                Console.WriteLine($"Id = {user.Id} , Name = {user.Name} , Gender = {user.Gender}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Getting an item at the top of the stackUsers Stack without removing it ------");
            User user11 = stackUsers.Peek(); // Return an item at the top of the stackUsers Stack without removing it
            Console.WriteLine($"Id = {user11.Id} , Name = {user11.Name} , Gender = {user11.Gender}");
            Console.WriteLine($"Total items left in the stackUsers Stack is : {stackUsers.Count}");


            Console.WriteLine("------ Checking if the specific item is found in the stackUsers Stack ------");
            User user0 = default;
            if (stackUsers.Contains(user1))
            {
                Console.WriteLine("user1 exists in the stackUsers Stack");
            }
            else
            {
                Console.WriteLine("user1 doesn't exist in the stackUsers Stack");
            }
            Console.WriteLine();
            if (stackUsers.Contains(user0))
            {
                Console.WriteLine("user0 exists in the stackUsers Stack");
            }
            else
            {
                Console.WriteLine("user0 doesn't exist in the stackUsers Stack");
            }


        }
    }
}