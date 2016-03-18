namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_StockNumerosDeSerie : IDisposable
	{
	
		#region Custom Members

		public static void Update(tlg_StockNumerosDeSerieDataset data, string IdTransaction)
		{
			mz.erp.dataaccess.tlg_StockNumerosDeSerie.Update(data, IdTransaction);
		}

		public static bool ExistsNumeroDeSerie(string IdProducto, string NumeroDeSerie)
		{
			DataSet data = mz.erp.dataaccess.tlg_StockNumerosDeSerie.ExistsNumeroDeSerie( IdProducto,  NumeroDeSerie);
			return data.Tables[0].Rows.Count > 0;
		}

		public static DataSet GetNumerosDeSerieParaBaja(string IdProducto,string IdDeposito, string IdSeccion, string IdEstadoDeStock)
		{
			return mz.erp.dataaccess.tlg_StockNumerosDeSerie.GetNumerosDeSerieParaBaja( IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock);
		}

		#endregion
		
		public tlg_StockNumerosDeSerie()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_StockNumerosDeSerie
		/// </summary>
		public static tlg_StockNumerosDeSerieDataset GetList()
		{
			return mz.erp.dataaccess.tlg_StockNumerosDeSerie.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_StockNumerosDeSerie filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_StockNumerosDeSerieDataset GetList( string IdStockNumerosDeSerie, string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, string NumeroDeSerie )
		{
			return mz.erp.dataaccess.tlg_StockNumerosDeSerie.GetList( IdStockNumerosDeSerie, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, NumeroDeSerie );
		}

		/// <summary>
		/// Crea un tlg_StockNumerosDeSerieRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_StockNumerosDeSerie.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_StockNumerosDeSerie que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow GetByPk( string IdStockNumerosDeSerie )
		{
			tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row = mz.erp.dataaccess.tlg_StockNumerosDeSerie.GetByPk( IdStockNumerosDeSerie  );
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
		/// Obtiene un registro de la tabla tlg_StockNumerosDeSerie que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow GetByPk( object IdStockNumerosDeSerie )
		{
			return GetByPk( ( string )IdStockNumerosDeSerie );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_StockNumerosDeSerieRow.
		/// </summary>
		public static tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow SetRowDefaultValues( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row )
		{
			row.IdStockNumerosDeSerie = Util.NewStringId(); 
			row.IdProducto = string.Empty;
			row.IdDeposito = string.Empty;
			row.IdSeccion = string.Empty;
			row.IdEstadoDeStock = string.Empty;
			row.NumeroDeSerie = string.Empty;
			row.Observaciones = string.Empty;
			row.Aux1 = string.Empty;
			row.Aux2 = string.Empty;
			row.Aux3 = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockNumerosDeSerieRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockNumerosDeSerieRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockNumerosDeSerieRow a la base de datos.
		/// </summary>
		public static void Update( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_StockNumerosDeSerie.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_StockNumerosDeSerieDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_StockNumerosDeSerieDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_StockNumerosDeSerie.Rows.Count > 0, "La tabla dataSet.tlg_StockNumerosDeSerieDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_StockNumerosDeSerie.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_StockNumerosDeSerie.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_StockNumerosDeSerieRow.
		/// </summary>
		public static bool RowIsValid( tlg_StockNumerosDeSerieDataset.tlg_StockNumerosDeSerieRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdStockNumerosDeSerieIsValid( row.IdStockNumerosDeSerie, out mensaje) )
			{ 
				row.SetColumnError( "IdStockNumerosDeSerie" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdDepositoIsValid( row.IdDeposito, out mensaje) )
			{ 
				row.SetColumnError( "IdDeposito" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSeccionIsValid( row.IdSeccion, out mensaje) )
			{ 
				row.SetColumnError( "IdSeccion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoDeStockIsValid( row.IdEstadoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroDeSerieIsValid( row.NumeroDeSerie, out mensaje) )
			{ 
				row.SetColumnError( "NumeroDeSerie" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !Aux1IsValid( row.Aux1, out mensaje) )
			{ 
				row.SetColumnError( "Aux1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Aux2IsValid( row.Aux2, out mensaje) )
			{ 
				row.SetColumnError( "Aux2" , mensaje);
				isValid=false;
			
			}
						
			if ( !Aux3IsValid( row.Aux3, out mensaje) )
			{ 
				row.SetColumnError( "Aux3" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdStockNumerosDeSerie.
		/// </summary>
		public static bool IdStockNumerosDeSerieIsValid( string IdStockNumerosDeSerie , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdStockNumerosDeSerie. Metodo Sobrecargado
		/// </summary>
		public static bool IdStockNumerosDeSerieIsValid( string IdStockNumerosDeSerie)
		{
			string mensaje;
			return IdStockNumerosDeSerieIsValid( IdStockNumerosDeSerie, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdDeposito.
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDeposito. Metodo Sobrecargado
		/// </summary>
		public static bool IdDepositoIsValid( string IdDeposito)
		{
			string mensaje;
			return IdDepositoIsValid( IdDeposito, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSeccion.
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSeccion. Metodo Sobrecargado
		/// </summary>
		public static bool IdSeccionIsValid( string IdSeccion)
		{
			string mensaje;
			return IdSeccionIsValid( IdSeccion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEstadoDeStock.
		/// </summary>
		public static bool IdEstadoDeStockIsValid( string IdEstadoDeStock , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstadoDeStock. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoDeStockIsValid( string IdEstadoDeStock)
		{
			string mensaje;
			return IdEstadoDeStockIsValid( IdEstadoDeStock, out mensaje );
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
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Aux1.
		/// </summary>
		public static bool Aux1IsValid( string Aux1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Aux1. Metodo Sobrecargado
		/// </summary>
		public static bool Aux1IsValid( string Aux1)
		{
			string mensaje;
			return Aux1IsValid( Aux1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Aux2.
		/// </summary>
		public static bool Aux2IsValid( string Aux2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Aux2. Metodo Sobrecargado
		/// </summary>
		public static bool Aux2IsValid( string Aux2)
		{
			string mensaje;
			return Aux2IsValid( Aux2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Aux3.
		/// </summary>
		public static bool Aux3IsValid( string Aux3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Aux3. Metodo Sobrecargado
		/// </summary>
		public static bool Aux3IsValid( string Aux3)
		{
			string mensaje;
			return Aux3IsValid( Aux3, out mensaje );
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
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( long IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}


