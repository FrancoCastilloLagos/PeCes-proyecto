<%@ Page Title="Crear Ticket" Language="C#" MasterPageFile="~/MPSitio.master" AutoEventWireup="true" CodeBehind="AgregarTicket.aspx.cs" Inherits="PeCesWeb.AgregarTicket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Crear Ticket</h2>
    
    <asp:ValidationSummary ID="vsErrores" runat="server" 
        HeaderText="Por favor corrige los siguientes errores:" 
        ForeColor="Red" 
        ShowSummary="true" 
        ShowMessageBox="false" 
        ShowDetail="true" 
        ValidationGroup="vgCrearTicket" />

    <asp:Label ID="lblError" runat="server" ForeColor="Red" Visible="false"></asp:Label>
    <asp:Label ID="lblSuccess" runat="server" ForeColor="Green" Visible="false"></asp:Label>

    <div>
        <label>Tipo de Cliente:</label>
        <asp:DropDownList ID="ddlTipoCliente" runat="server">
            <asp:ListItem Text="Seleccionar" Value="" />
            <asp:ListItem Text="Cliente" Value="Cliente" />
            <asp:ListItem Text="Empresa" Value="Empresa" />
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="rfvTipoCliente" runat="server" ControlToValidate="ddlTipoCliente" 
            InitialValue="" ErrorMessage="Debe seleccionar un tipo de cliente." ForeColor="Red" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <label>Nombre del Cliente:</label>
        <asp:TextBox ID="txtNombreCliente" runat="server" />
        <asp:RequiredFieldValidator ID="rfvNombreCliente" runat="server" ControlToValidate="txtNombreCliente" 
            ErrorMessage="El nombre del cliente es obligatorio." ForeColor="Red" ValidationGroup="vgCrearTicket" />
        <asp:RegularExpressionValidator ID="revNombreCliente" runat="server" ControlToValidate="txtNombreCliente" 
            ErrorMessage="El nombre debe tener al menos 5 caracteres." ForeColor="Red" 
            ValidationExpression="^.{5,}$" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <label>RUT:</label>
        <asp:TextBox ID="txtRut" runat="server" />
        <asp:RequiredFieldValidator ID="rfvRut" runat="server" ControlToValidate="txtRut" 
            ErrorMessage="El RUT es obligatorio." ForeColor="Red" ValidationGroup="vgCrearTicket" />
        <asp:RegularExpressionValidator ID="revRut" runat="server" ControlToValidate="txtRut" 
            ErrorMessage="Formato de RUT no válido. Debe ser 12345678-9." ForeColor="Red" 
            ValidationExpression="^\d{7,8}-[0-9kK]$" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <label>Teléfono:</label>
        <asp:TextBox ID="txtTelefono" runat="server" />
        <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono" 
            ErrorMessage="El teléfono es obligatorio." ForeColor="Red" ValidationGroup="vgCrearTicket" />
        <asp:RegularExpressionValidator ID="revTelefono" runat="server" ControlToValidate="txtTelefono" 
            ErrorMessage="Teléfono no válido, debe tener 9 caracteres." ForeColor="Red" 
            ValidationExpression="^\d{7,}$" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <label>Email:</label>
        <asp:TextBox ID="txtEmail" runat="server" />
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmail" 
            ErrorMessage="El email es obligatorio." ForeColor="Red" ValidationGroup="vgCrearTicket" />
        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" 
            ErrorMessage="Email no válido, debe ser formato nombre@email.com." ForeColor="Red" 
            ValidationExpression="^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <label>Nombre del Producto:</label>
        <asp:TextBox ID="txtNombreProducto" runat="server" />
        <asp:RequiredFieldValidator ID="rfvNombreProducto" runat="server" ControlToValidate="txtNombreProducto" 
            ErrorMessage="El nombre del producto es obligatorio." ForeColor="Red" ValidationGroup="vgCrearTicket" />
        <asp:RegularExpressionValidator ID="revNombreProducto" runat="server" ControlToValidate="txtNombreProducto" 
            ErrorMessage="El nombre del producto debe tener al menos 3 caracteres." ForeColor="Red" 
            ValidationExpression="^.{3,}$" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <label>Descripción:</label>
        <asp:TextBox ID="txtDescripcion" runat="server" TextMode="MultiLine" Rows="4" />
        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" 
            ErrorMessage="La descripción es obligatoria." ForeColor="Red" ValidationGroup="vgCrearTicket" />
        <asp:RegularExpressionValidator ID="revDescripcion" runat="server" ControlToValidate="txtDescripcion" 
            ErrorMessage="La descripción debe tener al menos 10 caracteres." ForeColor="Red" 
            ValidationExpression="^.{10,}$" ValidationGroup="vgCrearTicket" />
    </div>

    <div>
        <asp:Button ID="btnCrearTicket" runat="server" Text="Crear Ticket" OnClick="btnCrearTicket_Click" 
            ValidationGroup="vgCrearTicket" />
    </div>
</asp:Content>











