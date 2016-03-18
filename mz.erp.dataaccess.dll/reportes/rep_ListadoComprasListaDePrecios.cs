using System;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoComprasListaDePrecios.
	/// </summary>
	public class rep_ListadoComprasListaDePrecios
	{
		public rep_ListadoComprasListaDePrecios()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
	/*	public static DataTable GetList(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_GetListaDePrecios", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@IdJerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia6" ].Value = IdJerarquia6;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@IdJerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia7" ].Value = IdJerarquia7;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@IdJerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia8" ].Value = IdJerarquia8;

				
				
			
				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data.Tables[0];
			}
			catch(Exception e){;return null;}

		}
*/
        /* Silvina 20101112 - Tarea 895 */
        public static DataTable GetList(string IdProducto, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4, string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string IdMonedaReferencia, string IdMonedaVisualizacion, string IdFuenteDeCambio)
		{
			return GetList(IdProducto, true, IdJerarquia1, IdJerarquia2, IdJerarquia3, IdJerarquia4, IdJerarquia5, IdJerarquia6, IdJerarquia7, IdJerarquia8, "", "", "", "", "", "", "", "", "", "", IdMonedaReferencia, IdMonedaVisualizacion,IdFuenteDeCambio, string.Empty);
		}
        /* Fin Silvina */

        /* Silvina 20101112 - Tarea 895 */
		public static DataTable GetList(string IdProducto, bool SoloProductosActivos, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8, string IdListaDePrecios1, string IdListaDePrecios2, string IdListaDePrecios3, string IdListaDePrecios4, string IdListaDePrecios5, string IdListaDePrecios6, string IdListaDePrecios7, string IdListaDePrecios8, string IdListaDePrecios9, string IdListaDePrecios10, string IdMonedaReferencia, string IdMonedaVisualizacion, string IdFuenteDeCambioVisualizacion, string Orden)
        /* Fin Silvina */
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_GetListaDePrecios", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				cmd.Parameters.Add( new SqlParameter( "@Activo", SqlDbType.Bit ) );
				if (SoloProductosActivos)
					cmd.Parameters[ "@Activo" ].Value = true;
				else
					cmd.Parameters[ "@Activo" ].Value = System.DBNull.Value;
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia1", SqlDbType.VarChar ) );
				if(IdJerarquia1=="")cmd.Parameters[ "@IdJerarquia1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia1" ].Value = IdJerarquia1;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia2", SqlDbType.VarChar ) );
				if(IdJerarquia2=="")cmd.Parameters[ "@IdJerarquia2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia2" ].Value = IdJerarquia2;

			
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia3", SqlDbType.VarChar ) );
				if(IdJerarquia3=="")cmd.Parameters[ "@IdJerarquia3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia3" ].Value = IdJerarquia3;
				
				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia4", SqlDbType.VarChar ) );
				if(IdJerarquia4=="")cmd.Parameters[ "@IdJerarquia4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia4" ].Value = IdJerarquia4;

				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia5", SqlDbType.VarChar ) );
				if(IdJerarquia5=="")cmd.Parameters[ "@IdJerarquia5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia5" ].Value = IdJerarquia5;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia6", SqlDbType.VarChar ) );
				if(IdJerarquia6=="")cmd.Parameters[ "@IdJerarquia6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia6" ].Value = IdJerarquia6;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia7", SqlDbType.VarChar ) );
				if(IdJerarquia7=="")cmd.Parameters[ "@IdJerarquia7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia7" ].Value = IdJerarquia7;


				cmd.Parameters.Add( new SqlParameter( "@IdJerarquia8", SqlDbType.VarChar ) );
				if(IdJerarquia8=="")cmd.Parameters[ "@IdJerarquia8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdJerarquia8" ].Value = IdJerarquia8;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios1", SqlDbType.VarChar ) );
				if(IdListaDePrecios1=="")cmd.Parameters[ "@IdListaDePrecios1" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios1" ].Value = IdListaDePrecios1;
				
				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios2", SqlDbType.VarChar ) );
				if(IdListaDePrecios2=="")cmd.Parameters[ "@IdListaDePrecios2" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios2" ].Value = IdListaDePrecios2;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios3", SqlDbType.VarChar ) );
				if(IdListaDePrecios3=="")cmd.Parameters[ "@IdListaDePrecios3" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios3" ].Value = IdListaDePrecios3;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios4", SqlDbType.VarChar ) );
				if(IdListaDePrecios4=="")cmd.Parameters[ "@IdListaDePrecios4" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios4" ].Value = IdListaDePrecios4;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios5", SqlDbType.VarChar ) );
				if(IdListaDePrecios5=="")cmd.Parameters[ "@IdListaDePrecios5" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios5" ].Value = IdListaDePrecios5;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios6", SqlDbType.VarChar ) );
				if(IdListaDePrecios6=="")cmd.Parameters[ "@IdListaDePrecios6" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios6" ].Value = IdListaDePrecios6;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios7", SqlDbType.VarChar ) );
				if(IdListaDePrecios7=="")cmd.Parameters[ "@IdListaDePrecios7" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios7" ].Value = IdListaDePrecios7;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios8", SqlDbType.VarChar ) );
				if(IdListaDePrecios8=="")cmd.Parameters[ "@IdListaDePrecios8" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios8" ].Value = IdListaDePrecios8;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios9", SqlDbType.VarChar ) );
				if(IdListaDePrecios9=="")cmd.Parameters[ "@IdListaDePrecios9" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios9" ].Value = IdListaDePrecios9;

				cmd.Parameters.Add( new SqlParameter( "@IdListaDePrecios10", SqlDbType.VarChar ) );
				if(IdListaDePrecios10=="")cmd.Parameters[ "@IdListaDePrecios10" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdListaDePrecios10" ].Value = IdListaDePrecios10;

				cmd.Parameters.Add( new SqlParameter( "@IdMonedaReferencia", SqlDbType.VarChar ) );
				if (IdMonedaReferencia =="") cmd.Parameters[ "@IdMonedaReferencia" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdMonedaReferencia" ].Value = IdMonedaReferencia;

				cmd.Parameters.Add( new SqlParameter( "@IdMonedaVisualizacion", SqlDbType.VarChar ) );
				if (IdMonedaVisualizacion =="") cmd.Parameters[ "@IdMonedaVisualizacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdMonedaVisualizacion" ].Value = IdMonedaVisualizacion;

				cmd.Parameters.Add( new SqlParameter( "@IdFuenteDeCambioVisualizacion", SqlDbType.VarChar ) );
				if (IdFuenteDeCambioVisualizacion =="") cmd.Parameters[ "@IdFuenteDeCambioVisualizacion" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdFuenteDeCambioVisualizacion" ].Value = IdFuenteDeCambioVisualizacion;
				
                /* Silvina 2001112 - Tarea 895 */
                cmd.Parameters.Add(new SqlParameter("@Orden", SqlDbType.VarChar));
                if (Orden.Equals(string.Empty))
                    cmd.Parameters["@Orden"].Value = System.DBNull.Value;
                else
                    cmd.Parameters["@Orden"].Value = Orden;
                /* Fin Silvina */

				SqlDataAdapter adapter = new SqlDataAdapter();
				adapter.TableMappings.Add( "Table", "Table" );
				adapter.SelectCommand = cmd;
				adapter.Fill( data);

				return data.Tables[0];
			}
			catch(Exception e){;return null;}

		}

	}
}
