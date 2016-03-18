namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_TDCompTesoreria_Entidades : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetListEx( string ListaTDCompTesoreria, bool Activo)
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.GetListEx( ListaTDCompTesoreria, Activo );
		}

		public static tfi_TDCompTesoreria_EntidadesDataset GetByIdEntidad(string IdEntidad)
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.GetByIdEntidad(IdEntidad);
		}
		
		#endregion
		
		public tfi_TDCompTesoreria_Entidades()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_TDCompTesoreria_Entidades
		/// </summary>
		public static tfi_TDCompTesoreria_EntidadesDataset GetList()
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_TDCompTesoreria_Entidades filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_TDCompTesoreria_EntidadesDataset GetList( string IdEntidad, string TDCompTesoreria, bool Activo, string Aux1, string Aux2 )
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.GetList( IdEntidad, TDCompTesoreria, Activo, Aux1, Aux2 );
		}
		public static tfi_TDCompTesoreria_EntidadesDataset GetList( string TDCompTesoreria)
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.GetList( TDCompTesoreria );
		}


		/// <summary>
		/// Crea un tfi_TDCompTesoreria_EntidadesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria_Entidades que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow GetByPk( string IdEntidad, string TDCompTesoreria )
		{
			tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow row = mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.GetByPk( IdEntidad, TDCompTesoreria  );
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
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria_Entidades que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow GetByPk( object IdEntidad, string TDCompTesoreria )
		{
			return GetByPk( ( string )IdEntidad, ( string )TDCompTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_TDCompTesoreria_EntidadesRow.
		/// </summary>
		public static tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow SetRowDefaultValues( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow row )
		{
			row.IdEntidad = Util.NewStringId(); 
			row.TDCompTesoreria = Util.NewStringId(); 
			row.Activo = false;
			row.Aux1 = string.Empty;
			row.Aux2 = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_EntidadesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_EntidadesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_EntidadesRow a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_EntidadesDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_EntidadesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_TDCompTesoreria_Entidades.Rows.Count > 0, "La tabla dataSet.tfi_TDCompTesoreria_EntidadesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_Entidades.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_TDCompTesoreria_EntidadesRow.
		/// </summary>
		public static bool RowIsValid( tfi_TDCompTesoreria_EntidadesDataset.tfi_TDCompTesoreria_EntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdEntidadIsValid( row.IdEntidad, out mensaje) )
			{ 
				row.SetColumnError( "IdEntidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !TDCompTesoreriaIsValid( row.TDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "TDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
		/// Valida el campo IdEntidad.
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEntidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad)
		{
			string mensaje;
			return IdEntidadIsValid( IdEntidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo TDCompTesoreria.
		/// </summary>
		public static bool TDCompTesoreriaIsValid( string TDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo TDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool TDCompTesoreriaIsValid( string TDCompTesoreria)
		{
			string mensaje;
			return TDCompTesoreriaIsValid( TDCompTesoreria, out mensaje );
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

