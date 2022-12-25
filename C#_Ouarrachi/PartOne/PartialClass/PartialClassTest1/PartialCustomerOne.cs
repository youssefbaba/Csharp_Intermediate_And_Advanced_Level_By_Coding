namespace PartialClassTest1
{
    public partial class PartialCustomer
    {
        // Fields
        private string _firstName;
        private string _lastName;


        // Properties
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }    
}
