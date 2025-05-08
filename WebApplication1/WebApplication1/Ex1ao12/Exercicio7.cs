namespace WebApplication1.Ex1ao12
{
    public class Ex07
    {
        public static void Executar()
        {
            Action<string> log = null;

            log?.Invoke("Mensagem que não da erro.");
            log += msg => Console.WriteLine($"[INFO]: {msg}");
            log?.Invoke("Agora com delegate configurado.");
        }
    }
}
