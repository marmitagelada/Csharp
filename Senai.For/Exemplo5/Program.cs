using System;

namespace Senai.For.Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont_menor = 0, cont_maior = 0, cont_velho = 0;

            Console.WriteLine("Insira a quantidade de usuários: ");
            int quantUser = int.Parse(Console.ReadLine());

            int[] quantUserArray = new int[quantUser];
            
            for (int i = 0; i < quantUser; i++){
                System.Console.WriteLine("Insira a idade do usuário: ");
                quantUserArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < quantUser; i++){
                if (quantUserArray[i] < 18){
                    cont_menor++;
                } else if (quantUserArray[i] >= 18 && quantUserArray[i] < 50){
                    cont_maior++;
                } else if (quantUserArray[i] >= 50){
                    cont_velho++;
                }
            }

            System.Console.WriteLine($"São maiores de idade {cont_maior}");
            System.Console.WriteLine($"\nSão menores de idade {cont_menor}");
            System.Console.WriteLine($"\nSão idosos {cont_velho}");
        }
    }
}