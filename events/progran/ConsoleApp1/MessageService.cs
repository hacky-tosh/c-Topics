namespace EventsandDelegates;

public class MessageService
{
    // public void OnVideoEncoded(object Source, EventArgs args)
    public void OnVideoEncoded(object Source, VideoEventArgs args)
    {
        Console.WriteLine("MessageService: Sending a text message..."+ args.Video.Title);
    }
}