namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using System.Collections;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_TiposDeAjuste : IDisposable
	{
	
		#region Custom Members
		
		public static tlg_TiposDeAjusteDataset GetListQueNoSeanDeSistema( string IdTipoAjuste, string Descripcion)
		{
			return mz.erp.dataaccess.tlg_TiposDeAjuste.GetListQueNoSeanDeSistema(IdTipoAjuste, Descripcion);
		}

		#endregion
		
		public tlg_TiposDeAjuste()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_TiposDeAjuste
		/// </summary>
		public static tlg_TiposDeAjusteDataset GetList()
		{
			return mz.erp.dataaccess.tlg_TiposDeAjuste.GetList();
		}

		public static tlg_TiposDeAjusteDataset GetListSigno( string Signo, bool Sistema )
		{
			return mz.erp.dataaccess.tlg_TiposDeAjuste.GetListSigno(Signo, Sistema);
		} 
		

		/*public static DataTable GetList(bool sistema) 
		{						
			tlg_TiposDeAjusteDataset data = businessrules.tlg_TiposDeAjuste.GetList();			
			System.Data.DataView view = new System.Data.DataView(data.tlg_TiposDeAjuste,"Sistema = " + sistema.ToString(),"",System.Data.DataViewRowState.None);
			return view.Table;*/
			

			/*foreach (tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row in data.tlg_TiposDeAjuste.Rows)
			{
				if (row.Sistema == sistema) 
				{
					arr.Add(row);
				}
			}*/
			//return arr;
		//}*/

		
		/// <summary>
		/// Obtiene tabla tlg_TiposDeAjuste filtrada por las condiciones de bsqueda
		/// </summary>
		/// 
		//public static tlg_TiposDeAjusteDataset GetList( string IdTipoAjuste, string Descripcion, bool Sistema, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdSucursal, long IdEmpresa, string IdEstadoDeStock, string OldIdTipoAjuste )
		public static tlg_TiposDeAjusteDataset GetList( string IdTipoAjuste, string Descripcion)
		{
			return mz.erp.dataaccess.tlg_TiposDeAjuste.GetList( IdTipoAjuste, Descripcion);
		}

		/// <summary>
		/// Crea un tlg_TiposDeAjusteRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_TiposDeAjuste.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_TiposDeAjuste que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow GetByPk( string IdTipoAjuste )
		{
			tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row = mz.erp.dataaccess.tlg_TiposDeAjuste.GetByPk( IdTipoAjuste  );
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
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_TiposDeAjuste que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow GetByPk( object IdTipoAjuste )
		{
			return GetByPk( ( string )IdTipoAjuste );
		}


	
		/// <summary>
		/// busca la tupla en la tabla de tipos de ajustes de stock que tenga la descripcion tomada de la 
		/// variables de configuracion "Stock.IngresoParaReposicion.AjusteDeStock.Default"
		/// </summary>
		public static tlg_TiposDeAjusteDataset GetByDescripcion()
		{
			string descripcion = Variables.GetValueString("Stock.IngresoParaReposicion.AjusteDeStock.Default");
			return mz.erp.dataaccess.tlg_TiposDeAjuste.GetByDescripcion(descripcion);
		}



		/// <summary>
		/// Establece los valores por defecto de tlg_TiposDeAjusteRow.
		/// </summary>
		public static tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow SetRowDefaultValues( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row )
		{
			row.IdTipoAjuste = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Sistema = false;
			row.Operacion = -1;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
		//	row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdEstadoDeStock = string.Empty;
			row.OldIdTipoAjuste = string.Empty;
			row.Activo = true;
			row.AfectaSeguimientoDeArticulosFisico = false;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposDeAjusteRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposDeAjusteRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposDeAjusteRow a la base de datos.
		/// </summary>
		public static void Update( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TiposDeAjuste.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_TiposDeAjusteDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_TiposDeAjusteDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_TiposDeAjuste.Rows.Count > 0, "La tabla dataSet.tlg_TiposDeAjusteDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TiposDeAjuste.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TiposDeAjuste.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_TiposDeAjusteRow.
		/// </summary>
		public static bool RowIsValid( tlg_TiposDeAjusteDataset.tlg_TiposDeAjusteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoAjusteIsValid( row.IdTipoAjuste, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoAjuste" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !SistemaIsValid( row.Sistema, out mensaje) )
			{ 
				row.SetColumnError( "Sistema" , mensaje);
				isValid=false;
			
			}
						
			if ( !OperacionIsValid( row.Operacion, out mensaje) )
			{ 
				row.SetColumnError( "Operacion" , mensaje);
				isValid=false;
			
			}
						
		/*	if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
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
						
			if ( !IdEstadoDeStockIsValid( row.IdEstadoDeStock, out mensaje) )
			{ 
				row.SetColumnError( "IdEstadoDeStock" , mensaje);
				isValid=false;
			
			}
						
			if ( !OldIdTipoAjusteIsValid( row.OldIdTipoAjuste, out mensaje) )
			{ 
				row.SetColumnError( "OldIdTipoAjuste" , mensaje);
				isValid=false;
			
			}*/
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTipoAjuste.
		/// </summary>
		public static bool IdTipoAjusteIsValid( string IdTipoAjuste , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoAjuste. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoAjusteIsValid( string IdTipoAjuste)
		{
			string mensaje;
			return IdTipoAjusteIsValid( IdTipoAjuste, out mensaje );
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
		/// Valida el campo Sistema.
		/// </summary>
		public static bool SistemaIsValid( bool Sistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Sistema. Metodo Sobrecargado
		/// </summary>
		public static bool SistemaIsValid( bool Sistema)
		{
			string mensaje;
			return SistemaIsValid( Sistema, out mensaje );
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
		/// Valida el campo OldIdTipoAjuste.
		/// </summary>
		public static bool OldIdTipoAjusteIsValid( string OldIdTipoAjuste , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OldIdTipoAjuste. Metodo Sobrecargado
		/// </summary>
		public static bool OldIdTipoAjusteIsValid( string OldIdTipoAjuste)
		{
			string mensaje;
			return OldIdTipoAjusteIsValid( OldIdTipoAjuste, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

