namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;


	public class tsh_Autorizaciones : IDisposable
	{
	
		#region Custom Members

		public static DataTable GetSolicitudes() 
		{
			string IdAutorizacion = null;
			string IdResponsable = null;
			string Motivo = null;
			string IdResponsableDeAutorizacion = null;
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;			
			return dataaccess.tsh_Autorizaciones.GetList(IdAutorizacion, IdResponsable, Motivo, IdResponsableDeAutorizacion, IdEmpresa, IdSucursal).Tables[0];
		}
		public static DataTable GetSolicitudes(string Motivo) 
		{
			string IdAutorizacion = null;
			string IdResponsable = null;		
			string IdResponsableDeAutorizacion = null;
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;			
			return dataaccess.tsh_Autorizaciones.GetList(IdAutorizacion, IdResponsable, Motivo, IdResponsableDeAutorizacion, IdEmpresa, IdSucursal).Tables[0];
		}

		/*public static void Update(string IdAutorizacion, bool Autorizado, string Observaciones, SentenciasReplicacion Replicacion, string IdTransaction) 
		{
			tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = tsh_Autorizaciones.GetByPk(IdAutorizacion);
			if (Autorizado) 
			{
				row.Estado = "A";
			}
			else 
			{
				row.Estado = "R";
			}
			row.Observaciones = Observaciones;
			row.IdResponsableDeAutorizacion = Security.IdPersona;

			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);	
			dataaccess.tsh_Autorizaciones.Update(row, Replicacion, trx);		
		}*/
		#endregion
		
		public tsh_Autorizaciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Autorizaciones
		/// </summary>
		public static tsh_AutorizacionesDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Autorizaciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Autorizaciones filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsh_AutorizacionesDataset GetList(  )
		{
			return mz.erp.dataaccess.tsh_Autorizaciones.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsh_AutorizacionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_AutorizacionesDataset.tsh_AutorizacionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_Autorizaciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Autorizaciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AutorizacionesDataset.tsh_AutorizacionesRow GetByPk( string IdAutorizacion )
		{
			tsh_AutorizacionesDataset.tsh_AutorizacionesRow row = mz.erp.dataaccess.tsh_Autorizaciones.GetByPk( IdAutorizacion  );
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
		/// Obtiene un registro de la tabla tsh_Autorizaciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_AutorizacionesDataset.tsh_AutorizacionesRow GetByPk( object IdAutorizacion )
		{
			return GetByPk( ( string )IdAutorizacion );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_AutorizacionesRow.
		/// </summary>
		public static tsh_AutorizacionesDataset.tsh_AutorizacionesRow SetRowDefaultValues( tsh_AutorizacionesDataset.tsh_AutorizacionesRow row )
		{
			row.IdAutorizacion = Util.NewStringId(); 
			row.IdResponsable = string.Empty;
			row.Motivo = string.Empty;
			row.Datos = string.Empty;
			//row.DatosBinarios = null;
			row.TipoDatosBinarios = string.Empty;
			row.Estado = String.Empty;
			row.IdResponsableDeAutorizacion = string.Empty;
			row.Observaciones = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AutorizacionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_AutorizacionesDataset.tsh_AutorizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AutorizacionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_AutorizacionesDataset.tsh_AutorizacionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AutorizacionesRow a la base de datos.
		/// </summary>
		public static void Update( tsh_AutorizacionesDataset.tsh_AutorizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Autorizaciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_AutorizacionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_AutorizacionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Autorizaciones.Rows.Count > 0, "La tabla dataSet.tsh_AutorizacionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Autorizaciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_AutorizacionesDataset.tsh_AutorizacionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Autorizaciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_AutorizacionesRow.
		/// </summary>
		public static bool RowIsValid( tsh_AutorizacionesDataset.tsh_AutorizacionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdAutorizacionIsValid( row.IdAutorizacion, out mensaje) )
			{ 
				row.SetColumnError( "IdAutorizacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMotivoIsValid( row.Motivo, out mensaje) )
			{ 
				row.SetColumnError( "IdMotivo" , mensaje);
				isValid=false;
			
			}
						
			if ( !EstadoIsValid( row.Estado, out mensaje) )
			{ 
				row.SetColumnError( "Estado" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableDeAutorizacionIsValid( row.IdResponsableDeAutorizacion, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsableDeAutorizacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
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
		/// Valida el campo IdMotivo.
		/// </summary>
		public static bool IdMotivoIsValid( string IdMotivo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMotivo. Metodo Sobrecargado
		/// </summary>
		public static bool IdMotivoIsValid( string IdMotivo)
		{
			string mensaje;
			return IdMotivoIsValid( IdMotivo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Estado.
		/// </summary>
		public static bool EstadoIsValid( string Estado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Estado. Metodo Sobrecargado
		/// </summary>
		public static bool EstadoIsValid( string Estado)
		{
			string mensaje;
			return EstadoIsValid( Estado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdResponsableDeAutorizacion.
		/// </summary>
		public static bool IdResponsableDeAutorizacionIsValid( string IdResponsableDeAutorizacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsableDeAutorizacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableDeAutorizacionIsValid( string IdResponsableDeAutorizacion)
		{
			string mensaje;
			return IdResponsableDeAutorizacionIsValid( IdResponsableDeAutorizacion, out mensaje );
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

