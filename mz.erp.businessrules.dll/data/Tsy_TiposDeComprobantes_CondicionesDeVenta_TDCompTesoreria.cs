namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria
		/// </summary>
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset GetList()
		{
			return mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria filtrada por las condiciones de bsqueda
		/// </summary>
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset GetList( string IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria, string IdTipoDeComprobante, string IdTDCompTesoreria, string IdCondicionDeVenta)
		{
			return mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetList( IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria, IdTipoDeComprobante, IdTDCompTesoreria, IdCondicionDeVenta);
		}

		/// <summary>
		/// Crea un Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria que luego puede ser persistido en la base de datos.
		/// </summary>
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow GetByPk( string IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria )
		{
			Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row = mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.GetByPk( IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow GetByPk( object IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria )
		{
			return GetByPk( ( string )IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow.
		/// </summary>
		public static Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow SetRowDefaultValues( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row )
		{
			row.IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria = Util.NewStringId(); 
			row.IdTipoDeComprobante = string.Empty;
			row.IdTDCompTesoreria = string.Empty;
			row.IdCondicionDeVenta = string.Empty;
			row.MetodoDeAsignacion = string.Empty;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdProceso = 0;
			row.IdTarea = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow a la base de datos.
		/// </summary>
		public static void Update( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Update( row );
		}

		/// <summary>
		/// Envia los cambios del Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset a la base de datos.
		/// </summary>
		public static void Update( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Rows.Count > 0, "La tabla dataSet.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable a la base de datos.
		/// </summary>
		public static void Update( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreria.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow.
		/// </summary>
		public static bool RowIsValid( Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaDataset.Tsy_TiposDeComprobantes_CondicionesDeVenta_TDCompTesoreriaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreriaIsValid( row.IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCondicionDeVentaIsValid( row.IdCondicionDeVenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicionDeVenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !MetodoDeAsignacionIsValid( row.MetodoDeAsignacion, out mensaje) )
			{ 
				row.SetColumnError( "MetodoDeAsignacion" , mensaje);
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
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProcesoIsValid( row.IdProceso, out mensaje) )
			{ 
				row.SetColumnError( "IdProceso" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria.
		/// </summary>
		public static bool IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreriaIsValid( string IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreriaIsValid( string IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria)
		{
			string mensaje;
			return IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreriaIsValid( IdTiposDeComprobantesCondicionesDeVentaTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante.
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante)
		{
			string mensaje;
			return IdTipoDeComprobanteIsValid( IdTipoDeComprobante, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria)
		{
			string mensaje;
			return IdTDCompTesoreriaIsValid( IdTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta.
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( string IdCondicionDeVenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( string IdCondicionDeVenta)
		{
			string mensaje;
			return IdCondicionDeVentaIsValid( IdCondicionDeVenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MetodoDeAsignacion.
		/// </summary>
		public static bool MetodoDeAsignacionIsValid( string MetodoDeAsignacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MetodoDeAsignacion. Metodo Sobrecargado
		/// </summary>
		public static bool MetodoDeAsignacionIsValid( string MetodoDeAsignacion)
		{
			string mensaje;
			return MetodoDeAsignacionIsValid( MetodoDeAsignacion, out mensaje );
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
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
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
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProceso.
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProceso. Metodo Sobrecargado
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso)
		{
			string mensaje;
			return IdProcesoIsValid( IdProceso, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTarea.
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTarea. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea)
		{
			string mensaje;
			return IdTareaIsValid( IdTarea, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

