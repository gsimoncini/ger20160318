namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class st_RepuestoOrdenReparacion : IDisposable
	{
	
		#region Custom Members

		public static st_RepuestoOrdenReparacionDataset GetListByIdInstanciaOrdenReparacion( long IdInstanciaOrdenReparacion)
		{
			return mz.erp.dataaccess.st_RepuestoOrdenReparacion.GetListByIdInstanciaOrdenReparacion( IdInstanciaOrdenReparacion);
		}

		
		#endregion
		
		public st_RepuestoOrdenReparacion()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla st_RepuestoOrdenReparacion
		/// </summary>
		public static st_RepuestoOrdenReparacionDataset GetList()
		{
			return mz.erp.dataaccess.st_RepuestoOrdenReparacion.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla st_RepuestoOrdenReparacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_RepuestoOrdenReparacionDataset GetList( long IdRepuestoOrdenReparacion, long IdInstanciaOrdenReparacion, string IdProducto, string Descripcion, decimal Cantidad, decimal Precio, decimal PrecioSugerido, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, Guid RowId, decimal entregado )
		{
			return mz.erp.dataaccess.st_RepuestoOrdenReparacion.GetList( IdRepuestoOrdenReparacion, IdInstanciaOrdenReparacion, IdProducto);
		}

		/// <summary>
		/// Obtiene tabla st_RepuestoOrdenReparacion filtrada por las condiciones de bsqueda
		/// </summary>
		public static st_RepuestoOrdenReparacionDataset GetList( long IdRepuestoOrdenReparacion, long IdInstanciaOrdenReparacion, string IdProducto)
		{
			return mz.erp.dataaccess.st_RepuestoOrdenReparacion.GetList( IdRepuestoOrdenReparacion, IdInstanciaOrdenReparacion, IdProducto);
		}


		/// <summary>
		/// Crea un st_RepuestoOrdenReparacionRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.st_RepuestoOrdenReparacion.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla st_RepuestoOrdenReparacion que luego puede ser persistido en la base de datos.
		/// </summary>
		public static st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow GetByPk( long IdRepuestoOrdenReparacion )
		{
			st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow row = mz.erp.dataaccess.st_RepuestoOrdenReparacion.GetByPk( IdRepuestoOrdenReparacion  );
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
		/// Obtiene un registro de la tabla st_RepuestoOrdenReparacion que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow GetByPk( object IdRepuestoOrdenReparacion )
		{
			return GetByPk( ( long )IdRepuestoOrdenReparacion );
		}

		/// <summary>
		/// Establece los valores por defecto de st_RepuestoOrdenReparacionRow.
		/// </summary>
		public static st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow SetRowDefaultValues( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow row )
		{
			row.IdRepuestoOrdenReparacion = 0; 
			row.IdInstanciaOrdenReparacion = 0;
			row.IdProducto = string.Empty;
			row.Descripcion = string.Empty;
			row.Cantidad = 0;
			row.Precio = 0;
			row.PrecioSugerido = 0;
			row.FechaCreacion = DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.entregado = 0;
			row.Reservado = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del st_RepuestoOrdenReparacionRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del st_RepuestoOrdenReparacionRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del st_RepuestoOrdenReparacionRow a la base de datos.
		/// </summary>
		public static void Update( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_RepuestoOrdenReparacion.Update( row );
		}

		/// <summary>
		/// Envia los cambios del st_RepuestoOrdenReparacionDataset a la base de datos.
		/// </summary>
		public static void Update( st_RepuestoOrdenReparacionDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.st_RepuestoOrdenReparacion.Rows.Count > 0, "La tabla dataSet.st_RepuestoOrdenReparacionDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_RepuestoOrdenReparacion.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionDataTable a la base de datos.
		/// </summary>
		public static void Update( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.st_RepuestoOrdenReparacion.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un st_RepuestoOrdenReparacionRow.
		/// </summary>
		public static bool RowIsValid( st_RepuestoOrdenReparacionDataset.st_RepuestoOrdenReparacionRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdRepuestoOrdenReparacionIsValid( row.IdRepuestoOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdRepuestoOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdInstanciaOrdenReparacionIsValid( row.IdInstanciaOrdenReparacion, out mensaje) )
			{ 
				row.SetColumnError( "IdInstanciaOrdenReparacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !CantidadIsValid( row.Cantidad, out mensaje) )
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioIsValid( row.Precio, out mensaje) )
			{ 
				row.SetColumnError( "Precio" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioSugeridoIsValid( row.PrecioSugerido, out mensaje) )
			{ 
				row.SetColumnError( "PrecioSugerido" , mensaje);
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
						
			if ( !RowIdIsValid( row.RowId, out mensaje) )
			{ 
				row.SetColumnError( "RowId" , mensaje);
				isValid=false;
			
			}
						
			if ( !entregadoIsValid( row.entregado, out mensaje) )
			{ 
				row.SetColumnError( "entregado" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdRepuestoOrdenReparacion.
		/// </summary>
		public static bool IdRepuestoOrdenReparacionIsValid( long IdRepuestoOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdRepuestoOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdRepuestoOrdenReparacionIsValid( long IdRepuestoOrdenReparacion)
		{
			string mensaje;
			return IdRepuestoOrdenReparacionIsValid( IdRepuestoOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdInstanciaOrdenReparacion.
		/// </summary>
		public static bool IdInstanciaOrdenReparacionIsValid( long IdInstanciaOrdenReparacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdInstanciaOrdenReparacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdInstanciaOrdenReparacionIsValid( long IdInstanciaOrdenReparacion)
		{
			string mensaje;
			return IdInstanciaOrdenReparacionIsValid( IdInstanciaOrdenReparacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdProducto.
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdProductoIsValid( string IdProducto)
		{
			string mensaje;
			return IdProductoIsValid( IdProducto, out mensaje );
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
		/// Valida el campo Cantidad.
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Cantidad. Metodo Sobrecargado
		/// </summary>
		public static bool CantidadIsValid( decimal Cantidad)
		{
			string mensaje;
			return CantidadIsValid( Cantidad, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Precio.
		/// </summary>
		public static bool PrecioIsValid( decimal Precio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Precio. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioIsValid( decimal Precio)
		{
			string mensaje;
			return PrecioIsValid( Precio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioSugerido.
		/// </summary>
		public static bool PrecioSugeridoIsValid( decimal PrecioSugerido , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioSugerido. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioSugeridoIsValid( decimal PrecioSugerido)
		{
			string mensaje;
			return PrecioSugeridoIsValid( PrecioSugerido, out mensaje );
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
		/// Valida el campo entregado.
		/// </summary>
		public static bool entregadoIsValid( decimal entregado , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo entregado. Metodo Sobrecargado
		/// </summary>
		public static bool entregadoIsValid( decimal entregado)
		{
			string mensaje;
			return entregadoIsValid( entregado, out mensaje );
		}		
		

		public void Dispose()
		{
		}
		
	}
}

