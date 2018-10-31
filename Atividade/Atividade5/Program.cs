using System;

namespace Atividade5 {
    class Program {
        static void Main (string[] args) {
            int mai = 0;
            int mei = 0;
            int men = 0;

            //Consultando valores
            Console.WriteLine ("Insira o 1º valor:");
            int n1 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Insira o 2º valor:");
            int n2 = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Insira o 3º valor:");
            int n3 = int.Parse (Console.ReadLine ());

            if (n1 > n2 && n1 > n3) {
                mai = n1;
                if (n2 > n3) {
                    mei = n2;
                    men = n3;
                } else {
                    mei = n3;
                    men = n2;
                }
                Console.WriteLine ($"Os valores em ordem crescente são {men}, {mei} e {mai}.");
            }
            if (n2 > n1 && n2 > n3) {
                mai = n2;
                if (n1 > n3) {
                    mei = n1;
                    men = n3;
                } else {
                    mei = n3;
                    men = n1;
                }
                Console.WriteLine ($"Os valores em ordem crescente são {men}, {mei} e {mai}.");
            }
            if (n3 > n1 && n3 > n2) {
                mai = n3;
                if (n1 > n2) {
                    mei = n1;
                    men = n2;
                } else {
                    mei = n2;
                    men = n1;
                }
                Console.WriteLine ($"Os valores em ordem crescente são {men}, {mei} e {mai}.");
            }
        }
    }
}