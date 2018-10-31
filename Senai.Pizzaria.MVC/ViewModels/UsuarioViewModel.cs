namespace Senai.Pizzaria.MVC.ViewModels {
    /// <summary>
    /// Classe responsável pelas informações do usuário, representa a entidade Usuario
    /// Herda a classe BaseViewModel
    /// </summary>
    public class UsuarioViewModel : BaseViewModel {
        /// <summary>
        /// Email do usuário
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Senha do usuário
        /// </summary>
        public string Senha { get; set; }
    }
}