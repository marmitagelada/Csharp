using System;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.Financas.Transacoes.MVC.Web.Models;

namespace Senai.Financas.Transacoes.MVC.Web.Controllers
{
    public class TransacoesController : Controller
    {
        [HttpGet]
        public ActionResult Cadastro() => View();
       

        [HttpPost]
        public ActionResult Cadastro(IFormCollection form) {
            TransacoesModel transacoesModel = new TransacoesModel();

            transacoesModel.Tipo = form["tipo"];
            transacoesModel.Descricao = form["descricao"];
            transacoesModel.DataTransacao = DateTime.Parse(form["dataTransacao"]);
            transacoesModel.Valor = form["valor"];

            using (StreamWriter sw = new StreamWriter("transacoes.csv",true))
            {
                sw.WriteLine($"{transacoesModel.Tipo};{transacoesModel.Descricao};{transacoesModel.DataTransacao};{transacoesModel.Valor}");
            }
            ViewBag.Mensagem("Transação Efetuada!");
            return View();
        }
    }
}