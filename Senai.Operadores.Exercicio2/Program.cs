using System;

namespace Senai.Operadores.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a altura do retângulo?");
            float height = float.Parse( Console.ReadLine() );

            Console.WriteLine("Qual a largura do retângulo?");
            float width = float.Parse( Console.ReadLine());

            float area = height * width;

            Console.WriteLine($"Com um retângulo com {height} de altura e {width} de largura, possuímos um retângulo com {area} de área.");
        }
    }
}
