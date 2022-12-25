namespace Properties_Part2
{
    public class Customer
    {
        // Fields
        int _customerId;
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
        public int CustomerId
        {
            get { return _customerId; }
            //set { _customerId= value; }
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
            get { return _balance;}
            set
            {
                if (_status == true && value >= 500)
                {
                    _balance = value;
                }
            }
        }
    }
}