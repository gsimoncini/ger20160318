using System;
using System.IO;
using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.Collections;

namespace mz.erp.systemframework
{
	/// <summary>
	/// Descripción breve de ReportConfig.
	/// </summary>
	public class ReportConfig
	{
		public ReportConfig()
		{
			
				InitState();
		}
		private ArrayList _parametersSQL;
		private string _fileName = string.Empty;
		private ArrayList _parametersReport;


		private DateTime _createdDateTime;
		private string _SQL;
		private string _SQLType;

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
			_createdDateTime = DateTime.Now;

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

		
		public void AddParameterItemReport( ReportParameterConfig rpc )
		{
			
			_parametersReport.Add( rpc );
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

		public ReportParameterConfig[] ParametersReport
		{
			get
			{
				_parametersReport.Sort();

				return ( ReportParameterConfig[] )_parametersReport.ToArray( typeof( ReportParameterConfig ) ); 
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

			//Ver si hay que hav¡cer un casa por los distintos tipos de datos
			foreach(ReportParameterConfig param in this._parametersSQL)
			{
				if(param.ValorPorDefecto.ToLower() != "null")
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
