using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Text;
    
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes;
using mz.erp.commontypes.data;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de Workflow.
	/// </summary>
	public class Workflow
	{
		public Workflow()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public  static DataSet GetDependentTasks(long IdTask)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "TableIdTasks" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Tareas_Dependencias", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idCurrentTarea", SqlDbType.BigInt ) );
			if(IdTask.Equals(long.MinValue))
				cmd.Parameters[ "@idCurrentTarea" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idCurrentTarea" ].Value = IdTask;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;

		}

		public static bool IsNextTask(long IdCurrentTask, long IdNextTask)
		{
			
			SqlCommand cmd = new SqlCommand( "Pr_twf_Tareas_IsNextTarea", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idCurrentTarea", SqlDbType.BigInt ) );
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@idCurrentTarea" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idCurrentTarea" ].Value = IdCurrentTask;
			cmd.Parameters.Add( new SqlParameter( "@idNextTarea", SqlDbType.BigInt ) );
			if(IdNextTask.Equals(long.MinValue))
				cmd.Parameters[ "@idNextTarea" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idNextTarea" ].Value = IdNextTask;
			SqlParameter outParameter = new SqlParameter("@Respuesta", SqlDbType.Bit);
			outParameter.Direction = System.Data.ParameterDirection.ReturnValue;
			cmd.Parameters.Add(outParameter);
			bool result = Convert.ToBoolean(cmd.ExecuteScalar());
			return result;

		}
		public static DataSet GetNextTasks(long IdCurrentTask)
		{
			return GetNextTasks( IdCurrentTask, long.MinValue );
		}
		public static DataSet GetNextTasks(long IdCurrentTask, long IdCurrentProcess)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Tareas_Next", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idTareaCurrent", SqlDbType.BigInt ) );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idProcessCurrent", SqlDbType.BigInt ) );
			
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@idTareaCurrent" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idTareaCurrent" ].Value = IdCurrentTask;
			
			if(IdCurrentProcess.Equals(long.MinValue))
				cmd.Parameters[ "@idProcessCurrent" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idProcessCurrent" ].Value = IdCurrentProcess;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		}

		public static DataSet GetPreviousTasks(long IdCurrentTask)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Tareas_Previous", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idTareaCurrent", SqlDbType.BigInt ) );
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@idTareaCurrent" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idTareaCurrent" ].Value = IdCurrentTask;

			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		}

		public static DataSet GetDependentFlows(long IdCurrentTask, long IdNextTask)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Tareas_Previous", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idTareaCurrent", SqlDbType.BigInt ) );
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@idTareaCurrent" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idTareaCurrent" ].Value = IdCurrentTask;
			cmd.Parameters.Add( new SqlParameter( "@idNextTarea", SqlDbType.BigInt ) );
			if(IdNextTask.Equals(long.MinValue))
				cmd.Parameters[ "@idNextTarea" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idNextTarea" ].Value = IdNextTask;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		}

		public static DataSet GetComprobantesAsociados( long IdCurrentTask)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Tareas_ComprobantesAsociados", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@idCurrentTarea", SqlDbType.BigInt ) );
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@idCurrentTarea" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@idCurrentTarea" ].Value = IdCurrentTask;
			adapter.SelectCommand = cmd;
			try
			{
				adapter.Fill( data );
			}
			catch (SqlException e)
			{
				System.Diagnostics.Debug.WriteLine( e.ToString());
			}


			return data;
		}

		public static System.Data.DataSet GetProcessPrimaryTask(long IdProcess)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetProcessPrimaryTask", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdProcess", SqlDbType.BigInt ) );
			if(IdProcess.Equals(long.MinValue))
				cmd.Parameters[ "@IdProcess" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProcess" ].Value = IdProcess;

			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		}

		public static DataSet GetProcessSecondaryTasks(long IdProcess)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetProcessSecondaryTasks", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdProcess", SqlDbType.BigInt ) );
			if(IdProcess.Equals(long.MinValue))
				cmd.Parameters[ "@IdProcess" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProcess" ].Value = IdProcess;

			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		}

		public static DataSet GetPreviousTasksOfProcess(long IdCurrentTask, long IdCurrentProcess)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_PreviousTasksOfProcess", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdCurrentTask", SqlDbType.BigInt ) );
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@IdCurrentTask" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdCurrentTask" ].Value = IdCurrentTask;
			cmd.Parameters.Add( new SqlParameter( "@IdCurrentProcess", SqlDbType.BigInt ) );
			if(IdCurrentTask.Equals(long.MinValue))
				cmd.Parameters[ "@IdCurrentProcess" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdCurrentProcess" ].Value = IdCurrentProcess;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
		}

		public static DataSet GetCaminoComprobantesOrdinalBottonUp(string CurrentIdComprobante, long CurrentOrdinal, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesOrdinalBottonUp", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@CurrentOrdinal", SqlDbType.BigInt ) );
			if(CurrentOrdinal.Equals(long.MinValue))
				cmd.Parameters[ "@CurrentOrdinal" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentOrdinal" ].Value = CurrentOrdinal;
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}

		public static DataSet GetCaminoComprobantesBottonUp(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
			  {
				  DataSet data = new DataSet();
				  SqlDataAdapter adapter = new SqlDataAdapter();
				  adapter.TableMappings.Add( "Table", "Table" );
				  SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesBottonUp", dbhelper.Connection.GetConnection() );
				  cmd.CommandType = CommandType.StoredProcedure;
				  cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
				  if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
					  cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
				  else
					  cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
				 
				  cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
				  if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
					  cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
				  else
					  cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
				  adapter.SelectCommand = cmd;
				  adapter.Fill( data );
				  return data;
			
			  }


		public static DataSet GetComprobantesBottonUp(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetComprobantesSearchBottonUp", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
				 
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}

		public static DataSet GetComprobantesTopDown(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetComprobantesSearchTopDown", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}

		public static DataSet GetCaminoComprobantesTopDown(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesTopDown", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}



	public static System.Data.DataTable ComprobantesConProductosPendientesDeNumeroDeSerie( DateTime FechaDesde, DateTime FechaHasta, string TiposDeComprobantesValidos, string EstadosDeStockValidos)
	{			
		try
		{
			System.Data.DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_tpu_Comprobantes_GetComprobantesPendientesDeNumeroDeSerie", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
		
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
			cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobantes", SqlDbType.VarChar ));
			cmd.Parameters[ "@TiposDeComprobantes"].Value = TiposDeComprobantesValidos;

			cmd.Parameters.Add( new SqlParameter( "@EstadosDeStock", SqlDbType.VarChar ));
			cmd.Parameters[ "@EstadosDeStock"].Value = EstadosDeStockValidos;
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			adapter.SelectCommand = cmd;
			adapter.Fill( data);


			return data.Tables[0];
		}
		catch(Exception e){return null;}		
	}

		public static System.Data.DataTable ReparacionesPendientes(string IdOrdenReparacion,  string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string EstadoOrdenReparacion, bool EsEquipoNuevo)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ReparacionesPendientes", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
				if(IdOrdenReparacion=="")cmd.Parameters[ "@IdOrdenReparacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
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
				cmd.Parameters.Add( new SqlParameter( "@EstadoOrdenReparacion", SqlDbType.VarChar ) );
				if(EstadoOrdenReparacion=="")cmd.Parameters[ "@EstadoOrdenReparacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@EstadoOrdenReparacion" ].Value = EstadoOrdenReparacion;
				cmd.Parameters.Add( new SqlParameter( "@EsEquipoNuevo", SqlDbType.Bit ));				
				cmd.Parameters[ "@EsEquipoNuevo" ].Value = EsEquipoNuevo;


				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data.Tables[0];
			}
			catch(Exception e){return null;}		
		}


		public static System.Data.DataTable ReparacionesAjustarStockDevolucion(string IdOrdenReparacion,  string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string EstadoOrdenReparacion)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ReparacionesAjustarStockDevolucion", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
				if(IdOrdenReparacion=="")cmd.Parameters[ "@IdOrdenReparacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
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
				cmd.Parameters.Add( new SqlParameter( "@EstadoOrdenReparacion", SqlDbType.VarChar ) );
				if(EstadoOrdenReparacion=="")cmd.Parameters[ "@EstadoOrdenReparacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@EstadoOrdenReparacion" ].Value = EstadoOrdenReparacion;
			



				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data.Tables[0];
			}
			catch(Exception e){return null;}		
		}


		public static System.Data.DataTable ReparacionesAjustarStockTransferencia(string IdOrdenReparacion,  string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string EstadoOrdenReparacion)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ReparacionesAjustarStockTransferencia", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
		
				cmd.Parameters.Add( new SqlParameter( "@IdOrdenReparacion", SqlDbType.BigInt ) );
				if(IdOrdenReparacion=="")cmd.Parameters[ "@IdOrdenReparacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdOrdenReparacion" ].Value = IdOrdenReparacion;
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
				cmd.Parameters.Add( new SqlParameter( "@EstadoOrdenReparacion", SqlDbType.VarChar ) );
				if(EstadoOrdenReparacion=="")cmd.Parameters[ "@EstadoOrdenReparacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@EstadoOrdenReparacion" ].Value = EstadoOrdenReparacion;
			



				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data.Tables[0];
			}
			catch(Exception e){return null;}		
		}

		public static System.Data.DataSet ComprobantesPendientesNumeroDeSerieWFEx( string tiposComprobantesOrigen,string tiposComprobantesDestino, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesNumeroDeSerie", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="") cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				
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
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(tiposDeComprobanteDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;
			
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}

		public static System.Data.DataSet ComprobantesPendientesNumeroDeSerieWF( string tiposComprobantesOrigen,string tiposComprobantesDestino, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesPendientesNumeroDeSerie", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="") cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				
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
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(tiposDeComprobanteDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;
			
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}

		public static System.Data.DataSet Comprobantes( string tiposComprobantesOrigen,string tiposComprobantesDestino, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_Comprobantes", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="") cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				
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
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(tiposDeComprobanteDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;
			
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}



		public static System.Data.DataSet ComprobantesPendientes( string tiposComprobantesOrigen,string tiposComprobantesDestino, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesPendientes", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="") cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				
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
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(tiposDeComprobanteDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;
			
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}


		public static System.Data.DataSet ComprobantesEntregas( string tiposComprobantesOrigen,string tiposComprobantesDestino, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesEntregas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="") cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				
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
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(tiposDeComprobanteDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;
			
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}



		public static System.Data.DataSet ComprobantesPendientesEntregas( string tiposComprobantesOrigen,string tiposComprobantesDestino, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, string tiposDeComprobanteDestinoExcluidos, bool VerHTML)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ComprobantesPendientesEntregas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesDestino", SqlDbType.VarChar ) );
				if (tiposComprobantesDestino =="") cmd.Parameters[ "@TiposComprobantesDestino" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesDestino" ].Value = tiposComprobantesDestino;
				
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
			
				cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobanteDestinoExcluidos", SqlDbType.VarChar));
				if(tiposDeComprobanteDestinoExcluidos =="")cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposDeComprobanteDestinoExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;
			
				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}



		public static System.Data.DataSet ListarComprobantes( string tiposComprobantesOrigen,string comprobante, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, string ListaTiposDeComprobantesExcluidos)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantes", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@Comprobante", SqlDbType.VarChar ) );
				if (comprobante =="") cmd.Parameters[ "@Comprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Comprobante" ].Value = comprobante;
				
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

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesExcluidos", SqlDbType.VarChar ) );
				if (ListaTiposDeComprobantesExcluidos =="") cmd.Parameters[ "@TiposComprobantesExcluidos" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesExcluidos" ].Value = ListaTiposDeComprobantesExcluidos;

				cmd.CommandTimeout = 60;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}


		public static System.Data.DataSet ListarComprobantesEntregas( string tiposComprobantesOrigen,string comprobante, string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, string IdResponsable, long IdSucursal, long IdEmpresa, bool VerHTML, bool SoloPendientes, string ListaTiposDeComprobantesExcluidos, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{			
			try
			{
				System.Data.DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_ListarComprobantesEntregas", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesOrigen", SqlDbType.VarChar ) );
				if (tiposComprobantesOrigen =="") cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesOrigen" ].Value = tiposComprobantesOrigen;
				
				cmd.Parameters.Add( new SqlParameter( "@Comprobante", SqlDbType.VarChar ) );
				if (comprobante =="") cmd.Parameters[ "@Comprobante" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Comprobante" ].Value = comprobante;
				
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

				cmd.Parameters.Add( new SqlParameter( "@VerHTML", SqlDbType.Bit ));
				cmd.Parameters[ "@VerHTML"].Value = VerHTML;
				cmd.Parameters.Add( new SqlParameter( "@SoloPendientes", SqlDbType.Bit ));
				cmd.Parameters[ "@SoloPendientes"].Value = SoloPendientes;

				cmd.Parameters.Add( new SqlParameter( "@TiposComprobantesExcluidos", SqlDbType.VarChar ) );
				if (ListaTiposDeComprobantesExcluidos =="") cmd.Parameters[ "@TiposComprobantesExcluidos" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@TiposComprobantesExcluidos" ].Value = ListaTiposDeComprobantesExcluidos;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@IdJerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia6" ].Value = IdJerarquia6;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@IdJerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia7" ].Value = IdJerarquia7;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@IdJerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia8" ].Value = IdJerarquia8;

				cmd.CommandTimeout = 60;

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Pr_tsa_ComprobantesPendientes" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);


				return data;
			}
			catch(Exception e){return null;}
		}

		public static string GetHTMLComprobantesDeComprasPendientes(string IdComprobante)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetHTMLComprobantesDeComprasPendientes", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante != null && IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
				 
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
			
		}

		public static string GetHTMLRetenciones(long IdRetencion)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetHTMLRetenciones", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdRetencion", SqlDbType.BigInt ) );
			if(IdRetencion.Equals(long.MinValue))
				cmd.Parameters[ "@IdRetencion" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdRetencion" ].Value = IdRetencion;
				 
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
			
		}

		public static string GetCaminoJerarquiaAgrupProd(string IdNomenclatura)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetCaminoJerarquiaAgrupProd", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			if(IdNomenclatura.Equals(string.Empty))
				cmd.Parameters[ "@IdNomenclatura" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
				 
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
		}


		public static string GetCaminoJerarquiaAgrupCuentas(string IdNomenclatura)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetCaminoJerarquiaAgrupCuentas", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			if(IdNomenclatura.Equals(string.Empty))
				cmd.Parameters[ "@IdNomenclatura" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
				 
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
		}


		public static string GetCaminoJerarquiaAgrupProveedores(string IdNomenclatura)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetCaminoJerarquiaAgrupProveedores", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdNomenclatura", SqlDbType.VarChar ) );
			if(IdNomenclatura.Equals(string.Empty))
				cmd.Parameters[ "@IdNomenclatura" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdNomenclatura" ].Value = IdNomenclatura;
				 
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
		}


        //German 20120301 - Tarea 0000247

        public static string GetHTMLDetalleAcopio(string IdComprobante, long Ordinal)
        {
            DataSet data = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Table");
            SqlCommand cmd = new SqlCommand("Pr_GetHTMLDetalleAcopioItem", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IdComprobante", SqlDbType.VarChar));
            cmd.Parameters["@IdComprobante"].Value = IdComprobante;

            cmd.Parameters.Add(new SqlParameter("@Ordinal", SqlDbType.BigInt));
            cmd.Parameters["@Ordinal"].Value = Ordinal;
            adapter.SelectCommand = cmd;
            adapter.Fill(data);
            if (data.Tables[0].Rows.Count > 0)
                return Convert.ToString(data.Tables[0].Rows[0][0]);
            return string.Empty;
        }
        //Fin German 20120301 - Tarea 0000247


		public static string GetHTMLComprobantes(string IdComprobante, string IdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetHTMLComprobantes", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante != null && IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
				 
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if(IdTipoDeComprobantes != null && IdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
			
		}

		public static string GetHTMLComprobantesResumido(string IdComprobante, string IdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_GetHTMLComprobantesResumido", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdComprobante", SqlDbType.VarChar ) );
			if(IdComprobante != null && IdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@IdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdComprobante" ].Value = IdComprobante;
				 
			cmd.Parameters.Add( new SqlParameter( "@IdTipoDeComprobante", SqlDbType.VarChar ) );
			if(IdTipoDeComprobantes != null && IdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdTipoDeComprobante" ].Value = IdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			if(data.Tables[0].Rows.Count > 0)
				return Convert.ToString(data.Tables[0].Rows[0][0]);
			return string.Empty;
			
		}
		public static DataSet GetCaminoComprobantesCompraOrdinalBottonUp(string CurrentIdComprobante, long CurrentOrdinal, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesCompraOrdinalBottonUp", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@CurrentOrdinal", SqlDbType.BigInt ) );
			if(CurrentOrdinal.Equals(long.MinValue))
				cmd.Parameters[ "@CurrentOrdinal" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentOrdinal" ].Value = CurrentOrdinal;
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}

		public static DataSet GetCaminoComprobantesCompraBottonUp(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesCompraBottonUp", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
				 
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}

		public static DataSet GetCaminoComprobantesCompraTopDown(string CurrentIdComprobante, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesCompraTopDown", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
			
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}


		public static DataSet GetCaminoComprobantesOrdinalTopDown(string CurrentIdComprobante, long CurrentOrdinal, string ToIdTipoDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.TableMappings.Add( "Table", "Table" );
			SqlCommand cmd = new SqlCommand( "Pr_twf_Workflow_GetCaminoComprobantesOrdinalTopDown", dbhelper.Connection.GetConnection() );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@CurrentIdComprobante", SqlDbType.VarChar ) );
			if(CurrentIdComprobante != null && CurrentIdComprobante.Equals(string.Empty))
				cmd.Parameters[ "@CurrentIdComprobante" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentIdComprobante" ].Value = CurrentIdComprobante;
			cmd.Parameters.Add( new SqlParameter( "@CurrentOrdinal", SqlDbType.BigInt ) );
			if(CurrentOrdinal.Equals(long.MinValue))
				cmd.Parameters[ "@CurrentOrdinal" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@CurrentOrdinal" ].Value = CurrentOrdinal;
			cmd.Parameters.Add( new SqlParameter( "@ToIdTipoDeComprobantes", SqlDbType.VarChar ) );
			if(ToIdTipoDeComprobantes != null && ToIdTipoDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@ToIdTipoDeComprobantes" ].Value = ToIdTipoDeComprobantes;
			adapter.SelectCommand = cmd;
			adapter.Fill( data );
			return data;
			
		}


        /* Silvina 20111212 - Tarea 0000232 */
        public static System.Data.DataSet GetListPendientesReservas(string IdCuenta, DateTime FechaDesde, DateTime FechaHasta, DateTime FechaVencimientoDesde, DateTime FechaVencimientoHasta, string IdResponsable, string tiposComprobantesOrigen, string tiposComprobantesDestino, string tiposDeComprobanteDestinoExcluidos, bool VerHTML, long IdSucursal, long IdEmpresa)
        {
            System.Data.DataSet data = new DataSet();
            SqlCommand cmd = new SqlCommand("Pr_twf_Workflow_ListarComprobantesPendientesReservas", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@TiposComprobantesOrigen", SqlDbType.VarChar));
            if (tiposComprobantesOrigen == "") cmd.Parameters["@TiposComprobantesOrigen"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@TiposComprobantesOrigen"].Value = tiposComprobantesOrigen;

            cmd.Parameters.Add(new SqlParameter("@TiposComprobantesDestino", SqlDbType.VarChar));
            if (tiposComprobantesDestino == "") cmd.Parameters["@TiposComprobantesDestino"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@TiposComprobantesDestino"].Value = tiposComprobantesDestino;

            cmd.Parameters.Add(new SqlParameter("@IdCuenta", SqlDbType.VarChar));
            if (IdCuenta == "") cmd.Parameters["@IdCuenta"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@IdCuenta"].Value = IdCuenta;

            cmd.Parameters.Add(new SqlParameter("@FechaDesde", SqlDbType.DateTime));
            if (FechaDesde.Equals(DateTime.MinValue)) cmd.Parameters["@FechaDesde"].Value = System.DBNull.Value;
            else
            {
                DateTime d = new DateTime(FechaDesde.Year, FechaDesde.Month, FechaDesde.Day, 0, 0, 0, 0);
                cmd.Parameters["@FechaDesde"].Value = d;
            }

            cmd.Parameters.Add(new SqlParameter("@FechaHasta", SqlDbType.DateTime));
            if (FechaHasta.Equals(DateTime.MinValue)) cmd.Parameters["@FechaHasta"].Value = System.DBNull.Value;
            else
            {
                DateTime h = new DateTime(FechaHasta.Year, FechaHasta.Month, FechaHasta.Day, 23, 59, 0, 0);

                cmd.Parameters["@FechaHasta"].Value = h;
            }

            cmd.Parameters.Add(new SqlParameter("@FechaVencimientoDesde", SqlDbType.DateTime));
            if (FechaVencimientoDesde.Equals(DateTime.MinValue)) cmd.Parameters["@FechaVencimientoDesde"].Value = System.DBNull.Value;
            else
            {
                DateTime d = new DateTime(FechaVencimientoDesde.Year, FechaVencimientoDesde.Month, FechaVencimientoDesde.Day, 0, 0, 0, 0);
                cmd.Parameters["@FechaVencimientoDesde"].Value = d;
            }

            cmd.Parameters.Add(new SqlParameter("@FechaVencimientoHasta", SqlDbType.DateTime));
            if (FechaVencimientoHasta.Equals(DateTime.MinValue)) cmd.Parameters["@FechaVencimientoHasta"].Value = System.DBNull.Value;
            else
            {
                DateTime h = new DateTime(FechaVencimientoHasta.Year, FechaVencimientoHasta.Month, FechaVencimientoHasta.Day, 23, 59, 59, 0);

                cmd.Parameters["@FechaVencimientoHasta"].Value = h;
            }

            cmd.Parameters.Add(new SqlParameter("@IdResponsable", SqlDbType.VarChar));
            if (IdResponsable == "") cmd.Parameters["@IdResponsable"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@IdResponsable"].Value = IdResponsable;


            cmd.Parameters.Add(new SqlParameter("@TiposComprobantesExcluidos", SqlDbType.VarChar));
            if (tiposDeComprobanteDestinoExcluidos == "") cmd.Parameters["@TiposComprobantesExcluidos"].Value = System.DBNull.Value;
            else
                cmd.Parameters["@TiposComprobantesExcluidos"].Value = tiposDeComprobanteDestinoExcluidos;

            cmd.Parameters.Add(new SqlParameter("@VerHTML", SqlDbType.Bit));
            cmd.Parameters["@VerHTML"].Value = VerHTML;

            cmd.Parameters.Add(new SqlParameter("@IdSucursal", SqlDbType.BigInt));
            cmd.Parameters["@IdSucursal"].Value = IdEmpresa;

            cmd.Parameters.Add(new SqlParameter("@IdEmpresa", SqlDbType.BigInt));
            cmd.Parameters["@IdEmpresa"].Value = IdEmpresa;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.TableMappings.Add("Table", "Pr_tsa_ComprobantesPendientes");
            adapter.SelectCommand = cmd;
            adapter.Fill(data);


            return data;
        }
        /* Fin Silvina 20111212 - Tarea 0000232 */
		

	}
}
