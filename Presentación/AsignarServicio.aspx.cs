using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentación
{
    public partial class AsignarServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownListServicio();
                DropDownListVehiculo();
            }
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            try
            {
                if (drpPlaca.SelectedValue != "-- Seleccione un vehiculo --" & drpServicio.SelectedValue!= "-- Seleccione un servicio --")
                {
                    Vehiculo_Servicio vehiculo_Servicio = new Vehiculo_Servicio();

                    vehiculo_Servicio.ID_Vehiculo = Int32.Parse(drpPlaca.SelectedValue);
                    vehiculo_Servicio.ID_Servicio = Int32.Parse(drpServicio.SelectedValue);

                    BLVehiculoServicio.Ingresar(vehiculo_Servicio);
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha asignado con éxito un servicio a un vehiculo')", true);
                    limpiar();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se debe de seleccionar un servicio o un vehiculo')", true);
                }
                
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un error al intentar asignar un servicio')", true);
            }
        }

        private void DropDownListVehiculo()
        {
            drpPlaca.DataSource = DLServicios.DropdownListVehiculo();
            drpPlaca.DataTextField = "Placa";
            drpPlaca.DataValueField = "ID_Vehiculo";
            drpPlaca.DataBind();
            drpPlaca.Items.Insert(0, "-- Seleccione un vehiculo --");
        }
        
        private void DropDownListServicio()
        {
            drpServicio.DataSource = DLServicios.DropdownListServicio();
            drpServicio.DataTextField = "Descripción";
            drpServicio.DataValueField = "ID_Servicio";
            drpServicio.DataBind();
            drpServicio.Items.Insert(0, "-- Seleccione un servicio --");
        }


        public void limpiar()
        {
            this.drpPlaca.SelectedIndex = 0;
            this.drpServicio.SelectedIndex = 0;
        }

    }
}