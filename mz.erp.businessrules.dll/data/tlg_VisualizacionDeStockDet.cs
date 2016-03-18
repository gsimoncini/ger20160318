namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_VisualizacionDeStockDet : IDisposable
	{
	
		#region Custom Members

		public static DataSet GetListEx()
		{
			return mz.erp.dataaccess.tlg_VisualizacionDeStockDet.GetListEx();
		}
		
		public static DataSet GetListEx(string IdVisualizacionDeStock)
		{
			return mz.erp.dataaccess.tlg_VisualizacionDeStockDet.GetListEx(IdVisualizacionDeStock);
		}

		#endregion
		
		public tlg_VisualizacionDeStockDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_VisualizacionDeStockDet
		/// </summary>
		public static tlg_VisualizacionDeStockDetDataset GetList()
		{
			return mz.erp.dataaccess.tlg_VisualizacionDeStockDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_VisualizacionDeStockDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_VisualizacionDeStockDetDataset GetList( string IdVisualizacionDeStock, string IdEstadoDeStock, short Operacion )
		{
			return mz.erp.dataaccess.tlg_VisualizacionDeStockDet.GetList( IdVisualizacionDeStock, IdEstadoDeStock, Operacion );
		}

		/// <summary>
		/// Crea un tlg_VisualizacionDeStockDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_VisualizacionDeStockDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_VisualizacionDeStockDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow GetByPk( string IdVisualizacionDeStock, string IdEstadoDeStock )
		{
			tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow row = mz.erp.dataaccess.tlg_VisualizacionDeStockDet.GetByPk( IdVisualizacionDeStock, IdEstadoDeStock  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if(!dc.Caption.ToUpper().Equals("ROWID"))
					{
						if (row[dc] == System.DBNull.Value)
						{
							row[dc] = Util.DefaultValue( dc.DataType );
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_VisualizacionDeStockDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow GetByPk( object IdVisualizacionDeStock, object IdEstadoDeStock )
		{
			return GetByPk( ( string )IdVisualizacionDeStock, ( string )IdEstadoDeStock );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_VisualizacionDeStockDetRow.
		/// </summary>
		public static tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow SetRowDefaultValues( tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow row )
		{
			row.IdVisualizacionDeStock = Util.NewStringId(); 
			row.IdEstadoDeStock = Util.NewStringId(); 
			row.Operacion = 0;
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
		/// Envia los cambios del tlg_VisualizacionDeStockDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_VisualizacionDeStockDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_VisualizacionDeStockDetRow a la base de datos.
		/// </summary>
		public static void Update( tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_VisualizacionDeStockDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_VisualizacionDeStockDetDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_VisualizacionDeStockDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_VisualizacionDeStockDet.Rows.Count > 0, "La tabla dataSet.tlg_VisualizacionDeStockDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_VisualizacionDeStockDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_VisualizacionDeStockDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_VisualizacionDeStockDetRow.
		/// </summary>
		public static bool RowIsValid( tlg_VisualizacionDeStockDetDataset.tlg_VisualizacionDeStockDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdVisualizacionDeStockIsValid( row.IdVisualizacionDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdVisualizacionDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoDeStockIsValid( row.IdEstadoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !OperacionIsValid( row.Operacion, out mensaje) )
			{ 
				row.SetColumnError( "Operacion" , mensaje);
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
		/// Valida el campo IdVisualizacionDeStock.
		/// </summary>
		public static bool IdVisualizacionDeStockIsValid( string IdVisualizacionDeStock , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdVisualizacionDeStock. Metodo Sobrecargado
		/// </summary>
		public static bool IdVisualizacionDeStockIsValid( string IdVisualizacionDeStock)
		{
			string mensaje;
			return IdVisualizacionDeStockIsValid( IdVisualizacionDeStock, out mensaje );
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
		/// Valida el campo Operacion.
		/// </summary>
		public static bool OperacionIsValid( short Operacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Operacion. Metodo Sobrecargado
		/// </summary>
		public static bool OperacionIsValid( short Operacion)
		{
			string mensaje;
			return OperacionIsValid( Operacion, out mensaje );
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


