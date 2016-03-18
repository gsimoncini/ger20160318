namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tui_ConfiguracionFormasDePago : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tui_ConfiguracionFormasDePago()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tui_ConfiguracionFormasDePago
		/// </summary>
		public static tui_ConfiguracionFormasDePagoDataset GetList()
		{
			return mz.erp.dataaccess.tui_ConfiguracionFormasDePago.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tui_ConfiguracionFormasDePago filtrada por las condiciones de bsqueda
		/// </summary>
		public static tui_ConfiguracionFormasDePagoDataset GetList( string IdTDCompTesoreria, string ClaveCorta, string ClaveLarga, string Familia )
		{
			return mz.erp.dataaccess.tui_ConfiguracionFormasDePago.GetList( IdTDCompTesoreria, ClaveCorta, ClaveLarga, Familia );
		}

		/// <summary>
		/// Crea un tui_ConfiguracionFormasDePagoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tui_ConfiguracionFormasDePago.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tui_ConfiguracionFormasDePago que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow GetByPk( string IdTDCompTesoreria )
		{
			tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow row = mz.erp.dataaccess.tui_ConfiguracionFormasDePago.GetByPk( IdTDCompTesoreria  );
			if(row != null)
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
		/// Obtiene un registro de la tabla tui_ConfiguracionFormasDePago que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow GetByPk( object IdTDCompTesoreria )
		{
			return GetByPk( ( string )IdTDCompTesoreria );
		}

		/// <summary>
		/// Establece los valores por defecto de tui_ConfiguracionFormasDePagoRow.
		/// </summary>
		public static tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow SetRowDefaultValues( tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow row )
		{
			row.IdTDCompTesoreria = Util.NewStringId(); 
			row.ClaveCorta = string.Empty;
			row.ClaveLarga = string.Empty;
			row.Familia = string.Empty;
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
		/// Envia los cambios del tui_ConfiguracionFormasDePagoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFormasDePagoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFormasDePagoRow a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionFormasDePago.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFormasDePagoDataset a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionFormasDePagoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tui_ConfiguracionFormasDePago.Rows.Count > 0, "La tabla dataSet.tui_ConfiguracionFormasDePagoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionFormasDePago.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoDataTable a la base de datos.
		/// </summary>
		public static void Update( tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tui_ConfiguracionFormasDePago.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tui_ConfiguracionFormasDePagoRow.
		/// </summary>
		public static bool RowIsValid( tui_ConfiguracionFormasDePagoDataset.tui_ConfiguracionFormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveCortaIsValid( row.ClaveCorta, out mensaje) )
			{ 
				row.SetColumnError( "ClaveCorta" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaveLargaIsValid( row.ClaveLarga, out mensaje) )
			{ 
				row.SetColumnError( "ClaveLarga" , mensaje);
				isValid=false;
			
			}
						
			if ( !FamiliaIsValid( row.Familia, out mensaje) )
			{ 
				row.SetColumnError( "Familia" , mensaje);
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
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria)
		{
			string mensaje;
			return IdTDCompTesoreriaIsValid( IdTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ClaveCorta.
		/// </summary>
		public static bool ClaveCortaIsValid( string ClaveCorta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ClaveCorta. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveCortaIsValid( string ClaveCorta)
		{
			string mensaje;
			return ClaveCortaIsValid( ClaveCorta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ClaveLarga.
		/// </summary>
		public static bool ClaveLargaIsValid( string ClaveLarga , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ClaveLarga. Metodo Sobrecargado
		/// </summary>
		public static bool ClaveLargaIsValid( string ClaveLarga)
		{
			string mensaje;
			return ClaveLargaIsValid( ClaveLarga, out mensaje );
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

