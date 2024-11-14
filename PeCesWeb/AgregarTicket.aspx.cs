using Negocio;
using System;

namespace PeCesWeb
{
    public partial class AgregarTicket : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnCrearTicket_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) 
            {
                var ticket = new Ticket
                {
                    Cliente = new PersonaNatural
                    {
                        Nombre = txtNombreCliente.Text,
                        Rut = txtRut.Text,
                        Telefono = txtTelefono.Text,
                        Email = txtEmail.Text
                    },
                    Producto = txtNombreProducto.Text,
                    Descripción = txtDescripcion.Text,
                    Estado = "Nuevo" 
                };

                string resultado = TicketController.Create(ticket);

                if (resultado.StartsWith("Error"))
                {
                    lblError.Text = resultado;
                    lblError.Visible = true;
                    lblSuccess.Visible = false; 
                }
                else
                {
                    lblSuccess.Text = resultado;
                    lblSuccess.Visible = true;
                    lblError.Visible = false; 

                    LimpiarCampos();
                }
            }
            else
            {
                lblError.Text = "Por favor corrige los errores en el formulario.";
                lblError.Visible = true;
                lblSuccess.Visible = false; 
                lblSuccess.Visible = false; 
            }
        }

        private void LimpiarCampos()
        {
            txtNombreCliente.Text = "";
            txtRut.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombreProducto.Text = "";
            txtDescripcion.Text = "";
        }
    }
}







