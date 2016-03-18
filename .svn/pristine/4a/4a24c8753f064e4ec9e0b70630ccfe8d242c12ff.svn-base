namespace mz.erp.dbhelper
{
	using System;
	using System.Data;
	using System.Data.SqlClient;
	using mz.erp.systemframework;
	

	public class Connection
	{	
		public Connection()
		{
		}

		public static SqlConnection GetConnection()
		{			
			string connectionString;
			if (ApplicationConfiguration.ConnectionStringVisible == "") 
			{
				//connectionString = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64(ApplicationConfiguration.ConnectionString);
				connectionString = ApplicationConfiguration.ConnectionString;
				ApplicationConfiguration.ConnectionStringVisible = connectionString;
			}
			else connectionString = ApplicationConfiguration.ConnectionStringVisible;

			SqlConnection conect = new SqlConnection( connectionString );

			return conect;
			
		}

	}
}
