namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Empresas : IDisposable
	{
	
		#region Custom Members

		public static sy_EmpresasDataset GetList( string IdUsuario )
		{
			return mz.erp.dataaccess.sy_Empresas.GetList( IdUsuario );
		}
		
	
		#endregion
		
		public sy_Empresas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Empresas
		/// </summary>
		public static sy_EmpresasDataset GetList()
		{
			return mz.erp.dataaccess.sy_Empresas.GetList();
		}

		/// <summary>
		/// Crea un sy_EmpresasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_EmpresasDataset.sy_EmpresasRow NewRow()
		{
			return mz.erp.dataaccess.sy_Empresas.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Empresas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_EmpresasDataset.sy_EmpresasRow GetByPk( long IdEmpresa )
		{
			return mz.erp.dataaccess.sy_Empresas.GetByPk( IdEmpresa );
		}
		
		/// <summary>
		/// Envia los cambios del sy_EmpresasRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( sy_EmpresasDataset.sy_EmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del sy_EmpresasRow a la base de datos.
		/// </summary>
		public static void Update( sy_EmpresasDataset.sy_EmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Empresas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_EmpresasDataset a la base de datos.
		/// </summary>
		public static void Update( sy_EmpresasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Empresas.Rows.Count > 0, "La tabla dataSet.sy_EmpresasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Empresas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_EmpresasDataset.sy_EmpresasDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_EmpresasDataset.sy_EmpresasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			if(IsValidTable(dataTable))
			{
				mz.erp.dataaccess.sy_Empresas.Update( dataTable );
			}
		}


		private static bool IsValidTable( sy_EmpresasDataset.sy_EmpresasDataTable dataTable )
		{

			bool ok = true;
			foreach(sy_EmpresasDataset.sy_EmpresasRow row in dataTable.Rows)
			{
				
				if(row.RowState.Equals(DataRowState.Deleted))
				{
					row.RowError = "No se puede borrar una empresa";
					return false;
				}
				else
					ok = ok && RowIsValid(row);
			}
			return ok;
		}
		
		/// <summary>
		/// Valida un sy_EmpresasRow.
		/// </summary>
		public static bool RowIsValid( sy_EmpresasDataset.sy_EmpresasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				row.RowError = "Debe ingresar el nombre de la empresa.";
				return false;
			}
						
			if ( !ConexionIsValid( row.Conexion ) )
			{ 
				return false;
			}
						
			if ( !BaseDeDatosIsValid( row.BaseDeDatos ) )
			{ 
				return false;
			}
						
			if ( !UsuarioIsValid( row.Usuario ) )
			{ 
				return false;
			}
						
			if ( !PasswordIsValid( row.Password ) )
			{ 
				return false;
			}
						
			if ( !ActivoIsValid( row.Activo ) )
			{ 
				return false;
			}
				/*		
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
			*/
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa )
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
			if(Descripcion == null || Descripcion.Equals(string.Empty))
				return false;
			return true;
		}
		
		/// <summary>
		/// Valida el campo Conexion.
		/// </summary>
		public static bool ConexionIsValid( string Conexion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo BaseDeDatos.
		/// </summary>
		public static bool BaseDeDatosIsValid( string BaseDeDatos )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Usuario.
		/// </summary>
		public static bool UsuarioIsValid( string Usuario )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Password.
		/// </summary>
		public static bool PasswordIsValid( string Password )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( string Activo )
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

