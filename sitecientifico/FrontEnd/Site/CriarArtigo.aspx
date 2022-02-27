<%@ Page Title="Criar artigo" Language="C#" MasterPageFile="~/FrontEnd/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="CriarArtigo.aspx.cs" Inherits="sitecientifico.FrontEnd.CriarArtigo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="plhScript" runat="server">
    <link rel="stylesheet" href="/FrontEnd/CSS/FolhaEstiloCriarArtigo.css" />

    <script type="text/javascript">

        function Salvar() {

            var _titulo = document.getElementById('<%= txtTitulo.ClientID %>').value;
            var _descricao = document.getElementById('<%= txtDescricao.ClientID %>').value;

            if (_titulo === '' || _descricao === '') alert("Insira o título e descrição do artigo!");

            else $.ajax({
                method: 'POST',
                contentType: 'application/json',
                url: 'CriarArtigo.aspx/NovoArtigo',
                data: '{"txtTituloo": "' + _titulo + '", "txtDescricaoo": "' + _descricao + '"}',
                dataType: 'json',

                success: function () {
                    alert("Salvo com sucesso!");
                },
                error: function (error) {
                    alert(error.responseText);
                }
            });
        }

    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="plhConteudo" runat="server">

    <div class="divInfosArtigo">

        <table style="width: 97%; margin: 5px;">
            <tr>
                <td style="width: 10%">
                    <asp:Label CssClass="labelInfo" Width="20%" runat="server">Título</asp:Label>
                </td>
                <td style="width: 90%">
                    <asp:TextBox ID="txtTitulo" TextMode="SingleLine" CssClass="textBoxInfo" Width="100%" Height="25px" runat="server"></asp:TextBox>
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
                    <asp:Button ID="botao" class="botaoFormulario" Text="Cadastrar" OnClientClick="Salvar(); return false;" runat="server" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

