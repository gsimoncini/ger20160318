namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_CuentaBancaria : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_CuentaBancaria()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_CuentaBancaria
		/// </summary>
		public static tfi_CuentaBancariaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_CuentaBancaria.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_CuentaBancaria filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_CuentaBancariaDataset GetList( string IdCuenta, string CodigoCuenta, string IdBanco, string NroCuenta, string Descripcion)
		{
			return mz.erp.dataaccess.tfi_CuentaBancaria.GetList( IdCuenta, CodigoCuenta, IdBanco, NroCuenta, Descripcion );
		}

		public static DataTable GetListPorBanco(  string IdBanco)
		{
			tfi_CuentaBancariaDataset dataSet= mz.erp.dataaccess.tfi_CuentaBancaria.GetList( string.Empty, string.Empty, IdBanco, string.Empty, string.Empty );
			return dataSet.Tables[0];
		}


		/// <summary>
		/// Crea un tfi_CuentaBancariaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_CuentaBancaria.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_CuentaBancaria que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow GetByPk( string IdCuenta )
		{
			tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow row = mz.erp.dataaccess.tfi_CuentaBancaria.GetByPk( IdCuenta  );
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
		/// Obtiene un registro de la tabla tfi_CuentaBancaria que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow GetByPk( object IdCuenta )
		{
			return GetByPk( ( string )IdCuenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_CuentaBancariaRow.
		/// </summary>
		public static tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow SetRowDefaultValues( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow row )
		{
			row.IdCuenta = Util.NewStringId(); 
			row.CodigoCuenta = string.Empty;
			row.IdBanco = string.Empty;
			row.NroCuenta = string.Empty;
			row.Descripcion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdEmpresa = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CuentaBancariaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CuentaBancariaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CuentaBancariaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_CuentaBancaria.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_CuentaBancariaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_CuentaBancariaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_CuentaBancaria.Rows.Count > 0, "La tabla dataSet.tfi_CuentaBancariaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_CuentaBancaria.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_CuentaBancariaDataset.tfi_CuentaBancariaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_CuentaBancariaDataset.tfi_CuentaBancariaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_CuentaBancaria.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_CuentaBancariaRow.
		/// </summary>
		public static bool RowIsValid( tfi_CuentaBancariaDataset.tfi_CuentaBancariaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoCuentaIsValid( row.CodigoCuenta, out mensaje) )
			{ 
				row.SetColumnError( "CodigoCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdBancoIsValid( row.IdBanco, out mensaje) )
			{ 
				row.SetColumnError( "IdBanco" , mensaje);
				isValid=false;
			
			}
						
			if ( !NroCuentaIsValid( row.NroCuenta, out mensaje) )
			{ 
				row.SetColumnError( "NroCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
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
						
			if ( !IdEmpresaIsValid( row.IdEmpresa, out mensaje) )
			{ 
				row.SetColumnError( "IdEmpresa" , mensaje);
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
		/// Valida el campo CodigoCuenta.
		/// </summary>
		public static bool CodigoCuentaIsValid( string CodigoCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoCuentaIsValid( string CodigoCuenta)
		{
			string mensaje;
			return CodigoCuentaIsValid( CodigoCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdBanco.
		/// </summary>
		public static bool IdBancoIsValid( string IdBanco , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdBanco. Metodo Sobrecargado
		/// </summary>
		public static bool IdBancoIsValid( string IdBanco)
		{
			string mensaje;
			return IdBancoIsValid( IdBanco, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo NroCuenta.
		/// </summary>
		public static bool NroCuentaIsValid( string NroCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NroCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool NroCuentaIsValid( string NroCuenta)
		{
			string mensaje;
			return NroCuentaIsValid( NroCuenta, out mensaje );
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

