namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_ComprobantesRemitos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_ComprobantesRemitos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_ComprobantesRemitos
		/// </summary>
		public static tlg_ComprobantesRemitosDataset GetList()
		{
			return mz.erp.dataaccess.tlg_ComprobantesRemitos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_ComprobantesRemitos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_ComprobantesRemitosDataset GetList( long IdRemito, string IdProducto, DateTime Fecha, string Tipo, string Numero, short IdRenglon, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tlg_ComprobantesRemitos.GetList( IdRemito, IdProducto, Fecha, Tipo, Numero, IdRenglon, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tlg_ComprobantesRemitosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow NewRow()
		{
			return mz.erp.dataaccess.tlg_ComprobantesRemitos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_ComprobantesRemitos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow GetByPk( long IdRemito, string IdProducto, DateTime Fecha, string Tipo, string Numero, short IdRenglon )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tlg_ComprobantesRemitos.GetByPk( IdRemito, IdProducto, Fecha, Tipo, Numero, IdRenglon ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_ComprobantesRemitosRow.
		/// </summary>
		public static tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow SetRowDefaultValues( tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow row )
		{
			row.IdRemito = 0; 
			row.IdProducto = Util.NewStringId(); 
			row.Fecha = DateTime.Now; 
			row.Tipo = Util.NewStringId(); 
			row.Numero = Util.NewStringId(); 
			row.IdRenglon = 0; 
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
		/// Envia los cambios del tlg_ComprobantesRemitosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tlg_ComprobantesRemitosRow a la base de datos.
		/// </summary>
		public static void Update( tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_ComprobantesRemitos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_ComprobantesRemitosDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_ComprobantesRemitosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_ComprobantesRemitos.Rows.Count > 0, "La tabla dataSet.tlg_ComprobantesRemitosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_ComprobantesRemitos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_ComprobantesRemitos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_ComprobantesRemitosRow.
		/// </summary>
		public static bool RowIsValid( tlg_ComprobantesRemitosDataset.tlg_ComprobantesRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdRemitoIsValid( row.IdRemito ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !TipoIsValid( row.Tipo ) )
			{ 
				return false;
			}
						
			if ( !NumeroIsValid( row.Numero ) )
			{ 
				return false;
			}
						
			if ( !IdRenglonIsValid( row.IdRenglon ) )
			{ 
				return false;
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion ) )
			{ 
				return false;
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdReservadoIsValid( row.IdReservado ) )
			{ 
				return false;
			}
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal ) )
			{ 
				return false;
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRemito.
		/// </summary>
		public static bool IdRemitoIsValid( long IdRemito )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Tipo.
		/// </summary>
		public static bool TipoIsValid( string Tipo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRenglon.
		/// </summary>
		public static bool IdRenglonIsValid( short IdRenglon )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}

