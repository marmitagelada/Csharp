using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime anoAtual = DateTime.Now;

            Console.WriteLine("Qual seu ano de nascimento?");
            int anoNascimento = int.Parse(Console.ReadLine());

            if (anoAtual.Year - anoNascimento < 16 && anoAtual.Year - anoNascimento >= 16)
            {
                Console.WriteLine("Você não pode votar.");
            }
            else
            {
                Console.WriteLine("Você pode votar.");
            }
        }
    }
}
