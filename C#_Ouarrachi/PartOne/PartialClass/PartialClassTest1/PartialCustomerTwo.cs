namespace PartialClassTest1
{
    public partial class PartialCustomer
    {
        // Methods
        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }
    }
}
