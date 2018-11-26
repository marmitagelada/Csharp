using System;
using System.Collections.Generic;
using System.IO;
using Senai.MVC.Pizzaria.Models;

namespace Senai.MVC.Pizzaria.ViewControllers {
    public class UsuarioViewController {
        static int cont = 1;
        public void Cadastrar () { 
            #region View
            System.Console.WriteLine ("Informe o seu nome: ");
            string nome = Console.ReadLine ();

            System.Console.WriteLine ("Informe o seu e-mail: ");
            string email = Console.ReadLine ();

            System.Console.WriteLine ("Informe a sua senha: ");
            string senha = Console.ReadLine ();
            #endregion

            #region Controller
            List<UsuarioViewModel> lsUsuarios = ListarUsuarios();
            UsuarioViewModel usuarioViewModel = new UsuarioViewModel ();
            usuarioViewModel.ID = lsUsuarios.Count + 1;
            usuarioViewModel.Nome = nome;   
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.DataCriacao = DateTime.Now;

            using (StreamWriter sw = new StreamWriter ("usuarios.csv", true)) {
                sw.WriteLine ($"{usuarioViewModel.ID};{usuarioViewModel.Nome};{usuarioViewModel.Email};{usuarioViewModel.Senha};{usuarioViewModel.DataCriacao}");
            }
            System.Console.WriteLine ("Usuário Cadastrado");
            cont++;
            #endregion
        }

        public void Logar () {
            TransacoesViewController transacoesViewController = new TransacoesViewController ();
            #region View
            System.Console.WriteLine ("Informe seu e-mail: ");
            string email = Console.ReadLine ();

            System.Console.WriteLine ("Informe sua senha: ");
            string senha = Console.ReadLine ();
            #endregion

            #region Controller
            List<UsuarioViewModel> lsUsuarios = ListarUsuarios();

            foreach (UsuarioViewModel item in lsUsuarios) {
                
                if (item.Email == email && item.Senha == senha) {
                    System.Console.WriteLine ("Acesso liberado");

                    transacoesViewController.MenuTransacoes();
                    Console.ReadKey();
                    break;
                }
                else {
                    Logar ();
                }
            }
            #endregion
        }

        public void Listar () {
            #region Controller
            List<UsuarioViewModel> lsUsuarios = ListarUsuarios();
            #endregion

            #region View
            foreach (UsuarioViewModel item in lsUsuarios) {
                System.Console.WriteLine ($"{item.ID} - {item.Nome} - {item.Email} - {item.DataCriacao}");
            }
            #endregion
        }

        private List<UsuarioViewModel> ListarUsuarios () {
            #region Controller
            List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel> ();
            UsuarioViewModel usuario;

            string[] linhas = File.ReadAllLines ("usuarios.csv");

            foreach (string item in linhas) {
                string[] dados = item.Split (";");
                usuario = new UsuarioViewModel ();
                usuario.ID = int.Parse (dados[0]);
                usuario.Nome = dados[1];
                usuario.Email = dados[2];
                usuario.Senha = dados[3];
                usuario.DataCriacao = DateTime.Parse (dados[4]);
                lsUsuarios.Add (usuario);
            }
            return lsUsuarios;
            #endregion
        }
    }
}