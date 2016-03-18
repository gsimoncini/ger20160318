namespace mz.erp.systemframework
{
	using System;
	using System.Configuration;
	using System.Diagnostics;
	using System.IO;
	using System.Text;
	using System.Threading;
    
	public class ApplicationLog 
	{

		private static TraceSwitch debugSwitch;
		private static StreamWriter debugWriter;
		private static TraceLevel eventLogTraceLevel;

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
        
				bool clearSettings = true;
				try 
				{
					if ( ApplicationConfiguration.TracingEnabled ) 
					{
						String tracingFile = ApplicationConfiguration.TracingTraceFile;
						if ( tracingFile != String.Empty ) 
						{
							String switchName = ApplicationConfiguration.TracingSwitchName;
        
							if ( switchName != String.Empty ) 
							{
								FileInfo file = new FileInfo( tracingFile );
								debugWriter = new StreamWriter( file.Open( FileMode.Append, FileAccess.Write, FileShare.ReadWrite ) );
								Debug.Listeners.Add( new TextWriterTraceListener( debugWriter ) );
            
								debugSwitch = new TraceSwitch( switchName, ApplicationConfiguration.TracingSwitchDescription );
								debugSwitch.Level = ApplicationConfiguration.TracingTraceLevel;
							}
							clearSettings = false;
						}						
					}
				}
				catch 
				{
				}
            
				if ( clearSettings ) 
				{
					debugSwitch = null;
					debugWriter = null;
				}

				if ( ApplicationConfiguration.EventLogEnabled )
					eventLogTraceLevel = ApplicationConfiguration.EventLogTraceLevel;
				else 
					eventLogTraceLevel = TraceLevel.Off;
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

							strBuilder.Append( new string( '*', 80 ) ).Append( "\r\n" ).Append( DateTime.Now.ToString( "s", null ) ).Append( "\r\n" ).Append( messageText ).Append( "\r\n" );

							Debug.WriteLine( strBuilder.ToString() );
							debugWriter.Flush();
						}
					}
				}
        
				if ( level <= eventLogTraceLevel ) 
				{
					EventLogEntryType LogEntryType;

					switch ( level ) 
					{
						case TraceLevel.Error:
							LogEntryType = EventLogEntryType.Error;
							break;

						case TraceLevel.Warning:
							LogEntryType = EventLogEntryType.Warning;
							break;

						case TraceLevel.Info:
							LogEntryType = EventLogEntryType.Information;
							break;

						case TraceLevel.Verbose:
							LogEntryType = EventLogEntryType.SuccessAudit;
							break;

						default:
							LogEntryType = EventLogEntryType.SuccessAudit;
							break;
					}
        
					EventLog eventLog = new EventLog( "Aplicación", ApplicationConfiguration.EventLogMachineName, ApplicationConfiguration.EventLogSourceName );
					eventLog.WriteEntry( messageText, LogEntryType );
				}
			}
			catch {}
		}
        
	
	}
}
