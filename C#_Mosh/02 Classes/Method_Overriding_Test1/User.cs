
using System.Drawing;

namespace Method_Overriding_Test1
{
    public class User
    {
        // Fields
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor
        public User(string firstName , string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Overriding ToString method
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        // Overriding Equals Method
        public override bool Equals(object obj)
        {
            if ((obj == null) || ! this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                User user = (User)obj;
                return (FirstName == user.FirstName) && (LastName == user.LastName);
            }
        }
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
    }
}
