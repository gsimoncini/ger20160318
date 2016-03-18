namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_Flete : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tlg_Flete()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_Flete
		/// </summary>
		public static tlg_FleteDataset GetList()
		{
			return mz.erp.dataaccess.tlg_Flete.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_Flete filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tlg_FleteDataset GetList(  )
		{
			return mz.erp.dataaccess.tlg_Flete.GetList(  );
		}*/

		/// <summary>
		/// Crea un tlg_FleteRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_FleteDataset.tlg_FleteRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_Flete.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_Flete que luego puede ser persistido en la base de datos.
		/// </summary>


		/// <summary>
		/// Obtiene un registro de la tabla tlg_Flete que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_FleteDataset.tlg_FleteRow GetByPk( object IdComprobanteCargoAdicional, string IdTransporte )
		{
			return GetByPk( ( string )IdComprobanteCargoAdicional, ( string )IdTransporte );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_FleteRow.
		/// </summary>
		public static tlg_FleteDataset.tlg_FleteRow SetRowDefaultValues( tlg_FleteDataset.tlg_FleteRow row )
		{
			row.IdComprobanteCargoAdicional = Util.NewStringId(); 
			row.IdTransporte = Util.NewStringId(); 
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_FleteRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_FleteDataset.tlg_FleteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_FleteRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_FleteDataset.tlg_FleteRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_FleteRow a la base de datos.
		/// </summary>
		public static void Update( tlg_FleteDataset.tlg_FleteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Flete.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_FleteDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_FleteDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_Flete.Rows.Count > 0, "La tabla dataSet.tlg_FleteDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Flete.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_FleteDataset.tlg_FleteDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_FleteDataset.tlg_FleteDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_Flete.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_FleteRow.
		/// </summary>
		public static bool RowIsValid( tlg_FleteDataset.tlg_FleteRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdComprobanteCargoAdicionalIsValid( row.IdComprobanteCargoAdicional, out mensaje) )
			{ 
				row.SetColumnError( "IdComprobanteCargoAdicional" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTransporteIsValid( row.IdTransporte, out mensaje) )
			{ 
				row.SetColumnError( "IdTransporte" , mensaje);
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
		/// Valida el campo IdComprobanteCargoAdicional.
		/// </summary>
		public static bool IdComprobanteCargoAdicionalIsValid( string IdComprobanteCargoAdicional , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdComprobanteCargoAdicional. Metodo Sobrecargado
		/// </summary>
		public static bool IdComprobanteCargoAdicionalIsValid( string IdComprobanteCargoAdicional)
		{
			string mensaje;
			return IdComprobanteCargoAdicionalIsValid( IdComprobanteCargoAdicional, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTransporte.
		/// </summary>
		public static bool IdTransporteIsValid( string IdTransporte , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTransporte. Metodo Sobrecargado
		/// </summary>
		public static bool IdTransporteIsValid( string IdTransporte)
		{
			string mensaje;
			return IdTransporteIsValid( IdTransporte, out mensaje );
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

