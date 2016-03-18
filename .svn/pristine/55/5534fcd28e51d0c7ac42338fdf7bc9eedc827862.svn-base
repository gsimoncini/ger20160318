using System;
using System.Data.SqlClient;
using System.Collections;
using mz.erp.systemframework;

namespace mz.erp.dataaccess
{
	/// <summary>
	/// Descripción breve de PoolTransaction.
	/// </summary>
	public class PoolTransaction
	{
		public PoolTransaction()
		{
			
		}


		private static Hashtable _pool = new Hashtable();

		public static string BeginTransaction()
		{
			SqlConnection connection = mz.erp.dbhelper.Connection.GetConnection();
			connection.Open();
            
			//SqlTransaction sqltrx = connection.BeginTransaction(System.Data.IsolationLevel.Snapshot);
            SqlTransaction sqltrx = connection.BeginTransaction();
			
			string key = Util.NewStringId();
			_pool.Add(key,sqltrx);
			return key;
		}

		public static void Commit(string key)
		{
			
			SqlTransaction sqltrx = (SqlTransaction)_pool[key];
			SqlConnection connection = sqltrx.Connection;
			
			try
			{
				sqltrx.Commit();
				_pool.Remove(key);
			}

			catch(Exception e)
			{
				throw e;
			}
			finally
			{
				connection.Close();
			}

		} 
		
		public static void RollBack(string key)
		{
			SqlTransaction sqltrx = (SqlTransaction)_pool[key];
			SqlConnection connection = sqltrx.Connection;
			try
			{
				sqltrx.Rollback();
				
			}

			catch(Exception e)
			{
				throw e;
			}
			finally
			{
				connection.Close();
			}
		}

		public static SqlTransaction GetTransactionById(string key)
		{
			return (SqlTransaction)_pool[key];
		}
	}
}
