namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_PaisesProvincias : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetListByIdProvincia( long IdProvincia)
		{
			return mz.erp.dataaccess.tsh_PaisesProvincias.GetListByIdProvincia(IdProvincia);
		}


		public static tsh_ProvinciasDataset GetListProvincias( long IdPais)
		{
			return mz.erp.dataaccess.tsh_PaisesProvincias.GetListProvincias(IdPais);
		}

		#endregion
		
		public tsh_PaisesProvincias()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_PaisesProvincias
		/// </summary>
		public static tsh_PaisesProvinciasDataset GetList()
		{
			return mz.erp.dataaccess.tsh_PaisesProvincias.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_PaisesProvincias filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_PaisesProvinciasDataset GetList( long IdPais, long IdProvincia, long IdEmpresa, long IdSucursal)
		{
			return mz.erp.dataaccess.tsh_PaisesProvincias.GetList( IdPais, IdProvincia, IdEmpresa, IdSucursal);
		}

		/// <summary>
		/// Crea un tsh_PaisesProvinciasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_PaisesProvincias.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_PaisesProvincias que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow GetByPk( long IdPais, long IdProvincia )
		{
			tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow row = mz.erp.dataaccess.tsh_PaisesProvincias.GetByPk( IdPais, IdProvincia  );
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
		/// Obtiene un registro de la tabla tsh_PaisesProvincias que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow GetByPk( object IdPais, object IdProvincia )
		{
			return GetByPk( ( long )IdPais, ( long )IdProvincia );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_PaisesProvinciasRow.
		/// </summary>
		public static tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow SetRowDefaultValues( tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow row )
		{
			row.IdPais = 0; 
			row.IdProvincia = 0; 
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PaisesProvinciasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PaisesProvinciasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PaisesProvinciasRow a la base de datos.
		/// </summary>
		public static void Update( tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_PaisesProvincias.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_PaisesProvinciasDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_PaisesProvinciasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_PaisesProvincias.Rows.Count > 0, "La tabla dataSet.tsh_PaisesProvinciasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_PaisesProvincias.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_PaisesProvincias.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_PaisesProvinciasRow.
		/// </summary>
		public static bool RowIsValid( tsh_PaisesProvinciasDataset.tsh_PaisesProvinciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdPaisIsValid( row.IdPais, out mensaje) )
			{ 
				row.SetColumnError( "IdPais" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProvinciaIsValid( row.IdProvincia, out mensaje) )
			{ 
				row.SetColumnError( "IdProvincia" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdPais.
		/// </summary>
		public static bool IdPaisIsValid( long IdPais , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPais. Metodo Sobrecargado
		/// </summary>
		public static bool IdPaisIsValid( long IdPais)
		{
			string mensaje;
			return IdPaisIsValid( IdPais, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProvincia.
		/// </summary>
		public static bool IdProvinciaIsValid( long IdProvincia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProvincia. Metodo Sobrecargado
		/// </summary>
		public static bool IdProvinciaIsValid( long IdProvincia)
		{
			string mensaje;
			return IdProvinciaIsValid( IdProvincia, out mensaje );
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

