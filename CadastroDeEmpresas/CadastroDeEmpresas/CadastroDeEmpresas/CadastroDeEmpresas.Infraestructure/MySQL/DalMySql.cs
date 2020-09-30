using CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.Shared;
using MySql.Data.MySqlClient;
using System.Data;

namespace CadastroDeEmpresas.CadastroDeEmpresas.Infraestructure.MySQL
{
    // Data Access Layer.
    public class DalMySql : AbstractDal, IDal
    {
        private static new readonly string _server = "localhost";
        private static new readonly string _database = "cadastrodeempresasdb";
        private static new readonly string _user = "root";
        private static new readonly string _password = "123456";
        private MySqlConnection _connection;
        private readonly string _connectionString = $"Server={_server};Database={_database};Uid={_user};Pwd={_password};Sslmode=none;";

        public DalMySql()
        {
            var connection = new MySqlConnection(_connectionString);
            connection.Open();
        }

        public DalMySql(string connectionString)
        {
            _connection = new MySqlConnection(_connectionString);
            _connection.Open();
        }


        // Methods:

        public override void ExecuteSqlCommand(string sql)
        {
            var command = new MySqlCommand(sql, _connection);
            command.ExecuteNonQuery();
        }

        public override DataTable ReturnDataTable(string sql)
        {
            var command = new MySqlCommand(sql, _connection);
            var dataAdapter = new MySqlDataAdapter(command);
            var data = new DataTable();
            dataAdapter.Fill(data);
            return data;
        }
    }
}
