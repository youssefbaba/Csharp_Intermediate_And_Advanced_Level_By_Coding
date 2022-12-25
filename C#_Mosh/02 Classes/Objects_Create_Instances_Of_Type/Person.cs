
namespace Objects_Create_Instances_Of_Type
{
    public  class Person
    {
        // Fields
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }

    }
}
