namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_OrdenReparacionMovimientosDeStock : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_OrdenReparacionMovimientosDeStock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_OrdenReparacionMovimientosDeStock
		/// </summary>
		public static st_OrdenReparacionMovimientosDeStockDataset GetList()
		{
			return mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_OrdenReparacionMovimientosDeStock filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_OrdenReparacionMovimientosDeStockDataset GetList( string IdOrdenReparacion, string IdMovimientoDeStock )
		{
			return mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.GetList( IdOrdenReparacion, IdMovimientoDeStock );
		}

		/// <summary>
		/// Crea un st_OrdenReparacionMovimientosDeStockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_OrdenReparacionMovimientosDeStock que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow GetByPk( string IdMovimientoDeStock, string IdOrdenReparacion )
		{
			st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow row = mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.GetByPk( IdMovimientoDeStock, IdOrdenReparacion  );
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
		/// Obtiene un registro de la tabla st_OrdenReparacionMovimientosDeStock que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow GetByPk( object IdMovimientoDeStock, object IdOrdenReparacion )
		{
			return GetByPk( ( string )IdMovimientoDeStock, ( string )IdOrdenReparacion );
		}

		/// <summary>
		/// Establece los valores por defecto de st_OrdenReparacionMovimientosDeStockRow.
		/// </summary>
		public static st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow SetRowDefaultValues( st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow row )
		{
			row.IdMovimientoDeStock = Util.NewStringId(); 
			row.IdOrdenReparacion = Util.NewLongId(); 
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdInstanciaOrdenReparacion = 0;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_OrdenReparacionMovimientosDeStockRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_OrdenReparacionMovimientosDeStockRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_OrdenReparacionMovimientosDeStockRow a la base de datos.
		/// </summary>
		public static void Update( st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_OrdenReparacionMovimientosDeStockDataset a la base de datos.
		/// </summary>
		public static void Update( st_OrdenReparacionMovimientosDeStockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_OrdenReparacionMovimientosDeStock.Rows.Count > 0, "La tabla dataSet.st_OrdenReparacionMovimientosDeStockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockDataTable a la base de datos.
		/// </summary>
		public static void Update( st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_OrdenReparacionMovimientosDeStock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_OrdenReparacionMovimientosDeStockRow.
		/// </summary>
		public static bool RowIsValid( st_OrdenReparacionMovimientosDeStockDataset.st_OrdenReparacionMovimientosDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdOrdenReparacionIsValid( row.IdOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMovimientoDeStockIsValid( row.IdMovimientoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStock" , mensaje);
				isValid=false;
			
			}
			/*			
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}*/
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
		

		public void Dispose()
		{
		}
		
	}
}

