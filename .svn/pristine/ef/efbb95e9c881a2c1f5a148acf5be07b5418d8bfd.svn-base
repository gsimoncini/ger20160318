namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_AuditoriaControlCajasDetalleBilletes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_AuditoriaControlCajasDetalleBilletes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_AuditoriaControlCajasDetalleBilletes
		/// </summary>
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset GetList()
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_AuditoriaControlCajasDetalleBilletes filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset GetList( long IdAuditoria, long Ordinal, long IdTipoBillete, long CantidadInformada, decimal MontoInformado, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId )
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.GetList( IdAuditoria, Ordinal, IdTipoBillete, CantidadInformada, MontoInformado, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, RowId );
		}

		/// <summary>
		/// Crea un tfi_AuditoriaControlCajasDetalleBilletesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_AuditoriaControlCajasDetalleBilletes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow GetByPk( long IdAuditoria, long Ordinal, long IdTipoBillete )
		{
			tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow row = mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.GetByPk( IdAuditoria, Ordinal, IdTipoBillete  );
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
		/// Obtiene un registro de la tabla tfi_AuditoriaControlCajasDetalleBilletes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow GetByPk( object IdAuditoria, object Ordinal, object IdTipoBillete )
		{
			return GetByPk( ( long )IdAuditoria, ( long )Ordinal, ( long )IdTipoBillete );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_AuditoriaControlCajasDetalleBilletesRow.
		/// </summary>
		public static tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow SetRowDefaultValues( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow row )
		{
			row.IdAuditoria = 0; 
			row.Ordinal = 0; 
			row.IdTipoBillete = 0; 
			row.CantidadInformada = 0;
			row.MontoInformado = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetalleBilletesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetalleBilletesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetalleBilletesRow a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetalleBilletesDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDetalleBilletesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_AuditoriaControlCajasDetalleBilletes.Rows.Count > 0, "La tabla dataSet.tfi_AuditoriaControlCajasDetalleBilletesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajasDetalleBilletes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_AuditoriaControlCajasDetalleBilletesRow.
		/// </summary>
		public static bool RowIsValid( tfi_AuditoriaControlCajasDetalleBilletesDataset.tfi_AuditoriaControlCajasDetalleBilletesRow row )
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
						
			if ( !IdTipoBilleteIsValid( row.IdTipoBillete, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoBillete" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadInformadaIsValid( row.CantidadInformada, out mensaje) )
			{ 
				row.SetColumnError( "CantidadInformada" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoInformadoIsValid( row.MontoInformado, out mensaje) )
			{ 
				row.SetColumnError( "MontoInformado" , mensaje);
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
		/// Valida el campo IdTipoBillete.
		/// </summary>
		public static bool IdTipoBilleteIsValid( long IdTipoBillete , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoBillete. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoBilleteIsValid( long IdTipoBillete)
		{
			string mensaje;
			return IdTipoBilleteIsValid( IdTipoBillete, out mensaje );
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

