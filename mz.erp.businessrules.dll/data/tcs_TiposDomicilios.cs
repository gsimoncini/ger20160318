namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tcs_TiposDomicilios : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tcs_TiposDomicilios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_TiposDomicilios
		/// </summary>
		public static tcs_TiposDomiciliosDataset GetList()
		{
			return mz.erp.dataaccess.tcs_TiposDomicilios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_TiposDomicilios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_TiposDomiciliosDataset GetList( long IdTipoDomicilio, string Descripcion, bool Sistema, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tcs_TiposDomicilios.GetList( IdTipoDomicilio, Descripcion, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tcs_TiposDomiciliosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tcs_TiposDomicilios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_TiposDomicilios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow GetByPk( long IdTipoDomicilio )
		{
			//SetRowDefaultValues( 
			tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row = mz.erp.dataaccess.tcs_TiposDomicilios.GetByPk( IdTipoDomicilio );
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
		/// Establece los valores por defecto de tcs_TiposDomiciliosRow.
		/// </summary>
		public static tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow SetRowDefaultValues( tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row )
		{
			row.IdTipoDomicilio = 0; 
			row.Descripcion = string.Empty;
			row.Sistema = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tcs_TiposDomiciliosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tcs_TiposDomiciliosRow a la base de datos.
		/// </summary>
		public static void Update( tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_TiposDomicilios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_TiposDomiciliosDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_TiposDomiciliosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_TiposDomicilios.Rows.Count > 0, "La tabla dataSet.tcs_TiposDomiciliosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_TiposDomicilios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_TiposDomicilios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_TiposDomiciliosRow.
		/// </summary>
		public static bool RowIsValid( tcs_TiposDomiciliosDataset.tcs_TiposDomiciliosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoDomicilioIsValid( row.IdTipoDomicilio ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !SistemaIsValid( row.Sistema ) )
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
		/// Valida el campo IdTipoDomicilio.
		/// </summary>
		public static bool IdTipoDomicilioIsValid( long IdTipoDomicilio )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema )
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

