namespace Composition
{
    public class Installer
    {
        // Fields
        private readonly Logger _logger;    // Composition Relationship


        // Constructors
        public Installer(Logger logger)
        {
            _logger = logger;
        }


        // Methods
        public void Install()
        {
            _logger.Log("We are installing the application.");
        }
    }
}
