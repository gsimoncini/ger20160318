namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;	

	public class tfi_MovimientosDeCaja : IDisposable
	{
	
		#region Custom Members
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaDataset data, string  IdTransaction, SentenciasReplicacion replicacion)
		{						
			mz.erp.dataaccess.tfi_MovimientosDeCaja.Update( (DataTable) data.tfi_MovimientosDeCaja, IdTransaction , replicacion );
		}	

		public static tfi_MovimientosDeCajaDataset GetByTipo(string Key)
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCaja.GetByTipo(Key);
		}

		public static tfi_MovimientosDeCajaDataset GetBySubTipo(string Key)
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCaja.GetBySubTipo(Key);
		}

		#endregion
		
		public tfi_MovimientosDeCaja()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_MovimientosDeCaja
		/// </summary>
		public static tfi_MovimientosDeCajaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCaja.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_MovimientosDeCaja filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_MovimientosDeCajaDataset GetList( string IdInstanciaCaja, string IdTipoDeMovimiento, string IdSubTipoMovimiento, string TipoComprobante, string Numero, DateTime Fecha, string IdResponsable, decimal Total, string IdMonedaCierre, string IdAceptacion )
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCaja.GetList( IdInstanciaCaja, IdTipoDeMovimiento, IdSubTipoMovimiento, TipoComprobante, Numero, Fecha, IdResponsable, Total, IdMonedaCierre, IdAceptacion );
		}

		/// <summary>
		/// Crea un tfi_MovimientosDeCajaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_MovimientosDeCaja.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_MovimientosDeCaja que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow GetByPk( string IdMovimiento )
		{
			tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow row = mz.erp.dataaccess.tfi_MovimientosDeCaja.GetByPk( IdMovimiento  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					if (dc.Caption != "RowId" ) 
					{ 
						row[dc] = Util.DefaultValue( dc.DataType ); 
					}					
				}
			}
			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_MovimientosDeCaja que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow GetByPk( object IdMovimiento )
		{
			return GetByPk( ( string )IdMovimiento );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_MovimientosDeCajaRow.
		/// </summary>
		public static tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow SetRowDefaultValues( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow row )
		{
			row.IdMovimiento = Util.NewStringId(); 
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdInstanciaCaja = string.Empty;
			row.IdTipoDeMovimiento = string.Empty;
			row.IdSubTipoMovimiento = string.Empty;
			row.Numero = string.Empty;
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdResponsable = string.Empty;
			row.Total = 0;
			row.Observaciones = string.Empty;
			row.IdMonedaCierre = string.Empty;
			row.IdCotizacionCierre = string.Empty;
			row.IdAceptacion = string.Empty;

			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientosDeCaja.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_MovimientosDeCaja.Rows.Count > 0, "La tabla dataSet.tfi_MovimientosDeCajaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientosDeCaja.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientosDeCaja.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_MovimientosDeCajaRow.
		/// </summary>
		public static bool RowIsValid( tfi_MovimientosDeCajaDataset.tfi_MovimientosDeCajaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoIsValid( row.IdMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimiento" , mensaje);
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
						
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeMovimientoIsValid( row.IdTipoDeMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeMovimiento" , mensaje);
				isValid=false;
			
			}
			
			if ( !IdSubTipoMovimientoIsValid( row.IdSubTipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdSubTipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalIsValid( row.Total, out mensaje) )
			{ 
				row.SetColumnError( "Total" , mensaje);
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
			
			if ( !IdAceptacionIsValid( row.IdAceptacion, out mensaje) )
			{ 
				row.SetColumnError( "IdAceptacion" , mensaje);
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
		/// Valida el campo IdMovimiento.
		/// </summary>
		public static bool IdMovimientoIsValid( string IdMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoIsValid( string IdMovimiento)
		{
			string mensaje;
			return IdMovimientoIsValid( IdMovimiento, out mensaje );
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
		/// Valida el campo IdInstanciaCaja.
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja)
		{
			string mensaje;
			return IdInstanciaCajaIsValid( IdInstanciaCaja, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeMovimiento.
		/// </summary>
		public static bool IdTipoDeMovimientoIsValid( string IdTipoDeMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		/// Valida el campo IdTipoDeMovimiento.
		/// </summary>
		public static bool IdSubTipoMovimientoIsValid( string IdSubTipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		/// <summary>
		/// Valida el campo IdTipoDeMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeMovimientoIsValid( string IdTipoDeMovimiento)
		{
			string mensaje;
			return IdTipoDeMovimientoIsValid( IdTipoDeMovimiento, out mensaje );
		}		
		public static bool IdSubTipoMovimientoIsValid( string IdSubTipoMovimiento)
		{
			string mensaje;
			return IdSubTipoMovimientoIsValid( IdSubTipoMovimiento, out mensaje );
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
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha. Metodo Sobrecargado
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha)
		{
			string mensaje;
			return FechaIsValid( Fecha, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable)
		{
			string mensaje;
			return IdResponsableIsValid( IdResponsable, out mensaje );
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
		/// Valida el campo idAceptacion.
		/// </summary>
		public static bool IdAceptacionIsValid( string IdAceptacion , out string mensaje )
		{
			mensaje="";
			return true;
		}
		/// <summary>
		/// Valida el campo IdAceptacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdAceptacionIsValid( string IdAceptacion)
		{
			string mensaje;
			return IdAceptacionIsValid( IdAceptacion, out mensaje );
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

