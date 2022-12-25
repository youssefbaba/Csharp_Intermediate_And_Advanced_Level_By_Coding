
namespace Polymorphism_Method_Hiding
{
    internal class ChildClass : ParentClass
    {
        // Methods
        public override void Test1() // Method Overriding
        {
            Console.WriteLine("Method Test1 from child class.");
        }
        public new void Test2() // Method Hiding/Shadowing
        {
            Console.WriteLine("Method Test2 from child class.");
        }
        public new void ParentTest1()
        {
            base.Test1();
        }
        public new void ParentTest2()
        {
            base.Test2();
        }

        public void DisplayParentMembers()
        {
            ParentClass parent = new ParentClass();
            parent.Test1();
            parent.Test2();

            base.Test1();
            base.Test2();
        }
        public static void PrintParentMembers()
        {
            ParentClass parent = new ParentClass();
            parent.Test1();
            parent.Test2();
            
            ChildClass child = new ChildClass();
            child.ParentTest1();
            child.ParentTest2();
        }
    }
}
