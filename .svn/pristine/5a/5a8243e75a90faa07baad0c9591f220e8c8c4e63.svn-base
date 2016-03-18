using System;
using mz.erp.commontypes.data;

using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;


namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tfi_MovimientosDeCajaEx.
	/// </summary>
	public class tfi_MovimientosDeCajaEx
	{
		public tfi_MovimientosDeCajaEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static System.Data.DataSet GetComprobantesTesoreria (System.Data.DataSet data)
		
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Pr_tfi_GetComprobantesTesoreria" );

			SqlCommand cmd = new SqlCommand( "Pr_tfi_GetComprobantesTesoreria", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return  data;

		
		}

		public static tfi_MovimientosDeCajaExDataset.tfi_MovimientosDeCajaRow NewRow(tfi_MovimientosDeCajaExDataset data)
		{
			return data.tfi_MovimientosDeCaja.Newtfi_MovimientosDeCajaRow();
		}



		public static void Update(tfi_MovimientosDeCajaExDataset data, string IdVariable)
		{

			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			SentenciasReplicacion replication = null;

			try
			{
				mz.erp.dataaccess.tfi_ValoresEx.Update(data.Tables["tfi_Valores"] , trx );
				mz.erp.dataaccess.tfi_ValoresDatosAuxiliares.Update(data.Tables["tfi_ValoresDatosAuxiliares"], trx, replication);
				mz.erp.dataaccess.tfi_MovimientosDeCaja.Update (data.tfi_MovimientosDeCaja, trx, replication);
				//sy_Variables.Update(IdVariable, (string)data.tfi_MovimientosDeCaja.Rows[0]["Numero"],trx);
				mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update(data.tfi_PagosMovimientosCajas, trx, replication);
				trx.Commit();
			}
			catch (Exception e)
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
