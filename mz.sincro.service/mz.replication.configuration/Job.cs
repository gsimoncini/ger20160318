using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace mz.replication.configuration
{
	/// <summary>
	/// Provee un conjunto de configuraciones y elementos para realizar una sincronización de datos
	/// </summary>
	public class Job
	{
		private ArrayList _jobItems;
		private string _fileName = string.Empty;
		private string _createdBy = string.Empty;
		private DateTime _createdDateTime;

		/// <summary>
		/// Inicializa el estado de las variables locales.
		/// </summary>
		private void InitState()
		{
			_jobItems = new ArrayList();
			_createdDateTime = DateTime.Now;
			InitFileName();
		}

		/// <summary>
		/// Inicializa el nombre de archivo.
		/// </summary>
		private void InitFileName()
		{
			if ( _createdBy == string.Empty )
			{
				return;
			}

			_fileName = string.Format( "{0}_{1:yyyyMMddTHHmmss.fffffff}.zxml", _createdBy, _createdDateTime );
		}

		public Job()
		{
			InitState();
		}

		public Job( string fileName )
		{
			
			_fileName = fileName;
			InitState();
		}

		public string CreatedBy
		{
			get{ return _createdBy; }
			set
			{
				_createdBy = value;
				InitFileName();
			}
		}

		public DateTime CreatedDateTime
		{
			get{ return _createdDateTime; }
			set{ _createdDateTime = value; }
		}

		[XmlIgnore]
		public string FileName
		{
			get{ return _fileName; }
			set{ _fileName = value; }
		}

		public string GetBaseFileName()
		{
			return Path.GetFileName( _fileName );
		}

		public JobItem[] Items
		{
			get
			{
				_jobItems.Sort();

				return ( JobItem[] )_jobItems.ToArray( typeof( JobItem ) ); 
			}
			set
			{
				_jobItems.AddRange( value ); 
			}
		}

		/// <summary>
		/// Crea un SincronizationItem y lo agrega a SincronizationItems
		/// </summary>
		/// <param name="dateTime"></param>
		/// <param name="rowId"></param>
		/// <param name="body"></param>
		public void AddJobItem( DateTime dateTime, Guid rowId, string body )
		{
			JobItem i = new JobItem();
			i.DateTime = dateTime;
			i.RowId = rowId;
			i.Body = body;

			_jobItems.Add( i );
		}

		/// <summary>
		/// Lee una clase desde un archivo XML
		/// </summary>
		/// <param name="fileName">
		/// Ruta y nombre del archivo que se leerá.
		/// </param>
		/// <returns>
		/// Una clase SincronizationJob deserializada desde el archivo de origen.
		/// </returns>
		public static Job Read( string fileName )
		{
			return Read( new FileStream( fileName, FileMode.Open, FileAccess.Read, FileShare.Read ) );
		}

		public static Job Read( Stream stream )
		{
			stream.Position = 0;
			MemoryStream ms = new MemoryStream();
			ZipUtil.Decompress( stream, ms );

			ms.Position = 0;
			XmlSerializer serializer = new XmlSerializer( typeof( Job ) );
			XmlReader reader = new XmlTextReader( ms );
          
			Job j = ( Job )serializer.Deserialize( reader );
			reader.Close();

			j.FileName = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";

			return j;
		}

		public static Job Read( byte[] bytes )
		{
			MemoryStream ms = new MemoryStream();
			ms.Write( bytes, 0, bytes.Length );

			return Read( ms );
		}

		/// <summary>
		/// Guarda el estado actual de la clase.
		/// </summary>
		/// <param name="fileName">
		/// Ruta y nombre de archivo dónde se almacenará la clase.
		/// </param>
		public void Save( string fileName )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( Job ) );

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

		public void Save( Stream s )
		{
			XmlSerializer serializer = new XmlSerializer( typeof( Job ) );

			XmlWriter writer = new XmlTextWriter( s, new UTF8Encoding() );
			serializer.Serialize( writer, this );
		}

		public byte[] ToArray()
		{
			MemoryStream m = new MemoryStream();
			Save( m );
			return m.ToArray();
		}

		public void SaveToZip( string fileName )
		{
			SaveToZip( new FileStream( fileName, FileMode.Create ) );
		}


		public Stream SaveToZip( Stream stream )
		{
			Stream ms = new MemoryStream();

			Save( ms );

			if ( ZipUtil.Compress( ms, stream ) )
			{
				return stream;
			}
			
			return null;

		}

		public void SaveToZip()
		{
			Stream ms = new MemoryStream();

			Save( ms );

			ZipUtil.Compress( ms, new FileStream( FileName, FileMode.Create ) );
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
