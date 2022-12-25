namespace Interfaces_And_Extensibility
{
    public class Consolelogger : Ilogger
    {
        public void LogError(string message)
        {
            Log(message , ConsoleColor.Red);
        }

        public void LogInfo(string message)
        {
            Log(message, ConsoleColor.Green);
        }

        private static void Log(string message, ConsoleColor messageColor)
        {
            Console.ForegroundColor = messageColor;
            Console.WriteLine(message);
        }
    }
}
