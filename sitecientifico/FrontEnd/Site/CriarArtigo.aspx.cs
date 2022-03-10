using Npgsql;
using sitecientifico.BackEnd.Classes;
using sitecientifico.BancoDados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace sitecientifico.FrontEnd
{
    public partial class CriarArtigo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // POPULAR DROPDOWNLIST CATEGORIAS
            ddlCategorias.DataSource = new CategoriaDAO().BuscarTodasCategorias();
            ddlCategorias.DataTextField = "sdscategoria";
            ddlCategorias.DataValueField = "ncdcategoria";
            ddlCategorias.DataBind();
            ddlCategorias.Items.Insert(0, new ListItem("Selecione", "0"));
        }

        [WebMethod]
        public static void NovoArtigo(string txtTitulo, string txtDescricao, int ddlCategoria)
        {
            new ArtigoDAO().CadastrarArtigo(new Artigo(txtTitulo, txtDescricao, DateTime.Now, ddlCategoria));
        }

    }
}