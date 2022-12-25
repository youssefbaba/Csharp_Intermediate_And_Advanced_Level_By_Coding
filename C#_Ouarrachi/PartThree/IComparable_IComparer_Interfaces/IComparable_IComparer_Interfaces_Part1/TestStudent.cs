namespace IComparable_IComparer_Interfaces_Part1
{
    public class TestStudent
    {

        /*
         
         - if we have a collection of simple type (int , double , string , ...) we can use directly the Sort() method to sort that collection .
         - if we have a collection of complex type (user-defined class) we can use IComparable and IComparer interfaces to sort that collectio .
         
         */
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 103, 106, 104, 102, 101, 105 };
            Console.WriteLine("Before Sorting :");
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("After Sorting :");
            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Student student1 = new Student(103, "David", 10, 575.0);
            Student student2 = new Student(106, "Marks", 10, 535.0);
            Student student3 = new Student(104, "Bernard", 10, 592.0);
            Student student4 = new Student(102, "Jim", 10, 453.0);
            Student student5 = new Student(101, "Sam", 10, 512.0);
            Student student6 = new Student(105, "Adam", 10, 498.0);
            List<Student> students = new List<Student> { student1, student2, student3, student4, student5, student6 }; // Collection Initializer

            Console.WriteLine("Before Sorting :");
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }
            Console.WriteLine();
            Console.WriteLine();
            students.Sort();
            Console.WriteLine("After sorting the list based on IdStudent in ascending order :");
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }
            Console.WriteLine();
            Console.WriteLine();
            students.Reverse();
            Console.WriteLine("After sorting the list based on IdStudent in descending order :");
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }
            Console.WriteLine();
            Console.WriteLine();
            students.Sort(new CompareStudent());
            Console.WriteLine("After sorting the list based on MarksStudent in ascending order :");
            foreach (Student student in students)
            {
                Console.WriteLine($"IdStudent = {student.IdStudent} - NameStudent = {student.NameStudent} - ClassStudent = {student.ClassStudent} - MarksStudent = {student.MarksStudent}");
            }




        }
    }
}