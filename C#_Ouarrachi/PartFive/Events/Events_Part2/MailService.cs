namespace Events_Part2
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs args) // Event Handler
        {
            Console.WriteLine($"MailService : Sending an email... {args.Video.Title}");
        }
    }

}