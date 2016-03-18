namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_BarrasHerramientasHerramientas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_BarrasHerramientasHerramientas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_BarrasHerramientasHerramientas
		/// </summary>
		public static sy_BarrasHerramientasHerramientasDataset GetList()
		{
			return mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.GetList();
		}

		/// <summary>
		/// Crea un sy_BarrasHerramientasHerramientasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow NewRow()
		{
			return (sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow)SetRowDefaultValues(mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.NewRow());
		}

		public static DataRow SetRowDefaultValues( DataRow row )
		{
			row["IdBarraHerramienta"] = 0; 
			row["IdHerramienta"] = 0; 
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row["UltimaModificacion"] = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["RowId"] = Guid.Empty;

			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_BarrasHerramientasHerramientas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow GetByPk( long IdBarraHerramienta, long IdHerramienta )
		{
			return mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.GetByPk( IdBarraHerramienta, IdHerramienta );
		}
		
		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasHerramientasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasHerramientasRow a la base de datos.
		/// </summary>
		public static void Update( sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasHerramientasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_BarrasHerramientasHerramientasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_BarrasHerramientasHerramientas.Rows.Count > 0, "La tabla dataSet.sy_BarrasHerramientasHerramientasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_BarrasHerramientasHerramientas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_BarrasHerramientasHerramientasRow.
		/// </summary>
		public static bool RowIsValid( sy_BarrasHerramientasHerramientasDataset.sy_BarrasHerramientasHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			//row.RowState = DataRowState.Added
			
			if ( !IdBarraHerramientaIsValid( row.IdBarraHerramienta ) )
			{ 
				return false;
			}
						
			if ( !IdHerramientaIsValid( row.IdHerramienta ) )
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
		/// Valida el campo IdHerramienta.
		/// </summary>
		public static bool IdHerramientaIsValid( long IdHerramienta )
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

