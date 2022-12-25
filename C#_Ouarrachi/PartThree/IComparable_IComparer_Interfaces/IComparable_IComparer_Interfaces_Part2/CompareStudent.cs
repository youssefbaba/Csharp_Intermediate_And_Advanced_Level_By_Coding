namespace IComparable_IComparer_Interfaces_Part2
{
    public class CompareStudent : IComparer<Student>
    {
        // Methods
        public int Compare(Student? student1, Student? student2)
        {
            return student1.MarksStudent.CompareTo(student2.MarksStudent);
        }
    }
}