using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

using mz.erp.dbhelper;


namespace mz.erp.businessrules.reportes
{
	/// <summary>	/// Descripción breve de ReportConfig.
	/// </summary>
	public class ReportConfig
	{
		
		private static string _stroredProcedureOperation = "StoredProcedure";
		public static string StoredProcedureOperation
		{	
			get{return _stroredProcedureOperation;}
		}
		
		private static string _selectOperation = "Select";
		public static string SelectOperation
		{	
			get{return _selectOperation;}
		}	

		public ReportConfig()
		{
			
			InitState();
		}
		private ArrayList _parametersSQL;
		private string _fileName = string.Empty;
		private ArrayList _parametersReport;


		private DateTime _createdDateTime;
		private string _SQL;//propiedades
		private string _SQLType;

		public DataTable GetDataTable()
		{
			if ( this.SQLType == StoredProcedureOperation)
	
				return RunStoreProcedure( this.SQL, new ArrayList(this.ParametersSQL));
		
			else if ( this.SQLType == SelectOperation )
			
				return RunSql( this.SQL );
			else return null;
		}
		
		private static void  GetSqlParameterColleciton(SqlCommand cmd,ArrayList parameters)
		{
			
			foreach (ReportParameterConfig rpc in parameters)
			{
				cmd.Parameters.Add( new SqlParameter( rpc.Nombre, mz.erp.systemframework.Util.GetSqlBbType(rpc.TipoDeDato ) ));
				if(rpc.VariableSistema)
					cmd.Parameters[ rpc.Nombre ].Value = Variables.GetValueString(Convert.ToString(rpc.ValorPorDefecto));
				else
				if((rpc.ValorPorDefecto.Equals("null")) || (rpc.ValorPorDefecto.Equals("")))
					cmd.Parameters[ rpc.Nombre ].Value = System.DBNull.Value;
				else
					cmd.Parameters[ rpc.Nombre ].Value = GetValueForType(rpc.ValorPorDefecto, rpc.TipoDeDato);
			}

			
		}


		public static object GetValueForType(object value, string type)
		{

			if(type.Equals("DateTime"))
			{
				DateTime date = Convert.ToDateTime(value);
				if(date.Equals(DateTime.MinValue))
					return System.DBNull.Value;
				else return date;
			}
			else return value;
		}

		
	
		public static DataTable RunStoreProcedure( string storeProcedureName, ArrayList parameters)
		{

			try
			{
				System.Data.DataSet data = new DataSet();
				SqlDataAdapter adapter = new SqlDataAdapter();
						

				SqlCommand cmd = new SqlCommand( storeProcedureName, dbhelper.Connection.GetConnection() );
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.CommandTimeout = 180;
				GetSqlParameterColleciton(cmd,parameters);
			
				adapter.SelectCommand = cmd;
				adapter.Fill( data,"Table" );
			         
				return data.Tables[0];
			}
			catch(Exception e)
			{return null;}
			

			
		}

		public static DataTable RunSql( string sqlText )
		{
			return null;
		}
		
		



		public string SQLType
		{
			get{return _SQLType;}
			set{_SQLType = value;}
		}

		public string SQL
		{
			get{return _SQL;}
			set{_SQL = value;}
		}



		private void InitState()
		{
			_parametersSQL = new ArrayList();
			_parametersReport = new ArrayList();
			_createdDateTime = mz.erp.businessrules.Sistema.DateTime.Now;

		}

		
		public DateTime CreatedDateTime
		{
			get{ return _createdDateTime; }
			set{ _createdDateTime = value; }
		}

		public void AddParameterItemSQL( ReportParameterConfig rpc )
		{
			
			_parametersSQL.Add( rpc );
		}

		
		public void AddParameterItemReport( ReportParameter rp )
		{
			
			_parametersReport.Add( rp );
		}

		[XmlIgnore]
		public string FileName
		{
			get{ return _fileName; }
			set{ _fileName = value; }
		}

		public ReportParameterConfig[] ParametersSQL
		{
			get
			{
				_parametersSQL.Sort();

				return ( ReportParameterConfig[] )_parametersSQL.ToArray( typeof( ReportParameterConfig ) ); 
			}
			set
			{
				_parametersSQL.AddRange( value ); 
			}
		}

		public ReportParameter[] ParametersReport
		{
			get
			{
				 _parametersReport.Sort();
				
				return ( ReportParameter[] )_parametersReport.ToArray( typeof( ReportParameter ) ); 
			}
			set
			{
				_parametersReport.AddRange( value ); 
			}
		}

		public static ReportConfig Read(string fileName)
		{
			return Read( new FileStream( fileName, FileMode.Open, FileAccess.Read, FileShare.Read ) );
		}

		public static ReportConfig Read( Stream stream )
		{
			stream.Position = 0;

			XmlSerializer serializer = new XmlSerializer( typeof( ReportConfig ) );
			XmlReader reader = new XmlTextReader( stream );
          
			ReportConfig j = ( ReportConfig )serializer.Deserialize( reader );
			reader.Close();

			//j.FileName = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

			return j;
		}
		public static ReportConfig Read( byte[] bytes )
		{
			MemoryStream ms = new MemoryStream();
			ms.Write( bytes, 0, bytes.Length );

			return Read( ms );
		}

		public void Save(string fileName)
		{
			XmlSerializer serializer = new XmlSerializer( typeof( ReportConfig ) );

			Stream fs = new FileStream( fileName, FileMode.Create, FileAccess.Write, FileShare.None );
			XmlWriter writer = new XmlTextWriter( fs, new UTF8Encoding() );
			try
			{
				serializer.Serialize( writer, this );
			}
			catch( Exception ex )
			{
				throw ex;
			}
			finally
			{
				writer.Close();
				fs.Close();
			}
			
		}

		public string Format()
		{

			//Ver si hay que hacer un case por los distintos tipos de datos
			foreach(ReportParameterConfig param in this._parametersSQL)
			{
				if(!param.ValorPorDefecto.Equals("null"))
				{
					string aux = this.SQL.Replace("["+param.Nombre+"]","'{0}'");
					this.SQL =String.Format(@aux, param.ValorPorDefecto);
				}
				else
				{
					string aux = this.SQL.Replace("["+param.Nombre+"]","{0}");
					this.SQL =String.Format(@aux, param.ValorPorDefecto);
				}
			}
			return this.SQL;



		}



	}
}
