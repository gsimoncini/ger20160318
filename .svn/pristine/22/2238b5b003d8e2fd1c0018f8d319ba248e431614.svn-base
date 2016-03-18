namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobantesDetAuxiliares : IDisposable
	{
	
		#region Custom Members

		public static tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow GetByPk( string IdComprobante, long Ordinal, string IdTransaction )
		{
			tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow row = mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.GetByPk( IdComprobante, Ordinal, IdTransaction  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}			
			}
			return row;

		}
		
		#endregion
		
		public tsa_ComprobantesDetAuxiliares()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobantesDetAuxiliares
		/// </summary>
		public static tsa_ComprobantesDetAuxiliaresDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComprobantesDetAuxiliares filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsa_ComprobantesDetAuxiliaresDataset GetList(  )
		{
			return mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsa_ComprobantesDetAuxiliaresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobantesDetAuxiliares que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow GetByPk( string IdComprobante, long Ordinal )
		{
			tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow row = mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.GetByPk( IdComprobante, Ordinal  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}			
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobantesDetAuxiliares que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow GetByPk( object IdComprobante, long Ordinal )
		{
			return GetByPk( ( string )IdComprobante, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobantesDetAuxiliaresRow.
		/// </summary>
		public static tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow SetRowDefaultValues( tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.Ordinal = 0; 
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.ContadorOrigen = 0;
			row.ContadorDestino = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.Visible = false;
			row.IdOrdenReparacion = 0;
			row.IdInstanciaOrdenReparacion = 0;
			row.IdTareaRealizada = 0;
			row.IdRepuestoOrdenReparacion = 0;
			row.IdComprobantesPredecesores = string.Empty;
			row.IdComprobantesSucesores = string.Empty;
			row.IdTiposComprobantesPredecesores = string.Empty;
			row.IdTiposComprobantesSucesores = string.Empty;
			row.IdResponsableOrigen=string.Empty;
			row.Equipo=0;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetAuxiliaresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetAuxiliaresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetAuxiliaresRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetAuxiliaresDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesDetAuxiliaresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobantesDetAuxiliares.Rows.Count > 0, "La tabla dataSet.tsa_ComprobantesDetAuxiliaresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobantesDetAuxiliares.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobantesDetAuxiliaresRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobantesDetAuxiliaresDataset.tsa_ComprobantesDetAuxiliaresRow row )
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
						
			if ( !ContadorOrigenIsValid( row.ContadorOrigen, out mensaje) )
			{ 
				row.SetColumnError( "ContadorOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !ContadorDestinoIsValid( row.ContadorDestino, out mensaje) )
			{ 
				row.SetColumnError( "ContadorDestino" , mensaje);
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
						
			if ( !VisibleIsValid( row.Visible, out mensaje) )
			{ 
				row.SetColumnError( "Visible" , mensaje);
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
		/// Valida el campo ContadorOrigen.
		/// </summary>
		public static bool ContadorOrigenIsValid( long ContadorOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ContadorOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool ContadorOrigenIsValid( long ContadorOrigen)
		{
			string mensaje;
			return ContadorOrigenIsValid( ContadorOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ContadorDestino.
		/// </summary>
		public static bool ContadorDestinoIsValid( long ContadorDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ContadorDestino. Metodo Sobrecargado
		/// </summary>
		public static bool ContadorDestinoIsValid( long ContadorDestino)
		{
			string mensaje;
			return ContadorDestinoIsValid( ContadorDestino, out mensaje );
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
		/// Valida el campo Visible.
		/// </summary>
		public static bool VisibleIsValid( bool Visible , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Visible. Metodo Sobrecargado
		/// </summary>
		public static bool VisibleIsValid( bool Visible)
		{
			string mensaje;
			return VisibleIsValid( Visible, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

