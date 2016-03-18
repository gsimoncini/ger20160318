namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tsh_CombosDet : IDisposable
	{
	
		#region Custom Members
        public static tsh_CombosDetDataset GetByIdProducto(string IdProducto)
        {
            return mz.erp.dataaccess.tsh_CombosDet.GetByIdProducto(IdProducto);
        }

        public static tsh_CombosDetDataset GetByIdProductoReferencia(string IdProductoReferencia)
        {
            return mz.erp.dataaccess.tsh_CombosDet.GetByIdProductoReferencia(IdProductoReferencia);
        }

        public static void ActualizarPreciosProductosCombo(string IdTransaction, string IdProductoReferencia, decimal PrecioDeCostoRef, decimal PrecioDeVentaBrutoOriginal, string IdMonedaCierrePrecioDeCostoRef, string IdMonedaCierrePrecioDeVentaBruto, string IdCotizacionCierrePrecioDeCostoRef, string IdCotizacionCierrePrecioDeVentaBruto)
        {
            mz.erp.dataaccess.tsh_CombosDet.ActualizarPreciosProductosCombo(IdTransaction, IdProductoReferencia, PrecioDeCostoRef, PrecioDeVentaBrutoOriginal, IdMonedaCierrePrecioDeCostoRef, IdMonedaCierrePrecioDeVentaBruto, IdCotizacionCierrePrecioDeCostoRef, IdCotizacionCierrePrecioDeVentaBruto);
        }

        public static System.Data.DataSet SearchEx(string IdProducto)
        {
            return mz.erp.dataaccess.tsh_CombosDet.SearchEx(IdProducto);
        }
        #endregion
		
		public tsh_CombosDet()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_CombosDet
		/// </summary>
		public static tsh_CombosDetDataset GetList()
		{
			return mz.erp.dataaccess.tsh_CombosDet.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_CombosDet filtrada por las condiciones de bsqueda
		/// </summary>
		public static tsh_CombosDetDataset GetList( string IdProducto, long Ordinal,string IdProductoReferencia, decimal Cantidad, decimal DescuentoCombo, decimal DescuentoComboPorcentual, decimal PrecioDeVentaBrutoOriginal, decimal PrecioDeVentaBruto, decimal PrecioDeCostoRef, DateTime FechaUltimaModificacionPrecioDeCosto, DateTime FechaUltimaModificacionPrecioDeVenta, DateTime FechaCreacion, long IdConexionCreacion, byte[] UltimaModificacion, long IdConexionUltimaModificacion, long IdReservado, Guid RowId, long IdEmpresa, long IdSucursal )
		{
            return mz.erp.dataaccess.tsh_CombosDet.GetList(IdProducto, Ordinal, IdProductoReferencia, Cantidad, DescuentoCombo, DescuentoComboPorcentual, PrecioDeVentaBrutoOriginal, PrecioDeVentaBruto, PrecioDeCostoRef, FechaUltimaModificacionPrecioDeCosto, FechaUltimaModificacionPrecioDeVenta, FechaCreacion, IdConexionCreacion, UltimaModificacion, IdConexionUltimaModificacion, IdReservado, RowId, IdEmpresa, IdSucursal);
		}

		/// <summary>
		/// Crea un tsh_CombosDetRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_CombosDetDataset.tsh_CombosDetRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_CombosDet.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_CombosDet que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_CombosDetDataset.tsh_CombosDetRow GetByPk( string IdProducto, long Ordinal )
		{
		   tsh_CombosDetDataset.tsh_CombosDetRow row = mz.erp.dataaccess.tsh_CombosDet.GetByPk( IdProducto, Ordinal  );
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
		/// Obtiene un registro de la tabla tsh_CombosDet que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_CombosDetDataset.tsh_CombosDetRow GetByPk( object IdProducto, object Ordinal )
		{
			return GetByPk( ( string )IdProducto, ( long )Ordinal );
		}

		/// <summary>
		/// Establece los valores por defecto de tsh_CombosDetRow.
		/// </summary>
		public static tsh_CombosDetDataset.tsh_CombosDetRow SetRowDefaultValues( tsh_CombosDetDataset.tsh_CombosDetRow row )
		{
			row.IdProducto = Util.NewStringId(); 
			row.Ordinal = 0;
            row.IdProductoReferencia = string.Empty;
			row.Cantidad = 0;
			row.DescuentoCombo = 0;
			row.DescuentoComboPorcentual = 0;
			row.PrecioDeVentaBrutoOriginal = 0;
			row.PrecioDeVentaBruto = 0;
			row.PrecioDeCostoRef = 0;
			row.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
			row.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
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
		/// Envia los cambios del tsh_CombosDetRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_CombosDetDataset.tsh_CombosDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CombosDetRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_CombosDetDataset.tsh_CombosDetRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CombosDetRow a la base de datos.
		/// </summary>
		public static void Update( tsh_CombosDetDataset.tsh_CombosDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_CombosDet.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tsh_CombosDetDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_CombosDetDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_CombosDet.Rows.Count > 0, "La tabla dataSet.tsh_CombosDetDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_CombosDet.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_CombosDetDataset.tsh_CombosDetDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_CombosDetDataset.tsh_CombosDetDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_CombosDet.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_CombosDetRow.
		/// </summary>
		public static bool RowIsValid( tsh_CombosDetDataset.tsh_CombosDetRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !OrdinalIsValid( row.Ordinal, out mensaje) )
			{ 
				row.SetColumnError( "Ordinal" , mensaje);
				isValid=false;
			
			}

            if (!IdProductoReferenciaIsValid(row.IdProductoReferencia, out mensaje))
            {
                row.SetColumnError("IdProductoReferencia", mensaje);
                isValid = false;

            }
            
            if (!CantidadIsValid(row.Cantidad, out mensaje))
			{ 
				row.SetColumnError( "Cantidad" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescuentoComboIsValid( row.DescuentoCombo, out mensaje) )
			{ 
				row.SetColumnError( "DescuentoCombo" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescuentoComboPorcentualIsValid( row.DescuentoComboPorcentual, out mensaje) )
			{ 
				row.SetColumnError( "DescuentoComboPorcentual" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaBrutoOriginalIsValid( row.PrecioDeVentaBrutoOriginal, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaBrutoOriginal" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaBrutoIsValid( row.PrecioDeVentaBruto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaBruto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeCostoRefIsValid( row.PrecioDeCostoRef, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCostoRef" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaUltimaModificacionPrecioDeCostoIsValid( row.FechaUltimaModificacionPrecioDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "FechaUltimaModificacionPrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaUltimaModificacionPrecioDeVentaIsValid( row.FechaUltimaModificacionPrecioDeVenta, out mensaje) )
			{ 
				row.SetColumnError( "FechaUltimaModificacionPrecioDeVenta" , mensaje);
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
		/// Valida el campo Ordinal.
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Ordinal. Metodo Sobrecargado
		/// </summary>
		public static bool OrdinalIsValid( long Ordinal)
		{
			string mensaje;
			return OrdinalIsValid( Ordinal, out mensaje );
		}

        /// <summary>
        /// Valida el campo IdProductoReferencia.
        /// </summary>
        public static bool IdProductoReferenciaIsValid(string IdProductoReferencia, out string mensaje)
        {
            //Agregar cdigo de validacin
            mensaje = "";
            return true;
        }

        /// <summary>
        /// Valida el campo IdProductoReferencia. Metodo Sobrecargado
        /// </summary>
        public static bool IdProductoReferenciaIsValid(string IdProductoReferencia)
        {
            string mensaje;
            return IdProductoReferenciaIsValid(IdProductoReferencia, out mensaje);
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
		/// Valida el campo DescuentoCombo.
		/// </summary>
		public static bool DescuentoComboIsValid( decimal DescuentoCombo , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescuentoCombo. Metodo Sobrecargado
		/// </summary>
		public static bool DescuentoComboIsValid( decimal DescuentoCombo)
		{
			string mensaje;
			return DescuentoComboIsValid( DescuentoCombo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DescuentoComboPorcentual.
		/// </summary>
		public static bool DescuentoComboPorcentualIsValid( decimal DescuentoComboPorcentual , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescuentoComboPorcentual. Metodo Sobrecargado
		/// </summary>
		public static bool DescuentoComboPorcentualIsValid( decimal DescuentoComboPorcentual)
		{
			string mensaje;
			return DescuentoComboPorcentualIsValid( DescuentoComboPorcentual, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBrutoOriginal.
		/// </summary>
		public static bool PrecioDeVentaBrutoOriginalIsValid( decimal PrecioDeVentaBrutoOriginal , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeVentaBrutoOriginal. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeVentaBrutoOriginalIsValid( decimal PrecioDeVentaBrutoOriginal)
		{
			string mensaje;
			return PrecioDeVentaBrutoOriginalIsValid( PrecioDeVentaBrutoOriginal, out mensaje );
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
		/// Valida el campo PrecioDeCostoRef.
		/// </summary>
		public static bool PrecioDeCostoRefIsValid( decimal PrecioDeCostoRef , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeCostoRef. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeCostoRefIsValid( decimal PrecioDeCostoRef)
		{
			string mensaje;
			return PrecioDeCostoRefIsValid( PrecioDeCostoRef, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaUltimaModificacionPrecioDeCosto.
		/// </summary>
		public static bool FechaUltimaModificacionPrecioDeCostoIsValid( DateTime FechaUltimaModificacionPrecioDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaUltimaModificacionPrecioDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool FechaUltimaModificacionPrecioDeCostoIsValid( DateTime FechaUltimaModificacionPrecioDeCosto)
		{
			string mensaje;
			return FechaUltimaModificacionPrecioDeCostoIsValid( FechaUltimaModificacionPrecioDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaUltimaModificacionPrecioDeVenta.
		/// </summary>
		public static bool FechaUltimaModificacionPrecioDeVentaIsValid( DateTime FechaUltimaModificacionPrecioDeVenta , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaUltimaModificacionPrecioDeVenta. Metodo Sobrecargado
		/// </summary>
		public static bool FechaUltimaModificacionPrecioDeVentaIsValid( DateTime FechaUltimaModificacionPrecioDeVenta)
		{
			string mensaje;
			return FechaUltimaModificacionPrecioDeVentaIsValid( FechaUltimaModificacionPrecioDeVenta, out mensaje );
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

