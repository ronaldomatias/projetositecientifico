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

            Label lblLinhaDoTempo = (Label)Master.FindControl("lblLinhaDoTempo");
            lblLinhaDoTempo.Text = "~/visualizarArtigos";

            // MONTAGEM DA ÁREA DE VISUALIZAÇÃO DOS ARTIGOS;
            List<Artigo> listaArtigos = new ArtigoDAO().ProcurarArtigos();
            
            foreach(Artigo artigo in listaArtigos)
            {
                Panel painelLabels = new Panel();
                painelLabels.CssClass = "painelLabels";

                Panel painelEspacador = new Panel();
                painelEspacador.CssClass = "painelEspacador";

                Label lblTitulo = new Label();
                lblTitulo.CssClass = "labelTitulo";
                lblTitulo.Text = artigo.Titulo;

                Label lblDescricao = new Label();
                lblDescricao.CssClass = "labelDescricao";
                lblDescricao.Text = artigo.Descricao;

                painelLabels.Controls.Add(lblTitulo);
                painelLabels.Controls.Add(lblDescricao);

                placeHolder.Controls.Add(painelLabels);
                placeHolder.Controls.Add(painelEspacador);
            }

        }
    }
}