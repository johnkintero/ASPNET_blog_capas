<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="blogStyle.css" rel="stylesheet" />
     <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navbar">
            <i class="material-icons">code</i>
            <asp:LinkButton ID="btnnewform" runat="server" OnClick="btnnewform_Click">NewPost</asp:LinkButton>
        </div>
        <br />
        <div class="container">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="C_id" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" OnRowDeleting="GridView1_RowDeleting" BorderStyle="None" BorderWidth="0">
                <Columns>
                    <asp:TemplateField HeaderText="Titulo" SortExpression="titulo">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("titulo") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Post">
                        <ItemTemplate>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("post1") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="imagen">
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("urlimagen") %>' Width="250px" Height="200px"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Autor">
                        <ItemTemplate>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("autor") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Creado">
                        <ItemTemplate>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("fecha") %>' CssClass="fecha"></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="C_id" HeaderText="id" />
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                    <asp:CommandField ShowDeleteButton="True" />
                </Columns>
            </asp:GridView>
        </div>
        <hr />
        <asp:Panel ID="Panel1" runat="server" Visible="false">
        <div id="divNew">
            <h1>Create New Post</h1>
            <asp:Label Text="" runat="server" ID="lblID"/>
            <asp:Label Text="Titulo" runat="server" />
            <br />
            <asp:TextBox ID="txttitulo" runat="server"></asp:TextBox>
            <asp:Label Text="Post" runat="server" />
            <br />
            <asp:TextBox ID="txtpost" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:Label Text="imagen" runat="server" />
            <br />
            <asp:TextBox ID="txtimg" runat="server"></asp:TextBox>
            <asp:Label Text="Autor" runat="server" />
            <br />
            <asp:TextBox ID="txtautor" runat="server"></asp:TextBox>
            <asp:Button ID="Btnsave" runat="server" Text="Salvar" OnClick="Btnsave_Click" />
            <br />
            <asp:Button ID="Btnupd" runat="server" Text="Actualizar" OnClick="Btnupd_Click"/>
        </div>
        </asp:Panel>
        </form>
        <asp:Label Text="" runat="server" ID="lblerror" />

</body>
</html>
