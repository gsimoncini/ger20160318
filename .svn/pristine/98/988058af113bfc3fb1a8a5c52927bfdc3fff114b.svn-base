namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_AplicacionPagos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_AplicacionPagos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_AplicacionPagos
		/// </summary>
		public static tsa_AplicacionPagosDataset GetList()
		{
			return mz.erp.dataaccess.tsa_AplicacionPagos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_AplicacionPagos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_AplicacionPagosDataset GetList( string IdComprobanteOrigen, short CuotaOrigen, decimal Importe, string IdTipoDeComprobanteDestino, string IdComprobanteDestino, short CuotaDestino )
		{
			return mz.erp.dataaccess.tsa_AplicacionPagos.GetList( IdComprobanteOrigen, CuotaOrigen, Importe, IdTipoDeComprobanteDestino, IdComprobanteDestino, CuotaDestino );
		}

		/// <summary>
		/// Crea un tsa_AplicacionPagosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_AplicacionPagos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_AplicacionPagos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow GetByPk( string IdComprobanteOrigen, short CuotaOrigen, string IdComprobanteDestino )
		{
			tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row = mz.erp.dataaccess.tsa_AplicacionPagos.GetByPk( IdComprobanteOrigen, CuotaOrigen, IdComprobanteDestino  );
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
		/// Obtiene un registro de la tabla tsa_AplicacionPagos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow GetByPk( object IdComprobanteOrigen, object CuotaOrigen,object  IdComprobanteDestino )
		{
			return GetByPk( ( string )IdComprobanteOrigen, ( short )CuotaOrigen, ( string )IdComprobanteDestino );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_AplicacionPagosRow.
		/// </summary>
		public static tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow SetRowDefaultValues( tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row )
		{
			row.IdComprobanteOrigen = Util.NewStringId(); 
			row.CuotaOrigen = 0; 
			row.IdComprobanteDestino = Util.NewStringId(); 
			row.IdTipoComprobanteOrigen = string.Empty;
			row.Importe = 0;
			row.IdTipoDeComprobanteDestino = string.Empty;
			row.CuotaDestino = 0;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_AplicacionPagosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_AplicacionPagosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_AplicacionPagosRow a la base de datos.
		/// </summary>
		public static void Update( tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_AplicacionPagos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_AplicacionPagosDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_AplicacionPagosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_AplicacionPagos.Rows.Count > 0, "La tabla dataSet.tsa_AplicacionPagosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_AplicacionPagos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_AplicacionPagosDataset.tsa_AplicacionPagosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_AplicacionPagosDataset.tsa_AplicacionPagosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_AplicacionPagos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_AplicacionPagosRow.
		/// </summary>
		public static bool RowIsValid( tsa_AplicacionPagosDataset.tsa_AplicacionPagosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoComprobanteOrigenIsValid( row.IdTipoComprobanteOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoComprobanteOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteOrigenIsValid( row.IdComprobanteOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !CuotaOrigenIsValid( row.CuotaOrigen, out mensaje) )
			{ 
				row.SetColumnError( "CuotaOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImporteIsValid( row.Importe, out mensaje) )
			{ 
				row.SetColumnError( "Importe" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteDestinoIsValid( row.IdTipoDeComprobanteDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobanteDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteDestinoIsValid( row.IdComprobanteDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !CuotaDestinoIsValid( row.CuotaDestino, out mensaje) )
			{ 
				row.SetColumnError( "CuotaDestino" , mensaje);
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
		/// Valida el campo IdTipoComprobanteOrigen.
		/// </summary>
		public static bool IdTipoComprobanteOrigenIsValid( string IdTipoComprobanteOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoComprobanteOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoComprobanteOrigenIsValid( string IdTipoComprobanteOrigen)
		{
			string mensaje;
			return IdTipoComprobanteOrigenIsValid( IdTipoComprobanteOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdComprobanteOrigen.
		/// </summary>
		public static bool IdComprobanteOrigenIsValid( string IdComprobanteOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobanteOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteOrigenIsValid( string IdComprobanteOrigen)
		{
			string mensaje;
			return IdComprobanteOrigenIsValid( IdComprobanteOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CuotaOrigen.
		/// </summary>
		public static bool CuotaOrigenIsValid( short CuotaOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CuotaOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool CuotaOrigenIsValid( short CuotaOrigen)
		{
			string mensaje;
			return CuotaOrigenIsValid( CuotaOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Importe.
		/// </summary>
		public static bool ImporteIsValid( decimal Importe , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Importe. Metodo Sobrecargado
		/// </summary>
		public static bool ImporteIsValid( decimal Importe)
		{
			string mensaje;
			return ImporteIsValid( Importe, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobanteDestino.
		/// </summary>
		public static bool IdTipoDeComprobanteDestinoIsValid( string IdTipoDeComprobanteDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobanteDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeComprobanteDestinoIsValid( string IdTipoDeComprobanteDestino)
		{
			string mensaje;
			return IdTipoDeComprobanteDestinoIsValid( IdTipoDeComprobanteDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdComprobanteDestino.
		/// </summary>
		public static bool IdComprobanteDestinoIsValid( string IdComprobanteDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobanteDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteDestinoIsValid( string IdComprobanteDestino)
		{
			string mensaje;
			return IdComprobanteDestinoIsValid( IdComprobanteDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CuotaDestino.
		/// </summary>
		public static bool CuotaDestinoIsValid( short CuotaDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CuotaDestino. Metodo Sobrecargado
		/// </summary>
		public static bool CuotaDestinoIsValid( short CuotaDestino)
		{
			string mensaje;
			return CuotaDestinoIsValid( CuotaDestino, out mensaje );
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


