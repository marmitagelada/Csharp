using System;

namespace Senai.Aulas.Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o número 'a': ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número 'b': ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o número 'c': ");
            double c = double.Parse(Console.ReadLine());

            double maior = 0;

            if ( a > b && a > c)
            {
                maior = a;
            }
            else if ( b > c )
            {
                maior = b;
            }
            else 
            {
                maior = c;
            }
            Console.WriteLine($"O maior número é {maior}");
        }
    }
}
