namespace mz.erp.dataaccess 
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
    
	using mz.erp.dbhelper;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class tsh_Productos : IDisposable
	{
	
		#region Custom Members

         //Sabrina: Tarea 1068. 20110317
        public static tsh_ProductosDataset GetProductosEnCombo(string IdTransaction)
        {
            tsh_ProductosDataset data = new tsh_ProductosDataset(); 
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "tsh_Productos");

                SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
                SqlCommand cmd = new SqlCommand("Pr_tsh_Productos_GetProductosEnCombo", trx.Connection);
                cmd.Transaction = trx;
                cmd.CommandType = CommandType.StoredProcedure;

                adapter.SelectCommand = cmd;

                adapter.Fill(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return data;
        }
        //Fin Sabrina: Tarea 1068. 20110317

		public static tsh_ProductosDataset GetListByIdTipoProducto( string IdTipoProducto)	
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();
			return (tsh_ProductosDataset)GetListByIdTipoProducto( (DataSet)data, IdTipoProducto);
		}

		public static DataSet GetListByIdTipoProducto( DataSet data, string IdTipoProducto)	
		{
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tsh_Productos" );

				SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchByIdTipoProducto", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;		
	
				
		
				cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;

		
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
				
			return data;
		}

		public static string GetIdProductoByCodigoProveedorIdProveedor( string CodigoProveedor, string IdProveedor )
		{

			DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetIdProductoByCodigoProveedorIdProveedor", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@CodigoProveedor" ].Value = CodigoProveedor;
			
			cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;

			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Productos" );

			adapter.Fill( data );
			if(data.Tables.Count > 0)
				if(data.Tables[0].Rows.Count > 0)
					return Convert.ToString(data.Tables[0].Rows[0][0]);
			return null;

		}

        public static DataTable GetListIdProductoByCodigoProveedorIdProveedor(string CodigoProveedor, string IdProveedor)
        {

            DataSet data = new DataSet();
            SqlCommand cmd = new SqlCommand("Pr_tsh_Productos_GetIdProductoByCodigoProveedorIdProveedor", dbhelper.Connection.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@CodigoProveedor", SqlDbType.VarChar));
            cmd.Parameters["@CodigoProveedor"].Value = CodigoProveedor;

            cmd.Parameters.Add(new SqlParameter("@IdProveedor", SqlDbType.VarChar));
            cmd.Parameters["@IdProveedor"].Value = IdProveedor;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.TableMappings.Add("Table", "tsh_Productos");

            adapter.Fill(data);
            if (data.Tables.Count > 0)
                if (data.Tables[0].Rows.Count > 0)
                    return data.Tables[0];
            return null;

        }

		public static string GetIdProductoByCodigoProveedor( string CodigoProveedor )
		{

			DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetIdProductoByCodigoProveedor", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar ) );
			cmd.Parameters[ "@CodigoProveedor" ].Value = CodigoProveedor;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Productos" );

			adapter.Fill( data );
			if(data.Tables.Count > 0)
				if(data.Tables[0].Rows.Count > 0)
					return Convert.ToString(data.Tables[0].Rows[0][0]);
			return null;

		}

		
		public static string GetIdProductoByCodigoSecundario( string CodigoSecundario )
		{

			DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetIdProductoByCodigoSecundario", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar ) );
			cmd.Parameters[ "@CodigoSecundario" ].Value = CodigoSecundario;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Productos" );

			adapter.Fill( data );
			if(data.Tables.Count > 0)
				if(data.Tables[0].Rows.Count > 0)
					return Convert.ToString(data.Tables[0].Rows[0][0]);
			return null;

		}

		
		public static string GetIdProductoByCodigo( string Codigo )
		{

			DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetIdProductoByCodigo", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
			cmd.Parameters[ "@Codigo" ].Value = Codigo;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Productos" );

			adapter.Fill( data );
			if(data.Tables.Count > 0)
				if(data.Tables[0].Rows.Count > 0)
					return Convert.ToString(data.Tables[0].Rows[0][0]);
			return null;

		}
			


		public static void	UpdatePrecios(string IdTransaction, string IdCotizacion)
		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_UpdatePrecios", trx.Connection  );
			cmd.Transaction  = trx;
			cmd.CommandType = CommandType.StoredProcedure;
			cmd.Parameters.Add( new SqlParameter( "@IdCotizacion", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdCotizacion" ].Value = IdCotizacion;
			cmd.ExecuteNonQuery();
			
			
		}

		public static DataSet getPreciosDeCostoAnterior(string idProducto, string tiposDeComprobantes)
		{
			DataSet data = new DataSet();
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetPrecioCostoList", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = idProducto;

			cmd.Parameters.Add( new SqlParameter( "@IdTiposDeComprobantes", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdTiposDeComprobantes" ].Value = tiposDeComprobantes;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "Table" );

			adapter.Fill( data );

			return data;

		}	

		public static DataSet GetByPk( DataSet data, string IdProducto )
		{
			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Productos" );

			adapter.Fill( data );
			return data;

		}
        /* Silvina 20110704 - Tarea 0000136 */
		public static tsh_ProductosDataset GetListEx( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, long IdEmpresa, long IdSucursal, bool PermiteCambio )
        /* Fin Silvina 20110704 - Tarea 0000136 */
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tsh_Productos" );

				SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;			
		
				cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;
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
				cmd.Parameters[ "@CodigoSecundario" ].Value = CodigoSecundario;
				if (Descripcion == "") { Descripcion = null ; }
				if (DescripcionCorta == "") { DescripcionCorta = null;}
				if (DescripcionLarga == "") { DescripcionLarga = null;}
				cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
				cmd.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar ) );
				cmd.Parameters[ "@DescripcionCorta" ].Value = DescripcionCorta;
				cmd.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar ) );
				cmd.Parameters[ "@DescripcionLarga" ].Value = DescripcionLarga;
		
				cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
				if (Activo)
				{
					cmd.Parameters[ "@Activo" ].Value = Activo;
				}
				else
				{
					cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;
				}			
		
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
				if ( IdEmpresa == long.MinValue )
				{
					cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
				if ( IdSucursal == long.MinValue )
				{
					cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
				}
                /* Silvina 20110704 - Tarea 0000136 */
                cmd.Parameters.Add(new SqlParameter("@PermiteCambio", SqlDbType.Bit));
                cmd.Parameters["@PermiteCambio"].Value = PermiteCambio;
                /* Fin Silvina 20110704 - Tarea 0000136 */
				adapter.SelectCommand = cmd;
				adapter.Fill( data );
			}
			catch(Exception e)
			{
				;
			}
			return data;
		}


		private static SentenciasReplicacion _replication;



		#endregion
		
		public tsh_Productos()
		{
		}

		public static tsh_ProductosDataset GetList()
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();

			return ( tsh_ProductosDataset )GetList( data );
		}

		public static DataSet GetList( DataSet data )
		{
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tsh_Productos" );
			
				SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetList", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				adapter.SelectCommand = cmd;

				adapter.Fill( data );
         
				return data;
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
				return null;
			}
		}
        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        public static tsh_ProductosDataset GetListDataProductos(string IdTipoProducto, string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, long IdEmpresa, long IdSucursal, string IdMonedaReferencia, string IdFuenteDeCambio, bool PermiteProductosCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
			return (tsh_ProductosDataset)GetList( (DataSet)data, IdTipoProducto, Codigo, CodigoSecundario, CodigoProveedor, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia ,IdFuenteDeCambio, string.Empty, PermiteProductosCombo, PermiteCambio);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}


        //Sabrina: Tarea 1080. 20110326
		public static tsh_ProductosDataset GetListByMultipleCodigoSecundarioDataProductos( string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, long IdEmpresa, long IdSucursal, string IdMonedaReferencia , string IdFuenteDeCambio, bool PermiteProductosCombo)
        //Fin Sabrina: Tarea 1080. 20110326
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();
            //Sabrina: Tarea 1080. 20110326
            return (tsh_ProductosDataset)GetListByMultipleCodigoSecundario((DataSet)data, IdTipoProducto, Codigo, CodigoSecundario, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, string.Empty, PermiteProductosCombo);
            //Fin Sabrina: Tarea 1080. 20110326
		}



        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
        public static DataSet GetList(string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, long IdEmpresa, long IdSucursal, string IdMonedaReferencia, string IdFuenteDeCambio, string IdCondicionDeVentaVisualizacion, bool PermiteProductosCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{
			DataSet data = new DataSet();
            //Sabrina: Tarea 1080. 20110326
            /* Silvina 20110704 - Tarea 0000136 */
            return GetList(data, IdTipoProducto, Codigo, CodigoSecundario, null, Descripcion, DescripcionCorta, DescripcionLarga, Activo, IdEmpresa, IdSucursal, IdMonedaReferencia, IdFuenteDeCambio, IdCondicionDeVentaVisualizacion, PermiteProductosCombo, PermiteCambio);
            /* Fin Silvina 20110704 - Tarea 0000136 */
            //Fin Sabrina: Tarea 1080. 20110326
		}



            //Sabrina: Tarea 1080. 20110326			
			public static DataSet GetListByMultipleCodigoSecundario( DataSet data, string IdTipoProducto, string Codigo, string CodigoSecundario, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, long IdEmpresa, long IdSucursal, string IdMonedaReferencia, string IdFuenteDeCambio, string IdCondicionDeVentaVisualizacion, bool PermiteProducosCombo )
            //Fin Sabrina: Tarea 1080. 20110326
			{
				try
				{
					SqlDataAdapter adapter = new SqlDataAdapter();
					adapter.TableMappings.Add( "Table", "tsh_Productos" );

					SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_SearchByMultipleCodigoSecundario", dbhelper.Connection.GetConnection() );
					cmd.CommandType = CommandType.StoredProcedure;		
	
					cmd.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar ) );
					if (CodigoSecundario == "") 
					{
						cmd.Parameters[ "@CodigoSecundario" ].Value = System.DBNull.Value;
					}
					else
					{
						cmd.Parameters[ "@CodigoSecundario" ].Value = CodigoSecundario;
					}
				
				/*
		
					cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
					cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;

					cmd.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar ) );
					if (Codigo == "") 
					{
						cmd.Parameters[ "@Codigo" ].Value = System.DBNull.Value;
					}
					else 
					{
						cmd.Parameters[ "@Codigo" ].Value = Codigo;
					}
			
					
					cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
					cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
					cmd.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar ) );
					cmd.Parameters[ "@DescripcionCorta" ].Value = DescripcionCorta;
					cmd.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar ) );
					cmd.Parameters[ "@DescripcionLarga" ].Value = DescripcionLarga;
					
				*/
		
					cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
					if (Activo)
					{
						cmd.Parameters[ "@Activo" ].Value = Activo;
					}
					else
					{
						cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;
					}			
		
					cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
					if ( IdEmpresa == long.MinValue )
					{
						cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
					}
					else
					{
						cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
					}
					cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
					if ( IdSucursal == long.MinValue )
					{
						cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
					}
					else
					{
						cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
					}

                    //Sabrina: Tarea 1080. 20110326
                    cmd.Parameters.Add(new SqlParameter("@PermiteProductosCombo", SqlDbType.Bit));
                    if (Activo)
                    {
                        cmd.Parameters["@PermiteProductosCombo"].Value = Activo;
                    }
                    else
                    {
                        cmd.Parameters["@PermiteProductosCombo"].Value = System.DBNull.Value;
                    }
                    //Fin Sabrina: Tarea 1080. 20110326

					/*
					cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
					cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaReferencia;
					cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
					cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;

					cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaVisualizacion", SqlDbType.VarChar ) );
					if(IdCondicionDeVentaVisualizacion != null && !IdCondicionDeVentaVisualizacion.Equals(string.Empty))
						cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = IdCondicionDeVentaVisualizacion;
					else cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = System.DBNull.Value;
		
				*/
					adapter.SelectCommand = cmd;

					adapter.Fill( data );
				}
				catch(Exception e)
				{
					Console.WriteLine(e.Message);
				}
				
				return data;
			}

        //Sabrina: Tarea 1080. 20110326
        /* Silvina 20110704 - Tarea 0000136 */
         public static DataSet GetList(DataSet data, string IdTipoProducto, string Codigo, string CodigoSecundario, string CodigoProveedor, string Descripcion, string DescripcionCorta, string DescripcionLarga, bool Activo, long IdEmpresa, long IdSucursal, string IdMonedaReferencia, string IdFuenteDeCambio, string IdCondicionDeVentaVisualizacion, bool PermiteProductosCombo, bool PermiteCambio)
        /* Fin Silvina 20110704 - Tarea 0000136 */
        //Fin Sabrina: Tarea 1080. 20110326
		{
			try
			{
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "tsh_Productos" );

				SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_Search", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;			
		
				cmd.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdTipoProducto" ].Value = IdTipoProducto;

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

				cmd.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar ) );
				if (CodigoProveedor == "") 
				{
					cmd.Parameters[ "@CodigoProveedor" ].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters[ "@CodigoProveedor" ].Value = CodigoProveedor;
				}
				
				
				cmd.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar ) );
				cmd.Parameters[ "@Descripcion" ].Value = Descripcion;
				cmd.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar ) );
				cmd.Parameters[ "@DescripcionCorta" ].Value = DescripcionCorta;
				cmd.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar ) );
				cmd.Parameters[ "@DescripcionLarga" ].Value = DescripcionLarga;
		
				cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
				if (Activo)
				{
					cmd.Parameters[ "@Activo" ].Value = Activo;
				}
				else
				{
					cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;
				}			
		
				cmd.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt ) );
				if ( IdEmpresa == long.MinValue )
				{
					cmd.Parameters[ "@IdEmpresa" ].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters[ "@IdEmpresa" ].Value = IdEmpresa;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt ) );
				if ( IdSucursal == long.MinValue )
				{
					cmd.Parameters[ "@IdSucursal" ].Value = System.DBNull.Value;
				}
				else
				{
					cmd.Parameters[ "@IdSucursal" ].Value = IdSucursal;
				}
				cmd.Parameters.Add( new SqlParameter( "@IdMonedaDestino", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdMonedaDestino" ].Value = IdMonedaReferencia;
				cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambio", SqlDbType.VarChar ) );
				cmd.Parameters[ "@IdFuenteDeCambio" ].Value = IdFuenteDeCambio;

				cmd.Parameters.Add( new SqlParameter( "@IdCondicionDeVentaVisualizacion", SqlDbType.VarChar ) );
				if(IdCondicionDeVentaVisualizacion != null && !IdCondicionDeVentaVisualizacion.Equals(string.Empty))
					cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = IdCondicionDeVentaVisualizacion;
				else cmd.Parameters[ "@IdCondicionDeVentaVisualizacion" ].Value = System.DBNull.Value;

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
				adapter.SelectCommand = cmd;

				adapter.Fill( data );
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			return data;
		}


		public static tsh_ProductosDataset.tsh_ProductosRow NewRow()
		{
			
			return ( new tsh_ProductosDataset() ).tsh_Productos.Newtsh_ProductosRow();
		}
	
		public static tsh_ProductosDataset.tsh_ProductosRow GetByPk( string IdProducto )
		{
			tsh_ProductosDataset data = new tsh_ProductosDataset();

			SqlCommand cmd = new SqlCommand( "Pr_tsh_Productos_GetByPk", dbhelper.Connection.GetConnection()  );
			cmd.CommandType = CommandType.StoredProcedure;

			cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
			cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
			
			SqlDataAdapter adapter = new SqlDataAdapter( cmd );
			adapter.TableMappings.Add( "Table", "tsh_Productos" );

			adapter.Fill( data );

			if ( data.tsh_Productos.Rows.Count == 1 )
			{
				return ( tsh_ProductosDataset.tsh_ProductosRow )data.tsh_Productos.Rows[ 0 ];
			}
			
			return null;
		}
		
		public static void Update( tsh_ProductosDataset.tsh_ProductosRow row, string IdTransaction, SentenciasReplicacion sentencias )
		{
			if ( row.RowState == DataRowState.Detached )
			{
				( ( tsh_ProductosDataset.tsh_ProductosDataTable )row.Table ).Addtsh_ProductosRow( row );
			}
			
			Update( row.Table,  IdTransaction,sentencias );
		}

		public static void Update( tsh_ProductosDataset dataSet )
		{
			Update( (System.Data.DataTable)dataSet.tsh_Productos );
		}


		public static void Update( DataSet dataSet, string IdTransaction, SentenciasReplicacion replicacion )

		{
			SqlTransaction trx = PoolTransaction.GetTransactionById(IdTransaction);
			Update(dataSet.Tables["tsh_Productos"],trx, replicacion );
		}
		
		public static void Update( DataTable dataTable)
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );
			try
			{
				Update( ( tsh_ProductosDataset.tsh_ProductosDataTable )dataTable, trx );
				trx.Commit();
			}
			catch 
			{
				trx.Rollback();
			}
			finally
			{
				cnx.Close();
			}

		}
		public static void Update( DataTable dataTable, string IdTransaction, SentenciasReplicacion sentencias )
		{
			SqlTransaction trx = mz.erp.dataaccess.PoolTransaction.GetTransactionById(IdTransaction);
			Update( dataTable, trx, sentencias );
		}

		public static void Update( tsh_ProductosDataset.tsh_ProductosDataTable data, SqlTransaction trx )
		{
			SentenciasReplicacion replicacion = new SentenciasReplicacion();
			Update( ( DataTable )data, trx, replicacion );
		}


		public static void OnRowUpdated(object sender, SqlRowUpdatedEventArgs e)
		{
			try
			{
		
				StatementSQLForReplicationFactory.GetSqlStatement(e.Command, _replication.Sentence);
				if(_replication.IdTipoDeSentencia == null || _replication.IdTipoDeSentencia.Equals(string.Empty))
					_replication.IdTipoDeSentencia = e.StatementType.ToString().ToUpper();
			}
			catch(Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			
			
		}

				

		public static void Update( DataTable dataTable, SqlTransaction trx , SentenciasReplicacion replicacion )
		{
			SqlDataAdapter adapter = new SqlDataAdapter();
			
			
			adapter.TableMappings.AddRange(
				new System.Data.Common.DataTableMapping[] {
															  new System.Data.Common.DataTableMapping( "Table", "tsh_Productos", 
															  new System.Data.Common.DataColumnMapping[] {
																											 new System.Data.Common.DataColumnMapping( "IdProducto", "IdProducto" ),
																											 new System.Data.Common.DataColumnMapping( "IdTipoProducto", "IdTipoProducto" ),
																											 new System.Data.Common.DataColumnMapping( "Codigo", "Codigo" ),
																											 new System.Data.Common.DataColumnMapping( "CodigoSecundario", "CodigoSecundario" ),
																											 new System.Data.Common.DataColumnMapping( "Descripcion", "Descripcion" ),
																											 new System.Data.Common.DataColumnMapping( "DescripcionCorta", "DescripcionCorta" ),
																											 new System.Data.Common.DataColumnMapping( "DescripcionLarga", "DescripcionLarga" ),
																											 new System.Data.Common.DataColumnMapping( "UnidadesPedido", "UnidadesPedido" ),
																											 new System.Data.Common.DataColumnMapping( "MAC", "MAC" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCostoRef", "PrecioDeCostoRef" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeVentaNeto", "PrecioDeVentaNeto" ),
																											 new System.Data.Common.DataColumnMapping( "MaxDescuentoPorcentual", "MaxDescuentoPorcentual" ),
																											 new System.Data.Common.DataColumnMapping( "MaxDescuento", "MaxDescuento" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeVentaBruto", "PrecioDeVentaBruto" ),
																											 new System.Data.Common.DataColumnMapping( "ObligaCodigoBarra", "ObligaCodigoBarra" ),
																											 new System.Data.Common.DataColumnMapping( "ObligaNumeroSerie", "ObligaNumeroSerie" ),
																											 new System.Data.Common.DataColumnMapping( "IdCuentaImputacion", "IdCuentaImputacion" ),
																											 new System.Data.Common.DataColumnMapping( "FechaUltimaCompra", "FechaUltimaCompra" ),
																											 new System.Data.Common.DataColumnMapping( "Activo", "Activo" ),
																											 new System.Data.Common.DataColumnMapping( "FechaCreacion", "FechaCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionCreacion", "IdConexionCreacion" ),
																											 new System.Data.Common.DataColumnMapping( "UltimaModificacion", "UltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdConexionUltimaModificacion", "IdConexionUltimaModificacion" ),
																											 new System.Data.Common.DataColumnMapping( "IdReservado", "IdReservado" ),
																											 new System.Data.Common.DataColumnMapping( "RowId", "RowId" ),
																											 new System.Data.Common.DataColumnMapping( "IdEmpresa", "IdEmpresa" ),
																											 new System.Data.Common.DataColumnMapping( "IdSucursal", "IdSucursal" ),
																											 new System.Data.Common.DataColumnMapping( "IdBonificacion", "IdBonificacion" ),	
																											 new System.Data.Common.DataColumnMapping( "IdGenerado", "IdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "RowIdGenerado", "RowIdGenerado" ),
																											 new System.Data.Common.DataColumnMapping( "IdUnidad", "IdUnidad" ),
																											 new System.Data.Common.DataColumnMapping( "IdConversion", "IdConversion" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar1", "CampoAuxiliar1" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar2", "CampoAuxiliar2" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar3", "CampoAuxiliar3" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar4", "CampoAuxiliar4" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar5", "CampoAuxiliar5" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierrePrecioDeVentaBruto", "IdMonedaCierrePrecioDeVentaBruto" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierrePrecioDeVentaNeto", "IdMonedaCierrePrecioDeVentaNeto" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierrePrecioDeCostoRef", "IdMonedaCierrePrecioDeCostoRef" ),
																											 new System.Data.Common.DataColumnMapping( "IdMonedaCierreMaxDescuento", "IdMonedaCierreMaxDescuento" ),
																											 new System.Data.Common.DataColumnMapping( "IdCorizacionCierrePrecioDeVentaBruto", "IdCorizacionCierrePrecioDeVentaBruto" ),
																											 new System.Data.Common.DataColumnMapping( "IdCorizacionCierrePrecioDeVentaNeto", "IdCorizacionCierrePrecioDeVentaNeto" ),
																											 new System.Data.Common.DataColumnMapping( "IdCorizacionCierrePrecioDeCostoRef", "IdCorizacionCierrePrecioDeCostoRef" ),
																											 new System.Data.Common.DataColumnMapping( "IdCorizacionCierreMaxDescuento", "IdCorizacionCierreMaxDescuento" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCostoDirecto", "PrecioDeCostoDirecto" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCostoIndirecto", "PrecioDeCostoIndirecto" ),
																											 new System.Data.Common.DataColumnMapping( "Observaciones", "Observaciones" ),
																											 new System.Data.Common.DataColumnMapping( "PercibeIB", "PercibeIB" ),
															                                                 new System.Data.Common.DataColumnMapping( "IdProveedorDefault", "IdProveedorDefault" ),
																											 new System.Data.Common.DataColumnMapping( "CodigoProveedor", "CodigoProveedor" ),
																											 new System.Data.Common.DataColumnMapping( "FechaUltimaModificacionPrecioDeCosto", "FechaUltimaModificacionPrecioDeCosto" ),
																											 new System.Data.Common.DataColumnMapping( "FechaUltimaModificacionPrecioDeVenta", "FechaUltimaModificacionPrecioDeVenta" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCostoPromedioPonderado", "PrecioDeCostoPromedioPonderado" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeCostoReposicion", "PrecioDeCostoReposicion" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeVentaMercadoBolsa", "PrecioDeVentaMercadoBolsa" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeVentaMercadoCadena", "PrecioDeVentaMercadoCadena" ),
																											 new System.Data.Common.DataColumnMapping( "PrecioDeVentaMercadoCompetenciaDirecta", "PrecioDeVentaMercadoCompetenciaDirecta" ),
																											 new System.Data.Common.DataColumnMapping( "UsaPrecioDeCostoReposicion", "UsaPrecioDeCostoReposicion" ),
																											 new System.Data.Common.DataColumnMapping( "CampoAuxiliar6", "CampoAuxiliar6" ),
																											 new System.Data.Common.DataColumnMapping( "IdResponsableCreacion", "IdResponsableCreacion" )

																										 }
															  )
														  }
				);
			
			SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_Productos_Update", trx.Connection );
			sqlCommandUpdate.Transaction = trx;
			sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CodigoSecundario", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescripcionCorta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescripcionLarga", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UnidadesPedido", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UnidadesPedido", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MAC", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MAC", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoRef", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoRef", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MaxDescuentoPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MaxDescuentoPorcentual", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MaxDescuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MaxDescuento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaBruto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ObligaCodigoBarra", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ObligaCodigoBarra", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ObligaNumeroSerie", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ObligaNumeroSerie", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuentaImputacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaCompra", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaCompra", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUnidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUnidad", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConversion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConversion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar4", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierrePrecioDeVentaBruto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierrePrecioDeVentaBruto", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierrePrecioDeCostoRef", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierrePrecioDeCostoRef", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierrePrecioDeVentaNeto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierrePrecioDeVentaNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdMonedaCierreMaxDescuento", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierreMaxDescuento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PercibeIB", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PercibeIB", DataRowVersion.Current, null ) );
			//Cristian Tarea 953 20101124
            sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );			
			//Fin Tarea 953
            sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorDefault", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoProveedor", DataRowVersion.Current, null ) );
			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierrePrecioDeVentaBruto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierrePrecioDeVentaBruto", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierrePrecioDeCostoRef", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierrePrecioDeCostoRef", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierrePrecioDeVentaNeto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierrePrecioDeVentaNeto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCotizacionCierreMaxDescuento", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierreMaxDescuento", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoDirecto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCostoDirecto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoIndirecto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCostoIndirecto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeCosto", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null ) );
						
			//Sabrina: tarea 56
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoPromedioPonderado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoPromedioPonderado", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoReposicion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoReposicion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoBolsa", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoBolsa", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCadena", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCadena", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCompetenciaDirecta", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCompetenciaDirecta", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UsaPrecioDeCostoReposicion", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UsaPrecioDeCostoReposicion", DataRowVersion.Current, null ) );
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar6", DataRowVersion.Current, null ) );			
			sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsableCreacion", DataRowVersion.Current, null ) );
            
            //Sabrina: Tarea 1061. 20110310
            sqlCommandUpdate.Parameters.Add(new SqlParameter("@EsCombo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EsCombo", DataRowVersion.Current, null));
            //Fin Sabrina: Tarea 1061. 20110310

			SqlCommand sqlCommandDelete = new SqlCommand( "Pr_tsh_Productos_Delete", trx.Connection );
			sqlCommandDelete.Transaction = trx;
			sqlCommandDelete.CommandType = CommandType.StoredProcedure;
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Original, null ) );
			sqlCommandDelete.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Original, null ) );


			SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_Productos_Insert", trx.Connection );
			sqlCommandInsert.Transaction = trx;
			sqlCommandInsert.CommandType = CommandType.StoredProcedure;
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoSecundario", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescripcionCorta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescripcionLarga", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@UnidadesPedido", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UnidadesPedido", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MAC", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MAC", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoRef", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCostoRef", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeVentaNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MaxDescuentoPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MaxDescuentoPorcentual", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@MaxDescuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MaxDescuento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeVentaBruto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ObligaCodigoBarra", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ObligaCodigoBarra", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@ObligaNumeroSerie", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ObligaNumeroSerie", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaImputacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaCompra", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaUltimaCompra", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUnidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUnidad", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConversion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConversion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar4", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierrePrecioDeVentaBruto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierrePrecioDeVentaBruto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierrePrecioDeCostoRef", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierrePrecioDeCostoRef", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierrePrecioDeVentaNeto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierrePrecioDeVentaNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdMonedaCierreMaxDescuento", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdMonedaCierreMaxDescuento", DataRowVersion.Current, null ) );


			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierrePrecioDeVentaBruto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierrePrecioDeVentaBruto", DataRowVersion.Current, null ) );			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierrePrecioDeCostoRef", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierrePrecioDeCostoRef", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierrePrecioDeVentaNeto", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierrePrecioDeVentaNeto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCotizacionCierreMaxDescuento", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCotizacionCierreMaxDescuento", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoDirecto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCostoDirecto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoIndirecto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCostoIndirecto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PercibeIB", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PercibeIB", DataRowVersion.Current, null ) );
			//Cristian Tarea 953 20101124
            sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Observaciones", DataRowVersion.Current, null ) );			
			//Fin Tarea 953
            sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorDefault", DataRowVersion.Current, null ) );			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoProveedor", DataRowVersion.Current, null ) );			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeCosto", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null ) );

			//Sabrina: tarea 56
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoPromedioPonderado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoPromedioPonderado", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoReposicion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoReposicion", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoBolsa", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoBolsa", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCadena", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCadena", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCompetenciaDirecta", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCompetenciaDirecta", DataRowVersion.Current, null ) );
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@UsaPrecioDeCostoReposicion", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UsaPrecioDeCostoReposicion", DataRowVersion.Current, null ) );

			sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar6", DataRowVersion.Current, null ) );			
			sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdResponsableCreacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdResponsableCreacion", DataRowVersion.Current, null ) );
            //Sabrina: Tarea 1061. 20110310
            sqlCommandInsert.Parameters.Add(new SqlParameter("@EsCombo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EsCombo", DataRowVersion.Current, null));
            //Fin Sabrina: Tarea 1061. 20110310


			#region Replicacion

			_replication = replicacion;
			adapter.RowUpdated += new SqlRowUpdatedEventHandler(OnRowUpdated);

			#endregion

			
			adapter.UpdateCommand = sqlCommandUpdate;
			adapter.DeleteCommand = sqlCommandDelete;
			adapter.InsertCommand = sqlCommandInsert;
			adapter.RowUpdating +=new SqlRowUpdatingEventHandler(adapter_RowUpdating);
			adapter.Update ( dataTable );
			
		}
		
		public void Dispose()
		{
		}



		public static SqlCommand SqlCommandInsert
		{
			get
			{
				SqlCommand sqlCommandInsert = new SqlCommand("Pr_tsh_Productos_Insert");
				sqlCommandInsert.CommandType = CommandType.StoredProcedure;
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoSecundario", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescripcionCorta", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "DescripcionLarga", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@UnidadesPedido", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "UnidadesPedido", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@MAC", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MAC", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoRef", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeCostoRef", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeVentaNeto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@MaxDescuentoPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MaxDescuentoPorcentual", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@MaxDescuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "MaxDescuento", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "PrecioDeVentaBruto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@ObligaCodigoBarra", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ObligaCodigoBarra", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@ObligaNumeroSerie", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "ObligaNumeroSerie", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdCuentaImputacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaCompra", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaUltimaCompra", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaCreacion", SqlDbType.DateTime, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "FechaCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConexionCreacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConexionCreacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdGenerado", SqlDbType.VarChar, 20, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdGenerado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@RowIdGenerado", SqlDbType.UniqueIdentifier, 0, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "RowIdGenerado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdUnidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUnidad", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdConversion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConversion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar4", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
				//Cristian Tarea 953 20101124
                sqlCommandInsert.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
				//Fin tarea 953
                sqlCommandInsert.Parameters.Add( new SqlParameter( "@IdProveedorDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorDefault", DataRowVersion.Current, null ) );			
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoProveedor", DataRowVersion.Current, null ) );			
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeCosto", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null ) );

				//Sabrina: tarea 56
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoPromedioPonderado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoPromedioPonderado", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeCostoReposicion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoReposicion", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoBolsa", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoBolsa", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCadena", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCadena", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCompetenciaDirecta", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCompetenciaDirecta", DataRowVersion.Current, null ) );
				sqlCommandInsert.Parameters.Add( new SqlParameter( "@UsaPrecioDeCostoReposicion", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UsaPrecioDeCostoReposicion", DataRowVersion.Current, null ) );

				sqlCommandInsert.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar6", DataRowVersion.Current, null ) );

                //Sabrina: Tarea 1061. 20110310
                sqlCommandInsert.Parameters.Add(new SqlParameter("@EsCombo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EsCombo", DataRowVersion.Current, null));
                //Fin Sabrina: Tarea 1061. 20110310

				return sqlCommandInsert;
			}

		}

		public static SqlCommand SqlCommandUpdate
		{
			get
			{
				SqlCommand sqlCommandUpdate = new SqlCommand( "Pr_tsh_Productos_Update");
				
				sqlCommandUpdate.CommandType = CommandType.StoredProcedure;
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdProducto", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdTipoProducto", SqlDbType.VarChar, 1, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdTipoProducto", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Codigo", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Codigo", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoSecundario", SqlDbType.VarChar, 30, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "CodigoSecundario", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Descripcion", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Descripcion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescripcionCorta", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescripcionCorta", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@DescripcionLarga", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "DescripcionLarga", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UnidadesPedido", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UnidadesPedido", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MAC", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MAC", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoRef", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoRef", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaNeto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaNeto", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MaxDescuentoPorcentual", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MaxDescuentoPorcentual", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@MaxDescuento", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "MaxDescuento", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaBruto", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaBruto", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ObligaCodigoBarra", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ObligaCodigoBarra", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@ObligaNumeroSerie", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "ObligaNumeroSerie", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdCuentaImputacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdCuentaImputacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaCompra", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaCompra", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "Activo", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UltimaModificacion", SqlDbType.Timestamp, 8, ParameterDirection.InputOutput, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConexionUltimaModificacion", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdConexionUltimaModificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdReservado", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdReservado", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdEmpresa", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdEmpresa", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdSucursal", SqlDbType.BigInt, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdSucursal", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@OldIdProducto", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "IdProducto", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdBonificacion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "IdBonificacion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdUnidad", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdUnidad", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdConversion", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdConversion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar1", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar1", DataRowVersion.Current, null ) );			
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar2", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar2", DataRowVersion.Current, null ) );			
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar3", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar3", DataRowVersion.Current, null ) );			
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar4", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar4", DataRowVersion.Current, null ) );			
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar5", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );			
				//Cristian Tarea 953 20101124
                sqlCommandUpdate.Parameters.Add( new SqlParameter( "@Observaciones", SqlDbType.VarChar, 1000, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar5", DataRowVersion.Current, null ) );
				//fin Tarea 953
                sqlCommandUpdate.Parameters.Add( new SqlParameter( "@IdProveedorDefault", SqlDbType.VarChar, 20, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "IdProveedorDefault", DataRowVersion.Current, null ) );			
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CodigoProveedor", SqlDbType.VarChar, 50, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CodigoProveedor", DataRowVersion.Current, null ) );			
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeCosto", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeCosto", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@FechaUltimaModificacionPrecioDeVenta", SqlDbType.DateTime, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "FechaUltimaModificacionPrecioDeVenta", DataRowVersion.Current, null ) );
				
				//Sabrina: tarea 56
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoPromedioPonderado", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoPromedioPonderado", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeCostoReposicion", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeCostoReposicion", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoBolsa", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoBolsa", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCadena", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCadena", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@PrecioDeVentaMercadoCompetenciaDirecta", SqlDbType.Decimal, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "PrecioDeVentaMercadoCompetenciaDirecta", DataRowVersion.Current, null ) );
				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@UsaPrecioDeCostoReposicion", SqlDbType.Bit, 0, ParameterDirection.Input, false, ( ( System.Byte )( 0 )), ( ( System.Byte )( 0 ) ), "UsaPrecioDeCostoReposicion", DataRowVersion.Current, null ) );

				sqlCommandUpdate.Parameters.Add( new SqlParameter( "@CampoAuxiliar6", SqlDbType.VarChar, 256, ParameterDirection.Input, false, ( ( System.Byte )( 0 ) ), ( ( System.Byte )( 0 ) ), "CampoAuxiliar6", DataRowVersion.Current, null ) );

                //Sabrina: Tarea 1061. 20110310
                sqlCommandUpdate.Parameters.Add(new SqlParameter("@EsCombo", SqlDbType.Bit, 0, ParameterDirection.Input, false, ((System.Byte)(0)), ((System.Byte)(0)), "EsCombo", DataRowVersion.Current, null));
                //Fin Sabrina: Tarea 1061. 20110310
			
				return sqlCommandUpdate;
			}

		}

		private static void adapter_RowUpdating(object sender, SqlRowUpdatingEventArgs e)
		{			
			foreach(SqlParameter param in e.Command.Parameters)
			{
				if (param.ParameterName == "@FechaUltimaCompra") 
				{
					if ( e.Row["FechaUltimaCompra"].Equals(DateTime.MinValue))
					{
						e.Command.Parameters[ "@FechaUltimaCompra" ].Value = System.DBNull.Value;
					}
				}
			}
		}
	}
}

