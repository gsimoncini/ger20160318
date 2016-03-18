namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class twf_Dependencias : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public twf_Dependencias()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla twf_Dependencias
		/// </summary>
		public static twf_DependenciasDataset GetList()
		{
			return mz.erp.dataaccess.twf_Dependencias.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla twf_Dependencias filtrada por las condiciones de bsqueda
		/// </summary>
		public static twf_DependenciasDataset GetList( long IdDependencia, long IdCamino, long IdTarea, long IdConexion, short Orden, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, string Observaciones )
		{
			return mz.erp.dataaccess.twf_Dependencias.GetList( IdDependencia, IdCamino, IdTarea, IdConexion, Orden, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId, Observaciones );
		}

		/// <summary>
		/// Crea un twf_DependenciasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static twf_DependenciasDataset.twf_DependenciasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.twf_Dependencias.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla twf_Dependencias que luego puede ser persistido en la base de datos.
		/// </summary>
		public static twf_DependenciasDataset.twf_DependenciasRow GetByPk( long IdDependencia )
		{
			twf_DependenciasDataset.twf_DependenciasRow row = mz.erp.dataaccess.twf_Dependencias.GetByPk( IdDependencia  );
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
		/// Obtiene un registro de la tabla twf_Dependencias que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static twf_DependenciasDataset.twf_DependenciasRow GetByPk( object IdDependencia )
		{
			return GetByPk( ( long )IdDependencia );
		}

		/// <summary>
		/// Establece los valores por defecto de twf_DependenciasRow.
		/// </summary>
		public static twf_DependenciasDataset.twf_DependenciasRow SetRowDefaultValues( twf_DependenciasDataset.twf_DependenciasRow row )
		{
			row.IdDependencia = 0; 
			row.IdCamino = 0;
			row.IdTarea = 0;
			row.IdConexion = 0;
			row.Orden = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.Observaciones = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del twf_DependenciasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( twf_DependenciasDataset.twf_DependenciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del twf_DependenciasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( twf_DependenciasDataset.twf_DependenciasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del twf_DependenciasRow a la base de datos.
		/// </summary>
		public static void Update( twf_DependenciasDataset.twf_DependenciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Dependencias.Update( row );
		}

		/// <summary>
		/// Envia los cambios del twf_DependenciasDataset a la base de datos.
		/// </summary>
		public static void Update( twf_DependenciasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.twf_Dependencias.Rows.Count > 0, "La tabla dataSet.twf_DependenciasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Dependencias.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del twf_DependenciasDataset.twf_DependenciasDataTable a la base de datos.
		/// </summary>
		public static void Update( twf_DependenciasDataset.twf_DependenciasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.twf_Dependencias.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un twf_DependenciasRow.
		/// </summary>
		public static bool RowIsValid( twf_DependenciasDataset.twf_DependenciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdDependenciaIsValid( row.IdDependencia, out mensaje) )
			{ 
				row.SetColumnError( "IdDependencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCaminoIsValid( row.IdCamino, out mensaje) )
			{ 
				row.SetColumnError( "IdCamino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexion" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenIsValid( row.Orden, out mensaje) )
			{ 
				row.SetColumnError( "Orden" , mensaje);
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
		/// Valida el campo IdDependencia.
		/// </summary>
		public static bool IdDependenciaIsValid( long IdDependencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDependencia. Metodo Sobrecargado
		/// </summary>
		public static bool IdDependenciaIsValid( long IdDependencia)
		{
			string mensaje;
			return IdDependenciaIsValid( IdDependencia, out mensaje );
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
		/// Valida el campo Orden.
		/// </summary>
		public static bool OrdenIsValid( short Orden , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Orden. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenIsValid( short Orden)
		{
			string mensaje;
			return OrdenIsValid( Orden, out mensaje );
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


