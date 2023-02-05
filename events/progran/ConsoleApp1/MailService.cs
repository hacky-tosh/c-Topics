﻿namespace EventsandDelegates;

public class MailService
{
    // public void OnVideoEncoded(object source, EventArgs e)
     public void OnVideoEncoded(object source, VideoEventArgs e)
    {
        Console.WriteLine("MailService: Sending an Email..." + e.Video.Title);
    }
}