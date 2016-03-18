namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
    
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_TiposAgrupamiento : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_TiposAgrupamiento()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_TiposAgrupamiento
		/// </summary>
		public static tsy_TiposAgrupamientoDataset GetList()
		{
			return mz.erp.dataaccess.tsy_TiposAgrupamiento.GetList();
		}

		/// <summary>
		/// Crea un tsy_TiposAgrupamientoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow NewRow()
		{
			return mz.erp.dataaccess.tsy_TiposAgrupamiento.NewRow();
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_TiposAgrupamiento que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow GetByPk( long IdTipoAgrup )
		{
			return mz.erp.dataaccess.tsy_TiposAgrupamiento.GetByPk( IdTipoAgrup );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposAgrupamientoRow a la base de datos realizando una validacin previa.
		/// </summary>
		public static void UpdateWithValidation( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		
		/// <summary>
		/// Envia los cambios del tsy_TiposAgrupamientoRow a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposAgrupamiento.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_TiposAgrupamientoDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposAgrupamientoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_TiposAgrupamiento.Rows.Count > 0, "La tabla dataSet.tsy_TiposAgrupamientoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposAgrupamiento.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposAgrupamiento.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_TiposAgrupamientoRow.
		/// </summary>
		public static bool RowIsValid( tsy_TiposAgrupamientoDataset.tsy_TiposAgrupamientoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			
			if ( !IdTipoAgrupIsValid( row.IdTipoAgrup ) )
			{ 
				return false;
			}
						
			if ( !DescripcionIsValid( row.Descripcion ) )
			{ 
				return false;
			}
						
			if ( !CategoriaIsValid( row.Categoria ) )
			{ 
				return false;
			}
						
			if ( !EstiloIsValid( row.Estilo ) )
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
		/// Valida el campo IdTipoAgrup.
		/// </summary>
		public static bool IdTipoAgrupIsValid( long IdTipoAgrup )
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
		/// Valida el campo Categoria.
		/// </summary>
		public static bool CategoriaIsValid( string Categoria )
		{
			//Agregar cdigo de validacin
			return true;
		}
		
		/// <summary>
		/// Valida el campo Estilo.
		/// </summary>
		public static bool EstiloIsValid( string Estilo )
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

