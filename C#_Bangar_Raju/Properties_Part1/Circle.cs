namespace Properties_Part1
{
    public class Circle
    {
        // Fields
        double _radius = 12.43; // this field by default is private


        // Methods
        /*
         
        // get and set access to this field _radius
        public double GetRadius() // Provides only get access to the value
        {
            return _radius;
        }
        public void SetRadius(double value) // Provides only set access to the value
        {
            _radius = value;
        }

        */

        /*
        
        // only get access to this field _radius
        public double GetRadius() // Provides only get access to the value
        {
            return _radius;
        } 
        
        */

        /*
        
        // only set access to this field _radius
        public void SetRadius(double value) // Provides only set access to the value
        {
            _radius = value;
        }

        */

        // Properties
        // Read and Write property
        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value > _radius)
                {
                    _radius = value;
                }
            }
        }


        /*
        
        // Read only property
        public double Radius
        {
            get { return _radius; }
        }

        */

        /*
    
        // Write only property
        public double Radius
        {
            set { _radius = value; }
        }

         */





    }
}
