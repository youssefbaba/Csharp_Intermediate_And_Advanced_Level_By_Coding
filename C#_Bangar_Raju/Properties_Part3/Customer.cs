namespace Properties_Part3
{
    public class Customer
    {
        // Fields
        int _customerId; // this field is private by default
        bool _status;
        string _customerName;
        double _balance;
        Cities _city;
        string _state;

        // Constructors
        public Customer(int customerId, bool status, string customerName, double balance, Cities city, string state)
        {
            _customerId = customerId;
            _status = status;
            _customerName = customerName;
            _balance = balance;
            _city = city;
            _state = state;
        }

        // Properties
        public int CustomerId  // Read-only Property
        {
            get { return _customerId; }
        }
        public bool Status  // Read-Write Property 
        {
            get { return _status; }
            set { _status = value; }
        }
        public string CustomerName // Read-Write Property 
        {
            get { return _customerName; }
            set
            {
                if (_status)
                {
                    _customerName = value;
                }
            }
        }
        public double Balance // Read-Write Property
        {
            get { return _balance; }
            set
            {
                if (_status && value >= 100)
                {
                    _balance = value;
                }
            }
        }
        public Cities City // Read-Write Property associated with enim
        {
            get { return _city; }
            set
            {
                if (_status)
                {
                    _city = value;
                }
            }
        }
        public string State // Read-Write Property 
        {
            get { return _state; }  // this takes scope of property State (public)
            //private set   // Provides get accessor only inside the class
            protected set   // Provides get accessor only for child class
            {
                if (_status)
                {
                    _state = value;
                }
            }
        }
    }
}
