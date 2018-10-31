using System;

namespace Senai.Array.Bingo {
    class Program {
        static void Main (string[] args) {
            //Declaração do array do tipo int com 5 posições
            int[] cartela = new int[5];
            int contador = 0, acertos = 0, indice, numero;

            #region Recebe Números Cartela

            do {
                System.Console.WriteLine ("Informe o número: ");
                cartela[contador] = int.Parse (Console.ReadLine ());
                contador++;

            } while (contador < cartela.Length);
            contador = 0;
            do {
                System.Console.WriteLine (cartela[contador]);
                contador++;
            } while (contador < cartela.Length);
            #endregion
            #region Sorteia Números
            do {
                System.Console.WriteLine ("Informe o número sorteado: ");
                numero = int.Parse (Console.ReadLine ());
                indice = System.Array.IndexOf (cartela, numero);
                if (indice>=0){
                    acertos ++;
                    System.Console.WriteLine($"Você acertou {acertos}, faltam {5-acertos}");
                }
            } while (acertos != 5);
            System.Console.WriteLine("BINGO!");
            #endregion
        }
    }
}