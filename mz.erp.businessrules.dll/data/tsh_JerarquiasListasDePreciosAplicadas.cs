namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_JerarquiasListasDePreciosAplicadas : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsh_JerarquiasListasDePreciosAplicadas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_JerarquiasListasDePreciosAplicadas
		/// </summary>
		public static tsh_JerarquiasListasDePreciosAplicadasDataset GetList()
		{
			return mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_JerarquiasListasDePreciosAplicadas filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_JerarquiasListasDePreciosAplicadasDataset GetList( string IdNomenclatura, string IdListaDePrecio, decimal Coeficiente, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.GetList( IdNomenclatura, IdListaDePrecio, Coeficiente, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tsh_JerarquiasListasDePreciosAplicadasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_JerarquiasListasDePreciosAplicadas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow GetByPk( string IdNomenclatura, string IdListaDePrecio )
		{
			tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow row = mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.GetByPk( IdNomenclatura, IdListaDePrecio  );
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
		/// Obtiene un registro de la tabla tsh_JerarquiasListasDePreciosAplicadas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow GetByPk( object IdNomenclatura, object IdListaDePrecio )
		{
			return GetByPk( ( string )IdNomenclatura, ( string )IdListaDePrecio );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_JerarquiasListasDePreciosAplicadasRow.
		/// </summary>
		public static tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow SetRowDefaultValues( tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow row )
		{
			row.IdNomenclatura = Util.NewStringId(); 
			row.IdListaDePrecio = Util.NewStringId(); 
			row.Coeficiente = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.IdSucursal = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiasListasDePreciosAplicadasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiasListasDePreciosAplicadasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiasListasDePreciosAplicadasRow a la base de datos.
		/// </summary>
		public static void Update( tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_JerarquiasListasDePreciosAplicadasDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_JerarquiasListasDePreciosAplicadasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_JerarquiasListasDePreciosAplicadas.Rows.Count > 0, "La tabla dataSet.tsh_JerarquiasListasDePreciosAplicadasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_JerarquiasListasDePreciosAplicadas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_JerarquiasListasDePreciosAplicadasRow.
		/// </summary>
		public static bool RowIsValid( tsh_JerarquiasListasDePreciosAplicadasDataset.tsh_JerarquiasListasDePreciosAplicadasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdNomenclaturaIsValid( row.IdNomenclatura, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclatura" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdListaDePrecioIsValid( row.IdListaDePrecio, out mensaje) )
			{ 
				row.SetColumnError( "IdListaDePrecio" , mensaje);
				isValid=false;
			
			}
						
			if ( !CoeficienteIsValid( row.Coeficiente, out mensaje) )
			{ 
				row.SetColumnError( "Coeficiente" , mensaje);
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
		/// Valida el campo IdNomenclatura.
		/// </summary>
		public static bool IdNomenclaturaIsValid( string IdNomenclatura , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclatura. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclaturaIsValid( string IdNomenclatura)
		{
			string mensaje;
			return IdNomenclaturaIsValid( IdNomenclatura, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdListaDePrecio.
		/// </summary>
		public static bool IdListaDePrecioIsValid( string IdListaDePrecio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdListaDePrecio. Metodo Sobrecargado
		/// </summary>
		public static bool IdListaDePrecioIsValid( string IdListaDePrecio)
		{
			string mensaje;
			return IdListaDePrecioIsValid( IdListaDePrecio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Coeficiente.
		/// </summary>
		public static bool CoeficienteIsValid( decimal Coeficiente , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Coeficiente. Metodo Sobrecargado
		/// </summary>
		public static bool CoeficienteIsValid( decimal Coeficiente)
		{
			string mensaje;
			return CoeficienteIsValid( Coeficiente, out mensaje );
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

