<%@ Page Title="Criar artigo" Language="C#" MasterPageFile="~/FrontEnd/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="CriarArtigo.aspx.cs" Inherits="sitecientifico.FrontEnd.CriarArtigo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="plhScript" runat="server">
    <link rel="stylesheet" href="/FrontEnd/CSS/FolhaEstiloCriarArtigo.css" />

    <script type="text/javascript">

        if (window.history.replaceState) {
            window.history.replaceState(null, null, window.location.href);
        }

        function Salvar() {

            document.getElementById('<%= Master.FindControl("btnFecharInformacao").ClientID %>').style.display = "none";

            if (Page_ClientValidate()) {

                var _titulo = document.getElementById('<%= txtTitulo.ClientID %>').value;
                var _descricao = document.getElementById('<%= txtDescricao.ClientID %>').value;

                $.ajax({
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

                
            } else {
                document.getElementById('<%= Master.FindControl("btnFecharInformacao").ClientID %>').style.display = "flow";
            }
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
                    <asp:TextBox ID="txtTitulo" ValidationGroup="validacaoGrupo" TextMode="SingleLine" CssClass="textBoxInfo" Width="100%" Height="25px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtTitulo" ValidationGroup="validacaoGrupo"  ErrorMessage="Preencha o título!" Display="None" runat="server"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label CssClass="labelInfo" runat="server">Descrição</asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescricao" ValidationGroup="validacaoGrupo" CssClass="textBoxInfo" Width="100%" Height="200px" TextMode="MultiLine" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ControlToValidate="txtDescricao" ValidationGroup="validacaoGrupo" ErrorMessage="Preencha a descrição!" Display="None" runat="server"></asp:RequiredFieldValidator>
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

