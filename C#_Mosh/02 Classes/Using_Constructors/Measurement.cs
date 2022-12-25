
namespace Using_Constructors
{
    public struct Measurement
    {
        // Fields 
        public double Value { get; set; } // default value of field Value is 0
        //public string? Description { get; set; } // default value of field Description is null
        public string Description { get; set; } // default value of field Description is null

        // Constructor
        //public Measurement()
        //{
        //    Value = double.NaN;
        //    Description = default(string);
        //}

        //public Measurement()
        //{
        //    Value = default(double);
        //    Description = "Undifined";
        //}
        public Measurement()
        {
            Value = double.NaN;
            Description = "Undifined";
        }

        public Measurement(double value , string description)
        {
            Value=value;
            Description=description;
        }
    }
}
