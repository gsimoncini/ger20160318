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

	public class tsh_Productos : IDisposable
	{
	
		#region Custom Members
		/// <summary>
		/// Envia los cambios del tsh_ProductosRow a la base de datos.
		/// </summary>
		/// 

        //Sabrina: Tarea 1068. 20110317
        public static tsh_ProductosDataset GetProductosEnCombo(string IdTransaction)
        {
            return mz.erp.dataaccess.tsh_Productos.GetProductosEnCombo(IdTransaction);
        }
        //Fin Sabrina: Tarea 1068. 20110317

		public static string GetIdProductoByCodigoProveedorIdProveedor( string CodigoProveedor, string IdProveedor )
		{
			return mz.erp.dataaccess.tsh_Productos.GetIdProductoByCodigoProveedorIdProveedor(CodigoProveedor, IdProveedor);
		}

        public static DataTable GetListIdProductoByCodigoProveedorIdProveedor(string CodigoProveedor, string IdProveedor)
        {
            return mz.erp.dataaccess.tsh_Productos.GetListIdProductoByCodigoProveedorIdProveedor(CodigoProveedor, IdProveedor);
        }

		public static string GetIdProductoByCodigoProveedor( string CodigoProveedor )
		{
			return mz.erp.dataaccess.tsh_Productos.GetIdProductoByCodigoProveedor(CodigoProveedor);
		}
		
		public static string GetIdProductoByCodigoSecundario( string CodigoSecundario )
		{
			return mz.erp.dataaccess.tsh_Productos.GetIdProductoByCodigoSecundario(CodigoSecundario);		
		}

		
		public static string GetIdProductoByCodigo( string Codigo )
		{
			return mz.erp.dataaccess.tsh_Productos.GetIdProductoByCodigo(Codigo);		
		}



		public static void	UpdatePrecios(string IdTransaction, string IdCotizacion)
		{
			mz.erp.dataaccess.tsh_Productos.UpdatePrecios(IdTransaction, IdCotizacion);
		}
		public static void Update( tsh_ProductosDataset.tsh_ProductosRow row, string IdTransaction, SentenciasReplicacion sentencias )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Productos.Update( row, IdTransaction, sentencias  );
		}
		/// <summary>
		/// Obtiene la clave primaria de un producto en base a la clave unica. En caso de inconsistencia en los datos y que dos
		/// valores arrojen en mismo resultado, devuelve siempre el primero.
		/// </summary>
		/// <param name="IdProducto"></param>
		/// <returns></returns>
		/// 


		public static DataSet getPreciosDeCostoAnterior(string idProducto, string tiposDeComprobantes)
		{
			return mz.erp.dataaccess.tsh_Productos.getPreciosDeCostoAnterior(idProducto, tiposDeComprobantes);
		}


		public static string GetPkByCodigo( string Codigo )
		{
            //Sabrina: Tarea 1080. 20110326
			return GetPkByCodigo( Codigo , true, true );
            //Fin Sabrina: Tarea 1080. 20110326			
		}

		public static string GetPkByMultipleCodigoSecundario( string CodigoSecundario )
		{			
			string IdProducto = string.Empty;	
			string IdTipoProducto = null;
			string Codigo = null;			
			string Descripcion = null;
			string DescripcionCorta = null;
			string DescripcionLarga = null;
            //Sabrina: Tarea 1080. 20110326
			tsh_ProductosDataset data = GetListByMultipleCodigoSecundario(IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, true);
            //Fin Sabrina: Tarea 1080. 20110326
			if (data != null && data.tsh_Productos.Rows.Count > 0) 
			{
				IdProducto = data.tsh_Productos.Rows[0]["IdProducto"].ToString();
			}
			return IdProducto;
		}

        //Sabrina: Tarea 1080. 20110326
        public static string GetPkByMultipleCodigoSecundario(string CodigoSecundario, bool PermiteProductosCombo)
        {
            string IdProducto = string.Empty;
            string IdTipoProducto = null;
            string Codigo = null;
            string Descripcion = null;
            string DescripcionCorta = null;
            string DescripcionLarga = null;
            //Sabrina: Tarea 1080. 20110326
            tsh_ProductosDataset data = GetListByMultipleCodigoSecundario(IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, PermiteProductosCombo);
            //Fin Sabrina: Tarea 1080. 20110326
            if (data != null && data.tsh_Productos.Rows.Count > 0)
            {
                IdProducto = data.tsh_Productos.Rows[0]["IdProducto"].ToString();
            }
            return IdProducto;
        }
        //Fin Sabrina: Tarea 1080. 20110326

		public static string GetPkByCodigoSecundario( string CodigoSecundario )
		{
            //Sabrina: Tarea 1080. 20110326
			return GetPkByCodigoSecundario( CodigoSecundario , true, true );
            //Fin Sabrina: Tarea 1080. 20110326
		}

        //Sabrina: Tarea 1080. 20110326
        public static string GetPkByCodigoSecundario(string CodigoSecundario, bool Activo, bool PermiteProductosCombo)
        //Fin Sabrina: Tarea 1080. 20110326
		{			
			string IdProducto = string.Empty;	
			string IdTipoProducto = null;
			string Codigo = null;			
			string CodigoProveedor = null;			
			string Descripcion = null;
			string DescripcionCorta = null;
			string DescripcionLarga = null;
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
            tsh_ProductosDataset data = GetList(IdTipoProducto, Codigo, CodigoSecundario, CodigoProveedor, Descripcion, DescripcionCorta, DescripcionLarga, Activo, PermiteProductosCombo, false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
			if (data != null && data.tsh_Productos.Rows.Count > 0) 
			{
				IdProducto = data.tsh_Productos.Rows[0]["IdProducto"].ToString();
			}
			return IdProducto;
		}

		public static string GetPkByCodigoProveedor( string CodigoProveedor )
		{
            //Sabrina: Tarea 1080. 20110326
			return GetPkByCodigoProveedor( CodigoProveedor , true, true );
            //Fin Sabrina: Tarea 1080. 20110326
		}

        //Sabrina: Tarea 1080. 20110326
		public static string GetPkByCodigoProveedor( string CodigoProveedor, bool Activo, bool PermiteProuctosCombo )
        //Fin Sabrina: Tarea 1080. 20110326
		{			
			string IdProducto = string.Empty;	
			string IdTipoProducto = null;
			string Codigo = null;			
			string Descripcion = null;
			string DescripcionCorta = null;
			string DescripcionLarga = null;
			string CodigoSecundario = null;
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
            tsh_ProductosDataset data = GetList(IdTipoProducto, Codigo, CodigoSecundario, CodigoProveedor, Descripcion, DescripcionCorta, DescripcionLarga, Activo, PermiteProuctosCombo, false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
			if (data != null && data.tsh_Productos.Rows.Count > 0) 
			{
				IdProducto = data.tsh_Productos.Rows[0]["IdProducto"].ToString();
			}
			return IdProducto;
		}

		public static bool ExisteMultipleCodigoSecundario(string IdProducto, string CodigoSecundario )
		{			
			string IdProd = string.Empty;	
			string IdTipoProducto = null;
			string Codigo = null;			
			string Descripcion = null;
			string DescripcionCorta = null;
			string DescripcionLarga = null;
            //Sabrina: Tarea 1080. 20110326
            bool PermiteProductosCombo = true;
			tsh_ProductosDataset data = GetListByMultipleCodigoSecundario(IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, PermiteProductosCombo);
            //Fin Sabrina: Tarea 1080. 20110326
			foreach(DataRow row in data.tsh_Productos.Rows) 
			{
				IdProd = data.tsh_Productos.Rows[0]["IdProducto"].ToString();
				if(!IdProd.Equals(IdProducto))
					return true;
			}
			return false;
		}

		public static bool ExisteCodigoSecundario(string IdProducto, string CodigoSecundario )
		{			
			string IdProd = string.Empty;	
			string IdTipoProducto = null;
			string Codigo = null;			
			string CodigoProveedor = null;		
			string Descripcion = null;
			string DescripcionCorta = null;
			string DescripcionLarga = null;
			tsh_ProductosDataset data = GetList(IdTipoProducto, Codigo, CodigoSecundario, CodigoProveedor, Descripcion, DescripcionCorta, DescripcionLarga);
			foreach(DataRow row in data.tsh_Productos.Rows) 
			{
				IdProd = data.tsh_Productos.Rows[0]["IdProducto"].ToString();
				if(!IdProd.Equals(IdProducto))
					return true;
			}
			return false;
		}

		public static bool ExisteCodigoSecundario(string IdProducto, string CodigoSecundario, bool MultiplesCodigosSecundarios) 
		{
			//string IdProducto;
			if(!MultiplesCodigosSecundarios)
				//IdProducto = GetPkByCodigoSecundario(CodigoSecundario);
				return ExisteCodigoSecundario(IdProducto, CodigoSecundario );
			else
				//IdProducto = GetPkByMultipleCodigoSecundario(CodigoSecundario);
				return ExisteMultipleCodigoSecundario(IdProducto, CodigoSecundario );
			//return (IdProducto != String.Empty);
		}
		
        //Sabrina: Tarea 1080. 20110326
        public static string GetPkByCodigo(string Codigo, bool activo, bool PermiteProductosCombo)
        //Fin Sabrina: Tarea 1080. 20110326
		{
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
			tsh_ProductosDataset dataProducto = mz.erp.dataaccess.tsh_Productos.GetListDataProductos( null, Codigo, null, null,null, null, null, activo, Security.IdEmpresa,Security.IdSucursal,IdMonedaReferencia, IdFuenteDeCambio, PermiteProductosCombo, false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
			if (dataProducto.tsh_Productos.Rows.Count > 0) 
			{
				tsh_ProductosDataset.tsh_ProductosRow rowProducto = (tsh_ProductosDataset.tsh_ProductosRow)dataProducto.tsh_Productos.Rows[0];
				return rowProducto.IdProducto;
			}
			return "";
		}

		public static tsh_ProductosDataset GetListByIdTipoProducto( string IdTipoProducto )
		{
			return mz.erp.dataaccess.tsh_Productos.GetListByIdTipoProducto( IdTipoProducto );							
		}

		/*[ atMethodDeleteRow]
		public static void Delete(tsh_ProductosDataset.tsh_ProductosRow row)
		{
			
			row.Delete();
			Update(row);
			if	(row.Table.HasErrors)
			{
				row.RejectChanges();
				row["Activo"] = false;
				Update(row);
				if (row.Table.HasErrors)
				{
					row.SetColumnError("IdProducto","No se ha podido eliminar el item");
				}
				else
				{
					row.SetColumnError("IdProducto","No se ha podido eliminar el item porque existen tablas relacionadas. Se ha procede a desactivar");
				}
			}

		}
*/
		public static System.Data.DataRow SetRowDefaultValues( System.Data.DataRow row )
		{
			row["IdProducto"] = Util.NewStringId();
			row["IdTipoProducto"] = mz.erp.businessrules.Variables.GetValueString("Productos.DefaultValues.TipoDeProducto");
			row["Codigo"] = string.Empty;
			row["CodigoSecundario"] = string.Empty;
			row["Descripcion"] = string.Empty;
			row["DescripcionCorta"] = string.Empty;
			row["DescripcionLarga"] = string.Empty;
			row["UnidadesPedido"] = 0;
			row["MAC"] = 0;
			row["PrecioDeCostoRef"] = 0;
			row["PrecioDeVentaNeto"] = 0;
			row["MaxDescuentoPorcentual"] = 0;
			row["MaxDescuento"] = 0;
			row["PrecioDeVentaBruto"] = 0;
			row["ObligaCodigoBarra"] = false;
			row["ObligaNumeroSerie"] = false;
			row["IdCuentaImputacion"] = 0;
			row["FechaUltimaCompra"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["Activo"] = true;
			row["FechaCreacion"] = mz.erp.businessrules.Sistema.DateTime.Now;
			row["IdConexionCreacion"] = Security.IdConexion;
			row["IdConexionUltimaModificacion"] = Security.IdConexion;
			row["IdReservado"] = 0;
			row["RowId"] = Guid.Empty;
			row["IdEmpresa"] = Security.IdEmpresa;
			row["IdSucursal"] = Security.IdSucursal;
			row["IdBonificacion"] = 0;
			row["Observaciones"] = string.Empty;
			row["PrecioDeCostoDirecto"] = 0;
			row["PrecioDeCostoIndirecto"] = 0;
			row["PercibeIB"] = true;
			row["CampoAuxiliar1"] = string.Empty;
			row["CampoAuxiliar2"] = string.Empty;
			row["CampoAuxiliar3"] = string.Empty;
			row["CampoAuxiliar4"] = string.Empty;
			row["CampoAuxiliar5"] = string.Empty;
			row["CampoAuxiliar6"] = string.Empty;
			row["CodigoProveedor"] = string.Empty;
           
			//Sabrina: tarea 56
			row["PrecioDeCostoPromedioPonderado"] = 0;
			row["PrecioDeCostoReposicion"] = 0;
			row["PrecioDeVentaMercadoBolsa"] = 0;
			row["PrecioDeVentaMercadoCadena"] = 0;
			row["PrecioDeVentaMercadoCompetenciaDirecta"] = 0;
			row["UsaPrecioDeCostoReposicion"] = mz.erp.businessrules.Variables.GetValueString("Productos.PrecioDeCosto.UsaPrecioDeCostoReposicion");
            //Sabrina: Tarea 1067. 20110311
            row["EsCombo"] = false;
            //Fin Sabrina: Tarea 1067. 20110311
			return row;

		}
		/// <summary>
		/// Establece los valores por defecto de tsh_ProductosRow.
		/// </summary>
		public static tsh_ProductosDataset.tsh_ProductosRow SetRowDefaultValues( tsh_ProductosDataset.tsh_ProductosRow row )
		{
			
			return (tsh_ProductosDataset.tsh_ProductosRow)SetRowDefaultValues((System.Data.DataRow)row );
		}



		public static tsh_ProductosDataset GetListEx( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga)
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;

			//Excluyo los inactivos
			bool Activo = true;

			if (!Variables.GetValueBool("Debug.Productos.ControlTotal"))
			{

				if (Security.IdEmpresa != 0)
				{
					IdEmpresa = Security.IdEmpresa;
				}
				if (Security.IdSucursal != 0)
				{
					IdSucursal = Security.IdSucursal;
				}
			}
            /* Silvina 20110704 - Tarea 0000136 */
			return mz.erp.dataaccess.tsh_Productos.GetListEx( IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
		}
        /* Silvina 20110704 - Tarea 0000136 */
		public static tsh_ProductosDataset GetListEx( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;

			if (!Variables.GetValueBool("Debug.Productos.ControlTotal"))
			{

				if (Security.IdEmpresa != 0)
				{
					IdEmpresa = Security.IdEmpresa;
				}
				if (Security.IdSucursal != 0)
				{
					IdSucursal = Security.IdSucursal;
				}
			}
            /* Silvina 20110704 - Tarea 0000136 */
			return mz.erp.dataaccess.tsh_Productos.GetListEx( IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, PermiteCambio);
            /* Fin Silvina 20110704 - Tarea 0000136 */
		}

		/// <summary>
		/// Obtiene tabla tsh_Productos filtrada por las condiciones de bsqueda
		/// </summary>
		public static System.Data.DataSet GetListExDataset( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga )
		{
			long IdEmpresa = long.MinValue;
			long IdSucursal = long.MinValue;

			//Excluyo los inactivos
			bool Activo = true;

			if (Security.IdEmpresa != 0)
			{
				IdEmpresa = Security.IdEmpresa;
			}
			if (Security.IdSucursal != 0)
			{
				IdSucursal = Security.IdSucursal;
			}
            /* Silvina 20110704 - Tarea 0000136 */
			return (System.Data.DataSet)mz.erp.dataaccess.tsh_Productos.GetListEx( IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal,false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
		}
		#endregion
		
		public tsh_Productos()
		{
		}

		/// <summary>
		/// Obtiene la lista completa de la tabla tsh_Productos
		/// </summary>
		public static tsh_ProductosDataset GetList()
		{
			return mz.erp.dataaccess.tsh_Productos.GetList();
		}
		
		/// <summary>
		/// Obtiene tabla tsh_Productos filtrada por las condiciones de bsqueda
		/// </summary>
		/// 
        //Sabrina: Tarea 1080. 20110326
		public static tsh_ProductosDataset GetListByMultipleCodigoSecundario( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool PermiteProductosCombo )
        //Fin Sabrina: Tarea 1080. 20110326
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;

			//Excluyo los inactivos
			bool Activo = true;

			if (!Variables.GetValueBool("Debug.Productos.ControlTotal"))
			{

				if (Security.IdEmpresa != 0)
				{
					IdEmpresa = Security.IdEmpresa;
				}
				if (Security.IdSucursal != 0)
				{
					IdSucursal = Security.IdSucursal;
				}
			}
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            return mz.erp.dataaccess.tsh_Productos.GetListByMultipleCodigoSecundarioDataProductos(IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, PermiteProductosCombo);
            //Fin Sabrina: Tarea 1080. 20110326
		}

		public static tsh_ProductosDataset GetList( string IdTipoProducto, string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string DescripcionCorta, string DescripcionLarga )
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;

			//Excluyo los inactivos
			bool Activo = true;

			if (!Variables.GetValueBool("Debug.Productos.ControlTotal"))
			{

				if (Security.IdEmpresa != 0)
				{
					IdEmpresa = Security.IdEmpresa;
				}
				if (Security.IdSucursal != 0)
				{
					IdSucursal = Security.IdSucursal;
				}
			}
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
			return mz.erp.dataaccess.tsh_Productos.GetListDataProductos( IdTipoProducto, Codigo, CodigoSecundario, CodigoProveedor, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, true, false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}

		/// <summary>
		/// Obtiene tabla tsh_Productos filtrada por las condiciones de bsqueda
        /// </summary>
        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        public static tsh_ProductosDataset GetList(string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, bool PermiteCambio)
        {
            bool PermiteProductosCombo = true;
            return GetList(IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, PermiteProductosCombo, PermiteCambio);
        }

        public static tsh_ProductosDataset GetList(string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, bool PermiteproductoCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;
		
			if (!Variables.GetValueBool("Debug.Productos.ControlTotal"))
			{

				if (Security.IdEmpresa != 0)
				{
					IdEmpresa = Security.IdEmpresa;
				}
				if (Security.IdSucursal != 0)
				{
					IdSucursal = Security.IdSucursal;
				}
			}
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
			return mz.erp.dataaccess.tsh_Productos.GetListDataProductos( IdTipoProducto, Codigo, CodigoSecundario, null, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, PermiteproductoCombo, PermiteCambio);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}

        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        public static tsh_ProductosDataset GetList(string IdTipoProducto, string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, bool PermiteProductosCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{
			long IdEmpresa = Security.IdEmpresa;
			long IdSucursal = Security.IdSucursal;
		
			if (!Variables.GetValueBool("Debug.Productos.ControlTotal"))
			{

				if (Security.IdEmpresa != 0)
				{
					IdEmpresa = Security.IdEmpresa;
				}
				if (Security.IdSucursal != 0)
				{
					IdSucursal = Security.IdSucursal;
				}
			}
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
			return mz.erp.dataaccess.tsh_Productos.GetListDataProductos( IdTipoProducto, Codigo, CodigoSecundario, CodigoProveedor, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, PermiteProductosCombo, PermiteCambio);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}

		/// <summary>
		/// Obtiene tabla tsh_Productos filtrada por las condiciones de bsqueda
		/// </summary>
		public static System.Data.DataSet GetListDataset( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, string IdCondicionDeVentaVisualizacion )
		{
			long IdEmpresa = long.MinValue;
			long IdSucursal = long.MinValue;

			//Excluyo los inactivos
			bool Activo = true;

			if (Security.IdEmpresa != 0)
			{
				IdEmpresa = Security.IdEmpresa;
			}
			if (Security.IdSucursal != 0)
			{
				IdSucursal = Security.IdSucursal;
			}
			string IdMonedaReferencia = Variables.GetValueString( "Contabilidad.MonedaReferencia" );
			if (IdMonedaReferencia.CompareTo(string.Empty)==0) { IdMonedaReferencia = null; }
			string IdFuenteDeCambio = Variables.GetValueString( "Contabilidad.FuenteDeCambioReferencia" );
			if (IdFuenteDeCambio.CompareTo(string.Empty)==0) { IdFuenteDeCambio = null; }
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
			return (System.Data.DataSet)mz.erp.dataaccess.tsh_Productos.GetList( IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, IdCondicionDeVentaVisualizacion, true, false);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}

		/// <summary>
		/// Crea un tsh_ProductosRow que luego puede ser persistido en la base de datos.
		/// </summary>
		[ atMethodNewRow ]
		public static tsh_ProductosDataset.tsh_ProductosRow NewRow()
		{
			return SetRowDefaultValues(mz.erp.dataaccess.tsh_Productos.NewRow());
		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Productos que luego puede ser persistido en la base de datos.
		/// </summary>
		public static tsh_ProductosDataset.tsh_ProductosRow GetByPk( string IdProducto )
		{
			tsh_ProductosDataset.tsh_ProductosRow row = mz.erp.dataaccess.tsh_Productos.GetByPk( IdProducto  );
			if (row != null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						object defalutValue = Util.DefaultValue( dc.DataType );
						if (defalutValue !=null)
						{
							row[dc] = defalutValue;
						}
					}
				}
			}
			return row;

		}

		/// <summary>
		/// Obtiene un registro de la tabla tsh_Productos que luego puede ser persistido en la base de datos. Metodo Sobrecargado
		/// </summary>
		[ atMethodGetByPkRow ]
		public static tsh_ProductosDataset.tsh_ProductosRow GetByPk( object IdProducto )
		{
			return GetByPk( ( string )IdProducto );
		}

		/*
		/// <summary>
		/// Envia los cambios del tsh_ProductosRow a la base de datos realizando una validacin previa.
		/// </summary>
		[ atMethodSaveRowWithValidation ]
		public static void UpdateWithValidation( tsh_ProductosDataset.tsh_ProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			
			if ( RowIsValid( row ) )
			{
				Update( row );
			}
		}
		*/
		/// <summary>
		/// Envia los cambios del tsh_ProductosRow a la base de datos realizando una validacin previa. Mtodo Sobrecargado
		/// </summary>
		public static void UpdateWithValidation( System.Data.DataRow row )
		{
			UpdateWithValidation( ( tsh_ProductosDataset.tsh_ProductosRow )row );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosDataset a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosDataset dataSet )
		{
			ApplicationAssert.Check( dataSet != null, "El argumento dataSet no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataSet.tsh_Productos.Rows.Count > 0, "La tabla dataSet.tsh_ProductosDataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Productos.Update( dataSet );
		}
		
		/// <summary>
		/// Envia los cambios del tsh_ProductosDataset.tsh_ProductosDataTable a la base de datos.
		/// </summary>
		public static void Update( tsh_ProductosDataset.tsh_ProductosDataTable dataTable )
		{
			ApplicationAssert.Check( dataTable != null, "El argumento dataTable no debe ser nulo.", ApplicationAssert.LineNumber );
			ApplicationAssert.Check( dataTable.Rows.Count > 0, "El argumento dataTable debe poseer alguna fila.", ApplicationAssert.LineNumber );
			
			mz.erp.dataaccess.tsh_Productos.Update( dataTable );
		}
		
		/// <summary>
		/// Valida un tsh_ProductosRow.
		/// </summary>
		public static bool RowIsValid( tsh_ProductosDataset.tsh_ProductosRow row )
		{
			ApplicationAssert.Check( row != null, "El argumento row no debe ser nulo.", ApplicationAssert.LineNumber );
			bool isValid=true;
			string mensaje;
			
			
			if ( !IdProductoIsValid( row.IdProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdTipoProductoIsValid( row.IdTipoProducto, out mensaje) )
			{ 
				row.SetColumnError( "IdTipoProducto" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdBonificacionIsValid( row.IdBonificacion, out mensaje) )
			{ 
				row.SetColumnError( "Bonificacion" , mensaje);
				isValid=false;
			
			}
						
			
						
			if ( !CodigoIsValid( row.Codigo, out mensaje) )
			{ 
				row.SetColumnError( "Codigo" , mensaje);
				isValid=false;
			
			}
						
			if ( !CodigoSecundarioIsValid( row.CodigoSecundario, out mensaje) )
			{ 
				row.SetColumnError( "CodigoSecundario" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionIsValid( row.Descripcion, out mensaje) )
			{ 
				row.SetColumnError( "Descripcion" , mensaje);
				isValid=false;
			
			}
						
			if ( !DescripcionCortaIsValid( row.DescripcionCorta, out mensaje) )
			{ 
				row.SetColumnError( "DescripcionCorta" , mensaje);
				isValid=false;
			
			}

			if (row.DescripcionCorta =="") row.DescripcionCorta = row.Descripcion;
						
			if ( !DescripcionLargaIsValid( row.DescripcionLarga, out mensaje) )
			{ 
				row.SetColumnError( "DescripcionLarga" , mensaje);
				isValid=false;
			
			}
			if (row.DescripcionLarga =="") row.DescripcionLarga = row.Descripcion;
						
								
			if ( !UnidadesPedidoIsValid( row.UnidadesPedido, out mensaje) )
			{ 
				row.SetColumnError( "UnidadesPedido" , mensaje);
				isValid=false;
			
			}
						
			if ( !MACIsValid( row.MAC, out mensaje) )
			{ 
				row.SetColumnError( "MAC" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeCostoRefIsValid( row.PrecioDeCostoRef, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeCostoRef" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaNetoIsValid( row.PrecioDeVentaNeto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaNeto" , mensaje);
				isValid=false;
			
			}
						
			if ( !MaxDescuentoPorcentualIsValid( row.MaxDescuentoPorcentual, out mensaje) )
			{ 
				row.SetColumnError( "MaxDescuentoPorcentual" , mensaje);
				isValid=false;
			
			}
						
			if ( !MaxDescuentoIsValid( row.MaxDescuento, out mensaje) )
			{ 
				row.SetColumnError( "MaxDescuento" , mensaje);
				isValid=false;
			
			}
						
			if ( !PrecioDeVentaBrutoIsValid( row.PrecioDeVentaBruto, out mensaje) )
			{ 
				row.SetColumnError( "PrecioDeVentaBruto" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObligaCodigoBarraIsValid( row.ObligaCodigoBarra, out mensaje) )
			{ 
				row.SetColumnError( "ObligaCodigoBarra" , mensaje);
				isValid=false;
			
			}
						
			if ( !ObligaNumeroSerieIsValid( row.ObligaNumeroSerie, out mensaje) )
			{ 
				row.SetColumnError( "ObligaNumeroSerie" , mensaje);
				isValid=false;
			
			}
						
			if ( !IdCuentaImputacionIsValid( row.IdCuentaImputacion, out mensaje) )
			{ 
				row.SetColumnError( "IdCuentaImputacion" , mensaje);
				isValid=false;
			
			}
						
			if ( !FechaUltimaCompraIsValid( row.FechaUltimaCompra, out mensaje) )
			{ 
				row.SetColumnError( "FechaUltimaCompra" , mensaje);
				isValid=false;
			
			}
						
			if ( !ActivoIsValid( row.Activo, out mensaje) )
			{ 
				row.SetColumnError( "Activo" , mensaje);
				isValid=false;
			
			}

			if ( !IdResponsableCreacionIsValid( row.IdResponsableCreacion, out mensaje) )
			{ 
				row.SetColumnError( "IdResponsableCreacion" , mensaje);
				isValid=false;
			
			}
						
		/*	if ( !FechaCreacionIsValid( row.FechaCreacion, out mensaje) )
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
			
			}*/
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
		
		public static bool IdBonificacionIsValid( string IdBonificacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdBonificacionIsValid( string IdBonificacion)
		{
			string mensaje;
			return IdBonificacionIsValid( IdBonificacion, out mensaje );
		}
		/// <summary>
		/// Valida el campo IdTipoProducto.
		/// </summary>
		public static bool IdTipoProductoIsValid( string IdTipoProducto , out string mensaje )
		{
			if (IdTipoProducto=="")
			{
				mensaje = "Debe seleccionar un tipo de Producto";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdTipoProducto. Metodo Sobrecargado
		/// </summary>
		public static bool IdTipoProductoIsValid( string IdTipoProducto)
		{
			string mensaje;
			return IdTipoProductoIsValid( IdTipoProducto, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Codigo.
		/// </summary>
		public static bool CodigoIsValid( string Codigo , out string mensaje )
		{
			bool codigoAutomatico = Variables.GetValueBool("Productos.CodigoAutomatico");
			if (codigoAutomatico == false && Codigo == "") 
			{
				mensaje = "El codigo del producto no debe ser nulo";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo Codigo. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoIsValid( string Codigo)
		{
			string mensaje;
			return CodigoIsValid( Codigo, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo CodigoSecundario.
		/// </summary>
		public static bool CodigoSecundarioIsValid( string CodigoSecundario , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo CodigoSecundario. Metodo Sobrecargado
		/// </summary>
		public static bool CodigoSecundarioIsValid( string CodigoSecundario)
		{
			string mensaje;
			return CodigoSecundarioIsValid( CodigoSecundario, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo Descripcion.
		/// </summary>
		public static bool DescripcionIsValid( string Descripcion , out string mensaje )
		{
			if (Descripcion == null || Descripcion.Trim() == "")
			{
				mensaje = "Debe ingresar la descripcion del producto";
				return false;
			}
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
		/// Valida el campo DescripcionCorta.
		/// </summary>
		public static bool DescripcionCortaIsValid( string DescripcionCorta , out string mensaje )
		{

			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescripcionCorta. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionCortaIsValid( string DescripcionCorta)
		{
			string mensaje;
			return DescripcionCortaIsValid( DescripcionCorta, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo DescripcionLarga.
		/// </summary>
		public static bool DescripcionLargaIsValid( string DescripcionLarga , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo DescripcionLarga. Metodo Sobrecargado
		/// </summary>
		public static bool DescripcionLargaIsValid( string DescripcionLarga)
		{
			string mensaje;
			return DescripcionLargaIsValid( DescripcionLarga, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UnidadesPorPack.
		/// </summary>
		public static bool UnidadesPorPackIsValid( decimal UnidadesPorPack , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UnidadesPorPack. Metodo Sobrecargado
		/// </summary>
		public static bool UnidadesPorPackIsValid( decimal UnidadesPorPack)
		{
			string mensaje;
			return UnidadesPorPackIsValid( UnidadesPorPack, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdPack.
		/// </summary>
		public static bool IdPackIsValid( string IdPack , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdPack. Metodo Sobrecargado
		/// </summary>
		public static bool IdPackIsValid( string IdPack)
		{
			string mensaje;
			return IdPackIsValid( IdPack, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo UnidadesPedido.
		/// </summary>
		public static bool UnidadesPedidoIsValid( decimal UnidadesPedido , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo UnidadesPedido. Metodo Sobrecargado
		/// </summary>
		public static bool UnidadesPedidoIsValid( decimal UnidadesPedido)
		{
			string mensaje;
			return UnidadesPedidoIsValid( UnidadesPedido, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo MAC_VentaNeto.
		/// </summary>
		public static bool MACIsValid( decimal MAC , out string mensaje )
		{
			if (MAC < 0)
			{
				mensaje = "El Margen/Precio Costo Neto no puede ser negativo";
				return false;
			}
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo MAC_VentaNeto. Metodo Sobrecargado
		/// </summary>
		public static bool MACIsValid( decimal MAC)
		{
			string mensaje;
			return MACIsValid( MAC, out mensaje );
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
		/// Valida el campo PrecioDeVentaNeto.
		/// </summary>
		public static bool PrecioDeVentaNetoIsValid( decimal PrecioDeVentaNeto , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo PrecioDeVentaNeto. Metodo Sobrecargado
		/// </summary>
		public static bool PrecioDeVentaNetoIsValid( decimal PrecioDeVentaNeto)
		{
			string mensaje;
			return PrecioDeVentaNetoIsValid( PrecioDeVentaNeto, out mensaje );
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
		/// Valida el campo ObligaCodigoBarra.
		/// </summary>
		public static bool ObligaCodigoBarraIsValid( bool ObligaCodigoBarra , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ObligaCodigoBarra. Metodo Sobrecargado
		/// </summary>
		public static bool ObligaCodigoBarraIsValid( bool ObligaCodigoBarra)
		{
			string mensaje;
			return ObligaCodigoBarraIsValid( ObligaCodigoBarra, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo ObligaNumeroSerie.
		/// </summary>
		public static bool ObligaNumeroSerieIsValid( bool ObligaNumeroSerie , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo ObligaNumeroSerie. Metodo Sobrecargado
		/// </summary>
		public static bool ObligaNumeroSerieIsValid( bool ObligaNumeroSerie)
		{
			string mensaje;
			return ObligaNumeroSerieIsValid( ObligaNumeroSerie, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo IdCuentaImputacion.
		/// </summary>
		public static bool IdCuentaImputacionIsValid( long IdCuentaImputacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo IdCuentaImputacion. Metodo Sobrecargado
		/// </summary>
		public static bool IdCuentaImputacionIsValid( long IdCuentaImputacion)
		{
			string mensaje;
			return IdCuentaImputacionIsValid( IdCuentaImputacion, out mensaje );
		}		
		
		/// <summary>
		/// Valida el campo FechaUltimaCompra.
		/// </summary>
		public static bool FechaUltimaCompraIsValid( DateTime FechaUltimaCompra , out string mensaje )
		{
			//Agregar cdigo de validacin
			mensaje="";
			return true;
		}
		
		/// <summary>
		/// Valida el campo FechaUltimaCompra. Metodo Sobrecargado
		/// </summary>
		public static bool FechaUltimaCompraIsValid( DateTime FechaUltimaCompra)
		{
			string mensaje;
			return FechaUltimaCompraIsValid( FechaUltimaCompra, out mensaje );
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
		/// Valida el campo IdResponsableCreacion.
		/// </summary>
		public static bool IdResponsableCreacionIsValid( string IdResponsableCreacion , out string mensaje )
		{
			//Agregar cdigo de validacin
			if (IdResponsableCreacion.Equals(string.Empty))
			{
				mensaje="No seleccionó el Responsable del alta";
				return false;
			}
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

