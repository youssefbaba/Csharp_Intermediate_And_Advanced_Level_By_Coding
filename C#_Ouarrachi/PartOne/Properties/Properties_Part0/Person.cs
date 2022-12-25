namespace Properties_Part0
{
    public class Person
    {
        // Fields
        int _age;   // it is private by default


        // Constructors
        public Person(int age)
        {
            _age = age;
        }


        // Methods
        /*
        public int GetAge()
        {
            return _age;
        }
        public void SetAge(int value)
        {
            _age = value;   
        }
        */


        // Properties
        public int Age // Read-Write property
        {
            get { return _age; }    // Set Accessor
            set
            {                   // Get Accessor
                if (value < 0)
                {
                    Console.WriteLine("Error : Invalid age.");
                }
                else
                {
                    _age = value;
                }
            }
        }

    }
}