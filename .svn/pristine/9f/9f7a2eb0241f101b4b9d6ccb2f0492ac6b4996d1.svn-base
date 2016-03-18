namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tcs_Cargos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tcs_Cargos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tcs_Cargos
		/// </summary>
		public static tcs_CargosDataset GetList()
		{
			return mz.erp.dataaccess.tcs_Cargos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tcs_Cargos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tcs_CargosDataset GetList( long IdCargo, string Descripcion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tcs_Cargos.GetList( IdCargo, Descripcion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tcs_CargosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_CargosDataset.tcs_CargosRow NewRow()
		{
			return mz.erp.dataaccess.tcs_Cargos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tcs_Cargos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tcs_CargosDataset.tcs_CargosRow GetByPk( long IdCargo )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tcs_Cargos.GetByPk( IdCargo ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tcs_CargosRow.
		/// </summary>
		public static tcs_CargosDataset.tcs_CargosRow SetRowDefaultValues( tcs_CargosDataset.tcs_CargosRow row )
		{
			row.IdCargo = 0; 
			row.Descripcion = string.Empty;
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
		/// Envia los cambios del tcs_CargosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tcs_CargosDataset.tcs_CargosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tcs_CargosRow a la base de datos.
		/// </summary>
		public static void Update( tcs_CargosDataset.tcs_CargosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Cargos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tcs_CargosDataset a la base de datos.
		/// </summary>
		public static void Update( tcs_CargosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tcs_Cargos.Rows.Count > 0, "La tabla dataSet.tcs_CargosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Cargos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tcs_CargosDataset.tcs_CargosDataTable a la base de datos.
		/// </summary>
		public static void Update( tcs_CargosDataset.tcs_CargosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tcs_Cargos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tcs_CargosRow.
		/// </summary>
		public static bool RowIsValid( tcs_CargosDataset.tcs_CargosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCargoIsValid( row.IdCargo ) )
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
		/// Valida el campo IdCargo.
		/// </summary>
		public static bool IdCargoIsValid( long IdCargo )
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

