using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AplicacaoCliente.Models;

namespace AplicacaoCliente.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ClienteModel objCliente = new ClienteModel();
            // ViewBag é uma estrutura pela qual consegue trafegar entre a controladora e a visao informações em formato de pacote. Ex: uma lista de mesmo tipo.
            ViewBag.ListaClientes = objCliente.ListarTodosCliente();

            return View();
        }

        [HttpGet]
        public IActionResult Registrar(int? id)
        {
            if (id != null)
            {
                ViewBag.Registro = new ClienteModel().Carregar(id);
            }
            return View();
        }

        public IActionResult Excluir(int id)
        {
            ViewData["ClienteID"] = id.ToString();
            return View();
        }

        public IActionResult ExcluirCliente(int id)
        {
            new ClienteModel().Excluir(id);
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(ClienteModel dados)
        {
            dados.Inserir();
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
