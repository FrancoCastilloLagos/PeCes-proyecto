using Negocio;
using System;
using System.Web.UI;

namespace PeCesWeb
{
    public partial class DetalleTicket : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MostrarDetallesTicket(); 
            }
        }

        private void MostrarDetallesTicket()
        {
            string ticketId = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(ticketId))
            {
                var ticket = TicketController.Read(ticketId);

                if (ticket != null)
                {
                    lblIdValue.Text = ticket.Id.ToString();
                    lblClienteValue.Text = ticket.Cliente.Nombre;
                    lblProductoValue.Text = ticket.Producto;
                    lblDescripcionValue.Text = ticket.Descripción;
                    pnlDetalle.Visible = true; 
                }
                else
                {
                    lblMessage.Text = "No se encontró el ticket solicitado.";
                    lblMessage.Visible = true;
                }
            }
            else
            {
                lblMessage.Text = "ID de ticket no proporcionado.";
                lblMessage.Visible = true;
            }
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListarTodos.aspx"); 
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string ticketId = lblIdValue.Text;
            Response.Redirect($"ActualizarTicket.aspx?id={ticketId}"); 
        }
    }
}


