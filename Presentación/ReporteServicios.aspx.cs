using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LogicaNegocio;

namespace Presentación
{
    public partial class ReporteServicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList();
            }
        }

        private void ConsultaXServicio(string value)
        {
            datos.DataSource = BLVehiculoServicio.ConsultaXServicios(value);
            datos.DataBind();
        }

        private void DropDownList()
        {
            drpServicios.DataSource = BLVehiculoServicio.DropDownList();
            drpServicios.DataTextField = "Descripción";
            drpServicios.DataValueField = "ID_Servicio";
            drpServicios.DataBind();
            drpServicios.Items.Insert(0, "-- Seleccione un servicio --");
        }

        protected void drpServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drpServicios.SelectedIndex != 0)
            {
                ConsultaXServicio(drpServicios.SelectedValue);
            }
            else
            {
                ConsultaXServicio(drpServicios.SelectedValue = null);
            }
        }
    }
}