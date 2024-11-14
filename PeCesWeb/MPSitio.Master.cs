using System;
using System.Web.UI;

namespace PeCesWeb
{
    public partial class MPSitio : MasterPage 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = txtBusqueda.Text.Trim(); 
            if (!string.IsNullOrEmpty(criterioBusqueda))
            {
                Response.Redirect($"~/ListarTodos.aspx?criterio={Server.UrlEncode(criterioBusqueda)}");
            }
        }
    }
}


