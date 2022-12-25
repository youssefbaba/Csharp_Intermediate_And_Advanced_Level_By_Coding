namespace StaticConstructor
{
    public class Person
    {
        // Fields
        int _id;
        string _name;
        // static int _age = 30; // static field initialisation at declaration time
        static int _age;



        // Constructors
        public Person()
        {
        }
        public Person(int id , string name) // Instance Constructor
        {
            Console.WriteLine("Instance Constructor Invoked.");
            _id = id;   
            _name = name;
        }
        static Person()
        {
            Console.WriteLine("Static Constrcutor Invoked.");
            _age = 20;
        }

    }
}
