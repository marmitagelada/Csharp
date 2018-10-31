using System;

namespace Atividade4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Consultando quantidade de maçãs
            Console.WriteLine("As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia");
            Console.WriteLine("As maçãs custam R$ 0,25 cada se forem compradas pelo menos uma dúzia");
            Console.WriteLine("Quantas maçãs vai querer?");
            int quant = int.Parse(Console.ReadLine());

            //Calculando preço total
            if (quant<12)
            {
                Console.WriteLine($"Você pagará o total de R$ {(quant*0.30).ToString("N2")}");
            }
            else
            {
                Console.WriteLine($"Você pagará o total de R$ {(quant*0.25).ToString("N2")}");
            }
        }
    }
}
