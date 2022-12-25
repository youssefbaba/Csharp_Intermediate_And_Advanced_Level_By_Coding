namespace ThisKeyword
{
    public class Customer
    {
        // Fields
        int _id;
        string _name;
        float _balance;


        // Constructors
        /*
        public Customer(int _id)
        {
            this_id = _id;
        }
        */
        /*
        public Customer(int _id, string _name, float _balance) : this(_id)
        {
            this._name = _name;
            this._balance = _balance;
        }
        */
        public Customer(int id)
        {
            _id = id;
        }
        public Customer(int id, string name, float balance) : this(id)
        {
            _name = name;
            _balance = balance;
        }
        public object this[string key]
        {
            get
            {
                switch (key)
                {
                    case "id":
                        return _id;
                    case "name":
                        return _name;
                    case "balance":
                        return _balance;
                    default:
                        throw  new InvalidOperationException("This field not found");
                }
            }
        }

    }
}
