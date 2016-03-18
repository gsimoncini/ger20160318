using System;
using System.IO;
using Xceed.FileSystem;
using Xceed.Compression;
using Xceed.Compression.Formats;
using Xceed.Zip;

namespace mz.replication.configuration
{
	/// <summary>
	/// Provee métodos para comprimir y descomprimir.
	/// </summary>
	public class ZipUtil
	{
		static ZipUtil()
		{
			Xceed.Compression.Formats.Licenser.LicenseKey = "SCN10-DZM90-BZP84-WYBA";
			Xceed.Zip.Licenser.LicenseKey = "ZIN20-WWFF0-HN10H-KWCA";
		}

		public static bool Compress( Stream sourceStream, Stream destinationStream )
		{
			sourceStream.Position = 0;
			destinationStream.Position = 0;

			using( CompressedStream compStream = new CompressedStream( destinationStream, CompressionMethod.Deflated, CompressionLevel.Highest ) )
			{ 
				compStream.Transient = true;

				byte[] buffer = new byte[ 32768 ];

				int bytesRead = 0;

				while( ( bytesRead = sourceStream.Read( buffer, 0, buffer.Length  ) ) > 0 )
				{
					compStream.Write( buffer, 0, bytesRead );
				}
			}

			return true;
		}

		/// <summary>
		/// Comprime
		/// </summary>
		/// <param name="sourceFileName"></param>
		/// <param name="compressedFileName"></param>
		/// <returns></returns>
		public static bool Compress( string sourceFileName, string compressedFileName )
		{
			return Compress( new FileStream( sourceFileName, FileMode.Open ), new FileStream( compressedFileName, FileMode.Create ) );
		}

		/// <summary>
		/// Descomprime 
		/// </summary>
		/// <param name="sourceFileName"></param>
		/// <param name="decompressedFileName"></param>
		/// <returns></returns>
		public static bool Decompress( string sourceFileName, string decompressedFileName )
		{
			return Decompress( new FileStream( sourceFileName, FileMode.Open ), new FileStream( decompressedFileName, FileMode.Create ) );
		}


		public static bool Decompress( Stream sourceStream, Stream destinationStream )
		{
			using( CompressedStream compStream = new CompressedStream( sourceStream ) )
			{
				compStream.Transient = true;

				byte[] buffer = new byte[ 32768 ];

				int bytesRead = 0;

				while( ( bytesRead = compStream.Read( buffer, 0, buffer.Length  ) ) > 0 )
				{
					destinationStream.Write( buffer, 0, bytesRead );
				}
			}

			return true;
		}

		public static bool Decompress( byte[] source, Stream destination )
		{
			MemoryStream s = new MemoryStream();
			s.Write( source, 0, source.Length );
			s.Position = 0;

			return Decompress( s, destination );
		}

	}
}
