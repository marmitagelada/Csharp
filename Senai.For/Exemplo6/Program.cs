using System;

namespace Exemplo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de números");
            int quantNumeros = int.Parse(Console.ReadLine());
            
            //Declara um array com a quantidade de números informados pelo usuário
            int[] arrayNumeros = new int[quantNumeros];

            for (int i = 0; i < quantNumeros; i++)
            {
                System.Console.WriteLine("Informe o número: ");
                arrayNumeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayNumeros);
            System.Console.WriteLine($"O menor número é: " + arrayNumeros[0]);
            System.Console.WriteLine($"O maior número é: " + arrayNumeros[quantNumeros]);
        }
    }
}
