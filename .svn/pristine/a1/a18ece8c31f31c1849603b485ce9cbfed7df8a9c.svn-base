namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_ProductosPedidosPendientes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_ProductosPedidosPendientes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosPedidosPendientes
		/// </summary>
		public static tsh_ProductosPedidosPendientesDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetList();
		}
		
		public static DataSet GetList(string codigo)
		{
			return mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetList(codigo);
		}

			
		/// <summary>
		/// Obtiene tabla tsh_ProductosPedidosPendientes filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_ProductosPedidosPendientesDataset GetList( DateTime FechaCierre, bool Cerrado, string IdComprobante, string IdProducto, string IdProveedor, DateTime FechaRecepcion, decimal Cantidad, long Ordinal )
		{
			return mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetList( FechaCierre, Cerrado, IdComprobante, IdProducto, IdProveedor, FechaRecepcion, Cantidad, Ordinal );
		}

		/// <summary>
		/// Crea un tsh_ProductosPedidosPendientesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosPedidosPendientes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosPedidosPendientes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow GetByPk( string IdComprobante, string IdProducto, DateTime FechaRecepcion, long Ordinal )
		{
			tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow row = mz.erp.dataaccess.tsh_ProductosPedidosPendientes.GetByPk( IdComprobante, IdProducto, FechaRecepcion, Ordinal  );
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
		/// Obtiene un registro de la tabla tsh_ProductosPedidosPendientes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow GetByPk( object IdComprobante, string IdProducto, DateTime FechaRecepcion, long Ordinal )
		{
			return GetByPk( ( string )IdComprobante, ( string )IdProducto, ( DateTime )FechaRecepcion, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosPedidosPendientesRow.
		/// </summary>
		public static tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow SetRowDefaultValues( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdProducto = Util.NewStringId(); 
			row.FechaRecepcion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Ordinal = 0; 
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = 0;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.FechaCierre = DateTime.MinValue;
			row.Cerrado = false;
			row.IdProveedor = string.Empty;
			row.Cantidad = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosPedidosPendientesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosPedidosPendientesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosPedidosPendientesRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosPedidosPendientes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosPedidosPendientesDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosPedidosPendientesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosPedidosPendientes.Rows.Count > 0, "La tabla dataSet.tsh_ProductosPedidosPendientesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosPedidosPendientes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosPedidosPendientes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosPedidosPendientesRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosPedidosPendientesDataset.tsh_ProductosPedidosPendientesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
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
			
			}
						
			if ( !FechaCierreIsValid( row.FechaCierre, out mensaje) )
			{ 
				row.SetColumnError( "FechaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !CerradoIsValid( row.Cerrado, out mensaje) )
			{ 
				row.SetColumnError( "Cerrado" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaRecepcionIsValid( row.FechaRecepcion, out mensaje) )
			{ 
				row.SetColumnError( "FechaRecepcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
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
		public static bool RowIdIsValid( long RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( long RowId)
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
		/// Valida el campo IdComprobante.
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante)
		{
			string mensaje;
			return IdComprobanteIsValid( IdComprobante, out mensaje );
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
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor)
		{
			string mensaje;
			return IdProveedorIsValid( IdProveedor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaRecepcion.
		/// </summary>
		public static bool FechaRecepcionIsValid( DateTime FechaRecepcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaRecepcion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaRecepcionIsValid( DateTime FechaRecepcion)
		{
			string mensaje;
			return FechaRecepcionIsValid( FechaRecepcion, out mensaje );
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
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

