namespace WebApplication1.Ex1ao12
{
    public class Ex11
    {
        public static void Executar()
        {
            Func<string, string, string> nomeCompleto = (nome, sobrenome) => nome + " " + sobrenome;
            nomeCompleto += (nome, sobrenome) => (nome + sobrenome).ToUpper();
            nomeCompleto += (nome, sobrenome) => (nome + sobrenome).Replace(" ", "");

            Console.Write("Digite o nome: ");
            var nome = Console.ReadLine();
            Console.Write("Digite o sobrenome: ");
            var sobrenome = Console.ReadLine();

            var resultado = nomeCompleto(nome, sobrenome);
            Console.WriteLine($"Resultado final: {resultado}");
        }
    }
}
