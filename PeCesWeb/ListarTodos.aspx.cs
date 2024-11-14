using Negocio; 
using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeCesWeb
{
    public partial class ListarTodos : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string criterioBusqueda = Request.QueryString["criterio"];
                CargarTickets(criterioBusqueda);
            }

            if (!string.IsNullOrEmpty(Request.QueryString["mensaje"]))
            {
                lblMessage.Text = Request.QueryString["mensaje"];
                lblMessage.Visible = true;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBusqueda.Text.Trim();
            Response.Redirect($"ListarTodos.aspx?criterio={criterioBusqueda}");
        }

        private void CargarTickets(string criterioBusqueda = "")
        {
            var tickets = TicketController.ReadAll();

            if (!string.IsNullOrEmpty(criterioBusqueda))
            {
                criterioBusqueda = criterioBusqueda.ToLower();

                tickets = tickets.Where(t =>
                    (t.Producto != null && t.Producto.ToLower().Contains(criterioBusqueda)) ||
                    (t.Descripción != null && t.Descripción.ToLower().Contains(criterioBusqueda)) ||
                    (t.Estado != null && t.Estado.ToLower().Contains(criterioBusqueda)) ||
                    (t.Cliente != null &&
                        ((t.Cliente.Email != null && t.Cliente.Email.ToLower().Contains(criterioBusqueda)) ||
                         (t.Cliente.Telefono != null && t.Cliente.Telefono.ToLower().Contains(criterioBusqueda))))
                ).ToList();
            }

            if (tickets.Count > 0)
            {
                gvTickets.DataSource = tickets;
                gvTickets.DataBind();
                gvTickets.Visible = true;
                lblMessage.Visible = false;
            }
            else
            {
                gvTickets.Visible = false;
                lblMessage.Text = "No se encontraron tickets con el criterio de búsqueda.";
                lblMessage.Visible = true;
            }
        }

        protected void gvTickets_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detalle")
            {
                string ticketId = e.CommandArgument.ToString();
                Response.Redirect($"DetalleTicket.aspx?id={ticketId}");
            }
        }
    }
}







