using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class BLVehiculoServicio
    {
        public static void Ingresar(Vehiculo_Servicio vehiculo_Servicio)
        {
            DAVehiculo_Servicio.Ingresar(vehiculo_Servicio);
        }

        public static List<Vehiculo_Servicio> ConsultaXServicios(string ser)
        {
            return DAVehiculo_Servicio.ConsultaXServicios(ser);
        }

        public static List<Servicios> DropDownList()
        {
            return DAVehiculo_Servicio.DropdownList();
        }
    }
}
