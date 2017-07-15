using AplicacaoMarota.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AplicacaoMarota.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View(GetPessoas());
        }

        private List<Pessoa> GetPessoas()
        {
            var pessoas = new List<Pessoa>();

            pessoas.Add(new Pessoa() { Id = 1, Nome = "Adamastor" });
            pessoas.Add(new Pessoa() { Id = 2, Nome = "Enéas Carneiro" });

            return pessoas;
        }
    }
}