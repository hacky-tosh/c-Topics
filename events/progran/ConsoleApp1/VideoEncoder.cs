namespace EventsandDelegates;
// 3 steps to implement the event 
// 1 - define a delegate 
// 2 - define an event based on that delegate
// 3 - Raise the event


public class VideoEventArgs : EventArgs
{
    public Video Video { get; set; }
}
public class VideoEncoder
{

    // public delegate void VideoEncodeEventHandler(object source, EventArgs args);


    // instead of making a new delegate for an event we can use predifined delegates 
    // EventHandler
    // EventHandler<TEventArgs> "generic type"
    // public delegate void VideoEncodeEventHandler(object source, VideoEventArgs args);

    // public event VideoEncodeEventHandler VideoEncoded;

    public event EventHandler<VideoEventArgs> VideoEncoded; // this line replace line 21 


    public void Encode(Video video)
    {
        Console.WriteLine("Encoding video...");
        Thread.Sleep(3000);

        OnVideoEncoded(video);
    }

    protected virtual void OnVideoEncoded(Video video)
    {
        if (VideoEncoded != null)
        {
            // VideoEncoded(this, EventArgs.Empty);
            VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }
}