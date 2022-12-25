namespace Polymorphism_Method_Hiding
{
    internal class Test
    {
        static void Main(string[] args)
        {
            ChildClass child = new ChildClass();
            child.Test1(); // Test1() from ChildClass
            child.Test2(); // Test2() from ChildClass

            child.DisplayParentMembers();
            ChildClass.PrintParentMembers();

            ParentClass parent = new ChildClass(); // parent is a reference of parent class created by using child instance
            parent.Test1(); // Test1() from ChildClass
            parent.Test2(); // Test2() from ParentClass

        }
    }
}