

namespace Using_Constructors
{
    public class User
    {
        // Fields
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Transaction> Transactions { get; set; }

        // Constructors

        public User()
        {
            Transactions = new List<Transaction>();
        }
        public User(string name):this()
        {
            Name = name;
        }
        public User(string name, int age):this(name)
        {
            Age = age;
        }

    }
}
