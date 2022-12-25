namespace Method_Hiding
{
    internal class ChildClass : ParentClass
    {
        // Methods
        public override void Test1()    // Method Overriding which is optional and requires permission from parent class
        {
            Console.WriteLine("Method Test1 from child class.");
        }
        public new void Test2()     // Method Hiding which doesn't require any permission from parent class
        {
            Console.WriteLine("Method Test2 from child class.");
        }
        public new void Test3()     // Method Hiding which doesn't require any permission from parent class
        {
            Console.WriteLine("Method Test3 from child class.");
        }
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        public void ParentTest3()
        {
            base.Test3();
        }
        static void Main(string[] args)
        {
            ParentClass parent = new ParentClass(); // parent is instance of parent class
            parent.Test1();
            parent.Test2();
            parent.Test3();

            Console.WriteLine();

            ChildClass child = new ChildClass(); // child is instance of child class
            child.Test1();
            child.Test2();
            child.Test3();
            child.ParentTest1();
            child.ParentTest2();
            child.ParentTest3();

            Console.WriteLine();

            //base.Test1(); // Compile time error : because base keyword is not available in static blocks
            //base.Test2(); // Compile time error : because base keyword is not available in static blocks
            //base.Test3(); // Compile time error : because base keyword is not available in static blocks

            ParentClass parent1 = child; // parent1 is a reference of parent class created by using the child class instance
            parent1.Test1(); // Invokes child class method
            parent1.Test2();   // Invokes parent class method
            parent1.Test3();   // Invokes parent class method


        }
    }
}
