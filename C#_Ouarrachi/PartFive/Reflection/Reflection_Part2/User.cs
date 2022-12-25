namespace Reflection_Part2
{
    public class User
    {
        // Methods
        public bool AuthenticateUser(string username, string password)
        {
            return true;
        }
        public string HelloUser(string username)
        {
            return $"Hello {username}";
        }
    }
}