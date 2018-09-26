using System;

namespace Senai.Operadores.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o preço do item 1?");
            float item1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do item 2?");
            float item2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do item 3?");
            float item3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do item 4?");
            float item4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual o preço do item 5?");
            float item5 = float.Parse(Console.ReadLine());

            float md = (item1+item2+item3+item4+item5)/5;

            Console.WriteLine($"A média de preço entre os itens é {md}");
        }
    }
}
