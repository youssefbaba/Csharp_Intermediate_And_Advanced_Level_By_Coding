
namespace Classes_Objects_Constructor
{
    public class Car
    {
        // Fields
        public string Number;
        public string Color;

        // Constructor
        //Default Constructor is provided by .Net by default when any of custom Constructors were define , otherwise i must define its

        public void DisplayDetails()
        {
            if (Number == null && Color == null)
            {
                Console.WriteLine($"Number = 'No Value', Color = 'No Value' ");
            }
            else
            {
                Console.WriteLine($"Number = '{Number}', Color = '{Color}' ");
            }
        }
    }
}
