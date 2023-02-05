using System;
// events are the mechanism for comunication between the objects 

// 3 steps to implement the event 
// 1 - define a delegate 
// 2 - define an event based on that delegate
// 3 - Raise the event 

namespace EventsandDelegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); // publisher 
            var mailService = new MailService();    //subscriber
            var messageService = new MessageService(); // new subscriber

            //subscribing
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }

    }
}