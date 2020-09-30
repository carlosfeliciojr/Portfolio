using System;
using Microsoft.AspNetCore.Mvc;
using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.MySQL;
using CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.External;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Api.Controllers
{

    // Classe para teste utilizando Postman.

    [Route("database/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        [HttpPost]
        [Route("registercompany")]
        public ReturnAllServices RegisterCompany([FromBody]CompanyModel data)
        {
            var dataReturn = new ReturnAllServices();
            try
            {
                var objCompany = new ConnectionReceitaws(new CompanyModel());
                objCompany.GetCompanyDataFromApi(data.CnpjRequired);
                var registerCompany = new MySqlQueries(new CompanyModel());
                registerCompany.RegisterCompany(data);
                dataReturn.Result = true;
                dataReturn.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                dataReturn.Result = false;
                dataReturn.ErrorMessage = "Erro ao tentar registrar uma empresa. " + e.Message;
            }
            return dataReturn;
        }

        [HttpGet]
        [Route("consult")]
        public CompanyModel Consult(string cnpj)
        {
            return (CompanyModel)new MySqlQueries(new CompanyModel()).ConsultCompany(cnpj);
        }

        [HttpGet]
        [Route("company/{cnpj}")]
        public CompanyModel ReturnClient(string cnpj)
        {
            return (CompanyModel)new MySqlQueries(new CompanyModel()).ConsultCompany(cnpj);
        }

        [HttpPut]
        [Route("update/{cnpj}")]
        public ReturnAllServices Update(string cnpj, [FromBody]CompanyModel data)
        {
            var dataReturn = new ReturnAllServices();
            try
            {
                data.SetCnpj(cnpj);
                var update = new MySqlQueries(new CompanyModel());
                update.UpdateCompany();
                dataReturn.Result = true;
                dataReturn.ErrorMessage = string.Empty;
            }
            catch (Exception e)
            {
                dataReturn.Result = false;
                dataReturn.ErrorMessage = "Erro ao tentar atualizar uma empresa. " + e.Message;
            }
            return dataReturn;
        }

        [HttpDelete]
        [Route("exclude/{cnpj}")]
        public void Exclude(string cnpj)
        {
            new MySqlQueries(new CompanyModel()).ExcludeCompany(cnpj);
        }
    }
}
