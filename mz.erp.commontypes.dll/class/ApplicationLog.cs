using System;

namespace  mz.erp.commontypes
{
	using System;
	using System.Configuration;
	using System.Diagnostics;
	using System.IO;
	using System.Text;
	using System.Threading;
    
	public class ApplicationLog 
	{
		private static StreamWriter debugWriter;
		private static TraceSwitch debugSwitch;

		static ApplicationLog() 
		{
			Type myType = typeof( ApplicationLog );
        
			try 
			{
				if ( !Monitor.TryEnter( myType ) ) 
				{
					Monitor.Enter( myType );
					return;
				}
        
				try 
				{
					String tracingFile = AppDomain.CurrentDomain.BaseDirectory + "mz.erp.log";
					if ( tracingFile != String.Empty ) 
					{
						FileInfo file = new FileInfo( tracingFile );
						debugWriter = new StreamWriter( file.Open( FileMode.Append, FileAccess.Write, FileShare.ReadWrite ) );
						
						String switchName = "mz.sincro.service";

						debugSwitch = new TraceSwitch( switchName, "Seguimiento del sistema MZ.ERP" );
						debugSwitch.Level = TraceLevel.Verbose;
					}
				}
				catch 
				{
				}
			}
			finally 
			{
				Monitor.Exit( myType );
			}
		}
    

		public static void WriteError( String message ) 
		{
			WriteLog( TraceLevel.Error, message );
		}
        

		public static void WriteWarning( String message ) 
		{
			WriteLog( TraceLevel.Warning, message );
		}
        

		public static void WriteInfo( String message ) 
		{
			WriteLog( TraceLevel.Info, message );
		}
        

		public static void WriteTrace( String message ) 
		{
			
			WriteLog( TraceLevel.Verbose, message );
		}
        

		public static String FormatException( Exception ex, String catchInfo ) 
		{
			StringBuilder strBuilder = new StringBuilder();

			if ( catchInfo != String.Empty ) 
			{
				strBuilder.Append( catchInfo ).Append( "\r\n" );
			}

			strBuilder.Append( ex.Message ).Append( "\r\n" ).Append( ex.StackTrace );

			return strBuilder.ToString();
		}
        

		private static void WriteLog( TraceLevel level, String messageText ) 
		{
			try 
			{
				if ( debugWriter != null ) 
				{
					if ( level <= debugSwitch.Level ) 
					{
						lock( debugWriter ) 
						{
							StringBuilder strBuilder = new StringBuilder();

							string pre = string.Empty;

							switch( level )
							{
								case TraceLevel.Error:
									pre = "ERR";
									break;
								
								case TraceLevel.Info:
									pre = "INF";
									break;

								case TraceLevel.Verbose:
									pre = "VER";
									break;

								case TraceLevel.Warning:
									pre = "WAR";
									break;
							}

							strBuilder.Append( DateTime.Now.ToString( "s", null ) ).Append( "\t" );
							strBuilder.Append( "[" + pre + "]" ).Append( "\t" );
							strBuilder.Append( messageText );

							System.Diagnostics.Debug.WriteLine( strBuilder.ToString() );

							debugWriter.WriteLine( strBuilder.ToString() );
							debugWriter.Flush();
						}
					}
				}
        
			}
			catch {}
		}
	}
}
