using System;
using System.Collections.Generic;
using Senai.Pizzaria.MVC.Repositorio;
using Senai.Pizzaria.MVC.ViewModels;

namespace Senai.Pizzaria.MVC.ViewControllers {
    /// <summary>
    /// Classe responsável pelo view e controller do produto
    /// </summary>
    public class ProdutoViewController {
        static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio ();

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public decimal Preco { get; private set; }
        public string Categoria { get; private set; }

        public static void CadastrarProduto () {
            string nome, descricao, preco, categoria;

            #region View
            //Recebe o nome do produto
            do {
                System.Console.WriteLine ("Informe o nome do produto: ");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome do produto inválido");
                }
            } while (string.IsNullOrEmpty (nome));

            //Recebe a descrição
            do {
                System.Console.WriteLine ("Informe a descrição do produto: ");
                descricao = Console.ReadLine ();

                if (string.IsNullOrEmpty (descricao)) {
                    System.Console.WriteLine ("Descrição produto inválida");
                }
            } while (string.IsNullOrEmpty (descricao));

            //Recebe o preço
            do {
                System.Console.WriteLine ("Informe o preço do produto: ");
                preco = Console.ReadLine ();

                if (string.IsNullOrEmpty (preco)) {
                    System.Console.WriteLine ("Preço do produto inválido");
                }
            } while (string.IsNullOrEmpty (preco));

            //Recebe a categoria
            do {
                System.Console.WriteLine ("Informe a categoria do produto: ");
                categoria = Console.ReadLine ();

                if (string.IsNullOrEmpty (categoria)) {
                    System.Console.WriteLine ("Categoria do produto inválido");
                }
            } while (string.IsNullOrEmpty (categoria));
            #endregion

            #region Controller
            ProdutoViewController produtoViewModel = new ProdutoViewController ();
            produtoViewModel.Nome = nome;
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Preco = decimal.Parse (preco);
            produtoViewModel.Categoria = categoria;

            produtoRepositorio.Inserir (produtoViewModel);

            System.Console.WriteLine ("Produto Cadastrado");
            #endregion
        }

        public static void ListarProdutos () {
            List<ProdutoViewModel> lsProdutos = produtoRepositorio.Listar();

            foreach (ProdutoViewModel item in lsProdutos)
            {
                System.Console.WriteLine($"{item.ID} - {item.Nome} - R$ {item.Preco.ToString("N2")}");
            }

            System.Console.WriteLine("Informe o ID do produto para mais informações ou 0 para sair: ");

            int idProduto = 0;

            do
            {   
                //Obtém o ID do produto
                idProduto = int.Parse(Console.ReadLine());
                
                //Caso seja 0 sai do laço
                if (idProduto == 0)
                {
                    break;
                }
                //Declara um objeto ProdutoViewModel e busca o produto pelo ID
                ProdutoViewModel produtoViewModel = produtoRepositorio.BuscarPorID(idProduto);
                //Verifica se o produto exista
                if (produtoViewModel != null)
                {
                    //Caso exista, mostra todos os dados do produto 
                    System.Console.WriteLine($"{produtoViewModel.ID} - {produtoViewModel.Nome} - {produtoViewModel.Descricao} - {produtoViewModel.Preco.ToString("c")} - {produtoViewModel.Categoria}");
                }
                else
                {
                    //Se não existir informa ao usuário
                    System.Console.WriteLine("Produto não encontrado");
                }
            } while (idProduto != 0);
        }
    }
}