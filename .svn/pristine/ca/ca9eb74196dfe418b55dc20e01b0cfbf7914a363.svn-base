namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_MovimientosDeStockAjustes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_MovimientosDeStockAjustes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_MovimientosDeStockAjustes
		/// </summary>
		public static tlg_MovimientosDeStockAjustesDataset GetList()
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_MovimientosDeStockAjustes filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tlg_MovimientosDeStockAjustesDataset GetList(  )
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.GetList(  );
		}*/

		/// <summary>
		/// Crea un tlg_MovimientosDeStockAjustesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_MovimientosDeStockAjustes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow GetByPk( string IdMovimientoDeStockAjustesDatosAuxiliares, string IdMovimientoDeStock )
		{
			tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow row = mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.GetByPk( IdMovimientoDeStockAjustesDatosAuxiliares, IdMovimientoDeStock  );
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
		/// Obtiene un registro de la tabla tlg_MovimientosDeStockAjustes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow GetByPk( object IdMovimientoDeStockAjustesDatosAuxiliares, object IdMovimientoDeStock)
		{
			return GetByPk( ( string )IdMovimientoDeStockAjustesDatosAuxiliares, ( string )IdMovimientoDeStock );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_MovimientosDeStockAjustesRow.
		/// </summary>
		public static tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow SetRowDefaultValues( tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow row )
		{
			row.IdMovimientoDeStockAjustesDatosAuxiliares = Util.NewStringId(); 
			row.IdMovimientoDeStock = Util.NewStringId(); 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockAjustesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockAjustesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockAjustesRow a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockAjustesDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockAjustesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_MovimientosDeStockAjustes.Rows.Count > 0, "La tabla dataSet.tlg_MovimientosDeStockAjustesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockAjustes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_MovimientosDeStockAjustesRow.
		/// </summary>
		public static bool RowIsValid( tlg_MovimientosDeStockAjustesDataset.tlg_MovimientosDeStockAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoDeStockAjustesDatosAuxiliaresIsValid( row.IdMovimientoDeStockAjustesDatosAuxiliares, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStockAjustesDatosAuxiliares" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMovimientoDeStockIsValid( row.IdMovimientoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStock" , mensaje);
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStockAjustesDatosAuxiliares.
		/// </summary>
		public static bool IdMovimientoDeStockAjustesDatosAuxiliaresIsValid( string IdMovimientoDeStockAjustesDatosAuxiliares , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStockAjustesDatosAuxiliares. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeStockAjustesDatosAuxiliaresIsValid( string IdMovimientoDeStockAjustesDatosAuxiliares)
		{
			string mensaje;
			return IdMovimientoDeStockAjustesDatosAuxiliaresIsValid( IdMovimientoDeStockAjustesDatosAuxiliares, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStock.
		/// </summary>
		public static bool IdMovimientoDeStockIsValid( string IdMovimientoDeStock , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStock. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeStockIsValid( string IdMovimientoDeStock)
		{
			string mensaje;
			return IdMovimientoDeStockIsValid( IdMovimientoDeStock, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

