namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Puestos : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Puestos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Puestos
		/// </summary>
		public static sy_PuestosDataset GetList()
		{
			return mz.erp.dataaccess.sy_Puestos.GetList();
		}

		/// <summary>
		/// Crea un sy_PuestosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_PuestosDataset.sy_PuestosRow NewRow()
		{
			sy_PuestosDataset.sy_PuestosRow row =  mz.erp.dataaccess.sy_Puestos.NewRow();
			row.Activo = true;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			return row;
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Puestos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_PuestosDataset.sy_PuestosRow GetByPk( long IdPuesto )
		{
			return mz.erp.dataaccess.sy_Puestos.GetByPk( IdPuesto );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PuestosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_PuestosDataset.sy_PuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_PuestosRow a la base de datos.
		/// </summary>
		public static void Update( sy_PuestosDataset.sy_PuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Puestos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_PuestosDataset a la base de datos.
		/// </summary>
		public static void Update( sy_PuestosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Puestos.Rows.Count > 0, "La tabla dataSet.sy_PuestosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Puestos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_PuestosDataset.sy_PuestosDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_PuestosDataset.sy_PuestosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Puestos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_PuestosRow.
		/// </summary>
		public static bool RowIsValid( sy_PuestosDataset.sy_PuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdPuestoIsValid( row.IdPuesto ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !IdHardwareIsValid( row.IdHardware ) )
			{ 
				return false;
			}
						
			if ( !UbicacionIsValid( row.Ubicacion ) )
			{ 
				return false;
			}
						
			if ( !UsuarioSOIsValid( row.UsuarioSO ) )
			{ 
				return false;
			}
						
			if ( !ActivoIsValid( row.Activo ) )
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
		/// Valida el campo IdPuesto.
		/// </summary>
		public static bool IdPuestoIsValid( long IdPuesto )
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
		/// Valida el campo IdHardware.
		/// </summary>
		public static bool IdHardwareIsValid( string IdHardware )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ubicacion.
		/// </summary>
		public static bool UbicacionIsValid( string Ubicacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo UsuarioSO.
		/// </summary>
		public static bool UsuarioSOIsValid( string UsuarioSO )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo )
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

