using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Declarar o componente MySql.Data instalado na aplicação.
using MySql.Data.MySqlClient;
using System.Data;

namespace MinhaWebAPI.Util
{
    // Data Access Layer (Camada de acesso a dados).
    // Classe responsável por conectar com o banco de dados.
    public class DAL
    {
        private static string Server = "localhost";
        private static string Database = "dbcliente";
        private static string User = "root";
        private static string Password = "";
        private MySqlConnection Connection;


        // Sslmode=none significa que não está usando protocolo ssl.
        private string ConnectionString = $"Server={Server};" +
                                          $"Database={Database};" +
                                          $"Uid={User};" +
                                          $"Pwd={Password};" +
                                          $"Sslmode=none;" +
                                          $"charset=utf8";

        public DAL()
        {
            // Instancia a variável Connection quando o contrutor for executado.
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        // Método responsável por executar comandos na base de dados.
        // Executa: INSERT, UPDATE e DELETE.
        public void ExecutarComandoSQL(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            Command.ExecuteNonQuery();
        }

        // Método responsável por retornar dados do banco.
        public DataTable RetornarDataTable(string sql)
        {
            MySqlCommand Command = new MySqlCommand(sql, Connection);
            MySqlDataAdapter DataAdaptar = new MySqlDataAdapter(Command);
            DataTable Dados = new DataTable();
            DataAdaptar.Fill(Dados);
            return Dados;
        }
    }
}
