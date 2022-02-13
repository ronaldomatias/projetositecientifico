using sitecientifico.BackEnd.Classes;
using sitecientifico.BancoDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sitecientifico.FrontEnd.Site
{
    public partial class VisualizarArtigos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Artigo> lista = new ArtigoDAO().ProcurarArtigos();
            
            foreach(Artigo artigo in lista)
            {
                Panel painel = new Panel();
                painel.Visible = true;
                painel.CssClass = "painel";

                Panel painel2 = new Panel();
                painel2.Visible = true;
                painel2.CssClass = "painelEspacador";

                Label label = new Label();
                label.CssClass = "labelTitulo";
                label.Text = artigo.Titulo;

                Label label2 = new Label();
                label2.CssClass = "labelDescricao";
                label2.Text = artigo.Descricao;

                painel.Controls.Add(label);
                painel.Controls.Add(label2);

                placeHolder.Controls.Add(painel);
                placeHolder.Controls.Add(painel2);
            }

        }
    }
}