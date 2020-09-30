using System.Data;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.Shared
{
    interface IDal
    {
        // Contracts:

        void ExecuteSqlCommand(string sql);
        DataTable ReturnDataTable(string sql);
    }
}
