using System;
using Senai.MVC.Pizzaria.ViewControllers;

namespace Senai.MVC.Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioViewC = new UsuarioViewController();

            usuarioViewC.Cadastrar();

            usuarioViewC.Logar();

            usuarioViewC.Listar();
        }
    }
}
