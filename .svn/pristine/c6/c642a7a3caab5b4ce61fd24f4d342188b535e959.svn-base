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
	/// Descripción breve de tpu_RetencionesEx.
	/// </summary>
	public class tpu_RetencionesEx
	{
		public tpu_RetencionesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		#region Custom Members
		public static void Update( tpu_RetencionesExDataset dataset, string IdTransaction, SentenciasReplicacion replicacion)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataset, trx, replicacion);
		}

		public static void Update( tpu_RetencionesExDataset data, SqlTransaction trx, SentenciasReplicacion Replicacion )
		{

			try
			{
				tpu_Retenciones.Update( data.tpu_Retenciones, trx, Replicacion);
				tpu_RetencionesDet.Update( data.tpu_RetencionesDet, trx, Replicacion);
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
				//trx.Commit();
			}
			catch (System.Exception e )
			{
				data.tpu_Retenciones.Rows[0].SetColumnError("IdRetencion","No se ha podido realizar la grabación por un error en los datos");
				throw e;
			}		
		}

		
		public static DataSet GetListEx( string IdComprobante, string IdTipoDeRetencion)
		{
			DataSet data = new DataSet();
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "tpu_Retenciones" );

			SqlCommand cmd = new SqlCommand( "Pr_tpu_Retenciones_SearchEx", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeRetencion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeRetencion" ].Value = IdTipoDeRetencion;

			adapter.SelectCommand = cmd;

			adapter.Fill( data );
         
			return data;
		}


		public static System.Data.DataSet ListarRetencionesProveedores( string NumeroRetencion, DateTime FechaRetencionDesde, DateTime FechaRetencionHasta, string IdTipoDeRetencion, string NumeroRecibo, DateTime FechaReciboDesde, DateTime FechaReciboHasta, string NumeroFactura, DateTime FechaFacturaDesde, DateTime FechaFacturaHasta, long IdSucursal, long IdEmpresa, bool VerHTML)
		{

			try
			{
				SqlConnection cnx = dbhelper.Connection.GetConnection();
				cnx.Open();
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarRetencionesProveedores", cnx );
				
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@NumeroRetencion", SqlDbType.VarChar ) );
				if (NumeroRetencion =="" || NumeroRetencion == null) 
					cmd.Parameters[ "@NumeroRetencion" ].Value = System.DBNull.Value;
				else
                    cmd.Parameters[ "@NumeroRetencion" ].Value = NumeroRetencion;				
			
				cmd.Parameters.Add( new SqlParameter( "@FechaRetencionDesde", SqlDbType.DateTime ) );
				if (FechaRetencionDesde.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaRetencionDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaRetencionDesde.Year,FechaRetencionDesde.Month,FechaRetencionDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaRetencionDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaRetencionHasta", SqlDbType.DateTime ) );
				if (FechaRetencionHasta.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaRetencionHasta"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaRetencionHasta.Year,FechaRetencionHasta.Month,FechaRetencionHasta.Day,0,0,0,0);
					cmd.Parameters[ "@FechaRetencionHasta"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeRetencion", SqlDbType.VarChar ) );
				if (IdTipoDeRetencion =="" || IdTipoDeRetencion == null) 
					cmd.Parameters[ "@IdTipoDeRetencion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeRetencion" ].Value = IdTipoDeRetencion;

				cmd.Parameters.Add( new SqlParameter( "@NumeroRecibo", SqlDbType.VarChar ) );
				if (NumeroRecibo =="" || NumeroRecibo == null) 
					cmd.Parameters[ "@NumeroRecibo" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@NumeroRecibo" ].Value = NumeroRecibo;

				cmd.Parameters.Add( new SqlParameter( "@FechaReciboDesde", SqlDbType.DateTime ));
				if (FechaReciboDesde.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaReciboDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaReciboDesde.Year,FechaReciboDesde.Month,FechaReciboDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaReciboDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaReciboHasta", SqlDbType.DateTime ));
				if (FechaReciboHasta.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaReciboHasta"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaReciboHasta.Year,FechaReciboHasta.Month,FechaReciboHasta.Day,0,0,0,0);
					cmd.Parameters[ "@FechaReciboHasta"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@NumeroFactura", SqlDbType.VarChar ) );
				if (NumeroFactura =="" || NumeroFactura == null) 
					cmd.Parameters[ "@NumeroFactura" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@NumeroFactura" ].Value = NumeroFactura;

				cmd.Parameters.Add( new SqlParameter( "@FechaFacturaDesde", SqlDbType.DateTime ));
				if (FechaFacturaDesde.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaFacturaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaFacturaDesde.Year,FechaFacturaDesde.Month,FechaFacturaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaFacturaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaFacturaHasta", SqlDbType.DateTime ));
				if (FechaFacturaHasta.Equals(DateTime.MinValue))
					cmd.Parameters[ "@FechaFacturaHasta"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaFacturaHasta.Year,FechaFacturaHasta.Month,FechaFacturaHasta.Day,0,0,0,0);
					cmd.Parameters[ "@FechaFacturaHasta"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				if (IdSucursal != long.MinValue)
				{
					cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal"].Value = System.DBNull.Value;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				if (IdEmpresa != long.MinValue)
				{
					cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa"].Value = System.DBNull.Value;
				}

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_twf_Workflow_ListarRetencionesProveedores" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);
				//cnx.Close();

				return data;
			}
			catch(Exception e){;return null;}
			
		}


		#endregion
	}
}
