namespace Collection_Part7
{
    public class Student
    {
        // Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        // Methods
        // Comparison based on Marks
        public static int CompareMarks(Student std1, Student std2)
        {
            if (std1.Marks > std2.Marks)
            {
                return 1;
            }
            else if (std1.Marks < std2.Marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        //// Comparison based on Name
        //public static int CompareName(Student std1, Student std2)
        //{
        //    return std1.Name.CompareTo(std2.Name);
        //}
    }
}
