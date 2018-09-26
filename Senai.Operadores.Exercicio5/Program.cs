using System;

namespace Senai.Operadores.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o preço do produto?");
            float p = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade mínima desse produto no estoque?");
            float qMin = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade máxima desse produto no estoque?");
            float qMax = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade atual desse produto no estoque?");
            ushort qA = ushort.Parse(Console.ReadLine()); 

            float eM = (qMin+qMax)/2;
            float cTeM = p*eM;
            float cTeA = (float) (p*qA);

            Console.WriteLine($"O estoque médio é {eM}\n
                                Custo total do produto considerando o estoque médio: {cTeM}");
        }
    }
}
