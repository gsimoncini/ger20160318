namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_AuditoriaControlCajasDet : IDisposable
	{
	
		#region Custom Members
		public static tfi_AuditoriaControlCajasDetDataset GetByIdAuditoria( long IdAuditoria)
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.GetByIdAuditoria( IdAuditoria );
		}

		#endregion
		
		public tfi_AuditoriaControlCajasDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_AuditoriaControlCajasDet
		/// </summary>
		public static tfi_AuditoriaControlCajasDetDataset GetList()
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_AuditoriaControlCajasDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_AuditoriaControlCajasDetDataset GetList( long IdAuditoria, long Ordinal, string IdControlDeCajasFamiliasComprobanteTesoreria, string IdMoneda, long CantidadInformada, long CantidadSistema, decimal MontoInformado, decimal MontoSistema, long DiferenciaCantidad, decimal DiferenciaMonto, bool CodigoCalidadCantidad, bool CodigoCalidadMonto, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.GetList( IdAuditoria, Ordinal, IdControlDeCajasFamiliasComprobanteTesoreria, IdMoneda, CantidadInformada, CantidadSistema, MontoInformado, MontoSistema, DiferenciaCantidad, DiferenciaMonto, CodigoCalidadCantidad, CodigoCalidadMonto, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}

		/// <summary>
		/// Crea un tfi_AuditoriaControlCajasDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_AuditoriaControlCajasDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow GetByPk( long IdAuditoria, long Ordinal )
		{
			tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow row = mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.GetByPk( IdAuditoria, Ordinal  );
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
		/// Obtiene un registro de la tabla tfi_AuditoriaControlCajasDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow GetByPk( object IdAuditoria, object Ordinal )
		{
			return GetByPk( ( long )IdAuditoria, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_AuditoriaControlCajasDetRow.
		/// </summary>
		public static tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow SetRowDefaultValues( tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow row )
		{
			row.IdAuditoria = 0; 
			row.Ordinal = 0; 
			row.IdControlDeCajasFamiliasComprobanteTesoreria = string.Empty;
			row.IdMoneda = string.Empty;
			row.CantidadInformada = 0;
			row.CantidadSistema = 0;
			row.MontoInformado = 0;
			row.MontoSistema = 0;
			row.DiferenciaCantidad = 0;
			row.DiferenciaMonto = 0;
			row.CodigoCalidadCantidad = false;
			row.CodigoCalidadMonto = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetRow a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_AuditoriaControlCajasDet.Rows.Count > 0, "La tabla dataSet.tfi_AuditoriaControlCajasDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajasDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_AuditoriaControlCajasDetRow.
		/// </summary>
		public static bool RowIsValid( tfi_AuditoriaControlCajasDetDataset.tfi_AuditoriaControlCajasDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdAuditoriaIsValid( row.IdAuditoria, out mensaje) )
			{ 
				row.SetColumnError( "IdAuditoria" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( row.IdControlDeCajasFamiliasComprobanteTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdControlDeCajasFamiliasComprobanteTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadInformadaIsValid( row.CantidadInformada, out mensaje) )
			{ 
				row.SetColumnError( "CantidadInformada" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadSistemaIsValid( row.CantidadSistema, out mensaje) )
			{ 
				row.SetColumnError( "CantidadSistema" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoInformadoIsValid( row.MontoInformado, out mensaje) )
			{ 
				row.SetColumnError( "MontoInformado" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoSistemaIsValid( row.MontoSistema, out mensaje) )
			{ 
				row.SetColumnError( "MontoSistema" , mensaje);
				isValid=false;
			
			}
						
			if ( !DiferenciaCantidadIsValid( row.DiferenciaCantidad, out mensaje) )
			{ 
				row.SetColumnError( "DiferenciaCantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !DiferenciaMontoIsValid( row.DiferenciaMonto, out mensaje) )
			{ 
				row.SetColumnError( "DiferenciaMonto" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoCalidadCantidadIsValid( row.CodigoCalidadCantidad, out mensaje) )
			{ 
				row.SetColumnError( "CodigoCalidadCantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoCalidadMontoIsValid( row.CodigoCalidadMonto, out mensaje) )
			{ 
				row.SetColumnError( "CodigoCalidadMonto" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdAuditoria.
		/// </summary>
		public static bool IdAuditoriaIsValid( long IdAuditoria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdAuditoria. Metodo Sobrecargado
		/// </summary>
		public static bool IdAuditoriaIsValid( long IdAuditoria)
		{
			string mensaje;
			return IdAuditoriaIsValid( IdAuditoria, out mensaje );
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
		/// Valida el campo IdControlDeCajasFamiliasComprobanteTesoreria.
		/// </summary>
		public static bool IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( string IdControlDeCajasFamiliasComprobanteTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdControlDeCajasFamiliasComprobanteTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( string IdControlDeCajasFamiliasComprobanteTesoreria)
		{
			string mensaje;
			return IdControlDeCajasFamiliasComprobanteTesoreriaIsValid( IdControlDeCajasFamiliasComprobanteTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMoneda.
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMoneda. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaIsValid( string IdMoneda)
		{
			string mensaje;
			return IdMonedaIsValid( IdMoneda, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CantidadInformada.
		/// </summary>
		public static bool CantidadInformadaIsValid( long CantidadInformada , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CantidadInformada. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadInformadaIsValid( long CantidadInformada)
		{
			string mensaje;
			return CantidadInformadaIsValid( CantidadInformada, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CantidadSistema.
		/// </summary>
		public static bool CantidadSistemaIsValid( long CantidadSistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CantidadSistema. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadSistemaIsValid( long CantidadSistema)
		{
			string mensaje;
			return CantidadSistemaIsValid( CantidadSistema, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MontoInformado.
		/// </summary>
		public static bool MontoInformadoIsValid( decimal MontoInformado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontoInformado. Metodo Sobrecargado
		/// </summary>
		public static bool MontoInformadoIsValid( decimal MontoInformado)
		{
			string mensaje;
			return MontoInformadoIsValid( MontoInformado, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MontoSistema.
		/// </summary>
		public static bool MontoSistemaIsValid( decimal MontoSistema , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontoSistema. Metodo Sobrecargado
		/// </summary>
		public static bool MontoSistemaIsValid( decimal MontoSistema)
		{
			string mensaje;
			return MontoSistemaIsValid( MontoSistema, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DiferenciaCantidad.
		/// </summary>
		public static bool DiferenciaCantidadIsValid( long DiferenciaCantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DiferenciaCantidad. Metodo Sobrecargado
		/// </summary>
		public static bool DiferenciaCantidadIsValid( long DiferenciaCantidad)
		{
			string mensaje;
			return DiferenciaCantidadIsValid( DiferenciaCantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DiferenciaMonto.
		/// </summary>
		public static bool DiferenciaMontoIsValid( decimal DiferenciaMonto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DiferenciaMonto. Metodo Sobrecargado
		/// </summary>
		public static bool DiferenciaMontoIsValid( decimal DiferenciaMonto)
		{
			string mensaje;
			return DiferenciaMontoIsValid( DiferenciaMonto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CodigoCalidadCantidad.
		/// </summary>
		public static bool CodigoCalidadCantidadIsValid( bool CodigoCalidadCantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoCalidadCantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoCalidadCantidadIsValid( bool CodigoCalidadCantidad)
		{
			string mensaje;
			return CodigoCalidadCantidadIsValid( CodigoCalidadCantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CodigoCalidadMonto.
		/// </summary>
		public static bool CodigoCalidadMontoIsValid( bool CodigoCalidadMonto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoCalidadMonto. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoCalidadMontoIsValid( bool CodigoCalidadMonto)
		{
			string mensaje;
			return CodigoCalidadMontoIsValid( CodigoCalidadMonto, out mensaje );
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

