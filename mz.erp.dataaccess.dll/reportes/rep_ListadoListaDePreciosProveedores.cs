using System;
using System.Data;
using System.Data.SqlClient;

namespace mz.erp.dataaccess.reportes
{
	/// <summary>
	/// Descripción breve de rep_ListadoListaDePreciosProveedores.
	/// </summary>
	public class rep_ListadoListaDePreciosProveedores
	{
		public rep_ListadoListaDePreciosProveedores()
		{
		}

		public static DataTable GetList(string IdProducto, string IdProveedor, string IdJerarquia1, string IdJerarquia2, string IdJerarquia3, string IdJerarquia4,string IdJerarquia5, string IdJerarquia6, string IdJerarquia7, string IdJerarquia8)
		{
			try
			{
				DataSet data = new DataSet();
				SqlCommand cmd = new SqlCommand( "Pr_tpu_GetListaDePreciosProveedores", dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add( new SqlParameter( "@IdProducto", SqlDbType.VarChar ) );
				if (IdProducto =="") cmd.Parameters[ "@IdProducto" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProducto" ].Value = IdProducto;
				
				cmd.Parameters.Add( new SqlParameter( "@IdProveedor", SqlDbType.VarChar ) );
				if (IdProveedor =="") cmd.Parameters[ "@IdProveedor" ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ "@IdProveedor" ].Value = IdProveedor;
				
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


	}
}
