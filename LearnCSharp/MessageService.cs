namespace LearnCSharp
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            var video = e.Video;
            Console.WriteLine($"MessageService: Sending a text message to {video.Author}...");
        }
    }
}
