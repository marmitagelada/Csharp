using System;

namespace Ex1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem Vindo a Tsukamoto Airlines!");

            int resposta, cont=0, contE;
            int[] numPassagem = new int[2];
            string[] nomePassageiro = new string[2];
            DateTime[] dataVoo = new DateTime[2];
            do {
                System.Console.WriteLine ("------- Digite uma opção -------");
                System.Console.WriteLine ("1 - Agendar Viagem");
                System.Console.WriteLine ("2 - Exibir Viagens");
                System.Console.WriteLine ("0 - Sair");
                resposta = int.Parse (Console.ReadLine ());
                switch (resposta) {
                    case 1:
                        {
                            if(cont<2){
                                System.Console.WriteLine("Digite o nome do passageiro:");
                                nomePassageiro[cont] = Console.ReadLine();
                                System.Console.WriteLine("Digite o número da passagem:");
                                numPassagem[cont] = int.Parse(Console.ReadLine());
                                System.Console.WriteLine("Digite a data do voo (no formato DD/MM/AAAA):");
                                dataVoo[cont] = DateTime.Parse(Console.ReadLine());
                                cont ++;
                            }
                            else{
                                System.Console.WriteLine("Limite Excedido");
                            }
                            break;
                        }
                    case 2:
                        {
                            contE=0;
                            while(contE<cont){
                                System.Console.WriteLine($"-----Passageiro {contE}-----");
                                System.Console.WriteLine($"Nome: {nomePassageiro[contE]}");
                                System.Console.WriteLine($"Nº Passagem: {numPassagem[contE]}");
                                System.Console.WriteLine($"Data: {dataVoo[contE]}");
                                contE++;
                            }
                            break;
                        }
                    case 0:
                        {
                            System.Console.WriteLine ("Obrigado! A Tsukamoto Airlines agradece.");
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Opção Inválida");
                            break;
                        }
                }

            } while (resposta != 0);
        }
    }
}