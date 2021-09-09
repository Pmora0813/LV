using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace AccesoDatos
{
    public class DAVehiculos
    {

        public static void IngresarVehiculo(Vehiculo vehiculo)
        {
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Vehiculo vehi = modelo.Vehiculo.Add(vehiculo);
					modelo.SaveChanges();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
        }//fin del metodo de ingresar vehiculo

		public static void Eliminar(Vehiculo vehiculo)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Vehiculo vehi = modelo.Vehiculo.First(c => c.Placa== vehiculo.Placa);
					if (vehi != null)
					{
						modelo.Vehiculo.Remove(vehi);
						modelo.SaveChanges();
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}//fin del eliminar 

		public static void Modificar(Vehiculo vehiculo)
		{
			using (ModeloEntidad modelo = new ModeloEntidad())
			{
				try
				{
					Vehiculo vehi = modelo.Vehiculo.First(c => c.Placa == vehiculo.Placa);

					vehi.Placa = vehiculo.Placa;
					vehi.Dueño = vehiculo.Dueño;
					vehi.Marca = vehiculo.Marca;

					modelo.SaveChanges();

				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}//fin del modificar 

		public static Vehiculo Consultar(Vehiculo vehiculo)
		{
			ModeloEntidad modelo = new ModeloEntidad();
			Vehiculo vehi = null;
				try
				{
					vehi = modelo.Vehiculo.FirstOrDefault(c => c.Placa == vehiculo.Placa);
					return vehi;
				}
				catch (Exception ex)
				{
					throw ex;
				}
				
			
		}//fin del consultar
	}
}
