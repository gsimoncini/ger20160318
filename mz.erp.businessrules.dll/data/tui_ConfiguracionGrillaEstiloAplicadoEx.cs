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
	/// Descripción breve de tui_ConfiguracionGrillaEstiloAplicadoEx.
	/// </summary>
	public class tui_ConfiguracionGrillaEstiloAplicadoEx
	{
		#region Custom Members
		public static long GetIdConfiguracionAplicada(string IdUsuario, long IdPerfil, long IdProceso, long IdTarea, string Grilla, string Formulario)
		{
			long IdConfiguracion = tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetIdConfiguracionAplicada(IdUsuario, IdProceso, IdTarea, Grilla, Formulario);
			if(IdConfiguracion.Equals(long.MinValue))
			{
				IdConfiguracion = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetIdConfiguracionAplicada(IdPerfil, IdProceso, IdTarea, Grilla, Formulario);
				if(IdConfiguracion.Equals(long.MinValue))
					IdConfiguracion = tui_ConfiguracionGrillaEstiloAplicado.GetIdConfiguracionAplicada(IdProceso, IdTarea, Grilla, Formulario);
			}
			return IdConfiguracion;

		}

		public static bool EstaAplicada(long IdConfiguracion)
		{
			tui_ConfiguracionGrillaEstiloAplicadoUsuariosDataset dataUsuarios= tui_ConfiguracionGrillaEstiloAplicadoUsuarios.GetList( string.Empty, long.MinValue, long.MinValue, string.Empty, string.Empty, IdConfiguracion );
			bool estaAplicada = dataUsuarios.tui_ConfiguracionGrillaEstiloAplicadoUsuarios.Rows.Count > 0;
			if(!estaAplicada)
			{
				tui_ConfiguracionGrillaEstiloAplicadoPerfilesDataset dataPerfiles = tui_ConfiguracionGrillaEstiloAplicadoPerfiles.GetList( long.MinValue, long.MinValue, long.MinValue, string.Empty, string.Empty, IdConfiguracion );
				estaAplicada = dataPerfiles.tui_ConfiguracionGrillaEstiloAplicadoPerfiles.Rows.Count > 0;
				if(!estaAplicada)
				{
					tui_ConfiguracionGrillaEstiloAplicadoDataset data = tui_ConfiguracionGrillaEstiloAplicado.GetList(long.MinValue, long.MinValue, string.Empty, string.Empty, IdConfiguracion );
					estaAplicada = data.tui_ConfiguracionGrillaEstiloAplicado.Rows.Count > 0;
				}
			}
			return estaAplicada;

		}
		#endregion
		public tui_ConfiguracionGrillaEstiloAplicadoEx()
		{
		}

		/*public static void Update(tui_ConfiguracionGrillaEstiloAplicadoExDataset data)
		{
			SentenciasReplicacion replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tpu_ComprobantesEx.Update(data, replicacion);
		}*/

		#region replicacion

		private static SentenciasReplicacion GenerateReplication()
		{
			//Nuevo
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tui_ConfiguracionGrillaEstiloAplicado";
			return replication;
		}

		#endregion
	}
}
