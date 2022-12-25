namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            PhotoProcessor processor = new PhotoProcessor();
            PhotoFilters filter = new PhotoFilters();
            Action<Photo> filterHandler = filter.ApplyBrightness;  // Delegate points to one method
            filterHandler += filter.ApplyContrast;  // Delegate points to more than one method
            filterHandler += RemoveRedEyeFilter;    // Delegate points to more than one method
            processor.Process("photo.jpg" , filterHandler);
        }
        public static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply RemoveRedEye");
        }
    }
}