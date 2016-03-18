namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_RetencionesDet : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tpu_RetencionesDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_RetencionesDet
		/// </summary>
		public static tpu_RetencionesDetDataset GetList()
		{
			return mz.erp.dataaccess.tpu_RetencionesDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_RetencionesDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_RetencionesDetDataset GetList( long IdRetencion, string IdComprobante, string IdConcepto, decimal MontoNeto, decimal AlicuotaAplicada, decimal MontoRetencion )
		{
			return mz.erp.dataaccess.tpu_RetencionesDet.GetList( IdRetencion, IdComprobante, IdConcepto, MontoNeto, AlicuotaAplicada, MontoRetencion);
		}

		/// <summary>
		/// Crea un tpu_RetencionesDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_RetencionesDetDataset.tpu_RetencionesDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_RetencionesDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_RetencionesDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_RetencionesDetDataset.tpu_RetencionesDetRow GetByPk( long IdRetencion, string IdComprobante, string IdConcepto )
		{
			tpu_RetencionesDetDataset.tpu_RetencionesDetRow row = mz.erp.dataaccess.tpu_RetencionesDet.GetByPk( IdRetencion, IdComprobante, IdConcepto  );
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
		/// Obtiene un registro de la tabla tpu_RetencionesDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_RetencionesDetDataset.tpu_RetencionesDetRow GetByPk( object IdRetencion, object IdComprobante, object IdConcepto )
		{
			return GetByPk( ( long )IdRetencion, ( string )IdComprobante, ( string )IdConcepto );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_RetencionesDetRow.
		/// </summary>
		public static tpu_RetencionesDetDataset.tpu_RetencionesDetRow SetRowDefaultValues( tpu_RetencionesDetDataset.tpu_RetencionesDetRow row )
		{
			row.IdRetencion = 0; 
			row.IdComprobante = Util.NewStringId(); 
			row.IdConcepto = Util.NewStringId(); 
			row.MontoNeto = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;
			row.AlicuotaAplicada = 0;
			row.MontoRetencion = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_RetencionesDetDataset.tpu_RetencionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_RetencionesDetDataset.tpu_RetencionesDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesDetRow a la base de datos.
		/// </summary>
		public static void Update( tpu_RetencionesDetDataset.tpu_RetencionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RetencionesDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_RetencionesDetDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_RetencionesDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_RetencionesDet.Rows.Count > 0, "La tabla dataSet.tpu_RetencionesDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RetencionesDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_RetencionesDetDataset.tpu_RetencionesDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_RetencionesDetDataset.tpu_RetencionesDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_RetencionesDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_RetencionesDetRow.
		/// </summary>
		public static bool RowIsValid( tpu_RetencionesDetDataset.tpu_RetencionesDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdRetencionIsValid( row.IdRetencion, out mensaje) )
			{ 
				row.SetColumnError( "IdRetencion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConceptoIsValid( row.IdConcepto, out mensaje) )
			{ 
				row.SetColumnError( "IdConcepto" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoNetoIsValid( row.MontoNeto, out mensaje) )
			{ 
				row.SetColumnError( "MontoNeto" , mensaje);
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
			if ( !AlicuotaAplicadaIsValid( row.AlicuotaAplicada, out mensaje) )
			{ 
				row.SetColumnError( "AlicuotaAplicada" , mensaje);
				isValid=false;
			
			}
						
			if ( !MontoRetencionIsValid( row.MontoRetencion, out mensaje) )
			{ 
				row.SetColumnError( "MontoRetencion" , mensaje);
				isValid=false;
			
			}

			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdRetencion.
		/// </summary>
		public static bool IdRetencionIsValid( long IdRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool IdRetencionIsValid( long IdRetencion)
		{
			string mensaje;
			return IdRetencionIsValid( IdRetencion, out mensaje );
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
		/// Valida el campo IdConcepto.
		/// </summary>
		public static bool IdConceptoIsValid( string IdConcepto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConcepto. Metodo Sobrecargado
		/// </summary>
		public static bool IdConceptoIsValid( string IdConcepto)
		{
			string mensaje;
			return IdConceptoIsValid( IdConcepto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MontoNeto.
		/// </summary>
		public static bool MontoNetoIsValid( decimal MontoNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MontoNeto. Metodo Sobrecargado
		/// </summary>
		public static bool MontoNetoIsValid( decimal MontoNeto)
		{
			string mensaje;
			return MontoNetoIsValid( MontoNeto, out mensaje );
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
		/// Valida el campo AlicuotaAplicada.
		/// </summary>
		public static bool AlicuotaAplicadaIsValid( decimal AlicuotaAplicada , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo AlicuotaAplicada. Metodo Sobrecargado
		/// </summary>
		public static bool AlicuotaAplicadaIsValid( decimal AlicuotaAplicada)
		{
			string mensaje;
			return AlicuotaAplicadaIsValid( AlicuotaAplicada, out mensaje );
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
		/// Valida el campo MontoRetencion. Metodo Sobrecargado
		/// </summary>
		public static bool MontoRetencionIsValid( decimal MontoRetencion)
		{
			string mensaje;
			return MontoRetencionIsValid( MontoRetencion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MontoRetencion.
		/// </summary>
		public static bool MontoRetencionIsValid( decimal MontoRetencion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}

		public void Dispose()
		{
		}
		
	}
}

