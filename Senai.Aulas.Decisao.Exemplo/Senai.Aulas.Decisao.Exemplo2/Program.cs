using System;

namespace Senai.Aulas.Decisao.Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insira o gênero
            Console.WriteLine("Insira o gênero: ");
            char genero = char.Parse(Console.ReadLine());

            if (genero == 'M')
            {

                //Insira a idade
                Console.WriteLine("Insira sua idade: ");
                int idade = int.Parse(Console.ReadLine());
                
                if (idade >=18)
                {
                    Console.WriteLine("Apto a retirada da reservista");
                }
                else 
                {
                    Console.WriteLine("Não apto. Você é menor de idade");
                }
            }
            else 
            {
                Console.WriteLine("Não apto. Gênero não compatível");
            }
        }
    }
}