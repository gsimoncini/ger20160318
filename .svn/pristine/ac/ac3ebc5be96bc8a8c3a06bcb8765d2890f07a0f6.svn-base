namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet
		/// </summary>
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset GetList()
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset GetList( long IdOrdenReparacion, long IdInstanciaOrdenReparacion, long IdTarea, long IdMotivo, bool EsVerdadero )
		{
			return mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetList( IdOrdenReparacion, IdInstanciaOrdenReparacion, IdTarea, IdMotivo, EsVerdadero );
		}

		/// <summary>
		/// Crea un st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow GetByPk( long IdOrdenReparacion, long IdInstanciaOrdenReparacion, long IdTarea, long IdMotivo )
		{
			st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow row = mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.GetByPk( IdOrdenReparacion, IdInstanciaOrdenReparacion, IdTarea, IdMotivo  );
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
		/// Obtiene un registro de la tabla st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow GetByPk( object IdOrdenReparacion, object IdInstanciaOrdenReparacion, object IdTarea, object IdMotivo )
		{
			return GetByPk( ( long )IdOrdenReparacion, ( long )IdInstanciaOrdenReparacion, ( long )IdTarea, ( long )IdMotivo );
		}

		/// <summary>
		/// Establece los valores por defecto de st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow.
		/// </summary>
		public static st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow SetRowDefaultValues( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow row )
		{
			row.IdOrdenReparacion = 0; 
			row.IdInstanciaOrdenReparacion = 0; 
			row.IdTarea = 0; 
			row.IdMotivo = 0; 
			row.EsVerdadero = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Rows.Count > 0, "La tabla dataSet.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable a la base de datos.
		/// </summary>
		public static void Update( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow.
		/// </summary>
		public static bool RowIsValid( st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetDataset.st_EstadisticaOrdenReparacionMotivoOrdenReparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdOrdenReparacionIsValid( row.IdOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdInstanciaOrdenReparacionIsValid( row.IdInstanciaOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMotivoIsValid( row.IdMotivo, out mensaje) )
			{ 
				row.SetColumnError( "IdMotivo" , mensaje);
				isValid=false;
			
			}
						
			if ( !EsVerdaderoIsValid( row.EsVerdadero, out mensaje) )
			{ 
				row.SetColumnError( "EsVerdadero" , mensaje);
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
		/// Valida el campo IdInstanciaOrdenReparacion.
		/// </summary>
		public static bool IdInstanciaOrdenReparacionIsValid( long IdInstanciaOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaOrdenReparacionIsValid( long IdInstanciaOrdenReparacion)
		{
			string mensaje;
			return IdInstanciaOrdenReparacionIsValid( IdInstanciaOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTarea.
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTarea. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea)
		{
			string mensaje;
			return IdTareaIsValid( IdTarea, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMotivo.
		/// </summary>
		public static bool IdMotivoIsValid( long IdMotivo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMotivo. Metodo Sobrecargado
		/// </summary>
		public static bool IdMotivoIsValid( long IdMotivo)
		{
			string mensaje;
			return IdMotivoIsValid( IdMotivo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo EsVerdadero.
		/// </summary>
		public static bool EsVerdaderoIsValid( bool EsVerdadero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo EsVerdadero. Metodo Sobrecargado
		/// </summary>
		public static bool EsVerdaderoIsValid( bool EsVerdadero)
		{
			string mensaje;
			return EsVerdaderoIsValid( EsVerdadero, out mensaje );
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

