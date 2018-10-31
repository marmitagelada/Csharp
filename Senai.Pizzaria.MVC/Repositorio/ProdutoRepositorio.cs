using System;
using System.Collections.Generic;
using Senai.Pizzaria.MVC.ViewControllers;
using Senai.Pizzaria.MVC.ViewModels;

namespace Senai.Pizzaria.MVC.Repositorio {
    /// <summary>
    /// Classe responsável pela gravação e leitura dos dados do produto
    /// </summary>
    public class ProdutoRepositorio {
        //Cria um objeto do tipo List<ProdutoViewModel>
        static List<ProdutoViewModel> lsProdutos = new List<ProdutoViewModel> ();

        /// <summary>
        /// Insere um  novo produto
        /// </summary>
        /// <param name="produto">Dados do produto</param>
        /// <returns>Retorna o produto atualizado</returns>
        public ProdutoViewModel Inserir (ProdutoViewModel produto) {
            //Atribui ao ID a quantida de itens da lista + 1
            produto.ID = lsProdutos.Count + 1;
            //Atribui a data de criação ao objeto 
            produto.DataCriacao = DateTime.Now;
            //Adiciona o produto na lista
            lsProdutos.Add (produto);
            //Retorna o produto
            return produto;
        }

        /// <summary>
        /// Retorna a lista de produtos
        /// </summary>
        /// <returns>Retorna uma lista</returns>
        public List<ProdutoViewModel> Listar () {
            return lsProdutos;
        }

        /// <summary>
        /// Busca um produto pelo seu ID
        /// </summary>
        /// <param name="id">ID do produto</param>
        /// <returns>Retorna um produto</returns>
        public ProdutoViewModel BuscarPorID (int id) {
            foreach (ProdutoViewModel item in lsProdutos) {
                if (item.ID == id) {
                    return item;
                }
            }
            return null;
        }

        internal void Inserir(ProdutoViewController produtoViewModel)
        {
            throw new NotImplementedException();
        }
    }
}