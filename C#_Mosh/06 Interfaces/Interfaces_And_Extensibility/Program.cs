namespace Interfaces_And_Extensibility
{
    public class Program
    {
        static void Main(string[] args)
        {
            DbMigrator dbMigrator1 = new DbMigrator(new Consolelogger());
            dbMigrator1.Migrate();


            DbMigrator dbMigrator2 = new DbMigrator(new FileLogger(@"C:\Users\Youssef Baba\Desktop\My_Computer\log.txt"));
            dbMigrator2.Migrate();
        }
    }
}