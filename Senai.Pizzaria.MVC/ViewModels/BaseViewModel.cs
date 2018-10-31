using System;

namespace Senai.Pizzaria.MVC.ViewModels {
    /// <summary>
    /// Classe base que será herdada pelas outras classes
    /// Defina como Abstract para que não possa ser instanciada
    /// </summary>
    public abstract class BaseViewModel {
        /// <summary>
        /// ID do objeto
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Nome do objeto
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de criação do objeto
        /// </summary>
        public DateTime DataCriacao { get; set; }
    }
}