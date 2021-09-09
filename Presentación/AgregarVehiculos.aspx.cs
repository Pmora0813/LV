using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using LogicaNegocio;
using Entidades;
using System.Data.SqlClient;

namespace Presentación
{
    public partial class AgregarVehiculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {

                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = this.txtPlaca.Text.Trim();
                vehiculo.Dueño = this.txtDueño.Text.Trim();
                vehiculo.Marca = this.txtMarca.Text.Trim();

                BLVehiculo.IngresarVehiculo(vehiculo);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha ingresado un nuevo vehiculo con éxito)", true);
                limpiar();
            }
            catch 
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un error al ingresar)", true);
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = txtPlaca.Text;
                BLVehiculo capa = new BLVehiculo();
                    txtMarca.Text = capa.Consultar(vehiculo).Marca;
                    txtDueño.Text = capa.Consultar(vehiculo).Dueño;              
            }
            catch 
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un error al consultar)", true);
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = this.txtPlaca.Text.Trim();
                vehiculo.Dueño = this.txtDueño.Text.Trim();
                vehiculo.Marca = this.txtMarca.Text.Trim();

                BLVehiculo.Modificar(vehiculo);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha modificado un vehiculo con éxito)", true);
                this.limpiar();

            }
            catch 
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un error al modificar)", true);
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Vehiculo vehiculo = new Vehiculo();
                vehiculo.Placa = this.txtPlaca.Text.Trim();
                BLVehiculo.Eliminar(vehiculo);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Se ha eliminado un vehiculo con éxito)", true);
                this.limpiar();
            }
            catch 
            {

                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Ha ocurrido un error al eliminar)", true);
            }
        }

        protected void limpiar()
        {
            txtDueño.Text = "";
            txtMarca.Text = "";
            txtPlaca.Text = "";
        }

    }
}