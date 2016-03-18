namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tfi_TDCompTesoreria_CondicionesDeVenta : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tfi_TDCompTesoreria_CondicionesDeVenta()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tfi_TDCompTesoreria_CondicionesDeVenta
		/// </summary>
		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset GetList()
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tfi_TDCompTesoreria_CondicionesDeVenta filtrada por las condiciones de bsqueda
		/// </summary>
		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset GetList( string IdTDCompTesoreria_CondicionesDeVenta, string idTDCompTesoreria, string idCondicionDeVenta)
		{
			return mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetList(IdTDCompTesoreria_CondicionesDeVenta, idTDCompTesoreria, idCondicionDeVenta);
		}

		/// <summary>
		/// Crea un tfi_TDCompTesoreria_CondicionesDeVentaRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria_CondicionesDeVenta que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow GetByPk( string IdTDCompTesoreria_CondicionesDeVenta )
		{
			tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row = mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.GetByPk( IdTDCompTesoreria_CondicionesDeVenta  );
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
		/// Obtiene un registro de la tabla tfi_TDCompTesoreria_CondicionesDeVenta que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow GetByPk( object IdTDCompTesoreria_CondicionesDeVenta )
		{
			return GetByPk( ( string )IdTDCompTesoreria_CondicionesDeVenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tfi_TDCompTesoreria_CondicionesDeVentaRow.
		/// </summary>
		public static tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow SetRowDefaultValues( tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row )
		{
			row.IdTDCompTesoreria_CondicionesDeVenta = Util.NewStringId(); 
			row.idTDCompTesoreria = string.Empty;
			row.idCondicionDeVenta = string.Empty;
			row.MetodoDeComparacion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdProceso = 0;
			row.IdTarea = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_CondicionesDeVentaRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_CondicionesDeVentaRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_CondicionesDeVentaRow a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_CondicionesDeVentaDataset a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_CondicionesDeVentaDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tfi_TDCompTesoreria_CondicionesDeVenta.Rows.Count > 0, "La tabla dataSet.tfi_TDCompTesoreria_CondicionesDeVentaDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaDataTable a la base de datos.
		/// </summary>
		public static void Update( tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tfi_TDCompTesoreria_CondicionesDeVenta.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tfi_TDCompTesoreria_CondicionesDeVentaRow.
		/// </summary>
		public static bool RowIsValid( tfi_TDCompTesoreria_CondicionesDeVentaDataset.tfi_TDCompTesoreria_CondicionesDeVentaRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdTDCompTesoreria_CondicionesDeVentaIsValid( row.IdTDCompTesoreria_CondicionesDeVenta, out mensaje) )
			{ 
				row.SetColumnError( "IdTDCompTesoreria_CondicionesDeVenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !idTDCompTesoreriaIsValid( row.idTDCompTesoreria, out mensaje) )
			{ 
				row.SetColumnError( "idTDCompTesoreria" , mensaje);
				isValid=false;
			
			}
						
			if ( !idCondicionDeVentaIsValid( row.idCondicionDeVenta, out mensaje) )
			{ 
				row.SetColumnError( "idCondicionDeVenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !MetodoDeComparacionIsValid( row.MetodoDeComparacion, out mensaje) )
			{ 
				row.SetColumnError( "MetodoDeComparacion" , mensaje);
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
						
			if ( !IdProcesoIsValid( row.IdProceso, out mensaje) )
			{ 
				row.SetColumnError( "IdProceso" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTareaIsValid( row.IdTarea, out mensaje) )
			{ 
				row.SetColumnError( "IdTarea" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria_CondicionesDeVenta.
		/// </summary>
		public static bool IdTDCompTesoreria_CondicionesDeVentaIsValid( string IdTDCompTesoreria_CondicionesDeVenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTDCompTesoreria_CondicionesDeVenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdTDCompTesoreria_CondicionesDeVentaIsValid( string IdTDCompTesoreria_CondicionesDeVenta)
		{
			string mensaje;
			return IdTDCompTesoreria_CondicionesDeVentaIsValid( IdTDCompTesoreria_CondicionesDeVenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo idTDCompTesoreria.
		/// </summary>
		public static bool idTDCompTesoreriaIsValid( string idTDCompTesoreria , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo idTDCompTesoreria. Metodo Sobrecargado
		/// </summary>
		public static bool idTDCompTesoreriaIsValid( string idTDCompTesoreria)
		{
			string mensaje;
			return idTDCompTesoreriaIsValid( idTDCompTesoreria, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo idCondicionDeVenta.
		/// </summary>
		public static bool idCondicionDeVentaIsValid( string idCondicionDeVenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo idCondicionDeVenta. Metodo Sobrecargado
		/// </summary>
		public static bool idCondicionDeVentaIsValid( string idCondicionDeVenta)
		{
			string mensaje;
			return idCondicionDeVentaIsValid( idCondicionDeVenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MetodoDeComparacion.
		/// </summary>
		public static bool MetodoDeComparacionIsValid( string MetodoDeComparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MetodoDeComparacion. Metodo Sobrecargado
		/// </summary>
		public static bool MetodoDeComparacionIsValid( string MetodoDeComparacion)
		{
			string mensaje;
			return MetodoDeComparacionIsValid( MetodoDeComparacion, out mensaje );
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
		/// Valida el campo IdProceso.
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProceso. Metodo Sobrecargado
		/// </summary>
		public static bool IdProcesoIsValid( long IdProceso)
		{
			string mensaje;
			return IdProcesoIsValid( IdProceso, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdTarea.
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTarea. Metodo Sobrecargado
		/// </summary>
		public static bool IdTareaIsValid( long IdTarea)
		{
			string mensaje;
			return IdTareaIsValid( IdTarea, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

