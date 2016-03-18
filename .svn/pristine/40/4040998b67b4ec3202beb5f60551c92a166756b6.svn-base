namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_DescuentosPorVolumen : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsa_DescuentosPorVolumen()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_DescuentosPorVolumen
		/// </summary>
		public static tsa_DescuentosPorVolumenDataset GetList()
		{
			return mz.erp.dataaccess.tsa_DescuentosPorVolumen.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_DescuentosPorVolumen filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_DescuentosPorVolumenDataset GetList( string IdProducto, long IdSucursal, string Descripcion, decimal Unidades, decimal BonificacionRecargo, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsa_DescuentosPorVolumen.GetList( IdProducto, IdSucursal, Descripcion, Unidades, BonificacionRecargo, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsa_DescuentosPorVolumenRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow NewRow()
		{
			return mz.erp.dataaccess.tsa_DescuentosPorVolumen.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_DescuentosPorVolumen que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow GetByPk( string IdProducto, long IdSucursal )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsa_DescuentosPorVolumen.GetByPk( IdProducto, IdSucursal ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_DescuentosPorVolumenRow.
		/// </summary>
		public static tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow SetRowDefaultValues( tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdSucursal = 0; 
			row.Descripcion = string.Empty;
			row.Unidades = 0;
			row.BonificacionRecargo = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorVolumenRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorVolumenRow a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorVolumen.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorVolumenDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorVolumenDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_DescuentosPorVolumen.Rows.Count > 0, "La tabla dataSet.tsa_DescuentosPorVolumenDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorVolumen.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_DescuentosPorVolumen.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_DescuentosPorVolumenRow.
		/// </summary>
		public static bool RowIsValid( tsa_DescuentosPorVolumenDataset.tsa_DescuentosPorVolumenRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !UnidadesIsValid( row.Unidades ) )
			{ 
				return false;
			}
						
			if ( !BonificacionRecargoIsValid( row.BonificacionRecargo ) )
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto )
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Unidades.
		/// </summary>
		public static bool UnidadesIsValid( decimal Unidades )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo BonificacionRecargo.
		/// </summary>
		public static bool BonificacionRecargoIsValid( decimal BonificacionRecargo )
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

