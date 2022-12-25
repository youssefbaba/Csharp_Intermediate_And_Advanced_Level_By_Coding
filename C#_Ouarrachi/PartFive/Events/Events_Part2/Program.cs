namespace Events_Part2
{
    public class Program
    {
        /*
         - Events : 
            - A mechanism for communication between objects => when something happens inside an object it can notify other objects about that.
            - Used in building loosly Coupled Applications.
            - Helps extending applications
        - How does the publisher notify its subscribers?
            - for the publisher to notify its subscribers it needs to send a message to them by invoking a method in the subscriber. 
        - But how does the publisher know what method to call ?
            - we need an agreement or a contract between these publishers and subscribers , a method with a specific signature.
        - To puplish an event :
            1- Define a delegate 
            2- Define an event based on that delegate
            3- Raise or publish the event 


         */
        static void Main(string[] args)
        {
            Video video = new Video() { Title = "Video 1" };
            VideoEncoder videoEncoder = new VideoEncoder();         // Publisher
            MailService mailService = new MailService();            // Subscriber
            MessageService messageService = new MessageService();   // Subscriber


            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;        // Subscription
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;     // Subscription


            videoEncoder.Encode(video);
        }
    }
}