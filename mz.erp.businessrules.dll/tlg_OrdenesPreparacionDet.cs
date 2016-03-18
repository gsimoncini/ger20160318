namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_OrdenesPreparacionDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_OrdenesPreparacionDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_OrdenesPreparacionDet
		/// </summary>
		public static tlg_OrdenesPreparacionDetDataset GetList()
		{
			return mz.erp.dataaccess.tlg_OrdenesPreparacionDet.GetList();
		}

		/// <summary>
		/// Crea un tlg_OrdenesPreparacionDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetRow NewRow()
		{
			return mz.erp.dataaccess.tlg_OrdenesPreparacionDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_OrdenesPreparacionDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetRow GetByPk( long IdOrdenPreparacion, long IdProducto )
		{
			return mz.erp.dataaccess.tlg_OrdenesPreparacionDet.GetByPk( IdOrdenPreparacion, IdProducto );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionDetRow a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesPreparacionDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionDetDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesPreparacionDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_OrdenesPreparacionDet.Rows.Count > 0, "La tabla dataSet.tlg_OrdenesPreparacionDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesPreparacionDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_OrdenesPreparacionDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_OrdenesPreparacionDetRow.
		/// </summary>
		public static bool RowIsValid( tlg_OrdenesPreparacionDetDataset.tlg_OrdenesPreparacionDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdOrdenPreparacionIsValid( row.IdOrdenPreparacion ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !CantidadIsValid( row.Cantidad ) )
			{ 
				return false;
			}
						
			if ( !PreparadoIsValid( row.Preparado ) )
			{ 
				return false;
			}
						
			if ( !ControladorIsValid( row.Controlador ) )
			{ 
				return false;
			}
						
			if ( !LoteIsValid( row.Lote ) )
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( long IdProducto )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Preparado.
		/// </summary>
		public static bool PreparadoIsValid( decimal Preparado )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Controlador.
		/// </summary>
		public static bool ControladorIsValid( decimal Controlador )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Lote.
		/// </summary>
		public static bool LoteIsValid( long Lote )
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

