namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_AsociacionCodigos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_AsociacionCodigos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_AsociacionCodigos
		/// </summary>
		public static tsh_AsociacionCodigosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_AsociacionCodigos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_AsociacionCodigos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_AsociacionCodigosDataset GetList( string IdProducto, string CodigoSecundario, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_AsociacionCodigos.GetList( IdProducto, CodigoSecundario, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_AsociacionCodigosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow NewRow()
		{
			return mz.erp.dataaccess.tsh_AsociacionCodigos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_AsociacionCodigos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow GetByPk( string IdProducto, string CodigoSecundario )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_AsociacionCodigos.GetByPk( IdProducto, CodigoSecundario ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_AsociacionCodigosRow.
		/// </summary>
		public static tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow SetRowDefaultValues( tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.CodigoSecundario = Util.NewStringId(); 
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AsociacionCodigosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_AsociacionCodigosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_AsociacionCodigos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_AsociacionCodigosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_AsociacionCodigosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_AsociacionCodigos.Rows.Count > 0, "La tabla dataSet.tsh_AsociacionCodigosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_AsociacionCodigos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_AsociacionCodigos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_AsociacionCodigosRow.
		/// </summary>
		public static bool RowIsValid( tsh_AsociacionCodigosDataset.tsh_AsociacionCodigosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !CodigoSecundarioIsValid( row.CodigoSecundario ) )
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
			;
			
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
		/// Valida el campo CodigoSecundario.
		/// </summary>
		public static bool CodigoSecundarioIsValid( string CodigoSecundario )
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

