namespace StaticClass
{
    public static class StaticClass
    {
        // Fields
        //int _id;  // Error : we cannot declare instance member inside static class
        static int _id;
        static string _name;
        static int _age;


        // Constructor
        /*
        public StaticClass(int id , string name , int age)  // Static classes cannot have Instance constructors
        {
            _id = id;
            _name = name;
            _age = age;
        }
        */

        static StaticClass()    // Static Constrsutor
        {
            _id = default;
            _name = default;
            _age = default;
        }


        // Methods
        /*
        public void Test()  // we cannot declare instance member inside static class
        {
            // Some statement here ...
        }
        */

        public static void Test1()
        {
            // Some statement here ...
        }

    }
}
