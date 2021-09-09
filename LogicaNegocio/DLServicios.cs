using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class DLServicios
    {

        public static void Ingresar(Servicios ser)
        {
            DAServicios.Ingresar(ser);
        }

        public static void Eliminar(Servicios ser)
        {
            DAServicios.Eliminar(ser);
        }

        public static void Modificar(Servicios ser)
        {
            DAServicios.Modificar(ser);
        }
        public Servicios Consultar(Servicios ser)
        {
            return DAServicios.Consultar(ser);
        }

        public static List<Servicios> DropdownListServicio()
        {
            return DAServicios.DropdownListServicio();
        }

        public static List<Vehiculo> DropdownListVehiculo()
        {
            return DAServicios.DropdownListVehiculo();
        }

    }
}
