using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coleta de senha
            Console.WriteLine("Senha:");
            int pswd = int.Parse(Console.ReadLine());
            
            int senha = 1234;
            //Confirmação de senha
            if (pswd == senha) 
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                 Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
