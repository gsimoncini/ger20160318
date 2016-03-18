namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionFamiliaFDPEntidades : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tui_ConfiguracionFamiliaFDPEntidades()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionFamiliaFDPEntidades
		/// </summary>
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionFamiliaFDPEntidades filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset GetList( string Familia, string IdEntidad )
		{
			return mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.GetList( Familia, IdEntidad );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionFamiliaFDPEntidadesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionFamiliaFDPEntidades que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow GetByPk( string Familia, string IdEntidad )
		{
			tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow row = mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.GetByPk( Familia, IdEntidad  );
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
		/// Obtiene un registro de la tabla tui_ConfiguracionFamiliaFDPEntidades que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow GetByPk( object Familia, object IdEntidad )
		{
			return GetByPk( ( string )Familia, ( string )IdEntidad );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionFamiliaFDPEntidadesRow.
		/// </summary>
		public static tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow SetRowDefaultValues( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow row )
		{
			row.Familia = Util.NewStringId(); 
			row.IdEntidad = Util.NewStringId(); 
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFamiliaFDPEntidadesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFamiliaFDPEntidadesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFamiliaFDPEntidadesRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFamiliaFDPEntidadesDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionFamiliaFDPEntidadesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionFamiliaFDPEntidades.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionFamiliaFDPEntidadesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionFamiliaFDPEntidades.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionFamiliaFDPEntidadesRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionFamiliaFDPEntidadesDataset.tui_ConfiguracionFamiliaFDPEntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !FamiliaIsValid( row.Familia, out mensaje) )
			{ 
				row.SetColumnError( "Familia" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEntidadIsValid( row.IdEntidad, out mensaje) )
			{ 
				row.SetColumnError( "IdEntidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo Familia.
		/// </summary>
		public static bool FamiliaIsValid( string Familia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Familia. Metodo Sobrecargado
		/// </summary>
		public static bool FamiliaIsValid( string Familia)
		{
			string mensaje;
			return FamiliaIsValid( Familia, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEntidad.
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEntidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdEntidadIsValid( string IdEntidad)
		{
			string mensaje;
			return IdEntidadIsValid( IdEntidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
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
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdReservado. Metodo Sobrecargado
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado)
		{
			string mensaje;
			return IdReservadoIsValid( IdReservado, out mensaje );
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
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

