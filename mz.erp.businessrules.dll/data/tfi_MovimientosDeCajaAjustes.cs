using System;

namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_MovimientosDeCajaAjustes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_MovimientosDeCajaAjustes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_MovimientosDeCajaAjustes
		/// </summary>
		public static tfi_MovimientosDeCajaAjustesDataset GetList()
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.GetList();
		}
		public static tfi_MovimientosDeCajaAjustesDataset GetList(string IdMovimientoOrigen, string IdMovimientoAjuste)
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.GetList(IdMovimientoOrigen, IdMovimientoAjuste);
		}		
		/// <summary>
		/// Obtiene tabla tfi_MovimientosDeCajaAjustes filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tfi_MovimientosDeCajaAjustesDataset GetList(  )
		{
			return mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.GetList(  );
		}*/

		/// <summary>
		/// Crea un tfi_MovimientosDeCajaAjustesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_MovimientosDeCajaAjustes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow GetByPk( string IdMovimientoDeCaja, string IdMovimientoDeCajaAjuste )
		{
			tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row = mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.GetByPk( IdMovimientoDeCaja, IdMovimientoDeCajaAjuste  );
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
		/// Obtiene un registro de la tabla tfi_MovimientosDeCajaAjustes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow GetByPk( object IdMovimientoDeCaja, string IdMovimientoDeCajaAjuste )
		{
			return GetByPk( ( string )IdMovimientoDeCaja, ( string )IdMovimientoDeCajaAjuste );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_MovimientosDeCajaAjustesRow.
		/// </summary>
		public static tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow SetRowDefaultValues( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row )
		{
			row.IdMovimientoDeCaja = Util.NewStringId(); 
			row.IdMovimientoDeCajaAjuste = Util.NewStringId(); 
			row.aux1 = string.Empty;
			row.aux2 = string.Empty;
			row.aux3 = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaAjustesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaAjustesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaAjustesRow a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaAjustesDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaAjustesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_MovimientosDeCajaAjustes.Rows.Count > 0, "La tabla dataSet.tfi_MovimientosDeCajaAjustesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_MovimientosDeCajaAjustes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_MovimientosDeCajaAjustesRow.
		/// </summary>
		public static bool RowIsValid( tfi_MovimientosDeCajaAjustesDataset.tfi_MovimientosDeCajaAjustesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMovimientoDeCajaIsValid( row.IdMovimientoDeCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMovimientoDeCajaAjusteIsValid( row.IdMovimientoDeCajaAjuste, out mensaje) )
			{ 
				row.SetColumnError( "IdMovimientoDeCajaAjuste" , mensaje);
				isValid=false;
			
			}
						
			if ( !aux1IsValid( row.aux1, out mensaje) )
			{ 
				row.SetColumnError( "aux1" , mensaje);
				isValid=false;
			
			}
						
			if ( !aux2IsValid( row.aux2, out mensaje) )
			{ 
				row.SetColumnError( "aux2" , mensaje);
				isValid=false;
			
			}
						
			if ( !aux3IsValid( row.aux3, out mensaje) )
			{ 
				row.SetColumnError( "aux3" , mensaje);
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
		/// Valida el campo IdMovimientoDeCaja.
		/// </summary>
		public static bool IdMovimientoDeCajaIsValid( string IdMovimientoDeCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeCajaIsValid( string IdMovimientoDeCaja)
		{
			string mensaje;
			return IdMovimientoDeCajaIsValid( IdMovimientoDeCaja, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMovimientoDeCajaAjuste.
		/// </summary>
		public static bool IdMovimientoDeCajaAjusteIsValid( string IdMovimientoDeCajaAjuste , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMovimientoDeCajaAjuste. Metodo Sobrecargado
		/// </summary>
		public static bool IdMovimientoDeCajaAjusteIsValid( string IdMovimientoDeCajaAjuste)
		{
			string mensaje;
			return IdMovimientoDeCajaAjusteIsValid( IdMovimientoDeCajaAjuste, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo aux1.
		/// </summary>
		public static bool aux1IsValid( string aux1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo aux1. Metodo Sobrecargado
		/// </summary>
		public static bool aux1IsValid( string aux1)
		{
			string mensaje;
			return aux1IsValid( aux1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo aux2.
		/// </summary>
		public static bool aux2IsValid( string aux2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo aux2. Metodo Sobrecargado
		/// </summary>
		public static bool aux2IsValid( string aux2)
		{
			string mensaje;
			return aux2IsValid( aux2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo aux3.
		/// </summary>
		public static bool aux3IsValid( string aux3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo aux3. Metodo Sobrecargado
		/// </summary>
		public static bool aux3IsValid( string aux3)
		{
			string mensaje;
			return aux3IsValid( aux3, out mensaje );
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