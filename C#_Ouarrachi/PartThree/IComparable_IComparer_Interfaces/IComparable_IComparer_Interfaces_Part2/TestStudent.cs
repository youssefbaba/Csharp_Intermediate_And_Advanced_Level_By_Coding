namespace IComparable_IComparer_Interfaces_Part2
{
    public class TestStudent
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(103, "David", 10, 575.0);
            Student student2 = new Student(106, "Marks", 10, 535.0);
            Student student3 = new Student(104, "Bernard", 10, 592.0);
            Student student4 = new Student(102, "Jim", 10, 453.0);
            Student student5 = new Student(101, "Sam", 10, 512.0);
            Student student6 = new Student(105, "Adam", 10, 498.0);
            List<Student> students = new List<Student> { student1, student2, student3, student4, student5, student6 }; // Collection Initializer
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }
            Console.WriteLine();
            Console.WriteLine();
            students.Sort(1 , 4 ,new CompareStudent());
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Comparison<Student> obj = new Comparison<Student>(new Student().CompareNames);

            /*
            Comparison<Student> obj = new Student().CompareNames;
            students.Sort(obj);
            */

            //students.Sort(new Student().CompareNames);

            /*
            Comparison<Student> obj = delegate (Student student1, Student student2)   // Using anonymous method
            {
                return student1.NameStudent.CompareTo(student2.NameStudent);
            };
            students.Sort(obj);
            */
            
            //students.Sort(delegate (Student student1, Student student2) {return student1.NameStudent.CompareTo(student2.NameStudent);});
            
            /*
            Comparison<Student> obj = (student1, student2) => student1.NameStudent.CompareTo(student2.NameStudent);  // Using lambda expression
            students.Sort(obj);
            */

            students.Sort((student1, student2) => student1.NameStudent.CompareTo(student2.NameStudent));
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }
        }
    }
}