using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LogicaNegocio;
using Entidades;

namespace Presentación
{
    public partial class AgregarServicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                Servicios ser = new Servicios();
                ser.Descripción = this.txtDescripción.Text.Trim();
                ser.Monto = Int32.Parse(this.txtMonto.Text.Trim());

                DLServicios.Ingresar(ser);

                Response.Redirect("Default.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios ser = new Servicios();
                ser.Descripción = txtDescripción.Text.Trim();
                DLServicios capa = new DLServicios();

                txtMonto.Text = capa.Consultar(ser).Monto.ToString();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios ser = new Servicios();
                ser.Descripción = this.txtDescripción.Text.Trim();
                ser.Monto = Int32.Parse(this.txtMonto.Text.Trim());

                DLServicios.Modificar(ser);
                this.limpiar();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Servicios ser = new Servicios();
                ser.Descripción = this.txtDescripción.Text.Trim();
                DLServicios.Eliminar(ser);
                this.limpiar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        protected void limpiar()
        {
            txtDescripción.Text = "";
            txtMonto.Text = "";
        }
    }
}