namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_TDCompTesoreria_TipoMovimiento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_TDCompTesoreria_TipoMovimiento()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_TDCompTesoreria_TipoMovimiento
		/// </summary>
		public static tfi_TDCompTesoreria_TipoMovimientoDataset GetList()
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_TDCompTesoreria_TipoMovimiento filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_TDCompTesoreria_TipoMovimientoDataset GetList(  string IdTipoMovimiento, string IdTdCompTesoreria)
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.GetList( IdTipoMovimiento, IdTdCompTesoreria);
		}

		/// <summary>
		/// Crea un tfi_TDCompTesoreria_TipoMovimientoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria_TipoMovimiento que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow GetByPk( string Id )
		{
			tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow row = mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.GetByPk( Id  );
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
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria_TipoMovimiento que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow GetByPk( object Id )
		{
			return GetByPk( ( string )Id );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_TDCompTesoreria_TipoMovimientoRow.
		/// </summary>
		public static tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow SetRowDefaultValues( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow row )
		{
			row.Id = Util.NewStringId(); 
			row.IdTipoMovimiento = string.Empty;
			row.IdTdCompTesoreria = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdEmpresa = 0;
			row.IdSucursal= 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_TipoMovimientoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_TipoMovimientoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_TipoMovimientoRow a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_TipoMovimientoDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_TipoMovimientoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_TDCompTesoreria_TipoMovimiento.Rows.Count > 0, "La tabla dataSet.tfi_TDCompTesoreria_TipoMovimientoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_TipoMovimiento.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_TDCompTesoreria_TipoMovimientoRow.
		/// </summary>
		public static bool RowIsValid( tfi_TDCompTesoreria_TipoMovimientoDataset.tfi_TDCompTesoreria_TipoMovimientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdIsValid( row.Id, out mensaje) )
			{ 
				row.SetColumnError( "Id" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoMovimientoIsValid( row.IdTipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTdCompTesoreriaIsValid( row.IdTdCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTdCompTesoreria" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo Id.
		/// </summary>
		public static bool IdIsValid( string Id , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Id. Metodo Sobrecargado
		/// </summary>
		public static bool IdIsValid( string Id)
		{
			string mensaje;
			return IdIsValid( Id, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento.
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento)
		{
			string mensaje;
			return IdTipoMovimientoIsValid( IdTipoMovimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTdCompTesoreria.
		/// </summary>
		public static bool IdTdCompTesoreriaIsValid( string IdTdCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTdCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTdCompTesoreriaIsValid( string IdTdCompTesoreria)
		{
			string mensaje;
			return IdTdCompTesoreriaIsValid( IdTdCompTesoreria, out mensaje );
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

