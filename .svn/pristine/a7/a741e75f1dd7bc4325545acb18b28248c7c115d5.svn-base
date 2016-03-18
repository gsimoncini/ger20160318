namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_CotizComprasDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_CotizComprasDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_CotizComprasDet
		/// </summary>
		public static tpu_CotizComprasDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_CotizComprasDet.GetList();
		}

		/// <summary>
		/// Crea un tpu_CotizComprasDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CotizComprasDetDataset.tpu_CotizComprasDetRow NewRow()
		{
			return mz.erp.dataaccess.tpu_CotizComprasDet.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_CotizComprasDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CotizComprasDetDataset.tpu_CotizComprasDetRow GetByPk( long IdCotizCompra, short Renglon )
		{
			return mz.erp.dataaccess.tpu_CotizComprasDet.GetByPk( IdCotizCompra, Renglon );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CotizComprasDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tpu_CotizComprasDetDataset.tpu_CotizComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tpu_CotizComprasDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizComprasDetDataset.tpu_CotizComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizComprasDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_CotizComprasDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizComprasDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_CotizComprasDet.Rows.Count > 0, "La tabla dataSet.tpu_CotizComprasDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizComprasDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CotizComprasDetDataset.tpu_CotizComprasDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_CotizComprasDetDataset.tpu_CotizComprasDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CotizComprasDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_CotizComprasDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_CotizComprasDetDataset.tpu_CotizComprasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdCotizCompraIsValid( row.IdCotizCompra ) )
			{ 
				return false;
			}
						
			if ( !RenglonIsValid( row.Renglon ) )
			{ 
				return false;
			}
						
			if ( !IdProductoIsValid( row.IdProducto ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !Cantidad1IsValid( row.Cantidad1 ) )
			{ 
				return false;
			}
						
			if ( !PrecioFinal1IsValid( row.PrecioFinal1 ) )
			{ 
				return false;
			}
						
			if ( !Cantidad2IsValid( row.Cantidad2 ) )
			{ 
				return false;
			}
						
			if ( !PrecioFinal2IsValid( row.PrecioFinal2 ) )
			{ 
				return false;
			}
						
			if ( !Cantidad3IsValid( row.Cantidad3 ) )
			{ 
				return false;
			}
						
			if ( !PrecioFinal3IsValid( row.PrecioFinal3 ) )
			{ 
				return false;
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda ) )
			{ 
				return false;
			}
						
			if ( !IdFuenteDeCambioIsValid( row.IdFuenteDeCambio ) )
			{ 
				return false;
			}
						
			if ( !ObservacionesIsValid( row.Observaciones ) )
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
		/// Valida el campo IdCotizCompra.
		/// </summary>
		public static bool IdCotizCompraIsValid( long IdCotizCompra )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Renglon.
		/// </summary>
		public static bool RenglonIsValid( short Renglon )
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
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad1.
		/// </summary>
		public static bool Cantidad1IsValid( decimal Cantidad1 )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioFinal1.
		/// </summary>
		public static bool PrecioFinal1IsValid( decimal PrecioFinal1 )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad2.
		/// </summary>
		public static bool Cantidad2IsValid( decimal Cantidad2 )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioFinal2.
		/// </summary>
		public static bool PrecioFinal2IsValid( decimal PrecioFinal2 )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad3.
		/// </summary>
		public static bool Cantidad3IsValid( decimal Cantidad3 )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioFinal3.
		/// </summary>
		public static bool PrecioFinal3IsValid( decimal PrecioFinal3 )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( long IdMoneda )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio.
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( long IdFuenteDeCambio )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones )
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

