namespace Delegates
{
    // - Defining a delagate which is a new type (reference type)
    //public delegate void PhotoFilterHandler(Photo photo);


    // Instide of defining a delagate we can use predefining delagte : Action<> , Func<> , Predicate<>$
    
    
    public class PhotoProcessor
    {
        public void Process(string path , Action<Photo> filterHandler)
        {
            Photo photo = Photo.Load(path);

            PhotoFilters filter = new PhotoFilters();
            
            /*
            filter.ApplyBrightness(photo);
            filter.ApplyContrast(photo);
            filter.Resize(photo);
            */


            filterHandler(photo);
            

            photo.Save();
        }
    }
}