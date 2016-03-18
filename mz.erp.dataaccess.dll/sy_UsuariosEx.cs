using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de sy_UsuariosEx.
	/// </summary>
	public class sy_UsuariosEx
	{
		public sy_UsuariosEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		public static void Update( sy_UsuariosExDataset data )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			SentenciasReplicacion replication = null;

			try
			{
				mz.erp.dataaccess.sy_Usuarios.Update( data.sy_Usuarios, trx, replication );
				mz.erp.dataaccess.sy_PerfilesUsuariosEmpresas.Update(data.sy_PerfilesUsuariosEmpresas,trx);
				mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.Update(data.tlg_ResponsablesDepositosSecciones, trx);
				trx.Commit();
			}
			catch(Exception e)
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}

	}
}
