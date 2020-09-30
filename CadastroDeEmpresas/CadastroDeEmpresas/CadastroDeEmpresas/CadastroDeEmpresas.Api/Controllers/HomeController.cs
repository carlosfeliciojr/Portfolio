using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.MySQL;
using CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.External;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Api.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ConsultCompany(string cnpj)
        {
            var objCompany = new MySqlQueries(new CompanyModel());
            ViewBag.CompanyData = objCompany.ConsultCompany(cnpj);
            TempData["CompanyModel"] = ViewBag.CompanyData.Cnpj;
            RedirectToAction("Exclude");
            return View();
        }

        public IActionResult Details(string cnpj)
        {
            var objCompany = new ConnectionReceitaws(new CompanyModel());
            ViewBag.CompanyData = objCompany.GetCompanyDataFromApi(cnpj);
            TempData["CompanyModel"] = ViewBag.CompanyData.Cnpj;
            RedirectToAction("RegisterCompany");
            return View();
        }

        public IActionResult RegisterConfirmation()
        {
            return View();
        }

        public IActionResult RegisterCompany()
        {
            string cnpj = FormatCnpjCpf.WithoutFormat(TempData["CompanyModel"] as string);
            var objCompany = new ConnectionReceitaws(new CompanyModel());
            var registerCompany = new MySqlQueries(new CompanyModel());
            registerCompany.RegisterCompany(objCompany.GetCompanyData(cnpj));

            return View();
        }

        public IActionResult ExcludeConfirmation()
        {
            return View();
        }

        public IActionResult Exclude()
        {
            string cnpj = TempData["CompanyModel"] as string;
            var company = new MySqlQueries(new CompanyModel());
            company.ExcludeCompany(cnpj);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
