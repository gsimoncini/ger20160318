namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesDeCompraDetConfirmacionDePrecios : IDisposable
	{
	
		#region Custom Members



		
		#endregion
		
		public tpu_ComprobantesDeCompraDetConfirmacionDePrecios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesDeCompraDetConfirmacionDePrecios
		/// </summary>
		public static tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesDeCompraDetConfirmacionDePrecios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset GetList( string IdComprobante, string IdProducto, long Ordinal )
		{
			return mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetList( IdComprobante, IdProducto, Ordinal );
		}

		/// <summary>
		/// Crea un tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDeCompraDetConfirmacionDePrecios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow GetByPk( string IdComprobante, long Ordinal )
		{
			tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row = mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.GetByPk( IdComprobante, Ordinal  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesDeCompraDetConfirmacionDePrecios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow GetByPk( object IdComprobante, long Ordinal )
		{
			return GetByPk( ( string )IdComprobante, (long) Ordinal);
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow.
		/// </summary>
		public static tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow SetRowDefaultValues( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdComprobanteOrdenDeCompra = Util.NewStringId(); 
			row.Estado = "P";
			row.IdProducto = string.Empty;
			row.Ordinal = 0;
			row.OrdinalOrdenDeCompra = 0;
			row.CantidadOrdenDeCompra = 0;
			row.CantidadFactura= 0;
			row.CantidadReal= 0;
			row.PrecioDeCostoOrdenDeCompra = 0;
			row.PrecioDeCostoFactura = 0;
			row.PrecioDeCostoReal = 0;
			row.IdMoneda = string.Empty;
			row.IdFuenteDeCambio = string.Empty;
			row.IdCotizacion = string.Empty;
			row.ValorCotizacion = 0;
			row.Observaciones = string.Empty;
			row.IdMotivoDiferencia = 0;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.TieneDiferenciaPorCantidad = false;
			row.TieneDiferenciaPorCotizacion = false;
			row.TieneDiferenciaPorPrecio = false;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesDeCompraDetConfirmacionDePrecios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesDeCompraDetConfirmacionDePreciosDataset.tpu_ComprobantesDeCompraDetConfirmacionDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.CantidadOrdenDeCompra, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadOriginalIsValid( row.CantidadFactura, out mensaje) )
			{ 
				row.SetColumnError( "CantidadOriginal" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeCostoIsValid( row.PrecioDeCostoOrdenDeCompra, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeCostoOriginalIsValid( row.PrecioDeCostoFactura, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCostoOriginal" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMotivoDiferenciaIsValid( row.IdMotivoDiferencia, out mensaje) )
			{ 
				row.SetColumnError( "IdMotivoDiferencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionCreacion" , mensaje);
				isValid=false;
			
			}
				/*		
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
			*/
						
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
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
		/// Valida el campo CantidadOriginal.
		/// </summary>
		public static bool CantidadOriginalIsValid( decimal CantidadOriginal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CantidadOriginal. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadOriginalIsValid( decimal CantidadOriginal)
		{
			string mensaje;
			return CantidadOriginalIsValid( CantidadOriginal, out mensaje );
		}		
		
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
		/// Valida el campo PrecioDeCostoOriginal.
		/// </summary>
		public static bool PrecioDeCostoOriginalIsValid( decimal PrecioDeCostoOriginal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeCostoOriginal. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeCostoOriginalIsValid( decimal PrecioDeCostoOriginal)
		{
			string mensaje;
			return PrecioDeCostoOriginalIsValid( PrecioDeCostoOriginal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMotivoDiferencia.
		/// </summary>
		public static bool IdMotivoDiferenciaIsValid( long IdMotivoDiferencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMotivoDiferencia. Metodo Sobrecargado
		/// </summary>
		public static bool IdMotivoDiferenciaIsValid( long IdMotivoDiferencia)
		{
			string mensaje;
			return IdMotivoDiferenciaIsValid( IdMotivoDiferencia, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

