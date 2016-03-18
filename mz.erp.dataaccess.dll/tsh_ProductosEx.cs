using System;
using System.Data;
using System.Data.SqlClient;
using mz.erp.commontypes.data;

using mz.erp.commontypes;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de tsh_ProductosEx.
	/// </summary>
	public class tsh_ProductosEx
	{
		public tsh_ProductosEx()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public static tsh_ProductosExDataset NewDataset()
		{
			tsh_ProductosExDataset data = new mz.erp.commontypes.data.tsh_ProductosExDataset();
			return data;
			
		}
		public static tsh_ProductosExDataset.tsh_ProductosRow NewRowProductos()
		{
			return (new tsh_ProductosExDataset()).tsh_Productos.Newtsh_ProductosRow();
		}
		public static tsh_ProductosExDataset.tsh_ProductosRow NewRowProductos( tsh_ProductosExDataset data )
		{
			return data.tsh_Productos.Newtsh_ProductosRow();
		}

		public static System.Data.DataSet AddRowProductos( tsh_ProductosExDataset data, tsh_ProductosExDataset.tsh_ProductosRow row )
		{
			data.tsh_Productos.Addtsh_ProductosRow( row );
			return (System.Data.DataSet)data;
		}

		public static tsh_ProductosExDataset.tsh_ProductosSucursalesRow NewRowSucursales()
		{
			return (new tsh_ProductosExDataset()).tsh_ProductosSucursales.Newtsh_ProductosSucursalesRow();
		}
		public static tsh_ProductosExDataset.tsh_ProductosSucursalesRow NewRowSucursales( tsh_ProductosExDataset data )
		{
			return data.tsh_ProductosSucursales.Newtsh_ProductosSucursalesRow();
		}

		public static void Update( tsh_ProductosExDataset data , SentenciasReplicacion replicacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				tsh_Productos.Update( data.Tables["tsh_Productos"], trx , replicacion );
				tsh_ProductosSucursales.Update( data.Tables["tsh_ProductosSucursales"],trx , replicacion  );
				tsh_ProductosAuxiliares.Update(data.Tables["tsh_ProductosAuxiliares"],trx );
				tsy_ImpuestosProductos.Update( data.tsy_ImpuestosProductos, trx);
				tsh_ProductosJerarquias.Update(data.Tables["tsh_ProductosJerarquias"],trx);
				tsh_AgrupProductos.Update( data.tsh_AgrupProductos, trx, replicacion);
				tsh_ProductosListasDePrecios.Update( data.Tables["tsh_ProductosListasDePrecios"], trx , replicacion );
				tsh_ProductosListasDePreciosAplicadas.Update( data.Tables["tsh_ProductosListasDePreciosAplicadas"], trx , replicacion );
				/* Linea q guarda en mz.erp.dataaccess.tpu_ProveedoresProductos una nueva relacion Proveedores-Productos */
				mz.erp.dataaccess.tpu_ProveedoresProductos.Update( data.Tables["tpu_ProveedoresProductos"], trx);
				/* */
				//Sabrina: tarea 56
				tsh_ProductosCoeficientesAplicados.Update(data.tsh_ProductosCoeficientesAplicados, trx);
                
                //Sabrina: Tarea 1067. 20110311
                tsh_CombosDet.Update(data.Tables["tsh_CombosDet"], trx, replicacion);
                tsh_CombosDetListasDePrecios.Update(data.Tables["tsh_CombosDetListasDePrecios"], trx, replicacion);
                //Fin Sabrina: Tarea 1067. 20110311

                //Sabrina: Tarea 1110. 20110805
                tpu_ProveedoresProductosAuxiliares.Update(data.Tables["tpu_ProveedoresProductosAuxiliares"], trx,replicacion);
                //Fin Sabrina: Tarea 1110. 20110805

				if(!(replicacion.IdTipoDeSentencia == null || replicacion.IdTipoDeSentencia.Equals(string.Empty)))
				{
					replicacion.Update();
					mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
				}

				trx.Commit();
			}
			catch (Exception e )
			{
				trx.Rollback();
				throw e;
			}
			finally
			{
				cnx.Close();
			}
		}

		public static void Update(tsh_ProductosExDataset dataProductos ,tsh_ConversionesExDataset dataConversiones ,SentenciasReplicacion replicacion )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				mz.erp.dataaccess.tsh_ConversionesEx.Replicacion = replicacion;
				mz.erp.dataaccess.tsh_ConversionesEx.Update(dataConversiones,trx);
				Merge(dataProductos, dataConversiones );
				tsh_Productos.Update( dataProductos.Tables["tsh_Productos"], trx , replicacion );
				tsh_ProductosSucursales.Update( dataProductos.Tables["tsh_ProductosSucursales"],trx , replicacion  );
				replicacion.Update();
				mz.erp.dataaccess.sy_SentenciasReplicacion.Update(replicacion.Data.sy_SentenciasReplicacion, trx);
				Console.WriteLine(replicacion.Sentence);
				trx.Commit();
			}
			catch (Exception e )
			{
				trx.Rollback();
				throw e;
			}
			finally
			{
				cnx.Close();
			}
		}

		private static void Merge(tsh_ProductosExDataset dataProductos ,tsh_ConversionesExDataset dataConversiones)
		{
			bool valid = dataProductos.Tables["tsh_Productos"].Rows.Count > 0;
			bool otherValid = dataConversiones.Tables["tsh_conversiones"].Rows.Count > 0;
			if(valid && otherValid)
			{
				dataProductos.Tables["tsh_Productos"].Rows[0]["IdConversion"] = dataConversiones.Tables["tsh_conversiones"].Rows[0]["IdConversion"];
			}
		}

		/*public static System.Data.DataTable SearchProductByJerarquia(string Jerarquia,long IdSucursal,long IdEmpresa, bool Activo)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
		
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}*/
		public static System.Data.DataTable SearchProductosSinMovimientos(string Descripcion, string DescripcionCorta, string DescripcionLarga, string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa, string IdMonedaReferencia, /*string IdFuenteDeCambio,*/ string IdCondicionDeVentaVisualizacion, DateTime FechaDesde, DateTime FechaHasta, string TiposDeComprobantes)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchSinMovimientos", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if(Descripcion == null || Descripcion.Equals(string.Empty))
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
						

			cmd.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar ) );
			if(DescripcionCorta == null || DescripcionCorta.Equals(string.Empty))
				cmd.Parameters[ "@DescripcionCorta" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@DescripcionCorta" ].Value = DescripcionCorta;

			cmd.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar ) );
			if(DescripcionLarga == null || DescripcionLarga.Equals(string.Empty))
				cmd.Parameters[ "@DescripcionLarga" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@DescripcionLarga" ].Value = DescripcionLarga;
			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			if (Jerarquia1 == "") {	cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			if (Jerarquia2 == "") {	cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			if (Jerarquia3 == "") {	cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			if (Jerarquia4 == "") {	cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			if (Jerarquia5 == "") {	cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			if (Jerarquia6 == "") {	cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			if (Jerarquia7 == "") {	cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			if (Jerarquia8 == "") {	cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;}


			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaReferencia;
			//cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			//cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaVisualizacion", SqlDbType.VarChar ) );
			if(IdCondicionDeVentaVisualizacion != null && !IdCondicionDeVentaVisualizacion.Equals(string.Empty))
				cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = IdCondicionDeVentaVisualizacion;
			else cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@FechaDesde", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaDesde" ].Value = FechaDesde;

			cmd.Parameters.Add( new SqlParameter( "@FechaHasta", SqlDbType.DateTime ) );
			cmd.Parameters[ "@FechaHasta" ].Value = FechaHasta;

			cmd.Parameters.Add( new SqlParameter( "@TiposDeComprobantes", SqlDbType.VarChar ) );
			if(!TiposDeComprobantes.Equals(string.Empty))
				cmd.Parameters[ "@TiposDeComprobantes" ].Value = TiposDeComprobantes;
			else cmd.Parameters[ "@TiposDeComprobantes" ].Value = System.DBNull.Value;

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}

		
		// ----> Pr_tsh_Productos_SearchGeneral

        //Cristian Tarea 935 20101130
        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        /* Silvina 20111226 - Tarea 0000241 */
        public static System.Data.DataTable SearchProductos(string Codigo, string CodigoSecundario, string codigoProveedor, string Descripcion, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5, string CampoAuxiliar6, bool Activo, string IdMonedaReferencia, string IdFuenteDeCambio, string IdCondicionDeVentaVisualizacion, string Jerarquia1, string Jerarquia2, string Jerarquia3, string Jerarquia4, string Jerarquia5, string Jerarquia6, string Jerarquia7, string Jerarquia8, long IdSucursal, long IdEmpresa, string IdListaDePrecio, string IdTipoProducto, string IdResponsableCreacion, DateTime FechaAltaDesde, DateTime FechaAltaHasta, bool PermiteProductosCombo, bool PermiteCambio, string Separador)
        /* Fin Silvina 20111226 - Tarea 0000241 */
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
        //Cristian Tarea 935 20101130

		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchGeneral", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") 
			{
				cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;
			}
			else 
			{
				cmd.Parameters[ "@Codigo" ].Value = Codigo;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar ) );
			if (CodigoSecundario == "") 
			{
				cmd.Parameters[ "@CodigoSecundario" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@CodigoSecundario" ].Value = CodigoSecundario;
			}
            //Cristian Tarea 935
            cmd.Parameters.Add(new SqlParameter("@CodigoProveedor", SqlDbType.VarChar));
            if (codigoProveedor == "")
            {
                cmd.Parameters["@CodigoProveedor"].Value = System.DBNull.Value;
            }
            else
            {
                cmd.Parameters["@CodigoProveedor"].Value = codigoProveedor;
            }	
            //Fin Tarea 935
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Descripcion" ].Value = Descripcion;			

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar ) );
			if(CampoAuxiliar1 == null || CampoAuxiliar1.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar1" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar1" ].Value = CampoAuxiliar1;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar ) );
			if(CampoAuxiliar2 == null || CampoAuxiliar2.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar2" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar2" ].Value = CampoAuxiliar2;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar ) );
			if(CampoAuxiliar3 == null || CampoAuxiliar3.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar3" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar3" ].Value = CampoAuxiliar3;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar ) );
			if(CampoAuxiliar4 == null || CampoAuxiliar4.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar4" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar4" ].Value = CampoAuxiliar4;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar ) );
			if(CampoAuxiliar5 == null || CampoAuxiliar5.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar5" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar5" ].Value = CampoAuxiliar5;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar ) );
			if(CampoAuxiliar6 == null || CampoAuxiliar6.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar6" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar6" ].Value = CampoAuxiliar6;	
		
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			
		
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaReferencia;
			cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaVisualizacion", SqlDbType.VarChar ) );
			if(IdCondicionDeVentaVisualizacion != null && !IdCondicionDeVentaVisualizacion.Equals(string.Empty))
				cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = IdCondicionDeVentaVisualizacion;
			else cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			if (Jerarquia1 == "") {	cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			if (Jerarquia2 == "") {	cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			if (Jerarquia3 == "") {	cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			if (Jerarquia4 == "") {	cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			if (Jerarquia5 == "") {	cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			if (Jerarquia6 == "") {	cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			if (Jerarquia7 == "") {	cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			if (Jerarquia8 == "") {	cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;}


			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar ) );
			if(IdListaDePrecio.Equals(string.Empty))
				cmd.Parameters[ "@IdListaDePrecio" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdListaDePrecio" ].Value = IdListaDePrecio;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
			if (IdTipoProducto == "") 
			{
				cmd.Parameters[ "@IdTipoProducto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;
			}

			cmd.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar ) );
			if(IdResponsableCreacion.Equals(string.Empty))
				cmd.Parameters[ "@IdResponsableCreacion" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdResponsableCreacion" ].Value = IdResponsableCreacion;

			cmd.Parameters.Add( new SqlParameter( "@FechaAltaDesde", SqlDbType.DateTime ));
			if (FechaAltaDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaAltaDesde"].Value = System  .DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaAltaDesde.Year, FechaAltaDesde.Month, FechaAltaDesde.Day, 0, 0, 0, 0);
				cmd.Parameters[ "@FechaAltaDesde"].Value = d;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaAltaHasta", SqlDbType.DateTime ));
			if (FechaAltaHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaAltaHasta"].Value = System.DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaAltaHasta.Year, FechaAltaHasta.Month, FechaAltaHasta.Day, 23, 59, 59, 0);
				cmd.Parameters[ "@FechaAltaHasta"].Value = d;
			}

            //Sabrina: Tarea 1080. 20110326
            cmd.Parameters.Add(new SqlParameter("@PermiteProductosCombo", SqlDbType.Bit));
            if (Activo)
            {
                cmd.Parameters["@PermiteProductosCombo"].Value = PermiteProductosCombo;
            }
            else
            {
                cmd.Parameters["@PermiteProductosCombo"].Value = System.DBNull.Value;
            }
            //Fin Sabrina: Tarea 1080. 20110326

            /* Silvina 20110704 - Tarea 0000136 */
            cmd.Parameters.Add(new SqlParameter("@PermiteCambio", SqlDbType.Bit));
            cmd.Parameters["@PermiteCambio"].Value = PermiteCambio; 
            /* Fin Silvina 20110704 - Tarea 0000136 */

            /* Silvina 20111226 - Tarea 0000241 */
            cmd.Parameters.Add(new SqlParameter("@Separador", SqlDbType.Char));
            cmd.Parameters["@Separador"].Value = Separador; 
            /* Fin Silvina 20111226 - Tarea 0000241 */

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}
        //Fin Tarea 935
		
		// ----> Pr_tsh_Productos_SearchGeneralEx
		public static System.Data.DataTable SearchProductos(string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, bool ByActivo, string IdTipoProducto, string Observaciones, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5,  string CampoAuxiliar6, string IdBonificacion, bool ObligaCodigoBarra, bool ByObligaCodigoBarra, bool ObligaNumeroSerie, bool ByObligaNumeroSerie, bool PercibeIB, bool ByPercibeIB, string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal, long IdEmpresa, string IdMonedaReferencia, string IdFuenteDeCambio, string IdCondicionDeVentaVisualizacion, string IdResponsableCreacion, DateTime FechaAltaDesde, DateTime FechaAltaHasta)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchGeneralEx", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			
			cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
			if (IdTipoProducto == "") 
			{
				cmd.Parameters[ "@IdTipoProducto" ].Value = System.DBNull.Value;
			}
			else 
			{
				cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;
			}

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") 
			{
				cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;
			}
			else 
			{
				cmd.Parameters[ "@Codigo" ].Value = Codigo;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar ) );
			if (CodigoSecundario == "") 
			{
				cmd.Parameters[ "@CodigoSecundario" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@CodigoSecundario" ].Value = CodigoSecundario;
			}				
				
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if(Descripcion == null || Descripcion.Equals(string.Empty))
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
						

			cmd.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar ) );
			if(DescripcionCorta == null || DescripcionCorta.Equals(string.Empty))
				cmd.Parameters[ "@DescripcionCorta" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@DescripcionCorta" ].Value = DescripcionCorta;

			cmd.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar ) );
			if(DescripcionLarga == null || DescripcionLarga.Equals(string.Empty))
				cmd.Parameters[ "@DescripcionLarga" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@DescripcionLarga" ].Value = DescripcionLarga;
			
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			if(ByActivo)
                cmd.Parameters[ "@Activo" ].Value = Activo;
			else
				cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar ) );
			if(Observaciones == null || Observaciones.Equals(string.Empty))
				cmd.Parameters[ "@Observaciones" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@Observaciones" ].Value = Observaciones;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar ) );
			if(CampoAuxiliar1 == null || CampoAuxiliar1.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar1" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar1" ].Value = CampoAuxiliar1;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar ) );
			if(CampoAuxiliar2 == null || CampoAuxiliar2.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar2" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar2" ].Value = CampoAuxiliar2;	
		
			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar ) );
			if(CampoAuxiliar3 == null || CampoAuxiliar3.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar3" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar3" ].Value = CampoAuxiliar3;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar ) );
			if(CampoAuxiliar4 == null || CampoAuxiliar4.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar4" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar4" ].Value = CampoAuxiliar4;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar ) );
			if(CampoAuxiliar5 == null || CampoAuxiliar5.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar5" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar5" ].Value = CampoAuxiliar5;	

			cmd.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar ) );
			if(IdBonificacion == null || IdBonificacion.Equals(string.Empty))
				cmd.Parameters[ "@IdBonificacion" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@IdBonificacion" ].Value = IdBonificacion;	

			cmd.Parameters.Add( new SqlParameter( "@ObligaCodigoBarra", SqlDbType.Bit ) );
			if(ByObligaCodigoBarra)
				cmd.Parameters[ "@ObligaCodigoBarra" ].Value = ObligaCodigoBarra;
			else
				cmd.Parameters[ "@ObligaCodigoBarra" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@ObligaNumeroSerie", SqlDbType.Bit ) );
			if(ByObligaNumeroSerie)
				cmd.Parameters[ "@ObligaNumeroSerie" ].Value = ObligaNumeroSerie;
			else
				cmd.Parameters[ "@ObligaNumeroSerie" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@PercibeIB", SqlDbType.Bit ) );
			if(ByPercibeIB)
				cmd.Parameters[ "@PercibeIB" ].Value = PercibeIB;
			else
				cmd.Parameters[ "@PercibeIB" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			if (Jerarquia1 == "") {	cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			if (Jerarquia2 == "") {	cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			if (Jerarquia3 == "") {	cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			if (Jerarquia4 == "") {	cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			if (Jerarquia5 == "") {	cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			if (Jerarquia6 == "") {	cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			if (Jerarquia7 == "") {	cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			if (Jerarquia8 == "") {	cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;}


			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaReferencia;
			cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaVisualizacion", SqlDbType.VarChar ) );
			if(IdCondicionDeVentaVisualizacion != null && !IdCondicionDeVentaVisualizacion.Equals(string.Empty))
				cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = IdCondicionDeVentaVisualizacion;
			else cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar ) );
			if(IdResponsableCreacion.Equals(string.Empty))
				cmd.Parameters[ "@IdResponsableCreacion" ].Value =System.DBNull.Value;
			else
				cmd.Parameters[ "@IdResponsableCreacion" ].Value = IdResponsableCreacion;

			cmd.Parameters.Add( new SqlParameter( "@FechaAltaDesde", SqlDbType.DateTime ));
			if (FechaAltaDesde.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaAltaDesde"].Value = System.DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaAltaDesde.Year, FechaAltaDesde.Month, FechaAltaDesde.Day, 0, 0, 0, 0);
				cmd.Parameters[ "@FechaAltaDesde"].Value = d;
			}

			cmd.Parameters.Add( new SqlParameter( "@FechaAltaHasta", SqlDbType.DateTime ));
			if (FechaAltaHasta.Equals(DateTime.MinValue))
				cmd.Parameters[ "@FechaAltaHasta"].Value = System.DBNull.Value;
			else
			{
				DateTime d = new DateTime(FechaAltaHasta.Year, FechaAltaHasta.Month, FechaAltaHasta.Day, 23, 59, 59, 0);
				cmd.Parameters[ "@FechaAltaHasta"].Value = d;
			}

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}

        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        /* Silvina 20111226 - Tarea 0000241 */
        public static System.Data.DataTable SearchProductosCompras(string Codigo, string CodigoSecundario, string Descripcion, string CampoAuxiliar1, string CampoAuxiliar2, string CampoAuxiliar3, string CampoAuxiliar4, string CampoAuxiliar5, string CampoAuxiliar6, bool Activo, string IdMonedaReferencia, string IdFuenteDeCambio, string IdCondicionDeVentaVisualizacion, string Jerarquia1, string Jerarquia2, string Jerarquia3, string Jerarquia4, string Jerarquia5, string Jerarquia6, string Jerarquia7, string Jerarquia8, long IdSucursal, long IdEmpresa, string IdListaDePrecio, string TipoDePrecioDeCosto, string IdProveedor, string IdTipoProducto, bool PermiteProductosCombo, bool PermiteCambio, string Separador)
        /* Fin Silvina 20111226 - Tarea 0000241 */
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SerachCompras", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			if (Codigo == "") 
			{
				cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;
			}
			else 
			{
				cmd.Parameters[ "@Codigo" ].Value = Codigo;
			}
			
			cmd.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar ) );
			if (CodigoSecundario == "") 
			{
				cmd.Parameters[ "@CodigoSecundario" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@CodigoSecundario" ].Value = CodigoSecundario;
			}				
				
			cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
			if(Descripcion == null || Descripcion.Equals(string.Empty))
				cmd.Parameters[ "@Descripcion" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;			

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar ) );
			if(CampoAuxiliar1 == null || CampoAuxiliar1.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar1" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar1" ].Value = CampoAuxiliar1;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar ) );
			if(CampoAuxiliar2 == null || CampoAuxiliar2.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar2" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar2" ].Value = CampoAuxiliar2;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar ) );
			if(CampoAuxiliar3 == null || CampoAuxiliar3.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar3" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar3" ].Value = CampoAuxiliar3;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar ) );
			if(CampoAuxiliar4 == null || CampoAuxiliar4.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar4" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar4" ].Value = CampoAuxiliar4;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar ) );
			if(CampoAuxiliar5 == null || CampoAuxiliar5.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar5" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar5" ].Value = CampoAuxiliar5;	

			cmd.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar ) );
			if(CampoAuxiliar6 == null || CampoAuxiliar6.Equals(string.Empty))
				cmd.Parameters[ "@CampoAuxiliar6" ].Value = System.DBNull.Value;	
			else
				cmd.Parameters[ "@CampoAuxiliar6" ].Value = CampoAuxiliar6;	
		
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = Activo;
			
		
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaReferencia;
			cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;

			cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaVisualizacion", SqlDbType.VarChar ) );
			if(IdCondicionDeVentaVisualizacion != null && !IdCondicionDeVentaVisualizacion.Equals(string.Empty))
				cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = IdCondicionDeVentaVisualizacion;
			else cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = System.DBNull.Value;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			if (Jerarquia1 == "") {	cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			if (Jerarquia2 == "") {	cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			if (Jerarquia3 == "") {	cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			if (Jerarquia4 == "") {	cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			if (Jerarquia5 == "") {	cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			if (Jerarquia6 == "") {	cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			if (Jerarquia7 == "") {	cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			if (Jerarquia8 == "") {	cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;}


			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;

			cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar ) );
			if(IdListaDePrecio.Equals(string.Empty))
				cmd.Parameters[ "@IdListaDePrecio" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdListaDePrecio" ].Value = IdListaDePrecio;

			cmd.Parameters.Add( new SqlParameter( "@TipoDePrecioDeCosto", SqlDbType.VarChar ) );
			if(TipoDePrecioDeCosto.Equals(string.Empty))
				cmd.Parameters[ "@TipoDePrecioDeCosto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@TipoDePrecioDeCosto" ].Value = TipoDePrecioDeCosto;

			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			if(IdProveedor.Equals(string.Empty))
				cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

			cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
			if (IdTipoProducto == "") 
			{
				cmd.Parameters[ "@IdTipoProducto" ].Value = System.DBNull.Value;
			}
			else
			{
				cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;
			}

            //Sabrina: Tarea 1080. 20110326
            cmd.Parameters.Add(new SqlParameter("@PermiteProductosCombo", SqlDbType.Bit));
            if (Activo)
            {
                cmd.Parameters["@PermiteProductosCombo"].Value = PermiteProductosCombo;
            }
            else
            {
                cmd.Parameters["@PermiteProductosCombo"].Value = System.DBNull.Value;
            }
            //Fin Sabrina: Tarea 1080. 20110326

            /* Silvina 20110704 - Tarea 0000136 */
            cmd.Parameters.Add(new SqlParameter("@PermiteCambio", SqlDbType.Bit));
            cmd.Parameters["@PermiteCambio"].Value = PermiteCambio;
            /* Fin Silvina 20110704 - Tarea 0000136 */

            /* Silvina 20111226 - Tarea 0000241 */
            cmd.Parameters.Add(new SqlParameter("@Separador", SqlDbType.Char));
            cmd.Parameters["@Separador"].Value = Separador;
            /* Fin Silvina 20111226 - Tarea 0000241 */

			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}

		
		public static System.Data.DataTable SearchProductosConPreciosModificados(bool PorFechaUltimaModifPcioCosto, DateTime FechaUltimaModifPcioCostoDesde, DateTime FechaUltimaModifPcioCostoHasta, bool PorFechaUltimaModifPcioVenta, DateTime FechaUltimaModifPcioVentaDesde, DateTime FechaUltimaModifPcioVentaHasta, string IdListaDePrecio, string IdProducto, string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchProductosConPreciosModificados", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@PorFechaUltimaModifPcioCosto", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaUltimaModifPcioCosto" ].Value = PorFechaUltimaModifPcioCosto;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaUltimaModifPcioCostoDesde", SqlDbType.DateTime ) );
			if (FechaUltimaModifPcioCostoDesde.Equals(DateTime.MinValue)) 
				cmd.Parameters[ "@FechaUltimaModifPcioCostoDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaUltimaModifPcioCostoDesde" ].Value = FechaUltimaModifPcioCostoDesde;
				
			cmd.Parameters.Add( new SqlParameter( "@FechaUltimaModifPcioCostoHasta", SqlDbType.DateTime ) );
			if (FechaUltimaModifPcioCostoHasta.Equals(DateTime.MinValue)) 
				cmd.Parameters[ "@FechaUltimaModifPcioCostoHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaUltimaModifPcioCostoHasta" ].Value = FechaUltimaModifPcioCostoHasta;

			cmd.Parameters.Add( new SqlParameter( "@PorFechaUltimaModifPcioVenta", SqlDbType.Bit ) );
			cmd.Parameters[ "@PorFechaUltimaModifPcioVenta" ].Value = PorFechaUltimaModifPcioVenta;
			
			cmd.Parameters.Add( new SqlParameter( "@FechaUltimaModifPcioVentaDesde", SqlDbType.DateTime ) );
			if (FechaUltimaModifPcioVentaDesde.Equals(DateTime.MinValue)) 
				cmd.Parameters[ "@FechaUltimaModifPcioVentaDesde" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaUltimaModifPcioVentaDesde" ].Value = FechaUltimaModifPcioVentaDesde;
				
			cmd.Parameters.Add( new SqlParameter( "@FechaUltimaModifPcioVentaHasta", SqlDbType.DateTime ) );
			if (FechaUltimaModifPcioVentaHasta.Equals(DateTime.MinValue)) 
				cmd.Parameters[ "@FechaUltimaModifPcioVentaHasta" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@FechaUltimaModifPcioVentaHasta" ].Value = FechaUltimaModifPcioVentaHasta;

			cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecio", SqlDbType.VarChar ) );
			if(IdListaDePrecio.Equals(string.Empty))
				cmd.Parameters[ "@IdListaDePrecio" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdListaDePrecio" ].Value = IdListaDePrecio;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			if(IdProducto.Equals(string.Empty))
				cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
			else
				cmd.Parameters[ "@IdProducto" ].Value = IdProducto;

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			if (Jerarquia1 == "") {	cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			if (Jerarquia2 == "") {	cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			if (Jerarquia3 == "") {	cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			if (Jerarquia4 == "") {	cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			if (Jerarquia5 == "") {	cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;}

			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			if (Jerarquia6 == "") {	cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			if (Jerarquia7 == "") {	cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;}


			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			if (Jerarquia8 == "") {	cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;}
			else {cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;}


			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}


		public static tsh_ProductosDataset SearchProductByJerarquiaAux(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal,long IdEmpresa,bool activo)
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchProductosByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = activo;
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "tsh_productos" );
			adapter.Fill( data);
			return data;

		}


		public static System.Data.DataTable SearchProductByJerarquia(string Jerarquia,long IdSucursal,long IdEmpresa, string IdMonedaDestino, bool activo)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchByJerarquia", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia" ].Value = Jerarquia;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaDestino;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = activo;
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];
		}
		

		public static System.Data.DataTable SearchProductByJerarquia(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal,long IdEmpresa, string IdMonedaDestino, bool activo)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchByJerarquiaEx", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;			
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaDestino;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = activo;
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}
		public static System.Data.DataTable SearchProductByJerarquiaSinCodigo(string Jerarquia1,string Jerarquia2,string Jerarquia3,string Jerarquia4,string Jerarquia5,string Jerarquia6,string Jerarquia7,string Jerarquia8,long IdSucursal,long IdEmpresa, string IdMonedaDestino, bool activo)
		{
			System.Data.DataSet data = new System.Data.DataSet();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchByJerarquiaExSinCodigo", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia1" ].Value = Jerarquia1;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia2" ].Value = Jerarquia2;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia3" ].Value = Jerarquia3;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia4" ].Value = Jerarquia4;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia5" ].Value = Jerarquia5;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia6" ].Value = Jerarquia6;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia7" ].Value = Jerarquia7;
			cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Jerarquia8" ].Value = Jerarquia8;
			cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
			cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
			cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
			cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaDestino;
			cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
			cmd.Parameters[ "@Activo" ].Value = activo;
			
			SqlDataAdapter adapter = new SqlDataAdapter();
			adapter.SelectCommand = cmd;
			adapter.TableMappings.Add( "Table", "TableMov" );
			adapter.Fill( data);
			return data.Tables[0];

		}
		
	}
}
