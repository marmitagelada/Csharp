using System;

namespace Senai.Aulas.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu salário?");
            double salario = double.Parse(Console.ReadLine());

            double acres25 = 0;
            double acres15 = 0;
            double acres10 = 0;

            if (salario <= 1000)
            {
                acres25 = salario * 0.25;
                Console.WriteLine($"Seu salário com acréscimo será de {acres25}");
            }
            if (salario > 1000 && salario <=2000)
            {
                acres15 = salario * 0.15;
                Console.WriteLine($"Seu salário com acréscimo será de {acres15}");
            }
            if (salario >2000)
            {
                acres10 = salario * 0.10;
                Console.WriteLine($"Seu salário com acréscimo será de {acres10}");
            }
        }
    }
}
