namespace IComparable_IComparer_Interfaces_Part1
{
    public class Student : IComparable<Student>
    {
        // Constructors
        public Student(int idStudent, string nameStudent, int classStudent, double marksStudent)
        {
            IdStudent = idStudent;
            NameStudent = nameStudent;
            ClassStudent = classStudent;
            MarksStudent = marksStudent;
        }


        // Methods
        /*
        // First Way to sort list based on IdStudent in ascending order
        public int CompareTo(Student? other)
        {

            if (IdStudent == other.IdStudent)
            {
                return 0;
            }
            if (IdStudent < other.IdStudent)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
        */

        /*
        // First Way : To sort list based on IdStudent in descending order
        public int CompareTo(Student? other)
        {

            if (IdStudent == other.IdStudent)
            {
                return 0;
            }
            if (IdStudent < other.IdStudent)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        */


        // Second Way : To sort list based on IdStudent in ascending order
        public int CompareTo(Student? other)
        {
            return IdStudent.CompareTo(other.IdStudent);
        }


        /*
        // Second Way : To sort list based on IdStudent in descending order
        public int CompareTo(Student? other)
        {
            return -(IdStudent.CompareTo(other.IdStudent));
        }
        **/


        /*
        // First Way : To sort list based on NameStudent in ascending order
        public int CompareTo(Student? other)
        {
            return NameStudent.CompareTo(other.NameStudent);
        }
        */

        /*
        // First Way : To sort list based on NameStudent in descending order
        public int CompareTo(Student? other)
        {
            return -(NameStudent.CompareTo(other.NameStudent));
        }
        */


        // Properties
        public int IdStudent { get; set; }
        public string NameStudent { get; set; }
        public int ClassStudent { get; set; }
        public double MarksStudent { get; set; }
    }
}