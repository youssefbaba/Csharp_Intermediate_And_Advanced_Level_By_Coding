namespace Composition
{
    public class DbMigrator
    {
        // Fields
        private readonly Logger _logger;    // Composition Relationship


        // Constructors
        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }


        // Methods
        public void Migrate()
        {
            _logger.Log("We are migarting the table.");
        }
    }
}
