using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class DAVehiculo_Servicio
    {
		public static void Ingresar(Vehiculo_Servicio vehiculo_Servicio)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Vehiculo_Servicio vehi = modelo.Vehiculo_Servicio.Add(vehiculo_Servicio);
					modelo.SaveChanges();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}//fin del metodo de ingresar vehiculo


		public static List<Vehiculo_Servicio> ConsultaXServicios(string ser)
		{
			ModeloEntidad modelo = new ModeloEntidad();
			List<Vehiculo_Servicio> vehiculo_Servicios = null;
				try
				{
					vehiculo_Servicios = modelo.Vehiculo_Servicio.Where(c => c.ID_Servicio.ToString() == ser).ToList();
					
				}
				catch (Exception ex)
				{
					throw ex;
				}
				return vehiculo_Servicios;
		}

		public static List<Servicios> DropdownList()
		{
			ModeloEntidad modelo = new ModeloEntidad();
			List<Servicios> servicios = null;
			try
			{
				//servicios = modelo.Servicios.OrderBy(c => c.ID_Servicio).ToList();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return servicios;
		}

	}
}
