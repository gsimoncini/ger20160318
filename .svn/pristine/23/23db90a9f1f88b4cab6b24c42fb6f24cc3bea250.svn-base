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
	/// Descripción breve de tfi_AuditoriaControlCajasEx.
	/// </summary>
	public class tfi_AuditoriaControlCajasEx
	{
		public tfi_AuditoriaControlCajasEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static void Update(tfi_AuditoriaControlCajasExDataset data, SentenciasReplicacion replicacion )
		{

			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );


			try
			{
				mz.erp.dataaccess.tfi_AuditoriaControlCajas.Update(data.Tables["tfi_AuditoriaControlCajas"] , trx, replicacion);
				mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.Update(data.Tables["tfi_AuditoriaControlCajasDet"], trx, replicacion);
				mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.Update (data.Tables["tfi_AuditoriaControlCajasDetalleBilletes"], trx, replicacion);
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
		

		public static System.Data.DataSet GetAuditoriaCajasAbiertas ( string IdCajas)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_AuditoriaControlCajas_GetAuditoriaCajasAbiertas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar));
				cmd.Parameters["@IdCajas"].Value = IdCajas;

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e)
			{
				System.Console.WriteLine(e.ToString() );
			}
			return data;
		}

		public static System.Data.DataSet GetAuditoriaCajasCerradas ( string IdCajas, System.DateTime fechaApertura, System.DateTime fechaCierre)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_AuditoriaControlCajas_GetAuditoriaCajasCerradas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar));
				cmd.Parameters["@IdCajas"].Value = IdCajas;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}

				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e)
			{
				System.Console.WriteLine(e.ToString() );
			}
			return data;
		}
	
		public static System.Data.DataSet GetAuditoriaCajasAbiertasYCerradas ( string IdCajas, System.DateTime fechaApertura, System.DateTime fechaCierre)
		{
			System.Data.DataSet data = new DataSet();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();

				SqlCommand cmd = new SqlCommand( "Pr_tfi_AuditoriaControlCajas_GetAuditoriaCajasAbiertasYCerradas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = Sistema.GetTimeout(cmd.CommandText);
			
				cmd.Parameters.Add( new SqlParameter( "@IdCajas", SqlDbType.VarChar));
				cmd.Parameters["@IdCajas"].Value = IdCajas;

				cmd.Parameters.Add( new SqlParameter( "@fechaApertura", SqlDbType.DateTime ) );
				if (fechaApertura.Equals( DateTime.MinValue ) )
				{
					cmd.Parameters["@FechaApertura"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaApertura"].Value = fechaApertura;
				}
				cmd.Parameters.Add( new SqlParameter( "@FechaCierre", SqlDbType.DateTime ) );
				if (fechaCierre.Equals( DateTime.MinValue ))
				{
					cmd.Parameters["@FechaCierre"].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters["@FechaCierre"].Value = fechaCierre;
				}
				
				adapter.SelectCommand = cmd;
				adapter.Fill( data, "Result" );
			}
			catch (	Exception e)
			{
				System.Console.WriteLine(e.ToString() );
			}
			return data;
		}

	}
}
