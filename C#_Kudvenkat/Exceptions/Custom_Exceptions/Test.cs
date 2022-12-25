namespace Custom_Exceptions
{
    internal class Test
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    Console.Write("Please enter a number : ");
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Number : {number}");
                }
                catch (Exception exp)
                {
                    //throw new UserAlreadyLoggedInException();
                    //throw new UserAlreadyLoggedInException("User is Already logged in.");
                    throw new UserAlreadyLoggedInException("User is Already logged in.", exp);
                }
            }
            catch (UserAlreadyLoggedInException exp1)
            {
                Console.WriteLine($"{exp1.GetType().Name} : {exp1.Message}");
                if (exp1.InnerException != null)
                {
                    Console.WriteLine($"{exp1.InnerException.GetType().Name} : {exp1.InnerException.Message}");
                }
            }
        }
    }
}