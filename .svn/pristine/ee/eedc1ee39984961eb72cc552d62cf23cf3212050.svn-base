namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tcs_Tratamiento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tcs_Tratamiento()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_Tratamiento
		/// </summary>
		public static tcs_TratamientoDataset GetList()
		{
			return mz.erp.dataaccess.tcs_Tratamiento.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_Tratamiento filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_TratamientoDataset GetList( long IdTratamiento, string Abreviatura, string Texto, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tcs_Tratamiento.GetList( IdTratamiento, Abreviatura, Texto, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tcs_TratamientoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_TratamientoDataset.tcs_TratamientoRow NewRow()
		{
			return mz.erp.dataaccess.tcs_Tratamiento.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_Tratamiento que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_TratamientoDataset.tcs_TratamientoRow GetByPk( long IdTratamiento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tcs_Tratamiento.GetByPk( IdTratamiento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tcs_TratamientoRow.
		/// </summary>
		public static tcs_TratamientoDataset.tcs_TratamientoRow SetRowDefaultValues( tcs_TratamientoDataset.tcs_TratamientoRow row )
		{
			row.IdTratamiento = 0; 
			row.Abreviatura = string.Empty;
			row.Texto = string.Empty;
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
		/// Envia los cambios del tcs_TratamientoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tcs_TratamientoDataset.tcs_TratamientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tcs_TratamientoRow a la base de datos.
		/// </summary>
		public static void Update( tcs_TratamientoDataset.tcs_TratamientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Tratamiento.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_TratamientoDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_TratamientoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_Tratamiento.Rows.Count > 0, "La tabla dataSet.tcs_TratamientoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Tratamiento.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_TratamientoDataset.tcs_TratamientoDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_TratamientoDataset.tcs_TratamientoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Tratamiento.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_TratamientoRow.
		/// </summary>
		public static bool RowIsValid( tcs_TratamientoDataset.tcs_TratamientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTratamientoIsValid( row.IdTratamiento ) )
			{ 
				return false;
			}
						
			if ( !AbreviaturaIsValid( row.Abreviatura ) )
			{ 
				return false;
			}
						
			if ( !TextoIsValid( row.Texto ) )
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
		/// Valida el campo IdTratamiento.
		/// </summary>
		public static bool IdTratamientoIsValid( long IdTratamiento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Abreviatura.
		/// </summary>
		public static bool AbreviaturaIsValid( string Abreviatura )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Texto.
		/// </summary>
		public static bool TextoIsValid( string Texto )
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

