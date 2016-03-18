namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_OrdenesPreparacion : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_OrdenesPreparacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_OrdenesPreparacion
		/// </summary>
		public static tlg_OrdenesPreparacionDataset GetList()
		{
			return mz.erp.dataaccess.tlg_OrdenesPreparacion.GetList();
		}

		/// <summary>
		/// Crea un tlg_OrdenesPreparacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionRow NewRow()
		{
			return mz.erp.dataaccess.tlg_OrdenesPreparacion.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_OrdenesPreparacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionRow GetByPk( long IdOrdenPreparacion )
		{
			return mz.erp.dataaccess.tlg_OrdenesPreparacion.GetByPk( IdOrdenPreparacion );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionRow a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesPreparacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesPreparacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_OrdenesPreparacion.Rows.Count > 0, "La tabla dataSet.tlg_OrdenesPreparacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesPreparacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesPreparacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_OrdenesPreparacionRow.
		/// </summary>
		public static bool RowIsValid( tlg_OrdenesPreparacionDataset.tlg_OrdenesPreparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdOrdenPreparacionIsValid( row.IdOrdenPreparacion ) )
			{ 
				return false;
			}
						
			if ( !IdPedidoIsValid( row.IdPedido ) )
			{ 
				return false;
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante ) )
			{ 
				return false;
			}
						
			if ( !IdAsignoIsValid( row.IdAsigno ) )
			{ 
				return false;
			}
						
			if ( !IdPreparoIsValid( row.IdPreparo ) )
			{ 
				return false;
			}
						
			if ( !IdControloIsValid( row.IdControlo ) )
			{ 
				return false;
			}
						
			if ( !FechaIsValid( row.Fecha ) )
			{ 
				return false;
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento ) )
			{ 
				return false;
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta ) )
			{ 
				return false;
			}
						
			if ( !IdRetiraIsValid( row.IdRetira ) )
			{ 
				return false;
			}
						
			if ( !IdFormaEntregaIsValid( row.IdFormaEntrega ) )
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
						
			if ( !IdLocalIsValid( row.IdLocal ) )
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
		/// Valida el campo IdOrdenPreparacion.
		/// </summary>
		public static bool IdOrdenPreparacionIsValid( long IdOrdenPreparacion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPedido.
		/// </summary>
		public static bool IdPedidoIsValid( long IdPedido )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobante.
		/// </summary>
		public static bool IdComprobanteIsValid( long IdComprobante )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdAsigno.
		/// </summary>
		public static bool IdAsignoIsValid( long IdAsigno )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPreparo.
		/// </summary>
		public static bool IdPreparoIsValid( long IdPreparo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdControlo.
		/// </summary>
		public static bool IdControloIsValid( long IdControlo )
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
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( long IdCuenta )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRetira.
		/// </summary>
		public static bool IdRetiraIsValid( long IdRetira )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFormaEntrega.
		/// </summary>
		public static bool IdFormaEntregaIsValid( long IdFormaEntrega )
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
		/// Valida el campo IdLocal.
		/// </summary>
		public static bool IdLocalIsValid( long IdLocal )
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

