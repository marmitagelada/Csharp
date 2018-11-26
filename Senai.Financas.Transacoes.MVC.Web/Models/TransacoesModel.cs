using System;

namespace Senai.Financas.Transacoes.MVC.Web.Models {
    public class TransacoesModel {
        public string Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataTransacao { get; set; }
        public string Valor { get; set; }
    }
}