using System;

namespace Senai.Tarefas.MVC.Web.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Tipo { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}