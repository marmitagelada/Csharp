using System;
using System.Collections.Generic;
using Senai.Pizzaria.MVC.Repositorio;
using Senai.Pizzaria.MVC.Util;
using Senai.Pizzaria.MVC.ViewModels;

namespace Senai.Pizzaria.MVC.ViewControllers {
    public class UsuarioViewController {
        private static string nome;

        /// <summary>
        /// Tela de cadastro de usuário
        /// </summary>
        public static void CadastrarUsuario () {
            string email, nome, senha;

            do {
                System.Console.WriteLine ("Informe seu nome:");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome Inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Informe seu e-mail: ");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("E-mail inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe sua senha: ");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacaoUtil.ValidarSenha (senha));

            #region Controller
            //Cria um objeto do tipo UsuarioViewModel
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            //Atribui os valores das propriedades
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;

            //Criar um objeto do tipo usuário UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            //Insere um novo usuário
            usuarioRepositorio.Inserir (usuarioViewModel);

            System.Console.WriteLine ("Usuário Cadastrado");
            #endregion
        }

        public static void Listar () {
            //Crio um objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            //Retorna a lista de usuários cadastrados
            List<UsuarioViewModel> lsUsuarios = usuarioRepositorio.Listar ();

            //Percorre a lista de usuários
            foreach (UsuarioViewModel item in lsUsuarios) {
                //Mostra na tela os dados do usuário
                System.Console.WriteLine ($"{item.ID} - {item.Nome} - {item.Email}");
            }
        }

        public static UsuarioViewModel Logar () {
            string email, senha;

            #region View
            do {
                System.Console.WriteLine ("Informe seu e-mail: ");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine ("E-mail inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe sua senha: ");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha)) {
                    System.Console.WriteLine ("Senha inválida");
                }
            } while (!ValidacaoUtil.ValidarSenha (senha));
            #endregion

            #region Controller
            //Cria o objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio ();
            //Valida o e-mail e senha do usuário
            UsuarioViewModel usuario = usuarioRepositorio.Login (email, senha);

            //Verifica se o e-mail ou senha estão certos
            if (usuario != null) {
                //Retorna o usuário
                return usuario;
            } else {
                //Se não existir mostra mensagem e retorna null
                Console.WriteLine ("E-mail ou senha inválidos");
                return null;
            }
            #endregion
        }
    }
}