namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_Chequera : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_Chequera()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_Chequera
		/// </summary>
		public static tfi_ChequeraDataset GetList()
		{
			return mz.erp.dataaccess.tfi_Chequera.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_Chequera filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_ChequeraDataset GetList( string IdChequera, string IdBanco, string IdCuenta, long CodigoChequera, string Comienzo, string Final,DateTime FechaApertura,DateTime FechaCierre )
		{
			return mz.erp.dataaccess.tfi_Chequera.GetList( IdChequera, IdBanco, IdCuenta, CodigoChequera, Comienzo, Final,FechaApertura, FechaCierre );
		}

		public static tfi_ChequeraDataset GetListAbierta( string IdBanco, string IdCuenta)
		{
			return mz.erp.dataaccess.tfi_Chequera.GetListAbierta( IdBanco, IdCuenta);
		}
		/// <summary>
		/// Crea un tfi_ChequeraRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_ChequeraDataset.tfi_ChequeraRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_Chequera.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_Chequera que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_ChequeraDataset.tfi_ChequeraRow GetByPk( string IdChequera )
		{
			tfi_ChequeraDataset.tfi_ChequeraRow row = mz.erp.dataaccess.tfi_Chequera.GetByPk( IdChequera  );
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
		/// Obtiene un registro de la tabla tfi_Chequera que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_ChequeraDataset.tfi_ChequeraRow GetByPk( object IdChequera )
		{
			return GetByPk( ( string )IdChequera );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_ChequeraRow.
		/// </summary>
		public static tfi_ChequeraDataset.tfi_ChequeraRow SetRowDefaultValues( tfi_ChequeraDataset.tfi_ChequeraRow row )
		{
			row.IdChequera = Util.NewStringId(); 
			row.IdBanco = string.Empty;
			row.IdCuenta = string.Empty;
			row.CodigoChequera = 0;
			row.Comienzo = string.Empty;
			row.Final = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdEmpresa = 0;
			row.RowId = Guid.Empty;
			row.FechaApertura=DateTime.Now;
			/*row.FechaCierre=DateTime.MinValue;*/


			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ChequeraRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_ChequeraDataset.tfi_ChequeraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ChequeraRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_ChequeraDataset.tfi_ChequeraRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ChequeraRow a la base de datos.
		/// </summary>
		public static void Update( tfi_ChequeraDataset.tfi_ChequeraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Chequera.Update( row );
		}


		/// <summary>
		/// Envia los cambios del tfi_ChequeraDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_ChequeraDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_Chequera.Rows.Count > 0, "La tabla dataSet.tfi_ChequeraDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Chequera.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_ChequeraDataset.tfi_ChequeraDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_ChequeraDataset.tfi_ChequeraDataTable dataTable ,SqlTransaction trx)
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Chequera.Update(dataTable,trx);
		}
		
		/// <summary>
		/// Valida un tfi_ChequeraRow.
		/// </summary>
		public static bool RowIsValid( tfi_ChequeraDataset.tfi_ChequeraRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdChequeraIsValid( row.IdChequera, out mensaje) )
			{ 
				row.SetColumnError( "IdChequera" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdBancoIsValid( row.IdBanco, out mensaje) )
			{ 
				row.SetColumnError( "IdBanco" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoChequeraIsValid( row.CodigoChequera, out mensaje) )
			{ 
				row.SetColumnError( "CodigoChequera" , mensaje);
				isValid=false;
			
			}
						
			if ( !ComienzoIsValid( row.Comienzo, out mensaje) )
			{ 
				row.SetColumnError( "Comienzo" , mensaje);
				isValid=false;
			
			}
						
			if ( !FinalIsValid( row.Final, out mensaje) )
			{ 
				row.SetColumnError( "Final" , mensaje);
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
		/// Valida el campo IdChequera.
		/// </summary>
		public static bool IdChequeraIsValid( string IdChequera , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdChequera. Metodo Sobrecargado
		/// </summary>
		public static bool IdChequeraIsValid( string IdChequera)
		{
			string mensaje;
			return IdChequeraIsValid( IdChequera, out mensaje );
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
		/// Valida el campo CodigoChequera.
		/// </summary>
		public static bool CodigoChequeraIsValid( long CodigoChequera , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoChequera. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoChequeraIsValid( long CodigoChequera)
		{
			string mensaje;
			return CodigoChequeraIsValid( CodigoChequera, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Comienzo.
		/// </summary>
		public static bool ComienzoIsValid( string Comienzo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Comienzo. Metodo Sobrecargado
		/// </summary>
		public static bool ComienzoIsValid( string Comienzo)
		{
			string mensaje;
			return ComienzoIsValid( Comienzo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Final.
		/// </summary>
		public static bool FinalIsValid( string Final , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Final. Metodo Sobrecargado
		/// </summary>
		public static bool FinalIsValid( string Final)
		{
			string mensaje;
			return FinalIsValid( Final, out mensaje );
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


