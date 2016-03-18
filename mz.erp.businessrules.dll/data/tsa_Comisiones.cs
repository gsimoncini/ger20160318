namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_Comisiones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_Comisiones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Comisiones
		/// </summary>
		public static tsa_ComisionesDataset GetList()
		{
			return mz.erp.dataaccess.tsa_Comisiones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Comisiones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComisionesDataset GetList( long IdComision, string Descripcion, string SQLDatosOrigen, string VariableAplicacion, string VariableRestriccion, string ValorRestriccion, DateTime VigenciaDesde, DateTime VigenciaHasta, bool Activa, bool Sistema, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_Comisiones.GetList( IdComision, Descripcion, SQLDatosOrigen, VariableAplicacion, VariableRestriccion, ValorRestriccion, VigenciaDesde, VigenciaHasta, Activa, Sistema, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_ComisionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComisionesDataset.tsa_ComisionesRow NewRow()
		{
			return mz.erp.dataaccess.tsa_Comisiones.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Comisiones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComisionesDataset.tsa_ComisionesRow GetByPk( long IdComision )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_Comisiones.GetByPk( IdComision ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComisionesRow.
		/// </summary>
		public static tsa_ComisionesDataset.tsa_ComisionesRow SetRowDefaultValues( tsa_ComisionesDataset.tsa_ComisionesRow row )
		{
			row.IdComision = 0; 
			row.Descripcion = string.Empty;
			row.SQLDatosOrigen = string.Empty;
			row.VariableAplicacion = string.Empty;
			row.VariableRestriccion = string.Empty;
			row.ValorRestriccion = string.Empty;
			row.VigenciaDesde = mz.erp.businessrules.Sistema.DateTime.Now;
			row.VigenciaHasta = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Activa = false;
			row.Sistema = false;
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
		/// Envia los cambios del tsa_ComisionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_ComisionesDataset.tsa_ComisionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_ComisionesRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComisionesDataset.tsa_ComisionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Comisiones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComisionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComisionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Comisiones.Rows.Count > 0, "La tabla dataSet.tsa_ComisionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Comisiones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComisionesDataset.tsa_ComisionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComisionesDataset.tsa_ComisionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Comisiones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComisionesRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComisionesDataset.tsa_ComisionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComisionIsValid( row.IdComision ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !SQLDatosOrigenIsValid( row.SQLDatosOrigen ) )
			{ 
				return false;
			}
						
			if ( !VariableAplicacionIsValid( row.VariableAplicacion ) )
			{ 
				return false;
			}
						
			if ( !VariableRestriccionIsValid( row.VariableRestriccion ) )
			{ 
				return false;
			}
						
			if ( !ValorRestriccionIsValid( row.ValorRestriccion ) )
			{ 
				return false;
			}
						
			if ( !VigenciaDesdeIsValid( row.VigenciaDesde ) )
			{ 
				return false;
			}
						
			if ( !VigenciaHastaIsValid( row.VigenciaHasta ) )
			{ 
				return false;
			}
						
			if ( !ActivaIsValid( row.Activa ) )
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
		/// Valida el campo IdComision.
		/// </summary>
		public static bool IdComisionIsValid( long IdComision )
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
		/// Valida el campo SQLDatosOrigen.
		/// </summary>
		public static bool SQLDatosOrigenIsValid( string SQLDatosOrigen )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VariableAplicacion.
		/// </summary>
		public static bool VariableAplicacionIsValid( string VariableAplicacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VariableRestriccion.
		/// </summary>
		public static bool VariableRestriccionIsValid( string VariableRestriccion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorRestriccion.
		/// </summary>
		public static bool ValorRestriccionIsValid( string ValorRestriccion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VigenciaDesde.
		/// </summary>
		public static bool VigenciaDesdeIsValid( DateTime VigenciaDesde )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo VigenciaHasta.
		/// </summary>
		public static bool VigenciaHastaIsValid( DateTime VigenciaHasta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activa.
		/// </summary>
		public static bool ActivaIsValid( bool Activa )
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

