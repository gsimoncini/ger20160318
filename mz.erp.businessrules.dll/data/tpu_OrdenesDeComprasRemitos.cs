namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_OrdenesDeComprasRemitos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_OrdenesDeComprasRemitos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_OrdenesDeComprasRemitos
		/// </summary>
		public static tpu_OrdenesDeComprasRemitosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_OrdenesDeComprasRemitos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_OrdenesDeComprasRemitosDataset GetList( string IdComprobanteOrigen, long OrdinalOrigen, string IdComprobanteDestino, long OrdinalDestino )
		{
			return mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.GetList( IdComprobanteOrigen, OrdinalOrigen, IdComprobanteDestino, OrdinalDestino );
		}

		/// <summary>
		/// Crea un tpu_OrdenesDeComprasRemitosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_OrdenesDeComprasRemitos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow GetByPk( string IdComprobanteOrigen, long OrdinalOrigen, string IdComprobanteDestino, long OrdinalDestino )
		{
			tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row = mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.GetByPk( IdComprobanteOrigen, OrdinalOrigen, IdComprobanteDestino, OrdinalDestino  );
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
		/// Obtiene un registro de la tabla tpu_OrdenesDeComprasRemitos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow GetByPk( object IdComprobanteOrigen, object OrdinalOrigen, object IdComprobanteDestino,object OrdinalDestino )
		{
			return GetByPk( ( string )IdComprobanteOrigen, ( long )OrdinalOrigen, ( string )IdComprobanteDestino, ( long )OrdinalDestino );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_OrdenesDeComprasRemitosRow.
		/// </summary>
		public static tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow SetRowDefaultValues( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row )
		{
			row.IdComprobanteOrigen = Util.NewStringId(); 
			row.OrdinalOrigen = 0; 
			row.IdComprobanteDestino = Util.NewStringId(); 
			row.OrdinalDestino = 0; 
			row.CantidadOrigen = 0;
			row.CantidadDestino = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesDeComprasRemitosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesDeComprasRemitosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesDeComprasRemitosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_OrdenesDeComprasRemitosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesDeComprasRemitosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_OrdenesDeComprasRemitos.Rows.Count > 0, "La tabla dataSet.tpu_OrdenesDeComprasRemitosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_OrdenesDeComprasRemitos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_OrdenesDeComprasRemitosRow.
		/// </summary>
		public static bool RowIsValid( tpu_OrdenesDeComprasRemitosDataset.tpu_OrdenesDeComprasRemitosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteOrigenIsValid( row.IdComprobanteOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalOrigenIsValid( row.OrdinalOrigen, out mensaje) )
			{ 
				row.SetColumnError( "OrdinalOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteDestinoIsValid( row.IdComprobanteDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalDestinoIsValid( row.OrdinalDestino, out mensaje) )
			{ 
				row.SetColumnError( "OrdinalDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadOrigenIsValid( row.CantidadOrigen, out mensaje) )
			{ 
				row.SetColumnError( "CantidadOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadDestinoIsValid( row.CantidadDestino, out mensaje) )
			{ 
				row.SetColumnError( "CantidadDestino" , mensaje);
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
		/// Valida el campo OrdinalOrigen.
		/// </summary>
		public static bool OrdinalOrigenIsValid( long OrdinalOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OrdinalOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalOrigenIsValid( long OrdinalOrigen)
		{
			string mensaje;
			return OrdinalOrigenIsValid( OrdinalOrigen, out mensaje );
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
		/// Valida el campo OrdinalDestino.
		/// </summary>
		public static bool OrdinalDestinoIsValid( long OrdinalDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OrdinalDestino. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalDestinoIsValid( long OrdinalDestino)
		{
			string mensaje;
			return OrdinalDestinoIsValid( OrdinalDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CantidadOrigen.
		/// </summary>
		public static bool CantidadOrigenIsValid( decimal CantidadOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CantidadOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadOrigenIsValid( decimal CantidadOrigen)
		{
			string mensaje;
			return CantidadOrigenIsValid( CantidadOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CantidadDestino.
		/// </summary>
		public static bool CantidadDestinoIsValid( decimal CantidadDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CantidadDestino. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadDestinoIsValid( decimal CantidadDestino)
		{
			string mensaje;
			return CantidadDestinoIsValid( CantidadDestino, out mensaje );
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

