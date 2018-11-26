using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Tarefas.MVC.Web.Models;

namespace Senai.Tarefas.MVC.Web.Controllers {
    public class TarefaController : Controller {
        [HttpGet] // Retorna a tela para que o usuário preencha com os dados
        public IActionResult Cadastrar () {

            if (string.IsNullOrEmpty(HttpContext.Session.GetString("idUsuario")))
            {
                return RedirectToAction("Login", "Usuario");
            }
            return View ();
        }

        [HttpPost] // Recebe as informações do usuário
        public IActionResult Cadastrar (IFormCollection form) {
            TarefaModel tarefaModel = new TarefaModel ();
            
            tarefaModel.Id = 1;
            tarefaModel.Descricao = form["descricao"];
            tarefaModel.Valor = decimal.Parse (form["valor"]);
            tarefaModel.Tipo = form["tipo"];
            tarefaModel.DataCriacao = DateTime.Parse (form["data"]);

            using (StreamWriter sw = new StreamWriter ("tarefas.csv")) {
                sw.WriteLine ($"{tarefaModel.Id};{tarefaModel.Descricao};{tarefaModel.Valor};{tarefaModel.Tipo};{tarefaModel.DataCriacao};");
            }

            ViewBag.Mensagem = "Transferência Cadastrada!";

            return View ();
        }
    }
}