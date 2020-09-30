using System.Data;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.Shared
{
    public abstract class AbstractDal : IDal
    {
        // Properties:

        protected string _server;
        protected string _database;
        protected string _user;
        protected string _password;


        // Methods:

        public abstract void ExecuteSqlCommand(string sql);
        public abstract DataTable ReturnDataTable(string sql);
    }
}
