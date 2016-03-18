namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_AuditoriaControlCajas : IDisposable
	{
	
		#region Custom Members
		public static tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow GetUltimoControl( string IdInstanciaCaja )
		{
			tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row = mz.erp.dataaccess.tfi_AuditoriaControlCajas.GetUltimoControl( IdInstanciaCaja  );
			return row;

		}
		#endregion
		
		public tfi_AuditoriaControlCajas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_AuditoriaControlCajas
		/// </summary>
		public static tfi_AuditoriaControlCajasDataset GetList()
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_AuditoriaControlCajas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_AuditoriaControlCajasDataset GetList( long IdAuditoria, DateTime Fecha, DateTime FechaCierre, string Cajero, string IdInstanciaCaja, long Tiempo, bool AuditadoSupervisor, bool AuditadoGerente, bool EsCierre)
		{
			return mz.erp.dataaccess.tfi_AuditoriaControlCajas.GetList( IdAuditoria, Fecha, FechaCierre, Cajero, IdInstanciaCaja, Tiempo, AuditadoSupervisor, AuditadoGerente, EsCierre);
		}

		/// <summary>
		/// Crea un tfi_AuditoriaControlCajasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_AuditoriaControlCajas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_AuditoriaControlCajas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow GetByPk( long IdAuditoria )
		{
			tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row = mz.erp.dataaccess.tfi_AuditoriaControlCajas.GetByPk( IdAuditoria  );
			if(row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId")
                            row[dc] = Util.DefaultValue( dc.DataType );
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_AuditoriaControlCajas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow GetByPk( object IdAuditoria )
		{
			return GetByPk( ( long )IdAuditoria );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_AuditoriaControlCajasRow.
		/// </summary>
		public static tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow SetRowDefaultValues( tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row )
		{
			row.IdAuditoria = 0; 
			row.Fecha = DateTime.Now;
			row.FechaCierre = DateTime.Now;
			row.Cajero = string.Empty;
			row.IdInstanciaCaja = string.Empty;
			row.Tiempo = 0;
			row.AuditadoSupervisor = false;
			row.AuditadoGerente = false;
			row.EsCierre = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasRow a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_AuditoriaControlCajas.Rows.Count > 0, "La tabla dataSet.tfi_AuditoriaControlCajasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_AuditoriaControlCajas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_AuditoriaControlCajasRow.
		/// </summary>
		public static bool RowIsValid( tfi_AuditoriaControlCajasDataset.tfi_AuditoriaControlCajasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdAuditoriaIsValid( row.IdAuditoria, out mensaje) )
			{ 
				row.SetColumnError( "IdAuditoria" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaIsValid( row.Fecha, out mensaje) )
			{ 
				row.SetColumnError( "Fecha" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCierreIsValid( row.FechaCierre, out mensaje) )
			{ 
				row.SetColumnError( "FechaCierre" , mensaje);
				isValid=false;
			
			}
						
			if ( !CajeroIsValid( row.Cajero, out mensaje) )
			{ 
				row.SetColumnError( "Cajero" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdInstanciaCajaIsValid( row.IdInstanciaCaja, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaCaja" , mensaje);
				isValid=false;
			
			}
						
			if ( !TiempoIsValid( row.Tiempo, out mensaje) )
			{ 
				row.SetColumnError( "Tiempo" , mensaje);
				isValid=false;
			
			}
						
			if ( !AuditadoSupervisorIsValid( row.AuditadoSupervisor, out mensaje) )
			{ 
				row.SetColumnError( "AuditadoSupervisor" , mensaje);
				isValid=false;
			
			}
						
			if ( !AuditadoGerenteIsValid( row.AuditadoGerente, out mensaje) )
			{ 
				row.SetColumnError( "AuditadoGerente" , mensaje);
				isValid=false;
			
			}
						
			if ( !EsCierreIsValid( row.EsCierre, out mensaje) )
			{ 
				row.SetColumnError( "EsCierre" , mensaje);
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
		/// Valida el campo Fecha.
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Fecha. Metodo Sobrecargado
		/// </summary>
		public static bool FechaIsValid( DateTime Fecha)
		{
			string mensaje;
			return FechaIsValid( Fecha, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaCierre.
		/// </summary>
		public static bool FechaCierreIsValid( DateTime FechaCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaCierre. Metodo Sobrecargado
		/// </summary>
		public static bool FechaCierreIsValid( DateTime FechaCierre)
		{
			string mensaje;
			return FechaCierreIsValid( FechaCierre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Cajero.
		/// </summary>
		public static bool CajeroIsValid( string Cajero , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cajero. Metodo Sobrecargado
		/// </summary>
		public static bool CajeroIsValid( string Cajero)
		{
			string mensaje;
			return CajeroIsValid( Cajero, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja.
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaCaja. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaCajaIsValid( string IdInstanciaCaja)
		{
			string mensaje;
			return IdInstanciaCajaIsValid( IdInstanciaCaja, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Tiempo.
		/// </summary>
		public static bool TiempoIsValid( long Tiempo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Tiempo. Metodo Sobrecargado
		/// </summary>
		public static bool TiempoIsValid( long Tiempo)
		{
			string mensaje;
			return TiempoIsValid( Tiempo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo AuditadoSupervisor.
		/// </summary>
		public static bool AuditadoSupervisorIsValid( bool AuditadoSupervisor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo AuditadoSupervisor. Metodo Sobrecargado
		/// </summary>
		public static bool AuditadoSupervisorIsValid( bool AuditadoSupervisor)
		{
			string mensaje;
			return AuditadoSupervisorIsValid( AuditadoSupervisor, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo AuditadoGerente.
		/// </summary>
		public static bool AuditadoGerenteIsValid( bool AuditadoGerente , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo AuditadoGerente. Metodo Sobrecargado
		/// </summary>
		public static bool AuditadoGerenteIsValid( bool AuditadoGerente)
		{
			string mensaje;
			return AuditadoGerenteIsValid( AuditadoGerente, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo EsCierre.
		/// </summary>
		public static bool EsCierreIsValid( bool EsCierre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo EsCierre. Metodo Sobrecargado
		/// </summary>
		public static bool EsCierreIsValid( bool EsCierre)
		{
			string mensaje;
			return EsCierreIsValid( EsCierre, out mensaje );
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

