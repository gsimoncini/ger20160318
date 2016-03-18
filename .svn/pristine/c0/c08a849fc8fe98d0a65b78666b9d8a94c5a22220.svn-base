namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_DescuentosPorCuentasExt : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_DescuentosPorCuentasExt()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_DescuentosPorCuentasExt
		/// </summary>
		public static tsa_DescuentosPorCuentasExtDataset GetList()
		{
			return mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_DescuentosPorCuentasExt filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_DescuentosPorCuentasExtDataset GetList( long IdDescuentosPorCuentas, string IdProducto, decimal BonificacionRecargo, decimal CargoFijo, decimal UnidadesMinimo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.GetList( IdDescuentosPorCuentas, IdProducto, BonificacionRecargo, CargoFijo, UnidadesMinimo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_DescuentosPorCuentasExtRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow NewRow()
		{
			return mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_DescuentosPorCuentasExt que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow GetByPk( long IdDescuentosPorCuentas, string IdProducto )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.GetByPk( IdDescuentosPorCuentas, IdProducto ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_DescuentosPorCuentasExtRow.
		/// </summary>
		public static tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow SetRowDefaultValues( tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow row )
		{
			row.IdDescuentosPorCuentas = 0; 
			row.IdProducto = Util.NewStringId(); 
			row.BonificacionRecargo = 0;
			row.CargoFijo = 0;
			row.UnidadesMinimo = 0;
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
		/// Envia los cambios del tsa_DescuentosPorCuentasExtRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorCuentasExtRow a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorCuentasExtDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorCuentasExtDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_DescuentosPorCuentasExt.Rows.Count > 0, "La tabla dataSet.tsa_DescuentosPorCuentasExtDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorCuentasExt.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_DescuentosPorCuentasExtRow.
		/// </summary>
		public static bool RowIsValid( tsa_DescuentosPorCuentasExtDataset.tsa_DescuentosPorCuentasExtRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdDescuentosPorCuentasIsValid( row.IdDescuentosPorCuentas ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
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
						
			if ( !UnidadesMinimoIsValid( row.UnidadesMinimo ) )
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto )
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
		/// Valida el campo UnidadesMinimo.
		/// </summary>
		public static bool UnidadesMinimoIsValid( decimal UnidadesMinimo )
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

