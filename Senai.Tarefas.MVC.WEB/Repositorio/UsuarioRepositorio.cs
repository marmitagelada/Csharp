using System;
using System.Collections.Generic;
using System.IO;
using Senai.Tarefas.MVC.Web.Models;

namespace Senai.Tarefas.MVC.Web.Repositorio {
    public class UsuarioRepositorio {
        /// <summary>
        /// Carrega a lista de usuários com os dados do .csv
        /// </summary>
        public List<UsuarioModel> CarregarDoCSV () {
            List<UsuarioModel> lsUsuarios = new List<UsuarioModel> ();

            // Abre o stream para ler todos os dados do 'usuarios.csv'
            string[] linhas = File.ReadAllLines ("usuarios.csv");

            // Declara um objeto do tipo 'UsuarioModel'
            UsuarioModel usuarioModel;

            foreach (string linha in linhas) {
                //Separa os dados da linha
                string[] dados = linha.Split (';');

                usuarioModel = new UsuarioModel {
                    ID = int.Parse(dados[0]),
                    Nome = dados[1],
                    Email = dados[2],
                    Senha = dados[3],
                    DataCriacao = DateTime.Now
                };

                // Adiciona o usuário a lista
                lsUsuarios.Add(usuarioModel);
            }

            // Retorna a lista de usuários
            return lsUsuarios;
        }

        public UsuarioModel BuscarPorEmailESenha(string email, string senha)
        {
            List<UsuarioModel> lsUsuarios = CarregarDoCSV();

            // Percorre cada usuário da lista do csv...
            foreach (UsuarioModel usuario in lsUsuarios)
            {
                if (email == usuario.Email && senha == usuario.Senha)
                    // Retorna o objeto do usuário
                    return usuario;
            }
            // Caso o sistema não encontre nenhuma combinação de e-mail, retorna null
            return null;
        }
    }
}