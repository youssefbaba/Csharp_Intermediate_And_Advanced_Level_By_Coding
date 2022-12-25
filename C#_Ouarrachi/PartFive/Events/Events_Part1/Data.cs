namespace Events_Part1
{
    public class Data
    {
        // Properties
        public List<User> ListOfUsers { get; set; }

        // Constructors
        public Data()
        {
            ListOfUsers = new List<User>
            {
                new User("David", "Pedri", "DavidPedri1@example.com"),
                new User("Marks", "Gavi", "MarksGavi2@example.com"),
                new User("Bernard", "Xavi", "BernardXavi3@example.com"),
                new User("Jean", "Pique", "JeanPique4@example.com"),
                new User("Adam", "Lambart", "AdamLambart5@example.com")
            };
        }
    }
}