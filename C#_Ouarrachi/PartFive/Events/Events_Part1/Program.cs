namespace Events_Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User("David", "Pedri", "DavidPedri1@example.com");
            //User user = new User("David", "Alves", "DavidPedri1@example.com");
            LoginManager loginManager = new LoginManager();
            loginManager.UserLoginSuccessful += LoginManager_UserLoginSuccessful;
            loginManager.LoginUser(user);
        }
        private static void LoginManager_UserLoginSuccessful(object? sender, User user)
        {
            Console.WriteLine($"Welcome {user.FirstName} {user.LastName}");
        }
    }
}