namespace Polymorphism_Operator_Overloading
{
    internal class BankAcount
    {
        // Fields
        private double _money;
        private string _owner;

        // Constructors
        public BankAcount(double money, string owner)
        {
            _money = money;
            _owner = owner;
        }

        // Properties
        public double Money
        {
            get
            {
                return _money;
            }
        }
        public string Owner
        {
            get
            {
                return _owner;
            }
        }

        // Methods
        public static BankAcount operator +(BankAcount bank1, BankAcount bank2)
        {
            return new BankAcount(bank1._money + bank2._money, bank1._owner + "+" + bank2._owner);
        }
        public static BankAcount operator +(BankAcount bank1, int number)
        {
            return new BankAcount(bank1._money + number, bank1._owner);
        }
    }
}
