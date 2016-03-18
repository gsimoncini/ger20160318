namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_Caminos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public twf_Caminos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_Caminos
		/// </summary>
		public static twf_CaminosDataset GetList()
		{
			return mz.erp.dataaccess.twf_Caminos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_Caminos filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_CaminosDataset GetList( long IdCamino, long IdTareaOrigen, long IdTareaDestino, short Power, short Frecuencia, long IdConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones )
		{
			return mz.erp.dataaccess.twf_Caminos.GetList( IdCamino, IdTareaOrigen, IdTareaDestino, Power, Frecuencia, IdConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
		}

		/// <summary>
		/// Crea un twf_CaminosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_CaminosDataset.twf_CaminosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_Caminos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_Caminos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_CaminosDataset.twf_CaminosRow GetByPk( long IdCamino )
		{
			twf_CaminosDataset.twf_CaminosRow row = mz.erp.dataaccess.twf_Caminos.GetByPk( IdCamino  );
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
		/// Obtiene un registro de la tabla twf_Caminos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_CaminosDataset.twf_CaminosRow GetByPk( object IdCamino )
		{
			return GetByPk( ( long )IdCamino );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_CaminosRow.
		/// </summary>
		public static twf_CaminosDataset.twf_CaminosRow SetRowDefaultValues( twf_CaminosDataset.twf_CaminosRow row )
		{
			row.IdCamino = 0; 
			row.IdTareaOrigen = 0;
			row.IdTareaDestino = 0;
			row.IdProceso = 0;
			row.Power = 0;
			row.Frecuencia = 0;
			row.IdConexion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del twf_CaminosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_CaminosDataset.twf_CaminosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_CaminosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_CaminosDataset.twf_CaminosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_CaminosRow a la base de datos.
		/// </summary>
		public static void Update( twf_CaminosDataset.twf_CaminosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Caminos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_CaminosDataset a la base de datos.
		/// </summary>
		public static void Update( twf_CaminosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_Caminos.Rows.Count > 0, "La tabla dataSet.twf_CaminosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Caminos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_CaminosDataset.twf_CaminosDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_CaminosDataset.twf_CaminosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Caminos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_CaminosRow.
		/// </summary>
		public static bool RowIsValid( twf_CaminosDataset.twf_CaminosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCaminoIsValid( row.IdCamino, out mensaje) )
			{ 
				row.SetColumnError( "IdCamino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaOrigenIsValid( row.IdTareaOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdTareaOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaDestinoIsValid( row.IdTareaDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdTareaDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProcesoIsValid( row.IdProceso, out mensaje) )
			{ 
				row.SetColumnError( "IdProceso" , mensaje);
				isValid=false;
			
			}
						
			if ( !PowerIsValid( row.Power, out mensaje) )
			{ 
				row.SetColumnError( "Power" , mensaje);
				isValid=false;
			
			}
						
			if ( !FrecuenciaIsValid( row.Frecuencia, out mensaje) )
			{ 
				row.SetColumnError( "Frecuencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexion" , mensaje);
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
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCamino.
		/// </summary>
		public static bool IdCaminoIsValid( long IdCamino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCamino. Metodo Sobrecargado
		/// </summary>
		public static bool IdCaminoIsValid( long IdCamino)
		{
			string mensaje;
			return IdCaminoIsValid( IdCamino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTareaOrigen.
		/// </summary>
		public static bool IdTareaOrigenIsValid( long IdTareaOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTareaOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaOrigenIsValid( long IdTareaOrigen)
		{
			string mensaje;
			return IdTareaOrigenIsValid( IdTareaOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTareaDestino.
		/// </summary>
		public static bool IdTareaDestinoIsValid( long IdTareaDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTareaDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaDestinoIsValid( long IdTareaDestino)
		{
			string mensaje;
			return IdTareaDestinoIsValid( IdTareaDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProceso.
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProceso. Metodo Sobrecargado
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso)
		{
			string mensaje;
			return IdProcesoIsValid( IdProceso, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Power.
		/// </summary>
		public static bool PowerIsValid( short Power , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Power. Metodo Sobrecargado
		/// </summary>
		public static bool PowerIsValid( short Power)
		{
			string mensaje;
			return PowerIsValid( Power, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Frecuencia.
		/// </summary>
		public static bool FrecuenciaIsValid( short Frecuencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Frecuencia. Metodo Sobrecargado
		/// </summary>
		public static bool FrecuenciaIsValid( short Frecuencia)
		{
			string mensaje;
			return FrecuenciaIsValid( Frecuencia, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

