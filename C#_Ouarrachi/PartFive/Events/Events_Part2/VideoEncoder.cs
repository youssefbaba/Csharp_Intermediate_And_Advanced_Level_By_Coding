namespace Events_Part2
{
    public class VideoEncoder
    {
        /*
         - EvenHandler
         - EvenHandler<TEventArgs>
         */

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);       // Define a delegate , wich parameter object represent source of event or the class publisher , EventArgs any additional data we want to send when the event
        //public event VideoEncodedEventHandler VideoEncoded;     // Define an event based on that delegate
        public event EventHandler<VideoEventArgs> VideoEncoded;     // Define an event based on that delegate

        // Methods
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)   // Raise or publish the event 
        {
            if (VideoEncoded != null)
            {
                //VideoEncoded.Invoke(this, EventArgs.Empty);     // Notify of the subscribers
                VideoEncoded(this, new VideoEventArgs(video));     // Notify of the subscribers
            }
        }
    }
}