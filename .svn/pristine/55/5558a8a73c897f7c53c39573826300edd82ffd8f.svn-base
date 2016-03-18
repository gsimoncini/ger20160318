namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class sy_Sucursales : IDisposable
	{
	
		#region Custom Members
		public static sy_SucursalesDataset.sy_SucursalesRow GetByPk( long IdSucursal)		
		{
			return sy_Sucursales.GetByPk( IdSucursal, Security.IdEmpresa);
		}
		
		[ atMethodGetByPkRow ]
		public static sy_SucursalesDataset.sy_SucursalesRow GetByPk( object IdSucursal)
		{
			return sy_Sucursales.GetByPk( IdSucursal, (object) Security.IdEmpresa);
		}

		/// <summary>
		/// Establece los valores por defecto de sy_SucursalesRow.
		/// </summary>
		public static sy_SucursalesDataset.sy_SucursalesRow SetRowDefaultValues( sy_SucursalesDataset.sy_SucursalesRow row )
		{
			row.IdSucursal = Security.IdSucursal; 
			row.IdEmpresa = Security.IdEmpresa; 
			row.Descripcion = string.Empty;
			row.IdResponsable = string.Empty;
			row.Direccion = string.Empty;
			row.IdLocalidad = 0;
			row.CargoFijoProductos = 0;
			row.BonificacionRecargoProductos = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//		row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		

		#endregion
		
		public sy_Sucursales()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla sy_Sucursales
		/// </summary>
		public static sy_SucursalesDataset GetList()
		{
			return mz.erp.dataaccess.sy_Sucursales.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla sy_Sucursales filtrada por las condiciones de bsqueda
		/// </summary>
		public static sy_SucursalesDataset GetList( long IdSucursal, string Descripcion, string Direccion )
		{
			return mz.erp.dataaccess.sy_Sucursales.GetList( IdSucursal, Descripcion, Direccion );
		}

		/// <summary>
		/// Crea un sy_SucursalesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static sy_SucursalesDataset.sy_SucursalesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.sy_Sucursales.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Sucursales que luego puede ser persistido en la base de datos.
		/// </summary>
		public static sy_SucursalesDataset.sy_SucursalesRow GetByPk( long IdSucursal, long IdEmpresa )
		{
			sy_SucursalesDataset.sy_SucursalesRow row = mz.erp.dataaccess.sy_Sucursales.GetByPk( IdSucursal, IdEmpresa  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla sy_Sucursales que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		
		public static sy_SucursalesDataset.sy_SucursalesRow GetByPk( object IdSucursal, object IdEmpresa )
		{
			return GetByPk( ( long )IdSucursal, ( long )IdEmpresa );
		}

	
		/// <summary>
		/// Envia los cambios del sy_SucursalesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( sy_SucursalesDataset.sy_SucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del sy_SucursalesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( sy_SucursalesDataset.sy_SucursalesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del sy_SucursalesRow a la base de datos.
		/// </summary>
		public static void Update( sy_SucursalesDataset.sy_SucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Sucursales.Update( row );
		}

		/// <summary>
		/// Envia los cambios del sy_SucursalesDataset a la base de datos.
		/// </summary>
		public static void Update( sy_SucursalesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.sy_Sucursales.Rows.Count > 0, "La tabla dataSet.sy_SucursalesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Sucursales.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del sy_SucursalesDataset.sy_SucursalesDataTable a la base de datos.
		/// </summary>
		public static void Update( sy_SucursalesDataset.sy_SucursalesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.sy_Sucursales.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un sy_SucursalesRow.
		/// </summary>
		public static bool RowIsValid( sy_SucursalesDataset.sy_SucursalesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdResponsableIsValid( row.IdResponsable, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsable" , mensaje);
				isValid=false;
			
			}
						
			if ( !DireccionIsValid( row.Direccion, out mensaje) )
			{ 
				row.SetColumnError( "Direccion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdLocalidadIsValid( row.IdLocalidad, out mensaje) )
			{ 
				row.SetColumnError( "IdLocalidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !CargoFijoProductosIsValid( row.CargoFijoProductos, out mensaje) )
			{ 
				row.SetColumnError( "CargoFijoProductos" , mensaje);
				isValid=false;
			
			}
						
			if ( !BonificacionRecargoProductosIsValid( row.BonificacionRecargoProductos, out mensaje) )
			{ 
				row.SetColumnError( "BonificacionRecargoProductos" , mensaje);
				isValid=false;
			
			}
						
		/*	if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
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
			
			}*/
			;
			
			return isValid;
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
		/// Valida el campo IdResponsable.
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdResponsable. Metodo Sobrecargado
		/// </summary>
		public static bool IdResponsableIsValid( string IdResponsable)
		{
			string mensaje;
			return IdResponsableIsValid( IdResponsable, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Direccion.
		/// </summary>
		public static bool DireccionIsValid( string Direccion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Direccion. Metodo Sobrecargado
		/// </summary>
		public static bool DireccionIsValid( string Direccion)
		{
			string mensaje;
			return DireccionIsValid( Direccion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdLocalidad.
		/// </summary>
		public static bool IdLocalidadIsValid( long IdLocalidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdLocalidad. Metodo Sobrecargado
		/// </summary>
		public static bool IdLocalidadIsValid( long IdLocalidad)
		{
			string mensaje;
			return IdLocalidadIsValid( IdLocalidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CargoFijoProductos.
		/// </summary>
		public static bool CargoFijoProductosIsValid( decimal CargoFijoProductos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CargoFijoProductos. Metodo Sobrecargado
		/// </summary>
		public static bool CargoFijoProductosIsValid( decimal CargoFijoProductos)
		{
			string mensaje;
			return CargoFijoProductosIsValid( CargoFijoProductos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo BonificacionRecargoProductos.
		/// </summary>
		public static bool BonificacionRecargoProductosIsValid( decimal BonificacionRecargoProductos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargoProductos. Metodo Sobrecargado
		/// </summary>
		public static bool BonificacionRecargoProductosIsValid( decimal BonificacionRecargoProductos)
		{
			string mensaje;
			return BonificacionRecargoProductosIsValid( BonificacionRecargoProductos, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

