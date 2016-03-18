namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_FormasDePago : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_FormasDePago()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_FormasDePago
		/// </summary>
		public static tsy_FormasDePagoDataset GetList()
		{
			return mz.erp.dataaccess.tsy_FormasDePago.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_FormasDePago filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_FormasDePagoDataset GetList( string IdFormaDePago, string Descripcion, bool Activo, bool Sistema, decimal MaximoPorcentaje, decimal MaximoMontoFijo, long IdTasaDeCambio, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa )
		{
			return mz.erp.dataaccess.tsy_FormasDePago.GetList( IdFormaDePago, Descripcion, Activo, Sistema, MaximoPorcentaje, MaximoMontoFijo, IdTasaDeCambio, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa );
		}

		/// <summary>
		/// Crea un tsy_FormasDePagoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_FormasDePagoDataset.tsy_FormasDePagoRow NewRow()
		{
			return mz.erp.dataaccess.tsy_FormasDePago.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_FormasDePago que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_FormasDePagoDataset.tsy_FormasDePagoRow GetByPk( string IdFormaDePago )
		{
			return SetRowDefaultValues( mz.erp.dataaccess.tsy_FormasDePago.GetByPk( IdFormaDePago ) );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_FormasDePagoRow.
		/// </summary>
		public static tsy_FormasDePagoDataset.tsy_FormasDePagoRow SetRowDefaultValues( tsy_FormasDePagoDataset.tsy_FormasDePagoRow row )
		{
			row.IdFormaDePago = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Activo = false;
			row.Sistema = false;
			row.MaximoPorcentaje = 0;
			row.MaximoMontoFijo = 0;
			row.IdTasaDeCambio = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_FormasDePagoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_FormasDePagoDataset.tsy_FormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_FormasDePagoRow a la base de datos.
		/// </summary>
		public static void Update( tsy_FormasDePagoDataset.tsy_FormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_FormasDePago.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_FormasDePagoDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_FormasDePagoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_FormasDePago.Rows.Count > 0, "La tabla dataSet.tsy_FormasDePagoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_FormasDePago.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_FormasDePagoDataset.tsy_FormasDePagoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_FormasDePagoDataset.tsy_FormasDePagoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_FormasDePago.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_FormasDePagoRow.
		/// </summary>
		public static bool RowIsValid( tsy_FormasDePagoDataset.tsy_FormasDePagoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdFormaDePagoIsValid( row.IdFormaDePago ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !ActivoIsValid( row.Activo ) )
			{ 
				return false;
			}
						
			if ( !SistemaIsValid( row.Sistema ) )
			{ 
				return false;
			}
						
			if ( !MaximoPorcentajeIsValid( row.MaximoPorcentaje ) )
			{ 
				return false;
			}
						
			if ( !MaximoMontoFijoIsValid( row.MaximoMontoFijo ) )
			{ 
				return false;
			}
						
			if ( !IdTasaDeCambioIsValid( row.IdTasaDeCambio ) )
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
		/// Valida el campo IdFormaDePago.
		/// </summary>
		public static bool IdFormaDePagoIsValid( string IdFormaDePago )
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
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaximoPorcentaje.
		/// </summary>
		public static bool MaximoPorcentajeIsValid( decimal MaximoPorcentaje )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaximoMontoFijo.
		/// </summary>
		public static bool MaximoMontoFijoIsValid( decimal MaximoMontoFijo )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTasaDeCambio.
		/// </summary>
		public static bool IdTasaDeCambioIsValid( long IdTasaDeCambio )
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

