namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_Banco : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_Banco()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_Banco
		/// </summary>
		public static tfi_BancoDataset GetList()
		{
			return mz.erp.dataaccess.tfi_Banco.GetList();
		}

		public static DataTable GetListEnTabla()
		{
			tfi_BancoDataset  dataSet= mz.erp.dataaccess.tfi_Banco.GetList();
			return dataSet.Tables[0];
		}

		
		/// <summary>
		/// Obtiene tabla tfi_Banco filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_BancoDataset GetList( string IdBanco, string Nombre, string Direccion, string Telefono)
		{
			return mz.erp.dataaccess.tfi_Banco.GetList( IdBanco, Nombre, Direccion, Telefono);
		}

		/// <summary>
		/// Crea un tfi_BancoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_BancoDataset.tfi_BancoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_Banco.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_Banco que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_BancoDataset.tfi_BancoRow GetByPk( string IdBanco )
		{
			tfi_BancoDataset.tfi_BancoRow row = mz.erp.dataaccess.tfi_Banco.GetByPk( IdBanco  );
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
		/// Obtiene un registro de la tabla tfi_Banco que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_BancoDataset.tfi_BancoRow GetByPk( object IdBanco )
		{
			return GetByPk( ( string )IdBanco );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_BancoRow.
		/// </summary>
		public static tfi_BancoDataset.tfi_BancoRow SetRowDefaultValues( tfi_BancoDataset.tfi_BancoRow row )
		{
			row.IdBanco = Util.NewStringId(); 
			row.Nombre = string.Empty;
			row.Direccion = string.Empty;
			row.Telefono = string.Empty;
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
		/// Envia los cambios del tfi_BancoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_BancoDataset.tfi_BancoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_BancoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_BancoDataset.tfi_BancoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_BancoRow a la base de datos.
		/// </summary>
		public static void Update( tfi_BancoDataset.tfi_BancoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Banco.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_BancoDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_BancoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_Banco.Rows.Count > 0, "La tabla dataSet.tfi_BancoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Banco.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_BancoDataset.tfi_BancoDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_BancoDataset.tfi_BancoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_Banco.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_BancoRow.
		/// </summary>
		public static bool RowIsValid( tfi_BancoDataset.tfi_BancoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdBancoIsValid( row.IdBanco, out mensaje) )
			{ 
				row.SetColumnError( "IdBanco" , mensaje);
				isValid=false;
			
			}
						
			if ( !NombreIsValid( row.Nombre, out mensaje) )
			{ 
				row.SetColumnError( "Nombre" , mensaje);
				isValid=false;
			
			}
						
			if ( !DireccionIsValid( row.Direccion, out mensaje) )
			{ 
				row.SetColumnError( "Direccion" , mensaje);
				isValid=false;
			
			}
						
			if ( !TelefonoIsValid( row.Telefono, out mensaje) )
			{ 
				row.SetColumnError( "Telefono" , mensaje);
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
		/// Valida el campo Nombre.
		/// </summary>
		public static bool NombreIsValid( string Nombre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Nombre. Metodo Sobrecargado
		/// </summary>
		public static bool NombreIsValid( string Nombre)
		{
			string mensaje;
			return NombreIsValid( Nombre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Direccion.
		/// </summary>
		public static bool DireccionIsValid( string Direccion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Direccion. Metodo Sobrecargado
		/// </summary>
		public static bool DireccionIsValid( string Direccion)
		{
			string mensaje;
			return DireccionIsValid( Direccion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Telefono.
		/// </summary>
		public static bool TelefonoIsValid( string Telefono , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Telefono. Metodo Sobrecargado
		/// </summary>
		public static bool TelefonoIsValid( string Telefono)
		{
			string mensaje;
			return TelefonoIsValid( Telefono, out mensaje );
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

