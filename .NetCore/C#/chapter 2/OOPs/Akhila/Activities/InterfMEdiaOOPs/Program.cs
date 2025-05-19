namespace InterfMEdiaOOPs
{
    interface IAudioPlayer
    {
        public void PlayAudio();
    }
    interface IVideoPlayer
    {
        public void PlayVideo();
    }
    class MediaPlayer: IAudioPlayer, IVideoPlayer
    {
        public void PlayAudio()
        {
            Console.WriteLine("Play Audio");
        }
        public void PlayVideo()
        {
            Console.WriteLine("Play Video");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.PlayAudio();
            mediaPlayer.PlayVideo();
        }
    }
}
