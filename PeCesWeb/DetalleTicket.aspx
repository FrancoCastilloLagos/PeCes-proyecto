<%@ Page Title="Detalle del Ticket" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="DetalleTicket.aspx.cs" Inherits="PeCesWeb.DetalleTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Detalles del Ticket</h2>
    <asp:Panel ID="pnlDetalle" runat="server" Visible="false">
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
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="false" />
        </div>
    </asp:Panel>
    <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" />
</asp:Content>

