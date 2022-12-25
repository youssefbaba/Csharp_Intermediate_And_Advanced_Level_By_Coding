
namespace Method_Overriding_Test1
{
    public class Student : Person
    {
        public double Note { get; set; }
        public Student(double note ,  string name, int age) : base(name, age)
        {
            Note = note;
            Name = name;
            Age = age;
        }

        public override void Display()
        {
            Console.WriteLine($"Is student");
        }
    }
}
