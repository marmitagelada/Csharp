using System;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Senai.Tarefas.MVC.Web.Models;
using Senai.Tarefas.MVC.Web.Repositorio;

namespace Senai.Tarefas.MVC.Web.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(IFormCollection form)
        {
            UsuarioModel usuarioModel = new UsuarioModel();
            
            string[] linhas = System.IO.File.ReadAllLines("usuarios.csv");

            usuarioModel.ID = linhas.Length + 1;
            usuarioModel.Nome = form["nome"];
            usuarioModel.Email = form["email"];
            usuarioModel.Senha = form["senha"];
            usuarioModel.DataCriacao = DateTime.Now;

            using(StreamWriter sw = new StreamWriter("usuarios.csv", true))
            {
                sw.WriteLine($"{usuarioModel.ID};{usuarioModel.Nome};{usuarioModel.Email};{usuarioModel.Senha};{usuarioModel.DataCriacao}");
            }

            ViewBag.Mensagem = "Usuário cadastrado com sucesso!";
            return View();
        }

        [HttpGet]
        public IActionResult Login () => View();

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            UsuarioModel usuarioModel = new UsuarioModel
            {
                Email = form["email"],
                Senha = form["senha"]
            };

            // Verifica se o usuário possui acesso para realizar login...
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.BuscarPorEmailESenha(usuarioModel.Email, usuarioModel.Senha);

            if (usuario != null)
            {
                HttpContext.Session.SetString("idUsuario", usuario.Email.ToString());
                ViewBag.Mensagem = "Login realizado com sucesso!";

                return RedirectToAction("Cadastrar", "Tarefa");
            } else {
                ViewBag.Mensagem = "E-mail ou senha incorretos, acesso negado!";
            }
            return View();
        }
    }
}