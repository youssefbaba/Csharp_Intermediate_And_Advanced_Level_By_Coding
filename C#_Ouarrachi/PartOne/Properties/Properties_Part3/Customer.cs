namespace Properties_Part3
{
    public class Customer
    {
        // Fields
        int _customerId;
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
        public int CustomerId
        {
            get { return _customerId; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string CustomerName
        {
            get { return _customerName; }
            set
            {
                if (_status == true)
                {
                    _customerName = value;
                }
            }
        }
        public double Balance
        {
            get { return _balance; }
            set
            {
                if (_status == true && value >= 500)
                {
                    _balance = value;
                }
            }
        }
        public Cities City
        {
            get { return _city; }
            set
            {
                if (_status == true)
                {
                    _city = value;
                }
            }
        }
        // protected string State  // get and set accessible only by child class
        public string State  // get and set accessible only by child class
        {
            get { return _state; } // it takes the global scope which is public
            //set           // it takes the global scope which is public
            //private set   // it takes local scope which is private (can be accessible only within class)
            protected set   // it takes local scope which is protected (can be accessible only by child class)
            {
                if (_status == true)
                {
                    _state = value;
                }
            }
        }
        // Auto-Implemented property 
        //public string Country { get; set; } // ReadWrite Auto-Implemented property .
        public string Country { get; } = "Morocco";  // Readonly Auto-Implemented property .
        // public string Country { set; } // Compile time error : Auto-implemented properties must have get accessors.
    }
}