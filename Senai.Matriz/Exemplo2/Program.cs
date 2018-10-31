using System;

namespace Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];
            Random random =  new Random();
            bool encontrou = false;

            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    //Gera um número aleatório de 0 a 50
                    matriz[i,c] = random.Next(51);
                }
            }

            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    System.Console.WriteLine($"{matriz[i,c]}\t");
                }
                System.Console.WriteLine("");
            }

            System.Console.WriteLine("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < 5; i++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if(num == matriz[i,c]){
                        System.Console.WriteLine($"O número foi encontrado na linha {i} e coluna {c}");
                        encontrou = true;
                        break;
                    }
                }
                if(encontrou){
                    break;
                }
            }
            if(!encontrou){
                System.Console.WriteLine("O número não foi encontrado");
            }
        }
    }
}
