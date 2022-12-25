
namespace Object_Initializer_Test3
{
    public class Student
    {
        // Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructors
        public Student()
        {
        }
        public Student(string firstName , string lastName)
        {
            FirstName = firstName;  
            LastName = lastName;
        }

        // Methods
        public override string ToString()
        {
            return $"Id = {Id} , FirstName = {FirstName ?? "null"} , LastName = {LastName ?? "null"}";
        }
    }
}
