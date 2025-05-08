using System;

namespace WebApplication1.Ex1ao12
{
    public class Ex02
    {
        public static void Executar()
        {
            Console.Write("Escolha o idioma (portugues, english, español): ");
            string idioma = Console.ReadLine().ToLower();

            var mensagens = new Dictionary<string, Action<string>>()
            {
                { "portugues", nome => Console.WriteLine($"Olá, {nome}! Bem-vindo!") },
                { "english", nome => Console.WriteLine($"Hello, {nome}! Welcome!") },
                { "español", nome => Console.WriteLine($"¡Hola, {nome}! ¡Bienvenido!") }
            };

            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            if (mensagens.TryGetValue(idioma, out Action<string> saudacao))
                saudacao(nome);
            else
                Console.WriteLine("Idioma não suportado.");
        }
    }
}