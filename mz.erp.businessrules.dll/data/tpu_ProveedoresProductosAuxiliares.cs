namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProveedoresProductosAuxiliares : IDisposable
	{
	
		#region Custom Members

        //Sabrina: Tarea 1110. 20110805
        public static tsh_ProductosExDataset.tpu_ProveedoresProductosAuxiliaresRow SetRowDefaultValues(tsh_ProductosExDataset.tpu_ProveedoresProductosAuxiliaresRow row)
        {
            row.IdProveedor = Util.NewStringId();
            row.IdProducto = Util.NewStringId();
            row.CodigoProductoProveedor = string.Empty;
            row.FechaCreacion = DateTime.Now;
            row.IdConexionCreacion = Security.IdConexion;
            //row.UltimaModificacion = null;
            row.IdConexionUltimaModificacion = Security.IdConexion;
            row.IdReservado = 0;
            row.RowId = Guid.Empty;
            row.IdSucursal = Security.IdSucursal;
            row.IdEmpresa = Security.IdEmpresa;

            return row;
        }
        //Fin Sabrina: Tarea 1110. 20110805

		#endregion
		
		public tpu_ProveedoresProductosAuxiliares()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresProductosAuxiliares
		/// </summary>
		public static tpu_ProveedoresProductosAuxiliaresDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProveedoresProductosAuxiliares filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProveedoresProductosAuxiliaresDataset GetList( string IdProveedor, string IdProducto, string CodigoProductoProveedor, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.GetList( IdProveedor, IdProducto, CodigoProductoProveedor, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tpu_ProveedoresProductosAuxiliaresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresProductosAuxiliares que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow GetByPk( string IdProveedor, string IdProducto )
		{
		   tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow row = mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.GetByPk( IdProveedor, IdProducto  );
           //Sabrina: Tarea 1110. 20110805
           if (row != null)
           {
               foreach (DataColumn dc in row.Table.Columns)
               {
                   if (row[dc] == System.DBNull.Value)
                   {
                       row[dc] = Util.DefaultValue(dc.DataType);
                   }
               }
           }
            //Fin Sabrina: Tarea 1110. 20110805
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresProductosAuxiliares que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow GetByPk( object IdProveedor, object IdProducto )
		{
			return GetByPk( ( string )IdProveedor, ( string )IdProducto );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresProductosAuxiliaresRow.
		/// </summary>
		public static tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow SetRowDefaultValues( tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow row )
		{
			row.IdProveedor = Util.NewStringId(); 
			row.IdProducto = Util.NewStringId(); 
			row.CodigoProductoProveedor = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosAuxiliaresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosAuxiliaresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosAuxiliaresRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosAuxiliaresDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresProductosAuxiliaresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresProductosAuxiliares.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresProductosAuxiliaresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresProductosAuxiliares.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresProductosAuxiliaresRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoProductoProveedorIsValid( row.CodigoProductoProveedor, out mensaje) )
			{ 
				row.SetColumnError( "CodigoProductoProveedor" , mensaje);
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
			;
			
			return isValid;
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
		/// Valida el campo CodigoProductoProveedor.
		/// </summary>
		public static bool CodigoProductoProveedorIsValid( string CodigoProductoProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoProductoProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoProductoProveedorIsValid( string CodigoProductoProveedor)
		{
			string mensaje;
			return CodigoProductoProveedorIsValid( CodigoProductoProveedor, out mensaje );
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

