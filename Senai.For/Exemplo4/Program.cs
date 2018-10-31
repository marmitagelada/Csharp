using System;

namespace Senai.For.Exemplo4
{
    class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            Console.WriteLine("Quantos números você vai inserir: ");
            int QuantNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < QuantNum; i++){
                Console.WriteLine("Insira os números: ");
                int numRecebido = int.Parse(Console.ReadLine());
                
                soma = soma + numRecebido;
            }

            Console.WriteLine($"A soma dos valores é {soma}");
            Console.WriteLine($"\nA média dos valores é {soma / QuantNum}");
        }
    }
}