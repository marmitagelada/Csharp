namespace Senai.Pizzaria.MVC.ViewModels {
    /// <summary>
    /// Classe que representa a entidade Produto
    /// Herda a classe BaseViewModel
    /// </summary>
    public class ProdutoViewModel : BaseViewModel {
        /// <summary>
        /// Descrição do produto
        /// </summary>
        public string Descricao { get; set; }
        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Preco { get; set; }
        /// <summary>
        /// Categoria do produto
        /// </summary>
        public string Categoria { get; set; }
    }
}