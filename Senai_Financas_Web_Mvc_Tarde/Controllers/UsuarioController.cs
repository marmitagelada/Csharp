using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.Mvc.Web.Models;
using Senai.Financas.Mvc.Web.Repositorios;
using Senai_Financas_Web_Mvc_Tarde.Interfaces;
using Senai_Financas_Web_Mvc_Tarde.Repositorios;

namespace Senai.Financas.Mvc.Web.Controllers {
    public class UsuarioController : Controller {
        public IUsuario UsuarioRepositorio { get; set; }

        //Construtor da classe
        public UsuarioController () {
            UsuarioRepositorio = new UsuarioRepositorioSerializacao ();
        }

        [HttpGet]
        public ActionResult Cadastro () {
            return View ();
        }

        [HttpPost]
        public ActionResult Cadastro (IFormCollection form) {
            UsuarioModel usuarioModel = new UsuarioModel (nome: form["nome"], email: form["email"], senha: form["senha"], dataNascimento: DateTime.Parse (form["dataNascimento"]));

            //UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            // UsuarioRepositorioSerializacao usuarioRepositorio = new UsuarioRepositorioSerializacao();
            UsuarioRepositorio.Cadastrar (usuarioModel);

            ViewBag.Mensagem = "Usuário Cadastrado";

            return View ();
        }

        [HttpGet]
        public IActionResult Login () => View ();

        [HttpPost]
        public IActionResult Login (IFormCollection form) {

            //Pega os dados do POST
            UsuarioModel usuario = new UsuarioModel (email: form["email"], senha: form["senha"]);

            //Verificar se o usuário possuí acesso para realizazr login
            // UsuarioRepositorioCSV usuarioRep = new UsuarioRepositorioCSV ();

            UsuarioModel usuarioModel = UsuarioRepositorio.BuscarPorEmailESenha (usuario.Email, usuario.Senha);

            if (usuarioModel != null) {
                HttpContext.Session.SetString ("idUsuario", usuarioModel.Email.ToString ());

                ViewBag.Mensagem = "Login realizado com sucesso!";

                return RedirectToAction ("Cadastrar", "Transacao");
            } else {
                ViewBag.Mensagem = "Acesso negado!";
            }

            return View ();
        }

        /// <summary>
        /// Lista todos os usuários cadastrados no sistema
        /// </summary>
        /// <returns>A view da listagem de usuário</returns>
        [HttpGet]
        public IActionResult Listar () {
            //UsuarioRepositorio rep = new UsuarioRepositorio ();
            // UsuarioRepositorioSerializacao rep = new UsuarioRepositorioSerializacao ();

            //Buscando os dados do rep. e aplicando no view bag
            //ViewBag.Usuarios = rep.Listar();
            ViewData["Usuarios"] = UsuarioRepositorio.Listar ();

            return View ();
        }

        [HttpGet]
        public IActionResult Excluir (int id) {
            // UsuarioRepositorioCSV rep = new UsuarioRepositorioCSV ();
            UsuarioRepositorio.Excluir (id);
            TempData["Mensagem"] = "Usuário excluído.";
            return RedirectToAction ("Listar");
        }

        [HttpGet]
        public IActionResult Editar (int id) {
            if (id == 0) {
                TempData["Mensagem"] = "Informe um ID.";
                return RedirectToAction ("Listar");
            }

            // UsuarioRepositorioCSV usuarioRepositorio = new UsuarioRepositorioCSV();
            UsuarioModel usuario = UsuarioRepositorio.BuscarPorID (id);

            if (usuario != null) {
                ViewBag.Usuario = usuario;
                return View ();
            }

            TempData["Mensagem"] = "Usuário não encontrado.";

            return RedirectToAction ("Listar");
        }

        [HttpPost]
        public IActionResult Editar (IFormCollection form) {
            UsuarioModel usuario = new UsuarioModel (id: int.Parse (form["id"]), nome: form["nome"], email: form["email"], senha: form["senha"], dataNascimento: DateTime.Parse (form["dataNascimento"]));

            // UsuarioRepositorioCSV usuarioRepositorio = new UsuarioRepositorioCSV();

            UsuarioRepositorio.Editar (usuario);

            TempData["Mensagem"] = "Usuário Editado.";

            return RedirectToAction ("Listar");
        }
    }
}