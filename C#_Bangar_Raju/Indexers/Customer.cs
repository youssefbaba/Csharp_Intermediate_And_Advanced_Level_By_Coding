namespace Indexers
{
    public enum Cities
    {
        Tanger,
        Tetouan,
        Fes,
        Casablanca,
        Rabat,
        Marrakech,
        Agadir,
    }
    public class Customer
    {
        // Fields
        int _customerId; // this field is private by default
        bool _status;
        string _customerName;
        double _balance;
        Cities _city;

        // Constructors
        public Customer(int customerId, bool status, string customerName, double balance, Cities city)
        {
            _customerId = customerId;
            _status = status;
            _customerName = customerName;
            _balance = balance;
            _city = city;
        }

        // Indexers 
        public object this[string key]
        {
            get
            {
                switch (key.ToLower())
                {
                    case "customerid":
                        return _customerId;
                    case "status":
                        return _status;
                    case "customername":
                        return _customerName;
                    case "balance":
                        return _balance;
                    case "city":
                        return _city;
                    default:
                        return null;
                }
            }
            set
            {
                switch (key.ToLower())
                {
                    case "customerid":
                        _customerId = (int)value;
                        break;
                    case "status":
                        _status = (bool)value;
                        break;
                    case "customername":
                        _customerName = (string)value;
                        break;
                    case "balance":
                        _balance = (double)value;
                        break;
                    case "city":
                        _city = (Cities)value;
                        break;
                }
            }
        }

        // Methods
        static void Main(string[] args)
        {
            Customer customer = new Customer(100, false, "Youusef Baba", 1200.00, Cities.Casablanca);
            Console.WriteLine($"Costumer Id : {customer["customerId"]}");
            Console.WriteLine($"Costumer Status : {customer["status"]}");
            Console.WriteLine($"Costumer Name : {customer["customerName"]}");
            Console.WriteLine($"Costumer Balance : {customer["balance"]} $");
            Console.WriteLine($"Costumer City : {customer["city"]}");


            customer["status"] = true;
            customer["balance"] = (double)customer["balance"] + 1000.00;
            customer["city"] = Cities.Tanger;


            Console.WriteLine();
            Console.WriteLine("<----------------------->");
            Console.WriteLine();
           

            Console.WriteLine($"Costumer Id : {customer["customerId"]}");
            Console.WriteLine($"Costumer Status : {customer["status"]}");
            Console.WriteLine($"Costumer Name : {customer["customerName"]}");
            Console.WriteLine($"Costumer Balance : {customer["balance"]} $");
            Console.WriteLine($"Costumer City : {customer["city"]}");

        }
    }
}
