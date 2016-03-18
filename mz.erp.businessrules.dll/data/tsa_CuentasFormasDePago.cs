namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_CuentasFormasDePago : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_CuentasFormasDePago()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CuentasFormasDePago
		/// </summary>
		public static tsa_CuentasFormasDePagoDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CuentasFormasDePago.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_CuentasFormasDePago filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasFormasDePagoDataset GetList( string IdCuenta, string IdFormaPago, bool Activo, decimal MaximoPorcentaje, decimal MaximoMontoFijo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_CuentasFormasDePago.GetList( IdCuenta, IdFormaPago, Activo, MaximoPorcentaje, MaximoMontoFijo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_CuentasFormasDePagoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow NewRow()
		{
			return mz.erp.dataaccess.tsa_CuentasFormasDePago.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasFormasDePago que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow GetByPk( string IdCuenta, string IdFormaPago )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_CuentasFormasDePago.GetByPk( IdCuenta, IdFormaPago ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasFormasDePagoRow.
		/// </summary>
		public static tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow SetRowDefaultValues( tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.IdFormaPago = Util.NewStringId(); 
			row.Activo = false;
			row.MaximoPorcentaje = 0;
			row.MaximoMontoFijo = 0;
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
		/// Envia los cambios del tsa_CuentasFormasDePagoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasFormasDePagoRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasFormasDePago.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasFormasDePagoDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasFormasDePagoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CuentasFormasDePago.Rows.Count > 0, "La tabla dataSet.tsa_CuentasFormasDePagoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasFormasDePago.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasFormasDePago.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CuentasFormasDePagoRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasFormasDePagoDataset.tsa_CuentasFormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !IdFormaPagoIsValid( row.IdFormaPago ) )
			{ 
				return false;
			}
						
			if ( !ActivoIsValid( row.Activo ) )
			{ 
				return false;
			}
						
			if ( !MaximoPorcentajeIsValid( row.MaximoPorcentaje ) )
			{ 
				return false;
			}
						
			if ( !MaximoMontoFijoIsValid( row.MaximoMontoFijo ) )
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
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFormaPago.
		/// </summary>
		public static bool IdFormaPagoIsValid( string IdFormaPago )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaximoPorcentaje.
		/// </summary>
		public static bool MaximoPorcentajeIsValid( decimal MaximoPorcentaje )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaximoMontoFijo.
		/// </summary>
		public static bool MaximoMontoFijoIsValid( decimal MaximoMontoFijo )
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

