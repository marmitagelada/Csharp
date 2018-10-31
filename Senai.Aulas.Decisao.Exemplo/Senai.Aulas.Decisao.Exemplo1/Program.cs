using System;

namespace Senai.Aulas.Decisao.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recebendo um número
            Console.WriteLine("Insira um número: ");
            int numero = int.Parse(Console.ReadLine());

            //Estrutura de decisão if (se)
            if (numero >=0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Negativo");
            }
        }
    }
}
