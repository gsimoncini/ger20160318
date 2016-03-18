namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_Remito : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_Remito()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Remito
		/// </summary>
		public static tlg_RemitoDataset GetList()
		{
			return mz.erp.dataaccess.tlg_Remito.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_Remito filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_RemitoDataset GetList( long IdRemito, DateTime Fecha, string Tipo, string Numero, string IdCuenta, long IdEstado, bool ConservaPreico, long IdCondicionDeVenta, string Comentario, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tlg_Remito.GetList( IdRemito, Fecha, Tipo, Numero, IdCuenta, IdEstado, ConservaPreico, IdCondicionDeVenta, Comentario, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tlg_RemitoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_RemitoDataset.tlg_RemitoRow NewRow()
		{
			return mz.erp.dataaccess.tlg_Remito.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Remito que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_RemitoDataset.tlg_RemitoRow GetByPk( long IdRemito )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tlg_Remito.GetByPk( IdRemito ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_RemitoRow.
		/// </summary>
		public static tlg_RemitoDataset.tlg_RemitoRow SetRowDefaultValues( tlg_RemitoDataset.tlg_RemitoRow row )
		{
			row.IdRemito = 0; 
			row.Fecha = DateTime.Now;
			row.Tipo = string.Empty;
			row.Numero = string.Empty;
			row.IdCuenta = string.Empty;
			row.IdEstado = 0;
			row.ConservaPreico = false;
			row.IdCondicionDeVenta = 0;
			row.Comentario = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_RemitoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tlg_RemitoDataset.tlg_RemitoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tlg_RemitoRow a la base de datos.
		/// </summary>
		public static void Update( tlg_RemitoDataset.tlg_RemitoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Remito.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_RemitoDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_RemitoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Remito.Rows.Count > 0, "La tabla dataSet.tlg_RemitoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Remito.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_RemitoDataset.tlg_RemitoDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_RemitoDataset.tlg_RemitoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Remito.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_RemitoRow.
		/// </summary>
		public static bool RowIsValid( tlg_RemitoDataset.tlg_RemitoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdRemitoIsValid( row.IdRemito ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !TipoIsValid( row.Tipo ) )
			{ 
				return false;
			}
						
			if ( !NumeroIsValid( row.Numero ) )
			{ 
				return false;
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !IdEstadoIsValid( row.IdEstado ) )
			{ 
				return false;
			}
						
			if ( !ConservaPreicoIsValid( row.ConservaPreico ) )
			{ 
				return false;
			}
						
			if ( !IdCondicionDeVentaIsValid( row.IdCondicionDeVenta ) )
			{ 
				return false;
			}
						
			if ( !ComentarioIsValid( row.Comentario ) )
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
						
			if ( !IdSucursalIsValid( row.IdSucursal ) )
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
		/// Valida el campo IdRemito.
		/// </summary>
		public static bool IdRemitoIsValid( long IdRemito )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Tipo.
		/// </summary>
		public static bool TipoIsValid( string Tipo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero )
		{
			//Agregar cdigo de validacin
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
		/// Valida el campo IdEstado.
		/// </summary>
		public static bool IdEstadoIsValid( long IdEstado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo ConservaPreico.
		/// </summary>
		public static bool ConservaPreicoIsValid( bool ConservaPreico )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta.
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( long IdCondicionDeVenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comentario.
		/// </summary>
		public static bool ComentarioIsValid( string Comentario )
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
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal )
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

