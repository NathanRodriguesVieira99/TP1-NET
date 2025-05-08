namespace WebApplication1.Ex1ao12 { 
public class Ex01
{
    public delegate decimal CalculateDiscount(decimal valor);

    public static decimal AplicarDesconto(decimal preco) => preco * 0.9m;

    public static void Executar()
    {
        Console.Write("Informe o preço: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal preco))
        {
            CalculateDiscount desconto = AplicarDesconto;
            Console.WriteLine($"Preço com desconto: R$ {desconto(preco):F2}");
        }
    }
}
}