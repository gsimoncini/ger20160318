namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using System.Collections;

	public class tfi_FuentesDeCambio : IDisposable
	{
	
		#region Custom Members

		private static Hashtable _fuentesDeCambio = null;

		public static string GetDescripcion(string IdFuenteDeCambio)
		{
			if(_fuentesDeCambio == null)
			{
				_fuentesDeCambio = new Hashtable();
				DataTable t = mz.erp.businessrules.tfi_FuentesDeCambio.GetList().tfi_FuentesDeCambio;
				foreach(DataRow row in t.Rows)
				{
					string IdFDC = Convert.ToString(row["IdFuenteDeCambio"]);
					string Descripcion = Convert.ToString(row["Descripcion"]);
					if(!_fuentesDeCambio.Contains(IdFDC))
						_fuentesDeCambio.Add(IdFDC, Descripcion);
				}
			}
			if(_fuentesDeCambio.Contains(IdFuenteDeCambio)) return Convert.ToString(_fuentesDeCambio[IdFuenteDeCambio]);
			return string.Empty;
		}	
	
		
		#endregion
		
		public tfi_FuentesDeCambio()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_FuentesDeCambio
		/// </summary>
		public static tfi_FuentesDeCambioDataset GetList()
		{
			return mz.erp.dataaccess.tfi_FuentesDeCambio.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_FuentesDeCambio filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_FuentesDeCambioDataset GetList( string Descripcion )
		{
			return mz.erp.dataaccess.tfi_FuentesDeCambio.GetList( Descripcion );
		}

		/// <summary>
		/// Crea un tfi_FuentesDeCambioRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_FuentesDeCambio.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_FuentesDeCambio que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow GetByPk( string IdFuenteDeCamibo )
		{
			tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow row = mz.erp.dataaccess.tfi_FuentesDeCambio.GetByPk( IdFuenteDeCamibo  );
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
		/// Obtiene un registro de la tabla tfi_FuentesDeCambio que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow GetByPk( object IdFuenteDeCamibo )
		{
			return GetByPk( ( string )IdFuenteDeCamibo );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_FuentesDeCambioRow.
		/// </summary>
		public static tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow SetRowDefaultValues( tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow row )
		{
			row.IdFuenteDeCambio = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FuentesDeCambioRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FuentesDeCambioRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FuentesDeCambioRow a la base de datos.
		/// </summary>
		public static void Update( tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_FuentesDeCambio.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_FuentesDeCambioDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_FuentesDeCambioDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_FuentesDeCambio.Rows.Count > 0, "La tabla dataSet.tfi_FuentesDeCambioDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_FuentesDeCambio.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_FuentesDeCambio.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_FuentesDeCambioRow.
		/// </summary>
		public static bool RowIsValid( tfi_FuentesDeCambioDataset.tfi_FuentesDeCambioRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdFuenteDeCamiboIsValid( row.IdFuenteDeCambio, out mensaje) )
			{ 
				row.SetColumnError( "IdFuenteDeCamibo" , mensaje);
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
		/// Valida el campo IdFuenteDeCamibo.
		/// </summary>
		public static bool IdFuenteDeCamiboIsValid( string IdFuenteDeCamibo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCamibo. Metodo Sobrecargado
		/// </summary>
		public static bool IdFuenteDeCamiboIsValid( string IdFuenteDeCamibo)
		{
			string mensaje;
			return IdFuenteDeCamiboIsValid( IdFuenteDeCamibo, out mensaje );
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


