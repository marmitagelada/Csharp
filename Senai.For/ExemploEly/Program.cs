using System;

namespace ExemploEly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de números:");
            int quantidade = int.Parse (Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= quantidade; i++){
                System.Console.WriteLine("Digite o número" + i);
                int numero = int.Parse (Console.ReadLine());
            }

            Console.WriteLine("A soma é:" + soma);
            Console.WriteLine("A soma é:" + soma/quantidade);
        }
    }
}
