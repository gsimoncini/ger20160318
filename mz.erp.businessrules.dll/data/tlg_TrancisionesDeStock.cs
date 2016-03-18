namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_TransicionesDeStock : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_TransicionesDeStock()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_TransicionesDeStock
		/// </summary>
		public static tlg_TransicionesDeStockDataset GetList()
		{
			return mz.erp.dataaccess.tlg_TransicionesDeStock.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_TransicionesDeStock filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_TransicionesDeStockDataset GetList( long IdMomento, string IdEstadoDeStockOrigen, string IdEstadoDeStockDestino)
		{
			return mz.erp.dataaccess.tlg_TransicionesDeStock.GetList( IdMomento, IdEstadoDeStockOrigen, IdEstadoDeStockDestino);
		}

		/// <summary>
		/// Crea un tlg_TransicionesDeStockRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_TransicionesDeStock.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_TransicionesDeStock que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow GetByPk( long IdMomento )
		{
			tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow row = mz.erp.dataaccess.tlg_TransicionesDeStock.GetByPk( IdMomento  );
			foreach ( DataColumn dc in row.Table.Columns ) 
			{
				if (row[dc] == System.DBNull.Value)
				{
					object defaultValue =Util.DefaultValue( dc.DataType ) ;
					if (defaultValue != null)
					{
						row[dc] = defaultValue;
					}
					
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_TransicionesDeStock que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow GetByPk( object IdMomento )
		{
			return GetByPk( ( long )IdMomento );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_TransicionesDeStockRow.
		/// </summary>
		public static tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow SetRowDefaultValues( tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow row )
		{
			row.IdMomento = 0; 
			row.IdEstadoDeStockOrigen = string.Empty;
			row.IdEstadoDeStockDestino = string.Empty;
			//row.Descripcion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;
			row.OldIdMomento = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransicionesDeStockRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransicionesDeStockRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransicionesDeStockRow a la base de datos.
		/// </summary>
		public static void Update( tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TransicionesDeStock.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_TransicionesDeStockDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_TransicionesDeStockDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_TransicionesDeStock.Rows.Count > 0, "La tabla dataSet.tlg_TransicionesDeStockDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TransicionesDeStock.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TransicionesDeStock.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_TransicionesDeStockRow.
		/// </summary>
		public static bool RowIsValid( tlg_TransicionesDeStockDataset.tlg_TransicionesDeStockRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMomentoIsValid( row.IdMomento, out mensaje) )
			{ 
				row.SetColumnError( "IdMomento" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoDeStockOrigenIsValid( row.IdEstadoDeStockOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoDeStockOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdEstadoDeStockDestinoIsValid( row.IdEstadoDeStockDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoDeStockDestino" , mensaje);
				isValid=false;
			
			}
						
			/*if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
						
			if ( !OldIdMomentoIsValid( row.OldIdMomento, out mensaje) )
			{ 
				row.SetColumnError( "OldIdMomento" , mensaje);
				isValid=false;
			
			}
			;
			*/
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdMomento.
		/// </summary>
		public static bool IdMomentoIsValid( long IdMomento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMomento. Metodo Sobrecargado
		/// </summary>
		public static bool IdMomentoIsValid( long IdMomento)
		{
			string mensaje;
			return IdMomentoIsValid( IdMomento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEstadoDeStockOrigen.
		/// </summary>
		public static bool IdEstadoDeStockOrigenIsValid( string IdEstadoDeStockOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstadoDeStockOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoDeStockOrigenIsValid( string IdEstadoDeStockOrigen)
		{
			string mensaje;
			return IdEstadoDeStockOrigenIsValid( IdEstadoDeStockOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEstadoDeStockDestino.
		/// </summary>
		public static bool IdEstadoDeStockDestinoIsValid( string IdEstadoDeStockDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEstadoDeStockDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdEstadoDeStockDestinoIsValid( string IdEstadoDeStockDestino)
		{
			string mensaje;
			return IdEstadoDeStockDestinoIsValid( IdEstadoDeStockDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
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
		
		/// <summary>
		/// Valida el campo OldIdMomento.
		/// </summary>
		public static bool OldIdMomentoIsValid( long OldIdMomento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OldIdMomento. Metodo Sobrecargado
		/// </summary>
		public static bool OldIdMomentoIsValid( long OldIdMomento)
		{
			string mensaje;
			return OldIdMomentoIsValid( OldIdMomento, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

