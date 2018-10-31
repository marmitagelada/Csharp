using System;
using System.Collections.Generic;
using Senai.Pizzaria.MVC.ViewModels;

namespace Senai.Pizzaria.MVC.Repositorio {
    /// <summary>
    /// Classe responsável pela leitura e gravação de dados referente ao usuário
    /// </summary>
    public class UsuarioRepositorio {
        //Criação do objeto List<UsuarioViewModel> que faz parte do namespace System.Collections.Generic
        static List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel> ();
        /// <summary>
        /// Método para inserir um novo usuário
        /// </summary>
        /// <param name="usuario">Objeto UsuarioViewModel(nome, email, senha)</param>
        /// <returns>Retorna um UsuarioViewModel atualizado</returns>
        public UsuarioViewModel Inserir (UsuarioViewModel usuario) {
            //Verifica a quantidade de itens na lista, soma 1 e atribui o valor ao ID 
            usuario.ID = lsUsuarios.Count + 1;
            //Atribui data e hora atual
            usuario.DataCriacao = DateTime.Now;
            //Adiciona o usuário à list
            lsUsuarios.Add (usuario);
            //Retorna o usuário
            return usuario;
        }
        /// <summary>
        /// Lista todos os usuários
        /// </summary>
        /// <returns>Retorna uma list</returns>
        public List<UsuarioViewModel> Listar () {
            return lsUsuarios;
        }
/// <summary>
/// Verifica se o usuário é válido
/// </summary>
/// <param name="email">E-mail do usuário</param>
/// <param name="senha">Senha do usuário</param>
/// <returns>Retorna um usuário caso seja válido e retorna null caso seja inválido</returns>
        public UsuarioViewModel Login (string email, string senha) {
            foreach (UsuarioViewModel item in lsUsuarios) {
                //Verifica se o item/objeto email e senha são iguais aos passados como parâmetro
                if (item.Email == email && item.Senha == senha) {
                    //retorna o item/UsuarioViewModel 
                    return item;
                }
            }
            //Caso não encontre o usuário retorna null
            return null;
        }
    }
}