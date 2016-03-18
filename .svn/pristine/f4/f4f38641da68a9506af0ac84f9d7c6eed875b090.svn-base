

namespace mz.erp.businessrules
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesDet : IDisposable
	{
	
		#region Custom Members

		public static tpu_ComprobantesDetDataset GetList( string IdComprobante)
		{
			return mz.erp.dataaccess.tpu_ComprobantesDet.GetList( IdComprobante, string.Empty, long.MinValue) ;
		}

		public static tpu_ComprobantesDetDataset GetByPk( string IdComprobante) 
		{
			string IdProducto = String.Empty;
			long Ordinal = long.MinValue;
			return dataaccess.tpu_ComprobantesDet.GetList(IdComprobante, IdProducto, Ordinal);
		}
		public static tpu_ComprobantesDetDataset GetPendientes( string IdComprobante )
		{
			string IdProducto = String.Empty;
			long Ordinal = long.MinValue;
			return dataaccess.tpu_ComprobantesDet.ComprobantesPendientesDet(IdComprobante, Ordinal, IdProducto );

		}
		public static System.Data.DataSet GetPendientesDataset( string IdComprobante )
		{
			return (DataSet)GetPendientes(IdComprobante);
		}

		#endregion
		
		public tpu_ComprobantesDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesDet
		/// </summary>
		public static tpu_ComprobantesDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesDet.GetList();
		}

		/// <summary>
		/// Obtiene tabla tpu_ComprobantesDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesDetDataset GetList( string IdComprobante,  string IdProducto, long Ordinal)
		{
			return mz.erp.dataaccess.tpu_ComprobantesDet.GetList( IdComprobante, IdProducto, Ordinal) ;
		}

		/// <summary>
		/// Crea un tpu_ComprobantesDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ComprobantesDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow GetByPk( string IdComprobante, long Ordinal )
		{
			tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row = mz.erp.dataaccess.tpu_ComprobantesDet.GetByPk( IdComprobante, Ordinal  );
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
		/// Obtiene un registro de la tabla tpu_ComprobantesDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow GetByPk( object IdComprobante, object Ordinal )
		{
			return GetByPk( ( string )IdComprobante, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesDetRow.
		/// </summary>
		public static tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow SetRowDefaultValues( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.Ordinal = 0; 
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdProducto = string.Empty;
			row.Cantidad = 0;
			row.PrecioDeCosto = 0;
			row.ImpuestosDirectos = 0;
			row.ImpuestosIndirectos = 0;
			row.IdMonedaOrigen = string.Empty;
			row.IdMonedaCierre = string.Empty;
			row.IdCotizacionCierre = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.SetRowIdGeneradoNull();
			row.Bonificacion1MonedaOrigen = 0;
			row.Bonificacion2MonedaOrigen = 0;
			row.Bonificacion3MonedaOrigen = 0;
			row.Bonificacion4MonedaOrigen = 0;
			row.Bonificacion5MonedaOrigen = 0;
			row.PrecioDeCostoNetoMonedaOrigen = 0;
			row.PorcentajeBonificacion1 = 0;
			row.PorcentajeBonificacion2 = 0;
			row.PorcentajeBonificacion3 = 0;
			row.PorcentajeBonificacion4 = 0;
			row.PorcentajeBonificacion5 = 0;
			row.PrecioDeCostoMonedaOrigen = 0;
			row.Estado = string.Empty;

			
		

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesDet.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDetDataset.tpu_ComprobantesDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesDetDataset.tpu_ComprobantesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			
						
			
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !PrecioDeCostoIsValid( row.PrecioDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImpuestosDirectosIsValid( row.ImpuestosDirectos, out mensaje) )
			{ 
				row.SetColumnError( "ImpuestosDirectos" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImpuestosIndirectosIsValid( row.ImpuestosIndirectos, out mensaje) )
			{ 
				row.SetColumnError( "ImpuestosIndirectos" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaOrigenIsValid( row.IdMonedaOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaCierreIsValid( row.IdMonedaCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizacionCierreIsValid( row.IdCotizacionCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionCierre" , mensaje);
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
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
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
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante.
		/// </summary>
		
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad)
		{
			string mensaje;
			return CantidadIsValid( Cantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioFinal.
		/// </summary>
		
		/// <summary>
		/// Valida el campo PrecioDeCosto.
		/// </summary>
		public static bool PrecioDeCostoIsValid( decimal PrecioDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeCostoIsValid( decimal PrecioDeCosto)
		{
			string mensaje;
			return PrecioDeCostoIsValid( PrecioDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ImpuestosDirectos.
		/// </summary>
		public static bool ImpuestosDirectosIsValid( decimal ImpuestosDirectos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ImpuestosDirectos. Metodo Sobrecargado
		/// </summary>
		public static bool ImpuestosDirectosIsValid( decimal ImpuestosDirectos)
		{
			string mensaje;
			return ImpuestosDirectosIsValid( ImpuestosDirectos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ImpuestosIndirectos.
		/// </summary>
		public static bool ImpuestosIndirectosIsValid( decimal ImpuestosIndirectos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ImpuestosIndirectos. Metodo Sobrecargado
		/// </summary>
		public static bool ImpuestosIndirectosIsValid( decimal ImpuestosIndirectos)
		{
			string mensaje;
			return ImpuestosIndirectosIsValid( ImpuestosIndirectos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaOrigen.
		/// </summary>
		public static bool IdMonedaOrigenIsValid( string IdMonedaOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaOrigenIsValid( string IdMonedaOrigen)
		{
			string mensaje;
			return IdMonedaOrigenIsValid( IdMonedaOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaCierre.
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre)
		{
			string mensaje;
			return IdMonedaCierreIsValid( IdMonedaCierre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre.
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre)
		{
			string mensaje;
			return IdCotizacionCierreIsValid( IdCotizacionCierre, out mensaje );
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
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
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
