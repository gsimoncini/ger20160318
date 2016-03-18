namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using System.Data.SqlClient;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_PagosMovimientosCajas : IDisposable
	{
	
		#region Custom Members
		/// <summary>
		/// Envia los cambios del tfi_PagosMovimientosCajas a la base de datos.
		/// </summary>
		public static void Update( tfi_PagosMovimientosCajasDataset data, SqlTransaction trx, SentenciasReplicacion replicacion)
		{						
			mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update( (DataTable) data.tfi_PagosMovimientosCajas, trx, replicacion );
		}	

		#endregion
		
		public tfi_PagosMovimientosCajas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_PagosMovimientosCajas
		/// </summary>
		public static tfi_PagosMovimientosCajasDataset GetList()
		{
			return mz.erp.dataaccess.tfi_PagosMovimientosCajas.GetList();
		}
		public static tfi_PagosMovimientosCajasDataset GetList(string IdMovimiento, string IdValor)
		{
			return mz.erp.dataaccess.tfi_PagosMovimientosCajas.GetList(IdMovimiento, IdValor);
		}
		public static tfi_PagosMovimientosCajasDataset GetList(string IdMovimiento, string IdValor, string IdInstanciaCaja, string Numero, string IdTipoDeMovimiento)
		{
			return mz.erp.dataaccess.tfi_PagosMovimientosCajas.GetList(IdMovimiento, IdValor, IdInstanciaCaja, Numero, IdTipoDeMovimiento);
		}
		/// <summary>
		/// Obtiene tabla tfi_PagosMovimientosCajas filtrada por las condiciones de bsqueda
		/// </summary>


		/// <summary>
		/// Crea un tfi_PagosMovimientosCajasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_PagosMovimientosCajas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_PagosMovimientosCajas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow GetByPk( string IdMovimiento, string IdValor )
		{
			tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row = mz.erp.dataaccess.tfi_PagosMovimientosCajas.GetByPk( IdMovimiento, IdValor  );
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
		/// Obtiene un registro de la tabla tfi_PagosMovimientosCajas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow GetByPk( object IdMovimiento, object IdValor )
		{
			return GetByPk( ( string )IdMovimiento, ( string )IdValor );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_PagosMovimientosCajasRow.
		/// </summary>
		public static tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow SetRowDefaultValues( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row )
		{
			row.IdMovimiento = Util.NewStringId(); 
			row.IdValor = Util.NewStringId(); 
			row.IdEmpresa = Convert.ToString(Security.IdEmpresa);
			row.IdSucursal = Convert.ToString(Security.IdSucursal);
			row.IdInstanciaCaja = string.Empty;
			row.IdTipoDeMovimiento = string.Empty;
			row.Numero = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_PagosMovimientosCajasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_PagosMovimientosCajasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_PagosMovimientosCajasRow a la base de datos.
		/// </summary>
		public static void Update( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_PagosMovimientosCajasDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_PagosMovimientosCajasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_PagosMovimientosCajas.Rows.Count > 0, "La tabla dataSet.tfi_PagosMovimientosCajasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_PagosMovimientosCajas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_PagosMovimientosCajasRow.
		/// </summary>
		public static bool RowIsValid( tfi_PagosMovimientosCajasDataset.tfi_PagosMovimientosCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoIsValid( row.IdMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimiento" , mensaje);
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
						
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeMovimientoIsValid( row.IdTipoDeMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdValorIsValid( row.IdValor, out mensaje) )
			{ 
				row.SetColumnError( "IdValor" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdMovimiento.
		/// </summary>
		public static bool IdMovimientoIsValid( string IdMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoIsValid( string IdMovimiento)
		{
			string mensaje;
			return IdMovimientoIsValid( IdMovimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdEmpresa.
		/// </summary>
		public static bool IdEmpresaIsValid( string IdEmpresa , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdEmpresa. Metodo Sobrecargado
		/// </summary>
		public static bool IdEmpresaIsValid( string IdEmpresa)
		{
			string mensaje;
			return IdEmpresaIsValid( IdEmpresa, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdSucursal.
		/// </summary>
		public static bool IdSucursalIsValid( string IdSucursal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdSucursal. Metodo Sobrecargado
		/// </summary>
		public static bool IdSucursalIsValid( string IdSucursal)
		{
			string mensaje;
			return IdSucursalIsValid( IdSucursal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja.
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja)
		{
			string mensaje;
			return IdInstanciaCajaIsValid( IdInstanciaCaja, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoDeMovimiento.
		/// </summary>
		public static bool IdTipoDeMovimientoIsValid( string IdTipoDeMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeMovimientoIsValid( string IdTipoDeMovimiento)
		{
			string mensaje;
			return IdTipoDeMovimientoIsValid( IdTipoDeMovimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroIsValid( string Numero)
		{
			string mensaje;
			return NumeroIsValid( Numero, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdValor.
		/// </summary>
		public static bool IdValorIsValid( string IdValor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdValor. Metodo Sobrecargado
		/// </summary>
		public static bool IdValorIsValid( string IdValor)
		{
			string mensaje;
			return IdValorIsValid( IdValor, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

