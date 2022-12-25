namespace IComparable_IComparer_Interfaces_Part0
{
    public class TestPerson
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("David", 45);
            Person person2 = new Person("Sam", 20);
            Person person3 = new Person("Jim", 50);
            Person person4 = new Person("Adam", 18);
            Person person5 = new Person("Marks", 89);
            List<Person> listPersons = new List<Person>();
            listPersons.Add(person1);
            listPersons.Add(person2);
            listPersons.Add(person3);
            listPersons.Add(person4);
            listPersons.Add(person5);
            Console.WriteLine("Before sorting the list : ");
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"Name = {person.Name} - Age = {person.Age} ");
            }
            Console.WriteLine();
            listPersons.Sort();
            Console.WriteLine("After sorting the list based on name in ascending order : ");
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"Name = {person.Name} - Age = {person.Age} ");
            }
            Console.WriteLine();
            Console.WriteLine("After sorting the list based on name in descending order : ");
            listPersons.Reverse();
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"Name = {person.Name} - Age = {person.Age} ");
            }
            Console.WriteLine();
            listPersons.Sort(new ComparePerson());
            Console.WriteLine("After sorting the list based in age in ascending order : ");
            foreach (Person person in listPersons)
            {
                Console.WriteLine($"Name = {person.Name} - Age = {person.Age} ");
            }
        }
    }
}
