namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_ValorizacionStock : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetFechasEntre(DateTime fechaDesde, DateTime fechaHasta)
		{
			return mz.erp.dataaccess.tfi_ValorizacionStock.GetFechasEntre(fechaDesde, fechaHasta);
		}
		
		#endregion
		
		public tfi_ValorizacionStock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_ValorizacionStock
		/// </summary>
		public static tfi_ValorizacionStockDataset GetList()
		{
			return mz.erp.dataaccess.tfi_ValorizacionStock.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_ValorizacionStock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_ValorizacionStockDataset GetList( DateTime Fecha, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock )
		{
			return mz.erp.dataaccess.tfi_ValorizacionStock.GetList( Fecha, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock );
		}

		/// <summary>
		/// Crea un tfi_ValorizacionStockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_ValorizacionStock.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_ValorizacionStock que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow GetByPk( string IdValorizacionStock )
		{
			tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow row = mz.erp.dataaccess.tfi_ValorizacionStock.GetByPk( IdValorizacionStock  );
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
		/// Obtiene un registro de la tabla tfi_ValorizacionStock que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow GetByPk( object IdValorizacionStock )
		{
			return GetByPk( ( string )IdValorizacionStock );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_ValorizacionStockRow.
		/// </summary>
		public static tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow SetRowDefaultValues( tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow row )
		{
			row.IdValorizacionStock = Util.NewStringId(); 
			row.Fecha = DateTime.Now;
			row.IdProducto = string.Empty;
			row.IdDeposito = string.Empty;
			row.IdSeccion = string.Empty;
			row.IdEstadoDeStock = string.Empty;
			row.Cantidad = 0;
			row.Costo = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValorizacionStockRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValorizacionStockRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValorizacionStockRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValorizacionStock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_ValorizacionStockDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ValorizacionStockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_ValorizacionStock.Rows.Count > 0, "La tabla dataSet.tfi_ValorizacionStockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValorizacionStock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ValorizacionStockDataset.tfi_ValorizacionStockDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ValorizacionStockDataset.tfi_ValorizacionStockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_ValorizacionStock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_ValorizacionStockRow.
		/// </summary>
		public static bool RowIsValid( tfi_ValorizacionStockDataset.tfi_ValorizacionStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdValorizacionStockIsValid( row.IdValorizacionStock, out mensaje) )
			{ 
				row.SetColumnError( "IdValorizacionStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
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
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !CostoIsValid( row.Costo, out mensaje) )
			{ 
				row.SetColumnError( "Costo" , mensaje);
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
		/// Valida el campo IdValorizacionStock.
		/// </summary>
		public static bool IdValorizacionStockIsValid( string IdValorizacionStock , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValorizacionStock. Metodo Sobrecargado
		/// </summary>
		public static bool IdValorizacionStockIsValid( string IdValorizacionStock)
		{
			string mensaje;
			return IdValorizacionStockIsValid( IdValorizacionStock, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha. Metodo Sobrecargado
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha)
		{
			string mensaje;
			return FechaIsValid( Fecha, out mensaje );
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
		/// Valida el campo Costo.
		/// </summary>
		public static bool CostoIsValid( decimal Costo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Costo. Metodo Sobrecargado
		/// </summary>
		public static bool CostoIsValid( decimal Costo)
		{
			string mensaje;
			return CostoIsValid( Costo, out mensaje );
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

