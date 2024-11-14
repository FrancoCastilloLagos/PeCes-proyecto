<%@ Page Title="Listar Todos los Tickets" Language="C#" MasterPageFile="~/MPSitio.Master" AutoEventWireup="true" CodeBehind="ListarTodos.aspx.cs" Inherits="PeCesWeb.ListarTodos" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Listado de Tickets</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    
    <asp:TextBox ID="txtBusqueda" runat="server" Placeholder="Buscar..."></asp:TextBox>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />

    <asp:GridView ID="gvTickets" runat="server" AutoGenerateColumns="false" OnRowCommand="gvTickets_RowCommand">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="ID" />
            <asp:BoundField DataField="Cliente.Nombre" HeaderText="Cliente" />
            <asp:BoundField DataField="Producto" HeaderText="Producto" />
            <asp:BoundField DataField="Descripción" HeaderText="Descripción" />
            <asp:TemplateField HeaderText="Acciones">
                <ItemTemplate>
                    <asp:Button ID="btnDetalle" runat="server" Text="Ver Detalle" 
                                CommandName="Detalle" CommandArgument='<%# Eval("Id") %>' />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>




