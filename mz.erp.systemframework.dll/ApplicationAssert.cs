namespace mz.erp.systemframework
{
	using System;
	using System.Diagnostics;
	using System.IO;
	using System.Text;
    
	public class ApplicationAssert 
	{
#if !DEBUG
		public const int LineNumber = 0;
#else
		public static int LineNumber 
		{
			get 
			{
				try 
				{
					return ( new StackTrace( 1, true ) ).GetFrame( 0 ).GetFileLineNumber();
				}
				catch 
				{
				}

				return 0;
			}
		}
#endif
        
		[ConditionalAttribute("DEBUG")]
		public static void Check( bool condition, String errorText, int lineNumber ) 
		{
			if ( !condition ) 
			{
				String detailMessage = String.Empty;
				StringBuilder strBuilder;
				
				GenerateStackTrace( lineNumber, out detailMessage );
				
				strBuilder = new StringBuilder();
				strBuilder.Append( "ASSERT: " ).Append( "\r\n" ).Append( errorText ).Append( "\r\n" ).Append( detailMessage );
			
				ApplicationLog.WriteWarning( strBuilder.ToString() );
				
				Debug.Fail( errorText, detailMessage );
			}
		}
        

		public static void CheckCondition( bool condition, String errorText, int lineNumber ) 
		{
			if ( !condition ) 
			{
				String detailMessage = string.Empty;
				GenerateStackTrace( lineNumber, out detailMessage );
				
				StringBuilder strBuilder = new StringBuilder();
				strBuilder.Append( "ERROR: " ).Append( "\r\n" ).Append( errorText ).Append( "\r\n" ).Append( detailMessage );

				ApplicationLog.WriteError( strBuilder.ToString() );

				Debug.Fail( errorText, detailMessage );
        
				throw new ApplicationException( errorText );
            
			}
		}
        

		//[ConditionalAttribute("DEBUG")]
		private static void GenerateStackTrace( int lineNumber, out String currentTrace ) 
		{
			currentTrace = String.Empty;
            
#if DEBUG
			StringBuilder message;
			String        fileName;
			int           currentLine;
			String        sourceLine;
			StreamReader  fileStream = null;
			bool          openedFile = false;
			StackTrace    curTrace;
			StackFrame    curFrame;
             
			message = new StringBuilder();
            
			try 
			{
				curTrace = new StackTrace( 2, true );
				try 
				{        
					curFrame = curTrace.GetFrame( 0 );
        
					if ( ( String.Empty != ( fileName = curFrame.GetFileName() ) ) && 
						( 0 <= ( currentLine = ( lineNumber != 0 ) ? lineNumber : curFrame.GetFileLineNumber() ) ) ) 
					{
						message.Append( fileName ).Append( ", Línea: " ).Append( currentLine );
            
						fileStream = new StreamReader( fileName );
						openedFile = true;
						do 
						{
							sourceLine = fileStream.ReadLine();
							--currentLine;
						} while ( currentLine != 0 );
        
						message.Append( "\r\n" );
                        
						if ( lineNumber != 0 ) 
						{
							message.Append( "Línea actual: " );
						}
						else 
						{
							message.Append( "\r\n" ).Append( "Línea siguiente: " );
						}
                                
						message.Append( "\r\n" ).Append( sourceLine.Trim() );
					}
				}
				catch 
				{
				}
				finally 
				{
					if ( openedFile ) fileStream.Close();
				}
            
				currentTrace = message.ToString();
			}
			catch 
			{
			}
#endif
		}
    
	}
    
}
