namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_CategoriasIva : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_CategoriasIva()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_CategoriasIva
		/// </summary>
		public static tsy_CategoriasIvaDataset GetList()
		{
			return mz.erp.dataaccess.tsy_CategoriasIva.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_CategoriasIva filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_CategoriasIvaDataset GetList( string IdCategoriaIva, string Descripcion )
		{
			return mz.erp.dataaccess.tsy_CategoriasIva.GetList( IdCategoriaIva, Descripcion );
		}

		/// <summary>
		/// Crea un tsy_CategoriasIvaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_CategoriasIva.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_CategoriasIva que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow GetByPk( string IdCategoriaIva )
		{
			tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow row = mz.erp.dataaccess.tsy_CategoriasIva.GetByPk( IdCategoriaIva  );
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
		/// Obtiene un registro de la tabla tsy_CategoriasIva que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow GetByPk( object IdCategoriaIva )
		{
			return GetByPk( ( string )IdCategoriaIva );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_CategoriasIvaRow.
		/// </summary>
		public static tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow SetRowDefaultValues( tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow row )
		{
			row.IdCategoriaIva = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.ActivoVentas = false;
			row.ActivoCompras = false;
			row.Clase = string.Empty;
			row.PuertoImpresora = string.Empty;
			row.Copias = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_CategoriasIvaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_CategoriasIvaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_CategoriasIvaRow a la base de datos.
		/// </summary>
		public static void Update( tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_CategoriasIva.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_CategoriasIvaDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_CategoriasIvaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_CategoriasIva.Rows.Count > 0, "La tabla dataSet.tsy_CategoriasIvaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_CategoriasIva.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_CategoriasIvaDataset.tsy_CategoriasIvaDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_CategoriasIvaDataset.tsy_CategoriasIvaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_CategoriasIva.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_CategoriasIvaRow.
		/// </summary>
		public static bool RowIsValid( tsy_CategoriasIvaDataset.tsy_CategoriasIvaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCategoriaIvaIsValid( row.IdCategoriaIva, out mensaje) )
			{ 
				row.SetColumnError( "IdCategoriaIva" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoVentasIsValid( row.ActivoVentas, out mensaje) )
			{ 
				row.SetColumnError( "ActivoVentas" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoComprasIsValid( row.ActivoCompras, out mensaje) )
			{ 
				row.SetColumnError( "ActivoCompras" , mensaje);
				isValid=false;
			
			}
						
			if ( !ClaseIsValid( row.Clase, out mensaje) )
			{ 
				row.SetColumnError( "Clase" , mensaje);
				isValid=false;
			
			}
						
			if ( !PuertoImpresoraIsValid( row.PuertoImpresora, out mensaje) )
			{ 
				row.SetColumnError( "PuertoImpresora" , mensaje);
				isValid=false;
			
			}
						
			if ( !CopiasIsValid( row.Copias, out mensaje) )
			{ 
				row.SetColumnError( "Copias" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCategoriaIva.
		/// </summary>
		public static bool IdCategoriaIvaIsValid( string IdCategoriaIva , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCategoriaIva. Metodo Sobrecargado
		/// </summary>
		public static bool IdCategoriaIvaIsValid( string IdCategoriaIva)
		{
			string mensaje;
			return IdCategoriaIvaIsValid( IdCategoriaIva, out mensaje );
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
		/// Valida el campo ActivoVentas.
		/// </summary>
		public static bool ActivoVentasIsValid( bool ActivoVentas , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ActivoVentas. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoVentasIsValid( bool ActivoVentas)
		{
			string mensaje;
			return ActivoVentasIsValid( ActivoVentas, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ActivoCompras.
		/// </summary>
		public static bool ActivoComprasIsValid( bool ActivoCompras , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ActivoCompras. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoComprasIsValid( bool ActivoCompras)
		{
			string mensaje;
			return ActivoComprasIsValid( ActivoCompras, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Clase.
		/// </summary>
		public static bool ClaseIsValid( string Clase , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Clase. Metodo Sobrecargado
		/// </summary>
		public static bool ClaseIsValid( string Clase)
		{
			string mensaje;
			return ClaseIsValid( Clase, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PuertoImpresora.
		/// </summary>
		public static bool PuertoImpresoraIsValid( string PuertoImpresora , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PuertoImpresora. Metodo Sobrecargado
		/// </summary>
		public static bool PuertoImpresoraIsValid( string PuertoImpresora)
		{
			string mensaje;
			return PuertoImpresoraIsValid( PuertoImpresora, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Copias.
		/// </summary>
		public static bool CopiasIsValid( string Copias , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Copias. Metodo Sobrecargado
		/// </summary>
		public static bool CopiasIsValid( string Copias)
		{
			string mensaje;
			return CopiasIsValid( Copias, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

