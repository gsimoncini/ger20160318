namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_EstadisticaOrdenReparacion : IDisposable
	{
	
		#region Custom Members
		public static DataSet ListarDetalleTecnico (DateTime FechaDesde, DateTime FechaHasta, bool PorFechaAltaOrdenReparacion, bool PorFechaAsignacionATecnico, bool PorFechaFactura, bool PorFechaCierre, bool PorFechaCierreTecnico, string IdPersona, long IdEstadoOrdenReparacion, string IdTecnicosSelecionados)
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacion.ListarDetalleTecnico(FechaDesde, FechaHasta, PorFechaAltaOrdenReparacion, PorFechaAsignacionATecnico, PorFechaFactura, PorFechaCierre, PorFechaCierreTecnico, IdPersona, IdEstadoOrdenReparacion, IdTecnicosSelecionados);
		}

		public static DataSet ListarOrdenesACerrar (string CodigosEstadosOrdenReparacionACerrar)
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacion.ListarOrdenesACerrar(CodigosEstadosOrdenReparacionACerrar);
		}

		public static DataSet ListarOrdenesAAbrir (string CodigosEstadosOrdenReparacionAAbrir)
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacion.ListarOrdenesAAbrir(CodigosEstadosOrdenReparacionAAbrir);
		}

		#endregion
		
		public st_EstadisticaOrdenReparacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_EstadisticaOrdenReparacion
		/// </summary>
		public static st_EstadisticaOrdenReparacionDataset GetList()
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_EstadisticaOrdenReparacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_EstadisticaOrdenReparacionDataset GetList( long IdOrdenReparacion, bool Cerrado, string NumeroRemito, decimal TiempoDeEspera, DateTime FechaCierre )
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacion.GetList( IdOrdenReparacion, Cerrado, NumeroRemito, TiempoDeEspera, FechaCierre );
		}

		/// <summary>
		/// Crea un st_EstadisticaOrdenReparacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_EstadisticaOrdenReparacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow GetByPk( long IdOrdenReparacion )
		{
			st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow row = mz.erp.dataaccess.st_EstadisticaOrdenReparacion.GetByPk( IdOrdenReparacion  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow GetByPk( object IdOrdenReparacion )
		{
			return GetByPk( ( long )IdOrdenReparacion );
		}

		/// <summary>
		/// Establece los valores por defecto de st_EstadisticaOrdenReparacionRow.
		/// </summary>
		public static st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow SetRowDefaultValues( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow row )
		{
			row.IdOrdenReparacion = 0; 
			row.Cerrado = false;
			row.FechaCierre = DateTime.Now;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionRow a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDataset a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_EstadisticaOrdenReparacion.Rows.Count > 0, "La tabla dataSet.st_EstadisticaOrdenReparacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionDataTable a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_EstadisticaOrdenReparacionRow.
		/// </summary>
		public static bool RowIsValid( st_EstadisticaOrdenReparacionDataset.st_EstadisticaOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdOrdenReparacionIsValid( row.IdOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !CerradoIsValid( row.Cerrado, out mensaje) )
			{ 
				row.SetColumnError( "Cerrado" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCierreIsValid( row.FechaCierre, out mensaje) )
			{ 
				row.SetColumnError( "FechaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparacion.
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion)
		{
			string mensaje;
			return IdOrdenReparacionIsValid( IdOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cerrado.
		/// </summary>
		public static bool CerradoIsValid( bool Cerrado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cerrado. Metodo Sobrecargado
		/// </summary>
		public static bool CerradoIsValid( bool Cerrado)
		{
			string mensaje;
			return CerradoIsValid( Cerrado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCierre.
		/// </summary>
		public static bool FechaCierreIsValid( DateTime FechaCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCierre. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCierreIsValid( DateTime FechaCierre)
		{
			string mensaje;
			return FechaCierreIsValid( FechaCierre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

