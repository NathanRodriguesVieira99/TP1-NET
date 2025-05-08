namespace WebApplication1.Ex1ao12
{
    public class DownloadManager
    {
        public event Action DownloadCompleted;

        public void IniciarDownload()
        {
            Console.WriteLine("downloading...");
            Thread.Sleep(2000);
            DownloadCompleted?.Invoke();
        }
    }

    public class Ex05
    {
        public static void Executar()
        {
            var dm = new DownloadManager();
            dm.DownloadCompleted += () => Console.WriteLine("Download completed!");
            dm.IniciarDownload();
        }
    }
}
