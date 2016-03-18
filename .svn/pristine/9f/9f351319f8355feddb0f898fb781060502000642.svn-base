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

	public class tfi_MovimientoBancario : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_MovimientoBancario()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_MovimientoBancario
		/// </summary>
		public static tfi_MovimientoBancarioDataset GetList()
		{
			return mz.erp.dataaccess.tfi_MovimientoBancario.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_MovimientoBancario filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_MovimientoBancarioDataset GetList( string IdMovimientoBancario, string IdTipoMovimiento, string IdCuenta, string IdValor, string NroCheque, decimal Total, DateTime FechaConciliacion, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, long IdEmpresa, Guid RowId , DateTime FechaImputacion)
		{
			return mz.erp.dataaccess.tfi_MovimientoBancario.GetList( IdMovimientoBancario, IdTipoMovimiento, IdCuenta, IdValor, NroCheque, Total, FechaConciliacion, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, IdEmpresa, RowId, FechaImputacion );
		}

		/// <summary>
		/// Crea un tfi_MovimientoBancarioRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_MovimientoBancario.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_MovimientoBancario que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow GetByPk( string IdMovimientoBancario )
		{
			tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow row = mz.erp.dataaccess.tfi_MovimientoBancario.GetByPk( IdMovimientoBancario  );
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
		/// Obtiene un registro de la tabla tfi_MovimientoBancario que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow GetByPk( object IdMovimientoBancario )
		{
			return GetByPk( ( string )IdMovimientoBancario );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_MovimientoBancarioRow.
		/// </summary>
		public static tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow SetRowDefaultValues( tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow row )
		{
			row.IdMovimientoBancario = Util.NewStringId(); 
			row.IdTipoMovimiento = string.Empty;
			row.IdCuenta = string.Empty;
			row.IdValor = string.Empty;
			row.NroCheque = string.Empty;
			row.Total = 0;
			row.FechaImputacion = DateTime.Now;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.IdEmpresa = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientoBancarioRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientoBancarioRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientoBancarioRow a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientoBancario.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_MovimientoBancarioDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientoBancarioDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_MovimientoBancario.Rows.Count > 0, "La tabla dataSet.tfi_MovimientoBancarioDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientoBancario.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioDataTable dataTable,SqlTransaction trx )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientoBancario.Update( dataTable ,trx);
		}
		
		/// <summary>
		/// Valida un tfi_MovimientoBancarioRow.
		/// </summary>
		public static bool RowIsValid( tfi_MovimientoBancarioDataset.tfi_MovimientoBancarioRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoBancarioIsValid( row.IdMovimientoBancario, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoBancario" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoMovimientoIsValid( row.IdTipoMovimiento, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoMovimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdValorIsValid( row.IdValor, out mensaje) )
			{ 
				row.SetColumnError( "IdValor" , mensaje);
				isValid=false;
			
			}
						
			if ( !NroChequeIsValid( row.NroCheque, out mensaje) )
			{ 
				row.SetColumnError( "NroCheque" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalIsValid( row.Total, out mensaje) )
			{ 
				row.SetColumnError( "Total" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaConciliacionIsValid( row.FechaConciliacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaConciliacion" , mensaje);
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
		/// Valida el campo IdMovimientoBancario.
		/// </summary>
		public static bool IdMovimientoBancarioIsValid( string IdMovimientoBancario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoBancario. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoBancarioIsValid( string IdMovimientoBancario)
		{
			string mensaje;
			return IdMovimientoBancarioIsValid( IdMovimientoBancario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento.
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoMovimiento. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoMovimientoIsValid( string IdTipoMovimiento)
		{
			string mensaje;
			return IdTipoMovimientoIsValid( IdTipoMovimiento, out mensaje );
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
		/// Valida el campo NroCheque.
		/// </summary>
		public static bool NroChequeIsValid( string NroCheque , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo NroCheque. Metodo Sobrecargado
		/// </summary>
		public static bool NroChequeIsValid( string NroCheque)
		{
			string mensaje;
			return NroChequeIsValid( NroCheque, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Total.
		/// </summary>
		public static bool TotalIsValid( decimal Total , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Total. Metodo Sobrecargado
		/// </summary>
		public static bool TotalIsValid( decimal Total)
		{
			string mensaje;
			return TotalIsValid( Total, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaConciliacion.
		/// </summary>
		public static bool FechaConciliacionIsValid( DateTime FechaConciliacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaConciliacion. Metodo Sobrecargado
		/// </summary>
		public static bool FechaConciliacionIsValid( DateTime FechaConciliacion)
		{
			string mensaje;
			return FechaConciliacionIsValid( FechaConciliacion, out mensaje );
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


