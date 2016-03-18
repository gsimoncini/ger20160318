namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_MotivoOrdenReparacion : IDisposable
	{
	
		#region Custom Members
		public static tsy_MotivoOrdenReparacionDataset GetListPadres()
		{
			return mz.erp.dataaccess.tsy_MotivoOrdenReparacion.GetListPadres();
		}
		public static tsy_MotivoOrdenReparacionDataset GetListHijos(long IdMotivoPadre)
		{
			return mz.erp.dataaccess.tsy_MotivoOrdenReparacion.GetListHijos(IdMotivoPadre);
		}
		#endregion
		
		public tsy_MotivoOrdenReparacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_MotivoOrdenReparacion
		/// </summary>
		public static tsy_MotivoOrdenReparacionDataset GetList()
		{
			return mz.erp.dataaccess.tsy_MotivoOrdenReparacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_MotivoOrdenReparacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_MotivoOrdenReparacionDataset GetList( long IdMotivo, long IdMotivoPadre, bool EsVerdadero, string Descripcion )
		{
			return mz.erp.dataaccess.tsy_MotivoOrdenReparacion.GetList( IdMotivo, IdMotivoPadre, EsVerdadero, Descripcion );
		}

		/// <summary>
		/// Crea un tsy_MotivoOrdenReparacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_MotivoOrdenReparacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_MotivoOrdenReparacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow GetByPk( long IdMotivo )
		{
			tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row = mz.erp.dataaccess.tsy_MotivoOrdenReparacion.GetByPk( IdMotivo  );
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
		/// Obtiene un registro de la tabla tsy_MotivoOrdenReparacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow GetByPk( object IdMotivo )
		{
			return GetByPk( ( long )IdMotivo );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_MotivoOrdenReparacionRow.
		/// </summary>
		public static tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow SetRowDefaultValues( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row )
		{
			row.IdMotivo = 0; 
			row.IdMotivoPadre = 0;
			row.EsVerdadero = false;
			row.Descripcion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivoOrdenReparacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivoOrdenReparacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivoOrdenReparacionRow a la base de datos.
		/// </summary>
		public static void Update( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_MotivoOrdenReparacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_MotivoOrdenReparacionDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_MotivoOrdenReparacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_MotivoOrdenReparacion.Rows.Count > 0, "La tabla dataSet.tsy_MotivoOrdenReparacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_MotivoOrdenReparacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_MotivoOrdenReparacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_MotivoOrdenReparacionRow.
		/// </summary>
		public static bool RowIsValid( tsy_MotivoOrdenReparacionDataset.tsy_MotivoOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMotivoIsValid( row.IdMotivo, out mensaje) )
			{ 
				row.SetColumnError( "IdMotivo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMotivoPadreIsValid( row.IdMotivoPadre, out mensaje) )
			{ 
				row.SetColumnError( "IdMotivoPadre" , mensaje);
				isValid=false;
			
			}
						
			if ( !EsVerdaderoIsValid( row.EsVerdadero, out mensaje) )
			{ 
				row.SetColumnError( "EsVerdadero" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
		/// Valida el campo IdMotivoPadre.
		/// </summary>
		public static bool IdMotivoPadreIsValid( long IdMotivoPadre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMotivoPadre. Metodo Sobrecargado
		/// </summary>
		public static bool IdMotivoPadreIsValid( long IdMotivoPadre)
		{
			string mensaje;
			return IdMotivoPadreIsValid( IdMotivoPadre, out mensaje );
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

