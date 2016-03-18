namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_StockSucursales : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_StockSucursales()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_StockSucursales
		/// </summary>
		public static tlg_StockSucursalesDataset GetList()
		{
			return mz.erp.dataaccess.tlg_StockSucursales.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_StockSucursales filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_StockSucursalesDataset GetList( string IdStockSucursal, long IdSucursal, long IdEmpresa, long IdSucursalD, long IdEmpresaD, string IdDeposito, string IdSeccion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, string OldIdStockSucursal )
		{
			return mz.erp.dataaccess.tlg_StockSucursales.GetList( IdStockSucursal, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD, IdDeposito, IdSeccion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, OldIdStockSucursal );
		}

		/// <summary>
		/// Crea un tlg_StockSucursalesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_StockSucursalesDataset.tlg_StockSucursalesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_StockSucursales.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_StockSucursales que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_StockSucursalesDataset.tlg_StockSucursalesRow GetByPk( string IdStockSucursal )
		{
			tlg_StockSucursalesDataset.tlg_StockSucursalesRow row = mz.erp.dataaccess.tlg_StockSucursales.GetByPk( IdStockSucursal  );
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
		/// Obtiene un registro de la tabla tlg_StockSucursales que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_StockSucursalesDataset.tlg_StockSucursalesRow GetByPk( object IdStockSucursal )
		{
			return GetByPk( ( string )IdStockSucursal );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_StockSucursalesRow.
		/// </summary>
		public static tlg_StockSucursalesDataset.tlg_StockSucursalesRow SetRowDefaultValues( tlg_StockSucursalesDataset.tlg_StockSucursalesRow row )
		{
			row.IdStockSucursal = Util.NewStringId(); 
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursalD = 0;
			row.IdEmpresaD = 0;
			row.IdDeposito = string.Empty;
			row.IdSeccion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.OldIdStockSucursal = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockSucursalesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_StockSucursalesDataset.tlg_StockSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockSucursalesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_StockSucursalesDataset.tlg_StockSucursalesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockSucursalesRow a la base de datos.
		/// </summary>
		public static void Update( tlg_StockSucursalesDataset.tlg_StockSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_StockSucursales.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_StockSucursalesDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_StockSucursalesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_StockSucursales.Rows.Count > 0, "La tabla dataSet.tlg_StockSucursalesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_StockSucursales.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockSucursalesDataset.tlg_StockSucursalesDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_StockSucursalesDataset.tlg_StockSucursalesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_StockSucursales.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_StockSucursalesRow.
		/// </summary>
		public static bool RowIsValid( tlg_StockSucursalesDataset.tlg_StockSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdStockSucursalIsValid( row.IdStockSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdStockSucursal" , mensaje);
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
						
			if ( !IdSucursalDIsValid( row.IdSucursalD, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursalD" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaDIsValid( row.IdEmpresaD, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresaD" , mensaje);
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
						
			if ( !OldIdStockSucursalIsValid( row.OldIdStockSucursal, out mensaje) )
			{ 
				row.SetColumnError( "OldIdStockSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdStockSucursal.
		/// </summary>
		public static bool IdStockSucursalIsValid( string IdStockSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdStockSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdStockSucursalIsValid( string IdStockSucursal)
		{
			string mensaje;
			return IdStockSucursalIsValid( IdStockSucursal, out mensaje );
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
		
		/// <summary>
		/// Valida el campo IdSucursalD.
		/// </summary>
		public static bool IdSucursalDIsValid( long IdSucursalD , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursalD. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalDIsValid( long IdSucursalD)
		{
			string mensaje;
			return IdSucursalDIsValid( IdSucursalD, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresaD.
		/// </summary>
		public static bool IdEmpresaDIsValid( long IdEmpresaD , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresaD. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaDIsValid( long IdEmpresaD)
		{
			string mensaje;
			return IdEmpresaDIsValid( IdEmpresaD, out mensaje );
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
		/// Valida el campo OldIdStockSucursal.
		/// </summary>
		public static bool OldIdStockSucursalIsValid( string OldIdStockSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OldIdStockSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool OldIdStockSucursalIsValid( string OldIdStockSucursal)
		{
			string mensaje;
			return OldIdStockSucursalIsValid( OldIdStockSucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

