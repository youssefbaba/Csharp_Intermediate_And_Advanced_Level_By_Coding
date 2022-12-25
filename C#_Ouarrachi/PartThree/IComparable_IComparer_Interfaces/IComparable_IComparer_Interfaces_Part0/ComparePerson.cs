namespace IComparable_IComparer_Interfaces_Part0
{
    public class ComparePerson : IComparer<Person>
    {
        // Methods
        // First way
        public int Compare(Person? person1, Person? person2)
        {
            return person1.Age.CompareTo(person2.Age);
        }
        /*
        // Second Way: 
        public int Compare(Person? person1, Person? person2)
        {
            if (person1.Age == person2.Age)
            {
                return 0;
            }
            if (person1.Age < person2.Age)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        */
    }
}
