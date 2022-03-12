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

        public List<Artigo> PesquisarTodosArtigos()
        {
            List<Artigo> lista = new List<Artigo>();

            using (NpgsqlConnection con = Conexao.ObterConexao())
            {
                NpgsqlCommand sqlComando = new NpgsqlCommand("SELECT titulo, descricao, dtCriacao FROM artigo ORDER BY dtCriacao DESC", con);

                con.Open();
                NpgsqlDataReader dataReader = sqlComando.ExecuteReader();

                while (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        lista.Add(new Artigo(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetDateTime(2)));
                    }
                    dataReader.NextResult();
                }
                con.Close();
            }

            return lista;
        }

        public void CadastrarArtigo(Artigo artigo)
        {
            using (NpgsqlConnection con = Conexao.ObterConexao())
            {
                NpgsqlCommand sqlComando = new NpgsqlCommand("INSERT INTO artigo VALUES(default, @titulo, @descricao, @dtCriacao, @nCdCategoria)", con);
                sqlComando.Parameters.AddWithValue("titulo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = artigo.Titulo;
                sqlComando.Parameters.AddWithValue("descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = artigo.Descricao;
                sqlComando.Parameters.AddWithValue("dtCriacao", NpgsqlTypes.NpgsqlDbType.Date).Value = artigo.dtCriacao;
                sqlComando.Parameters.AddWithValue("nCdCategoria", NpgsqlTypes.NpgsqlDbType.Integer).Value = artigo.nCdCategoria;

                sqlComando.CommandType = System.Data.CommandType.Text;

                con.Open();
                sqlComando.ExecuteNonQuery();
                con.Close();
            }
        }

        public List<Artigo> PesquisarArtigoPorTituloOuDescricao(string txtPesquisaArtigo)
        {
            List<Artigo> listaArtigos = new List<Artigo>();

            using (NpgsqlConnection con = Conexao.ObterConexao())
            {
                NpgsqlCommand sqlComando = new NpgsqlCommand("SELECT titulo, descricao, dtCriacao FROM artigo WHERE titulo || descricao ILIKE '%" + txtPesquisaArtigo + "%' ORDER BY dtCriacao DESC", con);

                con.Open();
                NpgsqlDataReader dataReader = sqlComando.ExecuteReader();

                while (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        listaArtigos.Add(new Artigo(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetDateTime(2)));
                    }
                    dataReader.NextResult();
                }
                con.Close();
            }

            return listaArtigos;
        }


    }
}