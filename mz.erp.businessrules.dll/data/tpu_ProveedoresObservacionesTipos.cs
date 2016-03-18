namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProveedoresObservacionesTipos : IDisposable
	{
	
		#region Custom Members
		public static tpu_ProveedoresObservacionesTiposDataset GetListTipos()
		{
			bool Activo = true;
			return mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetListTipos(Activo);
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetListSubTipos(string IdProveedorObservacionTipoPadre)
		{
			bool Activo = true;
			return mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetListSubTipos(Activo, IdProveedorObservacionTipoPadre);
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetList(string IdProveedorObservacionTipoPadre, bool Activo )
		{
			return mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetList(IdProveedorObservacionTipoPadre, Activo);
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetListSubTiposPerfil(string IdProveedorObservacionTipoPadre, string Modo)
		{
			bool Activo = true;
			long IdPerfil = Security.IdPerfil;
			return mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetListSubTiposPerfil(Activo, IdProveedorObservacionTipoPadre, IdPerfil, Modo);
		}

		public static tpu_ProveedoresObservacionesTiposDataset GetListTiposPerfil(string Modo)
		{
			bool Activo = true;
			long IdPerfil = Security.IdPerfil;			
			return mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetListTiposPerfil(Activo, IdPerfil, Modo);
		}

		#endregion
		
		public tpu_ProveedoresObservacionesTipos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresObservacionesTipos
		/// </summary>
		public static tpu_ProveedoresObservacionesTiposDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetList();
		}
		

		/// <summary>
		/// Crea un tpu_ProveedoresObservacionesTiposRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresObservacionesTipos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow GetByPk( string IdProveedorObservacionTipo )
		{
			tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow row = mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.GetByPk( IdProveedorObservacionTipo  );
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
		/// Obtiene un registro de la tabla tpu_ProveedoresObservacionesTipos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow GetByPk( object IdProveedorObservacionTipo )
		{
			return GetByPk( ( string )IdProveedorObservacionTipo );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresObservacionesTiposRow.
		/// </summary>
		public static tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow SetRowDefaultValues( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow row )
		{
			row.IdProveedorObservacionTipo = Util.NewStringId(); 
			row.IdProveedorObservacionTipoPadre = string.Empty;
			row.Descripcion = string.Empty;
			row.FechaCreacion = DateTime.Now;
			row.Activo = false;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = 0;
			row.IdEmpresa = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesTiposRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesTiposRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesTiposRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesTiposDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresObservacionesTiposDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresObservacionesTipos.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresObservacionesTiposDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresObservacionesTipos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresObservacionesTiposRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresObservacionesTiposDataset.tpu_ProveedoresObservacionesTiposRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProveedorObservacionTipoIsValid( row.IdProveedorObservacionTipo, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedorObservacionTipo" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProveedorObservacionTipoPadreIsValid( row.IdProveedorObservacionTipoPadre, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedorObservacionTipoPadre" , mensaje);
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
		/// Valida el campo IdProveedorObservacionTipo.
		/// </summary>
		public static bool IdProveedorObservacionTipoIsValid( string IdProveedorObservacionTipo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionTipo. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorObservacionTipoIsValid( string IdProveedorObservacionTipo)
		{
			string mensaje;
			return IdProveedorObservacionTipoIsValid( IdProveedorObservacionTipo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionTipoPadre.
		/// </summary>
		public static bool IdProveedorObservacionTipoPadreIsValid( string IdProveedorObservacionTipoPadre , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedorObservacionTipoPadre. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorObservacionTipoPadreIsValid( string IdProveedorObservacionTipoPadre)
		{
			string mensaje;
			return IdProveedorObservacionTipoPadreIsValid( IdProveedorObservacionTipoPadre, out mensaje );
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

