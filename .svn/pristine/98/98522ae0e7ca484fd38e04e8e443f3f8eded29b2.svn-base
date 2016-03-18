namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProveedoresDetallePagoImpuestoGanancias : IDisposable
	{
	
		#region Custom Members
		
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow GetByPeriodo( string IdProveedor, int Año, int Mes)
		{
			tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row = mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.GetByPeriodo( IdProveedor, Año, Mes  );
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

		
		
		#endregion
		
		

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresDetallePagoImpuestoGanancias
		/// </summary>
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProveedoresDetallePagoImpuestoGanancias filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset GetList( long IdDetallePago, int Mes, int Anio, decimal TotalPago, decimal TotalRetencioes, long IdConceptoImpuestoGanancias )
		{
			return mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.GetList( IdDetallePago, Mes, Anio, TotalPago, TotalRetencioes, IdConceptoImpuestoGanancias );
		}

		/// <summary>
		/// Crea un tpu_ProveedoresDetallePagoImpuestoGananciasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresDetallePagoImpuestoGanancias que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow GetByPk( long IdDetallePago )
		{
			tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row = mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.GetByPk( IdDetallePago  );
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
		/// Obtiene un registro de la tabla tpu_ProveedoresDetallePagoImpuestoGanancias que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow GetByPk( object IdDetallePago )
		{
			return GetByPk( ( long )IdDetallePago );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresDetallePagoImpuestoGananciasRow.
		/// </summary>
		public static tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow SetRowDefaultValues( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row )
		{
			row.IdDetallePago = 0; 
			row.Mes = 0;
			row.Anio = 0;
			row.TotalPago = 0;
			row.TotalRetenciones = 0;
			row.IdConceptoImpuestoGanancias = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = Security.IdEmpresa;
			row.IdSucursal = Security.IdSucursal;
			row.IdProveedor = string.Empty;
			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDetallePagoImpuestoGananciasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDetallePagoImpuestoGananciasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDetallePagoImpuestoGananciasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDetallePagoImpuestoGananciasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresDetallePagoImpuestoGananciasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresDetallePagoImpuestoGanancias.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresDetallePagoImpuestoGananciasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresDetallePagoImpuestoGanancias.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresDetallePagoImpuestoGananciasRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresDetallePagoImpuestoGananciasDataset.tpu_ProveedoresDetallePagoImpuestoGananciasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdDetallePagoIsValid( row.IdDetallePago, out mensaje) )
			{ 
				row.SetColumnError( "IdDetallePago" , mensaje);
				isValid=false;
			
			}
						
			if ( !MesIsValid( row.Mes, out mensaje) )
			{ 
				row.SetColumnError( "Mes" , mensaje);
				isValid=false;
			
			}
						
			if ( !AnioIsValid( row.Anio, out mensaje) )
			{ 
				row.SetColumnError( "Anio" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalPagoIsValid( row.TotalPago, out mensaje) )
			{ 
				row.SetColumnError( "TotalPago" , mensaje);
				isValid=false;
			
			}
						
			if ( !TotalRetencioesIsValid( row.TotalRetenciones, out mensaje) )
			{ 
				row.SetColumnError( "TotalRetenciones" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdConceptoImpuestoGananciasIsValid( row.IdConceptoImpuestoGanancias, out mensaje) )
			{ 
				row.SetColumnError( "IdConceptoImpuestoGanancias" , mensaje);
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
				/*		
			if ( !UltimaModificacionIsValid( row.UltimaModificacion, out mensaje) )
			{ 
				row.SetColumnError( "UltimaModificacion" , mensaje);
				isValid=false;
			
			}
				*/		
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdDetallePago.
		/// </summary>
		public static bool IdDetallePagoIsValid( long IdDetallePago , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdDetallePago. Metodo Sobrecargado
		/// </summary>
		public static bool IdDetallePagoIsValid( long IdDetallePago)
		{
			string mensaje;
			return IdDetallePagoIsValid( IdDetallePago, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Mes.
		/// </summary>
		public static bool MesIsValid( int Mes , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Mes. Metodo Sobrecargado
		/// </summary>
		public static bool MesIsValid( int Mes)
		{
			string mensaje;
			return MesIsValid( Mes, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Anio.
		/// </summary>
		public static bool AnioIsValid( int Anio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Anio. Metodo Sobrecargado
		/// </summary>
		public static bool AnioIsValid( int Anio)
		{
			string mensaje;
			return AnioIsValid( Anio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo TotalPago.
		/// </summary>
		public static bool TotalPagoIsValid( decimal TotalPago , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo TotalPago. Metodo Sobrecargado
		/// </summary>
		public static bool TotalPagoIsValid( decimal TotalPago)
		{
			string mensaje;
			return TotalPagoIsValid( TotalPago, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo TotalRetencioes.
		/// </summary>
		public static bool TotalRetencioesIsValid( decimal TotalRetencioes , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo TotalRetencioes. Metodo Sobrecargado
		/// </summary>
		public static bool TotalRetencioesIsValid( decimal TotalRetencioes)
		{
			string mensaje;
			return TotalRetencioesIsValid( TotalRetencioes, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdConceptoImpuestoGanancias.
		/// </summary>
		public static bool IdConceptoImpuestoGananciasIsValid( long IdConceptoImpuestoGanancias , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdConceptoImpuestoGanancias. Metodo Sobrecargado
		/// </summary>
		public static bool IdConceptoImpuestoGananciasIsValid( long IdConceptoImpuestoGanancias)
		{
			string mensaje;
			return IdConceptoImpuestoGananciasIsValid( IdConceptoImpuestoGanancias, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

