namespace Interfaces_And_Extensibility
{
    public interface Ilogger
    {
        // Methods
        void LogError(string message);      // By default it is abstrat and public
        void LogInfo(string message);       // By default it is abstrat and public
    }
}
