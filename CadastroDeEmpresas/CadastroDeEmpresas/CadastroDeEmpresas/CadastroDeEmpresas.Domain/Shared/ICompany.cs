using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Entities;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Domain.Shared
{
    public interface ICompany
    {
        // Contracts:

        CompanyModel GetDataCompany();

        CompanyModel SetDataCompany(string cnpj,
                            string type,
                            string size,
                            string opening,
                            string name,
                            string fantasyName,
                            string judicialNature,
                            string street,
                            string number,
                            string complement,
                            string zipCode,
                            string neighborhood,
                            string city,
                            string state,
                            string email,
                            string telephone,
                            string responsibleFederativeEntity,
                            string situation,
                            string dateSituation,
                            string reasonSituation,
                            string specialSituation,
                            string dateSpecialSituation,
                            string socialCapital,
                            string lastUpdate);
    }
}
