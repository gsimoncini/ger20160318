namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_ProductosListasDePrecios : IDisposable
	{
	
		#region Custom Members

		//Sabrina 20100715 - Tarea 794
		public static System.Data.DataSet SearchEx(string IdProducto, string IdCondicionDeVentaVisualizacion)
		{
			return mz.erp.dataaccess.tsh_ProductosListasDePrecios.SearchEx(IdProducto, IdCondicionDeVentaVisualizacion);
		}
		//Fin Sabrina 20100715 - Tarea 794

        //Sabrina: Tarea 1068. 20110317
        public static tsh_ProductosListasDePreciosDataset GetByIdProducto(string IdProducto)
        {
            return mz.erp.dataaccess.tsh_ProductosListasDePrecios.GetByIdProducto(IdProducto);
        }
        //Fin Sabrina: Tarea 1068. 20110317


		#endregion
		
		public tsh_ProductosListasDePrecios()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosListasDePrecios
		/// </summary>
		public static tsh_ProductosListasDePreciosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosListasDePrecios.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_ProductosListasDePrecios filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_ProductosListasDePreciosDataset GetList( string IdProducto, string IdListaDePrecio, string ModoDeAplicacion, decimal Coeficiente, decimal MaxDescuento, decimal MaxDescuentoPorcentual, decimal PrecioDeVentaBruto, decimal PrecioDeVentaBrutoConImpuesto, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal )
		{
			return mz.erp.dataaccess.tsh_ProductosListasDePrecios.GetList( IdProducto, IdListaDePrecio, ModoDeAplicacion, Coeficiente, MaxDescuento, MaxDescuentoPorcentual, PrecioDeVentaBruto, PrecioDeVentaBrutoConImpuesto, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal );
		}

		/// <summary>
		/// Crea un tsh_ProductosListasDePreciosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosListasDePrecios.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosListasDePrecios que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow GetByPk( string IdProducto, string IdListaDePrecio )
		{
			tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow row = mz.erp.dataaccess.tsh_ProductosListasDePrecios.GetByPk( IdProducto, IdListaDePrecio  );
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
		/// Obtiene un registro de la tabla tsh_ProductosListasDePrecios que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow GetByPk( object IdProducto, object IdListaDePrecio )
		{
			return GetByPk( ( string )IdProducto, ( string )IdListaDePrecio );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosListasDePreciosRow.
		/// </summary>
		public static tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow SetRowDefaultValues( tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.IdListaDePrecio = Util.NewStringId(); 
			row.ModoDeAplicacion = string.Empty;
			row.Coeficiente = 0;
			row.MaxDescuento = 0;
			row.MaxDescuentoPorcentual = 0;
			row.PrecioDeVentaBruto = 0;
			row.PrecioDeVentaBrutoConImpuesto = 0;
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
		/// Envia los cambios del tsh_ProductosListasDePreciosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosListasDePrecios.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosListasDePreciosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosListasDePrecios.Rows.Count > 0, "La tabla dataSet.tsh_ProductosListasDePreciosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosListasDePrecios.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosListasDePrecios.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosListasDePreciosRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdListaDePrecioIsValid( row.IdListaDePrecio, out mensaje) )
			{ 
				row.SetColumnError( "IdListaDePrecio" , mensaje);
				isValid=false;
			
			}
						
			if ( !ModoDeAplicacionIsValid( row.ModoDeAplicacion, out mensaje) )
			{ 
				row.SetColumnError( "ModoDeAplicacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !CoeficienteIsValid( row.Coeficiente, out mensaje) )
			{ 
				row.SetColumnError( "Coeficiente" , mensaje);
				isValid=false;
			
			}
						
			if ( !MaxDescuentoIsValid( row.MaxDescuento, out mensaje) )
			{ 
				row.SetColumnError( "MaxDescuento" , mensaje);
				isValid=false;
			
			}
						
			if ( !MaxDescuentoPorcentualIsValid( row.MaxDescuentoPorcentual, out mensaje) )
			{ 
				row.SetColumnError( "MaxDescuentoPorcentual" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaBrutoIsValid( row.PrecioDeVentaBruto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaBruto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaBrutoConImpuestoIsValid( row.PrecioDeVentaBrutoConImpuesto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaBrutoConImpuesto" , mensaje);
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
		/// Valida el campo ModoDeAplicacion.
		/// </summary>
		public static bool ModoDeAplicacionIsValid( string ModoDeAplicacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ModoDeAplicacion. Metodo Sobrecargado
		/// </summary>
		public static bool ModoDeAplicacionIsValid( string ModoDeAplicacion)
		{
			string mensaje;
			return ModoDeAplicacionIsValid( ModoDeAplicacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Coeficiente.
		/// </summary>
		public static bool CoeficienteIsValid( decimal Coeficiente , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="El precio de Lista no puede ser inferior al precio de venta neto.";
			return !(Coeficiente < 0);
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
		/// Valida el campo MaxDescuento.
		/// </summary>
		public static bool MaxDescuentoIsValid( decimal MaxDescuento , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaxDescuento. Metodo Sobrecargado
		/// </summary>
		public static bool MaxDescuentoIsValid( decimal MaxDescuento)
		{
			string mensaje;
			return MaxDescuentoIsValid( MaxDescuento, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MaxDescuentoPorcentual.
		/// </summary>
		public static bool MaxDescuentoPorcentualIsValid( decimal MaxDescuentoPorcentual , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MaxDescuentoPorcentual. Metodo Sobrecargado
		/// </summary>
		public static bool MaxDescuentoPorcentualIsValid( decimal MaxDescuentoPorcentual)
		{
			string mensaje;
			return MaxDescuentoPorcentualIsValid( MaxDescuentoPorcentual, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBruto.
		/// </summary>
		public static bool PrecioDeVentaBrutoIsValid( decimal PrecioDeVentaBruto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBruto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeVentaBrutoIsValid( decimal PrecioDeVentaBruto)
		{
			string mensaje;
			return PrecioDeVentaBrutoIsValid( PrecioDeVentaBruto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBrutoConImpuesto.
		/// </summary>
		public static bool PrecioDeVentaBrutoConImpuestoIsValid( decimal PrecioDeVentaBrutoConImpuesto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBrutoConImpuesto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeVentaBrutoConImpuestoIsValid( decimal PrecioDeVentaBrutoConImpuesto)
		{
			string mensaje;
			return PrecioDeVentaBrutoConImpuestoIsValid( PrecioDeVentaBrutoConImpuesto, out mensaje );
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

