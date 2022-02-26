using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace sitecientifico.BancoDados
{
    static class Conexao
    {
        static string serverName = "127.0.0.1"; // ou "localhost";                                  
        static string port = "5433";
        static string userName = "postgres";
        static string password = "3242";
        static string databaseName = "projetocientifico";

        public static NpgsqlConnection ObterConexao()
        {
            //string infosBancoDados = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;


            string infosBancoDados = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
            serverName, port, userName, password, databaseName);

            return new NpgsqlConnection(infosBancoDados);
        }
    }
}
