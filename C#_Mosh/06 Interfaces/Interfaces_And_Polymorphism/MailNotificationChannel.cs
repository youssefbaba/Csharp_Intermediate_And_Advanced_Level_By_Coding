namespace Interfaces_And_Polymorphism
{
    public class MailNotificationChannel : INotificationChannel
    {
        // Methods
        public void Send(Message message)
        {
            Console.WriteLine("Sending Mail ...");
        }
    }
}