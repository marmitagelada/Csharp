using System;

namespace Projeto.Cadastro.Classes {
    class Program {
        static Funcionario[] arrayFuncionario;

        static int opcao = 0, indicador;
        static void Main (string[] args) {
            //Instaciação do array
            arrayFuncionario = new Funcionario[1000];

            do {
                Menu ();
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 0:
                        {
                            break;
                        }
                    case 1:
                        {
                            CadastraUsuario ();
                            break;
                        }
                    case 2:
                        {
                            ExibirFP ();
                            break;
                        }
                    case 3:
                        {
                            Bruto ();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Opção Inválida");
                            break;
                        }
                }
            } while (opcao != 0);

        }

        static void Menu () {
            Console.Clear ();
            System.Console.WriteLine ("Menu de Opções:");
            System.Console.WriteLine ("1 - Cadastrar Funcionário");
            System.Console.WriteLine ("2 - Exibir Folha de Pagamento");
            System.Console.WriteLine ("3 - Exibir Total de Custos Brutos");
            System.Console.WriteLine ("4 - Aumentos de Salário");
            System.Console.WriteLine ("5 - Exibir Total de Custos Líquidos");
            System.Console.WriteLine ("0 - Sair");
        }

        static void CadastraUsuario () {
            arrayFuncionario[indicador] = new Funcionario ();

            Console.Clear ();
            for (int cont = 0; cont < 1; cont++) {
                System.Console.WriteLine ("Nome do usuário a ser cadastrado: ");
                arrayFuncionario[indicador].Nome = Console.ReadLine ();;

                System.Console.WriteLine ("Salário do usuário a ser cadastrado: ");
                arrayFuncionario[indicador].Salario = float.Parse (Console.ReadLine ());

                indicador++;
            }

        }

        static void ExibirFP () {
            Console.Clear ();
            for (int cont = 0; cont < indicador; cont++) {
                System.Console.WriteLine ($"Funcionários\n\nNome: {arrayFuncionario[cont].Nome}\nSalário: {arrayFuncionario[cont].Salario.ToString("c")}");
            }
        }

        static void Calcula () {
            float Inss = 0;
        }

        static void Bruto () {
            double total = 0;
            foreach (Funcionario f in arrayFuncionario)
            {
                if (f ==null)
                {
                    break;
                }
            }
        }
    }
}