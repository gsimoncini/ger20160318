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

	public class tfi_TDCompTesoreriasMonedasRecargos : IDisposable
	{
	
		#region Custom Members
		public static System.Collections.Hashtable GetRecargosTDCompTesoreria()
		{
			tfi_TDCompTesoreriasMonedasRecargosDataset data = new tfi_TDCompTesoreriasMonedasRecargosDataset();
			data = GetList(null,null);
			Hashtable recargos = new Hashtable();
			foreach (mz.erp.commontypes.data.tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row in data.tfi_TDCompTesoreriasMonedasRecargos.Rows )
			{
				recargos.Add( row.IdTDCompTesoreria + ' '+row.IdMoneda, row.Recargo );
			}
			return recargos;
		}
		public static decimal Recargo( string IdTdCompTesoreria, string IdMoneda)
		{
			tfi_TDCompTesoreriasMonedasRecargosDataset data = new tfi_TDCompTesoreriasMonedasRecargosDataset();
			data = GetList(IdTdCompTesoreria,IdMoneda);
			decimal valor = 0;
			if (data.tfi_TDCompTesoreriasMonedasRecargos.Rows.Count > 0)
			{
				tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row  = (tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow) data.tfi_TDCompTesoreriasMonedasRecargos.Rows[0];
				valor = Convert.ToDecimal(row.Recargo);
			}
			
			return valor;
		}
		
		#endregion
		
		public tfi_TDCompTesoreriasMonedasRecargos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_TDCompTesoreriasMonedasRecargos
		/// </summary>
		public static tfi_TDCompTesoreriasMonedasRecargosDataset GetList()
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_TDCompTesoreriasMonedasRecargos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_TDCompTesoreriasMonedasRecargosDataset GetList( string IdTDCompTesoreria, string IdMoneda )
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.GetList( IdTDCompTesoreria, IdMoneda );
		}

		/// <summary>
		/// Crea un tfi_TDCompTesoreriasMonedasRecargosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_TDCompTesoreriasMonedasRecargos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow GetByPk( string IdFormaDePago )
		{
			tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row = mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.GetByPk( IdFormaDePago  );
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
		/// Obtiene un registro de la tabla tfi_TDCompTesoreriasMonedasRecargos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow GetByPk( object IdFormaDePago )
		{
			return GetByPk( ( string )IdFormaDePago );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_TDCompTesoreriasMonedasRecargosRow.
		/// </summary>
		public static tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow SetRowDefaultValues( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row )
		{
			row.IdFormaDePago = Util.NewStringId(); 
			row.IdTDCompTesoreria = string.Empty;
			row.IdMoneda = string.Empty;
			row.Recargo = 0;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriasMonedasRecargosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriasMonedasRecargosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriasMonedasRecargosRow a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriasMonedasRecargosDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreriasMonedasRecargosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_TDCompTesoreriasMonedasRecargos.Rows.Count > 0, "La tabla dataSet.tfi_TDCompTesoreriasMonedasRecargosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreriasMonedasRecargos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_TDCompTesoreriasMonedasRecargosRow.
		/// </summary>
		public static bool RowIsValid( tfi_TDCompTesoreriasMonedasRecargosDataset.tfi_TDCompTesoreriasMonedasRecargosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTDCompTesoreriaIsValid( row.IdTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaIsValid( row.IdMoneda, out mensaje) )
			{ 
				row.SetColumnError( "IdMoneda" , mensaje);
				isValid=false;
			
			}
						
			if ( !RecargoIsValid( row.Recargo, out mensaje) )
			{ 
				row.SetColumnError( "Recargo" , mensaje);
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
						
			if ( !IdFormaDePagoIsValid( row.IdFormaDePago, out mensaje) )
			{ 
				row.SetColumnError( "IdFormaDePago" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria.
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreriaIsValid( string IdTDCompTesoreria)
		{
			string mensaje;
			return IdTDCompTesoreriaIsValid( IdTDCompTesoreria, out mensaje );
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
		/// Valida el campo Recargo.
		/// </summary>
		public static bool RecargoIsValid( decimal Recargo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Recargo. Metodo Sobrecargado
		/// </summary>
		public static bool RecargoIsValid( decimal Recargo)
		{
			string mensaje;
			return RecargoIsValid( Recargo, out mensaje );
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
		/// Valida el campo IdFormaDePago.
		/// </summary>
		public static bool IdFormaDePagoIsValid( string IdFormaDePago , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFormaDePago. Metodo Sobrecargado
		/// </summary>
		public static bool IdFormaDePagoIsValid( string IdFormaDePago)
		{
			string mensaje;
			return IdFormaDePagoIsValid( IdFormaDePago, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

