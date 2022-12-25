namespace Properties_Part2
{
    public class Customer
    {
        // Fields
        int _customerId; // this field is private by default
        bool _status;
        string _customerName;
        double _balance;

        // Constructors
        public Customer(int customerId, bool status, string customerName, double balance)
        {
            _customerId = customerId;
            _status = status;
            _customerName = customerName;
            _balance = balance;
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
                if (_status && (value >= 100))
                {
                    _balance = value;
                }
            }
        }
    }
}
