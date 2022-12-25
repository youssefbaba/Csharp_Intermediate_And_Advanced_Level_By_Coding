namespace Collections_Part6
{
    public class Student : IComparable<Student>
    {
        // Properties
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }
        

        // - Sorting by StudentId : Increasing order  
        public int CompareTo(Student? other)  
        {
            if (StudentId > other.StudentId)
            {
                return 1;
            }else if (StudentId < other.StudentId)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        /*
         
        // - Sorting by Marks 
        public int CompareTo(Student? other)
        {
            if (Marks > other.Marks)
            {
                return 1;
            }
            else if (Marks < other.Marks)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        */

        /*

        // Sorting by Name
        public int CompareTo(Student? other)
        {
            return Name.CompareTo(other.Name);
        }

        */
    }
}
