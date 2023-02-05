using System;
using System.Threading.Channels;


// A delegate is a pointer to function 
// it's an object that knows hot to call a methode or a group of methods

namespace Delegates
{
    public class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();

            var filters = new PhotoFilters();

            // PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;

            filterHandler += filters.ApplyContrast;

            filterHandler += RemoveRedEyeFilter;

            processor.Process("photo.jpg",filterHandler);
        }

        // creating a new filter 
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Apply remove red eye filter");
        }
    }
}