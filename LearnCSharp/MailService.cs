namespace LearnCSharp
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            var video = e.Video;
            Console.WriteLine($"MailService: Sending an email to {video.Author}...");
        }
    }
}
