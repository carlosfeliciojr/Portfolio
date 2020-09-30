using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities;
using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Shared;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.External
{
    public class ConnectionReceitaws
    {
        private ICompany _company;

        public ConnectionReceitaws(ICompany company)
        {
            _company = company;
        }


        // Receitaws address:

        private static readonly string _uri = "https://www.receitaws.com.br/v1/cnpj/";


        // Connection Methods:

        public string RequestGet(string cnpj)
        {
            var request = (HttpWebRequest)WebRequest.Create(_uri + cnpj);
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }

        public ICompany GetCompanyDataFromApi(string cnpj)
        {
            string json = RequestGet(cnpj);
            var companyDataFromApi = JsonConvert.DeserializeObject<CompanyModel>(json);
            return companyDataFromApi;
        }

        public ICompany GetCompanyData(string cnpj)
        {
            var dataApi = GetCompanyDataFromApi(cnpj);
            var company = _company.GetDataCompany();
            return company;
        }
    }
}
