namespace Interfaces_And_Extensibility
{
    public class DbMigrator
    {
        // Fields
        private readonly Ilogger _logger;


        // Constructors
        public DbMigrator(Ilogger logger)
        {
            _logger = logger;
        }


        // Methods
        public void Migrate()
        {
            _logger.LogInfo($"Migration started at {DateTime.Now}");

            // Details of migrating a database

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
