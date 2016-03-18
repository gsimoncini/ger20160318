namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_ResponsablesDepositosSecciones : IDisposable
	{
	
		#region Custom Members
		public static tlg_ResponsablesDepositosSeccionesDataset GetList( string IdUsuario)
		{
			return mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.GetList( IdUsuario, string.Empty, string.Empty, true);
		}
	
		#endregion
		
		public tlg_ResponsablesDepositosSecciones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_ResponsablesDepositosSecciones
		/// </summary>
		public static tlg_ResponsablesDepositosSeccionesDataset GetList()
		{
			return mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_ResponsablesDepositosSecciones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_ResponsablesDepositosSeccionesDataset GetList( string IdUsuario, string IdDeposito, string IdSeccion, bool Activo)
		{
			return mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.GetList( IdUsuario, IdDeposito, IdSeccion, Activo);
		}

		/// <summary>
		/// Crea un tlg_ResponsablesDepositosSeccionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_ResponsablesDepositosSecciones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow GetByPk( string IdUsuario, string IdDeposito, string IdSeccion )
		{
			tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow row = mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.GetByPk( IdUsuario, IdDeposito, IdSeccion  );
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
		/// Obtiene un registro de la tabla tlg_ResponsablesDepositosSecciones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow GetByPk( object IdUsuario, object IdDeposito, object IdSeccion )
		{
			return GetByPk( ( string )IdUsuario, ( string )IdDeposito, ( string )IdSeccion );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_ResponsablesDepositosSeccionesRow.
		/// </summary>
		public static tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow SetRowDefaultValues( tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow row )
		{
			row.IdUsuario = Util.NewStringId(); 
			row.IdDeposito = Util.NewStringId(); 
			row.IdSeccion = Util.NewStringId(); 
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ResponsablesDepositosSeccionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ResponsablesDepositosSeccionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ResponsablesDepositosSeccionesRow a la base de datos.
		/// </summary>
		public static void Update( tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_ResponsablesDepositosSeccionesDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_ResponsablesDepositosSeccionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_ResponsablesDepositosSecciones.Rows.Count > 0, "La tabla dataSet.tlg_ResponsablesDepositosSeccionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_ResponsablesDepositosSecciones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_ResponsablesDepositosSeccionesRow.
		/// </summary>
		public static bool RowIsValid( tlg_ResponsablesDepositosSeccionesDataset.tlg_ResponsablesDepositosSeccionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdPersonaIsValid( row.IdUsuario, out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdDepositoIsValid( row.IdDeposito, out mensaje) )
			{ 
				row.SetColumnError( "IdDeposito" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSeccionIsValid( row.IdSeccion, out mensaje) )
			{ 
				row.SetColumnError( "IdSeccion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdPersonaIsValid( string IdUsuario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool IdPersonaIsValid( string IdUsuario)
		{
			string mensaje;
			return IdPersonaIsValid( IdUsuario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdDeposito.
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDeposito. Metodo Sobrecargado
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito)
		{
			string mensaje;
			return IdDepositoIsValid( IdDeposito, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSeccion.
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSeccion. Metodo Sobrecargado
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion)
		{
			string mensaje;
			return IdSeccionIsValid( IdSeccion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

