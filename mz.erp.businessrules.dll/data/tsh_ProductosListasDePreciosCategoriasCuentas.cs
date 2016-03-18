namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
    using System.Collections;

	public class tsh_ProductosListasDePreciosCategoriasCuentas : IDisposable
	{
	
		#region Custom Members
		
        public static ArrayList GetListEx()
		{
            ArrayList result = new ArrayList();
            DataSet data = mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.GetListEx();
            foreach (DataRow row in data.Tables["tsh_ProductosListasDePreciosCategoriasCuentas"].Rows)
            {
                ProductosCategoriasCuentas pc = new ProductosCategoriasCuentas();
                pc.CategoriaProducto = row["CategoriaProducto"].ToString();
                pc.CategoriaCuenta = row["CategoriaCuenta"].ToString();
                pc.IdNomenclaturaProducto = row["IdNomenclaturaProducto"].ToString();
                pc.IdNomenclaturaCuenta = row["IdNomenclaturaCuenta"].ToString();
                pc.IdListaDePrecios = row["IdListaDePrecio"].ToString();
                pc.ListaDePrecios = row["ListaDePrecios"].ToString();
                result.Add(pc);
            }
            return result;
		}

        public static string GetListaDePrecios(string JerarquiaCuentas, string JerarquiaProductos)
        {
            return mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.GetListaDePrecios(JerarquiaCuentas, JerarquiaProductos);
        }

		#endregion
		
		public tsh_ProductosListasDePreciosCategoriasCuentas()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosListasDePreciosCategoriasCuentas
		/// </summary>
		public static tsh_ProductosListasDePreciosCategoriasCuentasDataset GetList()
		{
			return mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_ProductosListasDePreciosCategoriasCuentas filtrada por las condiciones de bsqueda
		/// </summary>
        public static tsh_ProductosListasDePreciosCategoriasCuentasDataset GetList(string IdNomenclaturaCuenta, string IdNomenclaturaProducto, string IdListaDePrecio)
		{
			return mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.GetList( IdNomenclaturaCuenta, IdNomenclaturaProducto, IdListaDePrecio );
		}

		/// <summary>
		/// Crea un tsh_ProductosListasDePreciosCategoriasCuentasRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosListasDePreciosCategoriasCuentas que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow GetByPk( string IdNomenclaturaCuenta, string IdNomenclaturaProducto )
		{
		   tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow row = mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.GetByPk( IdNomenclaturaCuenta, IdNomenclaturaProducto  );
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
		/// Obtiene un registro de la tabla tsh_ProductosListasDePreciosCategoriasCuentas que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow GetByPk( object IdNomenclaturaCuenta, object IdNomenclaturaProducto )
		{
			return GetByPk( ( string )IdNomenclaturaCuenta, ( string )IdNomenclaturaProducto );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosListasDePreciosCategoriasCuentasRow.
		/// </summary>
		public static tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow SetRowDefaultValues( tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow row )
		{
            row.IdNomenclaturaCuenta = string.Empty;
            row.IdNomenclaturaProducto = string.Empty; 
			row.IdListaDePrecio = string.Empty;
            row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.RowId = Guid.Empty;
			row.IdEmpresa = 1;
			row.IdSucursal = 1;
			row.IdReservado = 0;

			return row;
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosCategoriasCuentasRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosCategoriasCuentasRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosCategoriasCuentasRow a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosCategoriasCuentasDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosListasDePreciosCategoriasCuentasDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_ProductosListasDePreciosCategoriasCuentas.Rows.Count > 0, "La tabla dataSet.tsh_ProductosListasDePreciosCategoriasCuentasDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_ProductosListasDePreciosCategoriasCuentas.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosListasDePreciosCategoriasCuentasRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosListasDePreciosCategoriasCuentasDataset.tsh_ProductosListasDePreciosCategoriasCuentasRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdNomenclaturaCuentaIsValid( row.IdNomenclaturaCuenta, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclaturaCuenta" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdNomenclaturaProductoIsValid( row.IdNomenclaturaProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdNomenclaturaProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdListaDePrecioIsValid( row.IdListaDePrecio, out mensaje) )
			{ 
				row.SetColumnError( "IdListaDePrecio" , mensaje);
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
						
			if ( !IdReservadoIsValid( row.IdReservado, out mensaje) )
			{ 
				row.SetColumnError( "IdReservado" , mensaje);
				isValid=false;
			
			}
			;
			
			return isValid;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclaturaCuenta.
		/// </summary>
		public static bool IdNomenclaturaCuentaIsValid( string IdNomenclaturaCuenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclaturaCuenta. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclaturaCuentaIsValid( string IdNomenclaturaCuenta)
		{
			string mensaje;
			return IdNomenclaturaCuentaIsValid( IdNomenclaturaCuenta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdNomenclaturaProducto.
		/// </summary>
		public static bool IdNomenclaturaProductoIsValid( string IdNomenclaturaProducto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdNomenclaturaProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdNomenclaturaProductoIsValid( string IdNomenclaturaProducto)
		{
			string mensaje;
			return IdNomenclaturaProductoIsValid( IdNomenclaturaProducto, out mensaje );
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
		

		public void Dispose()
		{
		}
		
	}
}

