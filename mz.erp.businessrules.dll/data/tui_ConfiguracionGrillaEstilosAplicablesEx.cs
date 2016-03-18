using System;
using System.Data;
using System.Text.RegularExpressions;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using mz.erp.businessrules;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de tui_ConfiguracionGrillaEstilosAplicablesEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosAplicablesEx
	{
		#region Custom Members
		public static tui_ConfiguracionGrillaEstilosAplicablesDataset GetList(long IdProceso, long IdTarea, string Grilla, string Formulario, long IdPerfil, string IdUsuario)
		{
			tui_ConfiguracionGrillaEstilosAplicablesDataset data = tui_ConfiguracionGrillaEstilosAplicables.GetList(IdProceso, IdTarea, Grilla, Formulario);
			tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset dataEAU = tui_ConfiguracionGrillaEstilosAplicablesUsuarios.GetList(IdProceso, IdTarea, Grilla, Formulario, IdUsuario);
			foreach(tui_ConfiguracionGrillaEstilosAplicablesUsuariosDataset.tui_ConfiguracionGrillaEstilosAplicablesUsuariosRow rowEAU in dataEAU.tui_ConfiguracionGrillaEstilosAplicablesUsuarios.Rows)
			{
				long IdConfiguracion = rowEAU.IdConfiguracion;
				tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesRow rowEA = data.tui_ConfiguracionGrillaEstilosAplicables.FindByIdProcesoIdTareaGrillaIdConfiguracion(IdProceso, IdTarea, Grilla, IdConfiguracion);
				if(rowEA == null)
				{
					rowEA = data.tui_ConfiguracionGrillaEstilosAplicables.Newtui_ConfiguracionGrillaEstilosAplicablesRow();
					rowEA.IdProceso = rowEAU.IdProceso;
					rowEA.IdTarea = rowEAU.IdTarea;
					rowEA.Grilla = rowEAU.Grilla;
					rowEA.Formulario = rowEAU.Formulario;
					rowEA.IdConfiguracion = rowEAU.IdConfiguracion;
					rowEA.FechaCreacion = rowEAU.FechaCreacion;
					rowEA.IdConexionCreacion = rowEAU.IdConexionCreacion;
					rowEA.IdReservado = rowEAU.IdReservado;
					rowEA.IdEmpresa = rowEAU.IdEmpresa;
					rowEA.IdSucursal = rowEAU.IdSucursal;
					data.tui_ConfiguracionGrillaEstilosAplicables.Addtui_ConfiguracionGrillaEstilosAplicablesRow(rowEA);
				}
			}
			tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset dataEAP = tui_ConfiguracionGrillaEstilosAplicablesPerfiles.GetList(IdProceso, IdTarea, Grilla, Formulario, IdPerfil);
			foreach(tui_ConfiguracionGrillaEstilosAplicablesPerfilesDataset.tui_ConfiguracionGrillaEstilosAplicablesPerfilesRow rowEAP in dataEAP.tui_ConfiguracionGrillaEstilosAplicablesPerfiles.Rows)
			{
				long IdConfiguracion = rowEAP.IdConfiguracion;
				tui_ConfiguracionGrillaEstilosAplicablesDataset.tui_ConfiguracionGrillaEstilosAplicablesRow rowEA = data.tui_ConfiguracionGrillaEstilosAplicables.FindByIdProcesoIdTareaGrillaIdConfiguracion(IdProceso, IdTarea, Grilla, IdConfiguracion);
				if(rowEA == null)
				{
					rowEA = data.tui_ConfiguracionGrillaEstilosAplicables.Newtui_ConfiguracionGrillaEstilosAplicablesRow();
					rowEA.IdProceso = rowEAP.IdProceso;
					rowEA.IdTarea = rowEAP.IdTarea;
					rowEA.Grilla = rowEAP.Grilla;
					rowEA.Formulario = rowEAP.Formulario;
					rowEA.IdConfiguracion = rowEAP.IdConfiguracion;
					rowEA.FechaCreacion = rowEAP.FechaCreacion;
					rowEA.IdConexionCreacion = rowEAP.IdConexionCreacion;
					rowEA.IdReservado = rowEAP.IdReservado;
					rowEA.IdEmpresa = rowEAP.IdEmpresa;
					rowEA.IdSucursal = rowEAP.IdSucursal;
					data.tui_ConfiguracionGrillaEstilosAplicables.Addtui_ConfiguracionGrillaEstilosAplicablesRow(rowEA);
				}
			}

			return data;
		}		
		

		#endregion
		public tui_ConfiguracionGrillaEstilosAplicablesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	}
}
