using System;

class FormasGeometricas
{
    public class Circulo
    {
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            if (raio <= 0)
                throw new ArgumentException("Raio deve ter valor positivo");
            Raio = raio;
        }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }

    public class Esfera
    {
        public double Raio { get; set; }

        public Esfera(double raio)
        {
            if (raio <= 0)
                throw new ArgumentException("Raio deve ter valor positivo");
            Raio = raio;
        }

        public double CalculaVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Raio, 3);
        }
    }

    public static void Executar()
    {
        Circulo circulo = new Circulo(2.5);
        double areaCirculo = circulo.CalcularArea();
        Console.WriteLine($"\nRaio do círculo: {circulo.Raio}");
        Console.WriteLine($"Área do círculo: {areaCirculo:F2}");

        Esfera esfera = new Esfera(6);
        double volumeEsfera = esfera.CalculaVolume();
        Console.WriteLine($"\nRaio da esfera: {esfera.Raio}");
        Console.WriteLine($"Volume da esfera: {volumeEsfera:F2}");

    }
}
