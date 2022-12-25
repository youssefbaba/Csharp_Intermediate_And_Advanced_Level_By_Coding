namespace IComparable_IComparer_Interfaces_Part1
{
    public class CompareStudent : IComparer<Student>
    {
        // Methods
        /*
        // First Way :
        public int Compare(Student? student1, Student? student2)
        {
            if (student1.MarksStudent == student2.MarksStudent)
            {
                return 0;
            }
            if (student1.MarksStudent < student2.MarksStudent)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        */

        // Second Way :
        public int Compare(Student? student1, Student? student2)
        {
            return student1.MarksStudent.CompareTo(student2.MarksStudent);
        }
    }
}
