using System;

namespace Senai.MVC.Pizzaria.Models
{
    public class UsuarioViewModel
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public string Email {get; set;}
        public string Senha {get; set;}
        public DateTime DataCriacao {get; set;}
    }
}