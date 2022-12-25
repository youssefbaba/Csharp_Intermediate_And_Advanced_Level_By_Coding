namespace Linq_For_Lists_Sorting_Filtering_And_Aggregating_Lists_Easily
{
    public class ListManager
    {
        public static List<Person> LoadSampleData()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person { FirstName = "Gerard", LastName = "Pique", BirthDay = Convert.ToDateTime("01/12/1991"), YearsExperience = 20 });
            output.Add(new Person { FirstName = "David", LastName = "Alaba", BirthDay = Convert.ToDateTime("11/04/1996"), YearsExperience = 12 });
            output.Add(new Person { FirstName = "Daniel", LastName = "Alaba", BirthDay = Convert.ToDateTime("07/12/1990"), YearsExperience = 1 });
            output.Add(new Person { FirstName = "Gerard", LastName = "Pedri", BirthDay = Convert.ToDateTime("11/01/1989"), YearsExperience = 8 });
            output.Add(new Person { FirstName = "Marks", LastName = "Alonso", BirthDay = Convert.ToDateTime("04/02/2000"), YearsExperience = 7 });
            output.Add(new Person { FirstName = "Ana", LastName = "Fonti", BirthDay = Convert.ToDateTime("05/06/1986"), YearsExperience = 16 });
            return output;
        }
    }
}
