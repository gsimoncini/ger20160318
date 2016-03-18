namespace mz.erp.businessrules 
{
	using System;
	using System.Data;
	using System.Drawing;
	using System.Text.RegularExpressions;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.dataaccess;
	using System.Collections;
	using System.Text;
	using mz.erp.businessrules.comprobantes;

	

	public class tsh_ProductosEx : IDisposable
	{
	
		public class ProductosSucursales: CollectionBase
		{
			public ProductosSucursales()
			{
			}

			public void Add(object sender)
			{
				base.List.Add( sender );				
			}
		}


		#region Custom Members
		/// <summary>
		/// Obtiene un dataset de productos con sus tablas relacionadas
		/// </summary>
		/// <returns></returns>
		[ atMethodNewRow ]
		public static tsh_ProductosExDataset NewDataset()
		{
			tsh_ProductosExDataset data = mz.erp.dataaccess.tsh_ProductosEx.NewDataset();
			try
			{
				
				tsh_ProductosExDataset.tsh_ProductosRow rowProducto = mz.erp.dataaccess.tsh_ProductosEx.NewRowProductos( data );
				SetRowProductosDefaultValues( rowProducto );
				//data = (tsh_ProductosExDataset)mz.erp.dataaccess.tsh_ProductosEx.AddRowProductos( data,  );
				data.tsh_Productos.Rows.Add( rowProducto );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			data = (tsh_ProductosExDataset)mz.erp.businessrules.tsh_ProductosEx.AddNewRowSucursales( data, Security.IdSucursal );
			return data;
		}

		public static tsh_ProductosExDataset.tsh_ProductosRow SetRowProductosDefaultValues( tsh_ProductosExDataset.tsh_ProductosRow row )
		{
			return (tsh_ProductosExDataset.tsh_ProductosRow)mz.erp.businessrules.tsh_Productos.SetRowDefaultValues( (System.Data.DataRow)row );
		}
				
		public static tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow SetRowProductosDefaultValues( tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow row )
		{
			return (tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow)mz.erp.businessrules.tsh_ProductosAuxiliares.SetRowDefaultValues( (System.Data.DataRow)row );
		}

		public static tsh_ProductosExDataset.tsh_ProductosRow GetRowProductos( tsh_ProductosExDataset data )
		{
			if (data.tsh_Productos.Rows.Count > 0)
			{
				return (tsh_ProductosExDataset.tsh_ProductosRow)data.tsh_Productos.Rows[0];
			}
			else
			{
				return null;
			}
		}
		
		public static System.Data.DataRow GetDataRowProductos( System.Data.DataSet data )
		{
			return GetDataRowProductos( (tsh_ProductosExDataset)data);
		}

		public static System.Data.DataRow GetDataRowProductos( tsh_ProductosExDataset data )
		{
			if (data.tsh_Productos.Rows.Count > 0)
			{
				return data.tsh_Productos.Rows[0];
			}
			else
			{
				return null;
			}
		}
		public static System.Data.DataRow GetDataRowProductosAuxiliares( System.Data.DataSet data )
		{
			return GetDataRowProductosAuxiliares( (tsh_ProductosExDataset)data);
		}
		public static System.Data.DataRow GetDataRowProductosAuxiliares( tsh_ProductosExDataset data )
		{
			if (data.tsh_ProductosAuxiliares.Rows.Count > 0)
			{
				return data.tsh_ProductosAuxiliares.Rows[0];
			}
			else
			{
				return null;
			}
		}		
		//Busqueda de productos por jerarquias
	
		/*public static System.Data.DataTable SearchProductByJerarquia(string Jerarquia,long IdSucursal, long IdEmpresa, bool Activo)
		{
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductByJerarquia(Jerarquia, IdSucursal, IdEmpresa, Activo);
		}*/
		
		public static System.Data.DataTable SearchProductosSinMovimientos(string Descripcion, string DescripcionCorta, string DescripcionLarga, string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa, string IdCondicionDeVentaVisualizacion, DateTime FechaDesde, DateTime FechaHasta, string TiposDeComprobantes)
		{						
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			//string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			//if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }				
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductosSinMovimientos(Descripcion, DescripcionCorta, DescripcionLarga, Jerarquia1, Jerarquia2, Jerarquia3, Jerarquia4, Jerarquia5, Jerarquia6, Jerarquia7, Jerarquia8, IdSucursal, IdEmpresa, IdMonedaReferencia, /*IdFuenteDeCambio,*/ IdCondicionDeVentaVisualizacion, FechaDesde, FechaHasta, TiposDeComprobantes);
		}

        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        public static System.Data.DataTable SearchProductosCompras(string Codigo, string CodigoSecundario, string Descripcion, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5, string CampoAuxiliar6, string IdCondicionDeVentaVisualizacion, string Jerarquia1, string Jerarquia2, string Jerarquia3, string Jerarquia4, string Jerarquia5, string Jerarquia6, string Jerarquia7, string Jerarquia8, long IdSucursal, long IdEmpresa, bool Activo, string IdListaDePrecio, string TipoDePrecioDeCosto, string IdProveedor, string IdTìpoProducto, bool PermiteProductosCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{						
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
            /* Silvina 20111226 - Tarea 0000241 */
            string separador = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada.Separador");
            if (string.IsNullOrEmpty(separador))
                separador = ",";
            return mz.erp.dataaccess.tsh_ProductosEx.SearchProductosCompras(Codigo, CodigoSecundario, Descripcion, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5, CampoAuxiliar6, Activo, IdMonedaReferencia, IdFuenteDeCambio, IdCondicionDeVentaVisualizacion, Jerarquia1, Jerarquia2, Jerarquia3, Jerarquia4, Jerarquia5, Jerarquia6, Jerarquia7, Jerarquia8, IdSucursal, IdEmpresa, IdListaDePrecio, TipoDePrecioDeCosto, IdProveedor, IdTìpoProducto, PermiteProductosCombo, PermiteCambio, separador);
            /* Fin Silvina 20111226 - Tarea 0000241 */
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}
        //Cristian Tarea 935
        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        public static System.Data.DataTable SearchProductos(string Codigo, string CodigoSecundario, string codigoProveedor, string Descripcion, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5, string CampoAuxiliar6, string IdCondicionDeVentaVisualizacion, string Jerarquia1, string Jerarquia2, string Jerarquia3, string Jerarquia4, string Jerarquia5, string Jerarquia6, string Jerarquia7, string Jerarquia8, long IdSucursal, long IdEmpresa, bool Activo, string IdListaDePrecio, string IdTìpoProducto, string IdResponsableCreacion, DateTime FechaAltaDesde, DateTime FechaAltaHasta, bool PermiteProductosCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326

		{						
			//Excluyo los inactivos
			//bool Activo = true;
			
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
            /* Silvina 20111226 - Tarea 0000241 */
            string separador = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada.Separador");
            if (string.IsNullOrEmpty(separador))
                separador = ",";
            return mz.erp.dataaccess.tsh_ProductosEx.SearchProductos(Codigo, CodigoSecundario, codigoProveedor, Descripcion, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5, CampoAuxiliar6, Activo, IdMonedaReferencia, IdFuenteDeCambio, IdCondicionDeVentaVisualizacion, Jerarquia1, Jerarquia2, Jerarquia3, Jerarquia4, Jerarquia5, Jerarquia6, Jerarquia7, Jerarquia8, IdSucursal, IdEmpresa, IdListaDePrecio, IdTìpoProducto, IdResponsableCreacion, FechaAltaDesde, FechaAltaHasta, PermiteProductosCombo, PermiteCambio,separador);
            /* Fin Silvina 20111226 - Tarea 0000241 */
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326

		}
        //Fin Tarea 935

		
		public static System.Data.DataTable SearchProductos(string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, bool ByActivo, string IdTipoProducto, string Observaciones, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5,string CampoAuxiliar6, string IdBonificacion, bool ObligaCodigoBarra, bool ByObligaCodigoBarra, bool ObligaNumeroSerie, bool ByObligaNumeroSerie, bool PercibeIB, bool ByPercibeIB, string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa, string IdCondicionDeVentaVisualizacion, string IdResponsableCreacion, DateTime FechaDesde, DateTime FechaHasta)
		{						
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }				
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductos(Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, ByActivo, IdTipoProducto, Observaciones, CampoAuxiliar1, CampoAuxiliar2, CampoAuxiliar3, CampoAuxiliar4, CampoAuxiliar5,CampoAuxiliar6, IdBonificacion, ObligaCodigoBarra, ByObligaCodigoBarra, ObligaNumeroSerie, ByObligaNumeroSerie, PercibeIB, ByPercibeIB, Jerarquia1, Jerarquia2, Jerarquia3, Jerarquia4, Jerarquia5, Jerarquia6, Jerarquia7, Jerarquia8, IdSucursal, IdEmpresa, IdMonedaReferencia, IdFuenteDeCambio, IdCondicionDeVentaVisualizacion, IdResponsableCreacion, FechaDesde, FechaHasta);
		}
		
		public static System.Data.DataTable SearchProductosConPreciosModificados(bool PorFechaUltimaModifPcioCosto, DateTime FechaUltimaModifPcioCostoDesde, DateTime FechaUltimaModifPcioCostoHasta, bool PorFechaUltimaModifPcioVenta, DateTime FechaUltimaModifPcioVentaDesde, DateTime FechaUltimaModifPcioVentaHasta, string IdListaDePrecio, string IdProducto, string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8)
		{						
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductosConPreciosModificados(PorFechaUltimaModifPcioCosto, FechaUltimaModifPcioCostoDesde, FechaUltimaModifPcioCostoHasta, PorFechaUltimaModifPcioVenta, FechaUltimaModifPcioVentaDesde, FechaUltimaModifPcioVentaHasta, IdListaDePrecio, IdProducto, Jerarquia1, Jerarquia2, Jerarquia3, Jerarquia4, Jerarquia5, Jerarquia6, Jerarquia7, Jerarquia8);
		}

		public static System.Data.DataTable SearchProductByJerarquia(string Jerarquia,long IdSucursal, long IdEmpresa)
		{
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductByJerarquia(Jerarquia, IdSucursal, IdEmpresa,null,true );
		}

		public static System.Data.DataTable SearchProductByJerarquia(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa)
		{
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductByJerarquia(Jerarquia1,Jerarquia2,Jerarquia3,Jerarquia4,Jerarquia5,Jerarquia6,Jerarquia7,Jerarquia8, IdSucursal, IdEmpresa,null,true );
		}

		public static tsh_ProductosDataset SearchProductByJerarquiaAux(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa)
		{
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductByJerarquiaAux(Jerarquia1,Jerarquia2,Jerarquia3,Jerarquia4,Jerarquia5,Jerarquia6,Jerarquia7,Jerarquia8, IdSucursal, IdEmpresa,true );
		}
		
		
		public static System.Data.DataTable SearchProductByJerarquiaSinCodigo(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa)
		{
			return mz.erp.dataaccess.tsh_ProductosEx.SearchProductByJerarquiaSinCodigo(Jerarquia1,Jerarquia2,Jerarquia3,Jerarquia4,Jerarquia5,Jerarquia6,Jerarquia7,Jerarquia8, IdSucursal, IdEmpresa,null,true );
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_ProductosEx que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosExDataset GetByPk( string IdProducto )
		{
			tsh_ProductosExDataset data = new tsh_ProductosExDataset();
			data = ( tsh_ProductosExDataset )mz.erp.dataaccess.tsh_Productos.GetByPk( data, IdProducto );
			data = ( tsh_ProductosExDataset )mz.erp.dataaccess.tsh_GruposProductos.GetList( data, IdProducto);
			data = ( tsh_ProductosExDataset )mz.erp.dataaccess.tsh_ProductosSucursales.GetList( data, IdProducto, long.MinValue, false);
			data = ( tsh_ProductosExDataset )mz.erp.dataaccess.sy_Sucursales.GetByPk(data, Security.IdSucursal, Security.IdEmpresa );
			data = ( tsh_ProductosExDataset )mz.erp.dataaccess.tsh_ProductosAuxiliares.GetByPk(data, IdProducto);			
			data.Merge(mz.erp.dataaccess.tsh_AgrupProductos.GetList(IdProducto, null).Tables[0]);
			IdProductoBuscado = IdProducto;
		
			try
			{
				foreach ( DataTable table in data.Tables) 
				{
					foreach ( DataRow row in table.Rows )
					{
						foreach ( DataColumn dc in row.Table.Columns )
						{
							if(! dc.Caption.ToUpper().Equals("ROWID"))
								if (row[dc] == System.DBNull.Value)
								{
									row[dc] = Util.DefaultValue( dc.DataType );
								}
						}
					}
				
				}
			}
			catch(Exception e)
			{
				
			}
			
			return data;
		}
		
		/// <summary>
		/// Obtiene un registro de la tabla tsh_Productos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosExDataset GetByPk( object IdProducto )
		{
			return GetByPk( ( string )IdProducto );
		}



		/// <summary>
		/// Envia los cambios del tsh_ProductosRow a la base de datos realizando una validacin previa.
		/// </summary>
		/// 



		#region Replication 
		private static SentenciasReplicacion  GenerateReplicaction()
		{
			SentenciasReplicacion replication = new SentenciasReplicacion();
			replication.IdConexion = Security.IdConexion;
			replication.SucGeneradora = Security.IdSucursal;
			//Para todas las sucursales
			replication.Destino = null;
			replication.VersionBD = null;
			replication.NombreTabla = "dataaccess.tsh_Productos";
			return replication;
			
		}

		#endregion


		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosExDataset data )
		{
			ApplicationAssert.Check( data != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( DatasetIsValid( data ) )
			{  
				Update( data );
			}
		}
		

		/// <summary>
		/// Valida un tsh_ProductosDataset
		/// </summary>
		public static bool DatasetIsValid( tsh_ProductosExDataset data )
		{
			//bool rowProductoIsValid = RowProductoIsValid( (tsh_ProductosExDataset.tsh_ProductosRow)data.tsh_Productos.Rows[0] );		
			bool impuestoIsValid = RowImpuestosExcluyentesIsValid ( data.tsy_ImpuestosProductos);
			//bool codigoSecundarioIsValid = RowCodigoSecundarioIsValid((tsh_ProductosExDataset.tsh_ProductosRow)data.tsh_Productos.Rows[0]);			
			bool tableProductosIsValid = TableProductoIsValid(data);
			bool impuestosDependientesIsValid = RowImpuestosDependientesIsValid ( data.tsy_ImpuestosProductos);
			bool JerarquiasValidas = RowJerarquiasIsValid(data);
			//return (rowProductoIsValid && impuestoIsValid && impuestosDependientesIsValid && JerarquiasValidas && codigoSecundarioIsValid);
			bool listaDePreciosIsValid = TableProductoListaDePreciosIsValid(data.tsh_ProductosListasDePrecios);
			return (tableProductosIsValid && impuestoIsValid && impuestosDependientesIsValid && JerarquiasValidas && listaDePreciosIsValid);
		}


		private static bool TableProductoListaDePreciosIsValid(tsh_ProductosExDataset.tsh_ProductosListasDePreciosDataTable dataTable)
		{
			bool ok = Variables.GetValueBool("Productos.ListasDePrecios.ValidarPrecioDeVentaBruto.Error");
			bool isValid = true;
			if(ok)
			{
				foreach(tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow rowP in dataTable.Rows)
				{				
					isValid = isValid && RowProductoListasDePreciosIsValid( rowP);
				}
			}
			return isValid;
		}
		private static bool TableProductoIsValid(tsh_ProductosExDataset data)
		{			
			bool ok = true;
			_codigosSecundarios.Clear();
			foreach(tsh_ProductosExDataset.tsh_ProductosRow rowP in data.tsh_Productos.Rows)
			{				
				string IdProducto = Convert.ToString(rowP["IdProducto"]);
				DataRow rowAux = data.tsh_ProductosAuxiliares.FindByIdProducto(IdProducto);
				ok = ok && RowProductoIsValid( rowP);
				ok = ok && RowCodigoSecundarioIsValid(rowP,(tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow)rowAux, Variables.GetValueBool("Productos.MultiplesCodigosSecundarios"));
			}
			return ok;
		}

		public static bool RowJerarquiasIsValid(tsh_ProductosExDataset data )
		{
			tsh_ProductosExDataset.tsh_AgrupProductosDataTable table = data.tsh_AgrupProductos;
			bool isValid = true;						
			foreach(DataRow row in table.Rows)
			{				
				if(row.HasErrors)
					return false;
			}
		
			return isValid;
		}
		public static bool RowCodigoSecundarioIsValid(tsh_ProductosExDataset.tsh_ProductosRow row, tsh_ProductosExDataset.tsh_ProductosAuxiliaresRow rowAux, bool MultiplesCodigosSecundarios)
		{
			bool result = true;
			bool AllowToValidateCodigoSecundario = Variables.GetValueBool("Productos.Validaciones.ControlCodigoSecundarioUnico");
			if(!row.RowState.Equals(DataRowState.Unchanged))
			{				
				if (AllowToValidateCodigoSecundario /*& IdProductoBuscado != row.IdProducto*/)
				{												
					if(!MultiplesCodigosSecundarios)
					{
						//Con la 2º validación nos aseguramos de entrar por altas únicamente.
						if (row.CodigoSecundario != null && row.CodigoSecundario != string.Empty && 
							businessrules.tsh_Productos.ExisteCodigoSecundario(row.IdProducto, row.CodigoSecundario, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(row.CodigoSecundario) )
						{						
							row.SetColumnError( "CodigoSecundario" , String.Format("El código secundario '{0}' ya fue ingresado anteriormente", row.CodigoSecundario));
							result = false;						
						}
					}
					else
					{
						if (row.CodigoSecundario != null && row.CodigoSecundario != string.Empty && 
							businessrules.tsh_Productos.ExisteCodigoSecundario(row.IdProducto, row.CodigoSecundario, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(row.CodigoSecundario) )
						{						
							row.SetColumnError( "CodigoSecundario" , String.Format("El código secundario '{0}' ya fue ingresado anteriormente", row.CodigoSecundario));
							result = false;						
						}
						if(rowAux != null)
						{
							if (rowAux.CodigoSecundario1 != null && rowAux.CodigoSecundario1 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario1, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario1) )
							{						
								rowAux.SetColumnError( "CodigoSecundario1" , String.Format("El código secundario 1 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario1));
								result = false;						
							}
							if (rowAux.CodigoSecundario2 != null && rowAux.CodigoSecundario2 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario2, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario2) )
							{						
								rowAux.SetColumnError( "CodigoSecundario2" , String.Format("El código secundario 2 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario2));
								result = false;						
							}
							if (rowAux.CodigoSecundario3 != null && rowAux.CodigoSecundario3 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario3, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario3) )
							{						
								rowAux.SetColumnError( "CodigoSecundario3" , String.Format("El código secundario 3 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario3));
								result = false;						
							}
							if (rowAux.CodigoSecundario4 != null && rowAux.CodigoSecundario4 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario4, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario4) )
							{						
								rowAux.SetColumnError( "CodigoSecundario4" , String.Format("El código secundario 4 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario4));
								result = false;						
							}
							if (rowAux.CodigoSecundario5 != null && rowAux.CodigoSecundario5 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario5, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario5) )
							{						
								rowAux.SetColumnError( "CodigoSecundario5" , String.Format("El código secundario 5 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario5));
								result = false;						
							}
							if (rowAux.CodigoSecundario6 != null && rowAux.CodigoSecundario6 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario6, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario6) )
							{						
								rowAux.SetColumnError( "CodigoSecundario6" , String.Format("El código secundario 6 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario6));
								result = false;						
							}
							if (rowAux.CodigoSecundario7 != null && rowAux.CodigoSecundario7 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario7, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario7) )
							{						
								rowAux.SetColumnError( "CodigoSecundario7" , String.Format("El código secundario 7 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario7));
								result = false;						
							}
							if (rowAux.CodigoSecundario8 != null && rowAux.CodigoSecundario8 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario8, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario8) )
							{						
								rowAux.SetColumnError( "CodigoSecundario8" , String.Format("El código secundario 8 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario8));
								result = false;						
							}
							if (rowAux.CodigoSecundario9 != null && rowAux.CodigoSecundario9 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario9, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario9) )
							{						
								rowAux.SetColumnError( "CodigoSecundario9" , String.Format("El código secundario 9 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario9));
								result = false;						
							}
							if (rowAux.CodigoSecundario11 != null && rowAux.CodigoSecundario11 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario11, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario11) )
							{						
								rowAux.SetColumnError( "CodigoSecundario11" , String.Format("El código secundario 11'{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario11));
								result = false;						
							}
							if (rowAux.CodigoSecundario12 != null && rowAux.CodigoSecundario12 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario12, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario12) )
							{						
								rowAux.SetColumnError( "CodigoSecundario12" , String.Format("El código secundario 12 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario12));
								result = false;						
							}
							if (rowAux.CodigoSecundario13 != null && rowAux.CodigoSecundario13 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario13, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario13) )
							{						
								rowAux.SetColumnError( "CodigoSecundario13" , String.Format("El código secundario 13 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario13));
								result = false;						
							}
							if (rowAux.CodigoSecundario14 != null && rowAux.CodigoSecundario14 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario14, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario14) )
							{						
								rowAux.SetColumnError( "CodigoSecundario14" , String.Format("El código secundario 14'{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario14));
								result = false;						
							}
							if (rowAux.CodigoSecundario15 != null && rowAux.CodigoSecundario15 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario15, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario15) )
							{						
								rowAux.SetColumnError( "CodigoSecundario15" , String.Format("El código secundario 15 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario15));
								result = false;						
							}
							if (rowAux.CodigoSecundario16 != null && rowAux.CodigoSecundario16 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario16, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario16) )
							{						
								rowAux.SetColumnError( "CodigoSecundario16" , String.Format("El código secundario 16 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario16));
								result = false;						
							}
							if (rowAux.CodigoSecundario17 != null && rowAux.CodigoSecundario17 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario17, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario17) )
							{						
								rowAux.SetColumnError( "CodigoSecundario17" , String.Format("El código secundario 17 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario17));
								result = false;						
							}
							if (rowAux.CodigoSecundario18 != null && rowAux.CodigoSecundario18 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario18, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario18) )
							{						
								rowAux.SetColumnError( "CodigoSecundario18" , String.Format("El código secundario 18 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario18));
								result = false;						
							}
							if (rowAux.CodigoSecundario19 != null && rowAux.CodigoSecundario19 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario19, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario19) )
							{						
								rowAux.SetColumnError( "CodigoSecundario19" , String.Format("El código secundario 19 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario19));
								result = false;						
							}
							if (rowAux.CodigoSecundario20 != null && rowAux.CodigoSecundario20 != string.Empty && 
								businessrules.tsh_Productos.ExisteCodigoSecundario( row.IdProducto,rowAux.CodigoSecundario20, MultiplesCodigosSecundarios) || _codigosSecundarios.Contains(rowAux.CodigoSecundario20) )
							{						
								rowAux.SetColumnError( "CodigoSecundario20" , String.Format("El código secundario 20 '{0}' ya fue ingresado anteriormente", rowAux.CodigoSecundario20));
								result = false;						
							}

						}

					}
				}
			}			
			if (row.CodigoSecundario != String.Empty)
				_codigosSecundarios.Add(row.CodigoSecundario);
			return result;
		}

		private static ArrayList dependencias = new  ArrayList();
		private static ArrayList _codigosSecundarios = new ArrayList();

		public static bool RowImpuestosDependientesIsValid(tsh_ProductosExDataset.tsy_ImpuestosProductosDataTable table)
		{
			
			string ImpuestosDependientes = Variables.GetValueString("Productos.Validaciones.ImpuestosDependientes");
			string[] ListaImpuestosDependientes = ImpuestosDependientes.Split( ',');
			if (ListaImpuestosDependientes.Length > 0)
			{
				dependencias = new  ArrayList();
				for(int i=0;i<ListaImpuestosDependientes.Length;i++)
				{
					string[] atupla = ListaImpuestosDependientes[i].Split(':');
					if (atupla.Length == 2)
					{
						ArrayList aux = new ArrayList();
						aux.Add(atupla[0]);
						aux.Add(atupla[1]);
						dependencias.Add(aux);
					}
				}
				ArrayList impuestos = new ArrayList();
				foreach(tsh_ProductosExDataset.tsy_ImpuestosProductosRow row in table.Rows)
				{
					if(!row.RowState.Equals(DataRowState.Deleted))
					{
						string IdImpuesto = row.IdImpuesto;
						DataRow rowAux = mz.erp.businessrules.tsy_Impuestos.GetByPk(IdImpuesto);
						if(rowAux!= null)
						{
							impuestos.Add(Convert.ToString(rowAux["Impuesto"]));
						}
					}
				}
				foreach(string IdImp in impuestos)
				{
					
					ArrayList dependientes = GetImpuestosDependientes(IdImp);
					foreach(string IdImpAux in impuestos)
					{
						if(dependientes.Contains(IdImpAux))
						{
							dependientes.Remove(IdImpAux);
						}
					}
					if(dependientes.Count > 0)
					{
						foreach(tsh_ProductosExDataset.tsy_ImpuestosProductosRow row1 in table.Rows)
						{
							if(!row1.RowState.Equals(DataRowState.Deleted))
							{
                                row1.SetColumnError("IdImpuesto","El impuesto " + IdImp + " requiere que se seleccione además el impuesto " + Convert.ToString(dependientes[0]));
								break;
							}
						}
						return false;
					}
				}
				return true;
			
			}
			else return false;
			
		}	
	

		private static ArrayList GetImpuestosDependientes(string Impuesto)
		{
			ArrayList aux = new ArrayList();
			long index = 0;
			foreach(ArrayList deps in dependencias)
			{
				string imp1 = Convert.ToString(deps[0]);
				string imp2 = Convert.ToString(deps[1]);
				if(imp1.Equals(Impuesto))
				{
					aux.Add(imp2);
				}
				else
					if(imp2.Equals(Impuesto))
					{
						aux.Add(imp1);
					}
			}
			return aux;

		}


		public static bool RowImpuestosExcluyentesIsValid(tsh_ProductosExDataset.tsy_ImpuestosProductosDataTable table)
		{
			
			string ImpuestosExcluyentes = Variables.GetValueString("Productos.Validaciones.ImpuestosExcluyentes");
			string[] ListaImpuestosExcluyentes = ImpuestosExcluyentes.Split( ',');
			if (ListaImpuestosExcluyentes.Length > 0)
			{
				Hashtable hash = new Hashtable();
				for(int i=0;i<ListaImpuestosExcluyentes.Length;i++)
				{
					string[] atupla = ListaImpuestosExcluyentes[i].Split(':');
					if (atupla.Length == 2)
					{
						hash.Add( atupla[0]+atupla[1], null);
					}
				}
				ArrayList impuestos = new ArrayList();
				foreach(tsh_ProductosExDataset.tsy_ImpuestosProductosRow row in table.Rows)
				{
					if(!row.RowState.Equals(DataRowState.Deleted))
					{
						string IdImpuesto = row.IdImpuesto;
						DataRow rowAux = mz.erp.businessrules.tsy_Impuestos.GetByPk(IdImpuesto);
						if(rowAux!= null)
						{
							impuestos.Add(Convert.ToString(rowAux["Impuesto"]));
						}
					}
				}
				foreach(string IdImp in impuestos)
				{
					foreach(string IdImpAux in impuestos)
					{
						if(!IdImp.Equals(IdImpAux))
						{
							if(hash.ContainsKey(IdImp+IdImpAux) || hash.ContainsKey(IdImpAux + IdImp))
							{
								foreach(tsh_ProductosExDataset.tsy_ImpuestosProductosRow row1 in table.Rows)
								{
									if(!row1.RowState.Equals(DataRowState.Deleted))
									{
										row1.SetColumnError("IdImpuesto","El producto no puede tener " + IdImp + ", " + IdImpAux + ". Son impuestos mutuamente excluyentes");
										break;
									}
								}
								return false;
							}
						}
					}
				}
				return true;
			
			}
			else return false;
			
		}		
		/// <summary>
		/// Vivivivi
		/// </summary>
		/// <param name="data"></param>
		public static void Update( tsh_ProductosExDataset data )
		{   
			SentenciasReplicacion replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsh_ProductosEx.Update( data , replicacion);
			
			//ST agrega el PRECIO FINAL ESTIMADO
			/*
			if(data.tsh_Productos.Rows.Count > 0)
			{
			    foreach(System.Data.DataRow row in data.tsh_ProductosSucursales.Rows)
				{	
					decimal pfe = Productos.ObtenerPrecioBrutoConImpuestos((String)data.tsh_Productos.Rows[0]["IdProducto"], 
																 (long)data.tsh_ProductosSucursales.Rows[0]["IdSucursal"], 
																 (long)data.tsh_ProductosSucursales.Rows[0]["IdEmpresa"]);
					row.Table.Rows[0]["PrecioFinalEstimado"]=pfe;
				}
			}

			*/			
		}

		
		public static bool RowProductoListasDePreciosIsValid( tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow row )
		{
			bool isValid=true;
			if(!row.RowState.Equals(DataRowState.Unchanged))
			{
				ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
				string mensaje;
			
				isValid = !row.HasErrors;
			
				if ( !tsh_ProductosListasDePrecios.CoeficienteIsValid( row.Coeficiente, out mensaje) )
				{ 
					row.SetColumnError( "Coeficiente" , mensaje);
					isValid=false;
			
				}
			}
			return isValid;
		}

		/// <summary>
		/// Valida un tsh_ProductosRow.
		/// </summary>
		public static bool RowProductoIsValid( tsh_ProductosExDataset.tsh_ProductosRow row )
		{
			

			bool isValid=true;
			if(!row.RowState.Equals(DataRowState.Unchanged))
			{
			
				if(row.RowState.Equals(DataRowState.Added))
				{
					if(row.Codigo != null && row.Codigo != string.Empty)
					{
						string IdProd = mz.erp.businessrules.tsh_Productos.GetIdProductoByCodigo(row.Codigo);
						if(!(IdProd == null || IdProd.Equals(string.Empty)))
						{
							row.SetColumnError( "Codigo" , "El Código ingresado ya existe");
							isValid=false;
						}

					}
				}
				ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
				string mensaje;
			
				isValid = !row.HasErrors;
			
				if ( !tsh_Productos.IdProductoIsValid( row.IdProducto, out mensaje) )
				{ 
					row.SetColumnError( "IdProducto" , mensaje);
					isValid=false;
			
				}
				/*if ( !tsh_Productos.IdBonificacionIsValid( row.IdBonificacion, out mensaje) )
				{ 
					row.SetColumnError( "IdBonificacion" , mensaje);
					isValid=false;
			
				}*/
						
				if ( !tsh_Productos.IdTipoProductoIsValid( row.IdTipoProducto, out mensaje) )
				{ 
					row.SetColumnError( "IdTipoProducto" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.CodigoIsValid( row.Codigo, out mensaje) )
				{ 
					row.SetColumnError( "Codigo" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.CodigoSecundarioIsValid( row.CodigoSecundario, out mensaje) )
				{ 
					row.SetColumnError( "CodigoSecundario" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.DescripcionIsValid( row.Descripcion, out mensaje) )
				{ 
					row.SetColumnError( "Descripcion" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.DescripcionCortaIsValid( row.DescripcionCorta, out mensaje) )
				{ 
					row.SetColumnError( "DescripcionCorta" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.DescripcionLargaIsValid( row.DescripcionLarga, out mensaje) )
				{ 
					row.SetColumnError( "DescripcionLarga" , mensaje);
					isValid=false;
			
				}
						
						
				if ( !tsh_Productos.UnidadesPedidoIsValid( row.UnidadesPedido, out mensaje) )
				{ 
					row.SetColumnError( "UnidadesPedido" , mensaje);
					isValid=false;
			
				}
				bool _validarMacNegativoError = Variables.GetValueBool("Momentos.ABMProductos.ValidarMacNegativo.Error", "Productos.Precios.ValidarMacNegativo.Error");
				if ( _validarMacNegativoError && !tsh_Productos.MACIsValid( row.MAC, out mensaje) )
				{ 
					row.SetColumnError( "MAC" , mensaje);
					isValid=false;
			
				}

                //German 20100428 - Tarea 742
                bool _validarPPPMenorOIgualACeroError = Variables.GetValueBool("Momentos.ABMProductos.ValidarPPPMenorIgualACero.Error");
                if (_validarPPPMenorOIgualACeroError && row.RowState.Equals(DataRowState.Added) && (row.Table.Rows.Count == 1) && (row.PrecioDeCostoPromedioPonderado <= 0))
                {
                    row.SetColumnError("PrecioDeCostoPromedioPonderado", "El Precio de Costo Promedio Ponderado debe ser mayor a 0");
                    isValid = false;

                }
                //Fin German 20100428 - Tarea 742
						
				if ( !tsh_Productos.PrecioDeCostoRefIsValid( row.PrecioDeCostoRef, out mensaje) )
				{ 
					row.SetColumnError( "PrecioDeCostoRef" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.PrecioDeVentaNetoIsValid( row.PrecioDeVentaNeto, out mensaje) )
				{ 
					row.SetColumnError( "PrecioDeVentaNeto" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.MaxDescuentoPorcentualIsValid( row.MaxDescuentoPorcentual, out mensaje) )
				{ 
					row.SetColumnError( "MaxDescuentoPorcentual" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.MaxDescuentoIsValid( row.MaxDescuento, out mensaje) )
				{ 
					row.SetColumnError( "MaxDescuento" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.PrecioDeVentaBrutoIsValid( row.PrecioDeVentaBruto, out mensaje) )
				{ 
					row.SetColumnError( "PrecioDeVentaBruto" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.ObligaCodigoBarraIsValid( row.ObligaCodigoBarra, out mensaje) )
				{ 
					row.SetColumnError( "ObligaCodigoBarra" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.ObligaNumeroSerieIsValid( row.ObligaNumeroSerie, out mensaje) )
				{ 
					row.SetColumnError( "ObligaNumeroSerie" , mensaje);
					isValid=false;
			
				}
						
				if ( !tsh_Productos.IdCuentaImputacionIsValid( row.IdCuentaImputacion, out mensaje) )
				{ 
					row.SetColumnError( "IdCuentaImputacion" , mensaje);
					isValid=false;
			
				}
						
				/*if ( !tsh_Productos.FechaUltimaCompraIsValid( row.FechaUltimaCompra, out mensaje) )
				{ 
					row.SetColumnError( "FechaUltimaCompra" , mensaje);
					isValid=false;
			
				}
					*/		
				if ( !tsh_Productos.ActivoIsValid( row.Activo, out mensaje) )
				{ 
					row.SetColumnError( "Activo" , mensaje);
					isValid=false;
			
				}

				if ( !tsh_Productos.IdResponsableCreacionIsValid( row.IdResponsableCreacion, out mensaje) )
				{ 
					row.SetColumnError( "IdResponsableCreacion" , mensaje);
					isValid=false;
			
				}
			}
			return isValid;
		}
		public static System.Data.DataSet AddNewRowSucursales( System.Data.DataSet data, long IdSucursal )
		{
			return (System.Data.DataSet)AddNewRowSucursales( data, IdSucursal, Security.IdEmpresa );
		}
		public static System.Data.DataSet AddNewRowSucursales( System.Data.DataSet data, long IdSucursal, long IdEmpresa )
		{
			return (System.Data.DataSet)AddNewRowSucursales( (tsh_ProductosExDataset)data, IdSucursal, IdEmpresa );
		}
		public static System.Data.DataSet AddNewRowSucursales( System.Data.DataSet data)
		{
			return (System.Data.DataSet)AddNewRowSucursales( (tsh_ProductosExDataset)data, Security.IdSucursal, Security.IdEmpresa );
		}
		public static tsh_ProductosExDataset AddNewRowSucursales( tsh_ProductosExDataset data, long IdSucursal, long IdEmpresa )
		{
			tsh_ProductosExDataset.tsh_ProductosRow rowProducto = (tsh_ProductosExDataset.tsh_ProductosRow)GetDataRowProductos(data);
			
			tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowSucursales = mz.erp.dataaccess.tsh_ProductosEx.NewRowSucursales( data );
			rowSucursales = SetRowProductosSucursalesDefaultValues( rowSucursales, rowProducto.IdProducto, IdEmpresa, IdSucursal );
			try
			{
				data.tsh_ProductosSucursales.Rows.Add( rowSucursales );
				return data;
			}
			catch
			{
				return null;
			}
			//Carga todas las sucursales



				
		}

		public static tsh_ProductosExDataset.tsh_ProductosSucursalesRow AddNewRowProdSucursales( tsh_ProductosExDataset data, long IdSucursal, long IdEmpresa )
		{
			tsh_ProductosExDataset.tsh_ProductosRow rowProducto = (tsh_ProductosExDataset.tsh_ProductosRow)GetDataRowProductos(data);
			
			tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowSucursales = mz.erp.dataaccess.tsh_ProductosEx.NewRowSucursales( data );
			rowSucursales = SetRowProductosSucursalesDefaultValues( rowSucursales, rowProducto.IdProducto, IdEmpresa, IdSucursal );
			try
			{
				data.tsh_ProductosSucursales.Rows.Add( rowSucursales );
				return rowSucursales;
			}
			catch
			{
				return null;
			}
			//Carga todas las sucursales



				
		}

		public static tsh_ProductosExDataset.tsh_ProductosSucursalesRow SetRowProductosSucursalesDefaultValues( tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowSucursal, string IdProducto, long IdEmpresa, long IdSucursal )
		{
			return (tsh_ProductosExDataset.tsh_ProductosSucursalesRow)mz.erp.businessrules.tsh_ProductosSucursales.SetRowDefaultValues( (System.Data.DataRow)rowSucursal, IdProducto, IdEmpresa, IdSucursal );
		}



		public static void Update(tsh_ProductosExDataset dataProductos, tsh_ConversionesExDataset dataConversiones)
		{
			SentenciasReplicacion replicacion = GenerateReplicaction();
			mz.erp.dataaccess.tsh_ProductosEx.Update(dataProductos, dataConversiones, replicacion);

		}
		

		#endregion
		
		public tsh_ProductosEx()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_ProductosEx
		/// </summary>
		public static tsh_ProductosDataset GetList()
		{
			return mz.erp.businessrules.tsh_Productos.GetList();
		}
		

		private static string IdProductoBuscado = "";
		/// <summary>
		/// Obtiene tabla tsh_Productos filtrada por las condiciones de bsqueda
		/// </summary>
		public static System.Data.DataSet GetList( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga )
		{								
			return (System.Data.DataSet)mz.erp.businessrules.tsh_Productos.GetList( IdTipoProducto, Codigo, CodigoSecundario, null, Descripcion, DescripcionCorta, DescripcionLarga );
		}
		

		public void Dispose()
		{
		}

		public class ProductosImpuestos: CollectionBase    
		{                                                  
			public ProductosImpuestos()                
			{                                          
			}                                          
			public void Add(object sender)             
			{                                          
				base.List.Add( sender );           
			}                                          
                                                   
		} 

		public class ProductosJearaquias: CollectionBase    
		{                                                  
			public ProductosJearaquias()                
			{                                          
			}                                          
			public void Add(object sender)             
			{                                          
				base.List.Add( sender );           
			}                                          
                                                   
		} 
        /*                                         
		public class ProductosSucursales: CollectionBase   
		{                                                  
			public ProductosSucursales()               
			{                                          
			}                                          
                                                   
			public void Add(object sender)             
			{                                          
				base.List.Add( sender );		
			}                                          
		}                                                  
		*/


        //Sabrina: Tarea 1067. 20110311
        public class ControladorProductos : IObserver
        //Fin Sabrina: Tarea 1067. 20110311
		{
			
			
			private ArrayList _productos = new ArrayList();
			private decimal _precioLista =0;
			private decimal _precioFinal = 0;
			private decimal _precioCosto= 0;
			private decimal _precioNeto= 0;
			private decimal _margen= 0;
			private decimal _descuentoMax= 0;
			private decimal _descuentoPorcentual= 0;
			private ProductosSucursales _sucursales;			
			private ProductosImpuestos _impuestos;
			private tsh_ProductosExDataset _data;
			private ArrayList _sucActivasONo;
			private string _idProducto;
			private bool _configuracionBasica = false;			
			

			private ArrayList impuestosAAplicar = new ArrayList();

			private CotizacionWrapper _cotizacionProductoPrecioDeCosto;
			private CotizacionWrapper _cotizacionProductoPrecioDeVenta;

			private bool _mantieneMaximoDescuento = true;

			private bool _percibeIB = true;
			private ArrayList _jerarquia1 = new ArrayList();
			private ArrayList _jerarquia2 = new ArrayList();
			private ArrayList _jerarquia3 = new ArrayList();
			private ArrayList _jerarquia4 = new ArrayList();
			private ArrayList _jerarquia5 = new ArrayList();
			private ArrayList _jerarquia6 = new ArrayList();
			private ArrayList _jerarquia7 = new ArrayList();
			private ArrayList _jerarquia8 = new ArrayList();

			private bool _byJerarquia1 = false;
			private bool _byJerarquia2 = false;
			private bool _byJerarquia3 = false;
			private bool _byJerarquia4 = false;
			private bool _byJerarquia5 = false;
			private bool _byJerarquia6 = false;
			private bool _byJerarquia7 = false;
			private bool _byJerarquia8 = false;
			


			public event EventHandler PrecioNetoChanged;
			public event EventHandler PrecioCostoChanged;
			public event EventHandler PrecioListaChanged;
			public event EventHandler MargenChanged;
			public event EventHandler DescuentoMaxChanged;
			public event EventHandler DescuentoPorcentualChanged;
			public event EventHandler IdMonedaCierrePrecioDeCostoRefChanged;
			public event EventHandler IdMonedaCierrePrecioDeVentaBrutoChanged;
			public event EventHandler IdFuenteDeCambioPrecioDeCostoRefChanged;
			public event EventHandler SimboloMonedaPrecioDeCostoReferenciaChanged;
			public event EventHandler SimboloMonedaPrecioDeListaChanged;
            //Sabrina: Tarea 1067. 20110311
            public event EventHandler ProductosComboChanged;
            //Fin Sabrina: Tarea 1067. 20110311
			
			private string _codigo = string.Empty;
			private string _codigoSecundarioBD = string.Empty;
			private string _descripcionBD = string.Empty;
			private string _descripcionCortaBD = string.Empty;
			private string _descripcionLargaBD = string.Empty;
			private bool _obligaCodigoBarra = false;
			private bool _obligaNumeroSerie = false;
			private bool _activo = true;
			private bool _percibeIBBD = true;
			private decimal _MAC = 0;
			private decimal _precioDeCostoRef = 0;
            
			//Sabrina: tarea 56
			private decimal _precioDeCostoReposicion = 0;
			private decimal _precioDeCostoPromedioPonderado = 0;
			private bool _usaPrecioDeCostoReposicion = false;
			private bool _usaListaDePreciosProveedores = false;
			private CostosIndirectos _coeficientesIndirectos;


			private bool _costoIndirecto1HabilitadoPorDefault = false;
			private bool _costoIndirecto2HabilitadoPorDefault = false;
			private bool _costoIndirecto3HabilitadoPorDefault = false;
			private bool _costoIndirecto4HabilitadoPorDefault = false;
			private bool _costoIndirecto5HabilitadoPorDefault = false;
			private bool _costoIndirecto6HabilitadoPorDefault = false;
			private bool _costoIndirecto7HabilitadoPorDefault = false;
			private bool _costoIndirecto8HabilitadoPorDefault = false;
			private bool _costoIndirecto9HabilitadoPorDefault = false;
			private bool _costoIndirecto10HabilitadoPorDefault = false;


			private string _costoIndirectoDescrip1 = string.Empty;
			private string _costoIndirectoDescrip2 = string.Empty;
			private string _costoIndirectoDescrip3 = string.Empty;
			private string _costoIndirectoDescrip4 = string.Empty;
			private string _costoIndirectoDescrip5 = string.Empty;
			private string _costoIndirectoDescrip6 = string.Empty;
			private string _costoIndirectoDescrip7 = string.Empty;
			private string _costoIndirectoDescrip8 = string.Empty;
			private string _costoIndirectoDescrip9 = string.Empty;
			private string _costoIndirectoDescrip10 = string.Empty;


			private decimal _precioDeVentaNeto = 0;
			private decimal _maxDescuentoPorcentual = 0;
			private decimal _maxDescuento = 0;
			private decimal _precioDeVentaBruto = 0;
			private decimal _precioDeCostoDirecto = 0;
			//private decimal _precioDeCostoIndirecto = 0;
			private long    _contador = 0;
			private Image  _imagen;
			private Image  _thumb;
			private string _idBonificacion = string.Empty;
			private string _idTipoProducto = string.Empty;
			private string _idMonedaCierrePrecioDeVentaBruto = string.Empty;
			private string _idMonedaCierrePrecioDeVentaNeto = string.Empty;
			private string _idMonedaCierreMaxDescuento = string.Empty;
			private string _idMonedaCierrePrecioDeCostoRef = string.Empty;
			private string _idCotizacionCierrePrecioDeCostoRef = string.Empty;
			private string _idCotizacionCierrePrecioDeVentaBruto = string.Empty;
			private string _idCotizacionCierrePrecioDeVentaNeto = string.Empty;
			private string _idCotizacionCierreMaxDescuento = string.Empty;

		
			/*private decimal _coeficiente1 = 0;
			private decimal _coeficiente2 = 0;
			private decimal _coeficiente3 = 0;
			private decimal _coeficiente4 = 0;
			private decimal _coeficiente5 = 0;
			private bool _coeficientesPorVariable = false;
			*/
			private ListaDePrecios _listaDePrecios;
			private string _simboloMonedaOrigen = string.Empty;
			private string _simboloMonedaDescuentoMaximo = string.Empty;
			private string _simboloMonedaPrecioDeVentaNeto = string.Empty;
			private string _simboloMonedaPrecioDeLista = string.Empty;
            private string _simboloMonedaReferencia = string.Empty;
			private string _idProveedorDefault = string.Empty;	
			private bool _precioDeVentaAfectaMac = Variables.GetValueBool("Productos.Precio.PrecioDeVentaAfectaMac", false);
			private bool _validarMacNegativoError = Variables.GetValueBool("Momentos.ABMProductos.ValidarMacNegativo.Error", "Productos.Precios.ValidarMacNegativo.Error");
			private bool _validarMacNegativoAdvertencia = Variables.GetValueBool("Momentos.ABMProductos.ValidarMacNegativo.Advertencia", "Productos.Precios.ValidarMacNegativo.Advertencia");
            //Cristian 20101018 Tarea 874
            private bool _coeficienteNegativo = true;
            //Fin Cristian

			//German 20100428 - Tarea 742
			private bool _validarPPPMenorIgualACeroError = Variables.GetValueBool("Momentos.ABMProductos.ValidarPPPMenorIgualACero.Error");
			private bool _validarPPPMenorIgualACeroAdvertencia = Variables.GetValueBool("Momentos.ABMProductos.ValidarPPPMenorIgualACero.Advertencia");
			//Fin German 20100428 - Tarea 742


			private string _codigoSecundario1 = string.Empty;
			private string _codigoSecundario2 = string.Empty;
			private string _codigoSecundario3 = string.Empty;
			private string _codigoSecundario4 = string.Empty;
			private string _codigoSecundario5 = string.Empty;
			private string _codigoSecundario6 = string.Empty;
			private string _codigoSecundario7 = string.Empty;
			private string _codigoSecundario8 = string.Empty;
			private string _codigoSecundario9 = string.Empty;
			private string _codigoSecundario10 = string.Empty;
			private string _codigoSecundario11= string.Empty;
			private string _codigoSecundario12 = string.Empty;
			private string _codigoSecundario13 = string.Empty;
			private string _codigoSecundario14 = string.Empty;
			private string _codigoSecundario15 = string.Empty;
			private string _codigoSecundario16 = string.Empty;
			private string _codigoSecundario17 = string.Empty;
			private string _codigoSecundario18 = string.Empty;
			private string _codigoSecundario19 = string.Empty;
			private string _codigoSecundario20 = string.Empty;

			private bool _usaCotizacionDefault = true;

            //Sabrina: Tarea 1110. 20110805
			//private string _codigoProductoSegunProveedor = string.Empty;
            //Fin Sabrina: Tarea 1110. 20110805

			private bool _tieneCodigoSecundarioSegmentado = false;

            //Sabrina: Tarea 1110. 20110805
            private ListaDePreciosProveedores _listaDePreciosProveedores;
            //Fin Sabrina: Tarea 1110. 20110805

            //Sabrina: Tarea 1067. 20110311
            private bool _esCombo = false;
            private ArrayList _detalleCombo = new ArrayList();

            public bool EsCombo
            {
                get { return _esCombo; }
                set { _esCombo = value; }
            }
            //Fin Sabrina: Tarea 1067. 20110311

            /* Silvina 20110630 - Tarea 0000136 */
            private bool _permiteCambio = true;
            public bool PermiteCambio
            {
                get { return _permiteCambio; }
                set { _permiteCambio = value; }
            }
            /* Fin Silvina 20110630 - Tarea 0000136 */

            //Sabrina: Tarea 1068. 20110317
            private decimal _precioDeCostoRefBD = 0;
            public decimal PrecioDeCostoRefBD
            {
                get
                {
                    return _precioDeCostoRefBD;
                }
                set
                {
                    _precioDeCostoRefBD = value;
                }
            }
            private decimal _precioDeVentaBrutoBD = 0;
            public decimal PrecioDeVentaBrutoBD
            {
                get
                {
                    return _precioDeVentaBrutoBD;
                }
                set
                {
                    _precioDeVentaBrutoBD = value;
                }
            }
            //Fin Sabrina: Tarea 1068. 20110317
			
			private bool _bonificacionesAcumulativas = true;
			public bool BonificacionesAcumulativas
			{
				get
				{
					return _bonificacionesAcumulativas;
				}
				set
				{
                    //Sabrina: Tarea 1110. 20110805
                    if (_bonificacionesAcumulativas != value)
                    {
                        _bonificacionesAcumulativas = value;
                        if ((!(this._idProveedorDefault == null)) && (!(this._idProveedorDefault.Equals(string.Empty))))
                        {
                           ListaDePreciosProveedoresItem item = _listaDePreciosProveedores.getListaDePreciosProveedoresItem(_idProveedorDefault);
                           item.BonificacionAcumulativa = _bonificacionesAcumulativas;
                        }
                    }
                    //Fin Sabrina: Tarea 1110. 20110805
				}
			}

			public bool TieneCodigoSecundarioSegmentado
			{
				get
				{
					return _tieneCodigoSecundarioSegmentado;
				}
				set
				{
					_tieneCodigoSecundarioSegmentado = value;
				}
			}

            //Sabrina: Tarea 1110. 20110805
            //Se lee de la nueva tabla tpu_ProveedoresProductosAuxiliares
			/*public string CodigoProductoSegunProveedor
			{
				get{return _codigoProductoSegunProveedor;}
				set{_codigoProductoSegunProveedor = value;}

			}*/
            //Fin Sabrina: Tarea 1110. 20110805

			public string CodigoSecundario1
			{
				get{return _codigoSecundario1;}
				set{_codigoSecundario1  = value;}
			}
			public string CodigoSecundario2
			{
				get{return _codigoSecundario2;}
				set{_codigoSecundario2  = value;}
			}
			public string CodigoSecundario3
			{
				get{return _codigoSecundario3;}
				set{_codigoSecundario3  = value;}
			}
			public string CodigoSecundario4
			{
				get{return _codigoSecundario4;}
				set{_codigoSecundario4  = value;}
			}

			public string CodigoSecundario5
			{
				get{return _codigoSecundario5;}
				set{_codigoSecundario5  = value;}
			}
			public string CodigoSecundario6
			{
				get{return _codigoSecundario6;}
				set{_codigoSecundario6  = value;}
			}

			public string CodigoSecundario7
			{
				get{return _codigoSecundario7;}
				set{_codigoSecundario7  = value;}
			}

			public string CodigoSecundario8
			{
				get{return _codigoSecundario8;}
				set{_codigoSecundario8  = value;}
			}

			public string CodigoSecundario9
			{
				get{return _codigoSecundario9;}
				set{_codigoSecundario9  = value;}
			}

			public string CodigoSecundario10
			{
				get{return _codigoSecundario10;}
				set{_codigoSecundario10  = value;}
			}

			public string CodigoSecundario11
			{
				get{return _codigoSecundario11;}
				set{_codigoSecundario11  = value;}
			}

			public string CodigoSecundario12
			{
				get{return _codigoSecundario12;}
				set{_codigoSecundario12 = value;}
			}

			public string CodigoSecundario13
			{
				get{return _codigoSecundario13;}
				set{_codigoSecundario13  = value;}
			}

			public string CodigoSecundario14
			{
				get{return _codigoSecundario14;}
				set{_codigoSecundario14  = value;}
			}

			public string CodigoSecundario15
			{
				get{return _codigoSecundario15;}
				set{_codigoSecundario15 = value;}
			}

			public string CodigoSecundario16
			{
				get{return _codigoSecundario16;}
				set{_codigoSecundario16  = value;}
			}

			public string CodigoSecundario17
			{
				get{return _codigoSecundario17;}
				set{_codigoSecundario17  = value;}
			}

			public string CodigoSecundario18
			{
				get{return _codigoSecundario18;}
				set{_codigoSecundario18  = value;}
			}

			public string CodigoSecundario19
			{
				get{return _codigoSecundario19;}
				set{_codigoSecundario19  = value;}
			}

			public string CodigoSecundario20
			{
				get{return _codigoSecundario20;}
				set{_codigoSecundario20 = value;}
			}

			public bool PrecioDeVentaAfectaMac
			{
				get{return _precioDeVentaAfectaMac;}
			}


            //Cristian 20100428 - Tarea 874
            public bool PermiteCoeficienteNegativo
            {
                get { return _coeficienteNegativo; }
            }
            //Fin Cristian 

            //German 20100428 - Tarea 742
            public bool ValidarPPPMenorIgualACeroError
            {
                get { return _validarPPPMenorIgualACeroError; }
            }

            public bool ValidarPPPMenorIgualACeroAdvertencia
            {
                get { return _validarPPPMenorIgualACeroAdvertencia; }
            }
            //Fin German 20100428 - Tarea 742
		
			public bool ValidarMacNegativoError
			{
				get{return _validarMacNegativoError;}
			}

			public bool ValidarMacNegativoAdvertencia
			{
				get{return _validarMacNegativoAdvertencia;}
			}
  
			/*public bool CoeficientesPorVariable
			{
				get
				{
					return _coeficientesPorVariable;
				}
			}*/
			//Cristian Tarea 000243
			public  string Codigo 
			{
                get { return _codigo; }
				set{_codigo = value;}

			}
            
			public  string CodigoSecundario
			{
                get { return _codigoSecundarioBD; }
                set{_codigoSecundarioBD = value;}
			}
            //Fin Cristian Tarea 000243

			public string Descripcion
			{
				set{_descripcionBD = value;}
			}

			public string DescripcionCorta 
			{
				set{_descripcionCortaBD = value;}
			}

			public  string DescripcionLarga
			{
				set{_descripcionLargaBD = value;}
			}
			public bool ObligaCodigoBarra
			{
				set{_obligaCodigoBarra = value;}
			}
			public  bool ObligaNumeroSerie
			{
				set{_obligaNumeroSerie = value;}
			}


			public  bool Activo 
			{
				set{_activo = value;}
			}

			public bool PercibeIBBD 
			{
				set{_percibeIBBD = value;}
			}

			public decimal MAC
			{
				set{_MAC = value;}
			}

			public decimal PrecioDeCostoRef
			{
				set{_precioDeCostoRef = value;}
				get{return _precioDeCostoRef;}
			}

			//Sabrina: tarea 56

			public decimal PrecioDeCostoReposicion
			{
				get{return _precioDeCostoReposicion;}
				set
				{
					_precioDeCostoReposicion = value;
					if(_usaPrecioDeCostoReposicion)
						PrecioDeCostoDirecto = _precioDeCostoReposicion;
				}
			}

			public decimal PrecioDeCostoPromedioPonderado
			{
				get{return _precioDeCostoPromedioPonderado;}
				set
				{
					_precioDeCostoPromedioPonderado = value;
					if(!_usaPrecioDeCostoReposicion)
						PrecioDeCostoDirecto = _precioDeCostoPromedioPonderado;
				}
			}
			
			public bool UsaPrecioDeCostoReposicion
			{
				get{return _usaPrecioDeCostoReposicion;}
				set
				{
					_usaPrecioDeCostoReposicion = value;
					if(_usaPrecioDeCostoReposicion)
						PrecioDeCostoDirecto = _precioDeCostoReposicion;
					else
						PrecioDeCostoDirecto = _precioDeCostoPromedioPonderado;
				}
			}

			private bool _usaCostosIndirectos = false;
			public bool UsaCostosIndirectos
			{
				get{return _usaCostosIndirectos;}
			}

			public void CargarCoeficientesIndirectos()
			{
				this.CoeficientesIndirectos = new CostosIndirectos(this.Idproducto, this._state);
				if( this._state.Equals("EDIT") && this.CoeficientesIndirectos.Count == 0)
					this.CoeficientesIndirectos = new CostosIndirectos(this.Idproducto, "NEW");
			}

			public bool CoeficienteBinding(long indice)
			{
				foreach(tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
				{                                  
					if ((row.Orden == indice) && ( row.Activo )) 
						return true;
					else
						if ((row.Orden == indice) && ( !row.Activo )) 
						return false;
				}
				return false;
			}
			public void ActivarCostoIndirecto(long idCosto, bool valor)
			{
				CoeficientesIndirectos.ActivarCostoIndirecto(idCosto, valor);
				RecalcularPrecioDeCosto();
			}

			public bool CoeficienteCreadoyActivo(long indice)
			{
				return CoeficientesIndirectos.CoeficienteCreadoyActivo(indice);
			}


			// --------------------- Recupera las descripciones de los costos indirectos
			public string CostosIndirectosDescrip1
			{
				//get{return this._producto.CostoIndirectoDescrip1;}
				get{ return this._costoIndirectoDescrip1; }
			}
			public string CostosIndirectosDescrip2
			{
				get{ return this._costoIndirectoDescrip2; }
			}
			public string CostosIndirectosDescrip3
			{
				get{ return this._costoIndirectoDescrip3; }
			}
			public string CostosIndirectosDescrip4
			{
				get{ return this._costoIndirectoDescrip4; }
			}
			public string CostosIndirectosDescrip5
			{
				get{ return this._costoIndirectoDescrip5; }
			}
			public string CostosIndirectosDescrip6
			{
				get{ return this._costoIndirectoDescrip6; }
			}
			public string CostosIndirectosDescrip7
			{
				get{ return this._costoIndirectoDescrip7; }
			}
			public string CostosIndirectosDescrip8
			{
				get{ return this._costoIndirectoDescrip8; }

			}
			public string CostosIndirectosDescrip9
			{
				get{ return this._costoIndirectoDescrip9; }
			}
			public string CostosIndirectosDescrip10
			{
				get{ return this._costoIndirectoDescrip10; }
			}

			private void RecalcularPrecioDeCosto()
			{
				PrecioCosto = _precioDeCostoDirecto + PrecioDeCostoIndirecto;
			}

            // Recupera la variable para ver si un Costo Indirectos se habilita por default
			public bool CostoIndirecto1HabilitadoPorDefault
			{
				get { return _costoIndirecto1HabilitadoPorDefault; }
			}
			public bool CostoIndirecto2HabilitadoPorDefault
			{
				get { return _costoIndirecto2HabilitadoPorDefault; }
			}
			public bool CostoIndirecto3HabilitadoPorDefault
			{
				get { return _costoIndirecto3HabilitadoPorDefault; }
			}
			public bool CostoIndirecto4HabilitadoPorDefault
			{
				get { return _costoIndirecto4HabilitadoPorDefault; }
			}
			public bool CostoIndirecto5HabilitadoPorDefault
			{
				get { return _costoIndirecto5HabilitadoPorDefault; }
			}
			public bool CostoIndirecto6HabilitadoPorDefault
			{
				get { return _costoIndirecto6HabilitadoPorDefault; }
			}
			public bool CostoIndirecto7HabilitadoPorDefault
			{
				get { return _costoIndirecto7HabilitadoPorDefault; }
			}
			public bool CostoIndirecto8HabilitadoPorDefault
			{
				get { return _costoIndirecto8HabilitadoPorDefault; }
			}
			public bool CostoIndirecto9HabilitadoPorDefault
			{
				get { return _costoIndirecto9HabilitadoPorDefault; }
			}
			public bool CostoIndirecto10HabilitadoPorDefault
			{
				get { return _costoIndirecto10HabilitadoPorDefault; }
			}

			// Recupera los Coeficientes en PORCENTAJES.
			public decimal Coeficiente1
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(1, this.PrecioDeCostoDirecto);}
				//set{_coeficiente1 = value;}
			}

			public decimal Coeficiente2
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(2, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente3
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(3, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente4
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(4, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente5
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(5, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente6
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(6, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente7
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(7, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente8
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(8, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente9
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(9, this.PrecioDeCostoDirecto);}
			}

			public decimal Coeficiente10
			{
				get{return CoeficientesIndirectos.GetCoeficientePorc(10, this.PrecioDeCostoDirecto);}
			}

            // Costos Indirectos : 1..10
            public decimal CostoIndirecto1
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(1, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(1, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto2
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(2, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(2, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto3
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(3, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(3, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto4
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(4, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(4, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto5
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(5, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(5, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto6
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(6, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(6, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto7
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(7, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(7, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto8
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(8, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(8, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto9
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(9, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(9, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

            public decimal CostoIndirecto10
            {
                get { return this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
                set
                {
                    if (value != this.CoeficientesIndirectos.GetCoeficienteValor(10, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto))
                    {
                        //Matias 20100722 - Tarea 78
                        //if(_precioDeCostoPromedioPonderado != 0)
                        //{
                        this.CoeficientesIndirectos.SetCoeficienteValor(10, value, this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto);
                        RecalcularPrecioDeCosto();
                        //}
                        //Fin Matias 20100722 - Tarea 78
                    }
                }
            }

			public decimal CostoIndirectoPorc1
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(1); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(1) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(1, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc2
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(2); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(2) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(2, value);
						RecalcularPrecioDeCosto();
					}

				}
			}

			public decimal CostoIndirectoPorc3
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(3); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(3) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(3, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc4
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(4); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(4) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(4, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc5
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(5); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(5) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(5, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc6
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(6); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(6) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(6, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc7
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(7); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(7) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(7, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc8
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(8); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(8) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(8, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc9
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(9); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(9) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(9, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			public decimal CostoIndirectoPorc10
			{
				get{return this.CoeficientesIndirectos.GetCoeficientePorc(10); }
				set
				{
					if( value != this.CoeficientesIndirectos.GetCoeficientePorc(10) )
					{
						this.CoeficientesIndirectos.SetCoeficientePorc(10, value);
						RecalcularPrecioDeCosto();
					}
				}
			}

			// ----------------- CostoIndirectoActivo 1..10
			public bool CostoIndirectoActivo1
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(1);}
			}
			public bool CostoIndirectoActivo2
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(2);}
			}
			public bool CostoIndirectoActivo3
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(3);}
			}
			public bool CostoIndirectoActivo4
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(4);}
			}
			public bool CostoIndirectoActivo5
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(5);}
			}
			public bool CostoIndirectoActivo6
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(6);}
			}
			public bool CostoIndirectoActivo7
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(7);}
			}
			public bool CostoIndirectoActivo8
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(8);}
			}
			public bool CostoIndirectoActivo9
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(9);}
			}
			public bool CostoIndirectoActivo10
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteActivo(10);}
			}
			
			// ----------------- CostoIndirectoTipo 1..10
			public bool CostoIndirectoTipo1
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(1);}
			}
			public bool CostoIndirectoTipo2
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(2);}
			}
			public bool CostoIndirectoTipo3
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(3);}
			}
			public bool CostoIndirectoTipo4
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(4);}
			}
			public bool CostoIndirectoTipo5
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(5);}
			}
			public bool CostoIndirectoTipo6
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(6);}
			}
			public bool CostoIndirectoTipo7
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(7);}
			}
			public bool CostoIndirectoTipo8
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(8);}
			}
			public bool CostoIndirectoTipo9
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(9);}
			}
			public bool CostoIndirectoTipo10
			{
				get {return this.CoeficientesIndirectos.GetCoeficienteTipo(10);}
			}
			// ------------------------

			public decimal PrecioDeVentaNeto 
			{
				set{_precioDeVentaNeto = value;}
			}

			public decimal MaxDescuentoPorcentual 
			{
				set{_maxDescuentoPorcentual = value;}
			}

			public decimal MaxDescuento
			{
				set{_maxDescuento = value;}
			}

			public decimal PrecioDeVentaBruto 
			{
                //Sabrina: Tarea 1068. 20110317
                get { return _precioDeVentaBruto; }
                //Fin Sabrina: Tarea 1068. 20110317
				set{_precioDeVentaBruto = value;}
			}

			//Sabrina: tarea 56
			/*public decimal PrecioDeCostoDirecto 
			{
				set{_precioDeCostoDirecto = value;}
			}*/

			public decimal PrecioDeCostoDirecto 
			{
				get{return _precioDeCostoDirecto;}
				set
				{
					_precioDeCostoDirecto = value;
					PrecioCosto = _precioDeCostoDirecto + this.PrecioDeCostoIndirecto;
				}
			}
			
			/*public decimal PrecioDeCostoIndirecto
			{
				set{_precioDeCostoIndirecto = value;}
			}*/

			/*public decimal PrecioDeCostoIndirecto
			{
				get{return _precioDeCostoIndirecto;}
				set
				{
					_precioDeCostoIndirecto = value;
					PrecioCosto = _precioDeCostoDirecto + _precioDeCostoIndirecto;
				}
			}*/


			public decimal PrecioDeCostoIndirecto
			{
				get{return this.CoeficientesIndirectos.GetCoeficienteValorTotal( this.PrecioDeCostoDirecto, this._cotizacionProductoPrecioDeCosto); }
			}

			public CostosIndirectos CoeficientesIndirectos
			{
				get{return _coeficientesIndirectos;}
				set{_coeficientesIndirectos = value;}
			}

			public long Contador 
			{
				set{_contador = value;}
				get{return _contador;}
			}

			public Image Thumb
			{
				set{_thumb = value;}
				get{return _thumb;}
			}
			public Image Imagen
			{
				set{_imagen = value;}
				get{return _imagen;}
			}
			public string IdBonificacion 
			{
				set{_idBonificacion = value;}
			}


			
			public string IdTiposProducto
			{
				set{_idTipoProducto = value;}
			}
			
			public string IdMonedaCierrePrecioDeVentaBrutoBD
			{
                //Sabrina: Tarea 1068. 20110317
                get { return _idMonedaCierrePrecioDeVentaBruto; }
                //Fin Sabrina: Tarea 1068. 20110317
				set{ _idMonedaCierrePrecioDeVentaBruto = value;}
			}
			
			public string IdMonedaCierrePrecioDeVentaNetoBD
			{
				set{_idMonedaCierrePrecioDeVentaNeto = value;}
			}
			
			public string IdMonedaCierreMaxDescuentoBD
			{
				set{ _idMonedaCierreMaxDescuento = value;}
			}

			public string IdMonedaCierrePrecioDeCostoRefBD
			{
                //Sabrina: Tarea 1068. 20110317
                get { return _idMonedaCierrePrecioDeCostoRef; }
                //Fin Sabrina: Tarea 1068. 20110317
                set { _idMonedaCierrePrecioDeCostoRef = value; }
			}

			
			public string IdCotizacionCierrePrecioDeCostoRefBD
			{
				set{ _idCotizacionCierrePrecioDeCostoRef = value;}
			}
			

			
			public string IdCotizacionCierrePrecioDeVentaBrutoBD
			{
				set{ _idCotizacionCierrePrecioDeVentaBruto= value;}
			}
		
			public string IdCotizacionCierrePrecioDeVentaNetoBD
			{
				set{ _idCotizacionCierrePrecioDeVentaNeto= value;}
			}
		
			public string IdCotizacionCierreMaxDescuentoBD
			{
				set{ _idCotizacionCierreMaxDescuento= value;}
			}
		
			//Sabrina: tarea 56
			/*public decimal Coeficiente1
			{
				get{return _coeficiente1;}
				set{_coeficiente1 = value;}
			}
			
			public decimal Coeficiente2
			{
				get{return _coeficiente2;}
				set{_coeficiente2 = value;}

			}
			

			public decimal Coeficiente3
			{
				get{return _coeficiente3;}
				set{_coeficiente3 = value;}
			}
			
			
			public decimal Coeficiente4
			{
				get{return _coeficiente4;}
				set{_coeficiente4 = value;}
			}
			
			public decimal Coeficiente5
			{
				get{return _coeficiente5;}
				set{_coeficiente5 = value;}
			}
			*/




			public ArrayList Productos
			{
				get{return _productos;}
			}

			public bool ByJerarquia1
			{
				get{return _byJerarquia1;}
				set{_byJerarquia1  = value;}
			}
			public bool ByJerarquia2
			{
				get{return _byJerarquia2;}
				set{_byJerarquia2 = value;}
			}
			public bool ByJerarquia3
			{
				get{return _byJerarquia3;}
				set{_byJerarquia3  = value;}
			}
			public bool ByJerarquia4
			{
				get{return _byJerarquia4;}
				set{_byJerarquia4  = value;}
			}
			public bool ByJerarquia5
			{
				get{return _byJerarquia5;}
				set{_byJerarquia5  = value;}
			}
			public bool ByJerarquia6
			{
				get{return _byJerarquia6;}
				set{_byJerarquia6  = value;}
			}
			public bool ByJerarquia7
			{
				get{return _byJerarquia7;}
				set{_byJerarquia7  = value;}
			}
			public bool ByJerarquia8
			{
				get{return _byJerarquia8;}
				set{_byJerarquia8  = value;}
			}

			public ArrayList Jerarquia1
			{
				get{return _jerarquia1;}
				set{_jerarquia1  = value;}
			}
			public ArrayList Jerarquia2
			{
				get{return _jerarquia2;}
				set{_jerarquia2 = value;}
			}
			public ArrayList Jerarquia3
			{
				get{return _jerarquia3;}
				set{_jerarquia3  = value;}
			}
			public ArrayList Jerarquia4
			{
				get{return _jerarquia4;}
				set{_jerarquia4 = value;}
			}
			public ArrayList Jerarquia5
			{
				get{return _jerarquia5;}
				set{_jerarquia5 = value;}
				
			}
			public ArrayList Jerarquia6
			{
				get{return _jerarquia6;}
				set{_jerarquia6 = value;}				
			}
			public ArrayList Jerarquia7
			{
				get{return _jerarquia7;}
				set{_jerarquia7 = value;}				
			}
			public ArrayList Jerarquia8
			{
				get{return _jerarquia8;}
				set{_jerarquia8 = value;}				
			}

			public bool PercibeIB
			{
				get{return _percibeIB;}
			}


			public string IdCotizacionCierrePrecioDeVentaBruto
			{
				set{_cotizacionProductoPrecioDeVenta = new CotizacionWrapper(value);}
				get{return _cotizacionProductoPrecioDeVenta.IdCotizacion;}
			}

			public string IdCotizacionCierrePrecioDeCostoRef
			{
				set{_cotizacionProductoPrecioDeCosto = new CotizacionWrapper(value);}
				get{return _cotizacionProductoPrecioDeCosto.IdCotizacion;}
			}

				
			public string IdFuenteDeCambioPrecioDeVentaBruto
			{
				get
				{
					if(_cotizacionProductoPrecioDeVenta != null)
						return _cotizacionProductoPrecioDeVenta.IdFuenteDeCambio;
					return string.Empty;
				}
				set
				{
					if(_cotizacionProductoPrecioDeVenta!= null)
					{
						if(value != _cotizacionProductoPrecioDeVenta.IdFuenteDeCambio)
						{
							_cotizacionProductoPrecioDeVenta.IdFuenteDeCambio = value;
							RecalcularPrecios();

						}
					}
				}
			}

			public string IdFuenteDeCambioPrecioDeCostoRef
			{
				get
				{
					if(_cotizacionProductoPrecioDeCosto != null)
						return _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio;
					return string.Empty;
				}
				set
				{
					if(_cotizacionProductoPrecioDeCosto!= null)
					{
						if(value != _cotizacionProductoPrecioDeCosto.IdFuenteDeCambio)
						{
							_cotizacionProductoPrecioDeCosto.IdFuenteDeCambio = value;
							RecalcularPrecios();
						}
					}
				}
			}

			public string IdMonedaCierrePrecioDeVentaBruto
			{
				get
				{
					if(_cotizacionProductoPrecioDeVenta != null)
					{
						return _cotizacionProductoPrecioDeVenta.IdMonedaOrigen;
					}
					return string.Empty;
				}
				set
				{
					if(_cotizacionProductoPrecioDeVenta!= null)
					{
						if(value != _cotizacionProductoPrecioDeVenta.IdMonedaOrigen)
						{
							_cotizacionProductoPrecioDeVenta.IdMonedaOrigen = value;
							SimboloMonedaPrecioDeLista = mz.erp.businessrules.tfi_Monedas.GetByPk(value).Simbolo;
							SimboloMonedaDescuentoMaximo = SimboloMonedaPrecioDeLista;
							SimboloMonedaPrecioDeVentaNeto = SimboloMonedaPrecioDeLista;
							if(SimboloMonedaPrecioDeListaChanged != null)
								SimboloMonedaPrecioDeListaChanged(_cotizacionProductoPrecioDeVenta.Valor, new EventArgs());
							RecalcularPrecios();

						}
					}
				}
			}

			public string IdMonedaCierrePrecioDeCostoRef
			{
				get
				{
					if(_cotizacionProductoPrecioDeCosto != null)
					{
						return _cotizacionProductoPrecioDeCosto.IdMonedaOrigen;
					}
					return string.Empty;
				}
				set
				{
					if(_cotizacionProductoPrecioDeCosto!= null)
					{
						if(value != _cotizacionProductoPrecioDeCosto.IdMonedaOrigen)
						{
							_cotizacionProductoPrecioDeCosto.IdMonedaOrigen = value;
							RecalcularPrecios();
							SimboloMonedaPrecioDeCostoReferencia = mz.erp.businessrules.tfi_Monedas.GetByPk(value).Simbolo;
							if(SimboloMonedaPrecioDeCostoReferenciaChanged != null)
								SimboloMonedaPrecioDeCostoReferenciaChanged(this, new EventArgs());
						}
					}
				}
			}

			public bool ConfiguracionBasica
			{
				get{return _configuracionBasica;}
			}

			public string Idproducto
			{
				get{return _idProducto;}
				set{_idProducto = value;}
			}

			private void RecalcularPrecios()
			{
                //German 20101125 - Tarea 924
				//decimal maxDescPor = _descuentoPorcentual;
                /*Fuerza el cambio del precio de costo para que se recalculen los precios, 
                 * se produce cuando cambian las monedas. Esto no andaba despues de la tarea 796 de Sabrina 
                 * en al cual se modifica la propiedad PrecioDeCosto.
                 * */
                decimal PrecioCostoOriginal = _precioCosto;
                _precioCosto = 0;
                PrecioCosto = PrecioCostoOriginal;
                
                if (_listaDePreciosHabilitadas)
                {
                    this.ListaDePrecios.UpdatePrecios(this._cotizacionProductoPrecioDeCosto.Valor, this._cotizacionProductoPrecioDeVenta.Valor, this.PrecioCosto, this.Margen, this.PrecioNeto);
                    //Sabrina: Tarea 1067. 20110311                    
                    foreach (ListaDePreciosItem item in this.ListaDePrecios.Items)
                    {
                        this.RecalcularDescuentosCombo(item.IdListaDePrecios, item.PrecioDeVentaBruto);
                    }
                    //Fin Sabrina: Tarea 1067. 20110311
                    if (PrecioNetoChanged != null)
                        PrecioNetoChanged(this, EventArgs.Empty);
                }

                //Fin German 20101125 - Tarea 924

			}

			public decimal PrecioLista
			{
				get{return _precioLista;}
				set
				{
					_precioLista = value;
					CalcularPrecioFinal();
					if(_precioDeVentaAfectaMac)
					{
						if(_precioCosto != 0)
						{
							_descuentoMax = _descuentoPorcentual * _precioLista / 100;
							_margen = ((((_precioLista - _descuentoMax) - ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
						}
						else
							_margen = 0;
						_precioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
						if (PrecioNetoChanged!= null)
							PrecioNetoChanged(this,new EventArgs());
						if (MargenChanged!= null)
							MargenChanged(this,new EventArgs());
						if (DescuentoMaxChanged != null)
							DescuentoMaxChanged(this, new EventArgs());
					}
					else
					{
						if (_precioLista != 0)
						{
						
							_descuentoPorcentual = (_precioLista - _precioNeto)*100/_precioLista;
							_descuentoMax =(_precioLista - _precioNeto);
							if (DescuentoMaxChanged != null)
								DescuentoMaxChanged(this, new EventArgs());
						}
					}
                    //Sabrina: Tarea 1067. 20110311
                    if (!_cambioDescuentoCombo)
                    {
                        this.RecalcularDescuentosCombo();
                        if(_cambioMAC)
                            RecalcularDescuentosComboPorCambioPVN();
                        if (ProductosComboChanged != null)
                            ProductosComboChanged(this, new EventArgs());
                    }
                    //Fin Sabrina: Tarea 1067. 20110311
                }
			}

			public event EventHandler PrecioFinalChanged;
			public event EventHandler PrecioFinalMonedaReferenciaChanged;
            //German 20101025 - tarea 880
            public event EventHandler ListaDePreciosPrecioFinalChanged;
			private void CalcularPrecioFinal()
			{
				ObtenerImpuestosAAplicar();
                if (!_listaDePreciosHabilitadas)
                {
                    _precioFinal = businessrules.Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(_precioLista, this.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, impuestosAAplicar);
                    if (PrecioFinalChanged != null)
                        PrecioFinalChanged(this, new EventArgs());
                }
                else
                {
                    if (this.ListaDePrecios != null)
                    {
                        foreach (ListaDePreciosItem item in this.ListaDePrecios.Items)
                        {
                            item.CalcularPrecioDeVentaConImpuestos();
                        }
                        if (ListaDePreciosPrecioFinalChanged != null)
                            ListaDePreciosPrecioFinalChanged(this, new EventArgs());
                    }
                }
			}
            //Fin German 20101025 - tarea 880

			//Se agrega para que el precio de venta incluya el impacto de Ingresos brutos y de seguridad e higuiene
			decimal IB =  0;
			decimal SH = 0;


			//Sabrina 20100719 - Tarea 796
			/*public decimal PrecioCosto
			{
				get{return _precioCosto;}
				set
				{	
					_precioCosto=value;
					//PrecioNeto = (_precioCosto + (_precioCosto* (_margen+IB+SH) /100))* _cotizacionProductoPrecioDeCosto.Valor;				
					PrecioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
				}
			}*/
			
			public decimal PrecioCosto
			{
				get{return _precioCosto;}
				set
				{
					decimal PrecioNetoAnterior = _precioNeto;
					if(_precioCosto != value)
					{
						_precioCosto=value;
						
						if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
						{
							_precioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
							if(PrecioNetoAnterior != 0)
							{
								decimal PListaAnterior = _precioLista;
								decimal Coef = (PListaAnterior - PrecioNetoAnterior)*100/PrecioNetoAnterior;
								PrecioLista = _precioNeto + (_precioNeto * Coef / 100);
							}
							else
								PrecioLista = _precioNeto;
						}
						else
						{
							if(_precioDeVentaAfectaMac)
							{
								if(_precioNeto != 0)
									_margen = ((((_precioLista - _descuentoMax) - ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
								else 
									_margen = 0;
								_precioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
								if (MargenChanged!= null)
									MargenChanged(this,new EventArgs());
							}							
							else
							{
								_precioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
								if(_precioLista != 0)
								{
									_descuentoPorcentual = (_precioLista - _precioNeto)*100/_precioLista;
									_descuentoMax = _precioLista * _descuentoPorcentual / 100;
									if (DescuentoMaxChanged != null)
										DescuentoMaxChanged(this, new EventArgs());
								}
							}
						}
						if (PrecioNetoChanged!= null)
							PrecioNetoChanged(this,new EventArgs());
					}
				}
			}
			//Fin Sabrina 20100719 - Tarea 796

			//Sabrina 20100719 - Tarea 796
			/*public decimal PrecioNeto
			{
				get{return _precioNeto;}
				set
				{
					decimal PrecioNetoAnterior = _precioNeto;
					if(_precioNeto != value)
					{
						_precioNeto=value;
						
						if(_precioDeVentaAfectaMac)
						{
							if(_precioLista != 0)
							{
								decimal PListaAnterior = _precioLista;
								decimal Coef = (PListaAnterior - PrecioNetoAnterior)*100/PrecioNetoAnterior;
								PrecioLista = value + (value * Coef / 100);
							}
							else
								PrecioLista = value;
						}
						else
						{
							if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                                PrecioLista = value;
							else
							{
								if(_precioLista != 0)
								{
									_descuentoPorcentual = (_precioLista - _precioNeto)*100/_precioLista;
									_descuentoMax = _precioLista * _descuentoPorcentual / 100;
									if (DescuentoMaxChanged != null)
										DescuentoMaxChanged(this, new EventArgs());
								}
							}

						}
						if (PrecioNetoChanged!= null)
							PrecioNetoChanged(this,new EventArgs());
					}
				}
			}*/


			public decimal PrecioNeto
			{
				get{return _precioNeto;}
				set
				{
					decimal PrecioNetoAnterior = _precioNeto;
					if(_precioNeto != value)
					{
						_precioNeto=value;
						
						if(_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
						{
							if(PrecioNetoAnterior != 0)
							{
								decimal PListaAnterior = _precioLista;
								decimal Coef = (PListaAnterior - PrecioNetoAnterior)*100/PrecioNetoAnterior;
								PrecioLista = value + (value * Coef / 100);
							}
							else
								PrecioLista = value;
						}
						else
						{
							if(_precioDeVentaAfectaMac)
							{
								if(_precioNeto != 0)
									_margen = ((((_precioLista - _descuentoMax) - ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
								else 
									_margen = 0;
								if (MargenChanged!= null)
									MargenChanged(this,new EventArgs());
							}							
							else
							{
								if(_precioLista != 0)
								{
									_descuentoPorcentual = (_precioLista - _precioNeto)*100/_precioLista;
									_descuentoMax = _precioLista * _descuentoPorcentual / 100;
									if (DescuentoMaxChanged != null)
										DescuentoMaxChanged(this, new EventArgs());
								}
							}

						}
						if (PrecioNetoChanged!= null)
							PrecioNetoChanged(this,new EventArgs());
					}
				}
			}

			//Fin Sabrina 20100719 - Tarea 796

            //Sabrina: Tarea 1068. 20110317
            private bool _cambioMAC = false;
            //Fin Sabrina: Tarea 1068. 20110317

			public decimal Margen
			{
				get{return _margen;}
				set
				{
					_margen=value;
                    //Sabrina: Tarea 1068. 20110317
                    _cambioMAC = true;
                    //Fin Sabrina: Tarea 1068. 20110317
					//PrecioNeto = _precioCosto + (_precioCosto* (_margen+IB+SH) /100);
					PrecioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
                    //Sabrina: Tarea 1068. 20110317
                    _cambioMAC = false;
                    //Fin Sabrina: Tarea 1068. 20110317
                }

			}

			public decimal DescuentoMax
			{
				get{return _descuentoMax;}
				set
				{
					_descuentoMax=value;
					if(!PrecioDeVentaAfectaMac)
					{
						_precioLista = _precioNeto + _descuentoMax;
						if(_precioLista != 0)
						{
							_descuentoPorcentual = (_precioLista - _precioNeto)*100/_precioLista;
							CalcularPrecioFinal();
						}
						else _descuentoPorcentual = 0;
                        //Sabrina: Tarea 1067. 20110311
                        if (!_cambioDescuentoCombo)
                        {
                            this.RecalcularDescuentosCombo();
                            if (ProductosComboChanged != null)
                                ProductosComboChanged(this, new EventArgs());
                        }
                        //Fin Sabrina: Tarea 1067. 20110311
					}
					
					if (DescuentoMaxChanged != null)
						DescuentoMaxChanged(this, new EventArgs());
				}

			}
			public decimal DescuentoPorcentual
			{
				get{return _descuentoPorcentual;}
				set
				{
					_descuentoPorcentual = value;
					if (_precioLista != 0)
					{
						if(_precioDeVentaAfectaMac)
						{
							_descuentoMax = _precioLista * _descuentoPorcentual / 100;
							if(_precioCosto != 0)
								_margen = ((((_precioLista - _descuentoMax) - ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) * 100) / ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
							else
								_margen = 0;
							_precioNeto = ( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor) + (( _precioCosto * _cotizacionProductoPrecioDeCosto.Valor / _cotizacionProductoPrecioDeVenta.Valor)* (_margen+IB+SH) /100);
							if (PrecioNetoChanged!= null)
								PrecioNetoChanged(this,new EventArgs());
							if (MargenChanged!= null)
								MargenChanged(this,new EventArgs());
							if (DescuentoMaxChanged != null)
								DescuentoMaxChanged(this, new EventArgs());
						}
					}

				}
			}

			public decimal PrecioFinal
			{
				get{return _precioFinal;}
				set
				{
					ObtenerImpuestosAAplicar();
					_precioFinal = value;
					System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( impuestosAAplicar);
					PrecioLista  = FuncionesImpuestos.CalcularInversa( formulas, value );
					/*if(_precioLista > 0)
					{
						_descuentoPorcentual = (_precioLista - _precioNeto)*100/_precioLista;
						_descuentoMax =(_precioLista - _precioNeto);
					}
					if(PrecioListaChanged != null)
						PrecioListaChanged(this, new EventArgs());
					if (DescuentoMaxChanged != null)
						DescuentoMaxChanged(this, new EventArgs());*/
				}
			}

			public decimal PrecioFinalMonedaReferencia
			{
				get
				{
					return _precioFinal * _cotizacionProductoPrecioDeVenta.Valor;
				}
				set
				{
					PrecioFinal = value * (1/ _cotizacionProductoPrecioDeVenta.Valor);
				}
			}

			public bool GeneracionDeProductosMasivos
			{
				get{return _generacionDeProductosMasivos;}
			}


			public ProductosJearaquias Jerarquias
			{
				get{return _jerarquias;}
			}

			public ListaDePrecios ListaDePrecios
			{
				get{return _listaDePrecios;}
			}

            //Sabrina: Tarea 1110. 20110805
            public ListaDePreciosProveedores ListaDePreciosProveedores
            {
                get { return _listaDePreciosProveedores; }
            }
            //Fin Sabrina: Tarea 1110. 20110805

			ArrayList _jerarquiasCampoAuxiliar6 = new ArrayList();
			public ArrayList JerarquiasCampoAuxiliar6
			{
				get{return _jerarquiasCampoAuxiliar6;}
			}

			private ProductosJearaquias _jerarquias = new ProductosJearaquias();
			public ControladorProductos(tsh_ProductosExDataset data, string State)
			{

				this._sucursales = new ProductosSucursales();
				this._impuestos = new ProductosImpuestos();
				this._sucActivasONo = new ArrayList();
				this._jerarquias = new ProductosJearaquias();
				this._data = data;
				this._state = State;
				Init();					
			}

			public void InitListaDePrecios()
			{
				//Sabrina 20100706 - Tarea 790
				_listaDePrecios = new ListaDePrecios(this, this._state, _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista);
				//Fin Sabrina 20100706 - Tarea 790
                //German 20120810 - Tarea 0000370
                _listaDePrecios.PrecioDeVentaAfectaMac = this._precioDeVentaAfectaMac;
                //Fin German 20120810 - Tarea 0000370
			}

            //Sabrina: Tarea 1110. 20110805
            public void InitListaDePreciosProveedores()
            {
                _listaDePreciosProveedores = new ListaDePreciosProveedores(this.Idproducto);
              
            }

            public void AddListaDePreciosProveedores(string CodigoProveedor)
            {
                string IdProveedor = tpu_Proveedores.GetPKByCodigo(CodigoProveedor);
                if (IdProveedor != null)
                {
                    ListaDePreciosProveedoresItem item = this._listaDePreciosProveedores.getListaDePreciosProveedoresItem(IdProveedor);
                    if (item == null)
                    {
                        string IdMonedaPrecioDeCostoProveedor = this.IdMonedaCierrePrecioDeCostoRef;
                        string IdFuenteDeCambioListaProveedor = this.IdFuenteDeCambioPrecioDeCostoRef;
                        string IdCotizacionPrecioDeCostoProveedor = this.IdCotizacionCierrePrecioDeCostoRef;
                        string IdMonedaProveedor = this.IdMonedaCierrePrecioDeCostoRef;
                        string IdFuenteDeCambioProveedor = this.IdFuenteDeCambioPrecioDeCostoRef;
                        string IdCotizacionProveedor = this.IdCotizacionCierrePrecioDeCostoRef;
                        if (_usaCotizacionDefault)
                        {
                            IdMonedaProveedor = _idMonedaReferencia;
                            IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
                            IdCotizacionProveedor = Variables.GetValueString("Contabilidad.CotizacionReferencia");
                        }
                        item = new ListaDePreciosProveedoresItem(this.Idproducto, IdProveedor, IdMonedaPrecioDeCostoProveedor, IdFuenteDeCambioListaProveedor, IdCotizacionPrecioDeCostoProveedor, IdCotizacionProveedor, IdFuenteDeCambioProveedor, IdMonedaProveedor, _bonificacionesAcumulativas);
                        this._listaDePreciosProveedores.AddItem(item);
                    }
                }

            }
            //Fin Sabrina: Tarea 1110. 20110805

			public void AddProductoImpuesto(ProductoImpuesto pi) 
			{
				this._impuestos.Add(pi);
			}
			public void AddProductoSucursal(ProductoSucursal ps)
			{
				this._sucursales.Add(ps);				
			}
            //Sabrina: Tarea 1067. 20110311
            private long _ordinalComboDet = 1;
            public void InitProductosCombo()
            {
                //Sabrina 20100706 - Tarea 790
                if (this._state.Equals("EDIT"))
                {
                    long maxOrdinal = 0; 
                    tsh_CombosDetDataset.tsh_CombosDetDataTable table = tsh_CombosDet.GetByIdProducto(this.Idproducto).tsh_CombosDet;
                    foreach (tsh_CombosDetDataset.tsh_CombosDetRow row in table.Rows)
                    {
                        modelo.Combo.ComboDet comboDet = new modelo.Combo.ComboDet(row);
                        _detalleCombo.Add(comboDet);
                        if (row.Ordinal > maxOrdinal)
                            maxOrdinal = row.Ordinal;
                    }
                    _ordinalComboDet = maxOrdinal + 1;
                }
                //Fin Sabrina 20100706 - Tarea 790
            }
            public ArrayList ProductosCombo
            {
                get { return _detalleCombo; }
            }
            //Fin Sabrina: Tarea 1067. 20110311
			private string _listaImpuestosPrecioFinalEstimado = string.Empty;
			private bool _agentePercepcionIB = false;
			private string _impuestosDirectos = string.Empty;
			private bool _habilitaJerarquias = false;
			private string _state = string.Empty;			
			
			private bool _generacionDeProductosMasivos = false;
			private bool _manejaJerarquiasRecursivas = false;

			private string _observaciones = "";
			private string _etiquetaCampoAuxiliar1 = "";
			private string _etiquetaCampoAuxiliar2 = "";
			private string _etiquetaCampoAuxiliar3 = "";
			private string _etiquetaCampoAuxiliar4 = "";
			private string _etiquetaCampoAuxiliar5 = "";
			private string _etiquetaCampoAuxiliar6 = "";
			private string _campoAuxiliar1 = "";
			private string _campoAuxiliar2 = "";
			private string _campoAuxiliar3 = "";
			private string _campoAuxiliar4 = "";
			private string _campoAuxiliar5 = "";			
			private string _campoAuxiliar6 = "";			
			private string _link1 = "";	
			private string _link2 = "";	
			private string _link3 = "";	
			private string _link4 = "";	
			private string _link5 = "";	
			private string _idProductoPadre = string.Empty;
			private string _contenedoresVisibles = string.Empty;
			private string _contenedoresHabilitados = string.Empty;		
			private bool _listaDePreciosHabilitadas = false;		

			public string State
			{
				get {return _state;}
			}

			public string Observaciones
			{
				get {return _observaciones;}
				set {_observaciones = value;}
			}
			public string ContenedoresVisibles
			{
				get{return _contenedoresVisibles;}
			}
			public string ContenedoresHabilitados
			{
				get{return _contenedoresHabilitados;}
			}
			public bool ListaDePreciosHabilitadas
			{
				get{return _listaDePreciosHabilitadas;}
			}
			public string EtiquetaCampoAuxiliar1
			{
				get {return _etiquetaCampoAuxiliar1;}
			}
			public string EtiquetaCampoAuxiliar2
			{
				get {return _etiquetaCampoAuxiliar2;}
			}
			public string EtiquetaCampoAuxiliar3
			{
				get {return _etiquetaCampoAuxiliar3;}
			}
			public string EtiquetaCampoAuxiliar4
			{
				get {return _etiquetaCampoAuxiliar4;}
			}
			public string EtiquetaCampoAuxiliar5
			{
				get {return _etiquetaCampoAuxiliar5;}
			}
			public string EtiquetaCampoAuxiliar6
			{
				get {return _etiquetaCampoAuxiliar6;}
			}
			public string CampoAuxiliar1
			{
				get {return _campoAuxiliar1;}
				set {_campoAuxiliar1 = value;}
			}
			public string CampoAuxiliar2
			{
				get {return _campoAuxiliar2;}
				set {_campoAuxiliar2 = value;}
			}			
			public string CampoAuxiliar3
			{
				get {return _campoAuxiliar3;}
				set {_campoAuxiliar3 = value;}
			}			
			public string CampoAuxiliar4
			{
				get {return _campoAuxiliar4;}
				set {_campoAuxiliar4 = value;}
			}			
			public string CampoAuxiliar6
			{
				get {return _campoAuxiliar6;}
				set {_campoAuxiliar6 = value;}
			}
			public string CampoAuxiliar5
			{
				get {return _campoAuxiliar5;}
				set {_campoAuxiliar5 = value;}
			}	
			public string Link1
			{
				get {return _link1;}
				set {_link1 = value;}
			}	
			public string Link2
			{
				get {return _link2;}
				set {_link2 = value;}
			}	
			public string Link3
			{
				get {return _link3;}
				set {_link3 = value;}
			}	
			public string Link4
			{
				get {return _link4;}
				set {_link4 = value;}
			}	
			public string Link5
			{
				get {return _link5;}
				set {_link5 = value;}
			}	
			public bool DescripcionSoloMayusculas
			{
				get {return _descripcionSoloMayusculas;}
				
			}	
			public string SimboloMonedaPrecioDeCostoReferencia
			{
				get{return _simboloMonedaOrigen;}
				set{_simboloMonedaOrigen = value;}
			}

			public string SimboloMonedaPrecioDeVentaNeto
			{
				get{return _simboloMonedaPrecioDeVentaNeto;}
				set{_simboloMonedaPrecioDeVentaNeto = value;}
			}

			public string SimboloMonedaDescuentoMaximo
			{
				get{return _simboloMonedaDescuentoMaximo;}
				set{_simboloMonedaDescuentoMaximo = value;}
			}

			public string SimboloMonedaPrecioDeLista
			{
				get{return _simboloMonedaPrecioDeLista;}
				set{_simboloMonedaPrecioDeLista = value;}
			}

			public string SimboloMonedaReferencia
			{
				get{return _simboloMonedaReferencia;}
			}

			public decimal ValorCotizacionPrecioDeVenta
			{
				get
				{
					if(_cotizacionProductoPrecioDeVenta != null)
					{
						return _cotizacionProductoPrecioDeVenta.Valor;
					}
					return 1;
				}
			}

			//Sabrina 20100706 - Tarea 790
			public decimal ValorCotizacionPrecioDeCosto
			{
				get
				{
					if(_cotizacionProductoPrecioDeCosto != null)
					{
						return _cotizacionProductoPrecioDeCosto.Valor;
					}
					return 1;
				}
			}
			//Fin Sabrina 20100706 - Tarea 790
			
			public string IdProveedorDefault
			{
				get{return _idProveedorDefault;}
				set{_idProveedorDefault = value;}
			}

			private string _codigoProveedorDefault = string.Empty;
			public string CodigoProveedorDefault
			{
				get{return _codigoProveedorDefault;}
				set
				{
					if(value != _codigoProveedorDefault)
					{
						_codigoProveedorDefault = value;
						_idProveedorDefault = mz.erp.businessrules.tpu_Proveedores.GetPKByCodigo(_codigoProveedorDefault);
					}
				}
			}

			// ---- Matias - Custom 8 - Tarea 276 - 20090716			
			private string _IdResponsableCreacion = string.Empty;
			private string _responsableIngreso = string.Empty;
			private bool _allowEditResponsableIngreso = false;
			private bool _askForPasswordResponsableIngreso = false;
			private string _ultimoResponsableClaveCorrecta = string.Empty;			
			
			public string IdResponsableCreacion
			{
				get{return _IdResponsableCreacion;}
				set
				{
					if(_IdResponsableCreacion != value)
					{				
						_IdResponsableCreacion = value;					
						if ( _IdResponsableCreacion != null && !_IdResponsableCreacion.Equals(string.Empty) )
						{
							tsh_PersonasDataset.tsh_PersonasRow row = businessrules.tsh_Personas.GetByPk(value);
							_responsableIngreso =  row.Nombre;						
						}
						else 
						{
							_responsableIngreso = string.Empty;
						}
					}
				}
			}

            /* Silvina 20101115 - Tarea 930 */
            private DateTime _fechaAlta = mz.erp.businessrules.Sistema.DateTime.Now;
            public DateTime FechaAlta
            {
                get { return _fechaAlta; }
                set { _fechaAlta = value; }
            }
            /* Fin Silvina */

			public string ResponsableIngreso
			{
				get{return _responsableIngreso;}
				set{_responsableIngreso=value;}
			}
			public bool AllowEditResponsableIngreso
			{
				get{return _allowEditResponsableIngreso;}
				set{_allowEditResponsableIngreso=value;}
			}
			public bool AskForPasswordResponsableIngreso
			{
				get{return _askForPasswordResponsableIngreso;}
				set{_askForPasswordResponsableIngreso=value;}
			}
			public string UltimoResponsableClaveCorrecta
			{
				get{return _ultimoResponsableClaveCorrecta;}
				set{_ultimoResponsableClaveCorrecta=value;}
			}
			// ---- Fin Matias.

			//Sabrina: tarea 56
			public bool UsaListaDePreciosProveedores
			{
				get{return _usaListaDePreciosProveedores;}
			}

			public bool PermiteModificarPrecioDeCostoReposicion
			{
				get{return _permiteModificarPrecioDeCostoReposicion;}			
			}

			public bool PermiteModificarUsaPrecioDeCostoReposicion
			{
				get{return _permiteModificarUsaPrecioDeCostoReposicion;}			
			}

			public bool PermiteModificarPrecioDeCostoPromedioPonderado
			{
				get{return _permiteModificarPrecioDeCostoPromedioPonderado;}			
			}

			private bool _descripcionSoloMayusculas = true;

			private string _idMonedaReferencia = string.Empty;
			private string _idFuenteDeCambioProveedor = string.Empty;
			private string _idCotizacionReferencia = string.Empty;	
			private bool _trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = false;

			private bool _permiteModificarPrecioDeCostoReposicion = true;
			private bool _permiteModificarUsaPrecioDeCostoReposicion = true;
			private bool _permiteModificarPrecioDeCostoPromedioPonderado = false;
 

            /* Silvina 20101116 - Tarea 920 */

            private bool _permiteModificarObservaciones = true;
            public bool PermiteModificarObservaciones
            {
                get { return _permiteModificarObservaciones; }
            }

            private bool _permiteAgregarObservaciones = true;
            public bool PermiteAgregarObservaciones
            {
                get { return _permiteAgregarObservaciones; }
            }


            /* Fin Silvina */

            //Sabrina: Tarea 1067. 20110311
            private DataTable _listaDePreciosTable = null;
            public System.Data.DataTable ListaDePreciosTable
            {
                get { return _listaDePreciosTable; }
            }

            public string KeyValueListaDePrecios
            {
                get { return "IdListaDePrecio"; }
            }
            public string KeyListListaDePrecios
            {
                get { return "Descripcion"; }
            }
            private string _idListaDePreciosDefault = string.Empty;
            public string IdListaDePreciosDefault
            {
                get { return _idListaDePreciosDefault; }
                set { _idListaDePreciosDefault = value; }
            }

            private string _idListaDePreciosProductosCombo = string.Empty;
            public string IdListaDePreciosProductosCombo
            {
                get { return _idListaDePreciosProductosCombo; }
                set
                {
                    if (_idListaDePreciosProductosCombo != value)
                    {
                        _idListaDePreciosProductosCombo = value;
                        foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                        {
                            comboDet.IdListaDePreciosReferencia = _idListaDePreciosProductosCombo;
                        }                       
                        if (ProductosComboChanged != null)
                            ProductosComboChanged(this, new EventArgs());
                    }
                }
            }

            private bool _cambioDescuentoCombo = false;
            public bool CambioDescuentoCombo
            {
                set { _cambioDescuentoCombo = value; }
            }
            public void RecalcularPreciosCombo()
            {
                decimal precioCosto = 0;
                Hashtable preciosLista = new Hashtable();
                foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                {
                    decimal precioCostoCDMP = (comboDet.PrecioDeCostoRef * comboDet.Cantidad) * comboDet.ValorCotizacionPrecioDeCostoRef / this.ValorCotizacionPrecioDeCosto;
                    precioCosto = precioCosto + precioCostoCDMP;
                    decimal precioListaItem = 0;
                    foreach (modelo.Combo.ListaDePreciosComboDetItem itemDet in comboDet.ListaDePreciosComboDet.Items)
                    {                       
                        if (!preciosLista.ContainsKey(itemDet.IdListaDePrecio))
                        {
                            preciosLista.Add(itemDet.IdListaDePrecio, precioListaItem);
                        }
                        precioListaItem = (decimal)preciosLista[itemDet.IdListaDePrecio];
                        decimal precioListaItemMP = (itemDet.PrecioDeVentaBruto * comboDet.Cantidad) * itemDet.ValorCotizacionPrecioDeVentaBruto / this.ValorCotizacionPrecioDeVenta;
                        preciosLista[itemDet.IdListaDePrecio] = precioListaItem + precioListaItemMP;
                    }
                }
                _cambioDescuentoCombo = true;
                this.RecalcularPrecioDeCostoReferencia(precioCosto);
                foreach (ListaDePreciosItem item in this.ListaDePrecios.Items)
                {
                    decimal precioListaItem = 0;
                    if (preciosLista.ContainsKey(item.IdListaDePrecios))
                        precioListaItem = (decimal)preciosLista[item.IdListaDePrecios];
                    decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(precioListaItem);
                    this.ListaDePrecios.UpdateCoeficiente(item, coeficienteNew);
                }
                ListaDePreciosItem itemDefault = this.ListaDePrecios.GetDefaultItem();
                this.PrecioLista = itemDefault.PrecioDeVentaBruto;
                _cambioDescuentoCombo = false;
            }

            public void RecalcularPrecioDeCostoReferencia(decimal PrecioDeCostoRef)
            {
                PrecioDeCostoPromedioPonderado = PrecioDeCostoRef;
                PrecioDeCostoReposicion = PrecioDeCostoRef;

            }
            public void AplicarDescuentoCombo(decimal DescuentoComboProcentual) 
            {
                foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                {
                    comboDet.DescuentoComboProcentual = DescuentoComboProcentual;
                }
                this.RecalcularPreciosCombo();
                if (ProductosComboChanged != null)
                    ProductosComboChanged(this, new EventArgs());
            }

            public void BorrarProductosCombo()
            {
                this.RecalcularPreciosCombo();
            }

            private ArrayList _listaDeProductosComboAEliminar = new ArrayList();
            public void ListaDeProductosComboSeleccionadoABorrar(ArrayList aux)
            {
                if (this._state.Equals("EDIT"))
                {
                    foreach (modelo.Combo.ComboDet comboDet in aux)
                    {
                        if (!comboDet.Estado.Equals("NEW"))
                        {
                            comboDet.Estado = "DEL";
                            foreach (modelo.Combo.ListaDePreciosComboDetItem comboDetItem in comboDet.ListaDePreciosComboDet.Items)
                            {
                                if (!comboDetItem.Estado.Equals("NEW"))
                                {
                                    comboDetItem.Estado = "DEL";
                                }
                            }
                            _listaDeProductosComboAEliminar.Add(comboDet);
                        }

                    }
                }
            }

            public void RecalcularDescuentosCombo()
            {
                if (EsCombo)
                {
                    decimal precioBrutoOriginal = 0;
                    foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                    {
                        decimal precioBrutoOriginalCDMP = (comboDet.PrecioDeVentaBrutoOriginal * comboDet.Cantidad) * comboDet.ValorCotizacionPrecioDeVentaBruto / this.ValorCotizacionPrecioDeVenta;
                        precioBrutoOriginal = precioBrutoOriginal + precioBrutoOriginalCDMP;
                    }
                    if (precioBrutoOriginal != 0)
                    {
                        decimal nuevoDescuentoCombo = (((PrecioLista - precioBrutoOriginal) * 100) / precioBrutoOriginal) * -1;
                        foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                        {
                            comboDet.DescuentoComboProcentual = nuevoDescuentoCombo;
                        }
                    }
                }

            }

            public void RecalcularDescuentosComboPorCambioPVN()
            {
                if (EsCombo)
                {
                    decimal precioBrutoOriginal = 0;
                    foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                    {
                        decimal precioBrutoOriginalCDMP = (comboDet.PrecioDeVentaBrutoOriginal * comboDet.Cantidad) * comboDet.ValorCotizacionPrecioDeVentaBruto / this.ValorCotizacionPrecioDeVenta;
                        precioBrutoOriginal = precioBrutoOriginal + precioBrutoOriginalCDMP;
                    }
                    if (precioBrutoOriginal != 0)
                    {
                        decimal nuevoDescuentoCombo = (((PrecioLista - precioBrutoOriginal) * 100) / precioBrutoOriginal) * -1;
                        foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                            comboDet.DescuentoComboProcentual = nuevoDescuentoCombo;
                    }
                }

            }

            public void RecalcularDescuentosCombo(string IdListaDePrecios, decimal PrecioDeVentaBruto)
            {
                if (EsCombo)
                {
                    decimal precioBrutoOriginalLPItem = 0;
                    foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                    {
                        modelo.Combo.ListaDePreciosComboDetItem comboDetItem = comboDet.ListaDePreciosComboDet.GetItem(comboDet.IdProducto, comboDet.Ordinal, IdListaDePrecios);
                        decimal precioBrutoOriginalLPItemMP = (comboDetItem.PrecioDeVentaBrutoOriginal * comboDet.Cantidad) * comboDetItem.ValorCotizacionPrecioDeVentaBruto / this.ValorCotizacionPrecioDeVenta;
                        precioBrutoOriginalLPItem = precioBrutoOriginalLPItem + precioBrutoOriginalLPItemMP;
                    }
                    if (precioBrutoOriginalLPItem != 0)
                    {
                        decimal nuevoDescuentoCombo = (((PrecioDeVentaBruto - precioBrutoOriginalLPItem) * 100) / precioBrutoOriginalLPItem) * -1;
                        foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                        {
                            comboDet.UpdateDescuentoPorcentual(IdListaDePrecios, nuevoDescuentoCombo);
                            if (_idListaDePreciosProductosCombo.Equals(IdListaDePrecios))
                                comboDet.DescuentoComboProcentual = nuevoDescuentoCombo;
                        }                        
                    }
                }

            }
            public void SetearCostosACero()
            {
                this.CostoIndirecto1 = 0;
                this.CostoIndirecto2 = 0;
                this.CostoIndirecto3 = 0;
                this.CostoIndirecto4 = 0;
                this.CostoIndirecto5 = 0;
                this.CostoIndirecto6 = 0;
                this.CostoIndirecto7 = 0;
                this.CostoIndirecto8 = 0;
                this.CostoIndirecto9 = 0;
                this.CostoIndirecto10 = 0;
                this.PrecioDeCostoPromedioPonderado = 0;
                this.PrecioDeCostoReposicion = 0;
            }
            //Fin Sabrina: Tarea 1067. 20110311
            
            //Sabrina: Tarea 1068. 20110317
            public bool CambioCostoProductosCombo()
            {
                bool cambio = false;
                if (this.State.Equals("EDIT"))
                {
                    if (this.PrecioDeCostoRefBD != this.PrecioCosto)
                    {
                        tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(this.Idproducto).tsh_CombosDet;
                        if (tableProdCombo.Rows.Count > 0)
                            cambio = true;
                    }
                }
                return cambio;
            }
           
            public bool CambioPrecioVentaProductosCombo()
            {
                bool cambio = false;
                if (this.State.Equals("EDIT"))
                {
                    if (this.PrecioDeVentaBrutoBD != this.PrecioLista)
                    {
                        tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(this.Idproducto).tsh_CombosDet;
                        if (tableProdCombo.Rows.Count > 0)
                            cambio = true;
                    }
                }
                return cambio;
            }

            public bool CambioMonedaProductosCombo()
            {
                bool cambio = false;
                if (this.State.Equals("EDIT"))
                {
                    if ((this.IdMonedaCierrePrecioDeCostoRefBD != this.IdMonedaCierrePrecioDeCostoRef) || (this.IdMonedaCierrePrecioDeVentaBrutoBD != this.IdMonedaCierrePrecioDeVentaBruto))
                    {
                        tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(this.Idproducto).tsh_CombosDet;
                        if (tableProdCombo.Rows.Count > 0)
                            cambio = true;
                    }
                }
                return cambio;
            }

            private bool _actualizaPreciosProductosCombo = false;
            public bool ActualizaPreciosProductosCombo
            {
                get { return _actualizaPreciosProductosCombo; }
                set { _actualizaPreciosProductosCombo = value; }
            }

            public tsh_ProductosExDataset ActualizarPreciosProductosCombo()
            {
                if (this.ActualizaPreciosProductosCombo)
                {
                    tsh_CombosDetDataset.tsh_CombosDetDataTable tableProdCombo = tsh_CombosDet.GetByIdProductoReferencia(this.Idproducto).tsh_CombosDet;
                    tsh_ListasDePreciosDataset.tsh_ListasDePreciosDataTable tableLP = tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
                    foreach (tsh_CombosDetDataset.tsh_CombosDetRow rowCDBD in tableProdCombo.Rows)
                    {
                        tsh_ProductosExDataset.tsh_ProductosRow rowP = _data.tsh_Productos.FindByIdProducto(rowCDBD.IdProducto);
                        if (rowP == null)
                        {
                            tsh_ProductosDataset.tsh_ProductosRow rowPBD = tsh_Productos.GetByPk(rowCDBD.IdProducto);
                            _data.tsh_Productos.ImportRow(rowPBD);
                            tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosDataTable tablePLP = tsh_ProductosListasDePrecios.GetByIdProducto(rowCDBD.IdProducto).tsh_ProductosListasDePrecios;
                            foreach (tsh_ProductosListasDePreciosDataset.tsh_ProductosListasDePreciosRow rowPLP in tablePLP.Rows)
                            {
                                _data.tsh_ProductosListasDePrecios.ImportRow(rowPLP);
                            }
                        }
                        _data.tsh_CombosDet.ImportRow(rowCDBD);

                        //Actualizo tsh_CombosDet y tsh_CombosDetListasDePrecios
                        tsh_ProductosExDataset.tsh_CombosDetRow rowCD = _data.tsh_CombosDet.FindByIdProductoOrdinal(rowCDBD.IdProducto, rowCDBD.Ordinal);
                        if (rowCD.PrecioDeCostoRef != this.PrecioDeCostoRef)
                        {
                            rowCD.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
                            rowCD.PrecioDeCostoRef = this.PrecioDeCostoRef;
                        }
                       
                        rowCD.IdMonedaCierrePrecioDeCostoRef = this.IdMonedaCierrePrecioDeCostoRef;
                        rowCD.IdMonedaCierrePrecioDeVentaBruto = this.IdMonedaCierrePrecioDeVentaBruto;
                        rowCD.IdCotizacionCierrePrecioDeCostoRef = this.IdCotizacionCierrePrecioDeCostoRef;
                        rowCD.IdCotizacionCierrePrecioDeVentaBruto = this.IdCotizacionCierrePrecioDeVentaBruto;

                        if (rowCD.PrecioDeVentaBrutoOriginal != this.PrecioDeVentaBruto)
                        {
                            rowCD.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                            rowCD.PrecioDeVentaBrutoOriginal = this.PrecioDeVentaBruto;
                            decimal nuevoDescuentoCombo = (this.PrecioDeVentaBruto * rowCD.DescuentoComboPorcentual) / 100;
                            rowCD.DescuentoCombo = nuevoDescuentoCombo;
                            rowCD.PrecioDeVentaBruto = this.PrecioDeVentaBruto - nuevoDescuentoCombo;

                            //Actualizo tsh_CombosDetListasDePrecios
                            foreach (ListaDePreciosItem itemLP in this.ListaDePrecios.Items)
                            {
                                tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow rowCDLP = tsh_CombosDetListasDePrecios.GetByPk(rowCD.IdProducto, rowCD.Ordinal, itemLP.IdListaDePrecios);
                                if (rowCDLP == null)
                                {
                                    tsh_ProductosExDataset.tsh_CombosDetListasDePreciosRow rowCDLPEx = _data.tsh_CombosDetListasDePrecios.Newtsh_CombosDetListasDePreciosRow();
                                    rowCDLPEx.IdProducto = rowCD.IdProducto;
                                    rowCDLPEx.Ordinal = rowCD.Ordinal;
                                    rowCDLPEx.IdListaDePrecio = itemLP.IdListaDePrecios;
                                    rowCDLPEx.ModoDeAplicacion = itemLP.ModoDeAplicacion;
                                    rowCDLPEx.Coeficiente = itemLP.CoeficienteProducto;
                                    rowCDLPEx.PrecioDeVentaBrutoOriginal = itemLP.PrecioDeVentaBruto;
                                    rowCDLPEx.DescuentoCombo = 0;
                                    rowCDLPEx.DescuentoComboPorcentual = 0;
                                    rowCDLPEx.PrecioDeVentaBruto = itemLP.PrecioDeVentaBruto;
                                    rowCDLPEx.FechaCreacion = DateTime.Now;
                                    rowCDLPEx.IdConexionCreacion = Security.IdConexion;
                                    rowCDLPEx.IdConexionUltimaModificacion = Security.IdConexion;
                                    rowCDLPEx.IdReservado = 0;
                                    rowCDLPEx.RowId = Guid.Empty;
                                    rowCDLPEx.IdEmpresa = Security.IdEmpresa;
                                    rowCDLPEx.IdSucursal = Security.IdSucursal;
                                    _data.tsh_CombosDetListasDePrecios.Addtsh_CombosDetListasDePreciosRow(rowCDLPEx);
                                }
                                else
                                {
                                    rowCDLP.ModoDeAplicacion = itemLP.ModoDeAplicacion;
                                    rowCDLP.Coeficiente = itemLP.CoeficienteProducto;
                                    if (rowCDLP.PrecioDeVentaBrutoOriginal != itemLP.PrecioDeVentaBruto)
                                        rowCDLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                                    rowCDLP.PrecioDeVentaBrutoOriginal = itemLP.PrecioDeVentaBruto;
                                    rowCDLP.DescuentoCombo = (rowCDLP.PrecioDeVentaBrutoOriginal * rowCDLP.DescuentoComboPorcentual) / 100;
                                    rowCDLP.PrecioDeVentaBruto = rowCDLP.PrecioDeVentaBrutoOriginal - rowCDLP.DescuentoCombo;
                                    _data.tsh_CombosDetListasDePrecios.ImportRow(rowCDLP);
                                }
                            }
                        }
                    }

                    //Actualizo tsh_Productos y tsh_ProductosListasDePrecios
                    foreach (tsh_ProductosExDataset.tsh_ProductosRow rowP in _data.tsh_Productos.Rows)
                    {
                        if (rowP.EsCombo)
                        {
                            CotizacionWrapper cotizacionProductoPrecioDeVenta = new CotizacionWrapper(rowP.IdCotizacionCierrePrecioDeVentaBruto);
                            CotizacionWrapper cotizacionProductoPrecioDeCosto = new CotizacionWrapper(rowP.IdCotizacionCierrePrecioDeCostoRef);
                            tsh_CombosDetDataset.tsh_CombosDetDataTable tableComboDetProd = tsh_CombosDet.GetByIdProducto(rowP.IdProducto).tsh_CombosDet;
                            decimal precioCosto = 0;
                            Hashtable preciosLista = new Hashtable();
                            foreach (tsh_CombosDetDataset.tsh_CombosDetRow rowCDBD in tableComboDetProd.Rows)
                            {
                                CotizacionWrapper cotizacionProductoPrecioDeVentaCD = new CotizacionWrapper(rowCDBD.IdCotizacionCierrePrecioDeVentaBruto);
                                CotizacionWrapper cotizacionProductoPrecioDeCostoCD = new CotizacionWrapper(rowCDBD.IdCotizacionCierrePrecioDeCostoRef);

                                tsh_ProductosExDataset.tsh_CombosDetRow rowCD = _data.tsh_CombosDet.FindByIdProductoOrdinal(rowCDBD.IdProducto, rowCDBD.Ordinal);
                                decimal precioCostoCDMP = 0;
                                if (rowCD == null)
                                    precioCostoCDMP = ( rowCDBD.PrecioDeCostoRef * rowCDBD.Cantidad) * cotizacionProductoPrecioDeCostoCD.Valor / cotizacionProductoPrecioDeCosto.Valor;
                                else
                                {
                                    cotizacionProductoPrecioDeVentaCD = new CotizacionWrapper(rowCD.IdCotizacionCierrePrecioDeVentaBruto);
                                    cotizacionProductoPrecioDeCostoCD = new CotizacionWrapper(rowCD.IdCotizacionCierrePrecioDeCostoRef);
                                    precioCostoCDMP = (rowCD.PrecioDeCostoRef * rowCD.Cantidad) * cotizacionProductoPrecioDeCostoCD.Valor / cotizacionProductoPrecioDeCosto.Valor;
                                }
                                precioCosto = precioCosto + precioCostoCDMP;

                                decimal precioListaItem = 0;
                                tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosDataTable tableComboDetLP = tsh_CombosDetListasDePrecios.GetByIdProductoOrdinal(rowCDBD.IdProducto, rowCDBD.Ordinal).tsh_CombosDetListasDePrecios;
                                foreach (tsh_CombosDetListasDePreciosDataset.tsh_CombosDetListasDePreciosRow rowLPCDBD in tableComboDetLP.Rows)
                                {
                                    if (!preciosLista.ContainsKey(rowLPCDBD.IdListaDePrecio))
                                    {
                                        preciosLista.Add(rowLPCDBD.IdListaDePrecio, precioListaItem);
                                    }
                                    precioListaItem = (decimal)preciosLista[rowLPCDBD.IdListaDePrecio];
                                    tsh_ProductosExDataset.tsh_CombosDetListasDePreciosRow rowCDLP = _data.tsh_CombosDetListasDePrecios.FindByIdProductoOrdinalIdListaDePrecio(rowLPCDBD.IdProducto, rowLPCDBD.Ordinal, rowLPCDBD.IdListaDePrecio);
                                    decimal precioDeVentaBrutoCDLPMP = 0;
                                    if (rowCDLP == null)
                                        precioDeVentaBrutoCDLPMP = ( rowLPCDBD.PrecioDeVentaBruto * rowCDBD.Cantidad) * cotizacionProductoPrecioDeVentaCD.Valor / cotizacionProductoPrecioDeVenta.Valor;
                                    else
                                        precioDeVentaBrutoCDLPMP = (rowCDLP.PrecioDeVentaBruto * rowCDBD.Cantidad) * cotizacionProductoPrecioDeVentaCD.Valor / cotizacionProductoPrecioDeVenta.Valor; 
                                    preciosLista[rowLPCDBD.IdListaDePrecio] = precioListaItem + precioDeVentaBrutoCDLPMP;
                                }
                            }
                            if(rowP.PrecioDeCostoRef != precioCosto)
                                rowP.FechaUltimaModificacionPrecioDeCosto = DateTime.Now;
                            rowP.PrecioDeCostoRef = precioCosto;
                            //Los costos indirectos de un combo son siempre 0
                            rowP.PrecioDeCostoDirecto = rowP.PrecioDeCostoRef;
                            rowP.PrecioDeCostoReposicion = rowP.PrecioDeCostoRef;
                            rowP.PrecioDeCostoPromedioPonderado = rowP.PrecioDeCostoRef;
                            this.RecalcularPrecioDeVentaNeto(rowP);

                            //Actualizo tsh_ProductosListasDePrecios
                            foreach (tsh_ListasDePreciosDataset.tsh_ListasDePreciosRow rowLP in tableLP.Rows)
                            {
                                tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow rowPLP = _data.tsh_ProductosListasDePrecios.FindByIdProductoIdListaDePrecio(rowP.IdProducto, rowLP.IdListaDePrecio);
                                if (rowPLP != null)
                                {
                                    decimal precioListaItem = 0;
                                    if (preciosLista.ContainsKey(rowPLP.IdListaDePrecio))
                                        precioListaItem = (decimal)preciosLista[rowPLP.IdListaDePrecio];
                                    this.RecalcularPreciosListasDePreciosPorCambioPrecioDeVentaBruto(rowP, rowPLP, precioListaItem);
                                }
                            }

                        }
                    }
                }
                return _data;
            }


            private void RecalcularPreciosListasDePreciosPorCambioPrecioDeVentaBruto(tsh_ProductosExDataset.tsh_ProductosRow rowP, tsh_ProductosExDataset.tsh_ProductosListasDePreciosRow rowPLP, decimal nuevoPrecioDeVentaBrutoLP)
            {
                decimal coeficienteNew = 0;
                if (rowP.PrecioDeVentaNeto != 0)
                    coeficienteNew = ((nuevoPrecioDeVentaBrutoLP - rowP.PrecioDeVentaNeto) * 100) / rowP.PrecioDeVentaNeto;
                rowPLP.Coeficiente = coeficienteNew;
                decimal coeficienteProductoMonedaReferencia = (rowP.PrecioDeVentaNeto * rowPLP.Coeficiente) / 100;
                rowPLP.PrecioDeVentaBruto = rowP.PrecioDeVentaNeto + ((rowP.PrecioDeVentaNeto * rowPLP.Coeficiente) / 100);
                if (_precioDeVentaAfectaMac)
                {
                    if (rowP.PrecioDeCostoRef != 0)
                    {
                        rowPLP.MaxDescuento = rowPLP.MaxDescuentoPorcentual * rowPLP.PrecioDeVentaBruto / 100;
                    }
                }
                else //Afecta el descuento
                {
                    rowPLP.MaxDescuento = rowPLP.PrecioDeVentaBruto - rowP.PrecioDeVentaNeto;
                    if (rowPLP.PrecioDeVentaBruto != 0)
                        rowPLP.MaxDescuentoPorcentual = rowPLP.MaxDescuento * 100 / rowPLP.PrecioDeVentaBruto;
                    else
                        rowPLP.MaxDescuentoPorcentual = 100;
                }
                rowPLP.FechaUltimaModificacionPrecioDeVenta = DateTime.Now;
                System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas(null, null, rowPLP.IdProducto);
                decimal impuestosBrutos = mz.erp.businessrules.comprobantes.FuncionesImpuestos.Calcular(formulas, rowPLP.PrecioDeVentaBruto);
                rowPLP.PrecioDeVentaBrutoConImpuesto = rowPLP.PrecioDeVentaBruto + impuestosBrutos;
            }
            
            private void RecalcularPrecioDeVentaNeto(tsh_ProductosExDataset.tsh_ProductosRow row)
            {
                decimal PrecioNetoAnterior = row.PrecioDeVentaNeto;
				CotizacionWrapper cotizacionProductoPrecioDeVenta = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeVentaBruto);
				CotizacionWrapper cotizacionProductoPrecioDeCosto = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeCostoRef);
                if (_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista)
                {
                    row.PrecioDeVentaNeto = (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) + ((row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) * (row.MAC + IB + SH) / 100);
                    if (PrecioNetoAnterior != 0)
                    {
                        decimal PListaAnterior = row.PrecioDeVentaBruto;
                        decimal Coef = (PListaAnterior - PrecioNetoAnterior) * 100 / PrecioNetoAnterior;
                        decimal nuevoPrecioDeVentaBruto = row.PrecioDeVentaNeto + (row.PrecioDeVentaNeto * Coef / 100);
                        this.RecalcularPrecioDeVentaBruto(row, nuevoPrecioDeVentaBruto);
                    }
                    else
                        this.RecalcularPrecioDeVentaBruto(row, row.PrecioDeVentaNeto);
                }
                else
                {
                    if (_precioDeVentaAfectaMac)
                    {
                        if (row.PrecioDeVentaNeto != 0)
                            row.MAC = ((((row.PrecioDeVentaBruto - row.MaxDescuento) - (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor)) * 100) / (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                        else
                            row.MAC = 0;
                        row.PrecioDeVentaNeto = (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) + ((row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) * (row.MAC + IB + SH) / 100);
                    }
                    else
                    {
                        row.PrecioDeVentaNeto = (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) + ((row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) * (row.MAC + IB + SH) / 100);
                        if (row.PrecioDeVentaBruto != 0)
                        {
                            row.MaxDescuentoPorcentual = (row.PrecioDeVentaBruto - row.PrecioDeVentaNeto) * 100 / row.PrecioDeVentaBruto;
                            row.MaxDescuento = row.PrecioDeVentaBruto * row.MaxDescuentoPorcentual / 100;
                        }
                    }
                }
            }

           private void RecalcularPrecioDeVentaBruto(tsh_ProductosExDataset.tsh_ProductosRow row, decimal PrecioDeVentaBruto)
           {
                CotizacionWrapper cotizacionProductoPrecioDeVenta = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeVentaBruto);
                CotizacionWrapper cotizacionProductoPrecioDeCosto = new CotizacionWrapper(row.IdCotizacionCierrePrecioDeCostoRef);

                row.PrecioDeVentaBruto = PrecioDeVentaBruto;
                if (_precioDeVentaAfectaMac)
                {
                    if (row.PrecioDeCostoRef != 0)
                    {
                        row.MaxDescuento = row.MaxDescuentoPorcentual * row.PrecioDeVentaBruto / 100;
                        row.MAC = ((((row.PrecioDeVentaBruto - row.MaxDescuento) - (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor)) * 100) / (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor)) - IB - SH;
                    }
                    else
                        row.MAC = 0;
                    row.PrecioDeVentaNeto = (row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) + ((row.PrecioDeCostoRef * cotizacionProductoPrecioDeCosto.Valor / cotizacionProductoPrecioDeVenta.Valor) * (row.MAC + IB + SH) / 100);
                }
                else
                {
                    if (row.PrecioDeVentaBruto != 0)
                    {
                        row.MaxDescuentoPorcentual = (row.PrecioDeVentaBruto - row.PrecioDeVentaNeto) * 100 / row.PrecioDeVentaBruto;
                        row.MaxDescuento = (row.PrecioDeVentaBruto - row.PrecioDeVentaNeto);
                    }
                }
            }
            //Fin Sabrina: Tarea 1068. 20110317


            /* Fin Silvina */
			public void Init()
			{				 
				// Var de la Tarea 31
				_usaCotizacionDefault = Variables.GetValueBool("Productos.UsaCotizacionDefault");
				_idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
				_idFuenteDeCambioProveedor = Variables.GetValueString("Contabilidad.FuenteDeCambioReferencia");
				_idCotizacionReferencia =  Variables.GetValueString("Contabilidad.CotizacionReferencia");
                // --
				_configuracionBasica = Variables.GetValueBool("Productos.Precios.ConfiguracionBasica");
                //German 20110605 - Tarea 0000149
                _listaImpuestosPrecioFinalEstimado = Variables.GetValueString("Productos.ProductosSucursales.PrecioFinalEstimado.ImpuestosAsociados") + "," + mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternosString();
                //Fin German 20110605 - Tarea 0000149
				_agentePercepcionIB = Variables.GetValueBool("Sistema.PercibeIB");
               //German 20110605 - Tarea 0000149
				_impuestosDirectos = Variables.GetValueString("Productos.Impuestos.ImpuestosDirectos") + "," + mz.erp.businessrules.tsy_Impuestos.GetListImpuestosInternosString() ;
                //Fin German 20110605 - Tarea 0000149
				_habilitaJerarquias = Variables.GetValueBool("Productos.ABMProductos.HabilitaJerarquias");
				_generacionDeProductosMasivos = Variables.GetValueBool("Productos.ABMProductos.GeneracionDeProductosMasivos");
				_manejaJerarquiasRecursivas = Variables.GetValueBool("Productos.ABMProductos.ManejaJerarquiasRecursivas");
				_etiquetaCampoAuxiliar1 = Variables.GetValueString("Productos.CampoAuxiliar1.Etiqueta");
				_etiquetaCampoAuxiliar2 = Variables.GetValueString("Productos.CampoAuxiliar2.Etiqueta");
				_etiquetaCampoAuxiliar3 = Variables.GetValueString("Productos.CampoAuxiliar3.Etiqueta");
				_etiquetaCampoAuxiliar4 = Variables.GetValueString("Productos.CampoAuxiliar4.Etiqueta");
                _etiquetaCampoAuxiliar5 = Variables.GetValueString("Productos.CampoAuxiliar5.Etiqueta");
				_etiquetaCampoAuxiliar6 = Variables.GetValueString("Productos.CampoAuxiliar6.Etiqueta");
				_contenedoresVisibles = Variables.GetValueString("Momentos.ABMProductos.ContenedoresVisibles");
				_contenedoresHabilitados = Variables.GetValueString("Momentos.ABMProductos.ContenedoresHabilitados");
				_listaDePreciosHabilitadas = Variables.GetValueBool("Productos.ListasDePrecios");
				//_coeficientesPorVariable = Variables.GetValueBool("Productos.PrecioDeCosto.Coeficientes.PorVariable");
				ArrayList imps = mz.erp.systemframework.Util.Parse(_impuestosDirectos, ",");
				_descripcionSoloMayusculas = Variables.GetValueBool("Productos.Descripcion.SoloMayusculas");
				string idMonedaReferencia = Variables.GetValueString("Contabilidad.MonedaReferencia");
				_simboloMonedaReferencia = mz.erp.businessrules.tfi_Monedas.GetByPk(idMonedaReferencia).Simbolo;
				_simboloMonedaOrigen = _simboloMonedaReferencia;
				_simboloMonedaPrecioDeVentaNeto = _simboloMonedaReferencia;
				_simboloMonedaPrecioDeLista = _simboloMonedaReferencia;
				_simboloMonedaDescuentoMaximo = _simboloMonedaReferencia;

				//Sabrina: tarea 56
				_usaPrecioDeCostoReposicion = Variables.GetValueBool("Productos.PrecioDeCosto.UsaPrecioDeCostoReposicion");
				_usaListaDePreciosProveedores = Variables.GetValueBool("Productos.Compras.Facturas.UsaPrecioDeListaProveedor");
				_usaCostosIndirectos = Variables.GetValueBool("Productos.PrecioDeCosto.UsaCostosIndirectos", _usaCostosIndirectos);
				_trasladaCambioPrecioDeCostoListaProveedorAPrecioDeLista = Variables.GetValueBool("Productos.Precio.ModificaPrecioDeCostoListaProveedorTrasladaPrecioDeVentaBruto");

				_permiteModificarPrecioDeCostoReposicion = Variables.GetValueBool("Productos.ABMProductos.PermiteModificarPrecioDeCostoReposicion");
                _permiteModificarUsaPrecioDeCostoReposicion = Variables.GetValueBool("Productos.ABMProductos.PermiteModificarUsaPrecioDeCostoReposicion");
				_permiteModificarPrecioDeCostoPromedioPonderado = Variables.GetValueBool("Productos.ABMProductos.PermiteModificarPrecioDeCostoPromedioPonderado");
				
				_costoIndirecto1HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto1HabilitadoPorDefault");
				_costoIndirecto2HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto2HabilitadoPorDefault");
				_costoIndirecto3HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto3HabilitadoPorDefault");
				_costoIndirecto4HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto4HabilitadoPorDefault");
				_costoIndirecto5HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto5HabilitadoPorDefault");
				_costoIndirecto6HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto6HabilitadoPorDefault");
				_costoIndirecto7HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto7HabilitadoPorDefault");
				_costoIndirecto8HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto8HabilitadoPorDefault");
				_costoIndirecto9HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto9HabilitadoPorDefault");
				_costoIndirecto10HabilitadoPorDefault = Variables.GetValueBool("Momentos.ABMProductos.CostoIndirecto10HabilitadoPorDefault");

				_bonificacionesAcumulativas = Variables.GetValueBool("Productos.BonificacionAcumulativa");

				// ---- Matias - tarea 276
				_allowEditResponsableIngreso = Variables.GetValueBool("Momentos.ABMProductos.Editar.ResponsableIngreso");
				_askForPasswordResponsableIngreso = Variables.GetValueBool("Momentos.ABMProductos.HabilitarContraseña.ResponsableIngreso");
				if (_allowEditResponsableIngreso)
					this.IdResponsableCreacion = null;
				else
					this.IdResponsableCreacion = mz.erp.businessrules.Security.IdPersona;
                // ---- Fin Matias.

				if(_data.tsh_Productos.Rows.Count > 0)
				{
					this.Idproducto =(string)_data.tsh_Productos.Rows[0]["IdProducto"]; 
					if(_data.tsh_Productos.Rows[0]["IdProveedorDefault"] != null && !_data.tsh_Productos.Rows[0]["IdProveedorDefault"].ToString().Equals(string.Empty))
						_idProveedorDefault = (string)_data.tsh_Productos.Rows[0]["IdProveedorDefault"];
					if(_idProveedorDefault != null && _idProveedorDefault != string.Empty)
					{
						_codigoProveedorDefault = mz.erp.businessrules.tpu_Proveedores.GetCodigoByPK(_idProveedorDefault);
						DataRow rowAux = mz.erp.businessrules.tpu_ProveedoresProductos.GetByPk(_idProveedorDefault,Idproducto);
						if(rowAux != null)
						{
							if(rowAux["BonificacionAcumulativa"] != null)
                                _bonificacionesAcumulativas = (bool)rowAux["BonificacionAcumulativa"];
						}
					}
                    //Sabrina: Tarea 1110. 20110805
					//_codigoProductoSegunProveedor = Convert.ToString(_data.tsh_Productos.Rows[0]["CodigoProveedor"]);
                    //Fin Sabrina: Tarea 1110. 20110805
					_idProductoPadre = Convert.ToString(_data.tsh_Productos.Rows[0]["IdProducto"]); 
					this._percibeIB = Convert.ToBoolean(_data.tsh_Productos.Rows[0]["PercibeIB"]);

                    /* Silvina 20101115 - Tarea 930 */
                    if (!_data.tsh_Productos.Rows[0]["FechaCreacion"].Equals(System.DBNull.Value))
                        FechaAlta = Convert.ToDateTime(_data.tsh_Productos.Rows[0]["FechaCreacion"]).Date;
                    else
                        FechaAlta = Convert.ToDateTime("01/01/1753").Date;
                    /* Fin Silvina */               

					sy_SucursalesDataset data = mz.erp.businessrules.sy_Sucursales.GetList();
					sy_EmpresasDataset.sy_EmpresasRow rowE = null;
					foreach(tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowPS in _data.tsh_ProductosSucursales)
					{
						ProductoSucursal ps = new ProductoSucursal();
						sy_SucursalesDataset.sy_SucursalesRow rowS = mz.erp.businessrules.sy_Sucursales.GetByPk(rowPS.IdSucursal);
						rowE = mz.erp.businessrules.sy_Empresas.GetByPk(rowS.IdEmpresa);						
						ps.Init(rowS,rowE,rowPS,this);
						this.AddProductoSucursal(ps);
						this._sucActivasONo.Add(rowPS.IdSucursal);				
					}

					foreach(sy_SucursalesDataset.sy_SucursalesRow row in data.sy_Sucursales.Rows)
					{
						if(!this._sucActivasONo.Contains(row.IdSucursal))
						{
							ProductoSucursal ps = new ProductoSucursal();
							rowE = mz.erp.businessrules.sy_Empresas.GetByPk(row.IdEmpresa);
							ps.Init(row,rowE,this);
							this.AddProductoSucursal(ps);
						}					
					}	

					DataSet dataImp = tsy_ImpuestosEx.GetList();					
					//System.Collections.Hashtable impuestos = new Hashtable();
					foreach (DataRow row in dataImp.Tables[0].Rows) 
					{
						//impuestos.Add(row["IdImpuesto"],row["Descripcion"]);
						if(imps.Contains(Convert.ToString(row["Impuesto"])))
						{
							ProductoImpuesto pi = new ProductoImpuesto();
							pi.IdImpuesto = row["IdImpuesto"].ToString();
							pi.Descripcion = row["Descripcion"].ToString();
							pi.Formula = row["FormulaDeCalculo"].ToString();
							pi.Key = Convert.ToString(row["Impuesto"]);
							pi.DescripcionCorta = Convert.ToString(row["DescripcionCorta"]);
							pi.Activo = businessrules.tsy_ImpuestosProductos.Find(this.Idproducto, row["IdImpuesto"].ToString());
							pi.ActivoChanged +=new EventHandler(pi_ActivoChanged);
							this.AddProductoImpuesto(pi);
						}
					}

					if (this.Sucursales.Count == 1) 
					{						
						foreach(ProductoSucursal ps in this.Sucursales)
						{
							ps.IsAvailable = true;
						}
					}
					if(_habilitaJerarquias)
					{
						foreach(DataRow rowJ in _data.tsh_AgrupProductos.Rows)
						{
							ProductoJerarquia pj = new ProductoJerarquia();
							pj.IdProducto = this.Idproducto;
							pj.Jerarquia = Convert.ToString(rowJ["Jerarquia"]);
							pj.IdNomenclatura = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetPkByJerarquia(Convert.ToString(rowJ["Jerarquia"]));
							this._jerarquias.Add(pj);
						}
					}
					
					_jerarquiasCampoAuxiliar6.Clear();
					string CampoAuxiliar6BD =(string)_data.tsh_Productos.Rows[0]["CampoAuxiliar6"];
                    /* Silvina 20111226 - Tarea 0000241 */
                    string _separador = Variables.GetValueString("Productos.CampoAuxiliar6.JerarquiaAsociada.Separador");
                    if (string.IsNullOrEmpty(_separador))
                        _separador = ",";
					ArrayList CampoAuxiliar6BDList = mz.erp.systemframework.Util.Parse(CampoAuxiliar6BD, _separador);
                    /* Fin Silvina 20111226 - Tarea 0000241 */
					foreach(string aux in CampoAuxiliar6BDList)
					{
						if(aux != null && aux != string.Empty)
						{
							DataRow row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetPkByDescripcion(aux);
							ItemJerarquia pj = new ItemJerarquia("PRODUCTOS");
							pj.NodeKeyPath = Convert.ToString(row["Jerarquia"]);
							pj.NodeKey = Convert.ToString(row["IdNomenclatura"]);
							_jerarquiasCampoAuxiliar6.Add(pj);

						}
					}


					tsh_ProductosAuxiliaresDataset.tsh_ProductosAuxiliaresRow rowAuxiliares = mz.erp.businessrules.tsh_ProductosAuxiliares.GetByPk(this.Idproducto);
					/*if(_coeficientesPorVariable)
					{
						_coeficiente1 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente1");
						_coeficiente2 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente2");
						_coeficiente3 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente3");
						_coeficiente4 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente4");
						_coeficiente5 = Variables.GetValueDecimal("Productos.PrecioDeCosto.Coeficiente5");
					}
					else
					{
						
						if(rowAuxiliares != null)
						{
							_coeficiente1 = Convert.ToDecimal(rowAuxiliares["Coeficiente1"]);
							_coeficiente2 = Convert.ToDecimal(rowAuxiliares["Coeficiente2"]);
							_coeficiente3 = Convert.ToDecimal(rowAuxiliares["Coeficiente3"]);
							_coeficiente4 = Convert.ToDecimal(rowAuxiliares["Coeficiente4"]);
							_coeficiente5 = Convert.ToDecimal(rowAuxiliares["Coeficiente5"]);
						}
					}
					*/

					if(rowAuxiliares != null)
					{
						_codigoSecundario1 = Convert.ToString(rowAuxiliares["CodigoSecundario1"]);
						_codigoSecundario2 = Convert.ToString(rowAuxiliares["CodigoSecundario2"]);
						_codigoSecundario3 = Convert.ToString(rowAuxiliares["CodigoSecundario3"]);
						_codigoSecundario4 = Convert.ToString(rowAuxiliares["CodigoSecundario4"]);
						_codigoSecundario5 = Convert.ToString(rowAuxiliares["CodigoSecundario5"]);
						_codigoSecundario6 = Convert.ToString(rowAuxiliares["CodigoSecundario6"]);
						_codigoSecundario7 = Convert.ToString(rowAuxiliares["CodigoSecundario7"]);
						_codigoSecundario8 = Convert.ToString(rowAuxiliares["CodigoSecundario8"]);
						_codigoSecundario9 = Convert.ToString(rowAuxiliares["CodigoSecundario9"]);
						_codigoSecundario10 = Convert.ToString(rowAuxiliares["CodigoSecundario10"]);
						_codigoSecundario11 = Convert.ToString(rowAuxiliares["CodigoSecundario11"]);
						_codigoSecundario12 = Convert.ToString(rowAuxiliares["CodigoSecundario12"]);
						_codigoSecundario13 = Convert.ToString(rowAuxiliares["CodigoSecundario13"]);
						_codigoSecundario14 = Convert.ToString(rowAuxiliares["CodigoSecundario14"]);
						_codigoSecundario15 = Convert.ToString(rowAuxiliares["CodigoSecundario15"]);
						_codigoSecundario16 = Convert.ToString(rowAuxiliares["CodigoSecundario16"]);
						_codigoSecundario17 = Convert.ToString(rowAuxiliares["CodigoSecundario17"]);
						_codigoSecundario18 = Convert.ToString(rowAuxiliares["CodigoSecundario18"]);
						_codigoSecundario19 = Convert.ToString(rowAuxiliares["CodigoSecundario19"]);
						_codigoSecundario20 = Convert.ToString(rowAuxiliares["CodigoSecundario20"]);
						_tieneCodigoSecundarioSegmentado = Convert.ToBoolean(rowAuxiliares["TieneCodigoSecundarioSegmentado"]);
                        /* Silvina 20110630 - Tarea 0000136 */
                        _permiteCambio = Convert.ToBoolean(rowAuxiliares["PermiteCambio"]);
                        /* Fin Silvina 20110630 - Tarea 0000136 */
					}
					
					
					/*ProductoImpuesto pi = new ProductoImpuesto();
					pi.Activo = true;
					pi.Descripcion = "DESC IVA";
					pi.IdImpuesto = "IVA";
					pi.Formula = "formulita de calculo";
					this.AddProductoImpuesto(pi);*/
					//System.Collections.Hashtable formulas = mz.erp.businessrules.comprobantes.FuncionesImpuestos.ObtenerFormulas( null, null, IdProducto );  

					if(!this._state.Equals("NEW"))
					{
						string idMonedaPrecioDeCosto = (string)_data.tsh_Productos.Rows[0]["IdMonedaCierrePrecioDeCostoRef"]; 
						_simboloMonedaOrigen = mz.erp.businessrules.tfi_Monedas.GetByPk(idMonedaPrecioDeCosto).Simbolo;
						string idMonedaPrecioDeVentaNeto = (string)_data.tsh_Productos.Rows[0]["IdMonedaCierrePrecioDeVentaNeto"]; 
						_simboloMonedaPrecioDeVentaNeto = mz.erp.businessrules.tfi_Monedas.GetByPk(idMonedaPrecioDeVentaNeto).Simbolo;
						_simboloMonedaPrecioDeLista = _simboloMonedaPrecioDeVentaNeto;
						_simboloMonedaDescuentoMaximo = _simboloMonedaPrecioDeVentaNeto;
					}
					
				}			

                /* Silvina 20101116 - Tarea 920 */

                _permiteModificarObservaciones = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "PermiteModificarObservaciones",true);
                _permiteAgregarObservaciones = Variables.GetValueBool("ProcesoABMProductos", "ABMProductos", "PermiteAgregarObservaciones",true); 
           
                /* Fin Silvina */
                
                //Sabrina: Tarea 1067. 20110311
                _listaDePreciosTable = businessrules.tsh_ListasDePrecios.GetList().tsh_ListasDePrecios;
                _idListaDePreciosDefault = businessrules.tsh_ListasDePrecios.GetDefault().IdListaDePrecio;
                //Fin Sabrina: Tarea 1067. 20110311


			}	
		
			public ArrayList ObtenerImpuestosAAplicar()
			{
				ArrayList imp = mz.erp.systemframework.Util.Parse(_listaImpuestosPrecioFinalEstimado, ",");
				impuestosAAplicar.Clear();
				foreach(ProductoImpuesto i in this.Impuestos)
				{
					if(imp.Contains(i.Key)&& i.Activo)
						impuestosAAplicar.Add(i.IdImpuesto);
				}
				return impuestosAAplicar;
			}

			public bool ValidarCodigo(string Codigo)
			{
				if(Codigo != null && Codigo != string.Empty)
				{
					string IdProd = mz.erp.businessrules.tsh_Productos.GetIdProductoByCodigo(Codigo);

                    //German 20100426
                    return (IdProd == null || IdProd.Equals(string.Empty) || IdProd == Idproducto);
                    //Fin German 20100426
				}
				return true;
			}


			public ProductosImpuestos Impuestos 
			{
				get{return _impuestos;}
				set{_impuestos = value;}		
			}
			
			
			
			

			public ProductosSucursales Sucursales
			{
				get{return _sucursales;}
				set{_sucursales = value;}
			}


			public void SetImpuestosDefault() 
			
			{
				string _impuestosPorDefecto = Variables.GetValueString("Productos.Impuestos.Default");
				ArrayList ArrImpuestosDefault = systemframework.Util.Parse(_impuestosPorDefecto, ",");				
				foreach (string Impuesto in ArrImpuestosDefault) 
				{
					CollectionBase aux = this.Impuestos;				
					foreach(ProductoImpuesto ps in aux) 
					{					
						if (ps.Key == Impuesto) 
						{
							ps.Activo = true;
						}
					}
				}
			}

			public void ClearProductos()
			{
				this._productos = new ArrayList();
			}


			public void CopiarCodigoSecundario(string CodigoSecundario)
			{
				foreach(ProductoABMProducto prod in this._productos)
				{
					prod.CodigoSecundario = CodigoSecundario;
				}
			}

			public void RemoveProductos(ArrayList productos)
			{
				foreach(ProductoABMProducto prod in productos)
				{
					this._productos.Remove(prod);
				}
				
			}

			private ArrayList _jerarquiasACombinar = new ArrayList();

			public void CombinarDescripciones(string Descripcion,  ArrayList Jerarquias)
			{
				_jerarquiasACombinar.Clear();
				foreach(object aux in Jerarquias)
				{
					if(!aux.Equals(Constantes.CampoDescripcionProductoKey))
						_jerarquiasACombinar.Add(aux);
				}
				ArrayList result = new ArrayList();
				Hashtable maping = new Hashtable();
				string separador = " ";
				foreach(object j in Jerarquias)
				{
					if(j.Equals(Constantes.CampoDescripcionProductoKey))
					{
						if(result.Count == 0) result.Add(Descripcion);
						else
						{
							for(int i = 0; i < result.Count; i++)
							{
								string aux = Convert.ToString(result[i]);
								ArrayList innerList = new ArrayList();
								if(maping.ContainsKey(aux))
									innerList = (ArrayList)maping[aux];
								ArrayList newInnerList = new ArrayList();
								newInnerList.AddRange(innerList);
								if(maping.ContainsKey(aux))
									maping.Remove(aux);
								aux = aux + separador + Descripcion;
								if(!maping.ContainsKey(aux))
									maping.Add(aux, newInnerList);
								result[i] = aux;
							}
							
						}
					}
					else
					{	
						if(j.GetType().Equals(typeof(System.Collections.ArrayList)))
						{
							ArrayList jerList = (ArrayList)j;
							ArrayList aux = new ArrayList();
							ArrayList resultAux = new ArrayList();
							foreach(ItemJerarquia it in jerList)
							{
							
								string keyPath = it.NodeKeyPath;
								ArmaDescripcionRecursivo(keyPath, aux);
							
							}
							if(result.Count == 0)
							{
								foreach(ArrayList nueva in aux)
								{
									string desc = Convert.ToString(nueva[0]);
									result.Add( desc);
									string IdJerarquia = Convert.ToString(nueva[1]);
									ArrayList innerList = new ArrayList();
									innerList.Add(IdJerarquia);
									maping.Add(desc, innerList);
								}
							}
							else
							{
								foreach(string aux1 in result)
								{
									foreach(ArrayList nueva in aux)
									{
										string desc = Convert.ToString(nueva[0]);
										string IdJerarquia = Convert.ToString(nueva[1]);
										string newDesc = aux1 + separador + desc;
										resultAux.Add( newDesc);
										
										ArrayList innerList = new ArrayList();
										if(maping.ContainsKey(aux1))
											innerList = (ArrayList)maping[aux1];
										ArrayList newInnerList = new ArrayList();
										newInnerList.AddRange(innerList);
										newInnerList.Add(IdJerarquia);
										if(!maping.ContainsKey(newDesc))
											maping.Add(newDesc, newInnerList);
										
									}
									if(maping.ContainsKey(aux1))
										maping.Remove(aux1);
								}
								result = resultAux;
							}
							
						}
					}
				}
				_productos = new ArrayList();
				foreach(string desc in result)
				{
					ProductoABMProducto p = new ProductoABMProducto();
					p.Descripcion = desc;
					if(maping.ContainsKey(desc))
						p.Jerarquias = (ArrayList)maping[desc];
					_productos.Add(p);
				}

			}

			private void ArmaDescripcionRecursivo(string Padre, ArrayList Resultado)
			{
				DataRow row; 
				string j = Padre.Substring(Padre.Length - 20);
				DataSet data = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetList(j, false);
				if(data.Tables[0].Rows.Count == 0 || !_manejaJerarquiasRecursivas)
				{
									
					row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(j);
					if(row != null)
					{
						string desc = Convert.ToString(row["Descripcion"]);
						string IdJerarquia = Convert.ToString(row["Jerarquia"]);
						ArrayList aux = new ArrayList();
						aux.Add(desc);
						aux.Add(IdJerarquia);
						Resultado.Add(aux);
					}
							
				}
				else
				{
					foreach(DataRow r in data.Tables[0].Rows)
					{
						string Hijo = Convert.ToString(r["Jerarquia"]);
						string DescHijo = Convert.ToString(r["Descripcion"]);
						ArmaDescripcionRecursivo(Hijo, Resultado);	
					
					}
					row = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(j);
					if(row != null)
					{
						string desc = Convert.ToString(row["Descripcion"]);
						AgregarDescripcion(desc, Resultado);
					}
					
				}
					

			}


			private void AgregarDescripcion(string Descripcion , ArrayList Resultado)
			{
				string separador = " ";
				for(int i = 0; i < Resultado.Count; i++)
				{
					ArrayList aux = (ArrayList)Resultado[i];
					string desc = Convert.ToString(aux[0]);
					string saux = Descripcion + separador +  desc  ;
					aux[0] = saux;
				}
			}

            //Sabrina: Tarea 1067. 20110311
            private void CommitProductosCombo(string IdProducto)
            {
                if (this._esCombo)
                {
                    if (this._idProducto.Equals(IdProducto))
                    {
                        foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                        {
                            _data = comboDet.Commit(_data);
                        }
                        //Tengo que borrar los combodet que se borraron de un combo modificado si es que hay alguno
                        foreach (modelo.Combo.ComboDet comboDetABorrar in _listaDeProductosComboAEliminar)
                        {
                            _data = comboDetABorrar.Commit(_data);
                        }
                        
                    }
                    else
                    {
                        foreach (modelo.Combo.ComboDet comboDet in ProductosCombo)
                        {
                            modelo.Combo.ComboDet comboDetNuevo = new modelo.Combo.ComboDet(Idproducto, comboDet.Ordinal, comboDet.IdProductoReferencia, comboDet.Cantidad, comboDet.DescuentoCombo, comboDet.DescuentoComboProcentual, comboDet.PrecioDeVentaBrutoOriginal, comboDet.PrecioDeCostoRef);
                            _data = comboDetNuevo.Commit(_data);
                        }
                    }
                }
            }
            //Fin Sabrina: Tarea 1067. 20110311

			private void CommitProducto(string IdProducto)
			{				
				DataRow _row = _data.Tables["tsh_productos"].Select("IdProducto=" + IdProducto)[0];
				//if(this.IdProveedorDefault != string.Empty) Actualiza mal al editar un producto y borrarle su Proveedor default
					_row["IdProveedorDefault"] = this._idProveedorDefault;
				_row["Codigo"] = this._codigo;
				_row["CodigoSecundario"] = this._codigoSecundarioBD;
				_row["Descripcion"] = this._descripcionBD;
				_row["DescripcionCorta"] = this._descripcionCortaBD;
				_row["DescripcionLarga"] = this._descripcionLargaBD;
				_row["ObligaCodigoBarra"] = this._obligaCodigoBarra;
				_row["ObligaNumeroSerie"] = this._obligaNumeroSerie;
				_row["Activo"] = this._activo;
				_row["PercibeIB"] = this._percibeIBBD;
				_row["MAC"] = this._MAC;
				if(((decimal)_row["PrecioDeCostoRef"]) != this._precioDeCostoRef)
					_row["FechaUltimaModificacionPrecioDeCosto"] = DateTime.Now;
				_row["PrecioDeCostoRef"] = this._precioDeCostoRef;
				_row["PrecioDeVentaNeto"] = this._precioDeVentaNeto;
				_row["MaxDescuentoPorcentual"] = this._maxDescuentoPorcentual;
				_row["MaxDescuento"] = this._maxDescuento;
				if(((decimal)_row["PrecioDeVentaBruto"]) != this._precioDeVentaBruto)
					_row["FechaUltimaModificacionPrecioDeVenta"] = DateTime.Now;
				_row["PrecioDeVentaBruto"] = this._precioDeVentaBruto;
				_row["PrecioDeCostoDirecto"] = this._precioDeCostoDirecto;
				_row["PrecioDeCostoIndirecto"] = this.PrecioDeCostoIndirecto;
				_row["IdBonificacion"] = this._idBonificacion;
				_row["IdTipoProducto"] = this._idTipoProducto;
				_row["IdMonedaCierrePrecioDeVentaBruto"]= this._idMonedaCierrePrecioDeVentaBruto;
				_row["IdMonedaCierrePrecioDeVentaNeto"]=this._idMonedaCierrePrecioDeVentaNeto;
				_row["IdMonedaCierreMaxDescuento"]= this._idMonedaCierreMaxDescuento;
				_row["IdMonedaCierrePrecioDeCostoRef"] = this._idMonedaCierrePrecioDeCostoRef;
				_row["IdCotizacionCierrePrecioDeCostoRef"] = this._idCotizacionCierrePrecioDeCostoRef;//cotizacionPrecioDeCosto.IdCotizacion;
				_row["IdCotizacionCierrePrecioDeVentaBruto"] =this._idCotizacionCierrePrecioDeVentaBruto;//cotizacionPrecioDeVenta.IdCotizacion;
				_row["IdCotizacionCierrePrecioDeVentaNeto"] = this._idCotizacionCierrePrecioDeVentaNeto;
				_row["IdCotizacionCierreMaxDescuento"] = this._idCotizacionCierreMaxDescuento;				
				_row["Observaciones"] = this._observaciones;
				_row["CampoAuxiliar1"] = this._campoAuxiliar1;
				_row["CampoAuxiliar2"] = this._campoAuxiliar2;
				_row["CampoAuxiliar3"] = this._campoAuxiliar3;
				_row["CampoAuxiliar4"] = this._campoAuxiliar4;
				_row["CampoAuxiliar5"] = this._campoAuxiliar5;
				_row["CampoAuxiliar6"] = this._campoAuxiliar6;
                //Sabrina: Tarea 1110. 20110805
				//_row["CodigoProveedor"] = this._codigoProductoSegunProveedor;
                //Fin Sabrina: Tarea 1110. 20110805

				//Sabrina: tarea 56
				_row["UsaPrecioDeCostoReposicion"] = this.UsaPrecioDeCostoReposicion;
				_row["PrecioDeCostoReposicion"] = this.PrecioDeCostoReposicion;
				_row["PrecioDeCostoPromedioPonderado"] = this.PrecioDeCostoPromedioPonderado;

				_row["IdResponsableCreacion"] = this.IdResponsableCreacion;

                //Sabrina: Tarea 1067. 20110311
                _row["EsCombo"] = this._esCombo;
                //Fin Sabrina: Tarea 1067. 20110311

			}

			public void CommitProductosCoeficientesAplicados(string IdProducto)		
			{
				//_data.tsh_ProductosCoeficientesAplicados.Clear();
				if(_state == "EDIT")
				{
					tsh_ProductosCoeficientesAplicadosDataset.tsh_ProductosCoeficientesAplicadosRow RowPca = tsh_ProductosCoeficientesAplicados.GetByPk(IdProducto);
					foreach( CostosIndirectosItem item in this.CoeficientesIndirectos )
					{
						item.Commit(item.Orden, RowPca);
					}

					_data.tsh_ProductosCoeficientesAplicados.ImportRow(RowPca);
				}
				else
				{
					tsh_ProductosExDataset.tsh_ProductosCoeficientesAplicadosRow RowPca = _data.tsh_ProductosCoeficientesAplicados.Newtsh_ProductosCoeficientesAplicadosRow();
					foreach( CostosIndirectosItem item in this.CoeficientesIndirectos )
					{
						item.Commit(item.Orden, RowPca);
					}
					RowPca.IdProducto = IdProducto;
					_data.tsh_ProductosCoeficientesAplicados.Addtsh_ProductosCoeficientesAplicadosRow(RowPca);
				}
			}


            //German 20111107 - Tarea 0000224


            private void ComitListaDePreciosProductoGeneracionMasiva(string IdProducto)
            {
                if (this._idProducto.Equals(IdProducto))
                    _data = _listaDePrecios.Commit(_data);
                else
                {
                    ArrayList oldItems = _listaDePrecios.Items;
                    _listaDePrecios.setItemsGeneracionMasiva(_listaDePrecios.Items, IdProducto, this);
                    _data = _listaDePrecios.Commit(_data);
                    _listaDePrecios.Items = oldItems;
                }
            }
            //Fin German 20111107 - Tarea 0000224


            private void ComitListaDePreciosProducto(string IdProducto)
			{
				if(this._idProducto.Equals(IdProducto))
					_data = _listaDePrecios.Commit(_data);
				else
				{
					ArrayList oldItems = _listaDePrecios.Items;
					_listaDePrecios.setItems(_listaDePrecios.Items, IdProducto);
					_data = _listaDePrecios.Commit(_data);
					_listaDePrecios.Items = oldItems;
				}
			}
			
			private void ComitListaDePreciosProducto(string IdProducto, ListaDePreciosItem item)
			{
				if(this._idProducto.Equals(IdProducto))
					_data = item.Commit(_data);
				else
				{
					item.IdProducto = IdProducto;
					_data = item.Commit(_data);
				}
			}
            
			//Sabrina: Tarea 1110. 20110805
            //Ahora guardamos en tpu_ProveedoresProductos y tpu_ProveedoresProductosAuxiliares todo lo q este en _listaDePreciosProveedores y no solo lo del proveedor default
            /*private void CommitProveedoresProducto(string IdProducto)
			{
				_data.tpu_ProveedoresProductos.Clear();
				// chequear q _idProveedorDefautl no sea blanco o null.
				if ( (!(this._idProveedorDefault == null)) && (!(this._idProveedorDefault.Equals(string.Empty))) )
				{
					// buscar en tpu_proveedoresproductos si existe una con fila con IdProducto e _idProveedroDefault.
					DataRow rowAux = mz.erp.businessrules.tpu_ProveedoresProductos.GetByPk(this._idProveedorDefault,IdProducto);
					if(rowAux == null)
					{	
						// No existe, creo la fila y la agrego a la tabla tpu_ProveedoresProductos dentro del dataset en la variable _data.
						tsh_ProductosExDataset.tpu_ProveedoresProductosRow row = _data.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();						
						mz.erp.businessrules.tpu_ProveedoresProductos.SetRowDefaultValues( row );																
						row.IdProducto = IdProducto;
						row.IdProveedor = this._idProveedorDefault;
						
						// Nuevos campos agregados - Tarea 31 - 20081027
						row.IdCotizacionPrecioDeCosto = this.IdCotizacionCierrePrecioDeCostoRef;
						row.IdFuenteDeCambio = this.IdFuenteDeCambioPrecioDeCostoRef;
						row.IdMonedaPrecioDeCosto = this.IdMonedaCierrePrecioDeCostoRef;						
						row.IdCotizacionProveedor = this.IdCotizacionCierrePrecioDeCostoRef;
						row.IdFuenteDeCambioProveedor = this.IdFuenteDeCambioPrecioDeCostoRef;
						row.IdMonedaProveedor = this.IdMonedaCierrePrecioDeCostoRef;						
						row.ValorCotizacionProveedor = tfi_CotizacionesMonedas.GetCotizacion(this.IdCotizacionCierrePrecioDeCostoRef).Valor;
						// por ahora estos campos no van...
						//row.PrecioDeCosto = this.PrecioDeCostoRef;
						//row.PrecioDeCostoFinal = this.PrecioFinal;
						if(_usaCotizacionDefault)
						{
							row.IdCotizacionProveedor = _idCotizacionReferencia;
							row.IdFuenteDeCambioProveedor = _idFuenteDeCambioProveedor;
							row.IdMonedaProveedor = _idMonedaReferencia;
							row.ValorCotizacionProveedor = tfi_CotizacionesMonedas.GetCotizacion(_idCotizacionReferencia).Valor;
						}
						row["BonificacionAcumulativa"] = _bonificacionesAcumulativas;
						// --
						_data.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow( row ); //_data.tpu_ProveedoresProductos.Rows.Add( row );

					}// Si existe modifico el campo bonificacion acumulativa
					else
					{
						rowAux["BonificacionAcumulativa"] = _bonificacionesAcumulativas;
                        //Sabrina: Tarea 1067. 20110311
                        if(_esCombo)
                            rowAux["PrecioDeCosto"] = PrecioDeCostoDirecto;
                        //Fin Sabrina: Tarea 1067. 20110311
						_data.tpu_ProveedoresProductos.ImportRow( rowAux ); //_data.tpu_ProveedoresProductos.Rows.Add( row );

					}
				}
			}
             * */

            private void CommitProveedoresProducto(string IdProducto)
            {
                foreach (ListaDePreciosProveedoresItem item in _listaDePreciosProveedores.Items)
                {
                    switch (item.Estado)
                    {
                        case "NEW": //Nueva lista de precios proveedores para el producto
                            {
                                //guardo en tpu_ProveedoresProductos
                                tsh_ProductosExDataset.tpu_ProveedoresProductosRow rowPP = _data.tpu_ProveedoresProductos.Newtpu_ProveedoresProductosRow();
                                mz.erp.businessrules.tpu_ProveedoresProductos.SetRowDefaultValues(rowPP);
                                rowPP.IdProducto = IdProducto;
                                rowPP.IdProveedor = item.IdProveedor;
                                rowPP.PrecioDeCosto = item.PrecioDeCosto;
                                rowPP.IdMonedaPrecioDeCosto = item.IdMonedaPrecioDeCosto;
                                rowPP.IdCotizacionPrecioDeCosto = item.IdCotizacionPrecioDeCosto;
                                rowPP.IdFuenteDeCambio = item.IdFuenteDeCambio;
                                rowPP.PrecioDeCostoFinal = item.PrecioDeCostoFinal;
                                rowPP.FechaUltimaModificacionPrecioDeCosto = mz.erp.businessrules.Sistema.DateTime.Now;
                                rowPP.PrecioDeCostoUltimaCompra = 0;
                                rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
                                rowPP.Bonificacion1 = item.Bonificacion1;
                                rowPP.Bonificacion2 = item.Bonificacion2;
                                rowPP.Bonificacion3 = item.Bonificacion3;
                                rowPP.Bonificacion4 = item.Bonificacion4;
                                rowPP.Bonificacion5 = item.Bonificacion5;
                                rowPP.PorcentajeBonificacion1 = item.PorcentajeBonificacion1;
                                rowPP.PorcentajeBonificacion2 = item.PorcentajeBonificacion2;
                                rowPP.PorcentajeBonificacion3 = item.PorcentajeBonificacion3;
                                rowPP.PorcentajeBonificacion4 = item.PorcentajeBonificacion4;
                                rowPP.PorcentajeBonificacion5 = item.PorcentajeBonificacion5;
                                rowPP.IdCotizacionProveedor = item.IdCotizacionProveedor;
                                rowPP.IdFuenteDeCambioProveedor = item.IdFuenteDeCambioProveedor;
                                rowPP.IdMonedaProveedor = item.IdMonedaProveedor;
                                rowPP.ValorCotizacionProveedor = item.ValorCotizacionProveedor;
                                _data.tpu_ProveedoresProductos.Addtpu_ProveedoresProductosRow(rowPP);

                                //guardo en tpu_ProveedoresProductosAuxiliares
                                tsh_ProductosExDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = _data.tpu_ProveedoresProductosAuxiliares.Newtpu_ProveedoresProductosAuxiliaresRow();
                                mz.erp.businessrules.tpu_ProveedoresProductosAuxiliares.SetRowDefaultValues(rowPPA);
                                rowPPA.IdProducto = IdProducto;
                                rowPPA.IdProveedor = item.IdProveedor;
                                rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                                _data.tpu_ProveedoresProductosAuxiliares.Addtpu_ProveedoresProductosAuxiliaresRow(rowPPA);

                                break;

                            }
                        case "MODIF": //Modificacion de Lista de precios proveedores producto 
                            {
                                //la tabla tpu_ProveedoresProductos solo se modifuca cuando el proveedor es el default
                                if ((!(this._idProveedorDefault == null)) && (!(this._idProveedorDefault.Equals(string.Empty))))
                                {
                                    tpu_ProveedoresProductosDataset.tpu_ProveedoresProductosRow rowPP = tpu_ProveedoresProductos.GetByPk(item.IdProveedor, IdProducto);
                                    rowPP.BonificacionAcumulativa = item.BonificacionAcumulativa;
                                    //Sabrina: Tarea 1067. 20110311
                                    if (_esCombo)
                                        rowPP["PrecioDeCosto"] = PrecioDeCostoDirecto;
                                    //Fin Sabrina: Tarea 1067. 20110311
                                    _data.tpu_ProveedoresProductos.ImportRow(rowPP);
                                }

                                //modifico el codigoProdProv en tpu_ProveedoresProductosAuxiliares
                                tpu_ProveedoresProductosAuxiliaresDataset.tpu_ProveedoresProductosAuxiliaresRow rowPPA = tpu_ProveedoresProductosAuxiliares.GetByPk(item.IdProveedor, IdProducto);
                                rowPPA.CodigoProductoProveedor = item.CodigoProductoProveedor;
                                _data.tpu_ProveedoresProductosAuxiliares.ImportRow(rowPPA);
                                break;
                            }
                    }
                }
            }
            //Fin Sabrina: Tarea 1110. 20110805

			private void CommitProductoAuxiliar(string IdProducto)
			{
				DataTable table = _data.Tables["tsh_productosAuxiliares"];	
				DataRow[] rows  = _data.Tables["tsh_productosAuxiliares"].Select("IdProducto=" + IdProducto);
				if (rows.Length == 0)
				{
					DataRow row = _data.tsh_ProductosAuxiliares.Newtsh_ProductosAuxiliaresRow();					
					row["Coeficiente1"] = this.Coeficiente1;
					row["Coeficiente2"] = this.Coeficiente2;
					row["Coeficiente3"] = this.Coeficiente3;
					row["Coeficiente4"] = this.Coeficiente4;
					row["Coeficiente5"] = this.Coeficiente5;
					row["Coeficiente6"] = this.Coeficiente6;
					row["Coeficiente7"] = this.Coeficiente7;
					row["Coeficiente8"] = this.Coeficiente8;
					row["Coeficiente9"] = this.Coeficiente9;
					row["Coeficiente10"] = this.Coeficiente10;
					row["IdProducto"] = IdProducto;
					row["Contador"] = 0;
					row["Activo"] = true;
					row["FechaCreacion"] = DateTime.Now;
					row["IdConexionCreacion"] = Security.IdConexion;					
					row["IdConexionUltimaModificacion"] = Security.IdConexion;
					row["IdReservado"] = 0;
					row["RowId"] = Guid.Empty;
					row["IdEmpresa"] = Security.IdEmpresa;
					row["IdSucursal"] = Security.IdSucursal;
					if (this._thumb != null)
						row["Thumb"] = Util.ImageToBytes(this._thumb);				
					else
						row["Thumb"] = System.DBNull.Value;
					if (this._imagen != null)
						row["Imagen"] = Util.ImageToBytes(this._imagen);
					else
						row["Imagen"] = System.DBNull.Value;
					/*if(!_coeficientesPorVariable)
					{
						row["Coeficiente1"] = this._coeficiente1;
						row["Coeficiente2"] = this._coeficiente2;
						row["Coeficiente3"] = this._coeficiente3;
						row["Coeficiente4"] = this._coeficiente4;
						row["Coeficiente5"] = this._coeficiente5;
					}*/
					if (this._link1 != null && this._link1 != "")
						row["Link1"] = _link1;				
					else
						row["Link1"] = System.DBNull.Value;
					if (this._link2 != null && this._link2 != "")
						row["Link2"] = _link2;				
					else
						row["Link2"] = System.DBNull.Value;
					if (this._link3 != null && this._link3 != "")
						row["Link3"] = _link3;				
					else
						row["Link3"] = System.DBNull.Value;
					if (this._link4 != null && this._link4 != "")
						row["Link4"] = _link4;				
					else
						row["Link4"] = System.DBNull.Value;
					if (this._link5 != null && this._link5 != "")
						row["Link5"] = _link5;				
					else
						row["Link5"] = System.DBNull.Value;
					if(_codigoSecundario1 != null && _codigoSecundario1 != "")
						row["CodigoSecundario1"] = _codigoSecundario1;
					else
						row["CodigoSecundario1"] = System.DBNull.Value;
					if(_codigoSecundario2 != null && _codigoSecundario2 != "")
						row["CodigoSecundario2"] = _codigoSecundario2;
					else
						row["CodigoSecundario2"] = System.DBNull.Value;

					if(_codigoSecundario3 != null && _codigoSecundario3 != "")
						row["CodigoSecundario3"] = _codigoSecundario3;
					else
						row["CodigoSecundario3"] = System.DBNull.Value;

					if(_codigoSecundario4 != null && _codigoSecundario4 != "")
						row["CodigoSecundario4"] = _codigoSecundario4;
					else
						row["CodigoSecundario4"] = System.DBNull.Value;

					if(_codigoSecundario5 != null && _codigoSecundario5 != "")
						row["CodigoSecundario5"] = _codigoSecundario5;
					else
						row["CodigoSecundario5"] = System.DBNull.Value;

					if(_codigoSecundario6 != null && _codigoSecundario6 != "")
						row["CodigoSecundario6"] = _codigoSecundario6;
					else
						row["CodigoSecundario6"] = System.DBNull.Value;

					if(_codigoSecundario7 != null && _codigoSecundario7 != "")
						row["CodigoSecundario7"] = _codigoSecundario7;
					else
						row["CodigoSecundario7"] = System.DBNull.Value;

					if(_codigoSecundario8 != null && _codigoSecundario8 != "")
						row["CodigoSecundario8"] = _codigoSecundario8;
					else
						row["CodigoSecundario8"] = System.DBNull.Value;

					if(_codigoSecundario9 != null && _codigoSecundario9 != "")
						row["CodigoSecundario9"] = _codigoSecundario9;
					else
						row["CodigoSecundario9"] = System.DBNull.Value;

					if(_codigoSecundario10 != null && _codigoSecundario10 != "")
						row["CodigoSecundario10"] = _codigoSecundario10;
					else
						row["CodigoSecundario10"] = System.DBNull.Value;

					if(_codigoSecundario11 != null && _codigoSecundario11 != "")
						row["CodigoSecundario11"] = _codigoSecundario11;
					else
						row["CodigoSecundario11"] = System.DBNull.Value;

					if(_codigoSecundario12 != null && _codigoSecundario12 != "")
						row["CodigoSecundario12"] = _codigoSecundario12;
					else
						row["CodigoSecundario12"] = System.DBNull.Value;

					if(_codigoSecundario13 != null && _codigoSecundario13 != "")
						row["CodigoSecundario13"] = _codigoSecundario13;
					else
						row["CodigoSecundario13"] = System.DBNull.Value;

					if(_codigoSecundario14 != null && _codigoSecundario14 != "")
						row["CodigoSecundario14"] = _codigoSecundario14;
					else
						row["CodigoSecundario14"] = System.DBNull.Value;

					if(_codigoSecundario15 != null && _codigoSecundario15 != "")
						row["CodigoSecundario15"] = _codigoSecundario15;
					else
						row["CodigoSecundario15"] = System.DBNull.Value;

					if(_codigoSecundario16 != null && _codigoSecundario16 != "")
						row["CodigoSecundario16"] = _codigoSecundario16;
					else
						row["CodigoSecundario16"] = System.DBNull.Value;

					if(_codigoSecundario17 != null && _codigoSecundario17 != "")
						row["CodigoSecundario17"] = _codigoSecundario17;
					else
						row["CodigoSecundario17"] = System.DBNull.Value;

					if(_codigoSecundario18 != null && _codigoSecundario18 != "")
						row["CodigoSecundario18"] = _codigoSecundario18;
					else
						row["CodigoSecundario18"] = System.DBNull.Value;

					if(_codigoSecundario19 != null && _codigoSecundario19 != "")
						row["CodigoSecundario19"] = _codigoSecundario19;
					else
						row["CodigoSecundario19"] = System.DBNull.Value;

					if(_codigoSecundario20 != null && _codigoSecundario20 != "")
						row["CodigoSecundario20"] = _codigoSecundario20;
					else
						row["CodigoSecundario20"] = System.DBNull.Value;
					row["TieneCodigoSecundarioSegmentado"] = _tieneCodigoSecundarioSegmentado;
                    /* Silvina 20110630 - Tarea 0000136 */
                    row["PermiteCambio"] = _permiteCambio;
                    /* Fin Silvina 20110630 - Tarea 0000136 */
					_data.Tables["tsh_productosAuxiliares"].Rows.Add(row);					
				}				
				else 
				{
					DataRow _row = rows[0];

					_row["Contador"] = this._contador;
					if (this._thumb != null)
						_row["Thumb"] = Util.ImageToBytes(this._thumb);				
					else
						_row["Thumb"] = System.DBNull.Value;
					if (this._imagen != null)
						_row["Imagen"] = Util.ImageToBytes(this._imagen);
					else
						_row["Imagen"] = System.DBNull.Value;
					/*if(!_coeficientesPorVariable)
					{
						_row["Coeficiente1"] = this._coeficiente1;
						_row["Coeficiente2"] = this._coeficiente2;
						_row["Coeficiente3"] = this._coeficiente3;
						_row["Coeficiente4"] = this._coeficiente4;
						_row["Coeficiente5"] = this._coeficiente5;
					}*/

					_row["Coeficiente1"] = this.Coeficiente1;
					_row["Coeficiente2"] = this.Coeficiente2;
					_row["Coeficiente3"] = this.Coeficiente3;
					_row["Coeficiente4"] = this.Coeficiente4;
					_row["Coeficiente5"] = this.Coeficiente5;
					_row["Coeficiente6"] = this.Coeficiente6;
					_row["Coeficiente7"] = this.Coeficiente7;
					_row["Coeficiente8"] = this.Coeficiente8;
					_row["Coeficiente9"] = this.Coeficiente9;
					_row["Coeficiente10"] = this.Coeficiente10;

					if (this._link1 != null && this._link1 != "")
						_row["Link1"] = _link1;				
					else
						_row["Link1"] = System.DBNull.Value;
					if (this._link2 != null && this._link2 != "")
						_row["Link2"] = _link2;				
					else
						_row["Link2"] = System.DBNull.Value;
					if (this._link3 != null && this._link3 != "")
						_row["Link3"] = _link3;				
					else
						_row["Link3"] = System.DBNull.Value;
					if (this._link4 != null && this._link4 != "")
						_row["Link4"] = _link4;				
					else
						_row["Link4"] = System.DBNull.Value;
					if (this._link5 != null && this._link5 != "")
						_row["Link5"] = _link5;				
					else
						_row["Link5"] = System.DBNull.Value;

					if(_codigoSecundario1 != null && _codigoSecundario1 != "")
						_row["CodigoSecundario1"] = _codigoSecundario1;
					else
						_row["CodigoSecundario1"] = System.DBNull.Value;
					if(_codigoSecundario2 != null && _codigoSecundario2 != "")
						_row["CodigoSecundario2"] = _codigoSecundario2;
					else
						_row["CodigoSecundario2"] = System.DBNull.Value;

					if(_codigoSecundario3 != null && _codigoSecundario3 != "")
						_row["CodigoSecundario3"] = _codigoSecundario3;
					else
						_row["CodigoSecundario3"] = System.DBNull.Value;

					if(_codigoSecundario4 != null && _codigoSecundario4 != "")
						_row["CodigoSecundario4"] = _codigoSecundario4;
					else
						_row["CodigoSecundario4"] = System.DBNull.Value;

					if(_codigoSecundario5 != null && _codigoSecundario5 != "")
						_row["CodigoSecundario5"] = _codigoSecundario5;
					else
						_row["CodigoSecundario5"] = System.DBNull.Value;

					if(_codigoSecundario6 != null && _codigoSecundario6 != "")
						_row["CodigoSecundario6"] = _codigoSecundario6;
					else
						_row["CodigoSecundario6"] = System.DBNull.Value;

					if(_codigoSecundario7 != null && _codigoSecundario7 != "")
						_row["CodigoSecundario7"] = _codigoSecundario7;
					else
						_row["CodigoSecundario7"] = System.DBNull.Value;

					if(_codigoSecundario8 != null && _codigoSecundario8 != "")
						_row["CodigoSecundario8"] = _codigoSecundario8;
					else
						_row["CodigoSecundario8"] = System.DBNull.Value;

					if(_codigoSecundario9 != null && _codigoSecundario9 != "")
						_row["CodigoSecundario9"] = _codigoSecundario9;
					else
						_row["CodigoSecundario9"] = System.DBNull.Value;

					if(_codigoSecundario10 != null && _codigoSecundario10 != "")
						_row["CodigoSecundario10"] = _codigoSecundario10;
					else
						_row["CodigoSecundario10"] = System.DBNull.Value;

					if(_codigoSecundario11 != null && _codigoSecundario11 != "")
						_row["CodigoSecundario11"] = _codigoSecundario11;
					else
						_row["CodigoSecundario11"] = System.DBNull.Value;

					if(_codigoSecundario12 != null && _codigoSecundario12 != "")
						_row["CodigoSecundario12"] = _codigoSecundario12;
					else
						_row["CodigoSecundario12"] = System.DBNull.Value;

					if(_codigoSecundario13 != null && _codigoSecundario13 != "")
						_row["CodigoSecundario13"] = _codigoSecundario13;
					else
						_row["CodigoSecundario13"] = System.DBNull.Value;

					if(_codigoSecundario14 != null && _codigoSecundario14 != "")
						_row["CodigoSecundario14"] = _codigoSecundario14;
					else
						_row["CodigoSecundario14"] = System.DBNull.Value;

					if(_codigoSecundario15 != null && _codigoSecundario15 != "")
						_row["CodigoSecundario15"] = _codigoSecundario15;
					else
						_row["CodigoSecundario15"] = System.DBNull.Value;

					if(_codigoSecundario16 != null && _codigoSecundario16 != "")
						_row["CodigoSecundario16"] = _codigoSecundario16;
					else
						_row["CodigoSecundario16"] = System.DBNull.Value;

					if(_codigoSecundario17 != null && _codigoSecundario17 != "")
						_row["CodigoSecundario17"] = _codigoSecundario17;
					else
						_row["CodigoSecundario17"] = System.DBNull.Value;

					if(_codigoSecundario18 != null && _codigoSecundario18 != "")
						_row["CodigoSecundario18"] = _codigoSecundario18;
					else
						_row["CodigoSecundario18"] = System.DBNull.Value;

					if(_codigoSecundario19 != null && _codigoSecundario19 != "")
						_row["CodigoSecundario19"] = _codigoSecundario19;
					else
						_row["CodigoSecundario19"] = System.DBNull.Value;

					if(_codigoSecundario20 != null && _codigoSecundario20 != "")
						_row["CodigoSecundario20"] = _codigoSecundario20;
					else
						_row["CodigoSecundario20"] = System.DBNull.Value;
				
					_row["TieneCodigoSecundarioSegmentado"] = _tieneCodigoSecundarioSegmentado;

                    /* Silvina 20110630 - Tarea 0000136 */
                    _row["PermiteCambio"] = _permiteCambio;
                    /* Fin Silvina 20110630 - Tarea 0000136 */
				}

			}				
				/*tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
							businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
							rowImp.IdProducto = IdProd;
							rowImp.MetodoDeAsignacion = "I";
							rowImp.IdImpuesto = ps.IdImpuesto;															
							ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);*/


				/*				DataTable table = _data.Tables["tsh_productosAuxiliares"];
					if (table.Rows.Count > 0)
					{
						DataRow _row = _data.Tables["tsh_productosAuxiliares"].Select("IdProducto=" + IdProducto)[0];
						_row["Contador"] = this._contador;
						if (this._thumb != null)
							_row["Thumb"] = Util.ImageToBytes(this._thumb);				
						else
							_row["Thumb"] = System.DBNull.Value;
						if (this._imagen != null)
							_row["Imagen"] = Util.ImageToBytes(this._imagen);
						else
							_row["Imagen"] = System.DBNull.Value;
					}				
*/

			public bool isValid()
			{
				bool ok = Variables.GetValueBool("Productos.ListasDePrecios.ValidarPrecioDeVentaBruto.Error");
				bool errors = false;
				if(!ok)
				{
					if(!_listaDePreciosHabilitadas)
					{
						errors = decimal.Round(this.PrecioNeto,2) > decimal.Round(this.PrecioLista,2);
					}
					else
					{
						foreach(ListaDePreciosItem item in this.ListaDePrecios.Items)
						{
							if(decimal.Round(item.PrecioDeVentaNeto,2) > decimal.Round(item.PrecioDeVentaBruto,2))
							{
								errors = true;
							}
						}						
					}
				}
				return !errors; 
			}

			public tsh_ProductosExDataset Commit(bool PercibeIB, string IdProd)
			{
				CommitProducto(IdProd);				
				CommitProductoAuxiliar(IdProd);
                //Sabrina: Tarea 1110. 20110805
				//CommitProveedoresProducto(IdProd);
                //Fin Sabrina: Tarea 1110. 20110805
				_data.tsh_ProductosCoeficientesAplicados.Clear();
				CommitProductosCoeficientesAplicados(IdProd);
				CollectionBase aux = this.Impuestos;				
				tsy_ImpuestosProductosDataset ip = businessrules.tsy_ImpuestosProductos.GetList(IdProd);
				string listaIBstr = Variables.GetValueString("Impuestos.Lista.IB");
				ArrayList listaIB = Util.Parse(listaIBstr, ",");
				ArrayList listaIBIds = new ArrayList();
				foreach (string ib in listaIB)
				{
					string IdImp =  mz.erp.businessrules.tsy_Impuestos.GetIdImpuesto(ib);
					if(IdImp != null && IdImp != string.Empty)
						listaIBIds.Add(IdImp);
				}	
				if(_agentePercepcionIB)
				{
					if(PercibeIB)
					{
						foreach(string IdImp in listaIBIds)
						{

							if(ip.tsy_ImpuestosProductos.FindByIdProductoIdImpuesto(IdProd, IdImp)!= null)
								ip.tsy_ImpuestosProductos.FindByIdProductoIdImpuesto(IdProd, IdImp).Delete();
						}
						
					}
					else
					{	
						foreach(string IdImp in listaIBIds)
						{
							if(ip.tsy_ImpuestosProductos.FindByIdProductoIdImpuesto(IdProd, IdImp)== null)
							{
								tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
								businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
								rowImp.IdProducto = IdProd;
								rowImp.MetodoDeAsignacion = "E";
								rowImp.IdImpuesto = IdImp;															
								ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);
							}
						}
						
					

					}
				}
				foreach(ProductoImpuesto ps in aux) 
				{
					bool ActivoN = ps.Activo;
					bool ActivoDB = businessrules.tsy_ImpuestosProductos.Find(IdProd, ps.IdImpuesto);
					if (ActivoN != ActivoDB)  
					{
						if (ActivoDB) //Esta en la base y lo quiero borrar
						{							
							foreach(tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp in ip.tsy_ImpuestosProductos.Rows) 
							{																							
								if (rowImp.RowState != System.Data.DataRowState.Deleted) 									
								{
									if (rowImp.IdImpuesto == ps.IdImpuesto) 
									{
										rowImp.Delete();										
									}
								}
							}							
						}
						if (ActivoN) //No está en la base y lo quiero agregar
						{							
							tsy_ImpuestosProductosDataset.tsy_ImpuestosProductosRow rowImp = ip.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
							businessrules.tsy_ImpuestosProductos.SetRowDefaultValues(rowImp);
							rowImp.IdProducto = IdProd;
							rowImp.MetodoDeAsignacion = "I";
							rowImp.IdImpuesto = ps.IdImpuesto;															
							ip.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(rowImp);
						}
					}
				}
				if (ip.tsy_ImpuestosProductos.Rows.Count > 0) 
				{
					
					_data.Merge((DataSet) ip);
					
				}				

				aux = this.Sucursales;
				
                
				foreach(ProductoSucursal ps in aux)
				{					
					if(this._sucActivasONo.Contains(ps.IdSucursal))
					{
						tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowPS = _data.tsh_ProductosSucursales.FindByIdProductoIdSucursalIdEmpresa(ps.Producto.Idproducto,ps.IdSucursal,ps.IdEmpresa);						
						//if(this._configuracionBasica)
                        //German 20101101 - Tarea 903
                        if (!_listaDePreciosHabilitadas)
                            rowPS.PrecioFinalEstimado = _precioFinal;// businessrules.Productos.ObtenerPrecioBrutoConImpuestosMoendaPrecioDeVentaBruto(this.PrecioLista,this.IdMonedaCierrePrecioDeVentaBruto, Security.IdSucursal, Security.IdEmpresa, impuestosAAplicar);
                        else
                        {
                            if (this.ListaDePrecios != null)
                            {
                                rowPS.PrecioFinalEstimado = this.ListaDePrecios.GetDefaultItem().PrecioDeVentaBrutoConImpuestos;
                            }
                        }
                        //German 20101101 - Tarea 903
						rowPS.Activo = ps.IsAvailable;
						rowPS.StockMinimo = ps.StockMinimo;
						rowPS.StockMaximo = ps.StockMaximo;
						if (!rowPS.IsFechaUltimaModificacionNull())
						{
							if(rowPS.FechaUltimaModificacion == DateTime.MinValue )
								rowPS.SetFechaUltimaModificacionNull();
						}
					}
					else
					{	
						if (ps.IsAvailable)
						{
							tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowPS = mz.erp.businessrules.tsh_ProductosEx.AddNewRowProdSucursales(_data, ps.IdSucursal,ps.IdEmpresa);
							
							rowPS.Activo = true;
							if (!rowPS.IsFechaUltimaModificacionNull())
							{
								if(rowPS.FechaUltimaModificacion == DateTime.MinValue )
									rowPS.SetFechaUltimaModificacionNull();
							}
							this._sucActivasONo.Add(ps.IdSucursal);
							
						}
					
					}
				}
				if(!_cotizacionProductoPrecioDeCosto.IsValid || !_cotizacionProductoPrecioDeVenta.IsValid)
				{
					_data.tsh_Productos.Rows[0].SetColumnError("IdCotizacionCierrePrecioDeCostoRef","No existe una cotizaicon para la Moneda y Fuente de Cambio seleccionada");
				}
				if(_habilitaJerarquias)
				{
					_data.tsh_AgrupProductos.Clear();
					_data.Merge(mz.erp.dataaccess.tsh_AgrupProductos.GetList(IdProd, null).Tables[0]);
					foreach(DataRow rowJ in _data.tsh_AgrupProductos.Rows)
					{
						rowJ.Delete();
					}	
					//Trae todos los registros de ese producto, si es q hay y los elimina, luego agregara las nuevas jerarquias
					_data.tsh_ProductosJerarquias.Clear();
					tsh_ProductosJerarquiasDataset.tsh_ProductosJerarquiasRow _auxRow=mz.erp.dataaccess.tsh_ProductosJerarquias.GetByPk(IdProd);
					if ( _auxRow!=null)
						_data.tsh_ProductosJerarquias.ImportRow(_auxRow);
					foreach(DataRow rowPJ in _data.tsh_ProductosJerarquias.Rows)
					{
						rowPJ.Delete();
					}
					

					if(this._byJerarquia1)
					{
						AddTsh_AgrupProductos(this.Jerarquia1);						
					}
					if(this._byJerarquia2)
					{
						AddTsh_AgrupProductos(this.Jerarquia2);
						
					}
					if(this._byJerarquia3)
					{
						AddTsh_AgrupProductos(this.Jerarquia3);					
					}
					if(this._byJerarquia4)
					{
						AddTsh_AgrupProductos(this.Jerarquia4);						
					}
					if(this._byJerarquia5)
					{
						AddTsh_AgrupProductos(this.Jerarquia5);						
					}
					if(this._byJerarquia6)
					{
						AddTsh_AgrupProductos(this.Jerarquia6);						
					}
					if(this._byJerarquia7)
					{
						AddTsh_AgrupProductos(this.Jerarquia7);						
					}
					if(this._byJerarquia8)
					{
						AddTsh_AgrupProductos(this.Jerarquia8);
					}
					System.Console.WriteLine("Commit boolean e id producto");
					
				}
				return _data;
			}

			DataRow row = null;
			DataRow[] rowsPS = null;
			DataRow[] rowsPI = null;

			public tsh_ProductosExDataset Commit(bool PercibeIB)
			{				
				if(!_generacionDeProductosMasivos || this._state.Equals("EDIT"))
				{
					_data.tsy_ImpuestosProductos.Clear();
					_data.tsh_ProductosListasDePrecios.Clear();
					_data.tsh_ProductosListasDePreciosAplicadas.Clear();
                    //Sabrina: Tarea 1110. 20110805
                    _data.tpu_ProveedoresProductos.Clear();
                    _data.tpu_ProveedoresProductosAuxiliares.Clear();
                    //Fin Sabrina: Tarea 1110. 20110805
					Commit(PercibeIB,this.Idproducto);
                    //Sabrina: Tarea 1110. 20110805
                    CommitProveedoresProducto(this.Idproducto);
                    //Fin Sabrina: Tarea 1110. 20110805
					if(_listaDePreciosHabilitadas)//Depende de la variable Productos.ListasDePrecios
						ComitListaDePreciosProducto(this.Idproducto);
					else
					{
						ListaDePreciosItem item = _listaDePrecios.GetDefaultItem();
						item.ModoDeAplicacion = "P";
						item.PrecioDeCosto = _precioDeCostoRef;
						item.Mac = _MAC;
						item.PrecioDeVentaNeto = _precioDeVentaNeto;
						decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(_precioDeVentaBruto);
						item.CoeficienteProducto = coeficienteNew;
						item.PrecioDeVentaBruto = _precioDeVentaBruto;
						item.PrecioDeVentaBrutoConImpuestos = _precioFinal;
						//_listaDePrecios.Commit(item);
						if(this._state.Equals("EDIT"))
							item.Estado = "MODIF_ALL";
						ComitListaDePreciosProducto(this.Idproducto, item);
					}
                    //Sabrina: Tarea 1067. 20110311
                    _data.tsh_CombosDetListasDePrecios.Clear();
                    _data.tsh_CombosDet.Clear();
                    CommitProductosCombo(this.Idproducto);
                    //Fin Sabrina: Tarea 1067. 20110311

				}
				else
				{
					//Entra aca
					_data.tsy_ImpuestosProductos.Clear();
					_data.tsh_ProductosListasDePrecios.Clear();
					_data.tsh_ProductosListasDePreciosAplicadas.Clear();
                    //Sabrina: Tarea 1067. 20110311
                    _data.tsh_CombosDetListasDePrecios.Clear();
                    _data.tsh_CombosDet.Clear();
                    //Fin Sabrina: Tarea 1067. 20110311
                    
                    //Sabrina: Tarea 1110. 20110805
                    _data.tpu_ProveedoresProductos.Clear();
                    _data.tpu_ProveedoresProductosAuxiliares.Clear();
                    //Fin Sabrina: Tarea 1110. 20110805
					
                    Commit(PercibeIB,this.Idproducto);
					if(this._productos.Count == 0)
					{
                        //Sabrina: Tarea 1110. 20110805
                        CommitProveedoresProducto(this.Idproducto);
                        //Fin Sabrina: Tarea 1110. 20110805

						if(_listaDePreciosHabilitadas)//Depende de la variable Productos.ListasDePrecios
							ComitListaDePreciosProducto(this.Idproducto);
						else
						{
							ListaDePreciosItem item = _listaDePrecios.GetDefaultItem();
							item.ModoDeAplicacion = "P";
							item.PrecioDeCosto = _precioDeCostoRef;
							item.Mac = _MAC;
							item.PrecioDeVentaNeto = _precioDeVentaNeto;
							decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(_precioDeVentaBruto);
							item.CoeficienteProducto = coeficienteNew;
							item.PrecioDeVentaBruto = _precioDeVentaBruto;
							item.PrecioDeVentaBrutoConImpuestos = _precioFinal;
							ComitListaDePreciosProducto(this.Idproducto, item);
						}
                        //Sabrina: Tarea 1067. 20110311
                        CommitProductosCombo(this.Idproducto);
                        //Fin Sabrina: Tarea 1067. 20110311
					}
					if(this._productos.Count > 0)
					{
						row = _data.tsh_Productos.FindByIdProducto(this._idProductoPadre);
						rowsPS = _data.tsh_ProductosSucursales.Select("IdProducto = " + this._idProductoPadre);
						rowsPI = _data.tsy_ImpuestosProductos.Select("IdProducto = " + this._idProductoPadre);
						DataRow[] rowPAEliminar = _data.tsh_Productos.Select("IdProducto <> " + this._idProductoPadre);
						DataRow[] rowsPSAEliminar = _data.tsh_ProductosSucursales.Select("IdProducto <> " + this._idProductoPadre);
						DataRow[] rowsPIAEliminar = _data.tsy_ImpuestosProductos.Select("IdProducto <> " + this._idProductoPadre);
						for(int i = 0; i < rowsPSAEliminar.Length; i++)
						{
							DataRow r = rowsPSAEliminar[i];
							_data.Tables["tsh_productosSucursales"].Rows.Remove(r);
						}
						
						for(int i = 0; i < rowsPIAEliminar.Length; i++)
						{
							DataRow r = rowsPIAEliminar[i];
							_data.Tables["tsy_ImpuestosProductos"].Rows.Remove(r);
						}
						
						for(int i = 0; i < rowPAEliminar.Length; i++)
						{
							DataRow r = rowPAEliminar[i];
							_data.Tables["tsh_productos"].Rows.Remove(r);
						}


						_data.tsh_AgrupProductos.Clear();
						int indice=0;					
						foreach(ProductoABMProducto prod in this._productos)
						{						
							string IdProducto = mz.erp.systemframework.Util.NewStringId();
							tsh_ProductosExDataset.tsh_ProductosRow rowP = _data.tsh_Productos.Newtsh_ProductosRow();
							rowP.ItemArray = row.ItemArray;
							rowP.IdProducto = IdProducto;
							rowP.Descripcion = prod.Descripcion.Trim();
							rowP.DescripcionCorta = prod.Descripcion.Trim();
							rowP.DescripcionLarga = prod.Descripcion.Trim();
							rowP.CodigoSecundario = prod.CodigoSecundario.Trim();
							_data.tsh_Productos.Addtsh_ProductosRow(rowP);
							CommitProductoAuxiliar(IdProducto);
							CommitProveedoresProducto(IdProducto);
							//German 20090512
							CommitProductosCoeficientesAplicados(IdProducto);
							//Fin German 20090512
							if(_listaDePreciosHabilitadas)//Depende de la variable Productos.ListasDePrecios
                                //German 20111107 - Tarea 0000224
								ComitListaDePreciosProductoGeneracionMasiva(IdProducto);
                                //German 20111107 - Tarea 0000224
							else
							{
								ListaDePreciosItem item = _listaDePrecios.GetDefaultItem();
								item.ModoDeAplicacion = "P";
								item.PrecioDeCosto = _precioDeCostoRef;
								item.Mac = _MAC;
								item.PrecioDeVentaNeto = _precioDeVentaNeto;
								decimal coeficienteNew = item.GetCoeficienteFromPrecioVentaBruto(_precioDeVentaBruto);
								item.CoeficienteProducto = coeficienteNew;
								item.PrecioDeVentaBruto = _precioDeVentaBruto;
								item.PrecioDeVentaBrutoConImpuestos = _precioFinal;
								ComitListaDePreciosProducto(IdProducto, item);
							}
                            //Sabrina: Tarea 1067. 20110311
                            CommitProductosCombo(Idproducto);
                            //Fin Sabrina: Tarea 1067. 20110311
							for(int i = 0; i < rowsPS.Length ; i++)
							{
								tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowS = (tsh_ProductosExDataset.tsh_ProductosSucursalesRow)rowsPS[i];
								tsh_ProductosExDataset.tsh_ProductosSucursalesRow newRowS = _data.tsh_ProductosSucursales.Newtsh_ProductosSucursalesRow();
								newRowS.ItemArray = rowS.ItemArray;
								newRowS.IdProducto = IdProducto;
								_data.tsh_ProductosSucursales.Addtsh_ProductosSucursalesRow(newRowS);
							}
							for(int i = 0; i < rowsPI.Length ; i++)
							{
								tsh_ProductosExDataset.tsy_ImpuestosProductosRow rowI = (tsh_ProductosExDataset.tsy_ImpuestosProductosRow ) rowsPI[i];
								tsh_ProductosExDataset.tsy_ImpuestosProductosRow newRowI = _data.tsy_ImpuestosProductos.Newtsy_ImpuestosProductosRow();
								newRowI.ItemArray = rowI.ItemArray;
								newRowI.IdProducto = IdProducto;
								_data.tsy_ImpuestosProductos.Addtsy_ImpuestosProductosRow(newRowI);
							}
								
							foreach(string Jerarquia in prod.Jerarquias)
							{
								AddTsh_AgrupProductos(Jerarquia,IdProducto);

							}
							//this.AddTsh_ProductosJerarquias(IdProducto,prod.Jerarquias);
							//En prod.Jerarquias ya tengo las jerarquias enteras pos 0 jerarquia 1,... hay q armar una row con toda la info de jerarquia
							if(this._byJerarquia1)
							{
								foreach(ItemJerarquia item in this._jerarquia1)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia2)
							{
								foreach(ItemJerarquia item in this._jerarquia2)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia3)
							{
								foreach(ItemJerarquia item in this._jerarquia3)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia4)
							{
								foreach(ItemJerarquia item in this._jerarquia4)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia5)
							{
								foreach(ItemJerarquia item in this._jerarquia5)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia6)
							{
								foreach(ItemJerarquia item in this._jerarquia6)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia7)
							{
								foreach(ItemJerarquia item in this._jerarquia7)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
							if(this._byJerarquia8)
							{
								foreach(ItemJerarquia item in this._jerarquia8)
								{
									if(!prod.Jerarquias.Contains(item.NodeKeyPath)&& !JerarquiaUsadaEnCombinaciones(item.NodeKeyPath))
										AddTsh_AgrupProductos(item.NodeKeyPath,IdProducto);
								}
							}
						System.Console.WriteLine("Commit boolean");
						//this.AddTsh_ProductosJerarquias(indice,IdProducto,_jerarquia1,_jerarquia2,_jerarquia3,_jerarquia4,_jerarquia5,_jerarquia6,_jerarquia7,_jerarquia8);
						indice++;
						}

						
						for(int i = 0; i < rowsPS.Length ; i++)
						{
							rowsPS[i].AcceptChanges();
							//_data.tsh_ProductosSucursales.Removetsh_ProductosSucursalesRow((tsh_ProductosExDataset.tsh_ProductosSucursalesRow)rowsPS[i]);

						}
						for(int i = 0; i < rowsPI.Length ; i++)
						{
							rowsPI[i].AcceptChanges();
							//_data.tsy_ImpuestosProductos.Removetsy_ImpuestosProductosRow((tsh_ProductosExDataset.tsy_ImpuestosProductosRow)rowsPI[i]);
						}
						row.AcceptChanges();
						//_data.tsh_Productos.Rows.Remove(row);
					}
				}
				ProductosJerarquiaAuxiliar p= new ProductosJerarquiaAuxiliar();
				p.cargarJerarquias(_data.tsh_AgrupProductos);
				Hashtable aux=p.ProductoJerarquia;
				//Para cada producto
				foreach(string idProd in aux.Keys)
					{
						object valor = aux[idProd];
						this.AddTsh_ProductosJerarquias(idProd,(ArrayList)valor);
					}
				return _data;

			}

			private bool JerarquiaUsadaEnCombinaciones(string Jerarquia)
			{
				foreach(ArrayList list in this._jerarquiasACombinar)
				{
					
					foreach(ItemJerarquia ij in list)
					{
						if(ij.NodeKeyPath.Equals(Jerarquia))
							return true;
					}
						
				}
				return false;
			}

			public void AddTsh_ProductosJerarquias(string idProducto,ArrayList TodaJerarquia)
			{
				tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row = this._data.tsh_ProductosJerarquias.Newtsh_ProductosJerarquiasRow();
				_row.IdProducto=idProducto;
				_row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				_row.IdConexionCreacion = Security.IdConexion;
				_row.IdConexionUltimaModificacion = Security.IdConexion;
				_row.IdReservado = 0;
				_row.RowId = Guid.Empty;
				_row.IdEmpresa = Security.IdEmpresa;
				_row.IdSucursal=Security.IdSucursal;
				_row=this.MetodoAuxiliarAddTsh_ProductosJerarquias(TodaJerarquia,_row);
				_data.tsh_ProductosJerarquias.Addtsh_ProductosJerarquiasRow(_row);
				
				}
			private tsh_ProductosExDataset.tsh_ProductosJerarquiasRow MetodoAuxiliarAddTsh_ProductosJerarquias(ArrayList TodaJerarquia,tsh_ProductosExDataset.tsh_ProductosJerarquiasRow _row)
			{
			 
				ArrayList ArrayNiveles1 = (TodaJerarquia.Count >0 && TodaJerarquia[0] != null)? (ArrayList)TodaJerarquia[0] : new ArrayList();
				ArrayList ArrayNiveles2 = (TodaJerarquia.Count >1 && TodaJerarquia[1] != null)? (ArrayList)TodaJerarquia[1] : new ArrayList();
				ArrayList ArrayNiveles3 = (TodaJerarquia.Count >2 && TodaJerarquia[2] != null)? (ArrayList)TodaJerarquia[2] : new ArrayList();
				ArrayList ArrayNiveles4 = (TodaJerarquia.Count >3 && TodaJerarquia[3] != null)? (ArrayList)TodaJerarquia[3] : new ArrayList();
				ArrayList ArrayNiveles5 = (TodaJerarquia.Count >4 && TodaJerarquia[4] != null)? (ArrayList)TodaJerarquia[4] : new ArrayList();
				ArrayList ArrayNiveles6 = (TodaJerarquia.Count >5 && TodaJerarquia[5] != null)? (ArrayList)TodaJerarquia[5] : new ArrayList();
				ArrayList ArrayNiveles7 = (TodaJerarquia.Count >6 && TodaJerarquia[6] != null)? (ArrayList)TodaJerarquia[6] : new ArrayList();
				ArrayList ArrayNiveles8 = (TodaJerarquia.Count >7 && TodaJerarquia[7] != null)? (ArrayList)TodaJerarquia[7] : new ArrayList();
				
									
				int i= ArrayNiveles1.Count;
				if (i>0)
				{
					_row.IdNomenclatura1a= Convert.ToString(ArrayNiveles1[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura1b=Convert.ToString( ArrayNiveles1[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura1c=Convert.ToString( ArrayNiveles1[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura1d= Convert.ToString(ArrayNiveles1[3]);
					i--;
				}
				
				//ArrayNiveles 2
				 i= ArrayNiveles2.Count;
				if (i>0)
				{
					_row.IdNomenclatura2a= Convert.ToString(ArrayNiveles2[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura2b= Convert.ToString(ArrayNiveles2[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura2c= Convert.ToString(ArrayNiveles2[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura2d=Convert.ToString( ArrayNiveles2[3]);
					i--;
				}
				//ArrayNiveles3
				 i= ArrayNiveles3.Count;
				if (i>0)
				{
					_row.IdNomenclatura3a=Convert.ToString( ArrayNiveles3[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura3b= Convert.ToString(ArrayNiveles3[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura3c= Convert.ToString(ArrayNiveles3[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura3d= Convert.ToString(ArrayNiveles3[3]);
					i--;
				}
				//Array Niveles 4
				 i= ArrayNiveles4.Count;
				if (i>0)
				{
					_row.IdNomenclatura4a= Convert.ToString(ArrayNiveles4[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura4b= Convert.ToString(ArrayNiveles4[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura4c= Convert.ToString(ArrayNiveles4[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura4d= Convert.ToString(ArrayNiveles4[3]);
					i--;
				}

				//Array Niveles 5
				 i= ArrayNiveles5.Count;
				if (i>0)
				{
					_row.IdNomenclatura5a= Convert.ToString(ArrayNiveles5[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura5b= Convert.ToString(ArrayNiveles5[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura5c= Convert.ToString(ArrayNiveles5[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura5d= Convert.ToString(ArrayNiveles5[3]);
					i--;
				}
				//Array Niveles 6
				 i= ArrayNiveles6.Count;
				if (i>0)
				{
					_row.IdNomenclatura6a=Convert.ToString( ArrayNiveles6[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura6b= Convert.ToString(ArrayNiveles6[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura6c= Convert.ToString(ArrayNiveles6[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura6d= Convert.ToString(ArrayNiveles6[3]);
					i--;
				}
				//Array Niveles 7
				 i= ArrayNiveles7.Count;
				if (i>0)
				{
					_row.IdNomenclatura7a= Convert.ToString(ArrayNiveles7[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura7b= Convert.ToString(ArrayNiveles7[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura7c= Convert.ToString(ArrayNiveles7[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura7d= Convert.ToString(ArrayNiveles7[3]);
					i--;
				}
				//Array Niveles 8
				 i= ArrayNiveles8.Count;
				if (i>0)
				{
					_row.IdNomenclatura8a= Convert.ToString(ArrayNiveles8[0]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura8b= Convert.ToString(ArrayNiveles8[1]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura8c= Convert.ToString(ArrayNiveles8[2]);
					i--;
				}
				if (i>0)
				{
					_row.IdNomenclatura8d= Convert.ToString(ArrayNiveles8[3]);
					i--;
				}
				return _row;
			
			}
			
			
			private void AddTsh_AgrupProductos(ArrayList Jerarquias)
			{
				foreach(ItemJerarquia it in Jerarquias)
				{
					AddTsh_AgrupProductos(it.NodeKeyPath, this.Idproducto);
		
				}
			}


			private void AddTsh_AgrupProductos(string Jerarquia, string IdProducto)
			{
				
				tsh_ProductosExDataset.tsh_AgrupProductosRow row = this._data.tsh_AgrupProductos.Newtsh_AgrupProductosRow();
				if(!this._data.tsh_AgrupProductos.HasErrors)
				{
					string filtro = String.Format("SUBSTRING(Jerarquia,1,20) = SUBSTRING({0},1,20) and IdProducto = {1}", "'" + Jerarquia + "'", "'" + IdProducto + "'");			
					DataView dv = new DataView( _data.tsh_AgrupProductos, filtro, "", System.Data.DataViewRowState.CurrentRows );
					bool ok = dv.Count == 0;
					if(! ok)
					{
						DataRow rowP = _data.tsh_Productos.FindByIdProducto(IdProducto);
						string DescP = Convert.ToString(rowP["Descripcion"]);
						string J = Convert.ToString(dv[0].Row["Jerarquia"]);
						string IdNomenclatura = J.Substring(J.Length - 20);
						DataRow rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(IdNomenclatura);
						string DescJ = string.Empty;
						string DescJ1 = string.Empty;
						if(rowJ != null)
						{
							DescJ = Convert.ToString(rowJ["Descripcion"]);

						}
						IdNomenclatura = Jerarquia.Substring(Jerarquia.Length - 20);
						rowJ = mz.erp.businessrules.tsh_JerarquiaAgrupProd.GetByPk(IdNomenclatura);
						if(rowJ != null)
						{
							DescJ1 = Convert.ToString(rowJ["Descripcion"]);

						}
						row.SetColumnError( "Jerarquia" , "El Artículo " + DescP + " Ya Pertence a la Jerarquía " + DescJ + ". Por ende, no puede pertencer a la Jerarquía " + DescJ1 + ".");
					


					}
				}
				
				
				
				row.IdProducto = IdProducto; 
				row.Jerarquia = Jerarquia; 
				row.FechaCreacion = mz.erp.businessrules.Sistema.DateTime.Now;
				row.IdConexionCreacion = Security.IdConexion;
				//row.UltimaModificacion = 0;
				row.IdConexionUltimaModificacion = Security.IdConexion;
				row.IdReservado = 0;
				row.RowId = Guid.Empty;
				row.IdEmpresa = Security.IdEmpresa;
				_data.tsh_AgrupProductos.Addtsh_AgrupProductosRow(row);

			}

			private void pi_ActivoChanged(object sender, EventArgs e)
			{
				CalcularPrecioFinal();
                //German 20101123 - Tarea 923
                if (_listaDePreciosHabilitadas)
                {
                    if (this._state.ToUpper().Equals("EDIT"))
                    {
                        _listaDePrecios.ImpuestosChanged();
                    }
                }
                //Fin German 20101123 - Tarea 923
			}

			private ArrayList _listaDeProductosAEliminar = null;
			public void ListaDeProductosSeleccionadoABorrar(ArrayList aux)
			{
				_listaDeProductosAEliminar = aux;
			}

			public void EliminarListaDeProductosSeleccionado()
			{
				if (_listaDeProductosAEliminar != null)
				{
					foreach(ProductoABMProducto prod in _listaDeProductosAEliminar)
					{
						this._productos.Remove(prod);
						_listaDeProductosAEliminar = null;
					}
				}
			}

			public void CargarCostosIndirectosDescripcion()
			{
				foreach(tsh_CoeficientesCostosIndirectosDataset.tsh_CoeficientesCostosIndirectosRow row in CostosIndirectosLoader.Load().Rows)
				{                                  
					if ((row.Orden == 1) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip1 = row.Descripcion;
					if ((row.Orden == 2) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip2 = row.Descripcion;
					if ((row.Orden == 3) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip3 = row.Descripcion;
					if ((row.Orden == 4) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip4 = row.Descripcion;
					if ((row.Orden == 5) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip5 = row.Descripcion;
					if ((row.Orden == 6) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip6 = row.Descripcion;
					if ((row.Orden == 7) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip7 = row.Descripcion;
					if ((row.Orden == 8) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip8 = row.Descripcion;
					if ((row.Orden == 9) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip9 = row.Descripcion;
					if ((row.Orden == 10) & ( row.Descripcion != string.Empty )) // & circuito corto
						_costoIndirectoDescrip10 = row.Descripcion;
				}
			
			}

            //Sabrina: Tarea 1067. 20110311
            #region Miembros de IObserver

            public void UpdateObject(object sender, object valores)
            {
                if ((valores.GetType()) == typeof(System.Collections.ArrayList))
                {   // Entra por lanzamiento de mzProductosControl (valores es un Producto)
                    ProcessItem((ArrayList)valores);
                }
                
            }
            private void ProcessItem(ArrayList lista)
            {
                foreach (mz.erp.businessrules.comprobantes.Item item in lista)
                {
                    modelo.Combo.ComboDet comboDet = new modelo.Combo.ComboDet(this.Idproducto, _ordinalComboDet, item.IdProducto, item.Cantidad, 0, 0, item.PrecioBruto, item.PrecioCosto);
                    comboDet.IdListaDePreciosReferencia = this.IdListaDePreciosProductosCombo;
                    this._detalleCombo.Add(comboDet);
                    _ordinalComboDet++;
                }
                RecalcularPreciosCombo();
                if (ProductosComboChanged != null)
                    ProductosComboChanged(this, new EventArgs());

            }

            #endregion
            //Fin Sabrina: Tarea 1067. 20110311
        }

		public class ProductoSucursal
		{			
			//Datos de la tabla Productos Sucursales
			private long _idSucursal;
			private long _idEmpresa;
			private string _empresa;
			private string _descripcion;
			private bool _bloqueado;
			private decimal _incrementoDeCosto;
			private decimal _mac;
			private decimal _precioDeVentaNeto;
			private decimal _maximoDescuento;
			private decimal _precioDeVentaBruto;
			private decimal _stockMinimo;
			private decimal _stockMaximo;
			private decimal _stockDisponible;
			private bool _isAvailable;

			//Datos del Producto
			private ControladorProductos _producto;

			//Datos de la Sucursal
			private decimal _cargoFijoProductos;
			private decimal _bonificacionRecargoProductos;




			public void Init(sy_SucursalesDataset.sy_SucursalesRow row, sy_EmpresasDataset.sy_EmpresasRow rowE, ControladorProductos p)
			{

				try
				{
					//El controlador de Producto
					_producto = p;

					//Datos de las Sucursales
					_idSucursal = row.IdSucursal;
					_descripcion = row.Descripcion;
					_cargoFijoProductos = row.CargoFijoProductos;
					_bonificacionRecargoProductos = row.BonificacionRecargoProductos;										
				
					///Datos de la  empresa				
					_idEmpresa = rowE.IdEmpresa;
					_empresa = rowE.Descripcion;

					//Datos de los produstos Sucursales

					_isAvailable = false;
					_incrementoDeCosto = 0;
					_mac = 0;
					_maximoDescuento = 0;
					_precioDeVentaBruto = 0;
					_precioDeVentaNeto = 0;
				}
				catch(Exception e)
				{
					
				}
			}

			public void Init(sy_SucursalesDataset.sy_SucursalesRow row, sy_EmpresasDataset.sy_EmpresasRow rowE, tsh_ProductosExDataset.tsh_ProductosSucursalesRow rowPS, ControladorProductos p)
			{

				//El controlador de Producto
				_producto = p;

				//Datos de las Sucursales
				_idSucursal = row.IdSucursal;
				_descripcion = row.Descripcion;
				_cargoFijoProductos = row.CargoFijoProductos;
				_bonificacionRecargoProductos = row.BonificacionRecargoProductos;

				//Datos de la empresa
				_idEmpresa = rowE.IdEmpresa;
				_empresa = rowE.Descripcion;

				//Datos de los produstos Sucursales

				_isAvailable = rowPS.Activo;
				_incrementoDeCosto = rowPS.IncrementoDeCosto;
				_stockMinimo = rowPS.StockMinimo;
				_stockMaximo = rowPS.StockMaximo;
				_stockDisponible = rowPS.StockDisponible;
				_mac = rowPS.MAC;
				_maximoDescuento = rowPS.MaxDescuento;
				_precioDeVentaBruto = rowPS.PrecioDeVentaBruto;
				_precioDeVentaNeto = rowPS.PrecioDeVentaNeto;
			}


			public long IdEmpresa
			{
				get{return _idEmpresa;}
				set{_idEmpresa = value;}
			}

			public string Empresa
			{
				get{return _empresa;}
				set{_empresa = value;}
			}



			public decimal CargoFijoProductos
			{		
				get{return _cargoFijoProductos;}
				//set{_cargoFijoProductos = value;}
			}

			public decimal BonificacionRecargoProductos
			{
				get{return _bonificacionRecargoProductos;}
				//set{_bonificacionRecargoProductos = value;}
			}

			public decimal StockMinimo
			{
				get{return _stockMinimo;}
				set{_stockMinimo = value;}
			}

			public decimal StockMaximo
			{
				get{return _stockMaximo;}				
				set{_stockMaximo = value;}
			}

			public decimal StockDisponible
			{
				get{return _stockDisponible;}				
			}

			public ControladorProductos Producto
			{
				get{return _producto;}
				set{_producto = value;}
			}

			public long IdSucursal
			{
				get{return _idSucursal;}
				set{_idSucursal = value;}
			}

			public string Descripcion
			{
				get{return _descripcion;}
				set{
					_descripcion = value;
				}
			}

			public bool Bloqueado
			{
				get{return _bloqueado;}
				set{_bloqueado = value;}
			}

			public decimal IncrementoDeCosto
			{
				get{return _incrementoDeCosto;}
				set{_incrementoDeCosto = value;}
			}		
			
			public decimal MAC
			{
				get{return _mac;}
				set{_mac = value;}
			}
		
			public decimal PrecioDeVentaNeto
			{
				get
				{
					decimal precioDeCostoProducto = this.Producto.PrecioCosto;
					decimal cargoFijoProducto = CargoFijoProductos;
					decimal incrementoDeCosto = IncrementoDeCosto;
					decimal montoDeIncremento = precioDeCostoProducto * incrementoDeCosto / 100;
					decimal precioDeCosto = (precioDeCostoProducto + montoDeIncremento + cargoFijoProducto);
					//Si el margen especifico para la sucursal no está definido obtengo el precio a partir del precio margen
					//definido en la central para el producto
					decimal precioDeVentaNeto = 0;
					if (MAC != 0)
					{
						precioDeVentaNeto = (precioDeCosto * MAC / 100)+ precioDeCosto;
					}
					else
					{
						precioDeVentaNeto = (precioDeCosto * this.Producto.Margen / 100) + precioDeCosto;
					}

					return precioDeVentaNeto;
				}
				//set{_precioDeVentaNeto = value;}
			}

			public decimal PrecioDeVentaBruto
			{
				get
				{
					decimal precioDeVentaBruto = this.Producto.PrecioLista;
					decimal incrementoProducto= precioDeVentaBruto * (BonificacionRecargoProductos / 100);
					decimal precioDeVentaBrutoSucursal = precioDeVentaBruto + incrementoProducto;
					return precioDeVentaBrutoSucursal;
				}
				//set{_precioDeVentaBruto = value;}
			}


			public decimal MaximoDescuento
			{	
				get{return (PrecioDeVentaBruto - PrecioDeVentaNeto);}
				//set{_maximoDescuento = value;}
			}

			private int _german=0;
			public int German
			{
				set { _german=value ; }
				get { return _german; }
			}
			public bool IsAvailable
			{		
				get
				{return _isAvailable;}

				
				set
				{
					_isAvailable = value;}
			}

		}

		public class ProductoABMProducto
		{
			private string _descripcion = string.Empty;
			private string _codigoSecundario = string.Empty;
			private  ArrayList _jerarquias = new ArrayList();
			


			public ArrayList Jerarquias
			{
				get{return _jerarquias;}
				set{_jerarquias = value;}
			}

			
			public string Descripcion
			{
				get{return _descripcion;}
				set{_descripcion = value;}
			}

			public string CodigoSecundario
			{
				get{return _codigoSecundario;}
				set{_codigoSecundario = value;}
			}
		}


		public class ProductoJerarquia
		{
			private string _idProducto = string.Empty;
			private string _jerarquia = string.Empty;
			private string _idNomenclatura = string.Empty;

			public string IdProducto
			{
				get{return _idProducto;}
				set{_idProducto = value;}
			}
			public string IdNomenclatura
			{
				get{return _idNomenclatura;}
				set{_idNomenclatura = value;}
			}
			public string Jerarquia
			{
				get{return _jerarquia;}
				set{_jerarquia = value;}
			}
		}

		
		public sealed class ProductoImpuesto
		{
			private string _idImpuesto = "";
			private string _descripcion = "";
			private bool _activo = false;
			private string _formula = "";
			private string _key = string.Empty;
			private string _descripcionCorta = string.Empty;

			public event EventHandler ActivoChanged;
			public string Key
			{
				get
				{
					return _key;
				}
				set
				{
					_key = value;
				}
			}

			public string DescripcionCorta 
			{
				get{return _descripcionCorta;}
				set{_descripcionCorta = value;}
			}

			public string IdImpuesto 
			{
				get {return _idImpuesto;}
				set {_idImpuesto = value;}
			}
			public string Descripcion 
			{
				get {return _descripcion;}
				set {_descripcion = value;}
			}
			public bool Activo 
			{
				get {return _activo;}
				set 
				{
					_activo = value;
					if(ActivoChanged != null)
						ActivoChanged(this, new EventArgs());

				}
			}
			public string Formula
			{
				get {return _formula;}
				set {_formula = value;}
			}
		}


	






		}
		
	public class ProductosJerarquiaAuxiliar
	{	
		private Hashtable _productoJerarquia=new Hashtable();
		private string _jerarquia1 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia1" );
		private string _jerarquia2 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia2" );
		private string _jerarquia3 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia3" );
		private string _jerarquia4 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia4" );
		private string _jerarquia5 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia5" );
		private string _jerarquia6 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia6" );
		private string _jerarquia7 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia7" );
		private string _jerarquia8 = Variables.GetValueString( "Productos.BusquedaJerarquica.Jerarquia8" );
		public ProductosJerarquiaAuxiliar()
		{	

		}
		#region properties
			
		public string Jerarquia1
		{
			get{return _jerarquia1;}
			set{_jerarquia1 = value;}
		}

		public string Jerarquia2
		{
			get{return _jerarquia2;}
			set{_jerarquia2 = value;}
		}
		public string Jerarquia3
		{
			get{return _jerarquia3;}
			set{_jerarquia3 = value;}
		}
		public string Jerarquia4
		{
			get{return _jerarquia4;}
			set{_jerarquia4= value;}
		}
		public string Jerarquia5
		{
			get{return _jerarquia5;}
			set{_jerarquia5 = value;}
		}
		public string Jerarquia6
		{
			get{return _jerarquia6;}
			set{_jerarquia6 = value;}
		}
		public string Jerarquia7
		{
			get{return _jerarquia7;}
			set{_jerarquia7 = value;}
		}
		public string Jerarquia8
		{
			get{return _jerarquia8;}
			set{_jerarquia8 = value;}
		}
		public Hashtable ProductoJerarquia
		{
			get{return _productoJerarquia;}
			set{_productoJerarquia = value;}
		}
			
		#endregion properties
			
		public void cargarJerarquias(tsh_ProductosExDataset.tsh_AgrupProductosDataTable tabla)
		{
			
			foreach (tsh_ProductosExDataset.tsh_AgrupProductosRow row in tabla)
			{
				if (!Convert.ToString(row.RowState).Equals("Deleted"))
				{
					string idProducto= Convert.ToString(row.IdProducto);
					string jerarquia=Convert.ToString(row.Jerarquia);
					string jerarquiaReal=this.jerarquiaReal(jerarquia);
					ArrayList jerarProducto;
					ArrayList ArrayNiveles;
					if(_productoJerarquia[idProducto]!=null)
					{
						jerarProducto=(ArrayList)_productoJerarquia[idProducto];
					}
					else 
					{
						//German 200911217
							//ArrayList aux=new ArrayList(7);
							ArrayList aux=new ArrayList(8);
						//Fin German 200911217
						int contador;
						//German 200911217
						//for( contador=0; contador <= 6; contador++ ) 
						for( contador=0; contador <= 7; contador++ ) 
						//German 200911217
						{
							aux.Add(new ArrayList());
						}
						_productoJerarquia.Add(idProducto,aux);
						jerarProducto=(ArrayList)_productoJerarquia[idProducto];
					}
					
					//Me da 1, 2, 3.....
					int posicion=Convert.ToInt16(jerarquiaReal.Substring(jerarquiaReal.Length-1,1));
					ArrayNiveles=new ArrayList();
					ArrayNiveles = Util.Parse(jerarquia,20);
					//Aca tengo en la posicion de la jerarquia guardado un array con lo q va en cada IdNomenclatura
					//jerarProducto[posicion-1]=ArrayNiveles;
					posicion--;
					//jerarProducto.Insert(posicion,ArrayNiveles);
					jerarProducto[posicion] = ArrayNiveles;
				}
			}
		}
		
		
		public void cargarJerarquias(string jerarquia,string idProducto)
		{
			string jerarquiaReal=this.jerarquiaReal(jerarquia);
			ArrayList jerarProducto;
			ArrayList ArrayNiveles;
			if(_productoJerarquia[idProducto]!=null)
			{
				jerarProducto=(ArrayList)_productoJerarquia[idProducto];
			}
			else 
			{
				//German 200911217
				//ArrayList aux=new ArrayList(7);
				ArrayList aux=new ArrayList(8);
				//Fin German 200911217
				int contador;
				//German 200911217
				//for( contador=0; contador <= 6; contador++ ) 
				for( contador=0; contador <= 7; contador++ ) 
					//German 200911217
				{
					aux.Add(new ArrayList());
				}
				_productoJerarquia.Add(idProducto,aux);
				jerarProducto=(ArrayList)_productoJerarquia[idProducto];
			}
					
			//Me da 1, 2, 3.....
			int posicion=Convert.ToInt16(jerarquiaReal.Substring(jerarquiaReal.Length-1,1));
			ArrayNiveles=new ArrayList();
			ArrayNiveles = Util.Parse(jerarquia,20);
			//Aca tengo en la posicion de la jerarquia guardado un array con lo q va en cada IdNomenclatura
			//jerarProducto[posicion-1]=ArrayNiveles;
			posicion--;
			jerarProducto.Insert(posicion,ArrayNiveles);
									
		}
		
		private string jerarquiaReal(string jerarquia)
		{
			string resultado=string.Empty;	
			string aux=jerarquia.Substring(0,20);
			
			if( aux== this._jerarquia1)
				resultado="jerarquia1";
			if( aux== this._jerarquia2)
				resultado="jerarquia2";
			if( aux== this._jerarquia3)
				resultado="jerarquia3";
			if( aux== this._jerarquia4)
				resultado="jerarquia4";
			if( aux== this._jerarquia5)
				resultado="jerarquia5";
			if( aux== this._jerarquia6)
				resultado="jerarquia6";
			if( aux== this._jerarquia7)
				resultado="jerarquia7";
			if( aux== this._jerarquia8)
				resultado="jerarquia8";
			return resultado;
		}

		public string nomenclaturaReal(string jerarquia)
		{
			string resultado=string.Empty;	
			string aux=jerarquia.Substring(0,20);
			
			if( aux== this._jerarquia1)
				resultado="IdNomenclatura1";
			if( aux== this._jerarquia2)
				resultado="IdNomenclatura2";
			if( aux== this._jerarquia3)
				resultado="IdNomenclatura3";
			if( aux== this._jerarquia4)
				resultado="IdNomenclatura4";
			if( aux== this._jerarquia5)
				resultado="IdNomenclatura5";
			if( aux== this._jerarquia6)
				resultado="IdNomenclatura6";
			if( aux== this._jerarquia7)
				resultado="IdNomenclatura7";
			if( aux== this._jerarquia8)
				resultado="IdNomenclatura8";
			return resultado;
		}
			
	}
}

