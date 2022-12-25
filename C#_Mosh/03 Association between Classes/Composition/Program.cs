namespace Composition
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator = new DbMigrator(new Logger());
            dbMigrator.Migrate();


            Logger logger = new Logger();
            Installer installer = new Installer(logger);    
            installer.Install();
        }
    }
}