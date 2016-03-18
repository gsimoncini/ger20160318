namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_ProductosValoresCampoAuxiliarBusqueda : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_ProductosValoresCampoAuxiliarBusqueda()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosValoresCampoAuxiliarBusqueda
		/// </summary>
		public static tsh_ProductosValoresCampoAuxiliarBusquedaDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_ProductosValoresCampoAuxiliarBusqueda filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_ProductosValoresCampoAuxiliarBusquedaDataset GetList( string IdCampoBusqueda, string Descripcion, bool Activo )
		{
			return mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.GetList( IdCampoBusqueda, Descripcion, Activo );
		}

		/// <summary>
		/// Crea un tsh_ProductosValoresCampoAuxiliarBusquedaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosValoresCampoAuxiliarBusqueda que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow GetByPk( string IdCampoBusqueda )
		{
			tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow row = mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.GetByPk( IdCampoBusqueda  );
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
		/// Obtiene un registro de la tabla tsh_ProductosValoresCampoAuxiliarBusqueda que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow GetByPk( object IdCampoBusqueda )
		{
			return GetByPk( ( string )IdCampoBusqueda );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosValoresCampoAuxiliarBusquedaRow.
		/// </summary>
		public static tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow SetRowDefaultValues( tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow row )
		{
			row.IdCampoBusqueda = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosValoresCampoAuxiliarBusquedaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosValoresCampoAuxiliarBusquedaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosValoresCampoAuxiliarBusquedaRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosValoresCampoAuxiliarBusquedaDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosValoresCampoAuxiliarBusquedaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosValoresCampoAuxiliarBusqueda.Rows.Count > 0, "La tabla dataSet.tsh_ProductosValoresCampoAuxiliarBusquedaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosValoresCampoAuxiliarBusqueda.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosValoresCampoAuxiliarBusquedaRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosValoresCampoAuxiliarBusquedaDataset.tsh_ProductosValoresCampoAuxiliarBusquedaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCampoBusquedaIsValid( row.IdCampoBusqueda, out mensaje) )
			{ 
				row.SetColumnError( "IdCampoBusqueda" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
		/// Valida el campo IdCampoBusqueda.
		/// </summary>
		public static bool IdCampoBusquedaIsValid( string IdCampoBusqueda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCampoBusqueda. Metodo Sobrecargado
		/// </summary>
		public static bool IdCampoBusquedaIsValid( string IdCampoBusqueda)
		{
			string mensaje;
			return IdCampoBusquedaIsValid( IdCampoBusqueda, out mensaje );
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

