using System.Net.Mail;

namespace Methods_Test1
{
    internal class Program
    {
        static void Main(string[] args) // this method is private by default
        {
            /*
             - link1 : https://www.youtube.com/watch?v=bPQx0paXrbw
             - link2 : https://www.youtube.com/watch?v=c4hOXIG8yPo
             - link3 : https://www.youtube.com/watch?v=56bbjE4assU
             - link4 :https://codewala.net/2016/05/22/passing-a-reference-type-using-ref-keyword/
             
             */
            PrintNumber();

            Console.WriteLine("---------------");

            MeetAlien();

            Console.WriteLine("---------------");

            if ((Multiply(5, 12) % 2) == 0)
            {
                Console.WriteLine($"{Multiply(5, 12)} is an even number");
            }
            else
            {
                Console.WriteLine($"{Multiply(5, 12)} is an uneven number");
            }

            Console.WriteLine("---------------");

            string sentence = "Welcome to DeveloperPublish website";
            Console.WriteLine($"Number of words in '{sentence}' = {NumberOfWords(sentence)} words");

            Console.WriteLine("---------------");

            Program program = new Program();
            program.EvensNumbers();
            program.OddNumbers(20);

            Console.WriteLine("---------------");

            Console.WriteLine($"Square of 10 = {Square(10)}");

            Console.WriteLine("--- method overloading ------");

            Point point = new Point(10, 20);
            Console.WriteLine(point); // Point( X = 10 , Y = 20)
            point.Move(40, 60);
            Console.WriteLine(point); // Point( X = 40 , Y = 60)
            Point point1 = new Point(100, 200);
            point.Move(point1);
            //point.Move(null);
            Console.WriteLine(point); // Point( X = 100 , Y = 200)

            Console.WriteLine("--- Params modifier ------");

            Calculator calculator1 = new Calculator();
            Console.WriteLine($"Sum1 = {calculator1.Add(1, 2)}");
            Console.WriteLine($"Sum1 = {calculator1.Add(new int[] { 1, 2 })}");
            Console.WriteLine($"Sum2 = {calculator1.Add(1, 2, 3)}");
            Console.WriteLine($"Sum2 = {calculator1.Add(new int[] { 1, 2, 3 })}");
            Console.WriteLine($"Sum3 = {calculator1.Add(1, 2, 3, 4, 5, 6)}");
            Console.WriteLine($"Sum3 = {calculator1.Add(new int[] { 1, 2, 3, 4, 5, 6 })}");

            Console.WriteLine("--- Ref modifier ------");

            Calculator calculator2 = new Calculator { Number = 10, };  // Here we use object initializer to initialize the calculator object 
            calculator2.Square(calculator2.Number);
            Console.WriteLine(calculator2.Number); // 10
            calculator2.Square(ref calculator2.Number);
            Console.WriteLine(calculator2.Number); // 100

            Person person = new Person { Name = "Youssef Baba", Age = 25 };  // Here we use object initializer to initialize the person object 
            Person person1 = new Person { Name = "Mohamed Zidani", Age = 30 }; // Here we use object initializer to initialize the person1 object 
            person.UpdateName(person1);
            Console.WriteLine(person1); // Name = John Doe  , Age = 30

            Person person4 = new Person { Name = "Toni Kroos", Age = 45 };
            person.UpdateName(ref person4);
            Console.WriteLine(person4); // Name = Sergio Gavi , Age = 45


            Console.WriteLine("--- difference between Ref and Out keywords ------");

            int firstNumber = 1;
            IncrementeOne(ref firstNumber);
            Console.WriteLine($"firstNumber = {firstNumber}"); // firstNumber = 2

            int secondNumber;
            IncrementeneTwo(out secondNumber);
            Console.WriteLine($"secondNumber = {secondNumber}"); // secondNumber = 3

            int firstValue = 10;
            int secondValue = 20;
            int resultAdd;
            int resultMult;
            AddMult(firstValue, secondValue, out resultAdd, out resultMult);
            Console.WriteLine($"{firstValue} + {secondValue} = {resultAdd}");
            Console.WriteLine($"{firstValue} * {secondValue} = {resultMult}");

            int number;
            if (int.TryParse("abc" ,out number))
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            try
            {
                int num = int.Parse("abs");
                Console.WriteLine(num);
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed");
            }
        }

        static void PrintNumber() // Parameterless static method and it's private by default
        {
            Random random = new Random();
            Console.WriteLine($"Random Number = {random.Next(0, 9999)}");
        }
        static void MeetAlien() // Parameterless static method and it's private by default
        {
            Random random = new Random();
            Console.WriteLine($"Hi , I'm X-{random.Next(10, 9999)}");
            Console.WriteLine($"I'm {random.Next(10, 9999)} years old.");
            Console.WriteLine($"Oh , and I'm an alien.");
        }
        static int Multiply(int firstNumber, int secondNumber) // Parameter static method and it's private by default
        {
            return firstNumber * secondNumber;
        }

        static int NumberOfWords(string sentence) // Parameter static method and it's private by default
        {
            char[] letters = new char[] { ' ', '\t', '\n', '\r' };
            return sentence.Split(letters).Length;
        }

        public void EvensNumbers() //¨Parameterless instance method and it's public 
        {
            Console.Write($"Even numbers : ");
            for (int i = 0; i < 20; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        public void OddNumbers(int number) // Parameter instance method it's public
        {
            Console.Write($"Odd numbers : ");
            for (int i = 0; i < number; i++)
            {
                if ((i % 2) != 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.WriteLine();
        }

        public static int Square(int number)  // Parameter static method , it's public
        {
            return number * number;
        }

        public static void IncrementeOne(ref int number)
        {
            number++;
            Console.WriteLine($"number = {number}"); // number = 2
        }

        public static void IncrementeneTwo(out int number)
        {
            number = 1;
            number += 2;
            Console.WriteLine($"number = {number}"); // number = 3
        }

        public static void AddMult(int firstAmount, int secondAmount, out int add, out int mult)
        {
            add = firstAmount + secondAmount;
            mult = firstAmount * secondAmount;
        }



    }
}