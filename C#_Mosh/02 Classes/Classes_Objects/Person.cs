namespace Classes_Objects
{
    public class Person
    {
        // Fields
        public string Name;

        // Methods
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to} , I am {Name}");
        }
        public static Person Parse(string str)
        {
            Person person = new Person();
            person.Name = str;
            return person;
        }
    }
}
