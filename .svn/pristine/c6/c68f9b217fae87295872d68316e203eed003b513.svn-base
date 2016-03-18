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
	/// Descripción breve de tui_ConfiguracionGrillaEstilosAplicablesModificablesEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstilosAplicablesModificablesEx
	{
		#region Custom Members
		public static bool ExisteModificable(long IdProceso, long IdTarea, string Grilla, string Formulario, long IdConfiguracion, long IdPerfil, string IdUsuario)
		{
			tui_ConfiguracionGrillaEstilosAplicablesModificablesDataset data = tui_ConfiguracionGrillaEstilosAplicablesModificables.GetList(IdProceso, IdTarea, Grilla, Formulario, IdConfiguracion);
			bool existe = data.tui_ConfiguracionGrillaEstilosAplicablesModificables.Rows.Count > 0;
			if(!existe)
			{
				tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuariosDataset dataUsuarios = tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.GetList(IdProceso, IdTarea, Grilla, Formulario, IdUsuario, IdConfiguracion);
				existe = dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Rows.Count > 0;
				if(!existe)
				{
					tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfilesDataset dataPerfiles = tui_ConfiguracionGrillaEstilosAplicablesModificablesPerfiles.GetList(IdProceso, IdTarea, Grilla, Formulario, IdPerfil, IdConfiguracion);
					existe = dataUsuarios.tui_ConfiguracionGrillaEstilosAplicablesModificablesUsuarios.Rows.Count > 0;
				}
			}
			return existe;
		}		
		

		#endregion
		public tui_ConfiguracionGrillaEstilosAplicablesModificablesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	}
}
