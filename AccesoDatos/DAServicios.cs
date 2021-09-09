using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace AccesoDatos
{
    public class DAServicios
    {
		public static void Ingresar(Servicios serv)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Servicios ser = modelo.Servicios.Add(serv);
					modelo.SaveChanges();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}//fin del metodo de ingresar vehiculo

		public static void Eliminar(Servicios serv)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Servicios ser = modelo.Servicios.First(c => c.Descripción == serv.Descripción);
					if (ser != null)
					{
						modelo.Servicios.Remove(ser);
						modelo.SaveChanges();
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}//fin del eliminar 

		public static void Modificar(Servicios serv)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Servicios ser = modelo.Servicios.First(c => c.Descripción == serv.Descripción);

					ser.Descripción = serv.Descripción;
					ser.Monto = serv.Monto;

					modelo.SaveChanges();

				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}//fin del modificar 

		public static Servicios Consultar(Servicios serv)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Servicios ser = modelo.Servicios.FirstOrDefault(c => c.Descripción == serv.Descripción);
					return ser;
				}
				catch (Exception ex)
				{
					throw ex;
				}

			}
		}//fin del consultar

		public static List<Servicios> DropdownListServicio()
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

		public static List<Vehiculo> DropdownListVehiculo()
		{
			ModeloEntidad modelo = new ModeloEntidad();
			List<Vehiculo> vehiculo = null;
			try
			{
				//vehiculo = modelo.Vehiculo.OrderBy(c => c.ID_Vehiculo).ToList();
			}
			catch (Exception ex)
			{

				throw ex;
			}
			return vehiculo;
		}

	}
}
