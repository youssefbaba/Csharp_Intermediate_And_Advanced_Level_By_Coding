namespace Inheritance
{
    public class PresentationObject
    {
        // Common shared code
        // Methods
        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }


        // Properties
        public double Width { get; set; }
        public double Height { get; set; }  
    }
}
