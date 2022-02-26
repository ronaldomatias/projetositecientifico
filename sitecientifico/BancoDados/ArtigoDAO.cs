using Npgsql;
using sitecientifico.BackEnd.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace sitecientifico.BancoDados
{
    public class ArtigoDAO
    {

        public List<Artigo> ProcurarArtigos()
        {
            List<Artigo> lista = new List<Artigo>();

            using (NpgsqlConnection con = Conexao.ObterConexao())
            {
                NpgsqlCommand sqlComando = new NpgsqlCommand("SELECT titulo, descricao FROM artigo", con);

                con.Open();
                NpgsqlDataReader dataReader = sqlComando.ExecuteReader();

                while (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        lista.Add(new Artigo(dataReader.GetString(0), dataReader.GetString(1)));
                    }
                    dataReader.NextResult();
                }
                con.Close();
            }

            return lista;
        }

        public void NovoArtigo(Artigo artigo)
        {
            using (NpgsqlConnection con = Conexao.ObterConexao())
            {
                NpgsqlCommand sqlComando = new NpgsqlCommand("INSERT INTO artigo VALUES(default, @titulo, @descricao)", con);
                sqlComando.Parameters.AddWithValue("titulo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = artigo.Titulo;
                sqlComando.Parameters.AddWithValue("descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = artigo.Descricao;
                sqlComando.CommandType = System.Data.CommandType.Text;

                con.Open();
                sqlComando.ExecuteNonQuery();
                con.Close();
            }
        }


    }
}