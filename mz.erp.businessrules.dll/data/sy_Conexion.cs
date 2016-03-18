namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Conexion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public sy_Conexion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Conexion
		/// </summary>
		public static sy_ConexionDataset GetList()
		{
			return mz.erp.dataaccess.sy_Conexion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_Conexion filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_ConexionDataset GetList( long IdConexion, string IdUsuario, long IdPerfil, long IdEmpresa, long IdPuesto, DateTime FechaInicio, DateTime FechaFinal, short IntentosFallidosConexion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			return mz.erp.dataaccess.sy_Conexion.GetList( IdConexion, IdUsuario, IdPerfil, IdEmpresa, IdPuesto, FechaInicio, FechaFinal, IntentosFallidosConexion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}

		/// <summary>
		/// Crea un sy_ConexionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_ConexionDataset.sy_ConexionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_Conexion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Conexion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_ConexionDataset.sy_ConexionRow GetByPk( long IdConexion )
		{
			sy_ConexionDataset.sy_ConexionRow row = mz.erp.dataaccess.sy_Conexion.GetByPk( IdConexion  );
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
		/// Obtiene un registro de la tabla sy_Conexion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static sy_ConexionDataset.sy_ConexionRow GetByPk( object IdConexion )
		{
			return GetByPk( ( long )IdConexion );
		}

		/// <summary>
		/// Establece los valores por defecto de sy_ConexionRow.
		/// </summary>
		public static sy_ConexionDataset.sy_ConexionRow SetRowDefaultValues( sy_ConexionDataset.sy_ConexionRow row )
		{
			row.IdConexion = 0; 
			row.IdUsuario = string.Empty;
			row.IdPerfil = 0;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdPuesto = 0;
			row.FechaInicio = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaFinal = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IntentosFallidosConexion = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConexionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_ConexionDataset.sy_ConexionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConexionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_ConexionDataset.sy_ConexionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConexionRow a la base de datos.
		/// </summary>
		public static void Update( sy_ConexionDataset.sy_ConexionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Conexion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_ConexionDataset a la base de datos.
		/// </summary>
		public static void Update( sy_ConexionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Conexion.Rows.Count > 0, "La tabla dataSet.sy_ConexionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Conexion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_ConexionDataset.sy_ConexionDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_ConexionDataset.sy_ConexionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Conexion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_ConexionRow.
		/// </summary>
		public static bool RowIsValid( sy_ConexionDataset.sy_ConexionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdConexionIsValid( row.IdConexion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdUsuarioIsValid( row.IdUsuario, out mensaje) )
			{ 
				row.SetColumnError( "IdUsuario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPerfilIsValid( row.IdPerfil, out mensaje) )
			{ 
				row.SetColumnError( "IdPerfil" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdPuestoIsValid( row.IdPuesto, out mensaje) )
			{ 
				row.SetColumnError( "IdPuesto" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaInicioIsValid( row.FechaInicio, out mensaje) )
			{ 
				row.SetColumnError( "FechaInicio" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaFinalIsValid( row.FechaFinal, out mensaje) )
			{ 
				row.SetColumnError( "FechaFinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IntentosFallidosConexionIsValid( row.IntentosFallidosConexion, out mensaje) )
			{ 
				row.SetColumnError( "IntentosFallidosConexion" , mensaje);
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
						
		/*	if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}*/
						
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
		/// Valida el campo IdUsuario.
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUsuario. Metodo Sobrecargado
		/// </summary>
		public static bool IdUsuarioIsValid( string IdUsuario)
		{
			string mensaje;
			return IdUsuarioIsValid( IdUsuario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPerfil.
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPerfil. Metodo Sobrecargado
		/// </summary>
		public static bool IdPerfilIsValid( long IdPerfil)
		{
			string mensaje;
			return IdPerfilIsValid( IdPerfil, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPuesto.
		/// </summary>
		public static bool IdPuestoIsValid( long IdPuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPuesto. Metodo Sobrecargado
		/// </summary>
		public static bool IdPuestoIsValid( long IdPuesto)
		{
			string mensaje;
			return IdPuestoIsValid( IdPuesto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaInicio.
		/// </summary>
		public static bool FechaInicioIsValid( DateTime FechaInicio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaInicio. Metodo Sobrecargado
		/// </summary>
		public static bool FechaInicioIsValid( DateTime FechaInicio)
		{
			string mensaje;
			return FechaInicioIsValid( FechaInicio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaFinal.
		/// </summary>
		public static bool FechaFinalIsValid( DateTime FechaFinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaFinal. Metodo Sobrecargado
		/// </summary>
		public static bool FechaFinalIsValid( DateTime FechaFinal)
		{
			string mensaje;
			return FechaFinalIsValid( FechaFinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IntentosFallidosConexion.
		/// </summary>
		public static bool IntentosFallidosConexionIsValid( short IntentosFallidosConexion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IntentosFallidosConexion. Metodo Sobrecargado
		/// </summary>
		public static bool IntentosFallidosConexionIsValid( short IntentosFallidosConexion)
		{
			string mensaje;
			return IntentosFallidosConexionIsValid( IntentosFallidosConexion, out mensaje );
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

