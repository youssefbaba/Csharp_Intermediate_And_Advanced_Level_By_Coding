
namespace Constructors_Overview
{
    public class Location
    {
        // Using expression body definition : 

        // Fields
        private string _locationName;

        // Properties
        public string Name
        {
            get => Name;
            set => Name = value;
        }

        // Constructors 
        public Location(string name) => _locationName = name;

        // Remaining implementation of Location class.
    }
}
