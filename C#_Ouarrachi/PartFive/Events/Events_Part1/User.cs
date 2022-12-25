namespace Events_Part1
{
    public class User
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        // Constructors
        public User(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}