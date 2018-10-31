using System;
using Senai.Pizzaria.MVC.Util;
using Senai.Pizzaria.MVC.ViewControllers;
using Senai.Pizzaria.MVC.ViewModels;

namespace Senai.Pizzaria.MVC {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0, opcaoLogado = 0;

            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());

                switch (opcaoDeslogado) {
                    case 0:
                        System.Console.WriteLine ("É nois");
                        Console.ReadKey ();
                        break;
                    case 1:
                        UsuarioViewController.CadastrarUsuario ();
                        break;
                    case 2:
                        UsuarioViewModel usuarioViewModel = UsuarioViewController.Logar ();

                        //Verifica se o usuário é valido
                        if (usuarioViewModel != null) {
                            //Mensagem de boas vindas
                            Console.WriteLine ("Seja Bem-Vindo " + usuarioViewModel.Nome);

                            do {
                                //Mostra o menu do usuário logado
                                MenuUtil.MenuLogado ();
                                //Aguarda ioção do usuário
                                opcaoLogado = int.Parse (Console.ReadLine ());
                                //Escolhe a opção do usuário
                                switch (opcaoLogado) {
                                    case 0:
                                        System.Console.WriteLine ("Obrigado!");
                                        break;
                                    case 1:
                                        ProdutoViewController.CadastrarProduto ();
                                        break;
                                    case 2:
                                        ProdutoViewController.ListarProdutos ();
                                        break;
                                    default:
                                        System.Console.WriteLine ("Opção Inválida");
                                        break;
                                }
                                //Fica no laço enquanto a opção é diferente de 0
                            } while (opcaoLogado != 0);
                        }
                        break;
                    case 3:
                        UsuarioViewController.Listar ();
                        break;
                    default:
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}