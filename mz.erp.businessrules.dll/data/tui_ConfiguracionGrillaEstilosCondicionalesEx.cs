using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using System.Collections;
namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tui_ConfiguracionGrillaEstilosCondicionalesEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosCondicionalesEx
	{
		#region Custom Members
		public static long GetIdConfiguracionByName( string Nombre)
		{
			long IdConfiguracion = long.MinValue;
			tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow row = tui_ConfiguracionGrillaEstilosCondicionales.GetByName(Nombre);
			if(row != null)
				IdConfiguracion = row.IdConfiguracion;
			else
			{
				tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowU = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetByName(Nombre);
				if(rowU != null)
					IdConfiguracion = rowU.IdConfiguracion;
				else
				{
					tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowP = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetByName(Nombre);
					if(rowP != null)
						IdConfiguracion = rowP.IdConfiguracion;
				}
			}

			return IdConfiguracion;

		}


		public static int GetCantidadConfiguracionesUsuario( string IdUsuarioCreador)
		{
			tui_ConfiguracionGrillaEstilosCondicionalesDataset data = tui_ConfiguracionGrillaEstilosCondicionales.GetList(long.MinValue, string.Empty, IdUsuarioCreador, DateTime.MinValue, long.MinValue, long.MinValue );
			int cant = data.tui_ConfiguracionGrillaEstilosCondicionales.Rows.Count;
			tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset dataUsuarios = tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.GetList(string.Empty, long.MinValue, string.Empty, IdUsuarioCreador, long.MinValue, long.MinValue );
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesUsuariosDataset.tui_ConfiguracionGrillaEstilosCondicionalesUsuariosRow rowU in dataUsuarios.tui_ConfiguracionGrillaEstilosCondicionalesUsuarios.Rows)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow row = data.tui_ConfiguracionGrillaEstilosCondicionales.FindByIdConfiguracion(rowU.IdConfiguracion);
				if(row == null)
					cant++;
			}

			tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset dataPerfiles = tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.GetList(long.MinValue, long.MinValue, string.Empty, IdUsuarioCreador, long.MinValue, long.MinValue );
			foreach(tui_ConfiguracionGrillaEstilosCondicionalesPerfilesDataset.tui_ConfiguracionGrillaEstilosCondicionalesPerfilesRow rowP in dataPerfiles.tui_ConfiguracionGrillaEstilosCondicionalesPerfiles.Rows)
			{
				tui_ConfiguracionGrillaEstilosCondicionalesDataset.tui_ConfiguracionGrillaEstilosCondicionalesRow row = data.tui_ConfiguracionGrillaEstilosCondicionales.FindByIdConfiguracion(rowP.IdConfiguracion);
				if(row == null)
					cant++;
			}
			return cant;

		}

		#endregion

		public tui_ConfiguracionGrillaEstilosCondicionalesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	}
}
