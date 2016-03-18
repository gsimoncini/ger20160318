namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesCompra : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesCompra()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesCompra
		/// </summary>
		public static tpu_ComprobantesCompraDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesCompra.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesCompra filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesCompraDataset GetList( long IdComprobanteCompra, long IdProveedor, DateTime Fecha, string Tipo, string Numero, string Comentario, DateTime FechaIngreso, string PeriodoFiscal, decimal NetoBruto, decimal Descuento, decimal SubtotalNeto, decimal IvaInscripto, decimal MontosNoGravados, decimal PrecepcionIB, decimal PrecepcionGanancias, decimal PercepcionIva, decimal ImpuestosInternos, decimal TotalGeneral, decimal DescuentoGlobal, decimal Total, DateTime FechaVencimiento, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tpu_ComprobantesCompra.GetList( IdComprobanteCompra, IdProveedor, Fecha, Tipo, Numero, Comentario, FechaIngreso, PeriodoFiscal, NetoBruto, Descuento, SubtotalNeto, IvaInscripto, MontosNoGravados, PrecepcionIB, PrecepcionGanancias, PercepcionIva, ImpuestosInternos, TotalGeneral, DescuentoGlobal, Total, FechaVencimiento, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tpu_ComprobantesCompraRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow NewRow()
		{
			return mz.erp.dataaccess.tpu_ComprobantesCompra.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesCompra que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow GetByPk( long IdComprobanteCompra )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tpu_ComprobantesCompra.GetByPk( IdComprobanteCompra ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesCompraRow.
		/// </summary>
		public static tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow SetRowDefaultValues( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow row )
		{
			row.IdComprobanteCompra = 0; 
			row.IdProveedor = 0;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Tipo = string.Empty;
			row.Numero = string.Empty;
			row.Comentario = string.Empty;
			row.FechaIngreso = mz.erp.businessrules.Sistema.DateTime.Now;
			row.PeriodoFiscal = string.Empty;
			row.NetoBruto = 0;
			row.Descuento = 0;
			row.SubtotalNeto = 0;
			row.IvaInscripto = 0;
			row.MontosNoGravados = 0;
			row.PrecepcionIB = 0;
			row.PrecepcionGanancias = 0;
			row.PercepcionIva = 0;
			row.ImpuestosInternos = 0;
			row.TotalGeneral = 0;
			row.DescuentoGlobal = 0;
			row.Total = 0;
			row.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesCompra.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesCompraDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesCompra.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesCompraDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesCompra.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesCompra.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesCompraRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesCompraDataset.tpu_ComprobantesCompraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdComprobanteCompraIsValid( row.IdComprobanteCompra ) )
			{ 
				return false;
			}
						
			if ( !IdProveedorIsValid( row.IdProveedor ) )
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
						
			if ( !ComentarioIsValid( row.Comentario ) )
			{ 
				return false;
			}
						
			if ( !FechaIngresoIsValid( row.FechaIngreso ) )
			{ 
				return false;
			}
						
			if ( !PeriodoFiscalIsValid( row.PeriodoFiscal ) )
			{ 
				return false;
			}
						
			if ( !NetoBrutoIsValid( row.NetoBruto ) )
			{ 
				return false;
			}
						
			if ( !DescuentoIsValid( row.Descuento ) )
			{ 
				return false;
			}
						
			if ( !SubtotalNetoIsValid( row.SubtotalNeto ) )
			{ 
				return false;
			}
						
			if ( !IvaInscriptoIsValid( row.IvaInscripto ) )
			{ 
				return false;
			}
						
			if ( !MontosNoGravadosIsValid( row.MontosNoGravados ) )
			{ 
				return false;
			}
						
			if ( !PrecepcionIBIsValid( row.PrecepcionIB ) )
			{ 
				return false;
			}
						
			if ( !PrecepcionGananciasIsValid( row.PrecepcionGanancias ) )
			{ 
				return false;
			}
						
			if ( !PercepcionIvaIsValid( row.PercepcionIva ) )
			{ 
				return false;
			}
						
			if ( !ImpuestosInternosIsValid( row.ImpuestosInternos ) )
			{ 
				return false;
			}
						
			if ( !TotalGeneralIsValid( row.TotalGeneral ) )
			{ 
				return false;
			}
						
			if ( !DescuentoGlobalIsValid( row.DescuentoGlobal ) )
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
		/// Valida el campo IdComprobanteCompra.
		/// </summary>
		public static bool IdComprobanteCompraIsValid( long IdComprobanteCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( long IdProveedor )
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
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaIngreso.
		/// </summary>
		public static bool FechaIngresoIsValid( DateTime FechaIngreso )
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
		/// Valida el campo NetoBruto.
		/// </summary>
		public static bool NetoBrutoIsValid( decimal NetoBruto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descuento.
		/// </summary>
		public static bool DescuentoIsValid( decimal Descuento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo SubtotalNeto.
		/// </summary>
		public static bool SubtotalNetoIsValid( decimal SubtotalNeto )
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
		/// Valida el campo MontosNoGravados.
		/// </summary>
		public static bool MontosNoGravadosIsValid( decimal MontosNoGravados )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecepcionIB.
		/// </summary>
		public static bool PrecepcionIBIsValid( decimal PrecepcionIB )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecepcionGanancias.
		/// </summary>
		public static bool PrecepcionGananciasIsValid( decimal PrecepcionGanancias )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PercepcionIva.
		/// </summary>
		public static bool PercepcionIvaIsValid( decimal PercepcionIva )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo ImpuestosInternos.
		/// </summary>
		public static bool ImpuestosInternosIsValid( decimal ImpuestosInternos )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo TotalGeneral.
		/// </summary>
		public static bool TotalGeneralIsValid( decimal TotalGeneral )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescuentoGlobal.
		/// </summary>
		public static bool DescuentoGlobalIsValid( decimal DescuentoGlobal )
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

