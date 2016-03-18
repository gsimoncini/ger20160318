namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_ComprobanteDetalleDeuda : IDisposable
	{
	
		#region Custom Members
		
		public static System.Data.DataRow NewRow(tsa_ComprobantesExDataset data)
		{
		
			System.Data.DataRow row =  mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.NewRow( data);
			SetRowDefaultValues(row);
			return row;
		}
		
		public static System.Data.DataRow NewRow(tsa_ComprobantesExDataset data,string IdComprobante)
		{
		
			System.Data.DataRow row =  NewRow(data);
			row["IdComprobante"]= IdComprobante;
			return row;
		}
		

		/// <summary>
		/// Obtiene tabla tsa_ComprobanteDetalleDeuda filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsa_ComprobanteDetalleDeudaDataset GetList( string IdComprobante, string IdTipoDeComprobante, string Numero )
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetList( IdComprobante, IdTipoDeComprobante, Numero );
		}		
		

		
		
		#endregion
		
		public tsa_ComprobanteDetalleDeuda()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_ComprobanteDetalleDeuda
		/// </summary>
		public static tsa_ComprobanteDetalleDeudaDataset GetList()
		{
			return mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetList();
		}
		


		/// <summary>
		/// Crea un tsa_ComprobanteDetalleDeudaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow NewRow()
		{
			return (tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow )SetRowDefaultValues(mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleDeuda que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow GetByPk( string IdComprobante, short Cuota )
		{
			tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row = mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.GetByPk( IdComprobante, Cuota  );						
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
		/// Obtiene un registro de la tabla tsa_ComprobanteDetalleDeuda que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow GetByPk( object IdComprobante, object Cuota )
		{
			return GetByPk( ( string )IdComprobante, ( short )Cuota );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_ComprobanteDetalleDeudaRow.
		/// </summary>
		public static System.Data.DataRow SetRowDefaultValues( System.Data.DataRow row )
		{
			row["IdComprobante"] = Util.NewStringId(); 
			row["Cuota"] = 1; 
			row["IdTipoDeComprobante"] = string.Empty;
			row["Numero"] = string.Empty;
			row["FechaEmision"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["FechaVencimiento"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["Importe"]= 0;
			row["Saldo"] = 0;
			row["IdMonedaCierre"] = string.Empty;
			row["IdCotizacionCierre"] = string.Empty;
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			//row.UltimaModificacion = null;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["IdReservado"] = 0;
			row["RowId"] = Guid.Empty;
			row["IdSucursal"] = Security.IdSucursal;
			row["IdEmpresa"] = Security.IdEmpresa;
			row["RowIdGenerado"] = System.DBNull.Value;
			row["IdFormaDePago"] = string.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDeudaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDeudaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDeudaRow a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDeudaDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDeudaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_ComprobanteDetalleDeuda.Rows.Count > 0, "La tabla dataSet.tsa_ComprobanteDetalleDeudaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_ComprobanteDetalleDeuda.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_ComprobanteDetalleDeudaRow.
		/// </summary>
		public static bool RowIsValid( tsa_ComprobanteDetalleDeudaDataset.tsa_ComprobanteDetalleDeudaRow row )
		{
			
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoDeComprobanteIsValid( row.IdTipoDeComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoDeComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !NumeroIsValid( row.Numero, out mensaje) )
			{ 
				row.SetColumnError( "Numero" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaEmisionIsValid( row.FechaEmision, out mensaje) )
			{ 
				row.SetColumnError( "FechaEmision" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaVencimientoIsValid( row.FechaVencimiento, out mensaje) )
			{ 
				row.SetColumnError( "FechaVencimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !CuotaIsValid( row.Cuota, out mensaje) )
			{ 
				row.SetColumnError( "Cuota" , mensaje);
				isValid=false;
			
			}
						
			if ( !ImporteIsValid( row.Importe, out mensaje) )
			{ 
				row.SetColumnError( "Importe" , mensaje);
				isValid=false;
			
			}
						
			if ( !SaldoIsValid( row.Saldo, out mensaje) )
			{ 
				row.SetColumnError( "Saldo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaCierreIsValid( row.IdMonedaCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizacionCierreIsValid( row.IdCotizacionCierre, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionCierre" , mensaje);
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
						
			if ( !IdSucursalIsValid( row.IdSucursal, out mensaje) )
			{ 
				row.SetColumnError( "IdSucursal" , mensaje);
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
		/// Valida el campo Numero.
		/// </summary>
		public static bool NumeroIsValid( string Numero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Numero. Metodo Sobrecargado
		/// </summary>
		public static bool NumeroIsValid( string Numero)
		{
			string mensaje;
			return NumeroIsValid( Numero, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaEmision.
		/// </summary>
		public static bool FechaEmisionIsValid( DateTime FechaEmision , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaEmision. Metodo Sobrecargado
		/// </summary>
		public static bool FechaEmisionIsValid( DateTime FechaEmision)
		{
			string mensaje;
			return FechaEmisionIsValid( FechaEmision, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento. Metodo Sobrecargado
		/// </summary>
		public static bool FechaVencimientoIsValid( DateTime FechaVencimiento)
		{
			string mensaje;
			return FechaVencimientoIsValid( FechaVencimiento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cuota.
		/// </summary>
		public static bool CuotaIsValid( short Cuota , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cuota. Metodo Sobrecargado
		/// </summary>
		public static bool CuotaIsValid( short Cuota)
		{
			string mensaje;
			return CuotaIsValid( Cuota, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Importe.
		/// </summary>
		public static bool ImporteIsValid( decimal Importe , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Importe. Metodo Sobrecargado
		/// </summary>
		public static bool ImporteIsValid( decimal Importe)
		{
			string mensaje;
			return ImporteIsValid( Importe, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Saldo.
		/// </summary>
		public static bool SaldoIsValid( decimal Saldo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Saldo. Metodo Sobrecargado
		/// </summary>
		public static bool SaldoIsValid( decimal Saldo)
		{
			string mensaje;
			return SaldoIsValid( Saldo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaCierre.
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaCierreIsValid( string IdMonedaCierre)
		{
			string mensaje;
			return IdMonedaCierreIsValid( IdMonedaCierre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre.
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionCierre. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionCierreIsValid( string IdCotizacionCierre)
		{
			string mensaje;
			return IdCotizacionCierreIsValid( IdCotizacionCierre, out mensaje );
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

