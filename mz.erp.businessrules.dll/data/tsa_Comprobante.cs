namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_Comprobante : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_Comprobante()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_Comprobante
		/// </summary>
		public static tsa_ComprobanteDataset GetList()
		{
			return mz.erp.dataaccess.tsa_Comprobante.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_Comprobante filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobanteDataset GetList( long IdComprobante, DateTime Fecha, string Tipo, string Numero, string IdCuenta, long IdCondicionDeVenta, decimal BaseImponible, decimal Exento, decimal IvaInscripto, decimal RetencionIB, decimal RetencionIva, decimal RetencionGanancia, decimal BonificacionRecargo, decimal Total, DateTime FechaVencimiento, string IdVendedor, string PeriodoFiscal, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_Comprobante.GetList( IdComprobante, Fecha, Tipo, Numero, IdCuenta, IdCondicionDeVenta, BaseImponible, Exento, IvaInscripto, RetencionIB, RetencionIva, RetencionGanancia, BonificacionRecargo, Total, FechaVencimiento, IdVendedor, PeriodoFiscal, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_ComprobanteRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDataset.tsa_ComprobanteRow NewRow()
		{
			return mz.erp.dataaccess.tsa_Comprobante.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_Comprobante que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDataset.tsa_ComprobanteRow GetByPk( DateTime Fecha, string Tipo, string Numero )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_Comprobante.GetByPk( Fecha, Tipo, Numero ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobanteRow.
		/// </summary>
		public static tsa_ComprobanteDataset.tsa_ComprobanteRow SetRowDefaultValues( tsa_ComprobanteDataset.tsa_ComprobanteRow row )
		{
			row.Fecha = DateTime.Now; 
			row.Tipo = Util.NewStringId(); 
			row.Numero = Util.NewStringId(); 
			row.IdComprobante = 0;
			row.IdCuenta = string.Empty;
			row.IdCondicionDeVenta = 0;
			row.BaseImponible = 0;
			row.Exento = 0;
			row.IvaInscripto = 0;
			row.RetencionIB = 0;
			row.RetencionIva = 0;
			row.RetencionGanancia = 0;
			row.BonificacionRecargo = 0;
			row.Total = 0;
			row.FechaVencimiento = DateTime.Now;
			row.IdVendedor = string.Empty;
			row.PeriodoFiscal = string.Empty;
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
		/// Envia los cambios del tsa_ComprobanteRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_ComprobanteDataset.tsa_ComprobanteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDataset.tsa_ComprobanteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Comprobante.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_Comprobante.Rows.Count > 0, "La tabla dataSet.tsa_ComprobanteDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Comprobante.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDataset.tsa_ComprobanteDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDataset.tsa_ComprobanteDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_Comprobante.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobanteRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobanteDataset.tsa_ComprobanteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !TipoIsValid( row.Tipo ) )
			{ 
				return false;
			}
						
			if ( !NumeroIsValid( row.Numero ) )
			{ 
				return false;
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !IdCondicionDeVentaIsValid( row.IdCondicionDeVenta ) )
			{ 
				return false;
			}
						
			if ( !BaseImponibleIsValid( row.BaseImponible ) )
			{ 
				return false;
			}
						
			if ( !ExentoIsValid( row.Exento ) )
			{ 
				return false;
			}
						
			if ( !IvaInscriptoIsValid( row.IvaInscripto ) )
			{ 
				return false;
			}
						
			if ( !RetencionIBIsValid( row.RetencionIB ) )
			{ 
				return false;
			}
						
			if ( !RetencionIvaIsValid( row.RetencionIva ) )
			{ 
				return false;
			}
						
			if ( !RetencionGananciaIsValid( row.RetencionGanancia ) )
			{ 
				return false;
			}
						
			if ( !BonificacionRecargoIsValid( row.BonificacionRecargo ) )
			{ 
				return false;
			}
						
			if ( !TotalIsValid( row.Total ) )
			{ 
				return false;
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento ) )
			{ 
				return false;
			}
						
			if ( !IdVendedorIsValid( row.IdVendedor ) )
			{ 
				return false;
			}
						
			if ( !PeriodoFiscalIsValid( row.PeriodoFiscal ) )
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
		/// Valida el campo IdComprobante.
		/// </summary>
		public static bool IdComprobanteIsValid( long IdComprobante )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Tipo.
		/// </summary>
		public static bool TipoIsValid( string Tipo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero )
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
		/// Valida el campo IdCondicionDeVenta.
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( long IdCondicionDeVenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo BaseImponible.
		/// </summary>
		public static bool BaseImponibleIsValid( decimal BaseImponible )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Exento.
		/// </summary>
		public static bool ExentoIsValid( decimal Exento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IvaInscripto.
		/// </summary>
		public static bool IvaInscriptoIsValid( decimal IvaInscripto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RetencionIB.
		/// </summary>
		public static bool RetencionIBIsValid( decimal RetencionIB )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RetencionIva.
		/// </summary>
		public static bool RetencionIvaIsValid( decimal RetencionIva )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RetencionGanancia.
		/// </summary>
		public static bool RetencionGananciaIsValid( decimal RetencionGanancia )
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
		/// Valida el campo Total.
		/// </summary>
		public static bool TotalIsValid( decimal Total )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdVendedor.
		/// </summary>
		public static bool IdVendedorIsValid( string IdVendedor )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PeriodoFiscal.
		/// </summary>
		public static bool PeriodoFiscalIsValid( string PeriodoFiscal )
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

