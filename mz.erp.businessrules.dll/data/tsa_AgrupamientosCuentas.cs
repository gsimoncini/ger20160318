namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_AgrupamientosCuentas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_AgrupamientosCuentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_AgrupamientosCuentas
		/// </summary>
		public static tsa_AgrupamientosCuentasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_AgrupamientosCuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_AgrupamientosCuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_AgrupamientosCuentasDataset GetList( string IdCuenta, long IdAgrupamiento, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_AgrupamientosCuentas.GetList( IdCuenta, IdAgrupamiento, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_AgrupamientosCuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow NewRow()
		{
			return mz.erp.dataaccess.tsa_AgrupamientosCuentas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_AgrupamientosCuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow GetByPk( string IdCuenta, long IdAgrupamiento )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_AgrupamientosCuentas.GetByPk( IdCuenta, IdAgrupamiento ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_AgrupamientosCuentasRow.
		/// </summary>
		public static tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow SetRowDefaultValues( tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
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
		/// Envia los cambios del tsa_AgrupamientosCuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_AgrupamientosCuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_AgrupamientosCuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_AgrupamientosCuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_AgrupamientosCuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_AgrupamientosCuentas.Rows.Count > 0, "La tabla dataSet.tsa_AgrupamientosCuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_AgrupamientosCuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_AgrupamientosCuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_AgrupamientosCuentasRow.
		/// </summary>
		public static bool RowIsValid( tsa_AgrupamientosCuentasDataset.tsa_AgrupamientosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCuentaIsValid( row.IdCuenta ) )
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
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta )
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

