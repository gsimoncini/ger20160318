namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_Contactos : IDisposable
	{
	
		#region Custom Members
		public static tsh_ContactosDataset GetList( string IdCuenta)
		{
			return mz.erp.dataaccess.tsh_Contactos.GetList(IdCuenta);
		}
		
		#endregion
		
		public tsh_Contactos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Contactos
		/// </summary>
		public static tsh_ContactosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Contactos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Contactos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_ContactosDataset GetList( string IdCuenta, string IdPersona, long IdTipoContacto, long IdCargo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsh_Contactos.GetList( IdCuenta, IdPersona, IdTipoContacto, IdCargo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsh_ContactosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ContactosDataset.tsh_ContactosRow NewRow()
		{
			return mz.erp.dataaccess.tsh_Contactos.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Contactos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ContactosDataset.tsh_ContactosRow GetByPk( string IdCuenta, string IdPersona )
		{
			tsh_ContactosDataset.tsh_ContactosRow row = mz.erp.dataaccess.tsh_Contactos.GetByPk( IdCuenta, IdPersona );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if(!dc.Caption.ToUpper().Equals("ROWID") && !dc.Caption.ToUpper().Equals("ULTIMAMODIFICACION"))
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
		/// Establece los valores por defecto de tsh_ContactosRow.
		/// </summary>
		public static tsh_ContactosDataset.tsh_ContactosRow SetRowDefaultValues( tsh_ContactosDataset.tsh_ContactosRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.IdPersona = Util.NewStringId(); 
			row.IdTipoContacto = 0;
			row.IdCargo = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ContactosRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsh_ContactosDataset.tsh_ContactosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsh_ContactosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ContactosDataset.tsh_ContactosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Contactos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ContactosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ContactosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Contactos.Rows.Count > 0, "La tabla dataSet.tsh_ContactosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Contactos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ContactosDataset.tsh_ContactosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ContactosDataset.tsh_ContactosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Contactos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ContactosRow.
		/// </summary>
		public static bool RowIsValid( tsh_ContactosDataset.tsh_ContactosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !IdPersonaIsValid( row.IdPersona ) )
			{ 
				return false;
			}
						
			if ( !IdTipoContactoIsValid( row.IdTipoContacto ) )
			{ 
				return false;
			}
						
			if ( !IdCargoIsValid( row.IdCargo ) )
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
						
			if ( !IdReservadoIsValid( row.IdReservado ) )
			{ 
				return false;
			}
						
			if ( !RowIdIsValid( row.RowId ) )
			{ 
				return false;
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa ) )
			{ 
				return false;
			}
			;
			
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPersona.
		/// </summary>
		public static bool IdPersonaIsValid( string IdPersona )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoContacto.
		/// </summary>
		public static bool IdTipoContactoIsValid( long IdTipoContacto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCargo.
		/// </summary>
		public static bool IdCargoIsValid( long IdCargo )
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
		/// Valida el campo IdReservado.
		/// </summary>
		public static bool IdReservadoIsValid( long IdReservado )
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
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( long IdEmpresa )
		{
			//Agregar cdigo de validacin
			return true;
		}
		

		public void Dispose()
		{
		}
		
	}
}

