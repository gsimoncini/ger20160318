namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_Comprobantes : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_Comprobantes()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Comprobantes
		/// </summary>
		/*public static tlg_ComprobantesDataset GetList()
		{			
			//return mz.erp.dataaccess.tlg_Comprobantes.GetList();
		}*/
		
		/// <summary>
		/// Obtiene tabla tlg_Comprobantes filtrada por las condiciones de bsqueda
		/// </summary>
/*		public static tlg_ComprobantesDataset GetList(  )
		{
			return mz.erp.dataaccess.tlg_Comprobantes.GetList(  );
		}*/

		/// <summary>
		/// Crea un tlg_ComprobantesRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_ComprobantesDataset.tlg_ComprobantesRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_Comprobantes.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Comprobantes que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_ComprobantesDataset.tlg_ComprobantesRow GetByPk( string IdComprobante )
		{
			tlg_ComprobantesDataset.tlg_ComprobantesRow row = mz.erp.dataaccess.tlg_Comprobantes.GetByPk( IdComprobante  );

            //German 20120213 -  Tarea 0000247
            if(row != null)
            {
			    foreach ( DataColumn dc in row.Table.Columns ) 
			    {
				    if(!dc.Caption.ToUpper().Equals("ROWID"))
				    {
					    if (row[dc] == System.DBNull.Value)
					    {
						    row[dc] = Util.DefaultValue( dc.DataType );
					    }
				    }
			    }
            }
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Comprobantes que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_ComprobantesDataset.tlg_ComprobantesRow GetByPk( object IdComprobante )
		{
			return GetByPk( ( string )IdComprobante );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_ComprobantesRow.
		/// </summary>
		public static tlg_ComprobantesDataset.tlg_ComprobantesRow SetRowDefaultValues( tlg_ComprobantesDataset.tlg_ComprobantesRow row )
		{
			row.IdComprobante = Util.NewStringId(); 
			row.FechaConvenida = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaVencimiento = mz.erp.businessrules.Sistema.DateTime.Now;
			row.Observaciones = string.Empty;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.CampoAuxiliar4 = string.Empty;
			row.CampoAuxiliar5 = string.Empty;
			row.IdDomicilio = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.OldIdComprobante = string.Empty;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ComprobantesRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_ComprobantesDataset.tlg_ComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ComprobantesRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_ComprobantesDataset.tlg_ComprobantesRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ComprobantesRow a la base de datos.
		/// </summary>
		public static void Update( tlg_ComprobantesDataset.tlg_ComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Comprobantes.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_ComprobantesDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_ComprobantesDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Comprobantes.Rows.Count > 0, "La tabla dataSet.tlg_ComprobantesDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Comprobantes.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_ComprobantesDataset.tlg_ComprobantesDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_ComprobantesDataset.tlg_ComprobantesDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Comprobantes.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_ComprobantesRow.
		/// </summary>
		public static bool RowIsValid( tlg_ComprobantesDataset.tlg_ComprobantesRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteIsValid( row.IdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobante" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaConvenidaIsValid( row.FechaConvenida, out mensaje) )
			{ 
				row.SetColumnError( "FechaConvenida" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaVencimientoIsValid( row, out mensaje) )
			{ 
				row.SetColumnError( "FechaVencimiento" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar1IsValid( row.CampoAuxiliar1, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar1" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar2IsValid( row.CampoAuxiliar2, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar2" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar3IsValid( row.CampoAuxiliar3, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar3" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar4IsValid( row.CampoAuxiliar4, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar4" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar5IsValid( row.CampoAuxiliar5, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar5" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdDomicilioIsValid( row.IdDomicilio, out mensaje) )
			{ 
				row.SetColumnError( "IdDomicilio" , mensaje);
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
						
			/*if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
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
						
			if ( !OldIdComprobanteIsValid( row.OldIdComprobante, out mensaje) )
			{ 
				row.SetColumnError( "OldIdComprobante" , mensaje);
				isValid=false;			
			}

			if (row.FechaVencimiento < row.FechaConvenida) 
			{
				row.SetColumnError( "FechaVencimiento", "La fecha de vencimiento no puede ser anterior a la fecha convenida");
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
		/// Valida el campo FechaConvenida.
		/// </summary>
		public static bool FechaConvenidaIsValid( DateTime FechaConvenida , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaConvenida. Metodo Sobrecargado
		/// </summary>
		public static bool FechaConvenidaIsValid( DateTime FechaConvenida)
		{
			string mensaje;
			return FechaConvenidaIsValid( FechaConvenida, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaVencimiento.
		/// </summary>
		public static bool FechaVencimientoIsValid( tlg_ComprobantesDataset.tlg_ComprobantesRow row, out string mensaje )
		{
			//Agregar cdigo de validacin			
			if (row.FechaVencimiento < row.FechaConvenida) 
			{
				mensaje = "La fecha de vencimiento no puede ser anterior a la fecha convenida.";
				return false;
			}			
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaVencimiento. Metodo Sobrecargado
		/// </summary>
		public static bool FechaVencimientoIsValid( tlg_ComprobantesDataset.tlg_ComprobantesRow row)
		{
			string mensaje;
			return FechaVencimientoIsValid( row, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1.
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1)
		{
			string mensaje;
			return CampoAuxiliar1IsValid( CampoAuxiliar1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2.
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2)
		{
			string mensaje;
			return CampoAuxiliar2IsValid( CampoAuxiliar2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3.
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3)
		{
			string mensaje;
			return CampoAuxiliar3IsValid( CampoAuxiliar3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar4.
		/// </summary>
		public static bool CampoAuxiliar4IsValid( string CampoAuxiliar4 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar4. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar4IsValid( string CampoAuxiliar4)
		{
			string mensaje;
			return CampoAuxiliar4IsValid( CampoAuxiliar4, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar5.
		/// </summary>
		public static bool CampoAuxiliar5IsValid( string CampoAuxiliar5 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar5. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar5IsValid( string CampoAuxiliar5)
		{
			string mensaje;
			return CampoAuxiliar5IsValid( CampoAuxiliar5, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdDomicilio.
		/// </summary>
		public static bool IdDomicilioIsValid( string IdDomicilio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDomicilio. Metodo Sobrecargado
		/// </summary>
		public static bool IdDomicilioIsValid( string IdDomicilio)
		{
			string mensaje;
			return IdDomicilioIsValid( IdDomicilio, out mensaje );
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
		
		/// <summary>
		/// Valida el campo OldIdComprobante.
		/// </summary>
		public static bool OldIdComprobanteIsValid( string OldIdComprobante , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OldIdComprobante. Metodo Sobrecargado
		/// </summary>
		public static bool OldIdComprobanteIsValid( string OldIdComprobante)
		{
			string mensaje;
			return OldIdComprobanteIsValid( OldIdComprobante, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

