using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class BLVehiculo
    {

        public static void IngresarVehiculo(Vehiculo vehiculo)
        {
            DAVehiculos.IngresarVehiculo(vehiculo);
        }
        
        public static void Eliminar(Vehiculo vehiculo)
        {
            DAVehiculos.Eliminar(vehiculo);
        }
        
        public static void Modificar(Vehiculo vehiculo)
        {
            DAVehiculos.Modificar(vehiculo);
        }
        public Vehiculo Consultar(Vehiculo vehiculo)
        {
            return DAVehiculos.Consultar(vehiculo);
        }

    }
}
