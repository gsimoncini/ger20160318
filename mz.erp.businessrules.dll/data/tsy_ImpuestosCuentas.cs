namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_ImpuestosCuentas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_ImpuestosCuentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_ImpuestosCuentas
		/// </summary>
		public static tsy_ImpuestosCuentasDataset GetList()
		{
			return mz.erp.dataaccess.tsy_ImpuestosCuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_ImpuestosCuentas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_ImpuestosCuentasDataset GetList( string IdImpuesto, string IdCuenta, string MetodoDeAsignacion)
		{
			return mz.erp.dataaccess.tsy_ImpuestosCuentas.GetList( IdImpuesto, IdCuenta, MetodoDeAsignacion);
		}

		/// <summary>
		/// Crea un tsy_ImpuestosCuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_ImpuestosCuentas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_ImpuestosCuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow GetByPk( string IdImpuesto, string IdCuenta )
		{
			tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow row = mz.erp.dataaccess.tsy_ImpuestosCuentas.GetByPk( IdImpuesto, IdCuenta  );
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
		/// Obtiene un registro de la tabla tsy_ImpuestosCuentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow GetByPk( object IdImpuesto, object IdCuenta )
		{
			return GetByPk( ( string )IdImpuesto, ( string )IdCuenta );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_ImpuestosCuentasRow.
		/// </summary>
		public static tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow SetRowDefaultValues( tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow row )
		{
			row.IdImpuesto = Util.NewStringId(); 
			row.IdCuenta = Util.NewStringId(); 
			row.MetodoDeAsignacion = "E";
			row.FechaCreacion = DateTime.Now;
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
		/// Envia los cambios del tsy_ImpuestosCuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosCuentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosCuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ImpuestosCuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_ImpuestosCuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosCuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_ImpuestosCuentas.Rows.Count > 0, "La tabla dataSet.tsy_ImpuestosCuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ImpuestosCuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_ImpuestosCuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_ImpuestosCuentasRow.
		/// </summary>
		public static bool RowIsValid( tsy_ImpuestosCuentasDataset.tsy_ImpuestosCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdImpuestoIsValid( row.IdImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "IdImpuesto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaIsValid( row.IdCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !MetodoDeAsignacionIsValid( row.MetodoDeAsignacion, out mensaje) )
			{ 
				row.SetColumnError( "MetodoDeAsignacion" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdImpuesto.
		/// </summary>
		public static bool IdImpuestoIsValid( string IdImpuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdImpuesto. Metodo Sobrecargado
		/// </summary>
		public static bool IdImpuestoIsValid( string IdImpuesto)
		{
			string mensaje;
			return IdImpuestoIsValid( IdImpuesto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuenta.
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaIsValid( string IdCuenta)
		{
			string mensaje;
			return IdCuentaIsValid( IdCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MetodoDeAsignacion.
		/// </summary>
		public static bool MetodoDeAsignacionIsValid( string MetodoDeAsignacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MetodoDeAsignacion. Metodo Sobrecargado
		/// </summary>
		public static bool MetodoDeAsignacionIsValid( string MetodoDeAsignacion)
		{
			string mensaje;
			return MetodoDeAsignacionIsValid( MetodoDeAsignacion, out mensaje );
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

