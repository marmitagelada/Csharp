using System;

namespace ex1.classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto();
            Produto p2 = new Produto();
            Produto p3 = new Produto();


            #region p1
            Console.WriteLine("Qual o nome do produto?");
            p1.nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto?");
            p1.p = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade?");
            p1.quant = Convert.ToInt16 (Console.ReadLine());
            #endregion

            #region p2
            Console.WriteLine("Qual o nome do produto 2?");
            p2.nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto 2?");
            p2.p = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade 2?");
            p2.quant = Convert.ToInt16 (Console.ReadLine());
            #endregion

            #region p3
            Console.WriteLine("Qual o nome do produto 3?");
            p3.nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto 3?");
            p3.p = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade 3?");
            p3.quant = Convert.ToInt16 (Console.ReadLine());
            #endregion

            float mdp1 = p1.p * p1.quant;
            float mdp2 = p2.p * p1.quant;
            float mdp3 = p3.p * p1.quant;
            float mdp = mdp1 + mdp2 + mdp3;
            float mq = p1.quant + p2.quant + p3.quant;
            float mdf = mdp/mq;
            
            Console.WriteLine($"A média do preço dos produtos é {mdf}");
        }
    }
}
