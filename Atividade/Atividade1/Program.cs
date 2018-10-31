using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o valor 1: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor 2: ");
            double valor2 = double.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine($"O {valor1} é maior");
            }
            else 
            {
                Console.WriteLine($"O {valor2} é maior");
            }
        }
    }
}
