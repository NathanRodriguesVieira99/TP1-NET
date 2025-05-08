using System;

namespace WebApplication1.Ex1ao12
{
    public class Ex03
    {
        public static void Executar()
        {
            try
            {
                Console.Write("Informe a base do retângulo: ");
                double baseR = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe a altura do retângulo: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Func<double, double, double> calcArea = (b, h) => b * h;
                Console.WriteLine($"Área: {calcArea(baseR, altura)}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Por favor, digite apenas números.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado: {ex.Message}");
            }
        }
    }
}