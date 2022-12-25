namespace Events
{
    // 1 - Define a delegate
    // 2 - Define an event based on that delegate
    // 3 - Raise or Publish the event

    // Define a delegate
    public delegate void VideoEncodedEventHandler(object source, EventArgs args);


    public class VideoEncoder
    {
        // Define an event based on that delegate
        public event VideoEncodedEventHandler VideoEncoded;


        // Methods
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video ...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }
        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this , EventArgs.Empty);
            }
        }
    }
}
