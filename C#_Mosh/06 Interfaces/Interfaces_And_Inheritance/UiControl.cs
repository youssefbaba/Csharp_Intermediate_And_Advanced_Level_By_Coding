namespace Interfaces_And_Inheritance
{
    public class UiControl
    {
        // Methods
        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }


        // Properties
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position TopLeft { get; set; }
    }
}