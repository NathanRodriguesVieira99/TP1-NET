namespace WebApplication1.Ex1ao12
{
    public class TemperatureSensor
    {
        public event Action<double> TemperatureExceeded;

        public void VerificarTemperatura(double temperatura)
        {
            if (temperatura >= 100 || temperatura <= 0)
                TemperatureExceeded?.Invoke(temperatura);
        }
    }

    public class Ex04
    {
        public static void Executar()
        {
            var sensor = new TemperatureSensor();
            sensor.TemperatureExceeded += temp => Console.WriteLine($"Temperatura crítica de: {temp}ºC");

            while (true)
            {
                Console.Write("Informe a temperatura: ");
                var entrada = Console.ReadLine();
                if (entrada.ToLower() == "sair") break;
                if (double.TryParse(entrada, out double temp))
                    sensor.VerificarTemperatura(temp);
            }
        }
    }
}
