namespace Inheritance
{
    public class Text:PresentationObject
    {
        // Code specific to Text
        // Methods
        public void AddHyperLink(string url)
        {
            Console.WriteLine($"We added a link to {url}");
        }


        // Properties
        public int FontSize { get; set; }
        public string FontName { get; set; }
    }
}
