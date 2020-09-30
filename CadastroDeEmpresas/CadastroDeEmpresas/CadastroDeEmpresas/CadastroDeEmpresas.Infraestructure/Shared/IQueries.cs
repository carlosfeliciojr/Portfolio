using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Shared;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.Shared
{
    public interface IQueries
    {
        // Contracts:

        void RegisterCompany(ICompany company);
        ICompany ConsultCompany(string cnpj);
        void UpdateCompany();
        void ExcludeCompany(string cnpj);
    }
}
