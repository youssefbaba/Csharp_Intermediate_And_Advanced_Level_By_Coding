namespace IComparable_IComparer_Interfaces_Part0
{

    public class Person : IComparable<Person>
    {
        // Consstructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;  
        }


        // Methods
        public int CompareTo(Person? other)
        {
            return Name.CompareTo(other.Name);
        }


        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
    }


    /*
    public class Person : IComparable
    {
        // Consstructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }


        // Methods
        public int CompareTo(object? obj)
        {
            Person person = obj as Person;
            return Name.CompareTo(person.Name);
        }

        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
    }
    */
}
