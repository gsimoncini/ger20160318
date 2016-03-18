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

	public class tsy_TiposDeComprobantesCategoriaIva : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_TiposDeComprobantesCategoriaIva()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_TiposDeComprobantesCategoriaIva
		/// </summary>
		public static tsy_TiposDeComprobantesCategoriaIvaDataset GetList()
		{
			return mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.GetList();
		}
		
		public static ArrayList GetTiposDeComprobantesCategoria(string categoria)
		{
			ArrayList result = new ArrayList();
			DataTable table = erp.businessrules.tsy_TiposDeComprobantesCategoriaIva.GetList(null,categoria,true).Tables[0];
				
			foreach(DataRow row in table.Rows)
			{		
				string IdTipoDeComprobante = Convert.ToString(row["IdTipoDeComprobante"]);				
				result.Add(IdTipoDeComprobante);
				
			}
			result.Sort();
			return result;
		}

		
		/// <summary>
		/// Obtiene tabla tsy_TiposDeComprobantesCategoriaIva filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_TiposDeComprobantesCategoriaIvaDataset GetList( string IdTipoDeComprobante, string IdCategoriaIva, bool Activo )
		{
			return mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.GetList( IdTipoDeComprobante, IdCategoriaIva, Activo );
		}

		/// <summary>
		/// Crea un tsy_TiposDeComprobantesCategoriaIvaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_TiposDeComprobantesCategoriaIva que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow GetByPk( string IdTipoDeComprobante, string IdCategoriaIva )
		{
			tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow row = mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.GetByPk( IdTipoDeComprobante, IdCategoriaIva  );
			if (row!=null){
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
		/// Obtiene un registro de la tabla tsy_TiposDeComprobantesCategoriaIva que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow GetByPk( object IdTipoDeComprobante, object IdCategoriaIva )
		{
			return GetByPk( ( string )IdTipoDeComprobante, ( string )IdCategoriaIva );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_TiposDeComprobantesCategoriaIvaRow.
		/// </summary>
		public static tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow SetRowDefaultValues( tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow row )
		{
			row.IdTipoDeComprobante = Util.NewStringId(); 
			row.IdCategoriaIva = Util.NewStringId(); 
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesCategoriaIvaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesCategoriaIvaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesCategoriaIvaRow a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesCategoriaIvaDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeComprobantesCategoriaIvaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_TiposDeComprobantesCategoriaIva.Rows.Count > 0, "La tabla dataSet.tsy_TiposDeComprobantesCategoriaIvaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_TiposDeComprobantesCategoriaIva.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_TiposDeComprobantesCategoriaIvaRow.
		/// </summary>
		public static bool RowIsValid( tsy_TiposDeComprobantesCategoriaIvaDataset.tsy_TiposDeComprobantesCategoriaIvaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCategoriaIvaIsValid( row.IdCategoriaIva, out mensaje) )
			{ 
				row.SetColumnError( "IdCategoriaIva" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
			/*			
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
			*/
						
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
		/// Valida el campo IdTipoDeComprobante.
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoDeComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoDeComprobanteIsValid( string IdTipoDeComprobante)
		{
			string mensaje;
			return IdTipoDeComprobanteIsValid( IdTipoDeComprobante, out mensaje );
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
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
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

