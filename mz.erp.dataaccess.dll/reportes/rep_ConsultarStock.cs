using System;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ConsultarStock.
	/// </summary>
	public class rep_ConsultarStock
	{
		public rep_ConsultarStock()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


        //Cristian Tarea 0000010 20110222
        public static DataTable GetListXEstadoDeStock(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string EstadosDeStock, bool SoloActivos, Boolean filtroStockMayor, Boolean filtroStockCero, Boolean filtroStockMenor,String IdDeposito, String IdSeccion)
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_StockPorEstadosDeStock", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia4" ].Value = IdJerarquia4;

				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia5" ].Value = IdJerarquia5;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia6" ].Value = IdJerarquia6;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia7" ].Value = IdJerarquia7;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia8" ].Value = IdJerarquia8;

				cmd.Parameters.Add( new SqlParameter( "@EstadosDeStock", SqlDbType.VarChar));
				if(EstadosDeStock =="")cmd.Parameters[ "@EstadosDeStock"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@EstadosDeStock"].Value = EstadosDeStock;


                //Matias 20100719 - Tarea 88
                cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit));
                cmd.Parameters["@Activo"].Value = SoloActivos;
                //Matias 20100719 - Tarea 88

                //Cristian  Tarea 0000010 20110222
                cmd.Parameters.Add(new SqlParameter("@filtroStockMayor", SqlDbType.Bit));
                cmd.Parameters["@filtroStockMayor"].Value = filtroStockMayor;

                cmd.Parameters.Add(new SqlParameter("@filtroStockCero", SqlDbType.Bit));
                cmd.Parameters["@filtroStockCero"].Value = filtroStockCero;

                cmd.Parameters.Add(new SqlParameter("@filtroStockMenor", SqlDbType.Bit));
                cmd.Parameters["@filtroStockMenor"].Value = filtroStockMenor;


                cmd.Parameters.Add(new SqlParameter("@idDeposito", SqlDbType.VarChar));

                if (IdDeposito == "") cmd.Parameters["@idDeposito"].Value = System.DBNull.Value;
                else cmd.Parameters["@idDeposito"].Value = IdDeposito;

                cmd.Parameters.Add(new SqlParameter("@idSeccion", SqlDbType.VarChar));

                if (IdSeccion == "") cmd.Parameters["@idSeccion"].Value = System.DBNull.Value;
                else cmd.Parameters["@idSeccion"].Value = IdSeccion;
                //Fin Cristian 			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data.Tables[0];
			}
			catch(Exception e){;return null;}	
		}
        //Fin Cristian 	
        //Cristian Tarea 0000010 20110222
        public static DataTable GetListXValorizacionDeStock(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string VisualizacionesDeStock, bool SoloActivos, Boolean filtroStockMayor, Boolean filtroStockCero,Boolean filtroStockMenor,String IdDeposito, String IdSeccion)
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tlg_Stock_StockPorVisualizacionesDeStock", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@Jerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@Jerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@Jerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@Jerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia4" ].Value = IdJerarquia4;

				
				cmd.Parameters.Add( new SqlParameter( "@Jerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@Jerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia5" ].Value = IdJerarquia5;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@Jerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia6" ].Value = IdJerarquia6;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@Jerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia7" ].Value = IdJerarquia7;

				cmd.Parameters.Add( new SqlParameter( "@Jerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@Jerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@Jerarquia8" ].Value = IdJerarquia8;

				cmd.Parameters.Add( new SqlParameter( "@VisualizacionesDeStock", SqlDbType.VarChar));
				if(VisualizacionesDeStock =="")cmd.Parameters[ "@VisualizacionesDeStock"].Value =  System.DBNull.Value;
				else
					cmd.Parameters[ "@VisualizacionesDeStock"].Value = VisualizacionesDeStock;


                //Matias 20100719 - Tarea 88
                cmd.Parameters.Add(new SqlParameter("@Activo", SqlDbType.Bit));
                cmd.Parameters["@Activo"].Value = SoloActivos;
                //Matias 20100719 - Tarea 88
                //Cristian  Tarea 0000010 20110222
                cmd.Parameters.Add(new SqlParameter("@filtroStockMayor", SqlDbType.Bit));
                cmd.Parameters["@filtroStockMayor"].Value = filtroStockMayor;

                cmd.Parameters.Add(new SqlParameter("@filtroStockCero", SqlDbType.Bit));
                cmd.Parameters["@filtroStockCero"].Value = filtroStockCero;

                cmd.Parameters.Add(new SqlParameter("@filtroStockMenor", SqlDbType.Bit));
                cmd.Parameters["@filtroStockMenor"].Value = filtroStockMenor;

                cmd.Parameters.Add(new SqlParameter("@idDeposito", SqlDbType.VarChar));
                if (IdDeposito == "") cmd.Parameters["@idDeposito"].Value = System.DBNull.Value;
                else cmd.Parameters["@idDeposito"].Value = IdDeposito;

                cmd.Parameters.Add(new SqlParameter("@idSeccion", SqlDbType.VarChar));

                if (IdSeccion == "") cmd.Parameters["@idSeccion"].Value = System.DBNull.Value;
                else cmd.Parameters["@idSeccion"].Value = IdSeccion;
                //Fin Cristian 			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data.Tables[0];
			}
			catch(Exception e){;return null;}	
		}
        //Fin Cristian
	}
}
