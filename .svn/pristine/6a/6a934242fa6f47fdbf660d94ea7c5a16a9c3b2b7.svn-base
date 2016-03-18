namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobantesAutorizaciones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_ComprobantesAutorizaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobantesAutorizaciones
		/// </summary>
		public static tsa_ComprobantesAutorizacionesDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComprobantesAutorizaciones filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsa_ComprobantesAutorizacionesDataset GetList(  )
		{
			return mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsa_ComprobantesAutorizacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobantesAutorizaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow GetByPk( string IdComprobante )
		{
			tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow row = mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.GetByPk( IdComprobante  );
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
		/// Obtiene un registro de la tabla tsa_ComprobantesAutorizaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow GetByPk( object IdComprobante )
		{
			return GetByPk( ( string )IdComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobantesAutorizacionesRow.
		/// </summary>
		public static tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow SetRowDefaultValues( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdComprobanteAutorizacion = string.Empty;
			row.IdAutorizacion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			//row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesAutorizacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesAutorizacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesAutorizacionesRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobantesAutorizacionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesAutorizacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobantesAutorizaciones.Rows.Count > 0, "La tabla dataSet.tsa_ComprobantesAutorizacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesAutorizaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobantesAutorizacionesRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobantesAutorizacionesDataset.tsa_ComprobantesAutorizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteAutorizacionIsValid( row.IdComprobanteAutorizacion, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteAutorizacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdAutorizacionIsValid( row.IdAutorizacion, out mensaje) )
			{ 
				row.SetColumnError( "IdAutorizacion" , mensaje);
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
		/// Valida el campo IdComprobanteAutorizacion.
		/// </summary>
		public static bool IdComprobanteAutorizacionIsValid( string IdComprobanteAutorizacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobanteAutorizacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteAutorizacionIsValid( string IdComprobanteAutorizacion)
		{
			string mensaje;
			return IdComprobanteAutorizacionIsValid( IdComprobanteAutorizacion, out mensaje );
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
		/// Valida el campo IdAutorizacion.
		/// </summary>
		public static bool IdAutorizacionIsValid( string IdAutorizacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdAutorizacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdAutorizacionIsValid( string IdAutorizacion)
		{
			string mensaje;
			return IdAutorizacionIsValid( IdAutorizacion, out mensaje );
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

