namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;

	public class tpu_ProveedoresProductos : IDisposable
	{
	
		#region Custom Members
		public static tpu_ProveedoresProductosDataset GetList(string IdProducto)
		{
			return mz.erp.dataaccess.tpu_ProveedoresProductos.GetList(IdProducto);
		}

		public static tpu_ProveedoresProductosDataset GetListByIdProducto(string IdProducto)
		{
			return mz.erp.dataaccess.tpu_ProveedoresProductos.GetListByIdProducto(IdProducto);
		}

		public static tsh_ProductosExDataset.tpu_ProveedoresProductosRow SetRowDefaultValues( tsh_ProductosExDataset.tpu_ProveedoresProductosRow row )
		{
			row.IdProveedor = Util.NewStringId(); 
			row.IdProducto = Util.NewStringId(); 
			row.PrecioDeCosto = 0;
			row.IdMonedaPrecioDeCosto = string.Empty;
			row.IdCotizacionPrecioDeCosto = string.Empty;
			row.IdFuenteDeCambio = string.Empty;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.CampoAuxiliar4 = string.Empty;
			row.CampoAuxiliar5 = 0;
			row.Bonificacion1 = 0;
			row.Bonificacion2 = 0;
			row.Bonificacion3 = 0;
			row.Bonificacion4 = 0;
			row.Bonificacion5 = 0;
			row.Observaciones = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
			row.IdConexionCreacion = Security.IdConexion;
			//row.UltimaModificacion = null;
			row.IdConexionUltimaModificacion = Security.IdConexion;
			row.IdReservado = 0;
			row.RowId = Guid.Empty;
			row.IdSucursal = Security.IdSucursal;
			row.IdEmpresa = Security.IdEmpresa;
			row.PorcentajeBonificacion1 = 0;
			row.PorcentajeBonificacion2 = 0;
			row.PorcentajeBonificacion3 = 0;
			row.PorcentajeBonificacion4 = 0;
			row.PorcentajeBonificacion5 = 0;
			row.PrecioDeCostoUltimaCompra = 0;
			row.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
			row.FechaUltimaModificacionPrecioDeCostoUltimaCompra = mz.erp.businessrules.Sistema.DateTime.Now;
			row.PrecioDeCostoFinal = 0;
			row.IdCotizacionProveedor = string.Empty;
			row.IdFuenteDeCambioProveedor = string.Empty;
			row.IdMonedaProveedor = string.Empty;
			row.ValorCotizacionProveedor = 0;
			row.BonificacionAcumulativa = true;

			return row;
		}

		#endregion
		
		public tpu_ProveedoresProductos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tpu_ProveedoresProductos
		/// </summary>
		public static tpu_ProveedoresProductosDataset GetList()
		{
			return mz.erp.dataaccess.tpu_ProveedoresProductos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tpu_ProveedoresProductos filtrada por las condiciones de bsqueda
		/// </summary>
		public static tpu_ProveedoresProductosDataset GetList( string IdProveedor, string IdProducto, string IdMonedaPrecioDeCosto, string IdCotizacionPrecioDeCosto, string IdFuenteDeCambio )
		{
			return mz.erp.dataaccess.tpu_ProveedoresProductos.GetList( IdProveedor, IdProducto, IdMonedaPrecioDeCosto, IdCotizacionPrecioDeCosto, IdFuenteDeCambio );
		}

		/// <summary>
		/// Crea un tpu_ProveedoresProductosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tpu_ProveedoresProductos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tpu_ProveedoresProductos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow GetByPk( string IdProveedor, string IdProducto )
		{
			tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row = mz.erp.dataaccess.tpu_ProveedoresProductos.GetByPk( IdProveedor, IdProducto  );
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
		/// Obtiene un registro de la tabla tpu_ProveedoresProductos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow GetByPk( object IdProveedor, object IdProducto )
		{
			return GetByPk( ( string )IdProveedor, ( string )IdProducto );
		}

		/// <summary>
		/// Establece los valores por defecto de tpu_ProveedoresProductosRow.
		/// </summary>
		public static tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow SetRowDefaultValues( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row )
		{
			row.IdProveedor = Util.NewStringId(); 
			row.IdProducto = Util.NewStringId(); 
			row.PrecioDeCosto = 0;
			row.IdMonedaPrecioDeCosto = string.Empty;
			row.IdCotizacionPrecioDeCosto = string.Empty;
			row.IdFuenteDeCambio = string.Empty;
			row.CampoAuxiliar1 = string.Empty;
			row.CampoAuxiliar2 = string.Empty;
			row.CampoAuxiliar3 = string.Empty;
			row.CampoAuxiliar4 = string.Empty;
			row.CampoAuxiliar5 = 0;
			row.Bonificacion1 = 0;
			row.Bonificacion2 = 0;
			row.Bonificacion3 = 0;
			row.Bonificacion4 = 0;
			row.Bonificacion5 = 0;
			row.Observaciones = string.Empty;
			row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
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
		/// Envia los cambios del tpu_ProveedoresProductosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosRow a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresProductos.Update( row );
		}

		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosDataset a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresProductosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tpu_ProveedoresProductos.Rows.Count > 0, "La tabla dataSet.tpu_ProveedoresProductosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresProductos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosDataTable a la base de datos.
		/// </summary>
		public static void Update( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tpu_ProveedoresProductos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tpu_ProveedoresProductosRow.
		/// </summary>
		public static bool RowIsValid( tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProveedorIsValid( row.IdProveedor, out mensaje) )
			{ 
				row.SetColumnError( "IdProveedor" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeCostoIsValid( row.PrecioDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdMonedaPrecioDeCostoIsValid( row.IdMonedaPrecioDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "IdMonedaPrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCotizacionPrecioDeCostoIsValid( row.IdCotizacionPrecioDeCosto, out mensaje) )
			{ 
				row.SetColumnError( "IdCotizacionPrecioDeCosto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdFuenteDeCambioIsValid( row.IdFuenteDeCambio, out mensaje) )
			{ 
				row.SetColumnError( "IdFuenteDeCambio" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar1IsValid( row.CampoAuxiliar1, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar1" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar2IsValid( row.CampoAuxiliar2, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar2" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar3IsValid( row.CampoAuxiliar3, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar3" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar4IsValid( row.CampoAuxiliar4, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar4" , mensaje);
				isValid=false;
			
			}
						
			if ( !CampoAuxiliar5IsValid( row.CampoAuxiliar5, out mensaje) )
			{ 
				row.SetColumnError( "CampoAuxiliar5" , mensaje);
				isValid=false;
			
			}
						
			if ( !Bonificacion1IsValid( row.Bonificacion1, out mensaje) )
			{ 
				row.SetColumnError( "Bonificacion1" , mensaje);
				isValid=false;
			
			}
						
			if ( !Bonificacion2IsValid( row.Bonificacion2, out mensaje) )
			{ 
				row.SetColumnError( "Bonificacion2" , mensaje);
				isValid=false;
			
			}
						
			if ( !Bonificacion3IsValid( row.Bonificacion3, out mensaje) )
			{ 
				row.SetColumnError( "Bonificacion3" , mensaje);
				isValid=false;
			
			}
						
			if ( !Bonificacion4IsValid( row.Bonificacion4, out mensaje) )
			{ 
				row.SetColumnError( "Bonificacion4" , mensaje);
				isValid=false;
			
			}
						
			if ( !Bonificacion5IsValid( row.Bonificacion5, out mensaje) )
			{ 
				row.SetColumnError( "Bonificacion5" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObservacionesIsValid( row.Observaciones, out mensaje) )
			{ 
				row.SetColumnError( "Observaciones" , mensaje);
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
		/// Valida el campo IdProveedor.
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProveedor. Metodo Sobrecargado
		/// </summary>
		public static bool IdProveedorIsValid( string IdProveedor)
		{
			string mensaje;
			return IdProveedorIsValid( IdProveedor, out mensaje );
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
		/// Valida el campo PrecioDeCosto.
		/// </summary>
		public static bool PrecioDeCostoIsValid( decimal PrecioDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeCostoIsValid( decimal PrecioDeCosto)
		{
			string mensaje;
			return PrecioDeCostoIsValid( PrecioDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdMonedaPrecioDeCosto.
		/// </summary>
		public static bool IdMonedaPrecioDeCostoIsValid( string IdMonedaPrecioDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdMonedaPrecioDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool IdMonedaPrecioDeCostoIsValid( string IdMonedaPrecioDeCosto)
		{
			string mensaje;
			return IdMonedaPrecioDeCostoIsValid( IdMonedaPrecioDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCotizacionPrecioDeCosto.
		/// </summary>
		public static bool IdCotizacionPrecioDeCostoIsValid( string IdCotizacionPrecioDeCosto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCotizacionPrecioDeCosto. Metodo Sobrecargado
		/// </summary>
		public static bool IdCotizacionPrecioDeCostoIsValid( string IdCotizacionPrecioDeCosto)
		{
			string mensaje;
			return IdCotizacionPrecioDeCostoIsValid( IdCotizacionPrecioDeCosto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio.
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( string IdFuenteDeCambio , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdFuenteDeCambio. Metodo Sobrecargado
		/// </summary>
		public static bool IdFuenteDeCambioIsValid( string IdFuenteDeCambio)
		{
			string mensaje;
			return IdFuenteDeCambioIsValid( IdFuenteDeCambio, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1.
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar1. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar1IsValid( string CampoAuxiliar1)
		{
			string mensaje;
			return CampoAuxiliar1IsValid( CampoAuxiliar1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2.
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar2. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar2IsValid( string CampoAuxiliar2)
		{
			string mensaje;
			return CampoAuxiliar2IsValid( CampoAuxiliar2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3.
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar3. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar3IsValid( string CampoAuxiliar3)
		{
			string mensaje;
			return CampoAuxiliar3IsValid( CampoAuxiliar3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar4.
		/// </summary>
		public static bool CampoAuxiliar4IsValid( string CampoAuxiliar4 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar4. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar4IsValid( string CampoAuxiliar4)
		{
			string mensaje;
			return CampoAuxiliar4IsValid( CampoAuxiliar4, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CampoAuxiliar5.
		/// </summary>
		public static bool CampoAuxiliar5IsValid( decimal CampoAuxiliar5 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CampoAuxiliar5. Metodo Sobrecargado
		/// </summary>
		public static bool CampoAuxiliar5IsValid( decimal CampoAuxiliar5)
		{
			string mensaje;
			return CampoAuxiliar5IsValid( CampoAuxiliar5, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bonificacion1.
		/// </summary>
		public static bool Bonificacion1IsValid( decimal Bonificacion1 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion1. Metodo Sobrecargado
		/// </summary>
		public static bool Bonificacion1IsValid( decimal Bonificacion1)
		{
			string mensaje;
			return Bonificacion1IsValid( Bonificacion1, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bonificacion2.
		/// </summary>
		public static bool Bonificacion2IsValid( decimal Bonificacion2 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion2. Metodo Sobrecargado
		/// </summary>
		public static bool Bonificacion2IsValid( decimal Bonificacion2)
		{
			string mensaje;
			return Bonificacion2IsValid( Bonificacion2, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bonificacion3.
		/// </summary>
		public static bool Bonificacion3IsValid( decimal Bonificacion3 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion3. Metodo Sobrecargado
		/// </summary>
		public static bool Bonificacion3IsValid( decimal Bonificacion3)
		{
			string mensaje;
			return Bonificacion3IsValid( Bonificacion3, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bonificacion4.
		/// </summary>
		public static bool Bonificacion4IsValid( decimal Bonificacion4 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion4. Metodo Sobrecargado
		/// </summary>
		public static bool Bonificacion4IsValid( decimal Bonificacion4)
		{
			string mensaje;
			return Bonificacion4IsValid( Bonificacion4, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Bonificacion5.
		/// </summary>
		public static bool Bonificacion5IsValid( decimal Bonificacion5 , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Bonificacion5. Metodo Sobrecargado
		/// </summary>
		public static bool Bonificacion5IsValid( decimal Bonificacion5)
		{
			string mensaje;
			return Bonificacion5IsValid( Bonificacion5, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Observaciones.
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Observaciones. Metodo Sobrecargado
		/// </summary>
		public static bool ObservacionesIsValid( string Observaciones)
		{
			string mensaje;
			return ObservacionesIsValid( Observaciones, out mensaje );
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

