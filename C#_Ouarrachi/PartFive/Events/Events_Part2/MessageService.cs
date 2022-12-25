namespace Events_Part2
{
    public class MessageService
    {
        public void OnVideoEncoded(object source , VideoEventArgs args)
        {
            Console.WriteLine($"MessageService : sending a text message... {args.Video.Title}");
        }
    }
}