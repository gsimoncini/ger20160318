namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_TipoAceptacion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_TipoAceptacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_TipoAceptacion
		/// </summary>
		public static tsh_TipoAceptacionDataset GetList()
		{
			return mz.erp.dataaccess.tsh_TipoAceptacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_TipoAceptacion filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsh_TipoAceptacionDataset GetList(  )
		{
			return mz.erp.dataaccess.tsh_TipoAceptacion.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsh_TipoAceptacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_TipoAceptacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_TipoAceptacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow GetByPk( string IdTipoAceptacion )
		{
			tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow row = mz.erp.dataaccess.tsh_TipoAceptacion.GetByPk( IdTipoAceptacion  );
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
		/// Obtiene un registro de la tabla tsh_TipoAceptacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow GetByPk( object IdTipoAceptacion )
		{
			return GetByPk( ( string )IdTipoAceptacion );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_TipoAceptacionRow.
		/// </summary>
		public static tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow SetRowDefaultValues( tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow row )
		{
			row.IdTipoAceptacion = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Aux1 = string.Empty;
			row.Aux2 = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_TipoAceptacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_TipoAceptacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_TipoAceptacionRow a la base de datos.
		/// </summary>
		public static void Update( tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_TipoAceptacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_TipoAceptacionDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_TipoAceptacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_TipoAceptacion.Rows.Count > 0, "La tabla dataSet.tsh_TipoAceptacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_TipoAceptacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_TipoAceptacionDataset.tsh_TipoAceptacionDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_TipoAceptacionDataset.tsh_TipoAceptacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_TipoAceptacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_TipoAceptacionRow.
		/// </summary>
		public static bool RowIsValid( tsh_TipoAceptacionDataset.tsh_TipoAceptacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoAceptacionIsValid( row.IdTipoAceptacion, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoAceptacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !Aux1IsValid( row.Aux1, out mensaje) )
			{ 
				row.SetColumnError( "Aux1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Aux2IsValid( row.Aux2, out mensaje) )
			{ 
				row.SetColumnError( "Aux2" , mensaje);
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Aux1.
		/// </summary>
		public static bool Aux1IsValid( string Aux1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Aux1. Metodo Sobrecargado
		/// </summary>
		public static bool Aux1IsValid( string Aux1)
		{
			string mensaje;
			return Aux1IsValid( Aux1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Aux2.
		/// </summary>
		public static bool Aux2IsValid( string Aux2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Aux2. Metodo Sobrecargado
		/// </summary>
		public static bool Aux2IsValid( string Aux2)
		{
			string mensaje;
			return Aux2IsValid( Aux2, out mensaje );
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

