namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobanteDetalleEstadoItems : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_ComprobanteDetalleEstadoItems()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobanteDetalleEstadoItems
		/// </summary>
		public static tsa_ComprobanteDetalleEstadoItemsDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComprobanteDetalleEstadoItems filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobanteDetalleEstadoItemsDataset GetList( string IdComprobante, long Ordinal, decimal Cantidad, DateTime Fecha, string IdEstado )
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.GetList( IdComprobante, Ordinal, Cantidad, Fecha, IdEstado );
		}

		/// <summary>
		/// Crea un tsa_ComprobanteDetalleEstadoItemsRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.NewRow());
		}
		
		public static tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow NewRow(tsa_ComprobanteDetalleEstadoItemsDataset data)
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.NewRow(data));
		}
		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleEstadoItems que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow GetByPk( string IdComprobante, long Ordinal, DateTime Fecha, string IdEstado )
		{
		   tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row = mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.GetByPk( IdComprobante, Ordinal, Fecha, IdEstado  );
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
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleEstadoItems que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow GetByPk( object IdComprobante, long Ordinal, System.DateTime Fecha, string IdEstado )
		{
			return GetByPk( ( string )IdComprobante, ( long )Ordinal, ( DateTime )Fecha, ( string )IdEstado );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobanteDetalleEstadoItemsRow.
		/// </summary>
		public static tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow SetRowDefaultValues( tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.Ordinal = 0; 
			row.Fecha = mz.erp.businessrules.Sistema.DateTime.Now; 
			row.IdEstado = Util.NewStringId(); 
			row.Cantidad = 0;
			row.Observaciones = string.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleEstadoItemsRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleEstadoItemsRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow )row );
		}
		
		public static void Update( tsa_ComprobanteDetalleEstadoItemsDataset data , SentenciasReplicacion replicacion, string IdTransaction)
		{
			mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.Update( data.tsa_ComprobanteDetalleEstadoItems, replicacion, IdTransaction );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleEstadoItemsRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleEstadoItemsDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleEstadoItemsDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobanteDetalleEstadoItems.Rows.Count > 0, "La tabla dataSet.tsa_ComprobanteDetalleEstadoItemsDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobantesDetalleEstadoItemsDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleEstadoItems.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobantesDetalleEstadoItemsRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobanteDetalleEstadoItemsDataset.tsa_ComprobanteDetalleEstadoItemsRow row )
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
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoIsValid( row.IdEstado, out mensaje) )
			{ 
				row.SetColumnError( "IdEstado" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
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
			/*			
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
			;*/
			
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
		/// Valida el campo IdEstado.
		/// </summary>
		public static bool IdEstadoIsValid( string IdEstado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstado. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoIsValid( string IdEstado)
		{
			string mensaje;
			return IdEstadoIsValid( IdEstado, out mensaje );
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

