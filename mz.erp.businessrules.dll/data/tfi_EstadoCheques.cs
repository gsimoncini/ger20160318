namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_EstadoCheques : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_EstadoCheques()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_EstadoCheques
		/// </summary>
		public static tfi_EstadoChequesDataset GetList()
		{
			return mz.erp.dataaccess.tfi_EstadoCheques.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_EstadoCheques filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_EstadoChequesDataset GetList( string idEstadoCheque, string nombre, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, long IdEmpresa, Guid RowId )
		{
			return mz.erp.dataaccess.tfi_EstadoCheques.GetList( idEstadoCheque, nombre, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, IdEmpresa, RowId );
		}

		/// <summary>
		/// Crea un tfi_EstadoChequesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_EstadoChequesDataset.tfi_EstadoChequesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_EstadoCheques.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_EstadoCheques que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_EstadoChequesDataset.tfi_EstadoChequesRow GetByPk( string idEstadoCheque )
		{
			tfi_EstadoChequesDataset.tfi_EstadoChequesRow row = mz.erp.dataaccess.tfi_EstadoCheques.GetByPk( idEstadoCheque  );
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
		/// Obtiene un registro de la tabla tfi_EstadoCheques que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_EstadoChequesDataset.tfi_EstadoChequesRow GetByPk( object idEstadoCheque )
		{
			return GetByPk( ( string )idEstadoCheque );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_EstadoChequesRow.
		/// </summary>
		public static tfi_EstadoChequesDataset.tfi_EstadoChequesRow SetRowDefaultValues( tfi_EstadoChequesDataset.tfi_EstadoChequesRow row )
		{
			row.idEstadoCheque = Util.NewStringId(); 
			row.nombre = string.Empty;
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
		/// Envia los cambios del tfi_EstadoChequesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_EstadoChequesDataset.tfi_EstadoChequesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EstadoChequesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_EstadoChequesDataset.tfi_EstadoChequesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EstadoChequesRow a la base de datos.
		/// </summary>
		public static void Update( tfi_EstadoChequesDataset.tfi_EstadoChequesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_EstadoCheques.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_EstadoChequesDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_EstadoChequesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_EstadoCheques.Rows.Count > 0, "La tabla dataSet.tfi_EstadoChequesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_EstadoCheques.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_EstadoChequesDataset.tfi_EstadoChequesDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_EstadoChequesDataset.tfi_EstadoChequesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_EstadoCheques.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_EstadoChequesRow.
		/// </summary>
		public static bool RowIsValid( tfi_EstadoChequesDataset.tfi_EstadoChequesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !idEstadoChequeIsValid( row.idEstadoCheque, out mensaje) )
			{ 
				row.SetColumnError( "idEstadoCheque" , mensaje);
				isValid=false;
			
			}
						
			if ( !nombreIsValid( row.nombre, out mensaje) )
			{ 
				row.SetColumnError( "nombre" , mensaje);
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
		/// Valida el campo idEstadoCheque.
		/// </summary>
		public static bool idEstadoChequeIsValid( string idEstadoCheque , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo idEstadoCheque. Metodo Sobrecargado
		/// </summary>
		public static bool idEstadoChequeIsValid( string idEstadoCheque)
		{
			string mensaje;
			return idEstadoChequeIsValid( idEstadoCheque, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo nombre.
		/// </summary>
		public static bool nombreIsValid( string nombre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo nombre. Metodo Sobrecargado
		/// </summary>
		public static bool nombreIsValid( string nombre)
		{
			string mensaje;
			return nombreIsValid( nombre, out mensaje );
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

