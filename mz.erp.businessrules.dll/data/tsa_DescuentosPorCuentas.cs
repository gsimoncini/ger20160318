namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_DescuentosPorCuentas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_DescuentosPorCuentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_DescuentosPorCuentas
		/// </summary>
		public static tsa_DescuentosPorCuentasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_DescuentosPorCuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_DescuentosPorCuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_DescuentosPorCuentasDataset GetList( long IdDescuentosPorCuentas, string IdCuenta, string Descripcion, decimal BonificacionRecargo, decimal CargoFijo, decimal MontoMinimo, DateTime VigenciaDesde, DateTime VigenciaHasta, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_DescuentosPorCuentas.GetList( IdDescuentosPorCuentas, IdCuenta, Descripcion, BonificacionRecargo, CargoFijo, MontoMinimo, VigenciaDesde, VigenciaHasta, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_DescuentosPorCuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow NewRow()
		{
			return mz.erp.dataaccess.tsa_DescuentosPorCuentas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_DescuentosPorCuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow GetByPk( long IdDescuentosPorCuentas )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_DescuentosPorCuentas.GetByPk( IdDescuentosPorCuentas ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_DescuentosPorCuentasRow.
		/// </summary>
		public static tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow SetRowDefaultValues( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow row )
		{
			row.IdDescuentosPorCuentas = 0; 
			row.IdCuenta = string.Empty;
			row.Descripcion = string.Empty;
			row.BonificacionRecargo = 0;
			row.CargoFijo = 0;
			row.MontoMinimo = 0;
			row.VigenciaDesde = DateTime.Now;
			row.VigenciaHasta = DateTime.Now;
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
		/// Envia los cambios del tsa_DescuentosPorCuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorCuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorCuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorCuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorCuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_DescuentosPorCuentas.Rows.Count > 0, "La tabla dataSet.tsa_DescuentosPorCuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorCuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorCuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_DescuentosPorCuentasRow.
		/// </summary>
		public static bool RowIsValid( tsa_DescuentosPorCuentasDataset.tsa_DescuentosPorCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdDescuentosPorCuentasIsValid( row.IdDescuentosPorCuentas ) )
			{ 
				return false;
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !BonificacionRecargoIsValid( row.BonificacionRecargo ) )
			{ 
				return false;
			}
						
			if ( !CargoFijoIsValid( row.CargoFijo ) )
			{ 
				return false;
			}
						
			if ( !MontoMinimoIsValid( row.MontoMinimo ) )
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
		/// Valida el campo IdDescuentosPorCuentas.
		/// </summary>
		public static bool IdDescuentosPorCuentasIsValid( long IdDescuentosPorCuentas )
		{
			//Agregar cdigo de validacin
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargo.
		/// </summary>
		public static bool BonificacionRecargoIsValid( decimal BonificacionRecargo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo CargoFijo.
		/// </summary>
		public static bool CargoFijoIsValid( decimal CargoFijo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontoMinimo.
		/// </summary>
		public static bool MontoMinimoIsValid( decimal MontoMinimo )
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

