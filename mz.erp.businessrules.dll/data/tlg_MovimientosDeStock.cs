namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_MovimientosDeStock : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_MovimientosDeStock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_MovimientosDeStock
		/// </summary>
		public static tlg_MovimientosDeStockDataset GetList()
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStock.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_MovimientosDeStock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_MovimientosDeStockDataset GetList( string IdMovimientoDeStock, string IdProducto, decimal Cantidad, string IdDeposito, string IdSeccion, string IdEstadoDeStock, string IdTipoDeAjuste, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStock.GetList( IdProducto, Cantidad, IdDeposito, IdSeccion, IdEstadoDeStock, IdTipoDeAjuste, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tlg_MovimientosDeStockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_MovimientosDeStock.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_MovimientosDeStock que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow GetByPk( string IdMovimientoDeStock )
		{
			tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row = mz.erp.dataaccess.tlg_MovimientosDeStock.GetByPk( IdMovimientoDeStock  );
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
		/// Obtiene un registro de la tabla tlg_MovimientosDeStock que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow GetByPk( object IdMovimientoDeStock )
		{
			return GetByPk( ( string )IdMovimientoDeStock );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_MovimientosDeStockRow.
		/// </summary>
		public static tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow SetRowDefaultValues( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row )
		{
			row.IdMovimientoDeStock = Util.NewStringId(); 
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.IdDeposito = string.Empty;
			row.IdSeccion = string.Empty;
			row.IdEstadoDeStock = string.Empty;
			row.IdTipoDeAjuste = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockRow a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_MovimientosDeStock.Rows.Count > 0, "La tabla dataSet.tlg_MovimientosDeStockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_MovimientosDeStockRow.
		/// </summary>
		public static bool RowIsValid( tlg_MovimientosDeStockDataset.tlg_MovimientosDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoDeStockIsValid( row.IdMovimientoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdDepositoIsValid( row.IdDeposito, out mensaje) )
			{ 
				row.SetColumnError( "IdDeposito" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSeccionIsValid( row.IdSeccion, out mensaje) )
			{ 
				row.SetColumnError( "IdSeccion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoDeStockIsValid( row.IdEstadoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeAjusteIsValid( row.IdTipoDeAjuste, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeAjuste" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
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
			;*/
			
			return isValid;
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad)
		{
			string mensaje;
			return CantidadIsValid( Cantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdDeposito.
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDeposito. Metodo Sobrecargado
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito)
		{
			string mensaje;
			return IdDepositoIsValid( IdDeposito, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSeccion.
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSeccion. Metodo Sobrecargado
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion)
		{
			string mensaje;
			return IdSeccionIsValid( IdSeccion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEstadoDeStock.
		/// </summary>
		public static bool IdEstadoDeStockIsValid( string IdEstadoDeStock , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstadoDeStock. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoDeStockIsValid( string IdEstadoDeStock)
		{
			string mensaje;
			return IdEstadoDeStockIsValid( IdEstadoDeStock, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeAjuste.
		/// </summary>
		public static bool IdTipoDeAjusteIsValid( string IdTipoDeAjuste , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeAjuste. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeAjusteIsValid( string IdTipoDeAjuste)
		{
			string mensaje;
			return IdTipoDeAjusteIsValid( IdTipoDeAjuste, out mensaje );
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

