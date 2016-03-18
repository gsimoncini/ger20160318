namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_MovimientosDeStockNumerosDeSerie : IDisposable
	{
	
		#region Custom Members
		
		public static bool ExistsNueroDeSerie(string NumeroDeSerie, string IdProducto, string IdEstadoDeStock)
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.ExistsNueroDeSerie(NumeroDeSerie,IdProducto, IdEstadoDeStock); 
		}

		public static DataSet GetNumerosDeSerieParaBaja(string IdProducto, string IdEstadoDeStock)
		{
			return  mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.GetNumerosDeSerieParaBaja(IdProducto, IdEstadoDeStock);
		}



		#endregion
		
		public tlg_MovimientosDeStockNumerosDeSerie()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_MovimientosDeStockNumerosDeSerie
		/// </summary>
		public static tlg_MovimientosDeStockNumerosDeSerieDataset GetList()
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_MovimientosDeStockNumerosDeSerie filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_MovimientosDeStockNumerosDeSerieDataset GetList( string IdMovimientoDeStock, string NumeroDeSerie )
		{
			return mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.GetList( IdMovimientoDeStock, NumeroDeSerie );
		}

		/// <summary>
		/// Crea un tlg_MovimientosDeStockNumerosDeSerieRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_MovimientosDeStockNumerosDeSerie que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow GetByPk( string IdMovimientoDeStock )
		{
			tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow row = mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.GetByPk( IdMovimientoDeStock  );
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
		/// Obtiene un registro de la tabla tlg_MovimientosDeStockNumerosDeSerie que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow GetByPk( object IdMovimientoDeStock )
		{
			return GetByPk( ( string )IdMovimientoDeStock );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_MovimientosDeStockNumerosDeSerieRow.
		/// </summary>
		public static tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow SetRowDefaultValues( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow row )
		{
			row.IdMovimientoDeStock = Util.NewStringId(); 
			row.NumeroDeSerie = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockNumerosDeSerieRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow row )
		{
			//ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockNumerosDeSerieRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockNumerosDeSerieRow a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow row )
		{
			//ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.Update( row );
		}

		

		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockNumerosDeSerieDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset dataSet )
		{
			//ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			//ApplicationAssert.Check( dataSet.tlg_MovimientosDeStockNumerosDeSerie.Rows.Count > 0, "La tabla dataSet.tlg_MovimientosDeStockNumerosDeSerieDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.Update( dataSet );
		}

		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset dataSet , string IdTransaction)
		{
			//ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			//ApplicationAssert.Check( dataSet.tlg_MovimientosDeStockNumerosDeSerie.Rows.Count > 0, "La tabla dataSet.tlg_MovimientosDeStockNumerosDeSerieDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.Update( dataSet, IdTransaction );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieDataTable dataTable )
		{
			//ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			//ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_MovimientosDeStockNumerosDeSerie.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_MovimientosDeStockNumerosDeSerieRow.
		/// </summary>
		public static bool RowIsValid( tlg_MovimientosDeStockNumerosDeSerieDataset.tlg_MovimientosDeStockNumerosDeSerieRow row )
		{
			//ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoDeStockIsValid( row.IdMovimientoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroDeSerieIsValid( row.NumeroDeSerie, out mensaje) )
			{ 
				row.SetColumnError( "NumeroDeSerie" , mensaje);
				isValid=false;
			
			}
				
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStock.
		/// </summary>
		public static bool IdMovimientoDeStockIsValid( string IdMovimientoDeStock , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeStock. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeStockIsValid( string IdMovimientoDeStock)
		{
			string mensaje;
			return IdMovimientoDeStockIsValid( IdMovimientoDeStock, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NumeroDeSerie.
		/// </summary>
		public static bool NumeroDeSerieIsValid( string NumeroDeSerie , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NumeroDeSerie. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroDeSerieIsValid( string NumeroDeSerie)
		{
			string mensaje;
			return NumeroDeSerieIsValid( NumeroDeSerie, out mensaje );
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

