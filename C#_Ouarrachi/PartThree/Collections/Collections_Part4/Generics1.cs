namespace Collections_Part4
{
    /*
     - Generic method : makes type safe and performs operations without boxing and unboxing .
     
     */
    public class Generics1
    {
        // Methods

        /*
        public bool Compare(int value1, int value2)
        {
            return (value1 == value2) ? true : false;
        }
        public bool Compare(float value1, float value2)
        {
            return (value1 == value2) ? true : false;
        }
        public bool Compare(double value1, double value2)
        {
            return (value1 == value2) ? true : false;
        }
        public bool Compare(string value1, string value2)
        {
            return (value1 == value2) ? true : false;
        }
        public bool Compare(bool value1, bool value2)
        {
            return (value1 == value2) ? true : false;
        }
                        .
                        .
                        .
                        .

        */

        /*
        public bool Compare(object value1, object value2)
        {
            return value1.Equals(value2) ? true : false;
        }
        */

        // Generic method
        public bool Compare<T>(T value1, T value2)
        {
            return value1.Equals(value2) ? true : false;
        }

    }
}