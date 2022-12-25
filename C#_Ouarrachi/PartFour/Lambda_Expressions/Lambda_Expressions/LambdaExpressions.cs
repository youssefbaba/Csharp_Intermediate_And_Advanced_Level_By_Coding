namespace Lambda_Expressions
{
    public delegate void DelegateOne(double number1, double number2);
    public delegate double DelegateTwo(double number1, double number2);
    public delegate void DelegateThree();
    public delegate string DelegateFour(string name);
    public class LambdaExpressions
    {
        /*
             - Lambda Expression is a shorthand for writing the anonymous methods . 
             - Syntax of Lambda Expression : Args => Expression = Arguments LambdaOperator Expression
             - () => expression     = if we don't need any argument
             - arg => expression  = if we need just only one argument
             - (arg1 , arg2 , arg3 , ....) => expression  = if we need multiple argument
         
         */


        static void Main(string[] args)
        {
            DelegateOne obj1 = (number1, number2) => Console.WriteLine(number1 + number2);
            obj1.Invoke(10.5, 20.6);


            DelegateTwo obj2 = (number1, number2) => number1 * number2;
            double result = obj2.Invoke(10.5, 20.6);
            Console.WriteLine(result);


            DelegateThree obj3 = () => Console.WriteLine("Hello Youssef Baba Good Evening");
            obj3.Invoke();


            DelegateFour obj4 = name => $"Hello {name} Good Morning";
            string str = obj4.Invoke("Youssef Baba");
            Console.WriteLine(str);
            Console.WriteLine();


            List<User> users = new List<User>
            {
                new User { Name = "David" , Age = 52},
                new User { Name = "Jim" , Age = 36},
                new User { Name = "Sam" , Age = 40},
                new User { Name = "Marks" , Age = 26},
                new User { Name = "Adam" , Age = 12},
            };

            List<User> ListUsers = (from user in users
                                    where user.Age >= 40
                                    select user).ToList();
            foreach (User user in ListUsers)
            {
                Console.WriteLine($"Name = {user.Name} - Age = {user.Age}");
            }
            Console.WriteLine();


            List<User> newListUsers = users.Where((user) => user.Age >= 40).ToList();
            foreach (User user in newListUsers)
            {
                Console.WriteLine($"Name = {user.Name} - Age = {user.Age}");
            }



        }
    }
}