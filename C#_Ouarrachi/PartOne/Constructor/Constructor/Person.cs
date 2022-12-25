namespace Constructor
{
    public class Person
    {
        // Fields
        private string _name;
        private int _age;


        // Constructors
        public Person()
        {
            _name = "Ahmed";
        }
        public Person(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }
}
