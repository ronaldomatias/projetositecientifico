<%@ Page Title="" Language="C#" MasterPageFile="~/FrontEnd/Site/PaginasMaster/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="VisualizarArtigos.aspx.cs" Inherits="sitecientifico.FrontEnd.Site.VisualizarArtigos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="plhScript" runat="server">
    <link rel="stylesheet" href="/FrontEnd/CSS/FolhaEstiloVisualizarArtigos.css" />

    <script type="text/javascript">
        if (window.history.replaceState) {
            window.history.replaceState(null, null, window.location.href);
        }
    </script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="plhConteudo" runat="server">

    <div class="divPesquisaArtigo">
        <asp:TextBox ID="txtPesquisaArtigo" CssClass="txtPesquisaArtigo" ToolTip="Digite aqui para pesquisar" runat="server"></asp:TextBox>
        <asp:ImageButton ID="ibtnPesquisarArtigo" ImageUrl="/Imagens/Lupa-Verde-PNG.png" CssClass="ibtnPesquisarArtigo" OnClick="PesquisarArtigoPorTitulo" runat="server" />
    </div>

    <div class="divConteudo">
        <div class="divPlaceHolder">
            <asp:PlaceHolder ID="placeHolder" runat="server"></asp:PlaceHolder>
        </div>
    </div>
</asp:Content>
