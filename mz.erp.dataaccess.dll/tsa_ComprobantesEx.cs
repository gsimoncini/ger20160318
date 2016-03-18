using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes.data;
using mz.erp.commontypes;


using System.Collections;


namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tsa_ComprobantesEx.
	/// </summary>
	public class tsa_ComprobantesEx
	{
		public tsa_ComprobantesEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}



		#region Custom Members
		
		private static SentenciasReplicacion _replicacion;

		public static bool IncluyeImpuestos(string IdComprobante, string listaImpuestos)
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Impuestos" );
			
			SqlCommand cmd = new SqlCommand( "Pr_Tsa_Comprobantes_SearchImpuestos", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@listaImpuestos", SqlDbType.VarChar ) );
			cmd.Parameters[ "@listaImpuestos" ].Value = listaImpuestos;
			adapter.SelectCommand = cmd;
			adapter.Fill( data, "Impuestos" );
         
			return data.Tables[0].Rows.Count > 0;
		}

		#endregion
	

		public static tsa_ComprobantesExDataset NewDataset()
		{
			tsa_ComprobantesExDataset data = new mz.erp.commontypes.data.tsa_ComprobantesExDataset();
			
			return data;
			
		}
		public static tsa_ComprobantesExDataset.tsa_ComprobantesRow NewRow()
		{
			return (new tsa_ComprobantesExDataset()).tsa_Comprobantes.Newtsa_ComprobantesRow();
		}
		public static tsa_ComprobantesExDataset.tsa_ComprobantesRow NewRow( tsa_ComprobantesExDataset data )
		{
			return data.tsa_Comprobantes.Newtsa_ComprobantesRow();
		}

		public static System.Data.DataSet AddRowComprobantes( tsa_ComprobantesExDataset data, tsa_ComprobantesExDataset.tsa_ComprobantesRow row )
		{
			data.tsa_Comprobantes.Addtsa_ComprobantesRow( row );
			return (System.Data.DataSet)data;
		}

		public static void Update( tsa_ComprobantesExDataset data , string IdVariable, ref string IdComprobante, SentenciasReplicacion replicacion , tsa_AplicacionPagosDataset dataAplicacionDePagos , tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda, tsa_ComprobantesExDataset dataComprobanteCancelacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				Update( data , IdVariable, ref IdComprobante, trx , replicacion);
				UpdateDesimputacion(dataDetalleDeuda, dataAplicacionDePagos,trx);
				UpdateCancelacion(dataComprobanteCancelacion, trx, replicacion);
				//mz.erp.dataaccess.tsa_ComprobanteValoresVarAux.Update(IdComprobanteDeVenta, "11", IdComprobanteDePago, trx);
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
				trx.Commit();
			}
			catch (Exception e)
			{
				trx.Rollback();
				data.tsa_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
			}
			finally
			{
				cnx.Close();				
			}

		}

		public static void Update( tsa_ComprobantesExDataset data , string IdVariable, ref string IdComprobante, SentenciasReplicacion replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				Update( data , IdVariable, ref IdComprobante, trx , replicacion);
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
				trx.Commit();
			}
			catch (Exception e)
			{
				trx.Rollback();
				data.tsa_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
			}
			finally
			{
				cnx.Close();				
			}

		}

	public static void Update( tsa_ComprobantesExDataset data , string IdVariable, ref string IdComprobante, SqlTransaction trx , SentenciasReplicacion replicacion)
		{
						
			tsa_Comprobantes.Update( data.Tables["tsa_Comprobantes"], trx, replicacion);	
			IdComprobante = (string)data.tsa_Comprobantes.Rows[0]["IdComprobante"];		
			sy_Variables.Update(IdVariable,(string) data.Tables["tsa_Comprobantes"].Rows[0]["Numero"],trx);				
			tsa_ComprobanteDetalleDeuda.Update( data.Tables["tsa_ComprobanteDetalleDeuda"],trx, replicacion); 				
			tsa_ComprobantesDet.Update( data.Tables["tsa_ComprobantesDet"], trx, replicacion);							
			tlg_MovimientosDeStock.Update( data.Tables[ "tlg_MovimientosDeStock"] , trx, replicacion );
			tsa_ComprobanteDetalleImpuestos.Update( data.Tables["tsa_ComprobanteDetalleImpuestos"], trx,replicacion);
			tsa_ComprobanteValoresVarAux.Update( data.Tables["tsa_ComprobanteValoresVarAux"], trx, replicacion);
			tsa_ComprobanteDetalleDescripcionAdicional.Update( data.Tables["tsa_ComprobanteDetalleDescripcionAdicional"], trx, replicacion );

			/// <summary>
			/// ComprobantesRelacionOrigenDestino: esta tabla puede ser nula (y por lo tanto no participar de la 
			/// replicación) cuando el origen es igual al destino. Este control se realiza en el commit de mz.erp.businessrules.comprobantes.itemComprobante
			/// </summary>																	
			tsa_ComprobantesRelacionOrigenDestino.Update( data.Tables["tsa_ComprobantesRelacionOrigenDestino"], trx, replicacion, (string)data.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"] );
		}

		public static System.Data.DataSet GetVariablesAuxiliaresPorTipo( string IdTipoDeComprobante )
		{
			System.Data.DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "VariablesAuxiliares" );
			
			SqlCommand cmd = new SqlCommand( "Pr_tsy_VarAuxComprobantes_Search", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data, "VariablesAuxiliares" );
         
			return data;
		}

		public static System.Data.DataSet GetVariablesAuxiliaresPorId( string IdComprobante, string IdTipoDeComprobante )
		{
			System.Data.DataSet data  = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "VariablesAuxiliares");
			SqlCommand cmd = new SqlCommand( "Pr_tsy_ValoresVarAuxComprobantes_Search", dbhelper.Connection.GetConnection());
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;
			
			adapter.SelectCommand = cmd;

			adapter.Fill( data, "VariablesAuxiliares" );
         
			return data;
			
		}

		public static void UpdateComprobanteDeVentaYComprobanteDePago( tsa_ComprobantesExDataset comprobantedeVenta, tsa_ComprobantesExDataset comprobantedePago, string IdVariableVenta, string IdVariablePago, ref string IdComprobanteDeVenta, ref string IdComprobanteDePago, SentenciasReplicacion Replicacion , string ComprobantesDeVentas)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				string IdComprobanteAnt = (string)comprobantedeVenta.tsa_Comprobantes.Rows[0]["IdComprobante"];
				
				Update( comprobantedeVenta, IdVariableVenta, ref IdComprobanteDeVenta, trx, Replicacion );
				Merge(comprobantedeVenta, comprobantedePago,IdComprobanteAnt, ComprobantesDeVentas);
				UpdateComprobanteDePago( comprobantedePago,ref IdComprobanteDePago, IdVariablePago, trx ,Replicacion);
				mz.erp.dataaccess.tsa_ComprobanteValoresVarAux.Update(IdComprobanteDeVenta, "11", IdComprobanteDePago, trx);
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
				trx.Commit();
			}
			catch (System.Exception e )
			{
				//Debug.WriteLine(e.Message);
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}

		}

		private static void Merge(tsa_ComprobantesExDataset comprobantedeVenta, tsa_ComprobantesExDataset comprobantedePago,  string IdComprobanteDeVenta, string comprobantesDeVentas)
		{
			if(comprobantedeVenta.tsa_Comprobantes.Rows.Count > 0)
			{
				System.Data.DataRow row = comprobantedeVenta.tsa_Comprobantes.Rows[0];
				string IdComprobante = (string) comprobantedePago.tsa_Comprobantes.Rows[0]["IdComprobante"];
				string IdComprobanteNuevo = (string) row["IdComprobante"];
				//row["IdComprobante"]= IdComprobanteDeVenta;
				comprobantedePago.tsa_Comprobantes.LoadDataRow(row.ItemArray, true);
				ArrayList comps = mz.erp.systemframework.Util.Parse(comprobantesDeVentas,",");
				string idAux = null;
				/*
				foreach(System.Data.DataRow rowDet  in comprobantedePago.tsa_ComprobanteDetalleDeuda.Rows)
				{
					if(comps.Contains(((string)rowDet["IdTipoDeComprobante"])))
					{
						idAux = (string)rowDet["IdComprobante"] ;
						rowDet["IdComprobante"] = IdComprobanteNuevo;
					}
				}*/
				System.Data.DataRow rowAplic = comprobantedePago.tsa_AplicacionPagos.FindByIdComprobanteOrigenCuotaOrigenIdComprobanteDestino(IdComprobanteDeVenta,1,IdComprobante);
				if(rowAplic != null)
					rowAplic["IdComprobanteOrigen"] = IdComprobanteNuevo;
			}




		}


		public static void UpdateComprobanteDeVentaYComprobanteDePago( tsa_ComprobantesExDataset comprobantedeVenta, tsa_ComprobantesExDataset comprobantedePago, string IdVariableVenta, string IdVariablePago, ref string IdComprobanteDeVenta, ref string IdComprobanteDePago, SentenciasReplicacion Replicacion ,string ComprobantesDeVentas, tsa_AplicacionPagosDataset dataAplicacionDePagos , tsa_ComprobanteDetalleDeudaDataset dataDetalleDeuda, tsa_ComprobantesExDataset dataComprobanteCancelacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();
			cnx.Open();
			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				string IdComprobanteAnt = (string)comprobantedeVenta.tsa_Comprobantes.Rows[0]["IdComprobante"];
				Update( comprobantedeVenta, IdVariableVenta, ref IdComprobanteDeVenta, trx, Replicacion );
				Merge(comprobantedeVenta, comprobantedePago, IdComprobanteAnt, ComprobantesDeVentas);
				UpdateComprobanteDePago( comprobantedePago, ref IdComprobanteDePago, IdVariablePago, trx ,Replicacion);
				UpdateDesimputacion(dataDetalleDeuda, dataAplicacionDePagos,trx);
                UpdateCancelacion(dataComprobanteCancelacion, trx, Replicacion);
				mz.erp.dataaccess.tsa_ComprobanteValoresVarAux.Update(IdComprobanteDeVenta, "11", IdComprobanteDePago, trx);
				Replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(Replicacion.Data.sy_SentenciasReplicacion, trx);
				trx.Commit();
			}
			catch (System.Exception e )
			{
				//Debug.WriteLine(e.Message);
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}

		}

		public static void UpdateComprobanteDePago(tsa_ComprobantesExDataset data, ref string IdComprobanteDePago, string IdVariable, SentenciasReplicacion replicacion)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				UpdateComprobanteDePago(data, ref IdComprobanteDePago ,IdVariable, trx , replicacion);
				trx.Commit();
			}
			catch (System.Exception e )
			{
				//Debug.WriteLine(e.Message);
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void UpdateCancelacion(tsa_ComprobantesExDataset data, SqlTransaction trx,SentenciasReplicacion replicacion)
		{
			if(data.tsa_Comprobantes.Rows.Count > 0 )
			{
				string IdVariable = data.tsa_Comprobantes.Rows[0]["Numero"].ToString();
				string Id = "";
				UpdateComprobanteDePago(data,ref Id, IdVariable, trx, replicacion );
			}


		}

		

		
		public static void UpdateComprobanteDePago(tsa_ComprobantesExDataset data,ref string IdComprobante, string IdVariable, SqlTransaction trx, SentenciasReplicacion replicacion )
		{
			
			tsa_Comprobantes.Update( data.Tables["tsa_Comprobantes"], trx, replicacion);
			IdComprobante = (string)data.tsa_Comprobantes.Rows[0]["IdComprobante"];
			sy_Variables.Update(IdVariable, (string)data.Tables["tsa_Comprobantes"].Rows[0]["Numero"],trx);
			tsa_ComprobanteDetalleDeuda.Update( data.Tables["tsa_ComprobanteDetalleDeuda"],trx, replicacion);
			tfi_Valores.Update( data.Tables["tfi_Valores"], trx , replicacion);
			tfi_ValoresDatosAuxiliares.Update(data.Tables["tfi_ValoresDatosAuxiliares"], trx, replicacion );
			tsa_ComprobanteDetalleDePagos.Update( data.Tables["tsa_ComprobanteDetalleDePagos"], trx);
			tsa_AplicacionPagos.Update(data.Tables["tsa_AplicacionPagos"],trx);
		}

		public static void UpdateTipoDeComprobanteDeVenta(tsa_ComprobantesExDataset data, string IdTransaction, SentenciasReplicacion replicacion )
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			tsa_Comprobantes.Update( data.Tables["tsa_Comprobantes"], trx, replicacion);
			tsa_ComprobantesDet.Update(data.Tables["tsa_ComprobantesDet"], trx, replicacion);
			tsa_ComprobanteDetalleImpuestos.Update(data.Tables["tsa_ComprobanteDetalleImpuestos"], trx, replicacion);
		}

		public static System.Data.DataSet ComprobantesPendientes( string tiposComprobantes, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesPendientes", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (tiposComprobantes =="") cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = tiposComprobantes;
		
				
				cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
				if(IdCuenta=="")cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
				
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="")cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}

		/*public static System.Data.DataTable ComprobantesPendientesDet( string IdTipoDeComprobante, string IdComprobante, int Ordinal, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa)
		{			
			try
			{
				System.Data.DataTable data = new DataTable();
				SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesPendientesDet", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (IdTipoDeComprobante =="") cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;

				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar));
				if(IdComprobante =="")cmd.Parameters[ "@IdComprobante"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;

				cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ));
				cmd.Parameters[ "@Ordinal"].Value = Ordinal;

				cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
				if(IdCuenta=="")cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="")cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientesDet" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}*/

		public static System.Data.DataTable ComprobantesPendientesDet( string IdComprobante, long Ordinal)
		{			
			try
			{
				System.Data.DataTable data = new DataTable();
				SqlCommand cmd = new SqlCommand( "Pr_tsa_ComprobantesPendientesDet", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				/*cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
				if (IdTipoDeComprobante =="") cmd.Parameters[ "@IdTipoDeComprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobante;*/

				cmd.CommandTimeout =  Variables.GetValueInt("Sistema.Timeout.Pr_tsa_ComprobantesPendientesDet");

				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar));
				if(IdComprobante =="")cmd.Parameters[ "@IdComprobante"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;

				cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ));
				cmd.Parameters[ "@Ordinal"].Value = Ordinal;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
				cmd.Parameters[ "@IdProducto"].Value = System.DBNull.Value;

				/*cmd.Parameters.Add( new SqlParameter( "@IdCuenta", SqlDbType.VarChar ) );
				if(IdCuenta=="")cmd.Parameters[ "@IdCuenta" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdCuenta" ].Value = IdCuenta;
			
				cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ));
				if (FechaDesde.Equals(DateTime.MinValue))cmd.Parameters[ "@FechaDesde"].Value =System.DBNull.Value;
				else
				{
					DateTime d = new DateTime(FechaDesde.Year,FechaDesde.Month,FechaDesde.Day,0,0,0,0);
					cmd.Parameters[ "@FechaDesde"].Value = d;
				}

				cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ));
				if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters[ "@FechaHasta"].Value = System.DBNull.Value;
				else
				{
					DateTime h = new DateTime(FechaHasta.Year,FechaHasta.Month,FechaHasta.Day,23,59,0,0);
					cmd.Parameters[ "@FechaHasta"].Value = h;
				}

				cmd.Parameters.Add( new SqlParameter( "@IdResponsable", SqlDbType.VarChar));
				if(IdResponsable =="")cmd.Parameters[ "@IdResponsable"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdResponsable"].Value = IdResponsable;

				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdSucursal"].Value = IdSucursal;

				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ));
				cmd.Parameters[ "@IdEmpresa"].Value = IdEmpresa;*/
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientesDet" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}


		
		#region Workflow


		public static System.Data.DataTable ComprobantesPendientesDet( string TiposComprobantesDestino,string TiposComprobantesDestinoExcluidos, string IdComprobante, long Ordinal)
		{			
			try
			{
				System.Data.DataTable data = new DataTable();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesPendientesDet", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;


				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar));
				if(TiposComprobantesDestino =="")cmd.Parameters[ "@TiposComprobantesDestino"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino"].Value = TiposComprobantesDestino;


				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar));
				if(IdComprobante =="")cmd.Parameters[ "@IdComprobante"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;

				cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ));
				cmd.Parameters[ "@Ordinal"].Value = Ordinal;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
				cmd.Parameters[ "@IdProducto"].Value = System.DBNull.Value;

				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestinoExcluidos", SqlDbType.VarChar));
				if(TiposComprobantesDestinoExcluidos =="")cmd.Parameters[ "@TiposComprobantesDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestinoExcluidos"].Value = TiposComprobantesDestinoExcluidos;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientesDet" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}

		public static System.Data.DataTable ComprobantesDet( string TiposComprobantesDestino,string TiposComprobantesDestinoExcluidos, string IdComprobante, long Ordinal)
		{			
			try
			{
				System.Data.DataTable data = new DataTable();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesDet", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;


				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar));
				if(TiposComprobantesDestino =="")cmd.Parameters[ "@TiposComprobantesDestino"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino"].Value = TiposComprobantesDestino;


				cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar));
				if(IdComprobante =="")cmd.Parameters[ "@IdComprobante"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@IdComprobante"].Value = IdComprobante;

				cmd.Parameters.Add( new SqlParameter( "@Ordinal", SqlDbType.BigInt ));
				cmd.Parameters[ "@Ordinal"].Value = Ordinal;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ));
				cmd.Parameters[ "@IdProducto"].Value = System.DBNull.Value;

				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestinoExcluidos", SqlDbType.VarChar));
				if(TiposComprobantesDestinoExcluidos =="")cmd.Parameters[ "@TiposComprobantesDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestinoExcluidos"].Value = TiposComprobantesDestinoExcluidos;
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientesDet" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data;
			}
			catch(Exception e)
			{
				return null;
			}
		}

		public static void Update( tsa_ComprobantesExDataset data , string IdVariable, SentenciasReplicacion replicacion, string IdTransaction)
		{
			try
			{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update( data , IdVariable, trx , replicacion);
			}
			catch (Exception e)
			{
				
				data.tsa_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
				throw e;
			}
			

		}
		public static void Update( tsa_ComprobantesExDataset data , string IdVariable, SqlTransaction trx , SentenciasReplicacion replicacion)
		{
						
			tsa_Comprobantes.Update( data.Tables["tsa_Comprobantes"], trx, replicacion);	
			sy_Variables.Update(IdVariable,(string) data.Tables["tsa_Comprobantes"].Rows[0]["Numero"],trx);				
			tsa_ComprobanteDetalleDeuda.Update( data.Tables["tsa_ComprobanteDetalleDeuda"],trx, replicacion); 				
			tsa_ComprobantesDet.Update( data.Tables["tsa_ComprobantesDet"], trx, replicacion);							
			tlg_MovimientosDeStock.Update(data.Tables["tlg_MovimientosDeStock"], trx, replicacion);				
			tsa_ComprobanteDetalleImpuestos.Update( data.Tables["tsa_ComprobanteDetalleImpuestos"], trx,replicacion);
			tsa_ComprobanteValoresVarAux.Update( data.Tables["tsa_ComprobanteValoresVarAux"], trx, replicacion);
			tsa_ComprobanteDetalleDescripcionAdicional.Update( data.Tables["tsa_ComprobanteDetalleDescripcionAdicional"], trx, replicacion );
			tsa_ComprobantesRelacionOrigenDestino.Update( data.Tables["tsa_ComprobantesRelacionOrigenDestino"], trx, replicacion, (string)data.Tables["tsa_Comprobantes"].Rows[0]["IdComprobante"] );
			tsa_ComprobantesOrdenReparacion.Update(data.Tables["tsa_ComprobantesOrdenReparacion"],trx);
			tsa_ComprobanteDetalleOrdenReparacion.Update(data.Tables["tsa_ComprobanteDetalleOrdenReparacion"],trx);
		}

		public static void UpdateComprobanteDePago( tsa_ComprobantesExDataset data , string IdVariable,string Numero, SentenciasReplicacion replicacion, string IdTransaction,
			ArrayList desimputacionDetalleDeudaDataSets,ArrayList desimputacionAplicacionPagoDataSets,ArrayList cancelacionesDePagoDataSets)
		{
			try
			{
				SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
				UpdateComprobanteDePago( data , IdVariable,Numero, trx , replicacion);
				foreach(DataSet dataDesimputacionDataSet in desimputacionDetalleDeudaDataSets)
				{
					mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update(dataDesimputacionDataSet.Tables["tsa_ComprobanteDetalleDeuda"],trx);
				}
				foreach(DataSet dataDesimputacionAplicacionPago in desimputacionAplicacionPagoDataSets )
				{
					mz.erp.dataaccess.tsa_AplicacionPagos.Update( dataDesimputacionAplicacionPago.Tables["tsa_AplicacionPagos"], trx );
				}
				foreach(DataSet dataCancelaciones in cancelacionesDePagoDataSets)
				{
					UpdateComprobanteDePago( dataCancelaciones , string.Empty,string.Empty, trx , replicacion);
				}

			}
			catch (Exception e)
			{
				
				data.tsa_Comprobantes.Rows[0].SetColumnError("IdComprobante","No se ha podido realizar la grabación por un error en los datos");
				throw e;
			}
			

		}


		public static void UpdateComprobanteDePago(DataSet data, string IdVariable,string Numero, SqlTransaction trx, SentenciasReplicacion replicacion)
		{
			
			tsa_Comprobantes.Update( data.Tables["tsa_Comprobantes"], trx, replicacion);
			if(IdVariable != null && !IdVariable.Equals(string.Empty) && !Numero.Equals(string.Empty))
				sy_Variables.Update(IdVariable, Numero,trx);
			tsa_ComprobanteDetalleDeuda.Update( data.Tables["tsa_ComprobanteDetalleDeuda"],trx, replicacion);
			tfi_Valores.Update( data.Tables["tfi_Valores"], trx, replicacion );
			tfi_ValoresDatosAuxiliares.Update( data.Tables["tfi_ValoresDatosAuxiliares"], trx , replicacion);
			tsa_ComprobanteDetalleDePagos.Update( data.Tables["tsa_ComprobanteDetalleDePagos"], trx);
			tsa_AplicacionPagos.Update(data.Tables["tsa_AplicacionPagos"],trx);
		}

		public static void UpdateDesimputacion(DataSet  dataDetalleDeuda, DataSet dataAplicacionPago,SqlTransaction trx)
		{
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update(dataDetalleDeuda.Tables["tsa_ComprobanteDetalleDeuda"],trx);
			mz.erp.dataaccess.tsa_AplicacionPagos.Update( dataAplicacionPago.Tables["tsa_AplicacionPagos"], trx );
		}



		#endregion





	}
}
