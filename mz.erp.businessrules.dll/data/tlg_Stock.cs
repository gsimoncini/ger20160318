namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_Stock : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_Stock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Stock
		/// </summary>
		///
		public static DataSet GetList(string IdProducto, string ListaVisualizacionesDeStock)  
		{			
			String IdEstadoDeStock = String.Empty;
			return GetList(IdProducto, ListaVisualizacionesDeStock, IdEstadoDeStock);		
		}

		public static DataSet GetStockSucursal(string IdProducto, string IdVisualizacionDeStock, string IdEstadoDeStock)  
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;
			string IdDeposito = String.Empty;
			string IdSeccion = String.Empty;						   
			DataSet data = new DataSet();			
			
			data = dataaccess.tlg_Stock.GetListSucursal(data, IdProducto, IdDeposito, IdSeccion, IdVisualizacionDeStock, IdEstadoDeStock, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD);				
			return data;
		}

		public static DataSet GetList(string IdProducto, string ListaVisualizacionesDeStock, string IdEstadoDeStock)
		{			
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;						   
			string IdDeposito = String.Empty;
			string IdSeccion = String.Empty;
			string IdVisualizacionDeStock = string.Empty;

			//long IdSucursalD = IdEmpresa;
			//long IdEmpresaD = IdSucursal;

			DataSet data = new DataSet();
			
			data = dataaccess.tlg_Stock.GetListVisualizacion(data, ListaVisualizacionesDeStock, IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD);

			data = dataaccess.tlg_Stock.GetListEstado(data,ListaVisualizacionesDeStock,IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD);						
			data = dataaccess.tlg_Stock.GetListSucursal(data, IdProducto, IdDeposito, IdSeccion, IdVisualizacionDeStock, IdEstadoDeStock, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD);

			DataColumn parentColumn = data.Tables[0].Columns["IdVisualizacionDeStock"];
			DataColumn childColumn = data.Tables[1].Columns["IdVisualizacionDeStock"];
			data.Relations.Add(parentColumn, childColumn);

			DataColumn parentColumn1 = data.Tables[1].Columns["IdVisualizacionDeStock"];
			DataColumn parentColumn2 = data.Tables[1].Columns["IdEstadoDeStock"];					
			DataColumn parentColumn3 = data.Tables[1].Columns["IdDeposito"];
			DataColumn parentColumn4 = data.Tables[1].Columns["IdSeccion"];					

			DataColumn[] ArrparentColumn = new DataColumn[]{parentColumn1, parentColumn2, parentColumn3, parentColumn4};

			DataColumn childColumn1 = data.Tables[2].Columns["IdVisualizacionDeStock"];
			DataColumn childColumn2 = data.Tables[2].Columns["IdEstadoDeStock"];
			DataColumn childColumn3 = data.Tables[2].Columns["IdDeposito"];
			DataColumn childColumn4 = data.Tables[2].Columns["IdSeccion"];

			DataColumn[] ArrchildColumn = new DataColumn[]{childColumn1, childColumn2, childColumn3, childColumn4};

			data.Relations.Add(ArrparentColumn, ArrchildColumn);
				
			return data;
		}

		public static tlg_StockDataset GetList()
		{
			return mz.erp.dataaccess.tlg_Stock.GetList();
		}

		public static DataSet GetStockSucursales(string IdProducto, string IdVisualizacionDeStock, string IdEstadoDeStock)  
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;
			long IdSucursalD = long.MinValue;
			long IdEmpresaD = long.MinValue;
			string IdDeposito = String.Empty;
			string IdSeccion = String.Empty;						   
			//long IdSucursalD = IdEmpresa;
			//long IdEmpresaD = IdSucursal;
			DataSet data = new DataSet();						
			
			data = dataaccess.tlg_Stock.GetListStockSucursales(data, IdProducto, IdDeposito, IdSeccion, IdVisualizacionDeStock, IdEstadoDeStock, IdSucursal, IdEmpresa, IdSucursalD, IdEmpresaD);				
			return data;
		}


		/// <summary>
		/// Obtiene tabla tlg_Stock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_StockDataset GetList( string IdProducto, string IdDeposito, string IdSeccion, long IdSucursal, long IdEmpresa )
		{
			string IdEstadoDeStock = "";
			return mz.erp.dataaccess.tlg_Stock.GetList( IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa );
		}
		
		/// <summary>
		/// Obtiene tabla tlg_Stock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_StockDataset GetList( string IdProducto,  string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa )
		{
			return mz.erp.dataaccess.tlg_Stock.GetList( IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa );
		}

		/// <summary>
		/// Crea un tlg_StockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_StockDataset.tlg_StockRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_Stock.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Stock que luego puede ser persistido en la base de datos.
		/// </summary>
		/*public static tlg_StockDataset.tlg_StockRow GetByPk( string IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa )
		{
			tlg_StockDataset.tlg_StockRow row = mz.erp.dataaccess.tlg_Stock.GetByPk( IdProducto, IdDeposito, IdSeccion, IdEstadoDeStock, IdSucursal, IdEmpresa  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					row[dc] = Util.DefaultValue( dc.DataType );
				}
			}
			return row;
		}*/

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Stock que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_StockDataset.tlg_StockRow GetByPk( object IdProducto, string IdDeposito, string IdSeccion, string IdEstadoDeStock, long IdSucursal, long IdEmpresa )
		{
			return GetByPk( ( string )IdProducto, ( string )IdDeposito, ( string )IdSeccion, ( string )IdEstadoDeStock, ( long )IdSucursal, ( long )IdEmpresa );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_StockRow.
		/// </summary>
		public static tlg_StockDataset.tlg_StockRow SetRowDefaultValues( tlg_StockDataset.tlg_StockRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdDeposito = Util.NewStringId(); 
			row.IdSeccion = Util.NewStringId(); 
			row.IdEstadoDeStock = Util.NewStringId(); 
			row.IdSucursal = Security.IdSucursal; 
			row.IdEmpresa = Security.IdEmpresa; 
			row.Cantidad = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			//row.SetIdGeneradoNull();
			row.SetRowIdGeneradoNull();

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_StockDataset.tlg_StockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_StockDataset.tlg_StockRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockRow a la base de datos.
		/// </summary>
		public static void Update( tlg_StockDataset.tlg_StockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Stock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_StockDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_StockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Stock.Rows.Count > 0, "La tabla dataSet.tlg_StockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Stock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_StockDataset.tlg_StockDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_StockDataset.tlg_StockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Stock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_StockRow.
		/// </summary>
		public static bool RowIsValid( tlg_StockDataset.tlg_StockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
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
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad)
		{
			string mensaje;
			return CantidadIsValid( Cantidad, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

