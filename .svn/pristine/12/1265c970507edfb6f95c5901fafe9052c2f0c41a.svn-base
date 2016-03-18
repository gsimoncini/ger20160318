namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using System.Collections;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tlg_TiposComprobantesOrigenDestino : IDisposable
	{
	
		#region Custom Members
		public static long GetMomento(string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino )
		{
			return dataaccess.tlg_TiposComprobantesOrigenDestino.GetMomento(IdTipoComprobanteOrigen, IdTipoComprobanteDestino);
		}
		/// <summary>
		/// Devuelve la lista de posibles comprobantes destinos que pueden realizarse en base al workflow que define la tabla tlg_ComprobantesOridenDestino
		/// Un comprobante tiene posibles destinos si aparece una o varias tuplas que cumplan que el Tipo de Comprobante buscado este en la columna ComprobanteOrigen y que
		/// alla otro tipo de comprobante en el campo ComprobanteDestino
		/// </summary>
		/// <param name="IdTipoComprobanteOrigen"></param>
		/// <returns></returns>
		public static ArrayList GetTipoComprobanteDestino(string IdTipoComprobanteOrigen) 
		{
			tlg_TiposComprobantesOrigenDestinoDataset data = dataaccess.tlg_TiposComprobantesOrigenDestino.GetList(IdTipoComprobanteOrigen, null,  long.MinValue, long.MinValue, long.MinValue);
			ArrayList myArray = new ArrayList();
			foreach (tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row in data.tlg_TiposComprobantesOrigenDestino)
			{
				myArray.Add( row.IdTipoComprobanteDestino );
			}
			return myArray;
		}
		/// <summary>
		/// Verifica si el comprobante seleccionado cierra un circuito en el workflow
		/// Ley: "Un Comprobante de Venta que cierra un circuito nunca aparece en el origen de la tabla tlg_ComprobantesOrigenDestino"
		/// </summary>
		/// <param name="TipoComprobrobante">El tipo de comprobante que chequeo</param>
		/// <returns></returns>
		public static bool CierraCircuito( string TipoComprobante )
		{
			tlg_TiposComprobantesOrigenDestinoDataset data = mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetList( TipoComprobante, null, long.MinValue, long.MinValue, long.MinValue);
			if (data.tlg_TiposComprobantesOrigenDestino.Rows.Count > 0)
			{
				return false;
			}
			else
			{
				return true;
			}

		}
		
		#endregion
		
		public tlg_TiposComprobantesOrigenDestino()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tlg_TiposComprobantesOrigenDestino
		/// </summary>
		/// 

		public static tlg_TiposComprobantesOrigenDestinoDataset GetList()
		{
			return mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tlg_TiposComprobantesOrigenDestino filtrada por las condiciones de bsqueda
		/// </summary>
		public static tlg_TiposComprobantesOrigenDestinoDataset GetList( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino, long IdMomento, long IdSucursal, long IdEmpresa, long OldIdMomento )
		{
			return mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetList( IdTipoComprobanteOrigen, IdTipoComprobanteDestino, IdMomento, IdSucursal, IdEmpresa);
		}

		/// <summary>
		/// Crea un tlg_TiposComprobantesOrigenDestinoRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tlg_TiposComprobantesOrigenDestino que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow GetByPk( string IdTipoComprobanteOrigen, string IdTipoComprobanteDestino )
		{
			tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row = mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.GetByPk( IdTipoComprobanteOrigen, IdTipoComprobanteDestino  );
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
		/// Obtiene un registro de la tabla tlg_TiposComprobantesOrigenDestino que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow GetByPk( object IdTipoComprobanteOrigen, object IdTipoComprobanteDestino )
		{
			return GetByPk( ( string )IdTipoComprobanteOrigen, ( string )IdTipoComprobanteDestino );
		}

		/// <summary>
		/// Establece los valores por defecto de tlg_TiposComprobantesOrigenDestinoRow.
		/// </summary>
		public static tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow SetRowDefaultValues( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row )
		{
			row.IdTipoComprobanteOrigen = Util.NewStringId(); 
			row.IdTipoComprobanteDestino = Util.NewStringId(); 
			row.IdMomento = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.OldIdMomento = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposComprobantesOrigenDestinoRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposComprobantesOrigenDestinoRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposComprobantesOrigenDestinoRow a la base de datos.
		/// </summary>
		public static void Update( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tlg_TiposComprobantesOrigenDestinoDataset a la base de datos.
		/// </summary>
		public static void Update( tlg_TiposComprobantesOrigenDestinoDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tlg_TiposComprobantesOrigenDestino.Rows.Count > 0, "La tabla dataSet.tlg_TiposComprobantesOrigenDestinoDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoDataTable a la base de datos.
		/// </summary>
		public static void Update( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tlg_TiposComprobantesOrigenDestino.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tlg_TiposComprobantesOrigenDestinoRow.
		/// </summary>
		public static bool RowIsValid( tlg_TiposComprobantesOrigenDestinoDataset.tlg_TiposComprobantesOrigenDestinoRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTipoComprobanteOrigenIsValid( row.IdTipoComprobanteOrigen, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoComprobanteOrigen" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoComprobanteDestinoIsValid( row.IdTipoComprobanteDestino, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoComprobanteDestino" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMomentoIsValid( row.IdMomento, out mensaje) )
			{ 
				row.SetColumnError( "IdMomento" , mensaje);
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
						
			if ( !OldIdMomentoIsValid( row.OldIdMomento, out mensaje) )
			{ 
				row.SetColumnError( "OldIdMomento" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTipoComprobanteOrigen.
		/// </summary>
		public static bool IdTipoComprobanteOrigenIsValid( string IdTipoComprobanteOrigen , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoComprobanteOrigen. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoComprobanteOrigenIsValid( string IdTipoComprobanteOrigen)
		{
			string mensaje;
			return IdTipoComprobanteOrigenIsValid( IdTipoComprobanteOrigen, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTipoComprobanteDestino.
		/// </summary>
		public static bool IdTipoComprobanteDestinoIsValid( string IdTipoComprobanteDestino , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoComprobanteDestino. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoComprobanteDestinoIsValid( string IdTipoComprobanteDestino)
		{
			string mensaje;
			return IdTipoComprobanteDestinoIsValid( IdTipoComprobanteDestino, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMomento.
		/// </summary>
		public static bool IdMomentoIsValid( long IdMomento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMomento. Metodo Sobrecargado
		/// </summary>
		public static bool IdMomentoIsValid( long IdMomento)
		{
			string mensaje;
			return IdMomentoIsValid( IdMomento, out mensaje );
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
		
		/// <summary>
		/// Valida el campo OldIdMomento.
		/// </summary>
		public static bool OldIdMomentoIsValid( long OldIdMomento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo OldIdMomento. Metodo Sobrecargado
		/// </summary>
		public static bool OldIdMomentoIsValid( long OldIdMomento)
		{
			string mensaje;
			return OldIdMomentoIsValid( OldIdMomento, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

