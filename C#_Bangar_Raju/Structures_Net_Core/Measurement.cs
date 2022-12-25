namespace Structures_Net_Core
{
    public struct Measurement
    {

        // Properties   
        public double Value { get; set; }
        public string Description { get; set; }

        // Constructors
        public Measurement()
        {
            Value = double.NaN;
            Description = "Undefined";
        }

        public Measurement(double value, string description)
        {
            Value = value;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Value} ({Description})"; 
        }

        static void Main(string[] args)
        {

            Measurement m1 = new Measurement(); // NaN (Undefined)
            Console.WriteLine(m1);
            /*
            Measurement m2 = new Measurement(20, "Hello");
            Console.WriteLine(m2); // 20 (Hello)
            Measurement m3 = default;
            Console.WriteLine(m3); // 0 ()
            Measurement[] m4 = new Measurement[2];
            Console.WriteLine(String.Join(" , ", m4));  // 0 () , 0 ()
            */


        }
    }

    
}
