namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using System.Drawing;

	public class tsh_ProductosAuxiliares : IDisposable
	{
	
		#region Custom Members
		public static Image GetThumb(string IdProducto)
		{
			tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowPA = businessrules.tsh_ProductosAuxiliares.GetByPk(IdProducto);
			if (rowPA != null)
				return systemframework.Util.BytesToImage(rowPA.Thumb);
			else
			{				
				return null;
			}				
		}				
		
		#endregion
		
		public tsh_ProductosAuxiliares()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosAuxiliares
		/// </summary>
		public static tsh_ProductosAuxiliaresDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosAuxiliares.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_ProductosAuxiliares filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsh_ProductosAuxiliaresDataset GetList(  )
		{
			return mz.erp.dataaccess.tsh_ProductosAuxiliares.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsh_ProductosAuxiliaresRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosAuxiliares.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosAuxiliares que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow GetByPk( string IdProducto )
		{
			tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row = mz.erp.dataaccess.tsh_ProductosAuxiliares.GetByPk( IdProducto  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
				return row;		
			}
			else
			{
				return null;
			}			
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosAuxiliares que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow GetByPk( object IdProducto )
		{
			return GetByPk( ( string )IdProducto );
		}

		public static tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow SetRowDefaultValues( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row )
		{
			
			return (tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow)SetRowDefaultValues((System.Data.DataRow)row );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosAuxiliaresRow.
		/// </summary>
		public static System.Data.DataRow SetRowDefaultValues( System.Data.DataRow row )
		{
			row["IdProducto"] = Util.NewStringId(); 
			row["Contador"] = 0;
			row["Activo"] = false;
			row["FechaCreacion"] = DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row["UltimaModificacion"] = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["IdReservado"] = 0;
			row["RowId"] = Guid.Empty;
			row["IdEmpresa"] = 0;
			row["IdSucursal"] = 0;
			row["TieneCodigoSecundarioSegmentado"] = false;
			row["IdComprobanteProximaRecepcionMercaderia"] = string.Empty;
			row["IdProveedor"] = string.Empty;
			row["Cantidad"] = 0;
			row["FechaRecepcion"] = DateTime.Now;

			/*row["Thumb"] = null;
			row["Imagen"] = null;
			row["Thumb2"] = null;
			row["Imagen2"] = null;
			row["Thumb3"] = null;
			row["Imagen3"] = null;
			row["Thumb4"] = null;
			row["Imagen4"] = null;
			row["Thumb5"] = null;
			row["Imagen5"] = null;*/
			row["Coeficiente1"] = 0;
			row["Coeficiente2"] = 0;
			row["Coeficiente3"] = 0;
			row["Coeficiente4"] = 0;
			row["Coeficiente5"] = 0;
			row["Coeficiente6"] = 0;
			row["Coeficiente7"] = 0;
			row["Coeficiente8"] = 0;
			row["Coeficiente9"] = 0;
			row["Coeficiente10"] = 0;
			row["Link1"] = string.Empty;
			row["Link2"] = string.Empty;
			row["Link3"] = string.Empty;
			row["Link4"] = string.Empty;
			row["Link5"] = string.Empty;
			row["CodigoSecundario1"] = string.Empty;
			row["CodigoSecundario2"] = string.Empty;
			row["CodigoSecundario3"] = string.Empty;
			row["CodigoSecundario4"] = string.Empty;
			row["CodigoSecundario5"] = string.Empty;
			row["CodigoSecundario6"] = string.Empty;
			row["CodigoSecundario7"] = string.Empty;
			row["CodigoSecundario8"] = string.Empty;
			row["CodigoSecundario9"] = string.Empty;
			row["CodigoSecundario10"] = string.Empty;
			row["CodigoSecundario11"] = string.Empty;
			row["CodigoSecundario12"] = string.Empty;
			row["CodigoSecundario13"] = string.Empty;
			row["CodigoSecundario14"] = string.Empty;
			row["CodigoSecundario15"] = string.Empty;
			row["CodigoSecundario16"] = string.Empty;
			row["CodigoSecundario17"] = string.Empty;
			row["CodigoSecundario18"] = string.Empty;
			row["CodigoSecundario19"] = string.Empty;
			row["CodigoSecundario20"] = string.Empty;
			//row.TieneCodigoSecundarioSegmentado
            /* Silvina 20110630 - Tarea 0000136 */
            row["PermiteCambio"] = true;
            /* Fin Silvina 20110630 - Tarea 0000136 */
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosAuxiliaresRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosAuxiliaresRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosAuxiliaresRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosAuxiliares.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosAuxiliaresDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosAuxiliaresDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosAuxiliares.Rows.Count > 0, "La tabla dataSet.tsh_ProductosAuxiliaresDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosAuxiliares.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosAuxiliares.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosAuxiliaresRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !ContadorIsValid( row.Contador, out mensaje) )
			{ 
				row.SetColumnError( "Contador" , mensaje);
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
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Contador.
		/// </summary>
		public static bool ContadorIsValid( long Contador , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Contador. Metodo Sobrecargado
		/// </summary>
		public static bool ContadorIsValid( long Contador)
		{
			string mensaje;
			return ContadorIsValid( Contador, out mensaje );
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

