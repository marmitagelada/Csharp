namespace Senai.Pizzaria.MVC.Util {
    /// <summary>
    /// Classe resonsável pelas validações dos sistemas
    /// </summary>
    public static class ValidacaoUtil {
        /// <summary>
        /// Método responsável por validar o email
        /// </summary>
        /// <param name="email">Email a ser validado </param>
        /// <returns>Retorna true para e-mail válido e false para e-mail inválido</returns>
        public static bool ValidarEmail (string email) {
            if (email.Contains ("@") && email.Contains (".")) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida a senha informada
        /// </summary>
        /// <param name="senha">Senha informada</param>
        /// <returns>Retorna true para senha válida e false para senha inválida</returns>
        public static bool ValidarSenha (string senha) {
            //Verifica se a senha tem mais de 6 caracteres
            if (senha.Length >= 6) {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida a categoria informada
        /// </summary>
        /// <param name="categoria">Categoria deve ser pizza ou bebida</param>
        /// <returns>Retorna true casa a categoria seja pizza/bebida e false caso não seja</returns>
        public static bool ValidarCategoria (string categoria) {
            if (categoria.ToLower () == "pizza" || categoria.ToLower () == "bebida") {
                return true;
            }
            return false;
        }
    }
}