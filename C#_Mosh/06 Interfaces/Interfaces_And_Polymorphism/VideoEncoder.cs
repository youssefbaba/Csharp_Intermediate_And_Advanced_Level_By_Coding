namespace Interfaces_And_Polymorphism
{
    public class VideoEncoder
    {
        // Fields
        private readonly List<INotificationChannel> _notificationChannels;


        // Constructors
        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }
        public void Encode(Video video)
        {
            // Video Encoding logic ...
            // ...

            foreach (INotificationChannel notificationChannel in _notificationChannels)
            {
                notificationChannel.Send(new Message());   // Polymorphism => if run-time type of notificationChannel is SmsNotificationChannel it will be execute Send method that finds in SmsNotificationChannel class
            }                                              // Polymorphism => if run-time type of notificationChannel is MailNotificationChannel it will be execute Send method that finds in MailNotificationChannel class
        }
        public void RegistrationNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}