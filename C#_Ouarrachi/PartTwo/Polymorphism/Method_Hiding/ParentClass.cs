namespace Method_Hiding
{
    internal class ParentClass
    {
        // Methods
        public virtual void Test1()  // Overridable method
        {
            Console.WriteLine("Method Test1 from parent class.");
        }
        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class.");
        }
        public virtual void Test3()  // Overridable method
        {
            Console.WriteLine("Method Test3 from parent class.");
        }
    }
}
