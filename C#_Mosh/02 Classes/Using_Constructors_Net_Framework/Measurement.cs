
using System.CodeDom;

namespace Using_Constructors_Net_Framework
{
    public struct Measurement
    {
        // Fields
        public double Value { get; set; }
        public string Description { get; set; }

        // Constructors

        //public Measurement() // structs can't contain an explicit parameterless constructor because one is provided automatically by the compile in less than C# 10.0
        //{
        //    Value = double.NaN;
        //    Description = "Undefined";
        //}

        public Measurement(double value , string description)
        {
            Value = value;
            Description = description;
        }
    }
}
