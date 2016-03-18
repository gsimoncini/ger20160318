namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_InstanciasCajaCierres : IDisposable
	{
	
		#region Custom Members
		

		public static tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresRow SetRowDefaultValues( tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresRow row )
		{
			row.IdInstanciaCaja = Util.NewStringId(); 
			row.IdTDCompTesoreria = Util.NewStringId(); 
			row.Total = 0;
			row.IdMonedaCierre = string.Empty;
			row.IdCotizacionCierre = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}

		public static tfi_InstanciasCajaExDataset.tfi_InstanciasCajaCierresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_InstanciasCajaCierres.NewRow());
		}


		#endregion
		
		public tfi_InstanciasCajaCierres()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_InstanciasCajaCierres
	/*	/// </summary>
		public static tfi_InstanciasCajaCierresDataset GetList()
		{
			return mz.erp.dataaccess.tfi_InstanciasCajaCierres.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_InstanciasCajaCierres filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_InstanciasCajaCierresDataset GetList( string IdInstanciaCaja, string IdTDCompTesoreria, decimal Total, string IdMonedaCierre, string IdCotizacionCierre )
		{
			return mz.erp.dataaccess.tfi_InstanciasCajaCierres.GetList( IdInstanciaCaja, IdTDCompTesoreria, Total, IdMonedaCierre, IdCotizacionCierre );
		}

		/// <summary>
		/// Crea un tfi_InstanciasCajaCierresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_InstanciasCajaCierres.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_InstanciasCajaCierres que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow GetByPk( string IdInstanciaCaja, string IdTDCompTesoreria )
		{
			tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow row = mz.erp.dataaccess.tfi_InstanciasCajaCierres.GetByPk( IdInstanciaCaja, IdTDCompTesoreria  );
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
		/// Obtiene un registro de la tabla tfi_InstanciasCajaCierres que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow GetByPk( object IdInstanciaCaja, object IdTDCompTesoreria )
		{
			return GetByPk( ( string )IdInstanciaCaja, ( string )IdTDCompTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_InstanciasCajaCierresRow.
		/// </summary>
		public static tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow SetRowDefaultValues( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow row )
		{
			row.IdInstanciaCaja = Util.NewStringId(); 
			row.IdTDCompTesoreria = Util.NewStringId(); 
			row.Total = 0;
			row.IdMonedaCierre = string.Empty;
			row.IdCotizacionCierre = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaCierresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaCierresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaCierresRow a la base de datos.
		/// </summary>
		public static void Update( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCajaCierres.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaCierresDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_InstanciasCajaCierresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_InstanciasCajaCierres.Rows.Count > 0, "La tabla dataSet.tfi_InstanciasCajaCierresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCajaCierres.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_InstanciasCajaCierres.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_InstanciasCajaCierresRow.
		/// </summary>
		public static bool RowIsValid( tfi_InstanciasCajaCierresDataset.tfi_InstanciasCajaCierresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
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
			;
			
			return isValid;
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
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria)
		{
			string mensaje;
			return IdTDCompTesoreriaIsValid( IdTDCompTesoreria, out mensaje );
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
		}		*/
		

		public void Dispose()
		{
		}
		
	}
}




