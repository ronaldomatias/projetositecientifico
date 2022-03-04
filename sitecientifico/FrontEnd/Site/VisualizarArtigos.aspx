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

    <div class="divConteudo">

        <div class="divPlaceHolder">
            <asp:PlaceHolder ID="placeHolder" runat="server"></asp:PlaceHolder>
        </div>

    </div>
</asp:Content>
