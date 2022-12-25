namespace Exception_Handling
{
    public class YoutubeApi
    {
        // Methods
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube web Service
                // Read Data
                // Create a list of Video objects
                throw new Exception("Oops some low level Youtube error.");

            }
            catch (Exception exception)
            {
                // Log
                throw new YoutubeException("Could not fetch videos from Youtube.", exception); // Throw an Exception
            }
        }
    }
}
