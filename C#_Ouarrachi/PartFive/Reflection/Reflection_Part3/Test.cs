namespace Reflection_Part3
{
    public class Test
    {
        // Fields
        public string TestField = "TestString";


        // Properties
        public int TestProp { get; set; }
        public int TestProp2 { get; set; }
        protected int TestProp3 { get; set; }


        // Constructors
        public Test()
        {

        }
        public Test(string testField)
        {
            TestField = testField;
        }


        // Methods
        public void Test1()
        {
            Console.WriteLine("Test1 Method");
        }
        public int Test2()
        {
            return 0;
        }
        public void Test3(string str)
        {
            Console.WriteLine(str);
        }

    }
}