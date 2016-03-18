namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_DetalleConversiones : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_DetalleConversiones()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_DetalleConversiones
		/// </summary>
		public static tsh_DetalleConversionesDataset GetList()
		{
			return mz.erp.dataaccess.tsh_DetalleConversiones.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_DetalleConversiones filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_DetalleConversionesDataset GetList( string IdConversion, string IdUnidadOrigen, string IdUnidadDestino)
		{
			return mz.erp.dataaccess.tsh_DetalleConversiones.GetList( IdConversion, IdUnidadOrigen, IdUnidadDestino);
		}

		/// <summary>
		/// Crea un tsh_DetalleConversionesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_DetalleConversiones.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_DetalleConversiones que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow GetByPk( string IdConversion, string IdUnidadOrigen, string IdUnidadDestino )
		{
			tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow row = mz.erp.dataaccess.tsh_DetalleConversiones.GetByPk( IdConversion, IdUnidadOrigen, IdUnidadDestino  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
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
		/// Obtiene un registro de la tabla tsh_DetalleConversiones que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow GetByPk( object IdConversion, object IdUnidadOrigen, object  IdUnidadDestino )
		{
			return GetByPk( ( string )IdConversion, ( string )IdUnidadOrigen, ( string )IdUnidadDestino );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_DetalleConversionesRow.
		/// </summary>
		public static tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow SetRowDefaultValues( tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow row )
		{
			row.IdConversion = Util.NewStringId(); 
			row.IdUnidadOrigen = "1"; 
			row.IdUnidadDestino = "2"; 
			row.Ordinal = 0;
			row.ValorConversion = 0;
			row.FormulaConversion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IsDefault = false;
			

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DetalleConversionesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DetalleConversionesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DetalleConversionesRow a la base de datos.
		/// </summary>
		public static void Update( tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_DetalleConversiones.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_DetalleConversionesDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_DetalleConversionesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_DetalleConversiones.Rows.Count > 0, "La tabla dataSet.tsh_DetalleConversionesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_DetalleConversiones.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_DetalleConversionesDataset.tsh_DetalleConversionesDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_DetalleConversionesDataset.tsh_DetalleConversionesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_DetalleConversiones.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_DetalleConversionesRow.
		/// </summary>
		public static bool RowIsValid( tsh_DetalleConversionesDataset.tsh_DetalleConversionesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdConversionIsValid( row.IdConversion, out mensaje) )
			{ 
				row.SetColumnError( "IdConversion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdUnidadOrigenIsValid( row.IdUnidadOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdUnidadOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdUnidadDestinoIsValid( row.IdUnidadDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdUnidadDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorConversionIsValid( row.ValorConversion, out mensaje) )
			{ 
				row.SetColumnError( "ValorConversion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FormulaConversionIsValid( row.FormulaConversion, out mensaje) )
			{ 
				row.SetColumnError( "FormulaConversion" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdConversion.
		/// </summary>
		public static bool IdConversionIsValid( string IdConversion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConversion. Metodo Sobrecargado
		/// </summary>
		public static bool IdConversionIsValid( string IdConversion)
		{
			string mensaje;
			return IdConversionIsValid( IdConversion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdUnidadOrigen.
		/// </summary>
		public static bool IdUnidadOrigenIsValid( string IdUnidadOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUnidadOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdUnidadOrigenIsValid( string IdUnidadOrigen)
		{
			string mensaje;
			return IdUnidadOrigenIsValid( IdUnidadOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdUnidadDestino.
		/// </summary>
		public static bool IdUnidadDestinoIsValid( string IdUnidadDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdUnidadDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdUnidadDestinoIsValid( string IdUnidadDestino)
		{
			string mensaje;
			return IdUnidadDestinoIsValid( IdUnidadDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( int Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( int Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorConversion.
		/// </summary>
		public static bool ValorConversionIsValid( decimal ValorConversion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorConversion. Metodo Sobrecargado
		/// </summary>
		public static bool ValorConversionIsValid( decimal ValorConversion)
		{
			string mensaje;
			return ValorConversionIsValid( ValorConversion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FormulaConversion.
		/// </summary>
		public static bool FormulaConversionIsValid( string FormulaConversion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FormulaConversion. Metodo Sobrecargado
		/// </summary>
		public static bool FormulaConversionIsValid( string FormulaConversion)
		{
			string mensaje;
			return FormulaConversionIsValid( FormulaConversion, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}


