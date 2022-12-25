namespace Properties
{
    public class Person
    {
        // Fields
        private string _name;


        // Constutors
        public Person()
        {

        }
        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }


        // Methods
        public void ChangeDate()
        {
           BirthDate = DateTime.Now;    
        }


        // Properties
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name = "DefaultName";
                }
                else
                {
                    _name = value;
                }
            }
        }
        //public DateTime BirthDate { get;}     // like readonly modifier that property set only in construtor or here
        //public DateTime BirthDate { get; set; }     // Auto-implemented property
        //public DateTime BirthDate { get; private set; } = new DateTime(1996, 12, 01); // First Approach
        public DateTime BirthDate { get; private set; }  // Second Approach
        public int Age
        {
            get
            {
                TimeSpan time = DateTime.Today - BirthDate;
                return time.Days / 365;
            }
        }

    }
}
