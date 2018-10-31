using System;

namespace Senai.Projetos.Pizzaria.Classes
{
    public class Produtos
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataDeCriacao { get; set; }
        public int Preco { get; set; }
        public int Id { get; set; }
        public string Categoria { get; set; }
    }
}