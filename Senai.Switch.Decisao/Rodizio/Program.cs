using System;

namespace Rodizio {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Informe o útimo digito da placa do seu carro:");
            int digitoPlaca = int.Parse (Console.ReadLine ());

            switch (digitoPlaca) {
                case 1:
                case 2:
                    {
                        Console.WriteLine ("Segunda-Feira");
                        break;
                    }
                case 3:
                case 4:
                    {
                        Console.WriteLine ("Terça-Feira");
                        break;
                    }
                case 5:
                case 6:
                    {
                        Console.WriteLine ("Quarta-Feira");
                        break;
                    }
                case 7:
                case 8:
                    {
                        Console.WriteLine ("Quinta-Feira");
                        break;
                    }
                case 9:
                case 0:
                    {
                        Console.WriteLine ("Sexta-Feira");
                        break;
                    }
                default:
                    {
                        Console.WriteLine ("Opção Inválida");
                        break;
                    }
            }
        }
    }
}