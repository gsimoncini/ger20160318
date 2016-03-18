namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_FormasDePago : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_FormasDePago()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_FormasDePago
		/// </summary>
		public static tfi_FormasDePagoDataset GetList()
		{
			return mz.erp.dataaccess.tfi_FormasDePago.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_FormasDePago filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_FormasDePagoDataset GetList( string IdTDCompTesoreria, string IdMoneda, string IdEntidad, short Cuotas )
		{
			return mz.erp.dataaccess.tfi_FormasDePago.GetList( IdTDCompTesoreria, IdMoneda, IdEntidad, Cuotas );
		}

		/// <summary>
		/// Crea un tfi_FormasDePagoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_FormasDePagoDataset.tfi_FormasDePagoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_FormasDePago.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_FormasDePago que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_FormasDePagoDataset.tfi_FormasDePagoRow GetByPk( string IdFormaDePago )
		{
			tfi_FormasDePagoDataset.tfi_FormasDePagoRow row = mz.erp.dataaccess.tfi_FormasDePago.GetByPk( IdFormaDePago  );
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
		/// Obtiene un registro de la tabla tfi_FormasDePago que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_FormasDePagoDataset.tfi_FormasDePagoRow GetByPk( object IdFormaDePago )
		{
			return GetByPk( ( string )IdFormaDePago );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_FormasDePagoRow.
		/// </summary>
		public static tfi_FormasDePagoDataset.tfi_FormasDePagoRow SetRowDefaultValues( tfi_FormasDePagoDataset.tfi_FormasDePagoRow row )
		{
			row.IdFormaDePago = Util.NewStringId(); 
			row.IdTDCompTesoreria = string.Empty;
			row.IdMoneda = string.Empty;
			row.IdEntidad = string.Empty;
			row.Cuotas = 0;
			row.Recargo = 0;
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
		
		/// <summary>
		/// Envia los cambios del tfi_FormasDePagoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_FormasDePagoDataset.tfi_FormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FormasDePagoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_FormasDePagoDataset.tfi_FormasDePagoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FormasDePagoRow a la base de datos.
		/// </summary>
		public static void Update( tfi_FormasDePagoDataset.tfi_FormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_FormasDePago.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_FormasDePagoDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_FormasDePagoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_FormasDePago.Rows.Count > 0, "La tabla dataSet.tfi_FormasDePagoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_FormasDePago.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FormasDePagoDataset.tfi_FormasDePagoDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_FormasDePagoDataset.tfi_FormasDePagoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_FormasDePago.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_FormasDePagoRow.
		/// </summary>
		public static bool RowIsValid( tfi_FormasDePagoDataset.tfi_FormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEntidadIsValid( row.IdEntidad, out mensaje) )
			{ 
				row.SetColumnError( "IdEntidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !CuotasIsValid( row.Cuotas, out mensaje) )
			{ 
				row.SetColumnError( "Cuotas" , mensaje);
				isValid=false;
			
			}
						
			if ( !RecargoIsValid( row.Recargo, out mensaje) )
			{ 
				row.SetColumnError( "Recargo" , mensaje);
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
						
			if ( !IdFormaDePagoIsValid( row.IdFormaDePago, out mensaje) )
			{ 
				row.SetColumnError( "IdFormaDePago" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
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
		/// Valida el campo IdEntidad.
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEntidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad)
		{
			string mensaje;
			return IdEntidadIsValid( IdEntidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cuotas.
		/// </summary>
		public static bool CuotasIsValid( short Cuotas , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cuotas. Metodo Sobrecargado
		/// </summary>
		public static bool CuotasIsValid( short Cuotas)
		{
			string mensaje;
			return CuotasIsValid( Cuotas, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Recargo.
		/// </summary>
		public static bool RecargoIsValid( decimal Recargo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Recargo. Metodo Sobrecargado
		/// </summary>
		public static bool RecargoIsValid( decimal Recargo)
		{
			string mensaje;
			return RecargoIsValid( Recargo, out mensaje );
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
		}		
		
		/// <summary>
		/// Valida el campo IdFormaDePago.
		/// </summary>
		public static bool IdFormaDePagoIsValid( string IdFormaDePago , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFormaDePago. Metodo Sobrecargado
		/// </summary>
		public static bool IdFormaDePagoIsValid( string IdFormaDePago)
		{
			string mensaje;
			return IdFormaDePagoIsValid( IdFormaDePago, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}



