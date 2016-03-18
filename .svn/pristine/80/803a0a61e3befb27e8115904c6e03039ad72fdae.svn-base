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

	public class tsa_CuentasCondicionesDeVenta : IDisposable
	{
	
		#region Custom Members
		public static bool GetActivo(string IdCuenta, string IdCondicionDeVenta) 
		{
			DataSet data = dataaccess.tsa_CondicionesDeVentas.GetList(IdCuenta, IdCondicionDeVenta);
			if (data == null) 
			{
				return false;
			}
			else 
			{
				if (data.Tables[0].Rows.Count == 0) 
				{
					return false;
				}
				else 
				{
					return true;
				}				
			}
		}
		
		#endregion
		
		public tsa_CuentasCondicionesDeVenta()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CuentasCondicionesDeVenta
		/// </summary>
		public static tsa_CuentasCondicionesDeVentaDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_CuentasCondicionesDeVenta filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsa_CuentasCondicionesDeVentaDataset GetList(  )
		{
			return mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsa_CuentasCondicionesDeVentaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasCondicionesDeVenta que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow GetByPk( string IdCuenta, string IdCondicionDeVenta )
		{
			tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow row = mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.GetByPk( IdCuenta, IdCondicionDeVenta  );
			if (row == null){return null;}

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
		/// Obtiene un registro de la tabla tsa_CuentasCondicionesDeVenta que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
/*		[ atMethodGetByPkRow ]
		public static tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow GetByPk( object IdCuenta, IdCondicionDeVenta )
		{
			return GetByPk( ( string )IdCuenta, ( string )IdCondicionDeVenta );
		}*/

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasCondicionesDeVentaRow.
		/// </summary>
		public static tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow SetRowDefaultValues( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.Valor = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasCondicionesDeVentaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow row)
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row);
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasCondicionesDeVentaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasCondicionesDeVentaRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow row, SqlTransaction trx, SentenciasReplicacion replicacion)
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.Update( row);
		}

		public static void Update( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow row)
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.Update( row);
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasCondicionesDeVentaDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasCondicionesDeVentaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CuentasCondicionesDeVenta.Rows.Count > 0, "La tabla dataSet.tsa_CuentasCondicionesDeVentaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasCondicionesDeVenta.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CuentasCondicionesDeVentaRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasCondicionesDeVentaDataset.tsa_CuentasCondicionesDeVentaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCondicionDeVentaIsValid( row.IdCondicionDeVenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicionDeVenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorIsValid( row.Valor, out mensaje) )
			{ 
				row.SetColumnError( "Valor" , mensaje);
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
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta.
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( string IdCondicionDeVenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeVenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionDeVentaIsValid( string IdCondicionDeVenta)
		{
			string mensaje;
			return IdCondicionDeVentaIsValid( IdCondicionDeVenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Valor.
		/// </summary>
		public static bool ValorIsValid( decimal Valor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Valor. Metodo Sobrecargado
		/// </summary>
		public static bool ValorIsValid( decimal Valor)
		{
			string mensaje;
			return ValorIsValid( Valor, out mensaje );
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

