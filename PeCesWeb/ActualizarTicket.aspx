<%@ Page Title="Actualizar Ticket" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="ActualizarTicket.aspx.cs" Inherits="PeCesWeb.ActualizarTicket" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Actualizar Ticket</h2>

    <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    
    <div>
        <strong>ID:</strong> <asp:Label ID="lblIdValue" runat="server" />
    </div>
    
    <div>
        <strong>Cliente:</strong> <asp:Label ID="lblClienteValue" runat="server" />
    </div>
    
    <div>
        <strong>Producto:</strong> <asp:Label ID="lblProductoValue" runat="server" />
    </div>
    
    <div>
        <strong>Descripción:</strong> <asp:Label ID="lblDescripcionValue" runat="server" />
    </div>

    <div>
        <label>Producto:</label>
        <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
    </div>
    
    <div>
        <label>Descripción:</label>
        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
    </div>
    
    <div>
        <label>Teléfono:</label>
        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
    </div>
    
    <div>
        <label>Email:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </div>
    
    <div>
        <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
    </div>
</asp:Content>




