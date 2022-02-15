<%@ Page Title="Criar artigo" Language="C#" MasterPageFile="~/FrontEnd/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="CriarArtigo.aspx.cs" Inherits="sitecientifico.FrontEnd.CriarArtigo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="script" runat="server">
    <link rel="stylesheet" href="/FrontEnd/CSS/FolhaEstiloCriarArtigo.css" />

    <script defer="defer" type="text/javascript">
        if (window.history.replaceState) {
            window.history.replaceState(null, null, window.location.href);
        }

        function funcao() {
            const _titulo = document.getElementById('<%= txtTitulo.ClientID %>').value;
            const _descricao = document.getElementById('<%= txtDescricao.ClientID %>').value;

            alert(_titulo + " " + _descricao);
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="conteudo" runat="server">

    <div class="divInfosArtigo">

        <table style="width: 97%; margin: 5px;">
            <tr>
                <td style="width: 10%">
                    <asp:Label CssClass="labelInfo" Width="20%" runat="server">Título</asp:Label>
                </td>
                <td style="width: 90%">
                    <asp:TextBox ID="txtTitulo" CssClass="textBoxInfo" Width="100%" Height="25px" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label CssClass="labelInfo" runat="server">Descrição</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescricao" CssClass="textBoxInfo" Width="100%" Height="200px" TextMode="MultiLine" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="botao" class="botaoFormulario" Text="Cadastrar" OnClientClick="funcao();" runat="server" />
                </td>
            </tr>
        </table>
    </div>
   
     
   
</asp:Content>

<asp:Content ID="content3" ContentPlaceHolderID="scriptFinal" runat="server">

    
</asp:Content>
