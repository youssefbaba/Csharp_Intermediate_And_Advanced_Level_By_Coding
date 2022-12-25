namespace ReadonlyKeyword
{
    public class Person
    {
        // Fields
        string _name;
        // First case :
        // readonly int _age = 20;
        // Second case :
        readonly int _age;
        //readonly Employee employee // Readonly field can take reference type as a value


        // Constructors
        public Person()
        {
        }

        // First case ;
        /*
        public Person(string name )
        {
            _name= name;
        }
        */

        // Second case : 
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }


        // Methods
        public void Test()
        {
            //_age = 25; // Compile time error : A readonly field cannot be assigned to , except in a constructor or variable initializer or init-only setter
            Console.WriteLine($"Age = {_age}");
        }
        
    }
}