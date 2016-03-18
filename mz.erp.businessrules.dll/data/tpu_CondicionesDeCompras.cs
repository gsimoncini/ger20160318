namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_CondicionesDeCompras : IDisposable
	{
	
		#region Custom Members

        /* Silvina 20110225 - Tarea 0000074 */
        public static tpu_CondicionesDeComprasDataset GetListActivas()
        {
            return mz.erp.dataaccess.tpu_CondicionesDeCompras.GetListActivas();
        }
        /* Fin Silvina */

		#endregion
		
		public tpu_CondicionesDeCompras()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_CondicionesDeCompras
		/// </summary>
		public static tpu_CondicionesDeComprasDataset GetList()
		{
			return mz.erp.dataaccess.tpu_CondicionesDeCompras.GetList();
		}

		/// <summary>
		/// Obtiene tabla tpu_CondicionesDeCompras filtrada por las condiciones de bsqueda
		/// </summary>
		/*public static tpu_CondicionesDeComprasDataset GetList(  )
		{
			return mz.erp.dataaccess.tpu_CondicionesDeCompras.GetList(  );
		}*/

		/// <summary>
		/// Crea un tpu_CondicionesDeComprasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_CondicionesDeCompras.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_CondicionesDeCompras que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow GetByPk( string IdCondicionDeCompra )
		{
			tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row = mz.erp.dataaccess.tpu_CondicionesDeCompras.GetByPk( IdCondicionDeCompra  );
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
		/// Obtiene un registro de la tabla tpu_CondicionesDeCompras que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow GetByPk( object IdCondicionDeCompra )
		{
			return GetByPk( ( string )IdCondicionDeCompra );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_CondicionesDeComprasRow.
		/// </summary>
		public static tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow SetRowDefaultValues( tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row )
		{
			row.IdCondicionDeCompra = Util.NewStringId(); 
			row.Descripcion = string.Empty;
			row.Orden = 0;
			row.Recargo = 0;
			row.Activo = false;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 0;
			row.DiasVencimiento = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CondicionesDeComprasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CondicionesDeComprasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CondicionesDeComprasRow a la base de datos.
		/// </summary>
		public static void Update( tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CondicionesDeCompras.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_CondicionesDeComprasDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_CondicionesDeComprasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_CondicionesDeCompras.Rows.Count > 0, "La tabla dataSet.tpu_CondicionesDeComprasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CondicionesDeCompras.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_CondicionesDeCompras.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_CondicionesDeComprasRow.
		/// </summary>
		public static bool RowIsValid( tpu_CondicionesDeComprasDataset.tpu_CondicionesDeComprasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdCondicionDeCompraIsValid( row.IdCondicionDeCompra, out mensaje) )
			{ 
				row.SetColumnError( "IdCondicionDeCompra" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdenIsValid( row.Orden, out mensaje) )
			{ 
				row.SetColumnError( "Orden" , mensaje);
				isValid=false;
			
			}
						
			if ( !RecargoIsValid( row.Recargo, out mensaje) )
			{ 
				row.SetColumnError( "Recargo" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
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
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeCompra.
		/// </summary>
		public static bool IdCondicionDeCompraIsValid( string IdCondicionDeCompra , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCondicionDeCompra. Metodo Sobrecargado
		/// </summary>
		public static bool IdCondicionDeCompraIsValid( string IdCondicionDeCompra)
		{
			string mensaje;
			return IdCondicionDeCompraIsValid( IdCondicionDeCompra, out mensaje );
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
		/// Valida el campo Orden.
		/// </summary>
		public static bool OrdenIsValid( long Orden , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Orden. Metodo Sobrecargado
		/// </summary>
		public static bool OrdenIsValid( long Orden)
		{
			string mensaje;
			return OrdenIsValid( Orden, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

