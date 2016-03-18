namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_Entidades : IDisposable
	{
	
		#region Custom Members

		public static tfi_EntidadesDataset.tfi_EntidadesRow GetByCodigo( string Codigo )
		{
			tfi_EntidadesDataset.tfi_EntidadesRow row = mz.erp.dataaccess.tfi_Entidades.GetByCodigo( Codigo  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;
		}

		#endregion
		
		public tfi_Entidades()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_Entidades
		/// </summary>
		public static tfi_EntidadesDataset GetList()
		{
			return mz.erp.dataaccess.tfi_Entidades.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_Entidades filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_EntidadesDataset GetList( string Codigo, string Descripcion )
		{
			return mz.erp.dataaccess.tfi_Entidades.GetList( Codigo, Descripcion );
		}

		/// <summary>
		/// Crea un tfi_EntidadesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_EntidadesDataset.tfi_EntidadesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_Entidades.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_Entidades que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_EntidadesDataset.tfi_EntidadesRow GetByPk( string IdEntidad )
		{
			tfi_EntidadesDataset.tfi_EntidadesRow row = mz.erp.dataaccess.tfi_Entidades.GetByPk( IdEntidad  );
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
		/// Obtiene un registro de la tabla tfi_Entidades que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_EntidadesDataset.tfi_EntidadesRow GetByPk( object IdEntidad )
		{
			return GetByPk( ( string )IdEntidad );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_EntidadesRow.
		/// </summary>
		public static tfi_EntidadesDataset.tfi_EntidadesRow SetRowDefaultValues( tfi_EntidadesDataset.tfi_EntidadesRow row )
		{
			row.IdEntidad = Util.NewStringId(); 
			row.Codigo = string.Empty;
			row.Descripcion = string.Empty;
			row.Sistema = false;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdNomenclatura = string.Empty;
			//row.ActivoPorDefault = false;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EntidadesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_EntidadesDataset.tfi_EntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EntidadesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_EntidadesDataset.tfi_EntidadesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EntidadesRow a la base de datos.
		/// </summary>
		public static void Update( tfi_EntidadesDataset.tfi_EntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Entidades.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_EntidadesDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_EntidadesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_Entidades.Rows.Count > 0, "La tabla dataSet.tfi_EntidadesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Entidades.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EntidadesDataset.tfi_EntidadesDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_EntidadesDataset.tfi_EntidadesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Entidades.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_EntidadesRow.
		/// </summary>
		public static bool RowIsValid( tfi_EntidadesDataset.tfi_EntidadesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdEntidadIsValid( row.IdEntidad, out mensaje) )
			{ 
				row.SetColumnError( "IdEntidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoIsValid( row.Codigo, out mensaje) )
			{ 
				row.SetColumnError( "Codigo" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !SistemaIsValid( row.Sistema, out mensaje) )
			{ 
				row.SetColumnError( "Sistema" , mensaje);
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
			
			}
						
			if ( !IdConexionUltimaModificacionIsValid( row.IdConexionUltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "IdConexionUltimaModificacion" , mensaje);
				isValid=false;
			
			}*/
						
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
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoIsValid( string Codigo)
		{
			string mensaje;
			return CodigoIsValid( Codigo, out mensaje );
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
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema. Metodo Sobrecargado
		/// </summary>
		public static bool SistemaIsValid( bool Sistema)
		{
			string mensaje;
			return SistemaIsValid( Sistema, out mensaje );
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


