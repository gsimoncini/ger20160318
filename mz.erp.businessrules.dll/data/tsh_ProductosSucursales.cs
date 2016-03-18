namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_ProductosSucursales : IDisposable
	{
	
		#region Custom Members
		
		public static tsh_ProductosSucursalesDataset GetList(string IdProducto, long IdSucursal)
		{
			return mz.erp.dataaccess.tsh_ProductosSucursales.GetList(IdProducto, IdSucursal);
		}
		
		
		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosSucursalesRow.
		/// </summary>
		public static System.Data.DataRow SetRowDefaultValues( System.Data.DataRow row)
		{
			return SetRowDefaultValues( row, Util.NewStringId(), Security.IdEmpresa, Security.IdSucursal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosSucursalesRow.
		/// </summary>
		public static System.Data.DataRow SetRowDefaultValues( System.Data.DataRow row, string IdProducto, long IdEmpresa, long IdSucursal )
		{
			row["IdProducto"] = IdProducto; 
			row["IdSucursal"] = IdSucursal; 
			row["IdEmpresa"] = IdEmpresa; 
			row["IncrementoDeCosto"] = 0;
			row["MAC"] = 0;
			row["PrecioDeVentaNeto"] = 0;
			row["MaxDescuento"] = 0;
			row["PrecioDeVentaBruto"] = 0;
			row["StockReservado"] = 0;
			row["StockConfirmado"] = 0;
			row["StockDisponible"] = 0;
			row["StockFisico"] = 0;
			row["StockMinimo"] = 0;
			row["StockMaximo"] = 0;
			row["Activo"] = false;
			row["Bloqueado"] = false;
			row["FechaCreacion"] = DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			row["FechaUltimaModificacion"] = DateTime.Now;
			row["PrecioFinalEstimado"] = 0;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["IdReservado"] = 0;
			row["RowId"] = Guid.Empty;

			return row;
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosSucursalesRow.
		/// </summary>
		public static tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow SetRowDefaultValues( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row )
		{
			return (tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow)SetRowDefaultValues((System.Data.DataRow)row, Util.NewStringId(), Security.IdEmpresa, Security.IdSucursal );
		}

		#endregion
		
		public tsh_ProductosSucursales()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosSucursales
		/// </summary>
		public static tsh_ProductosSucursalesDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosSucursales.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_ProductosSucursales filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_ProductosSucursalesDataset GetList( string IdProducto, long IdSucursal, bool Activo )
		{
			
			return mz.erp.dataaccess.tsh_ProductosSucursales.GetList( IdProducto, IdSucursal, Activo );
		}

		/// <summary>
		/// Crea un tsh_ProductosSucursalesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosSucursales.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosSucursales que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow GetByPk( string IdProducto, long IdSucursal, long IdEmpresa )
		{
			tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row = mz.erp.dataaccess.tsh_ProductosSucursales.GetByPk( IdProducto, IdSucursal, IdEmpresa  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId")
                            row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		public static tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow GetByPk(string IdTransaction,  string IdProducto, long IdSucursal, long IdEmpresa )
		{
			tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row = mz.erp.dataaccess.tsh_ProductosSucursales.GetByPk(IdTransaction, IdProducto, IdSucursal, IdEmpresa  );
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
		/// Obtiene un registro de la tabla tsh_ProductosSucursales que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow GetByPk( object IdProducto, object IdSucursal, object IdEmpresa )
		{
			return GetByPk( ( string )IdProducto, ( long )IdSucursal, ( long )IdEmpresa );
		}

		
		/// <summary>
		/// Envia los cambios del tsh_ProductosSucursalesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosSucursalesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosSucursalesRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosSucursales.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosSucursalesDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosSucursalesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosSucursales.Rows.Count > 0, "La tabla dataSet.tsh_ProductosSucursalesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosSucursales.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosSucursales.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosSucursalesRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosSucursalesDataset.tsh_ProductosSucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
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
						
			if ( !IncrementoDeCostoIsValid( row.IncrementoDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "IncrementoDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !MACIsValid( row.MAC, out mensaje) )
			{ 
				row.SetColumnError( "MAC" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaNetoIsValid( row.PrecioDeVentaNeto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !MaxDescuentoIsValid( row.MaxDescuento, out mensaje) )
			{ 
				row.SetColumnError( "MaxDescuento" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaBrutoIsValid( row.PrecioDeVentaBruto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaBruto" , mensaje);
				isValid=false;
			
			}
						
			if ( !StockReservadoIsValid( row.StockReservado, out mensaje) )
			{ 
				row.SetColumnError( "StockReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !StockConfirmadoIsValid( row.StockConfirmado, out mensaje) )
			{ 
				row.SetColumnError( "StockConfirmado" , mensaje);
				isValid=false;
			
			}
						
			if ( !StockDisponibleIsValid( row.StockDisponible, out mensaje) )
			{ 
				row.SetColumnError( "StockDisponible" , mensaje);
				isValid=false;
			
			}
						
			if ( !StockFisicoIsValid( row.StockFisico, out mensaje) )
			{ 
				row.SetColumnError( "StockFisico" , mensaje);
				isValid=false;
			
			}
						
			if ( !StockMinimoIsValid( row.StockMinimo, out mensaje) )
			{ 
				row.SetColumnError( "StockMinimo" , mensaje);
				isValid=false;
			
			}
						
			if ( !StockMaximoIsValid( row.StockMaximo, out mensaje) )
			{ 
				row.SetColumnError( "StockMaximo" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}
						
			if ( !BloqueadoIsValid( row.Bloqueado, out mensaje) )
			{ 
				row.SetColumnError( "Bloqueado" , mensaje);
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
			;
			
			return isValid;
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
		/// Valida el campo IncrementoDeCosto.
		/// </summary>
		public static bool IncrementoDeCostoIsValid( decimal IncrementoDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IncrementoDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool IncrementoDeCostoIsValid( decimal IncrementoDeCosto)
		{
			string mensaje;
			return IncrementoDeCostoIsValid( IncrementoDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MAC.
		/// </summary>
		public static bool MACIsValid( decimal MAC , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MAC. Metodo Sobrecargado
		/// </summary>
		public static bool MACIsValid( decimal MAC)
		{
			string mensaje;
			return MACIsValid( MAC, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioDeVentaNeto.
		/// </summary>
		public static bool PrecioDeVentaNetoIsValid( decimal PrecioDeVentaNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeVentaNeto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeVentaNetoIsValid( decimal PrecioDeVentaNeto)
		{
			string mensaje;
			return PrecioDeVentaNetoIsValid( PrecioDeVentaNeto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MaxDescuento.
		/// </summary>
		public static bool MaxDescuentoIsValid( decimal MaxDescuento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaxDescuento. Metodo Sobrecargado
		/// </summary>
		public static bool MaxDescuentoIsValid( decimal MaxDescuento)
		{
			string mensaje;
			return MaxDescuentoIsValid( MaxDescuento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBruto.
		/// </summary>
		public static bool PrecioDeVentaBrutoIsValid( decimal PrecioDeVentaBruto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBruto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeVentaBrutoIsValid( decimal PrecioDeVentaBruto)
		{
			string mensaje;
			return PrecioDeVentaBrutoIsValid( PrecioDeVentaBruto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo StockReservado.
		/// </summary>
		public static bool StockReservadoIsValid( decimal StockReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo StockReservado. Metodo Sobrecargado
		/// </summary>
		public static bool StockReservadoIsValid( decimal StockReservado)
		{
			string mensaje;
			return StockReservadoIsValid( StockReservado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo StockConfirmado.
		/// </summary>
		public static bool StockConfirmadoIsValid( decimal StockConfirmado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo StockConfirmado. Metodo Sobrecargado
		/// </summary>
		public static bool StockConfirmadoIsValid( decimal StockConfirmado)
		{
			string mensaje;
			return StockConfirmadoIsValid( StockConfirmado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo StockDisponible.
		/// </summary>
		public static bool StockDisponibleIsValid( decimal StockDisponible , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo StockDisponible. Metodo Sobrecargado
		/// </summary>
		public static bool StockDisponibleIsValid( decimal StockDisponible)
		{
			string mensaje;
			return StockDisponibleIsValid( StockDisponible, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo StockFisico.
		/// </summary>
		public static bool StockFisicoIsValid( decimal StockFisico , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo StockFisico. Metodo Sobrecargado
		/// </summary>
		public static bool StockFisicoIsValid( decimal StockFisico)
		{
			string mensaje;
			return StockFisicoIsValid( StockFisico, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo StockMinimo.
		/// </summary>
		public static bool StockMinimoIsValid( decimal StockMinimo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo StockMinimo. Metodo Sobrecargado
		/// </summary>
		public static bool StockMinimoIsValid( decimal StockMinimo)
		{
			string mensaje;
			return StockMinimoIsValid( StockMinimo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo StockMaximo.
		/// </summary>
		public static bool StockMaximoIsValid( decimal StockMaximo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo StockMaximo. Metodo Sobrecargado
		/// </summary>
		public static bool StockMaximoIsValid( decimal StockMaximo)
		{
			string mensaje;
			return StockMaximoIsValid( StockMaximo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bloqueado.
		/// </summary>
		public static bool BloqueadoIsValid( bool Bloqueado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bloqueado. Metodo Sobrecargado
		/// </summary>
		public static bool BloqueadoIsValid( bool Bloqueado)
		{
			string mensaje;
			return BloqueadoIsValid( Bloqueado, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

