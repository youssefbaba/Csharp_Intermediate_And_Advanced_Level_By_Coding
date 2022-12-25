namespace Events_Part2
{
    public class VideoEventArgs : EventArgs
    {
        // Properties
        public Video Video { get; set; }


        // Constructors 
        public VideoEventArgs(Video video)
        {
            Video = video;
        }
    }

}