namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsa_CuentasObservacionesTipos : IDisposable
	{
	
		#region Custom Members
		
		public static tsa_CuentasObservacionesTiposDataset GetListTipos()
		{
			bool Activo = true;
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetListTipos(Activo);
		}
		public static tsa_CuentasObservacionesTiposDataset GetListSubTipos(string IdCuentaObservacionTipoPadre)
		{
			bool Activo = true;
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetListSubTipos(Activo, IdCuentaObservacionTipoPadre);
		}

		public static tsa_CuentasObservacionesTiposDataset GetListTiposPerfil(string Modo)
		{
			bool Activo = true;
			long IdPerfil = Security.IdPerfil;			
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetListTiposPerfil(Activo, IdPerfil, Modo);
		}
		public static tsa_CuentasObservacionesTiposDataset GetListSubTiposPerfil(string IdCuentaObservacionTipoPadre, string Modo)
		{
			bool Activo = true;
			long IdPerfil = Security.IdPerfil;
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetListSubTiposPerfil(Activo, IdCuentaObservacionTipoPadre, IdPerfil, Modo);
		}

		#endregion
		
		public tsa_CuentasObservacionesTipos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsa_CuentasObservacionesTipos
		/// </summary>
		public static tsa_CuentasObservacionesTiposDataset GetList()
		{
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetList();
		}
		
		public static tsa_CuentasObservacionesTiposDataset GetList(string IdCuentaObservacionTipoPadre, bool Activo )
		{
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetList(IdCuentaObservacionTipoPadre, Activo);
		}

		/// <summary>
		/// Obtiene tabla tsa_CuentasObservacionesTipos filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tsa_CuentasObservacionesTiposDataset GetList( parametros )
		{
			return mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetList(  );
		}*/

		/// <summary>
		/// Crea un tsa_CuentasObservacionesTiposRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsa_CuentasObservacionesTipos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasObservacionesTipos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow GetByPk( string IdCuentaObservacionTipo )
		{
			tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row = mz.erp.dataaccess.tsa_CuentasObservacionesTipos.GetByPk( IdCuentaObservacionTipo  );
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
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsa_CuentasObservacionesTipos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow GetByPk( object IdCuentaObservacionTipo )
		{
			return GetByPk( ( string )IdCuentaObservacionTipo );
		}

		/// <summary>
		/// Establece los valores por defecto de tsa_CuentasObservacionesTiposRow.
		/// </summary>
		public static tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow SetRowDefaultValues( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row )
		{
			row.IdCuentaObservacionTipo = Util.NewStringId(); 
			row.IdCuentaObservacionTipoPadre = string.Empty;
			row.Descripcion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.Activo = false;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesTiposRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesTiposRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesTiposRow a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasObservacionesTipos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesTiposDataset a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasObservacionesTiposDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsa_CuentasObservacionesTipos.Rows.Count > 0, "La tabla dataSet.tsa_CuentasObservacionesTiposDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasObservacionesTipos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable a la base de datos.
		/// </summary>
		public static void Update( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsa_CuentasObservacionesTipos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsa_CuentasObservacionesTiposRow.
		/// </summary>
		public static bool RowIsValid( tsa_CuentasObservacionesTiposDataset.tsa_CuentasObservacionesTiposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCuentaObservacionTipoIsValid( row.IdCuentaObservacionTipo, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaObservacionTipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaObservacionTipoPadreIsValid( row.IdCuentaObservacionTipoPadre, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaObservacionTipoPadre" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
			{ 
				row.SetColumnError( "FechaCreacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionTipo.
		/// </summary>
		public static bool IdCuentaObservacionTipoIsValid( string IdCuentaObservacionTipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionTipo. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaObservacionTipoIsValid( string IdCuentaObservacionTipo)
		{
			string mensaje;
			return IdCuentaObservacionTipoIsValid( IdCuentaObservacionTipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionTipoPadre.
		/// </summary>
		public static bool IdCuentaObservacionTipoPadreIsValid( string IdCuentaObservacionTipoPadre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaObservacionTipoPadre. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaObservacionTipoPadreIsValid( string IdCuentaObservacionTipoPadre)
		{
			string mensaje;
			return IdCuentaObservacionTipoPadreIsValid( IdCuentaObservacionTipoPadre, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Descripcion. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion)
		{
			string mensaje;
			return DescripcionIsValid( Descripcion, out mensaje );
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
		/// Valida el campo Activo.
		/// </summary>
		public static bool ActivoIsValid( bool Activo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Activo. Metodo Sobrecargado
		/// </summary>
		public static bool ActivoIsValid( bool Activo)
		{
			string mensaje;
			return ActivoIsValid( Activo, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

