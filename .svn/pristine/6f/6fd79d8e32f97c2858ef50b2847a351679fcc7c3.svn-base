namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_SentenciasReplicacion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_SentenciasReplicacion()
		{
		}


		
		/// <summary>
		/// Obtiene tabla sy_SentenciasReplicacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_SentenciasReplicacionDataset GetList(  )
		{
			return mz.erp.dataaccess.sy_SentenciasReplicacion.GetList(  );
		}

		/// <summary>
		/// Crea un sy_SentenciasReplicacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_SentenciasReplicacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_SentenciasReplicacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow GetByPk( long IdSentenciaReplicacion )
		{
			sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row = mz.erp.dataaccess.sy_SentenciasReplicacion.GetByPk( IdSentenciaReplicacion  );
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
		/// Obtiene un registro de la tabla sy_SentenciasReplicacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow GetByPk( object IdSentenciaReplicacion )
		{
			return GetByPk( ( long )IdSentenciaReplicacion );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_SentenciasReplicacionRow.
		/// </summary>
		public static sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow SetRowDefaultValues( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row )
		{
			row.IdSentenciaReplicacion = 0; 
			row.IdTabla = string.Empty;
			row.IdTipoSentencia = string.Empty;
			row.Sentencia = string.Empty;
			row.SentenciaRowId = Guid.Empty;
			row.NombreArchivo = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.IdSucursalGeneradora = 0;
			row.IdConexion = 0;
			row.Destino = string.Empty;
			row.VersionBD = null;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_SentenciasReplicacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_SentenciasReplicacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_SentenciasReplicacionRow a la base de datos.
		/// </summary>
		public static void Update( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_SentenciasReplicacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_SentenciasReplicacionDataset a la base de datos.
		/// </summary>
		public static void Update( sy_SentenciasReplicacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_SentenciasReplicacion.Rows.Count > 0, "La tabla dataSet.sy_SentenciasReplicacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_SentenciasReplicacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_SentenciasReplicacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_SentenciasReplicacionRow.
		/// </summary>
		public static bool RowIsValid( sy_SentenciasReplicacionDataset.sy_SentenciasReplicacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdSentenciaReplicacionIsValid( row.IdSentenciaReplicacion, out mensaje) )
			{ 
				row.SetColumnError( "IdSentenciaReplicacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTablaIsValid( row.IdTabla, out mensaje) )
			{ 
				row.SetColumnError( "IdTabla" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoSentenciaIsValid( row.IdTipoSentencia, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoSentencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !SentenciaIsValid( row.Sentencia, out mensaje) )
			{ 
				row.SetColumnError( "Sentencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !SentenciaRowIdIsValid( row.SentenciaRowId, out mensaje) )
			{ 
				row.SetColumnError( "SentenciaRowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreArchivoIsValid( row.NombreArchivo, out mensaje) )
			{ 
				row.SetColumnError( "NombreArchivo" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalGeneradoraIsValid( row.IdSucursalGeneradora, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursalGeneradora" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DestinoIsValid( row.Destino, out mensaje) )
			{ 
				row.SetColumnError( "Destino" , mensaje);
				isValid=false;
			
			}
						
			if ( !VersionBDIsValid( row.VersionBD, out mensaje) )
			{ 
				row.SetColumnError( "VersionBD" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdSentenciaReplicacion.
		/// </summary>
		public static bool IdSentenciaReplicacionIsValid( long IdSentenciaReplicacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSentenciaReplicacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdSentenciaReplicacionIsValid( long IdSentenciaReplicacion)
		{
			string mensaje;
			return IdSentenciaReplicacionIsValid( IdSentenciaReplicacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTabla.
		/// </summary>
		public static bool IdTablaIsValid( string IdTabla , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTabla. Metodo Sobrecargado
		/// </summary>
		public static bool IdTablaIsValid( string IdTabla)
		{
			string mensaje;
			return IdTablaIsValid( IdTabla, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoSentencia.
		/// </summary>
		public static bool IdTipoSentenciaIsValid( string IdTipoSentencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoSentencia. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoSentenciaIsValid( string IdTipoSentencia)
		{
			string mensaje;
			return IdTipoSentenciaIsValid( IdTipoSentencia, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Sentencia.
		/// </summary>
		public static bool SentenciaIsValid( string Sentencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sentencia. Metodo Sobrecargado
		/// </summary>
		public static bool SentenciaIsValid( string Sentencia)
		{
			string mensaje;
			return SentenciaIsValid( Sentencia, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo SentenciaRowId.
		/// </summary>
		public static bool SentenciaRowIdIsValid( Guid SentenciaRowId , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo SentenciaRowId. Metodo Sobrecargado
		/// </summary>
		public static bool SentenciaRowIdIsValid( Guid SentenciaRowId)
		{
			string mensaje;
			return SentenciaRowIdIsValid( SentenciaRowId, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NombreArchivo.
		/// </summary>
		public static bool NombreArchivoIsValid( string NombreArchivo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NombreArchivo. Metodo Sobrecargado
		/// </summary>
		public static bool NombreArchivoIsValid( string NombreArchivo)
		{
			string mensaje;
			return NombreArchivoIsValid( NombreArchivo, out mensaje );
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
		/// Valida el campo IdSucursalGeneradora.
		/// </summary>
		public static bool IdSucursalGeneradoraIsValid( long IdSucursalGeneradora , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursalGeneradora. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalGeneradoraIsValid( long IdSucursalGeneradora)
		{
			string mensaje;
			return IdSucursalGeneradoraIsValid( IdSucursalGeneradora, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConexion.
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConexionIsValid( long IdConexion)
		{
			string mensaje;
			return IdConexionIsValid( IdConexion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Destino.
		/// </summary>
		public static bool DestinoIsValid( string Destino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Destino. Metodo Sobrecargado
		/// </summary>
		public static bool DestinoIsValid( string Destino)
		{
			string mensaje;
			return DestinoIsValid( Destino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo VersionBD.
		/// </summary>
		public static bool VersionBDIsValid( string VersionBD , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo VersionBD. Metodo Sobrecargado
		/// </summary>
		public static bool VersionBDIsValid( string VersionBD)
		{
			string mensaje;
			return VersionBDIsValid( VersionBD, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


