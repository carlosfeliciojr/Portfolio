using CadastroDeEmpresas.CadastroDeEmpresas.Domain.Shared;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.Shared
{
    public abstract class AbstractQueries
    {
        // Properties:

        public string _sql;
        public AbstractDal _dal;


        // Methods:

        public abstract void RegisterCompany(ICompany company);
        public abstract ICompany ConsultCompany(string cnpj);
        public abstract void UpdateCompany();
        public abstract void ExcludeCompany(string cnpj);
    }
}
