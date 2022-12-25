namespace Access_Modifiers
{
    public class Person
    {
        // Fields
        private string _name;  // Camelcase perfixed by underline
        private DateTime _birthDate; // Camelcase perfixed by underline


        // Methods
        public void SetName(string name)    // Setter
        {
            if (string.IsNullOrEmpty(name))
            {
                _name = "Default Name";
                return;
            }
            _name = name;
        }
        public void SetBirthDate(DateTime birthDate)    // Setter
        {
            _birthDate = birthDate;
        }

        public string GetName()     // Getter
        {
            return _name;
        }
        public DateTime GetBirthDate()      // Getter
        {
            return _birthDate;
        }
    }
}
