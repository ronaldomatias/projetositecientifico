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

            if (!IsPostBack)
            {
                List<Artigo> todosArtigos = new ArtigoDAO().PesquisarTodosArtigos();
                MontarArtigos(todosArtigos);
            }

        }

        public void PesquisarArtigo(object sender, EventArgs e)
        {
            List<Artigo> artigosEncontrados = new ArtigoDAO().PesquisarArtigoPorTituloOuDescricao(txtPesquisaArtigo.Text);

            if (artigosEncontrados.Count == 0)
            {
                Label lblInformacaoRetorno = new Label();
                lblInformacaoRetorno.CssClass = "lblNenhumArtigoEncontrado";
                lblInformacaoRetorno.Text = "Nenhum artigo encontrado! Você buscou por: " + txtPesquisaArtigo.Text;
                placeHolder.Controls.Add(lblInformacaoRetorno);
            }

            MontarArtigos(artigosEncontrados);
        }

        public void MontarArtigos(List<Artigo> listaArtigos)
        {
            foreach (Artigo artigo in listaArtigos)
            {
                Panel painelLabels = new Panel();
                painelLabels.CssClass = "painelLabels";

                Panel painelEspacador = new Panel();
                painelEspacador.CssClass = "painelEspacador";

                Panel painelDtCriacao = new Panel();
                painelDtCriacao.CssClass = "painelDtCriacao";

                Label lblTitulo = new Label();
                lblTitulo.CssClass = "lblTitulo";
                lblTitulo.Text = artigo.Titulo;

                Label lblDescricao = new Label();
                lblDescricao.CssClass = "lblDescricao";
                lblDescricao.Text = artigo.Descricao;

                Label lblDataCriacao = new Label();
                lblDataCriacao.CssClass = "lblDtCriacao";
                lblDataCriacao.Text = artigo.dtCriacao.ToString("dd / MM / yyyy");

                painelDtCriacao.Controls.Add(lblDataCriacao);

                painelLabels.Controls.Add(lblTitulo);
                painelLabels.Controls.Add(lblDescricao);
                painelLabels.Controls.Add(painelDtCriacao);

                placeHolder.Controls.Add(painelLabels);
                placeHolder.Controls.Add(painelEspacador);
            }
        }

    }
}