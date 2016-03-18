namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_FacturasImpagas : IDisposable
	{
	
		#region Custom Members
		public static void GenerarListadoFacturasImpagas()
		{
			mz.erp.dataaccess.tsa_FacturasImpagas.GenerarListadoFacturasImpagas();
		}
		
		public static tsa_FacturasImpagasDataset GetList( string TiposDeComprobantes, string IdCuenta, DateTime EmisionDesde, DateTime EmisionHasta, DateTime VencimientoDesde, DateTime VencimientoHasta, bool PeriodosPorFechaEmision, int Periodo, bool PeriodosEnDias, bool PeriodosEnSemanas, bool PeriodosEnMeses, bool MostrarElResto)
		{
			return mz.erp.dataaccess.tsa_FacturasImpagas.GetList( TiposDeComprobantes, IdCuenta, EmisionDesde, EmisionHasta, VencimientoDesde, VencimientoHasta, PeriodosPorFechaEmision, Periodo, PeriodosEnDias, PeriodosEnSemanas, PeriodosEnMeses, MostrarElResto);
		}
		#endregion
		
		public tsa_FacturasImpagas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_FacturasImpagas
		/// </summary>
		public static tsa_FacturasImpagasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_FacturasImpagas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_FacturasImpagas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_FacturasImpagasDataset GetList( string IdCuenta, string IdComprobante, string IdTipoDeComprobante, DateTime FechaEmision, DateTime FechaVencimiento, string Vendedores, decimal Total, decimal SaldoFactura, string IdTiposComprobantesPredecesores, string IdOrdenReparaciones, decimal SaldoCtaCte, decimal SaldoCtaCteDV, decimal SaldoCtaCteConsolidado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			return mz.erp.dataaccess.tsa_FacturasImpagas.GetList( IdCuenta, IdComprobante, IdTipoDeComprobante, FechaEmision, FechaVencimiento, Vendedores, Total, SaldoFactura, IdTiposComprobantesPredecesores, IdOrdenReparaciones, SaldoCtaCte, SaldoCtaCteDV, SaldoCtaCteConsolidado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}

		/// <summary>
		/// Crea un tsa_FacturasImpagasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_FacturasImpagas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_FacturasImpagas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow GetByPk( string IdCuenta, string IdComprobante )
		{
			tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow row = mz.erp.dataaccess.tsa_FacturasImpagas.GetByPk( IdCuenta, IdComprobante  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_FacturasImpagas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow GetByPk( object IdCuenta, object IdComprobante )
		{
			return GetByPk( ( string )IdCuenta, ( string )IdComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_FacturasImpagasRow.
		/// </summary>
		public static tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow SetRowDefaultValues( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.IdComprobante = Util.NewStringId(); 
			row.IdTipoDeComprobante = string.Empty;
			row.FechaEmision = DateTime.Now;
			row.FechaVencimiento = DateTime.Now;
			row.Vendedores = string.Empty;
			row.Total = 0;
			row.SaldoFactura = 0;
			row.IdTiposComprobantesPredecesores = string.Empty;
			row.IdOrdenReparaciones = string.Empty;
			row.SaldoCtaCte = 0;
			row.SaldoCtaCteDV = 0;
			row.SaldoCtaCteConsolidado = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_FacturasImpagasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_FacturasImpagasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_FacturasImpagasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_FacturasImpagas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_FacturasImpagasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_FacturasImpagasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_FacturasImpagas.Rows.Count > 0, "La tabla dataSet.tsa_FacturasImpagasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_FacturasImpagas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_FacturasImpagasDataset.tsa_FacturasImpagasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_FacturasImpagasDataset.tsa_FacturasImpagasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_FacturasImpagas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_FacturasImpagasRow.
		/// </summary>
		public static bool RowIsValid( tsa_FacturasImpagasDataset.tsa_FacturasImpagasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaEmisionIsValid( row.FechaEmision, out mensaje) )
			{ 
				row.SetColumnError( "FechaEmision" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento, out mensaje) )
			{ 
				row.SetColumnError( "FechaVencimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !VendedoresIsValid( row.Vendedores, out mensaje) )
			{ 
				row.SetColumnError( "Vendedores" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalIsValid( row.Total, out mensaje) )
			{ 
				row.SetColumnError( "Total" , mensaje);
				isValid=false;
			
			}
						
			if ( !SaldoFacturaIsValid( row.SaldoFactura, out mensaje) )
			{ 
				row.SetColumnError( "SaldoFactura" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTiposComprobantesPredecesoresIsValid( row.IdTiposComprobantesPredecesores, out mensaje) )
			{ 
				row.SetColumnError( "IdTiposComprobantesPredecesores" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdOrdenReparacionesIsValid( row.IdOrdenReparaciones, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !SaldoCtaCteIsValid( row.SaldoCtaCte, out mensaje) )
			{ 
				row.SetColumnError( "SaldoCtaCte" , mensaje);
				isValid=false;
			
			}
						
			if ( !SaldoCtaCteDVIsValid( row.SaldoCtaCteDV, out mensaje) )
			{ 
				row.SetColumnError( "SaldoCtaCteDV" , mensaje);
				isValid=false;
			
			}
						
			if ( !SaldoCtaCteConsolidadoIsValid( row.SaldoCtaCteConsolidado, out mensaje) )
			{ 
				row.SetColumnError( "SaldoCtaCteConsolidado" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdComprobante.
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante)
		{
			string mensaje;
			return IdComprobanteIsValid( IdComprobante, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante.
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante)
		{
			string mensaje;
			return IdTipoDeComprobanteIsValid( IdTipoDeComprobante, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaEmision.
		/// </summary>
		public static bool FechaEmisionIsValid( DateTime FechaEmision , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaEmision. Metodo Sobrecargado
		/// </summary>
		public static bool FechaEmisionIsValid( DateTime FechaEmision)
		{
			string mensaje;
			return FechaEmisionIsValid( FechaEmision, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento. Metodo Sobrecargado
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento)
		{
			string mensaje;
			return FechaVencimientoIsValid( FechaVencimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Vendedores.
		/// </summary>
		public static bool VendedoresIsValid( string Vendedores , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Vendedores. Metodo Sobrecargado
		/// </summary>
		public static bool VendedoresIsValid( string Vendedores)
		{
			string mensaje;
			return VendedoresIsValid( Vendedores, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Total.
		/// </summary>
		public static bool TotalIsValid( decimal Total , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Total. Metodo Sobrecargado
		/// </summary>
		public static bool TotalIsValid( decimal Total)
		{
			string mensaje;
			return TotalIsValid( Total, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo SaldoFactura.
		/// </summary>
		public static bool SaldoFacturaIsValid( decimal SaldoFactura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo SaldoFactura. Metodo Sobrecargado
		/// </summary>
		public static bool SaldoFacturaIsValid( decimal SaldoFactura)
		{
			string mensaje;
			return SaldoFacturaIsValid( SaldoFactura, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTiposComprobantesPredecesores.
		/// </summary>
		public static bool IdTiposComprobantesPredecesoresIsValid( string IdTiposComprobantesPredecesores , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTiposComprobantesPredecesores. Metodo Sobrecargado
		/// </summary>
		public static bool IdTiposComprobantesPredecesoresIsValid( string IdTiposComprobantesPredecesores)
		{
			string mensaje;
			return IdTiposComprobantesPredecesoresIsValid( IdTiposComprobantesPredecesores, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdOrdenReparaciones.
		/// </summary>
		public static bool IdOrdenReparacionesIsValid( string IdOrdenReparaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparaciones. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdenReparacionesIsValid( string IdOrdenReparaciones)
		{
			string mensaje;
			return IdOrdenReparacionesIsValid( IdOrdenReparaciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo SaldoCtaCte.
		/// </summary>
		public static bool SaldoCtaCteIsValid( decimal SaldoCtaCte , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo SaldoCtaCte. Metodo Sobrecargado
		/// </summary>
		public static bool SaldoCtaCteIsValid( decimal SaldoCtaCte)
		{
			string mensaje;
			return SaldoCtaCteIsValid( SaldoCtaCte, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo SaldoCtaCteDV.
		/// </summary>
		public static bool SaldoCtaCteDVIsValid( decimal SaldoCtaCteDV , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo SaldoCtaCteDV. Metodo Sobrecargado
		/// </summary>
		public static bool SaldoCtaCteDVIsValid( decimal SaldoCtaCteDV)
		{
			string mensaje;
			return SaldoCtaCteDVIsValid( SaldoCtaCteDV, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo SaldoCtaCteConsolidado.
		/// </summary>
		public static bool SaldoCtaCteConsolidadoIsValid( decimal SaldoCtaCteConsolidado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo SaldoCtaCteConsolidado. Metodo Sobrecargado
		/// </summary>
		public static bool SaldoCtaCteConsolidadoIsValid( decimal SaldoCtaCteConsolidado)
		{
			string mensaje;
			return SaldoCtaCteConsolidadoIsValid( SaldoCtaCteConsolidado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion)
		{
			string mensaje;
			return FechaCreacionIsValid( FechaCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion)
		{
			string mensaje;
			return IdConexionCreacionIsValid( IdConexionCreacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion)
		{
			string mensaje;
			return UltimaModificacionIsValid( UltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion)
		{
			string mensaje;
			return IdConexionUltimaModificacionIsValid( IdConexionUltimaModificacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId. Metodo Sobrecargado
		/// </summary>
		public static bool RowIdIsValid( Guid RowId)
		{
			string mensaje;
			return RowIdIsValid( RowId, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

