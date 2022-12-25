
namespace Object_Initializer_Test2
{
    public class Person
    {
        //// Fields
        //public string FirstName;
        //public string LastName;
        //public int Age;

        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        // Consructors
        public Person() // parameterless constructor
        {
        }
        public Person(string firstName, string lastName) // parameter constructor
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
