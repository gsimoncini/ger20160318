using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using mz.erp.dbhelper;
using mz.erp.systemframework;
using mz.erp.commontypes.data;
using mz.erp.commontypes;
using System.Collections;


namespace mz.erp.dataaccess
{

	/// <summary>
	/// Descripción breve de tsh_ListasDePreciosEx.
	/// </summary>
	public class tsh_ListasDePreciosEx
	{
		public tsh_ListasDePreciosEx()
		{
		}

		public static void Update(tsh_ListasDePreciosExDataset data )
		{
			SqlConnection cnx = dbhelper.Connection.GetConnection();;
			cnx.Open();

			SqlTransaction trx = cnx.BeginTransaction( IsolationLevel.Serializable );

			try
			{
				mz.erp.dataaccess.tsh_ListasDePrecios.Update( data.tsh_ListasDePrecios, trx );
				mz.erp.dataaccess.tsh_ProductosListasDePrecios.Update(data.tsh_ProductosListasDePrecios,trx);

				trx.Commit();
			}
			catch(Exception e)
			{
				trx.Rollback();
				//Debug.WriteLine(e.Message);
			}
			finally
			{
				cnx.Close();
			}
		}
		}
}
