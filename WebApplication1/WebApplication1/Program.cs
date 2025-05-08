using System;

namespace WebApplication1.Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU DE EXERC�CIOS ====");
                for (int i = 1; i <= 12; i++)
                {
                    Console.WriteLine($"{i} - Exerc�cio {i}");
                }
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma op��o: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": Ex1ao12.Ex01.Executar(); break;
                    case "2": Ex1ao12.Ex02.Executar(); break;
                    case "3": Ex1ao12.Ex03.Executar(); break;
                    case "4": Ex1ao12.Ex04.Executar(); break;
                    case "5": Ex1ao12.Ex05.Executar(); break;
                    case "6": Ex1ao12.Ex06.Executar(); break;
                    case "7": Ex1ao12.Ex07.Executar(); break;
                    case "8": Ex1ao12.Ex08.Executar(); break;
                    case "9": Ex1ao12.Ex09.Executar(); break;
                    case "10": Ex1ao12.Ex10.Executar(); break;
                    case "11": Ex1ao12.Ex11.Executar(); break;
                    case "12": Ex1ao12.Ex12.Executar(); break;
                    case "0": return;
                    default: Console.WriteLine("Op��o inv�lida."); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
            }
        }
    }
}
