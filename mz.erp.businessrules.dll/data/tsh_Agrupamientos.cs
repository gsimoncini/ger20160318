namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_Agrupamientos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_Agrupamientos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Agrupamientos
		/// </summary>
		public static tsh_AgrupamientosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Agrupamientos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Agrupamientos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_AgrupamientosDataset GetList( string IdProducto, long IdAgrupamiento, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_Agrupamientos.GetList( IdProducto, IdAgrupamiento, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_AgrupamientosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AgrupamientosDataset.tsh_AgrupamientosRow NewRow()
		{
			return mz.erp.dataaccess.tsh_Agrupamientos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Agrupamientos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AgrupamientosDataset.tsh_AgrupamientosRow GetByPk( string IdProducto, long IdAgrupamiento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsh_Agrupamientos.GetByPk( IdProducto, IdAgrupamiento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_AgrupamientosRow.
		/// </summary>
		public static tsh_AgrupamientosDataset.tsh_AgrupamientosRow SetRowDefaultValues( tsh_AgrupamientosDataset.tsh_AgrupamientosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdAgrupamiento = 0; 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupamientosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_AgrupamientosDataset.tsh_AgrupamientosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupamientosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_AgrupamientosDataset.tsh_AgrupamientosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Agrupamientos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_AgrupamientosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_AgrupamientosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Agrupamientos.Rows.Count > 0, "La tabla dataSet.tsh_AgrupamientosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Agrupamientos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AgrupamientosDataset.tsh_AgrupamientosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_AgrupamientosDataset.tsh_AgrupamientosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Agrupamientos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_AgrupamientosRow.
		/// </summary>
		public static bool RowIsValid( tsh_AgrupamientosDataset.tsh_AgrupamientosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !IdAgrupamientoIsValid( row.IdAgrupamiento ) )
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
		/// Valida el campo IdAgrupamiento.
		/// </summary>
		public static bool IdAgrupamientoIsValid( long IdAgrupamiento )
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

