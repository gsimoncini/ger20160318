namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ComprobantesImpuestos : IDisposable
	{
	
		#region Custom Members
		public static void Update( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosDataTable dataTable, string IdTransaction )
		{						
			mz.erp.dataaccess.tpu_ComprobantesImpuestos.Update(dataTable, IdTransaction);
		}
		public static tpu_ComprobantesImpuestosDataset GetList( string IdComprobante)
		{
			return mz.erp.dataaccess.tpu_ComprobantesImpuestos.GetList( IdComprobante, long.MinValue, null, decimal.MinValue, decimal.MinValue, decimal.MinValue);
		}
		public static DataSet GetListEx( string IdComprobante)
		{
			return mz.erp.dataaccess.tpu_ComprobantesImpuestos.GetListEx( IdComprobante, long.MinValue, null, decimal.MinValue, decimal.MinValue, decimal.MinValue);
		}
		#endregion
		
		public tpu_ComprobantesImpuestos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ComprobantesImpuestos
		/// </summary>
		public static tpu_ComprobantesImpuestosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ComprobantesImpuestos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ComprobantesImpuestos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ComprobantesImpuestosDataset GetList( string IdComprobante, long IdNeto, string IdImpuesto, decimal ValorNeto, decimal ValorImpuesto, decimal PorcentajeAplicado )
		{
			return mz.erp.dataaccess.tpu_ComprobantesImpuestos.GetList( IdComprobante, IdNeto, IdImpuesto, ValorNeto, ValorImpuesto, PorcentajeAplicado );
		}

		/// <summary>
		/// Crea un tpu_ComprobantesImpuestosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ComprobantesImpuestos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ComprobantesImpuestos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow GetByPk( string IdComprobante, long IdNeto, string IdImpuesto )
		{
			tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row = mz.erp.dataaccess.tpu_ComprobantesImpuestos.GetByPk( IdComprobante, IdNeto, IdImpuesto  );
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
		/// Obtiene un registro de la tabla tpu_ComprobantesImpuestos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow GetByPk( object IdComprobante, object IdNeto, object IdImpuesto )
		{
			return GetByPk( ( string )IdComprobante, ( long )IdNeto, ( string )IdImpuesto );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ComprobantesImpuestosRow.
		/// </summary>
		public static tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow SetRowDefaultValues( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.IdNeto = 0; 
			row.IdImpuesto = Util.NewStringId(); 
			row.ValorNeto = 0;
			row.ValorImpuesto = 0;
			row.PorcentajeAplicado = 0;
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
		/// Envia los cambios del tpu_ComprobantesImpuestosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesImpuestosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesImpuestosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesImpuestos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ComprobantesImpuestosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesImpuestosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ComprobantesImpuestos.Rows.Count > 0, "La tabla dataSet.tpu_ComprobantesImpuestosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesImpuestos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ComprobantesImpuestos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ComprobantesImpuestosRow.
		/// </summary>
		public static bool RowIsValid( tpu_ComprobantesImpuestosDataset.tpu_ComprobantesImpuestosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
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
						
			if ( !ValorNetoIsValid( row.ValorNeto, out mensaje) )
			{ 
				row.SetColumnError( "ValorNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !ValorImpuestoIsValid( row.ValorImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "ValorImpuesto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PorcentajeAplicadoIsValid( row.PorcentajeAplicado, out mensaje) )
			{ 
				row.SetColumnError( "PorcentajeAplicado" , mensaje);
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
		/// Valida el campo ValorNeto.
		/// </summary>
		public static bool ValorNetoIsValid( decimal ValorNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorNeto. Metodo Sobrecargado
		/// </summary>
		public static bool ValorNetoIsValid( decimal ValorNeto)
		{
			string mensaje;
			return ValorNetoIsValid( ValorNeto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ValorImpuesto.
		/// </summary>
		public static bool ValorImpuestoIsValid( decimal ValorImpuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ValorImpuesto. Metodo Sobrecargado
		/// </summary>
		public static bool ValorImpuestoIsValid( decimal ValorImpuesto)
		{
			string mensaje;
			return ValorImpuestoIsValid( ValorImpuesto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PorcentajeAplicado.
		/// </summary>
		public static bool PorcentajeAplicadoIsValid( decimal PorcentajeAplicado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PorcentajeAplicado. Metodo Sobrecargado
		/// </summary>
		public static bool PorcentajeAplicadoIsValid( decimal PorcentajeAplicado)
		{
			string mensaje;
			return PorcentajeAplicadoIsValid( PorcentajeAplicado, out mensaje );
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

