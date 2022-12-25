namespace IComparable_IComparer_Interfaces_Part2
{
    public class Student
    {
        // Constructors
        public Student()
        {
        }
        public Student(int idStudent, string nameStudent, int classStudent, double marksStudent)
        {
            IdStudent = idStudent;
            NameStudent = nameStudent;
            ClassStudent = classStudent;
            MarksStudent = marksStudent;
        }


        // Methods
        /*
        public int CompareNames(Student student1 , Student student2)
        {
            return student1.NameStudent.CompareTo(student2.NameStudent);
        }
        */
        
        // Properties
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public int ClassStudent { get; set; }
        public double MarksStudent { get; set; }
    }
}