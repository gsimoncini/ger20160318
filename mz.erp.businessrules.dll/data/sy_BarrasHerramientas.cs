namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_BarrasHerramientas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_BarrasHerramientas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_BarrasHerramientas
		/// </summary>
		public static sy_BarrasHerramientasDataset GetList()
		{
			return mz.erp.dataaccess.sy_BarrasHerramientas.GetList();
		}

		/// <summary>
		/// Crea un sy_BarrasHerramientasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_BarrasHerramientasDataset.sy_BarrasHerramientasRow NewRow()
		{
			return mz.erp.dataaccess.sy_BarrasHerramientas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_BarrasHerramientas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_BarrasHerramientasDataset.sy_BarrasHerramientasRow GetByPk( long IdBarraHerramienta )
		{
			return mz.erp.dataaccess.sy_BarrasHerramientas.GetByPk( IdBarraHerramienta );
		}
		
		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_BarrasHerramientasDataset.sy_BarrasHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasRow a la base de datos.
		/// </summary>
		public static void Update( sy_BarrasHerramientasDataset.sy_BarrasHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_BarrasHerramientas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_BarrasHerramientasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_BarrasHerramientas.Rows.Count > 0, "La tabla dataSet.sy_BarrasHerramientasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_BarrasHerramientas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasDataset.sy_BarrasHerramientasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_BarrasHerramientasDataset.sy_BarrasHerramientasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_BarrasHerramientas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_BarrasHerramientasRow.
		/// </summary>
		public static bool RowIsValid( sy_BarrasHerramientasDataset.sy_BarrasHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdBarraHerramientaIsValid( row.IdBarraHerramienta ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionCreacionIsValid( row.IdConexionCreacion ) )
			{ 
				return false;
			}
						
			if ( !UltimaModificacionIsValid( row.UltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion ) )
			{ 
				return false;
			}
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdBarraHerramienta.
		/// </summary>
		public static bool IdBarraHerramientaIsValid( long IdBarraHerramienta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCreacion.
		/// </summary>
		public static bool FechaCreacionIsValid( DateTime FechaCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionCreacion.
		/// </summary>
		public static bool IdConexionCreacionIsValid( long IdConexionCreacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo UltimaModificacion.
		/// </summary>
		public static bool UltimaModificacionIsValid( byte[] UltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConexionUltimaModificacion.
		/// </summary>
		public static bool IdConexionUltimaModificacionIsValid( long IdConexionUltimaModificacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo RowId.
		/// </summary>
		public static bool RowIdIsValid( Guid RowId )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}

