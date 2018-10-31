using System;

namespace Ex1.Classes {
    class Program {
        static Usuario[] arrayUsuarios;

        static int contador = 0;
        
        static void Main (string[] args) {
            Console.Clear ();
            Console.WriteLine ("Informe a quantidade de Usuários: ");
            int quantNumeros = int.Parse (Console.ReadLine ());

            //Instancio e passo a quantidade de posições no array
            arrayUsuarios = new Usuario[quantNumeros];

            int opcao = 0;

            do {
                MontarMenu ();
                opcao = int.Parse (Console.ReadLine ());
                switch (opcao) {
                    case 1:
                        {
                            CadastrarUsuario ();
                            break;
                        }

                    case 2:
                        {
                            ListarUsuarios ();
                            break;
                        }

                    case 3:
                        {
                            AcessarSistema ();
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
        /// <summary>
        /// Monta o menu do sistema
        /// </summary>
        static void MontarMenu () {
            System.Console.WriteLine ("Menu de opções");
            System.Console.WriteLine ("1 - Cadastrar");
            System.Console.WriteLine ("2 - Listar");
            System.Console.WriteLine ("3 - Acessar");
            System.Console.WriteLine ("0 - Sair");
            System.Console.WriteLine ("Escolha sua opção: ");
        }

        static void CadastrarUsuario () {
            Console.Clear ();
            arrayUsuarios[contador] = new Usuario ();
            bool emailValido = false;
            string email;

            System.Console.WriteLine ("Informe seu nome: ");
            arrayUsuarios[contador].Nome = Console.ReadLine ();

            #region Email
            do {
                System.Console.WriteLine ("Informe seu e-mail");
                email = Console.ReadLine ();

                if (email.Contains ("@")) {
                    emailValido = true;
                    arrayUsuarios[contador].Email = email;
                    break;
                } else {
                    System.Console.WriteLine ("E-mail inválido");
                }
            } while (!emailValido); //Verifica se é falso
            #endregion

            #region Senha
            bool senhaValida = false;
            string senha;

            do {
                System.Console.WriteLine ("Informe a senha: ");
                senha = Console.ReadLine ();

                if (senha.Length >= 4) {
                    arrayUsuarios[contador].Senha = senha;
                    break;
                }
            } while (!senhaValida);
            #endregion

            System.Console.WriteLine ("Usuário Cadastrado");

            contador++;
        }

        static void ListarUsuarios () {
            Console.Clear ();
            foreach (Usuario item in arrayUsuarios) {
                System.Console.WriteLine ($"{item.Nome} - {item.Email}");
            }
        }

        static void AcessarSistema () {
            string email;
            int senha;

            System.Console.WriteLine ("Insira seu e-mail: ");
            email = Console.ReadLine ();

            System.Console.WriteLine ("Insira sua senha: ");
            senha = int.Parse (Console.ReadLine ());

        }
    }
}