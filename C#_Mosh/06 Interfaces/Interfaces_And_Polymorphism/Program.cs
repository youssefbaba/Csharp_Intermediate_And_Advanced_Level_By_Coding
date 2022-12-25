namespace Interfaces_And_Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             - Polymorphism = multiple form (Execute this method following the run-time type of its object )
            */

            VideoEncoder videoEncoder = new VideoEncoder();
            videoEncoder.RegistrationNotificationChannel(new MailNotificationChannel());
            videoEncoder.RegistrationNotificationChannel(new SmsNotificationChannel());
            videoEncoder.Encode(new Video());
        }
    }
}