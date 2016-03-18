namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_PerfilesHerramientas : IDisposable
	{
	
		#region Custom Members
		public static DataSet GetListPerfilesFor(long IdHerramienta)
		{
			return mz.erp.dataaccess.sy_PerfilesHerramientas.GetListPerfilesFor(IdHerramienta);
		}

		#endregion
		
		public sy_PerfilesHerramientas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_PerfilesHerramientas
		/// </summary>
		public static sy_PerfilesHerramientasDataset GetList()
		{
			return mz.erp.dataaccess.sy_PerfilesHerramientas.GetList();
		}

		/// <summary>
		/// Crea un sy_PerfilesHerramientasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_PerfilesHerramientas.NewRow());
		}

		public static sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow SetRowDefaultValues( sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow row )
		{
			row.IdPerfil = 0; 
			row.IdHerramienta = 0; 
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_PerfilesHerramientas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow GetByPk( long IdPerfil, long IdHerramienta )
		{
			sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow row = mz.erp.dataaccess.sy_PerfilesHerramientas.GetByPk( IdPerfil, IdHerramienta );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId" && dc.Caption != "UltimaModificacion") 
						{ 
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesHerramientasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesHerramientasRow a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesHerramientas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_PerfilesHerramientasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesHerramientasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_PerfilesHerramientas.Rows.Count > 0, "La tabla dataSet.sy_PerfilesHerramientasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesHerramientas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_PerfilesHerramientas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_PerfilesHerramientasRow.
		/// </summary>
		public static bool RowIsValid( sy_PerfilesHerramientasDataset.sy_PerfilesHerramientasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPerfilIsValid( row.IdPerfil ) )
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
		/// Valida el campo IdPerfil.
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil )
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

