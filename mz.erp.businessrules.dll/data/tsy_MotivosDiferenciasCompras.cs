namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsy_MotivosDiferenciasCompras : IDisposable
	{
	
		#region Custom Members
		
		#endregion
		
		public tsy_MotivosDiferenciasCompras()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsy_MotivosDiferenciasCompras
		/// </summary>
		public static tsy_MotivosDiferenciasComprasDataset GetList()
		{
			return mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsy_MotivosDiferenciasCompras filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsy_MotivosDiferenciasComprasDataset GetList( long IdMotivoDiferencia, string Descripcion, bool Activo )
		{
			return mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.GetList( IdMotivoDiferencia, Descripcion, Activo );
		}

		/// <summary>
		/// Crea un tsy_MotivosDiferenciasComprasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsy_MotivosDiferenciasCompras que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow GetByPk( long IdMotivoDiferencia )
		{
			tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow row = mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.GetByPk( IdMotivoDiferencia  );
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
		/// Obtiene un registro de la tabla tsy_MotivosDiferenciasCompras que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow GetByPk( object IdMotivoDiferencia )
		{
			return GetByPk( ( long )IdMotivoDiferencia );
		}

		/// <summary>
		/// Establece los valores por defecto de tsy_MotivosDiferenciasComprasRow.
		/// </summary>
		public static tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow SetRowDefaultValues( tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow row )
		{
			row.IdMotivoDiferencia = 0; 
			row.Descripcion = string.Empty;
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
		/// Envia los cambios del tsy_MotivosDiferenciasComprasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivosDiferenciasComprasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivosDiferenciasComprasRow a la base de datos.
		/// </summary>
		public static void Update( tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsy_MotivosDiferenciasComprasDataset a la base de datos.
		/// </summary>
		public static void Update( tsy_MotivosDiferenciasComprasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsy_MotivosDiferenciasCompras.Rows.Count > 0, "La tabla dataSet.tsy_MotivosDiferenciasComprasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsy_MotivosDiferenciasCompras.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsy_MotivosDiferenciasComprasRow.
		/// </summary>
		public static bool RowIsValid( tsy_MotivosDiferenciasComprasDataset.tsy_MotivosDiferenciasComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdMotivoDiferenciaIsValid( row.IdMotivoDiferencia, out mensaje) )
			{ 
				row.SetColumnError( "IdMotivoDiferencia" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
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
		/// Valida el campo IdMotivoDiferencia.
		/// </summary>
		public static bool IdMotivoDiferenciaIsValid( long IdMotivoDiferencia , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMotivoDiferencia. Metodo Sobrecargado
		/// </summary>
		public static bool IdMotivoDiferenciaIsValid( long IdMotivoDiferencia)
		{
			string mensaje;
			return IdMotivoDiferenciaIsValid( IdMotivoDiferencia, out mensaje );
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

