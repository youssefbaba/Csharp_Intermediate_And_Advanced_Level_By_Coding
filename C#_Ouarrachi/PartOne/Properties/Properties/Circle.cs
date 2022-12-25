namespace Properties_Part1
{
    public class Circle
    {
        // Fields
        // public double _radius = 12.43; // Never declare field as public
        double _radius = 12.43; // it is private by default


        // Properties
        public double Radius  // Read Write property
        {
            get { return _radius; }     // Represents a value returning method without parameter
            set
            { // Represent a non-value returning method with parameter

                if (_radius < value)
                {
                    _radius = value;
                }
            }
        }

        /*
        public double Radius  // Readonly property
        {
            get { return _radius; }
        }
        */
        /*
        public double Radius  // Writeonly property
        {
            set { _radius = value; }
        }
        */


        // Methods
        /*
        public double GetRadius()       // Provides only get access to the value
        {
            return _radius;
        }
        public void SetRadius(double value)     // Provides only set access to the value
        {
            _radius = value;
        }
       */
    }
}
