namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobanteDetalleDescripcionAdicional : IDisposable
	{
	
		#region Custom Members
		public static string GetDescripcionAdicional(string IdComprobante, long Ordinal)
		{
			string descripcion = string.Empty;
			System.Data.DataRow row = mz.erp.businessrules.tsa_ComprobanteDetalleDescripcionAdicional.GetByPk( IdComprobante, Ordinal);
			if (row != null)
			{
				descripcion = (string)row["Descripcion"];
			}
			return descripcion;
		}
		#endregion
		
		public tsa_ComprobanteDetalleDescripcionAdicional()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobanteDetalleDescripcionAdicional
		/// </summary>
		public static tsa_ComprobanteDetalleDescripcionAdicionalDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsa_ComprobanteDetalleDescripcionAdicional filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobanteDetalleDescripcionAdicionalDataset GetList( string IdComprobante, long Ordinal, string Descripcion )
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.GetList( IdComprobante, Ordinal, Descripcion );
		}

		/// <summary>
		/// Crea un tsa_ComprobanteDetalleDescripcionAdicionalRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleDescripcionAdicional que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow GetByPk( string IdComprobante, long Ordinal )
		{
			tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row = mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.GetByPk( IdComprobante, Ordinal  );
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
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleDescripcionAdicional que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow GetByPk( object IdComprobante, object Ordinal )
		{
			return GetByPk( ( string )IdComprobante, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobanteDetalleDescripcionAdicionalRow.
		/// </summary>
		public static tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow SetRowDefaultValues( tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.Ordinal = 0; 
			row.Descripcion = string.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.SetRowIdGeneradoNull();

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDescripcionAdicionalRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDescripcionAdicionalRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDescripcionAdicionalRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDescripcionAdicionalDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDescripcionAdicionalDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobanteDetalleDescripcionAdicional.Rows.Count > 0, "La tabla dataSet.tsa_ComprobanteDetalleDescripcionAdicionalDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDescripcionAdicional.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobanteDetalleDescripcionAdicionalRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobanteDetalleDescripcionAdicionalDataset.tsa_ComprobanteDetalleDescripcionAdicionalRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
		/// Valida el campo IdComprobante.
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteIsValid( string IdComprobante)
		{
			string mensaje;
			return IdComprobanteIsValid( IdComprobante, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
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

