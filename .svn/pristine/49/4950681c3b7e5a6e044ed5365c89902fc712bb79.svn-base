namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_NetosImpuestos : IDisposable
	{
	
		#region Custom Members

		public static tpu_NetosImpuestosDataset GetListEx( long IdNetoImpuestos, long IdNeto, string IdImpuesto, string IdTipoDeComprobante, bool Activo )
		{
			return mz.erp.dataaccess.tpu_NetosImpuestos.GetListEx( IdNetoImpuestos, IdNeto, IdImpuesto, IdTipoDeComprobante, Activo );
		}

		public static DataTable GetListImpuestosAsociados(string IdTipoDeComprobante)
		{
			return mz.erp.dataaccess.tpu_NetosImpuestos.GetListImpuestosAsociados(IdTipoDeComprobante);
		}
		
		public static DataTable GetListNetosAsociados(string IdTipoDeComprobante)
		{
			return mz.erp.dataaccess.tpu_NetosImpuestos.GetListNetosAsociados(IdTipoDeComprobante);
		}
		public static string GetFamilia( long IdNeto, string IdImpuesto, string IdTipoDeComprobante )
		{
			tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row = mz.erp.dataaccess.tpu_NetosImpuestos.GetByPk(IdNeto, IdImpuesto, IdTipoDeComprobante);
			if (row != null)
				return row.Familia;
			return "";
		}
		

		#endregion
		
		public tpu_NetosImpuestos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_NetosImpuestos
		/// </summary>
		public static tpu_NetosImpuestosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_NetosImpuestos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_NetosImpuestos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_NetosImpuestosDataset GetList( long IdNetoImpuestos, long IdNeto, string IdImpuesto, string IdTipoDeComprobante, bool Activo )
		{
			return mz.erp.dataaccess.tpu_NetosImpuestos.GetList( IdNetoImpuestos, IdNeto, IdImpuesto, IdTipoDeComprobante, Activo );
		}

		/// <summary>
		/// Crea un tpu_NetosImpuestosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_NetosImpuestos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_NetosImpuestos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow GetByPk( long IdNetoImpuestos )
		{
			tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row = mz.erp.dataaccess.tpu_NetosImpuestos.GetByPk( IdNetoImpuestos  );
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
		/// Obtiene un registro de la tabla tpu_NetosImpuestos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow GetByPk( object IdNetoImpuestos )
		{
			return GetByPk( ( long )IdNetoImpuestos );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_NetosImpuestosRow.
		/// </summary>
		public static tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow SetRowDefaultValues( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row )
		{
			row.IdNetoImpuestos = 0; 
			row.IdNeto = 0;
			row.IdImpuesto = string.Empty;
			row.IdTipoDeComprobante = string.Empty;
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
		/// Envia los cambios del tpu_NetosImpuestosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_NetosImpuestosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_NetosImpuestosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_NetosImpuestos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_NetosImpuestosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_NetosImpuestosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_NetosImpuestos.Rows.Count > 0, "La tabla dataSet.tpu_NetosImpuestosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_NetosImpuestos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_NetosImpuestosDataset.tpu_NetosImpuestosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_NetosImpuestosDataset.tpu_NetosImpuestosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_NetosImpuestos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_NetosImpuestosRow.
		/// </summary>
		public static bool RowIsValid( tpu_NetosImpuestosDataset.tpu_NetosImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdNetoImpuestosIsValid( row.IdNetoImpuestos, out mensaje) )
			{ 
				row.SetColumnError( "IdNetoImpuestos" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNetoIsValid( row.IdNeto, out mensaje) )
			{ 
				row.SetColumnError( "IdNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdImpuestoIsValid( row.IdImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "IdImpuesto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
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
			
			}*/
						
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
		/// Valida el campo IdNetoImpuestos.
		/// </summary>
		public static bool IdNetoImpuestosIsValid( long IdNetoImpuestos , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNetoImpuestos. Metodo Sobrecargado
		/// </summary>
		public static bool IdNetoImpuestosIsValid( long IdNetoImpuestos)
		{
			string mensaje;
			return IdNetoImpuestosIsValid( IdNetoImpuestos, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNeto.
		/// </summary>
		public static bool IdNetoIsValid( long IdNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNeto. Metodo Sobrecargado
		/// </summary>
		public static bool IdNetoIsValid( long IdNeto)
		{
			string mensaje;
			return IdNetoIsValid( IdNeto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdImpuesto.
		/// </summary>
		public static bool IdImpuestoIsValid( string IdImpuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdImpuesto. Metodo Sobrecargado
		/// </summary>
		public static bool IdImpuestoIsValid( string IdImpuesto)
		{
			string mensaje;
			return IdImpuestoIsValid( IdImpuesto, out mensaje );
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

