namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobanteDetalleDePagos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_ComprobanteDetalleDePagos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobanteDetalleDePagos
		/// </summary>
		public static tsa_ComprobanteDetalleDePagosDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComprobanteDetalleDePagos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobanteDetalleDePagosDataset GetList( string IdTipoDeComprobante, string Numero, string IdComprobante, string IdValor, decimal Monto )
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.GetList( IdTipoDeComprobante, Numero, IdComprobante, IdValor, Monto );
		}

		/// <summary>
		/// Crea un tsa_ComprobanteDetalleDePagosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleDePagos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow GetByPk( string IdComprobante, string IdValor )
		{
			tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow row = mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.GetByPk( IdComprobante, IdValor  );
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
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleDePagos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow GetByPk( object IdComprobante, string IdValor )
		{
			return GetByPk( ( string )IdComprobante, ( string )IdValor );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobanteDetalleDePagosRow.
		/// </summary>
		public static tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow SetRowDefaultValues( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdValor = Util.NewStringId(); 
			row.IdTipoDeComprobante = string.Empty;
			row.Numero = string.Empty;
			row.Monto = 0;
			row.IdMoneda = string.Empty;
			row.IdCotizaicon = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdFormaDePago = null;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDePagosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDePagosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDePagosRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDePagosDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDePagosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobanteDetalleDePagos.Rows.Count > 0, "La tabla dataSet.tsa_ComprobanteDetalleDePagosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDePagos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobanteDetalleDePagosRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobanteDetalleDePagosDataset.tsa_ComprobanteDetalleDePagosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdValorIsValid( row.IdValor, out mensaje) )
			{ 
				row.SetColumnError( "IdValor" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoIsValid( row.Monto, out mensaje) )
			{ 
				row.SetColumnError( "Monto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizaiconIsValid( row.IdCotizaicon, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizaicon" , mensaje);
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
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroIsValid( string Numero)
		{
			string mensaje;
			return NumeroIsValid( Numero, out mensaje );
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
		/// Valida el campo IdValor.
		/// </summary>
		public static bool IdValorIsValid( string IdValor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValor. Metodo Sobrecargado
		/// </summary>
		public static bool IdValorIsValid( string IdValor)
		{
			string mensaje;
			return IdValorIsValid( IdValor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Monto.
		/// </summary>
		public static bool MontoIsValid( decimal Monto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Monto. Metodo Sobrecargado
		/// </summary>
		public static bool MontoIsValid( decimal Monto)
		{
			string mensaje;
			return MontoIsValid( Monto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda)
		{
			string mensaje;
			return IdMonedaIsValid( IdMoneda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizaicon.
		/// </summary>
		public static bool IdCotizaiconIsValid( string IdCotizaicon , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizaicon. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizaiconIsValid( string IdCotizaicon)
		{
			string mensaje;
			return IdCotizaiconIsValid( IdCotizaicon, out mensaje );
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


