using Npgsql;
using sitecientifico.BackEnd.Classes;
using sitecientifico.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitecientifico.FrontEnd
{
    public partial class CriarArtigo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void NovoArtigo(object sender, EventArgs e)
        {
            if(txtTitulo.Text.Length.Equals(0) || txtDescricao.Text.Length.Equals(0))
            {
                Response.Write("<script>confirm('Insira algum conteúdo!') </script");
            }
            else
            {
                Artigo artigo = new Artigo(txtTitulo.Text, txtDescricao.Text);

                using (NpgsqlConnection con = Conexao.ObterConexao())
                {
                    NpgsqlCommand sqlComando = new NpgsqlCommand("INSERT INTO artigo VALUES(default, @titulo, @descricao)", con);
                    sqlComando.Parameters.AddWithValue("titulo", NpgsqlTypes.NpgsqlDbType.Varchar).Value = artigo.Titulo;
                    sqlComando.Parameters.AddWithValue("descricao", NpgsqlTypes.NpgsqlDbType.Varchar).Value = artigo.Descricao;
                    sqlComando.CommandType = System.Data.CommandType.Text;

                    con.Open();
                    sqlComando.ExecuteNonQuery();
                    con.Close();

                    Response.Write("<script>alert('Novo artigo publicado com sucesso!') </script");
                }
            }

            
        }
    }
}