using Npgsql;
using sitecientifico.BackEnd.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace sitecientifico.BancoDados
{
    public class CategoriaDAO
    {
        


        public List<Categoria> BuscarTodasCategorias()
        {
                List<Categoria> lista = new List<Categoria>();

                using (NpgsqlConnection con = Conexao.ObterConexao())
                {
                    NpgsqlCommand sqlComando = new NpgsqlCommand("SELECT ncdcategoria, sdsCategoria FROM categoria ORDER BY sdsCategoria ASC", con);

                    con.Open();
                    NpgsqlDataReader dataReader = sqlComando.ExecuteReader();

                    while (dataReader.HasRows)
                    {
                        while (dataReader.Read())
                        {
                            lista.Add(new Categoria(dataReader.GetInt32(0), dataReader.GetString(1)));
                        }
                        dataReader.NextResult();
                    }
                    con.Close();
                }

                return lista;
            }
    }
}