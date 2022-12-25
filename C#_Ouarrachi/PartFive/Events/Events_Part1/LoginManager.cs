namespace Events_Part1
{
    public class LoginManager
    {
        // Event
        //public event Action<User> UserLoginSuccessful;
        public event EventHandler<User> UserLoginSuccessful;


        // Methods
        public void LoginUser(User user)
        {
            List<User> data = new Data().ListOfUsers;
            foreach (var item in data)
            {
                if (user.FirstName.Equals(item.FirstName) && user.LastName.Equals(item.LastName) && user.Email.Equals(item.Email))
                {
                    OnUserLoginSuccessful(user);
                    return;
                }
            }
            Console.WriteLine("login failed.");
        }
        private void OnUserLoginSuccessful(User user)
        {
            if (UserLoginSuccessful != null)
            {
                UserLoginSuccessful.Invoke(this, user);
            }
        }
    }
}