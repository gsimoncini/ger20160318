namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_Aceptacion : IDisposable
	{
	
		#region Custom Members

		public static void Update(DataSet data, string IdTransaction)
		{
			mz.erp.dataaccess.tsh_Aceptacion.Update(data.Tables[0], IdTransaction);
		}
		
		#endregion
		
		public tsh_Aceptacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Aceptacion
		/// </summary>
		public static tsh_AceptacionDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Aceptacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Aceptacion filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsh_AceptacionDataset GetList(  )
		{
			return mz.erp.dataaccess.tsh_Aceptacion.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsh_AceptacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_AceptacionDataset.tsh_AceptacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_Aceptacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Aceptacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_AceptacionDataset.tsh_AceptacionRow GetByPk( string IdAceptacion )
		{
			tsh_AceptacionDataset.tsh_AceptacionRow row = mz.erp.dataaccess.tsh_Aceptacion.GetByPk( IdAceptacion  );
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
		/// Obtiene un registro de la tabla tsh_Aceptacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_AceptacionDataset.tsh_AceptacionRow GetByPk( object IdAceptacion )
		{
			return GetByPk( ( string )IdAceptacion );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_AceptacionRow.
		/// </summary>
		public static tsh_AceptacionDataset.tsh_AceptacionRow SetRowDefaultValues( tsh_AceptacionDataset.tsh_AceptacionRow row )
		{
			row.IdAceptacion = Util.NewStringId(); 
			row.Usuario1 = string.Empty;
			row.Usuario2 = string.Empty;
			row.MensajeAceptacion = string.Empty;
			row.FechaHora = DateTime.Now;
			row.Comentario = string.Empty;
			row.IdTipoAceptacion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AceptacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_AceptacionDataset.tsh_AceptacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AceptacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_AceptacionDataset.tsh_AceptacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AceptacionRow a la base de datos.
		/// </summary>
		public static void Update( tsh_AceptacionDataset.tsh_AceptacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Aceptacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_AceptacionDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_AceptacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Aceptacion.Rows.Count > 0, "La tabla dataSet.tsh_AceptacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Aceptacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_AceptacionDataset.tsh_AceptacionDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_AceptacionDataset.tsh_AceptacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Aceptacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_AceptacionRow.
		/// </summary>
		public static bool RowIsValid( tsh_AceptacionDataset.tsh_AceptacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdAceptacionIsValid( row.IdAceptacion, out mensaje) )
			{ 
				row.SetColumnError( "IdAceptacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !Usuario1IsValid( row.Usuario1, out mensaje) )
			{ 
				row.SetColumnError( "Usuario1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Usuario2IsValid( row.Usuario2, out mensaje) )
			{ 
				row.SetColumnError( "Usuario2" , mensaje);
				isValid=false;
			
			}
						
			if ( !MensajeAceptacionIsValid( row.MensajeAceptacion, out mensaje) )
			{ 
				row.SetColumnError( "MensajeAceptacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaHoraIsValid( row.FechaHora, out mensaje) )
			{ 
				row.SetColumnError( "FechaHora" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComentarioIsValid( row.Comentario, out mensaje) )
			{ 
				row.SetColumnError( "Comentario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoAceptacionIsValid( row.IdTipoAceptacion, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoAceptacion" , mensaje);
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
		/// Valida el campo IdAceptacion.
		/// </summary>
		public static bool IdAceptacionIsValid( string IdAceptacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdAceptacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdAceptacionIsValid( string IdAceptacion)
		{
			string mensaje;
			return IdAceptacionIsValid( IdAceptacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Usuario1.
		/// </summary>
		public static bool Usuario1IsValid( string Usuario1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Usuario1. Metodo Sobrecargado
		/// </summary>
		public static bool Usuario1IsValid( string Usuario1)
		{
			string mensaje;
			return Usuario1IsValid( Usuario1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Usuario2.
		/// </summary>
		public static bool Usuario2IsValid( string Usuario2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Usuario2. Metodo Sobrecargado
		/// </summary>
		public static bool Usuario2IsValid( string Usuario2)
		{
			string mensaje;
			return Usuario2IsValid( Usuario2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MensajeAceptacion.
		/// </summary>
		public static bool MensajeAceptacionIsValid( string MensajeAceptacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MensajeAceptacion. Metodo Sobrecargado
		/// </summary>
		public static bool MensajeAceptacionIsValid( string MensajeAceptacion)
		{
			string mensaje;
			return MensajeAceptacionIsValid( MensajeAceptacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaHora.
		/// </summary>
		public static bool FechaHoraIsValid( DateTime FechaHora , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaHora. Metodo Sobrecargado
		/// </summary>
		public static bool FechaHoraIsValid( DateTime FechaHora)
		{
			string mensaje;
			return FechaHoraIsValid( FechaHora, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comentario. Metodo Sobrecargado
		/// </summary>
		public static bool ComentarioIsValid( string Comentario)
		{
			string mensaje;
			return ComentarioIsValid( Comentario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoAceptacion.
		/// </summary>
		public static bool IdTipoAceptacionIsValid( string IdTipoAceptacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoAceptacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoAceptacionIsValid( string IdTipoAceptacion)
		{
			string mensaje;
			return IdTipoAceptacionIsValid( IdTipoAceptacion, out mensaje );
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
