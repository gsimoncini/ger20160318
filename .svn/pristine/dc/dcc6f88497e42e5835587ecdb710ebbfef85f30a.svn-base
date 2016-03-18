namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_EstadisticaOrdenReparacionModificacionTecnico : IDisposable
	{
	
		#region Custom Members

		public static long GetIdTecnicoByIdPersona( string IdPersona )
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.GetIdTecnicoByIdPersona( IdPersona  );
		}

		#endregion
		
		public st_EstadisticaOrdenReparacionModificacionTecnico()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_EstadisticaOrdenReparacionModificacionTecnico
		/// </summary>
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset GetList()
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_EstadisticaOrdenReparacionModificacionTecnico filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset GetList( long IdOrdenReparacion, long IdTecnico )
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.GetList( IdOrdenReparacion, IdTecnico );
		}

		/// <summary>
		/// Crea un st_EstadisticaOrdenReparacionModificacionTecnicoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacionModificacionTecnico que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow GetByPk( long IdOrdenReparacion, long IdTecnico )
		{
			st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow row = mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.GetByPk( IdOrdenReparacion, IdTecnico  );
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
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacionModificacionTecnico que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow GetByPk( object IdOrdenReparacion, object IdTecnico )
		{
			return GetByPk( ( long )IdOrdenReparacion, ( long )IdTecnico );
		}

		/// <summary>
		/// Establece los valores por defecto de st_EstadisticaOrdenReparacionModificacionTecnicoRow.
		/// </summary>
		public static st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow SetRowDefaultValues( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow row )
		{
			row.IdOrdenReparacion = 0; 
			row.IdTecnico = 0; 
			row.FechaUltimaModificacion = DateTime.Now;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionModificacionTecnicoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionModificacionTecnicoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionModificacionTecnicoRow a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionModificacionTecnicoDataset a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionModificacionTecnicoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_EstadisticaOrdenReparacionModificacionTecnico.Rows.Count > 0, "La tabla dataSet.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionModificacionTecnico.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_EstadisticaOrdenReparacionModificacionTecnicoRow.
		/// </summary>
		public static bool RowIsValid( st_EstadisticaOrdenReparacionModificacionTecnicoDataset.st_EstadisticaOrdenReparacionModificacionTecnicoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdOrdenReparacionIsValid( row.IdOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTecnicoIsValid( row.IdTecnico, out mensaje) )
			{ 
				row.SetColumnError( "IdTecnico" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaUltimaModificacionIsValid( row.FechaUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaUltimaModificacion" , mensaje);
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
		/// Valida el campo IdOrdenReparacion.
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdOrdenReparacionIsValid( long IdOrdenReparacion)
		{
			string mensaje;
			return IdOrdenReparacionIsValid( IdOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTecnico.
		/// </summary>
		public static bool IdTecnicoIsValid( long IdTecnico , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTecnico. Metodo Sobrecargado
		/// </summary>
		public static bool IdTecnicoIsValid( long IdTecnico)
		{
			string mensaje;
			return IdTecnicoIsValid( IdTecnico, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaUltimaModificacion.
		/// </summary>
		public static bool FechaUltimaModificacionIsValid( DateTime FechaUltimaModificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaUltimaModificacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaUltimaModificacionIsValid( DateTime FechaUltimaModificacion)
		{
			string mensaje;
			return FechaUltimaModificacionIsValid( FechaUltimaModificacion, out mensaje );
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

