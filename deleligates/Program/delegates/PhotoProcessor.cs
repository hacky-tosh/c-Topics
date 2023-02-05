using System.Reflection.Metadata;
using Microsoft.VisualBasic;
using SystemException = System.SystemException;

namespace Delegates;

public class PhotoProcessor
{

    // public delegate void PhotoFilterHandler(Photo photo);
    // removing user defiend delegate DateAndTime using System defined Action deligate 
    // public void Process(string path,PhotoFilterHandler filterHandler)
    public void Process(string path,Action<Photo> filterHandler)
    {

        // System.Action<> delegate 
        // System.Func<>



        var photo = Photo.Load(path);


        // var filters = new PhotoFilters();
        // filters.ApplyBrightness(photo);
        // filters.ApplyContrast(photo);
        // filters.Resize(photo);


        filterHandler(photo);
        photo.Save();

    }
}