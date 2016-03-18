namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tcs_TiposContactos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tcs_TiposContactos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_TiposContactos
		/// </summary>
		public static tcs_TiposContactosDataset GetList()
		{
			return mz.erp.dataaccess.tcs_TiposContactos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_TiposContactos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_TiposContactosDataset GetList( long IdTipoContacto, string Descripcion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tcs_TiposContactos.GetList( IdTipoContacto, Descripcion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tcs_TiposContactosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_TiposContactosDataset.tcs_TiposContactosRow NewRow()
		{
			return mz.erp.dataaccess.tcs_TiposContactos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_TiposContactos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_TiposContactosDataset.tcs_TiposContactosRow GetByPk( long IdTipoContacto )
		{
			tcs_TiposContactosDataset.tcs_TiposContactosRow row = mz.erp.dataaccess.tcs_TiposContactos.GetByPk( IdTipoContacto );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;;
		}

		/// <summary>
		/// Establece los valores por defecto de tcs_TiposContactosRow.
		/// </summary>
		public static tcs_TiposContactosDataset.tcs_TiposContactosRow SetRowDefaultValues( tcs_TiposContactosDataset.tcs_TiposContactosRow row )
		{
			row.IdTipoContacto = 0; 
			row.Descripcion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tcs_TiposContactosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tcs_TiposContactosDataset.tcs_TiposContactosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tcs_TiposContactosRow a la base de datos.
		/// </summary>
		public static void Update( tcs_TiposContactosDataset.tcs_TiposContactosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_TiposContactos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_TiposContactosDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_TiposContactosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_TiposContactos.Rows.Count > 0, "La tabla dataSet.tcs_TiposContactosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_TiposContactos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_TiposContactosDataset.tcs_TiposContactosDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_TiposContactosDataset.tcs_TiposContactosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_TiposContactos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_TiposContactosRow.
		/// </summary>
		public static bool RowIsValid( tcs_TiposContactosDataset.tcs_TiposContactosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoContactoIsValid( row.IdTipoContacto ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
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
		/// Valida el campo IdTipoContacto.
		/// </summary>
		public static bool IdTipoContactoIsValid( long IdTipoContacto )
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

