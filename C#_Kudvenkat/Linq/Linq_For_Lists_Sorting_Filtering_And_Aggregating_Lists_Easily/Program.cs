namespace Linq_For_Lists_Sorting_Filtering_And_Aggregating_Lists_Easily
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();
            Console.WriteLine("------ Defaul list before sorting ------");
            foreach (Person person in people)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , BirthDay = {person.BirthDay.ToShortDateString()} , Experience {person.YearsExperience}");
            }
            Console.WriteLine();


            Console.WriteLine("------ list after ascending sorting (FirstName) ------");
            List<Person> people1 = people.OrderBy(person => person.FirstName).ToList();
            foreach (Person person in people1)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , BirthDay = {person.BirthDay.ToShortDateString()} , Experience {person.YearsExperience}");
            }
            Console.WriteLine();


            Console.WriteLine("------ list after descending sorting (FirstName) ------");
            List<Person> people2 = people.OrderByDescending(person => person.FirstName).ToList();
            foreach (Person person in people2)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , BirthDay = {person.BirthDay.ToShortDateString()} , Experience {person.YearsExperience}");
            }
            Console.WriteLine();


            Console.WriteLine("------ list after ascending sorting (FirstName) and then descending sorting (YearsExperience)  ------");
            List<Person> people3 = people.OrderBy(person => person.FirstName).ThenByDescending(person => person.YearsExperience) .ToList();
            foreach (Person person in people3)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , BirthDay = {person.BirthDay.ToShortDateString()} , Experience {person.YearsExperience}");
            }
            Console.WriteLine();


            Console.WriteLine("------ list after descending sorting (FirstName) and then ascending sorting (LastName)  ------");
            List<Person> people4 = people.OrderByDescending(person => person.FirstName).ThenBy(person => person.LastName).ToList();
            foreach (Person person in people4)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , BirthDay = {person.BirthDay.ToShortDateString()} , Experience {person.YearsExperience}");
            }
            Console.WriteLine();


            Console.WriteLine("------ Filter a list by conditions  ------");
            List<Person> people5 = people.Where(person => person.YearsExperience > 10 && person.BirthDay.Month  >= 3).ToList(); // Filter sublist based on a condition
            foreach (Person person in people5)
            {
                Console.WriteLine($"FirstName = {person.FirstName} , LastName = {person.LastName} , BirthDay = {person.BirthDay.ToShortDateString()} , Experience {person.YearsExperience}");
            }
            Console.WriteLine();

            int totalYearsExperiences = 0;
            totalYearsExperiences = people.Where(person => person.BirthDay.Month >= 3).Sum(person => person.YearsExperience);
            Console.WriteLine($"The total years experiences is : {totalYearsExperiences}");
        }
    }
}