
namespace How_To_Write_A_Copy_Constructor
{
    internal class Person
    {
        // Fields
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructors
        public Person(string name , int age) // Instance constructor
        {
            Name = name;
            Age = age;
        }
        public Person(Person previousPerson) // Copy constructor
        {
            Name = previousPerson.Name;
            Age = previousPerson.Age;
        }
        //public Person(Person previousPerson):this(previousPerson.Name , previousPerson.Age)  // Alternative copy contructor
        //{
        //}

        // Methods
        public string Detail()
        {
            return $"{Name} is {Age} years old.";
        }
    }
}
