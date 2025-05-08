namespace WebApplication1.Ex1ao12
{
    public class Logger
    {
        public static void LogToConsole(string mensagem) => Console.WriteLine($"Console: {mensagem}");
        public static void LogToFile(string mensagem) => Console.WriteLine($"Arquivo : {mensagem}");
        public static void LogToDatabase(string mensagem) => Console.WriteLine($"Banco de Dados : {mensagem}");
    }

    public class Ex06
    {
        public static void Executar()
        {
            Action<string> log = Logger.LogToConsole;
            log += Logger.LogToFile;
            log += Logger.LogToDatabase;

            log("Registro de log com multicast delegate.");
        }
    }
}
