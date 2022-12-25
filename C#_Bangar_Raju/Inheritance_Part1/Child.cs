
namespace Inheritance_Part1
{
    internal class Child : Parent
    {

        // Constructors
        public Child()
        {
            Console.WriteLine("Child parameterless constructor is called");
        }
        public Child(string firstname, string lastName, float wealth) : base(firstname, lastName, wealth)
        {
            Console.WriteLine("Child parameterized contructor is called");
        }


        // Methods
        public void Test4()
        {
            Console.WriteLine("Method 4");
        }
        static void Main()
        {
            Child child = new Child();
            child.Test1();
            child.Test2();
            //child.Test3();  // Not Inheritable because it's private method
            child.Display();
            child.Test4();


            Child child1 = new Child("Youssef", "Baba", 21000000.00f);
            child1.Test1();
            child1.Test2();
            //child1.Test3();  // Not Inheritable because it's private method
            child1.Display();
            child1.Test4();


            Parent parent = new Parent();
            parent.Test1(); 
            parent.Test2();
            parent.Display();


            Parent parent2; // parent2 is variable of Parent (uninitialized copy)
            Child child2 = new Child(); // child2 is instance of Child
            //parent2 = new Child(); // Option 1
            parent2 = child2; // Option 2 :  parent2 is reference of parent class created by using child class instance (pointer)
            parent2.Test1();
            parent2.Test2();
            parent2.Display();
            //parent2.Test4(); // Impossible because parent2 cannot be accessible to any child member 


        }
    }
}
