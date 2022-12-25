
namespace Methods_Test1
{
    public class Person
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }

        // Methods
        public void UpdateName(Person person)
        {
            person.Name = "John Doe";
            Console.WriteLine(person); // Name = John Doe  , Age = 30
        }
        public void UpdateName(ref Person person) // Overload of UpdateName method
        {
            person.Name = "Sergio Gavi";
            Console.WriteLine(person); // Name = Sergio Gavi , Age = 45

            //person = null;
            //Console.WriteLine(person);
        }

        public override string ToString()
        {
            return $"Name = {Name} , Age = {Age}";
        }
    }
}
