namespace Interfaces_And_Extensibility
{
    public enum MessageType
    {
        ERROR,
        INFO
    }
    public class FileLogger : Ilogger
    {
        // Fields
        private readonly string _path;


        // Constructors
        public FileLogger(string path)
        {
            _path = path;
        }


        // Methods
        public void LogError(string message)
        {
            Log(message, MessageType.ERROR);
        }
        public void LogInfo(string message)
        {
            Log(message, MessageType.INFO);
        }
        private void Log(string message, MessageType messageType)
        {
            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine($"{messageType} : {message} => {DateTime.Now}");
                //streamWriter.Dispose();  // it is used by default to dispose resourses
            }
        }
    }
}
