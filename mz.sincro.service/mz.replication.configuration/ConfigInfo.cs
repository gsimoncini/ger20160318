using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace mz.replication.configuration
{
	/// <summary>
	/// Encapsula toda la configuración del servicio.
	/// </summary>
	public class ConfigInfo
	{
		private string _ftpHost;
		private int _port = 21;
		private string _user;
		private string _password;
		private string _remoteInbox;
		private string _remoteOutbox;
		private string _remoteFileExtension;
		private long _remoteFileTimeSpan;

		private string _localInbox;
		private string _localOutbox;
		private string _localRetry;
		private string _localError;
		private string _terminalId;

		private long _dueTime;
		private long _period;
		
		private string _fileName;

		public ConfigInfo()
		{
		}

		public string FtpHost
		{
			get{ return _ftpHost; }
			set{ _ftpHost = value; }
		}

		public int Port
		{
			get{ return _port; }
			set{ _port = value; }
		}

		public string User
		{
			get{ return _user; }
			set{ _user = value; }
		}

		public string Password
		{
			get{ return _password; }
			set{ _password = value; }
		}

		public string RemoteInbox
		{
			get{ return _remoteInbox; }
			set{ _remoteInbox = value; }
		}

		public string RemoteOutbox
		{
			get{ return _remoteOutbox; }
			set{ _remoteOutbox = value; }
		}

		public string RemoteFileExtension
		{
			get{ return _remoteFileExtension; }
			set{ _remoteFileExtension = value; }
		}

		
		public long RemoteFileTimeSpan
		{
			get{ return _remoteFileTimeSpan; }
			set{ _remoteFileTimeSpan = value; }
		}

		public TimeSpan GetRemoteFileTimeSpan()
		{
			return TimeSpan.FromTicks( _remoteFileTimeSpan );
		}

		public void SetRemoteFileTimeSpan( TimeSpan timeSpan )
		{
			_remoteFileTimeSpan = timeSpan.Ticks;
		}

		public string LocalInbox
		{
			get{ return _localInbox; }
			set{ _localInbox = value; }
		}

		public string LocalOutbox
		{
			get{ return _localOutbox; }
			set{ _localOutbox = value; }
		}

		public string LocalRetry
		{
			get{ return _localRetry; }
			set{ _localRetry = value; }
		}

		public string LocalError
		{
			get{ return _localError; }
			set{ _localError = value; }
		}

		public string TerminalId
		{
			get{ return _terminalId; }
			set{ _terminalId = value; }
		}

		public long DueTime
		{
			get{ return _dueTime; }
			set{ _dueTime = value; }
		}

		public long Period
		{
			get{ return _period; }
			set{ _period = value; }
		}

		[XmlIgnore]
		public string FileName
		{
			get{ return _fileName; }
			set{ _fileName = value; }
		}

		/// <summary>
		/// Lee una clase desde un archivo XML
		/// </summary>
		/// <param name="fileName">
		/// Ruta y nombre del archivo que se leerá.
		/// </param>
		/// <returns>
		/// Una clase ServiceConfigInfo deserializada desde el archivo de origen.
		/// </returns>
		public static ConfigInfo Read( string fileName )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( ConfigInfo ) );

			FileStream fs = new FileStream( fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None );
			XmlReader reader = new XmlTextReader( fs );
          
			ConfigInfo configInfo = ( ConfigInfo )serializer.Deserialize( reader );
			reader.Close();
			configInfo.FileName = fileName;

			return configInfo;
		}

		/// <summary>
		/// Guarda el estado actual de la clase.
		/// </summary>
		/// <param name="fileName">
		/// Ruta y nombre de archivo dónde se almacenará la clase.
		/// </param>
		public void Save( string fileName )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( ConfigInfo ) );
			Stream fs = new FileStream( fileName, FileMode.Create );
			XmlWriter writer = new XmlTextWriter( fs, new UTF8Encoding() );
			serializer.Serialize( writer, this );
			writer.Close();
		}

		/// <summary>
		/// Guarda el estado actual de la clase en FileName.
		/// </summary>
		public void Save()
		{
			if ( FileName == string.Empty )
			{
				throw new Exception( "Se debe especificar un nombre de archivo." );
			}
			Save( FileName );
		}

	}
}
