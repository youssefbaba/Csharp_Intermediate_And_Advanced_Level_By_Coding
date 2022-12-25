namespace Events
{
    public class Program
    {
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1" };
            VideoEncoder videoEncoder= new VideoEncoder();  
            videoEncoder.Encode(video);

        }
    }
    public class MailService
    {
        // Methods
        public void OnVideoEncoded(object source , EventArgs e)
        {
            Console.WriteLine("MailService : Sending an email....");
        }
    }


}