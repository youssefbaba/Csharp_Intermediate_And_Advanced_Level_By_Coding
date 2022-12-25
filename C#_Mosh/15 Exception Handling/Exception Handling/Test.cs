namespace Exception_Handling
{
    public class Test
    {
        static void Main(string[] args)
        {
			try
			{
                YoutubeApi youtubeApi = new YoutubeApi();
                List<Video> videos = youtubeApi.GetVideos("Marks"); 
			}
			catch (Exception exception)
			{
                Console.WriteLine($"Inner Exceptin : {exception.InnerException.Message}");
                Console.WriteLine($"Current Exception : {exception.Message}");
			}
        }
    }
}
