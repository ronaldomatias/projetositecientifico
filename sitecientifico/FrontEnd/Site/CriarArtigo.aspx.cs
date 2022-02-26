using Npgsql;
using sitecientifico.BackEnd.Classes;
using sitecientifico.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitecientifico.FrontEnd
{
    public partial class CriarArtigo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod]
        public static void NovoArtigo(string txtTituloo, string txtDescricaoo)
        {
            /*if(txtTitulo.Length.Equals(0) || txtDescricao.Length.Equals(0))
            {
            }*/

            Artigo artigo = new Artigo(txtTituloo, "teste");

            ArtigoDAO artigoDAO = new ArtigoDAO();
            artigoDAO.NovoArtigo(artigo);
        }


    }
}