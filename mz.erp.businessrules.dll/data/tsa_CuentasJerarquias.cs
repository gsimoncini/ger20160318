using System;

namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_CuentasJerarquias : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_CuentasJerarquias()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CuentasJerarquias
		/// </summary>
		public static tsa_CuentasJerarquiasDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CuentasJerarquias.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_CuentasJerarquias filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_CuentasJerarquiasDataset GetList( string IdCuenta, string IdNomenclatura1a, string IdNomenclatura1b, string IdNomenclatura1c, string IdNomenclatura1d, string IdNomenclatura2a, string IdNomenclatura2b, string IdNomenclatura2c, string IdNomenclatura2d, string IdNomenclatura3a, string IdNomenclatura3b, string IdNomenclatura3c, string IdNomenclatura3d, string IdNomenclatura4a, string IdNomenclatura4b, string IdNomenclatura4c, string IdNomenclatura4d, string IdNomenclatura5a, string IdNomenclatura5b, string IdNomenclatura5c, string IdNomenclatura5d, string IdNomenclatura6a, string IdNomenclatura6b, string IdNomenclatura6c, string IdNomenclatura6d, string IdNomenclatura7a, string IdNomenclatura7b, string IdNomenclatura7c, string IdNomenclatura7d, string IdNomenclatura8a, string IdNomenclatura8b, string IdNomenclatura8c, string IdNomenclatura8d, string IdNomenclatura9a, string IdNomenclatura9b, string IdNomenclatura9c, string IdNomenclatura9d, string IdNomenclatura10a, string IdNomenclatura10b, string IdNomenclatura10c, string IdNomenclatura10d, bool Activo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tsa_CuentasJerarquias.GetList( IdCuenta, IdNomenclatura1a, IdNomenclatura1b, IdNomenclatura1c, IdNomenclatura1d, IdNomenclatura2a, IdNomenclatura2b, IdNomenclatura2c, IdNomenclatura2d, IdNomenclatura3a, IdNomenclatura3b, IdNomenclatura3c, IdNomenclatura3d, IdNomenclatura4a, IdNomenclatura4b, IdNomenclatura4c, IdNomenclatura4d, IdNomenclatura5a, IdNomenclatura5b, IdNomenclatura5c, IdNomenclatura5d, IdNomenclatura6a, IdNomenclatura6b, IdNomenclatura6c, IdNomenclatura6d, IdNomenclatura7a, IdNomenclatura7b, IdNomenclatura7c, IdNomenclatura7d, IdNomenclatura8a, IdNomenclatura8b, IdNomenclatura8c, IdNomenclatura8d, IdNomenclatura9a, IdNomenclatura9b, IdNomenclatura9c, IdNomenclatura9d, IdNomenclatura10a, IdNomenclatura10b, IdNomenclatura10c, IdNomenclatura10d, Activo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tsa_CuentasJerarquiasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_CuentasJerarquias.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasJerarquias que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow GetByPk( string IdCuenta )
		{
			tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row = mz.erp.dataaccess.tsa_CuentasJerarquias.GetByPk( IdCuenta  );
			if (row !=null)
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
		/// Obtiene un registro de la tabla tsa_CuentasJerarquias que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow GetByPk( object IdCuenta )
		{
			return GetByPk( ( string )IdCuenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasJerarquiasRow.
		/// </summary>
		public static tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow SetRowDefaultValues( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.IdNomenclatura1a = string.Empty;
			row.IdNomenclatura1b = string.Empty;
			row.IdNomenclatura1c = string.Empty;
			row.IdNomenclatura1d = string.Empty;
			row.IdNomenclatura2a = string.Empty;
			row.IdNomenclatura2b = string.Empty;
			row.IdNomenclatura2c = string.Empty;
			row.IdNomenclatura2d = string.Empty;
			row.IdNomenclatura3a = string.Empty;
			row.IdNomenclatura3b = string.Empty;
			row.IdNomenclatura3c = string.Empty;
			row.IdNomenclatura3d = string.Empty;
			row.IdNomenclatura4a = string.Empty;
			row.IdNomenclatura4b = string.Empty;
			row.IdNomenclatura4c = string.Empty;
			row.IdNomenclatura4d = string.Empty;
			row.IdNomenclatura5a = string.Empty;
			row.IdNomenclatura5b = string.Empty;
			row.IdNomenclatura5c = string.Empty;
			row.IdNomenclatura5d = string.Empty;
			row.IdNomenclatura6a = string.Empty;
			row.IdNomenclatura6b = string.Empty;
			row.IdNomenclatura6c = string.Empty;
			row.IdNomenclatura6d = string.Empty;
			row.IdNomenclatura7a = string.Empty;
			row.IdNomenclatura7b = string.Empty;
			row.IdNomenclatura7c = string.Empty;
			row.IdNomenclatura7d = string.Empty;
			row.IdNomenclatura8a = string.Empty;
			row.IdNomenclatura8b = string.Empty;
			row.IdNomenclatura8c = string.Empty;
			row.IdNomenclatura8d = string.Empty;
			row.IdNomenclatura9a = string.Empty;
			row.IdNomenclatura9b = string.Empty;
			row.IdNomenclatura9c = string.Empty;
			row.IdNomenclatura9d = string.Empty;
			row.IdNomenclatura10a = string.Empty;
			row.IdNomenclatura10b = string.Empty;
			row.IdNomenclatura10c = string.Empty;
			row.IdNomenclatura10d = string.Empty;
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
		/// Envia los cambios del tsa_CuentasJerarquiasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasJerarquiasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasJerarquiasRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasJerarquias.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasJerarquiasDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasJerarquiasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CuentasJerarquias.Rows.Count > 0, "La tabla dataSet.tsa_CuentasJerarquiasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasJerarquias.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasJerarquias.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CuentasJerarquiasRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasJerarquiasDataset.tsa_CuentasJerarquiasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura1aIsValid( row.IdNomenclatura1a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura1a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura1bIsValid( row.IdNomenclatura1b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura1b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura1cIsValid( row.IdNomenclatura1c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura1c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura1dIsValid( row.IdNomenclatura1d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura1d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura2aIsValid( row.IdNomenclatura2a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura2a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura2bIsValid( row.IdNomenclatura2b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura2b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura2cIsValid( row.IdNomenclatura2c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura2c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura2dIsValid( row.IdNomenclatura2d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura2d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura3aIsValid( row.IdNomenclatura3a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura3a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura3bIsValid( row.IdNomenclatura3b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura3b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura3cIsValid( row.IdNomenclatura3c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura3c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura3dIsValid( row.IdNomenclatura3d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura3d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura4aIsValid( row.IdNomenclatura4a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura4a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura4bIsValid( row.IdNomenclatura4b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura4b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura4cIsValid( row.IdNomenclatura4c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura4c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura4dIsValid( row.IdNomenclatura4d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura4d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura5aIsValid( row.IdNomenclatura5a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura5a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura5bIsValid( row.IdNomenclatura5b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura5b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura5cIsValid( row.IdNomenclatura5c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura5c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura5dIsValid( row.IdNomenclatura5d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura5d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura6aIsValid( row.IdNomenclatura6a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura6a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura6bIsValid( row.IdNomenclatura6b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura6b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura6cIsValid( row.IdNomenclatura6c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura6c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura6dIsValid( row.IdNomenclatura6d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura6d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura7aIsValid( row.IdNomenclatura7a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura7a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura7bIsValid( row.IdNomenclatura7b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura7b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura7cIsValid( row.IdNomenclatura7c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura7c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura7dIsValid( row.IdNomenclatura7d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura7d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura8aIsValid( row.IdNomenclatura8a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura8a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura8bIsValid( row.IdNomenclatura8b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura8b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura8cIsValid( row.IdNomenclatura8c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura8c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura8dIsValid( row.IdNomenclatura8d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura8d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura9aIsValid( row.IdNomenclatura9a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura9a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura9bIsValid( row.IdNomenclatura9b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura9b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura9cIsValid( row.IdNomenclatura9c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura9c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura9dIsValid( row.IdNomenclatura9d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura9d" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura10aIsValid( row.IdNomenclatura10a, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura10a" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura10bIsValid( row.IdNomenclatura10b, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura10b" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura10cIsValid( row.IdNomenclatura10c, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura10c" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclatura10dIsValid( row.IdNomenclatura10d, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura10d" , mensaje);
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
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura1a.
		/// </summary>
		public static bool IdNomenclatura1aIsValid( string IdNomenclatura1a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura1a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura1aIsValid( string IdNomenclatura1a)
		{
			string mensaje;
			return IdNomenclatura1aIsValid( IdNomenclatura1a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura1b.
		/// </summary>
		public static bool IdNomenclatura1bIsValid( string IdNomenclatura1b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura1b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura1bIsValid( string IdNomenclatura1b)
		{
			string mensaje;
			return IdNomenclatura1bIsValid( IdNomenclatura1b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura1c.
		/// </summary>
		public static bool IdNomenclatura1cIsValid( string IdNomenclatura1c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura1c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura1cIsValid( string IdNomenclatura1c)
		{
			string mensaje;
			return IdNomenclatura1cIsValid( IdNomenclatura1c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura1d.
		/// </summary>
		public static bool IdNomenclatura1dIsValid( string IdNomenclatura1d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura1d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura1dIsValid( string IdNomenclatura1d)
		{
			string mensaje;
			return IdNomenclatura1dIsValid( IdNomenclatura1d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura2a.
		/// </summary>
		public static bool IdNomenclatura2aIsValid( string IdNomenclatura2a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura2a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura2aIsValid( string IdNomenclatura2a)
		{
			string mensaje;
			return IdNomenclatura2aIsValid( IdNomenclatura2a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura2b.
		/// </summary>
		public static bool IdNomenclatura2bIsValid( string IdNomenclatura2b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura2b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura2bIsValid( string IdNomenclatura2b)
		{
			string mensaje;
			return IdNomenclatura2bIsValid( IdNomenclatura2b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura2c.
		/// </summary>
		public static bool IdNomenclatura2cIsValid( string IdNomenclatura2c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura2c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura2cIsValid( string IdNomenclatura2c)
		{
			string mensaje;
			return IdNomenclatura2cIsValid( IdNomenclatura2c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura2d.
		/// </summary>
		public static bool IdNomenclatura2dIsValid( string IdNomenclatura2d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura2d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura2dIsValid( string IdNomenclatura2d)
		{
			string mensaje;
			return IdNomenclatura2dIsValid( IdNomenclatura2d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura3a.
		/// </summary>
		public static bool IdNomenclatura3aIsValid( string IdNomenclatura3a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura3a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura3aIsValid( string IdNomenclatura3a)
		{
			string mensaje;
			return IdNomenclatura3aIsValid( IdNomenclatura3a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura3b.
		/// </summary>
		public static bool IdNomenclatura3bIsValid( string IdNomenclatura3b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura3b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura3bIsValid( string IdNomenclatura3b)
		{
			string mensaje;
			return IdNomenclatura3bIsValid( IdNomenclatura3b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura3c.
		/// </summary>
		public static bool IdNomenclatura3cIsValid( string IdNomenclatura3c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura3c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura3cIsValid( string IdNomenclatura3c)
		{
			string mensaje;
			return IdNomenclatura3cIsValid( IdNomenclatura3c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura3d.
		/// </summary>
		public static bool IdNomenclatura3dIsValid( string IdNomenclatura3d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura3d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura3dIsValid( string IdNomenclatura3d)
		{
			string mensaje;
			return IdNomenclatura3dIsValid( IdNomenclatura3d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura4a.
		/// </summary>
		public static bool IdNomenclatura4aIsValid( string IdNomenclatura4a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura4a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura4aIsValid( string IdNomenclatura4a)
		{
			string mensaje;
			return IdNomenclatura4aIsValid( IdNomenclatura4a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura4b.
		/// </summary>
		public static bool IdNomenclatura4bIsValid( string IdNomenclatura4b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura4b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura4bIsValid( string IdNomenclatura4b)
		{
			string mensaje;
			return IdNomenclatura4bIsValid( IdNomenclatura4b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura4c.
		/// </summary>
		public static bool IdNomenclatura4cIsValid( string IdNomenclatura4c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura4c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura4cIsValid( string IdNomenclatura4c)
		{
			string mensaje;
			return IdNomenclatura4cIsValid( IdNomenclatura4c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura4d.
		/// </summary>
		public static bool IdNomenclatura4dIsValid( string IdNomenclatura4d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura4d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura4dIsValid( string IdNomenclatura4d)
		{
			string mensaje;
			return IdNomenclatura4dIsValid( IdNomenclatura4d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura5a.
		/// </summary>
		public static bool IdNomenclatura5aIsValid( string IdNomenclatura5a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura5a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura5aIsValid( string IdNomenclatura5a)
		{
			string mensaje;
			return IdNomenclatura5aIsValid( IdNomenclatura5a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura5b.
		/// </summary>
		public static bool IdNomenclatura5bIsValid( string IdNomenclatura5b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura5b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura5bIsValid( string IdNomenclatura5b)
		{
			string mensaje;
			return IdNomenclatura5bIsValid( IdNomenclatura5b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura5c.
		/// </summary>
		public static bool IdNomenclatura5cIsValid( string IdNomenclatura5c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura5c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura5cIsValid( string IdNomenclatura5c)
		{
			string mensaje;
			return IdNomenclatura5cIsValid( IdNomenclatura5c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura5d.
		/// </summary>
		public static bool IdNomenclatura5dIsValid( string IdNomenclatura5d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura5d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura5dIsValid( string IdNomenclatura5d)
		{
			string mensaje;
			return IdNomenclatura5dIsValid( IdNomenclatura5d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura6a.
		/// </summary>
		public static bool IdNomenclatura6aIsValid( string IdNomenclatura6a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura6a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura6aIsValid( string IdNomenclatura6a)
		{
			string mensaje;
			return IdNomenclatura6aIsValid( IdNomenclatura6a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura6b.
		/// </summary>
		public static bool IdNomenclatura6bIsValid( string IdNomenclatura6b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura6b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura6bIsValid( string IdNomenclatura6b)
		{
			string mensaje;
			return IdNomenclatura6bIsValid( IdNomenclatura6b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura6c.
		/// </summary>
		public static bool IdNomenclatura6cIsValid( string IdNomenclatura6c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura6c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura6cIsValid( string IdNomenclatura6c)
		{
			string mensaje;
			return IdNomenclatura6cIsValid( IdNomenclatura6c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura6d.
		/// </summary>
		public static bool IdNomenclatura6dIsValid( string IdNomenclatura6d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura6d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura6dIsValid( string IdNomenclatura6d)
		{
			string mensaje;
			return IdNomenclatura6dIsValid( IdNomenclatura6d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura7a.
		/// </summary>
		public static bool IdNomenclatura7aIsValid( string IdNomenclatura7a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura7a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura7aIsValid( string IdNomenclatura7a)
		{
			string mensaje;
			return IdNomenclatura7aIsValid( IdNomenclatura7a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura7b.
		/// </summary>
		public static bool IdNomenclatura7bIsValid( string IdNomenclatura7b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura7b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura7bIsValid( string IdNomenclatura7b)
		{
			string mensaje;
			return IdNomenclatura7bIsValid( IdNomenclatura7b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura7c.
		/// </summary>
		public static bool IdNomenclatura7cIsValid( string IdNomenclatura7c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura7c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura7cIsValid( string IdNomenclatura7c)
		{
			string mensaje;
			return IdNomenclatura7cIsValid( IdNomenclatura7c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura7d.
		/// </summary>
		public static bool IdNomenclatura7dIsValid( string IdNomenclatura7d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura7d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura7dIsValid( string IdNomenclatura7d)
		{
			string mensaje;
			return IdNomenclatura7dIsValid( IdNomenclatura7d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura8a.
		/// </summary>
		public static bool IdNomenclatura8aIsValid( string IdNomenclatura8a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura8a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura8aIsValid( string IdNomenclatura8a)
		{
			string mensaje;
			return IdNomenclatura8aIsValid( IdNomenclatura8a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura8b.
		/// </summary>
		public static bool IdNomenclatura8bIsValid( string IdNomenclatura8b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura8b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura8bIsValid( string IdNomenclatura8b)
		{
			string mensaje;
			return IdNomenclatura8bIsValid( IdNomenclatura8b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura8c.
		/// </summary>
		public static bool IdNomenclatura8cIsValid( string IdNomenclatura8c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura8c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura8cIsValid( string IdNomenclatura8c)
		{
			string mensaje;
			return IdNomenclatura8cIsValid( IdNomenclatura8c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura8d.
		/// </summary>
		public static bool IdNomenclatura8dIsValid( string IdNomenclatura8d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura8d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura8dIsValid( string IdNomenclatura8d)
		{
			string mensaje;
			return IdNomenclatura8dIsValid( IdNomenclatura8d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura9a.
		/// </summary>
		public static bool IdNomenclatura9aIsValid( string IdNomenclatura9a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura9a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura9aIsValid( string IdNomenclatura9a)
		{
			string mensaje;
			return IdNomenclatura9aIsValid( IdNomenclatura9a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura9b.
		/// </summary>
		public static bool IdNomenclatura9bIsValid( string IdNomenclatura9b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura9b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura9bIsValid( string IdNomenclatura9b)
		{
			string mensaje;
			return IdNomenclatura9bIsValid( IdNomenclatura9b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura9c.
		/// </summary>
		public static bool IdNomenclatura9cIsValid( string IdNomenclatura9c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura9c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura9cIsValid( string IdNomenclatura9c)
		{
			string mensaje;
			return IdNomenclatura9cIsValid( IdNomenclatura9c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura9d.
		/// </summary>
		public static bool IdNomenclatura9dIsValid( string IdNomenclatura9d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura9d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura9dIsValid( string IdNomenclatura9d)
		{
			string mensaje;
			return IdNomenclatura9dIsValid( IdNomenclatura9d, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura10a.
		/// </summary>
		public static bool IdNomenclatura10aIsValid( string IdNomenclatura10a , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura10a. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura10aIsValid( string IdNomenclatura10a)
		{
			string mensaje;
			return IdNomenclatura10aIsValid( IdNomenclatura10a, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura10b.
		/// </summary>
		public static bool IdNomenclatura10bIsValid( string IdNomenclatura10b , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura10b. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura10bIsValid( string IdNomenclatura10b)
		{
			string mensaje;
			return IdNomenclatura10bIsValid( IdNomenclatura10b, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura10c.
		/// </summary>
		public static bool IdNomenclatura10cIsValid( string IdNomenclatura10c , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura10c. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura10cIsValid( string IdNomenclatura10c)
		{
			string mensaje;
			return IdNomenclatura10cIsValid( IdNomenclatura10c, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclatura10d.
		/// </summary>
		public static bool IdNomenclatura10dIsValid( string IdNomenclatura10d , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura10d. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclatura10dIsValid( string IdNomenclatura10d)
		{
			string mensaje;
			return IdNomenclatura10dIsValid( IdNomenclatura10d, out mensaje );
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

