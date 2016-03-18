using System;

namespace mz.erp.businessrules
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesRelacionOrigenDestino : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_ComprobantesRelacionOrigenDestino()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesRelacionOrigenDestino
		/// </summary>
		public static tpu_ComprobantesRelacionOrigenDestinoDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesRelacionOrigenDestino filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesRelacionOrigenDestinoDataset GetList( string IdComprobanteOrigen, string IdComprobanteDestino)
		{
			return mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.GetList( IdComprobanteOrigen, IdComprobanteDestino );
		}

		/// <summary>
		/// Crea un tpu_ComprobantesRelacionOrigenDestinoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesRelacionOrigenDestino que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow GetByPk( string IdComprobanteOrigen, string IdComprobanteDestino )
		{
			tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row = mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.GetByPk( IdComprobanteOrigen, IdComprobanteDestino  );
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
		/// Obtiene un registro de la tabla tpu_ComprobantesRelacionOrigenDestino que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow GetByPk( object IdComprobanteOrigen, object IdComprobanteDestino )
		{
			return GetByPk( ( string )IdComprobanteOrigen, ( string )IdComprobanteDestino );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesRelacionOrigenDestinoRow.
		/// </summary>
		public static tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow SetRowDefaultValues( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row )
		{
			row.IdComprobanteOrigen = Util.NewStringId(); 
			row.IdComprobanteDestino = Util.NewStringId(); 
			row.IdOrdinalOrigen = 0;
			row.IdOrdinalDestino = 0;
			row.Cantidad = 0;
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
		/// Envia los cambios del tpu_ComprobantesRelacionOrigenDestinoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRelacionOrigenDestinoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRelacionOrigenDestinoRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRelacionOrigenDestinoDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesRelacionOrigenDestinoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesRelacionOrigenDestino.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesRelacionOrigenDestinoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesRelacionOrigenDestino.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesRelacionOrigenDestinoRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesRelacionOrigenDestinoDataset.tpu_ComprobantesRelacionOrigenDestinoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteOrigenIsValid( row.IdComprobanteOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteDestinoIsValid( row.IdComprobanteDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdOrdinalOrigenIsValid( row.IdOrdinalOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdinalOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdOrdinalDestinoIsValid( row.IdOrdinalDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdinalDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
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
		/// Valida el campo IdOrdinalOrigen.
		/// </summary>
		public static bool IdOrdinalOrigenIsValid( long IdOrdinalOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdinalOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdinalOrigenIsValid( long IdOrdinalOrigen)
		{
			string mensaje;
			return IdOrdinalOrigenIsValid( IdOrdinalOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdOrdinalDestino.
		/// </summary>
		public static bool IdOrdinalDestinoIsValid( long IdOrdinalDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdinalDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdinalDestinoIsValid( long IdOrdinalDestino)
		{
			string mensaje;
			return IdOrdinalDestinoIsValid( IdOrdinalDestino, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}
