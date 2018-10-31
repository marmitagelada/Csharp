using System;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de lados do polígono?");
            int quantLados = int.Parse(Console.ReadLine());

            Console.WriteLine("Infore o tamanho do lado em centímetros:");
            float medida = float.Parse(Console.ReadLine());

            if (quantLados == 3)
            {
                float area = (float)((Math.Pow(medida,2) * Math.Sqrt(3))/4);
                Console.WriteLine($"É um triângulo e sua área é de: {area.ToString("N2")}");
            }
            else if (quantLados == 4)
            {
                float area = (float)(Math.Pow(medida,2));
                Console.WriteLine($"É um quadrado e sua área é de: {area.ToString("N2")}");
            }
            else if (quantLados == 5)
            {
                Console.WriteLine("É um pentágono");
            }
            else
            {
                Console.WriteLine("É um pentágono");
            }
        }
    }
}
