using Negocio;
using System;
using System.Web.UI;

namespace PeCesWeb
{
    public partial class ActualizarTicket : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string ticketId = Request.QueryString["id"]; 

                if (!string.IsNullOrEmpty(ticketId))
                {
                    CargarDetallesTicket(ticketId); 
                }
                else
                {
                    lblError.Text = "El ticket no fue encontrado.";
                    lblError.Visible = true;
                }
            }
        }

        private void CargarDetallesTicket(string ticketId)
        {
            Ticket ticket = TicketController.Read(ticketId); 

            if (ticket != null)
            {
                lblIdValue.Text = ticket.Id;
                lblClienteValue.Text = ticket.Cliente.Nombre; 
                lblProductoValue.Text = ticket.Producto;
                lblDescripcionValue.Text = ticket.Descripción;

                txtProducto.Text = ticket.Producto;
                txtDescripcion.Text = ticket.Descripción;
                txtTelefono.Text = ticket.Cliente.Telefono;
                txtEmail.Text = ticket.Cliente.Email;
            }
            else
            {
                lblError.Text = "El ticket no fue encontrado.";
                lblError.Visible = true;
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string ticketId = lblIdValue.Text; 
                var ticket = new Ticket
                {
                    Id = ticketId,
                    Producto = txtProducto.Text.Trim(),
                    Descripción = txtDescripcion.Text.Trim(),
                    Cliente = new Cliente 
                    {
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    }
                };

                string resultado = TicketController.Update(ticket); 

              
                Response.Redirect($"ListarTodos.aspx?mensaje={resultado}");
            }
            catch (Exception ex)
            {
            
                lblError.Text = "Ocurrió un error al actualizar el ticket: " + ex.Message;
                lblError.Visible = true;
            }
        }
    }
}








