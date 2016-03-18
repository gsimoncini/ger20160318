namespace mz.erp.systemframework 
{
	using System;
	using System.Collections;
	using System.Diagnostics;
	using System.Configuration;
	using System.Data.SqlClient;
	using System.Xml;
	using System.Collections.Specialized;
	using System.Reflection;
	using System.IO;
using System.Text;
    
	public class ApplicationConfiguration
	{

		private const String TRACING_ENABLED = "SystemFramework.Tracing.Enabled";
		private const String TRACING_TRACEFILE = "SystemFramework.Tracing.TraceFile";
		private const String TRACING_TRACELEVEL = "SystemFramework.Tracing.TraceLevel";
		private const String TRACING_SWITCHNAME	= "SystemFramework.Tracing.SwitchName";
		private const String TRACING_SWITCHDESCRIPTION = "SystemFramework.Tracing.SwitchDescription";
		private const String EVENTLOG_ENABLED = "SystemFramework.EventLog.Enabled";
		private const String EVENTLOG_MACHINENAME = "SystemFramework.EventLog.Machine";
		private const String EVENTLOG_SOURCENAME = "SystemFramework.EventLog.SourceName";
		private const String EVENTLOG_TRACELEVEL = "SystemFramework.EventLog.LogLevel";
		private const string USERACCOUNT_SOURCE = "SystemFramework.UserAccount.Source";
		private const string CONNECTION_STRING = "SystemFramework.ConnectionString";
		private const string SUCURSAL = "SystemFramework.Sucursal";
		private const string PUESTO = "SystemFramework.Puesto";
		private const string EMPRESA = "SystemFramework.Empresa";

        
		private static bool tracingEnabled;
		private static string tracingTraceFile;
		private static TraceLevel tracingTraceLevel;
		private static string tracingSwitchName;
		private static string tracingSwitchDescription;
		private static bool eventLogEnabled;
		private static string eventLogMachineName;
		private static string eventLogSourceName;
		private static TraceLevel eventLogTraceLevel;
		private static string userAccountSource;
		private static string connectionString;
		private static string connectionStringVisible = "";
		private static string sucursal;
		private static string puesto;
		private static string empresa;

        
		private const bool TRACING_ENABLED_DEFAULT = true;
		private const String TRACING_TRACEFILE_DEFAULT = "ApplicationTrace.txt";
		private const TraceLevel TRACING_TRACELEVEL_DEFAULT	= TraceLevel.Verbose;
		private const String TRACING_SWITCHNAME_DEFAULT	= "ApplicationTraceSwitch";
		private const String TRACING_SWITCHDESCRIPTION_DEFAULT = "Application error and tracing information";
		private const bool EVENTLOG_ENABLED_DEFAULT	= true;
		private const String EVENTLOG_MACHINENAME_DEFAULT = ".";
		private const String EVENTLOG_SOURCENAME_DEFAULT = "WinFormsApplication";
		private const TraceLevel EVENTLOG_TRACELEVEL_DEFAULT = TraceLevel.Error;
		private const string USERACCOUNT_SOURCE_DEFAULT = "NONE";
		private const string CONNECTION_STRING_DEFAULT = "";
		private const string SUCURSAL_DEFAULT = "1";
		private const string PUESTO_DEFAULT = "1";
		private const string EMPRESA_DEFAULT = "1";


		private static string _configFileName = null;
		private static NameValueCollection _appSettingsCollection = null; 

		public static string ConfigFileName
		{
			get
			{
				// Initialize the config file path if not already
				if (_configFileName == null)
					_configFileName = GetCustomConfigFilePath();

				return _configFileName;
			} 
			set
			{
				// Get the appropriate configuration file path/name
				_configFileName = GetCustomConfigFilePath(value);
				
				// Reset the name value collection
				_appSettingsCollection = null;
			}
		}

		public static NameValueCollection AppSettings
		{
			get
			{
				// Load settings if they haven't already
				if (_appSettingsCollection == null)
					LoadAppSettings();

				return _appSettingsCollection;
			}
		}

		private static void LoadAppSettings()
		{

            // Load the document

		    XmlDocument configDoc = new XmlDocument();

			configDoc.Load(ConfigFileName);
        	// Get the node settings
			XmlNode node = configDoc.SelectSingleNode("/configuration/appSettings");
            //XmlNode nodeRuntime = configDoc.SelectSingleNode("/configuration/runtime");
            //XmlNode nodeAssemblybinding = nodeRuntime.FirstChild;
            //XmlNode nodeProbing = nodeAssemblybinding.FirstChild;
            //XmlAttribute oAtt = configDoc.CreateAttribute("privatePath");
            //oAtt.Value = "lib;bin\\Debug\\lib" ;
            //nodeProbing.Attributes.Append(oAtt);
            

			// Get reference to the NameValueCollection holding the parsed values
			NameValueSectionHandler handler = new NameValueSectionHandler();
			_appSettingsCollection = (NameValueCollection) handler.Create(null, null, node);
          
		}

        /* Configura los path para levantar las dll estaticas y dinamicas */
		private static string GetCustomConfigFilePath()
		{
            //Cristian Tarea 129 20110622
		    string fullPath = String.Empty;
            //Verifica si es el archivo de configuracion en modo DEBUG de la aplicacion
            //if (!AppDomain.CurrentDomain.FriendlyName.Contains("vshost"))
            //{
              //  fullPath = AppDomain.CurrentDomain.BaseDirectory + "Configuration\\" +
              //             AppDomain.CurrentDomain.FriendlyName + ".config";
            //}
            //else
            //{
                fullPath = Assembly.GetEntryAssembly().Location + ".config";
            //}
            //Fin Tarea 129
            //string fileName = "Path.txt";
            //StreamWriter writer = File.CreateText(fileName);

            //writer.WriteLine("PATH: "+ fullPath);
            //writer.Close();
			return GetCustomConfigFilePath(fullPath);
		}



		private static string GetCustomConfigFilePath(string customConfigFilename)
		{
			// Does the filename include path information? (i.e. if path information is provided, perform no searching)
			if (customConfigFilename.IndexOf(@"\") >= 0)
			{
				// Does it exist?
				if (!File.Exists(customConfigFilename))
					throw new FileNotFoundException(string.Format("Could not locate configuration file '{0}'.", customConfigFilename));

				// Do not perform searching, just return the configuration filename provided by the user
				return customConfigFilename;
			}
			else
			{
				// Get the full path and filename of the executing assembly (i.e. dll or exe path)
				string fullPath = Assembly.GetCallingAssembly().Location;
               
				// Get just the directory path
				string searchPath = Path.GetDirectoryName(fullPath);

#if !DEBUG
				// Build the expected physical config file location
				string configFileName = Path.Combine(searchPath, customConfigFilename);

				// Throw an exception if config file couldn't be found
				if (!File.Exists(configFileName))
					throw new FileNotFoundException(string.Format("Could not locate configuration file '{0}'.", customConfigFilename));

#else
				// DEBUG Implementation climbs folder structure to find config file in source folder (for easier development since VS doesn't copy DLL config files to bin folder automatically)
				string configFileName; 

				// Iterate up folder structure until we either find the file, or we don't
				do
				{
					// Build the potential physical config file location
					configFileName = Path.Combine(searchPath, customConfigFilename);
	
					// Does it exist here?
					if (File.Exists(configFileName))
						break;

					// Move to parent folder
					DirectoryInfo directory = Directory.GetParent(searchPath);
						
					if (directory == null)
					{
						searchPath = null;
					}
					else
					{
						searchPath = directory.FullName;
					}
				} while (searchPath != null);

				// Make sure that we didn't climb all the way up (and out) of the directory hierarchy
				if (searchPath == null)
				{
					throw new FileNotFoundException(string.Format("Could not locate configuration file '{0}'.", customConfigFilename));
				}
#endif

				return configFileName;
			}
		}

		static ApplicationConfiguration()
		{
    

            tracingEnabled = ReadSetting( TRACING_ENABLED, TRACING_ENABLED_DEFAULT );
			tracingTraceFile = ReadSetting( TRACING_TRACEFILE, TRACING_TRACEFILE_DEFAULT );
			tracingTraceLevel = ReadSetting( TRACING_TRACELEVEL, TRACING_TRACELEVEL_DEFAULT );
			tracingSwitchName = ReadSetting( TRACING_SWITCHNAME, TRACING_SWITCHNAME_DEFAULT );
			tracingSwitchDescription = ReadSetting( TRACING_SWITCHDESCRIPTION, TRACING_SWITCHDESCRIPTION_DEFAULT );
			eventLogEnabled = ReadSetting( EVENTLOG_ENABLED, EVENTLOG_ENABLED_DEFAULT );
			eventLogMachineName = ReadSetting( EVENTLOG_MACHINENAME, EVENTLOG_MACHINENAME_DEFAULT );
			eventLogSourceName = ReadSetting( EVENTLOG_SOURCENAME, EVENTLOG_SOURCENAME_DEFAULT );
			eventLogTraceLevel = ReadSetting( EVENTLOG_TRACELEVEL, EVENTLOG_TRACELEVEL_DEFAULT );
			userAccountSource = ReadSetting( USERACCOUNT_SOURCE, USERACCOUNT_SOURCE_DEFAULT );
			connectionString = ReadSetting( CONNECTION_STRING, CONNECTION_STRING_DEFAULT );
			sucursal = ReadSetting( SUCURSAL, SUCURSAL_DEFAULT );
			puesto = ReadSetting( PUESTO, PUESTO_DEFAULT );
			empresa = ReadSetting( EMPRESA, EMPRESA_DEFAULT );
		
		}

		#region Commented out
		/*
		public static void LoadSettings( AppSettingsReader appSettingsReader )
		{
			settings = appSettingsReader;

			if ( settings == null ) 
			{
				tracingEnabled = TRACING_ENABLED_DEFAULT;
				tracingTraceFile = TRACING_TRACEFILE_DEFAULT;
				tracingTraceLevel = TRACING_TRACELEVEL_DEFAULT;
				tracingSwitchName = TRACING_SWITCHNAME_DEFAULT;
				tracingSwitchDescription = TRACING_SWITCHDESCRIPTION_DEFAULT;
				eventLogEnabled = EVENTLOG_ENABLED_DEFAULT;
				eventLogMachineName = EVENTLOG_MACHINENAME_DEFAULT;
				eventLogSourceName = EVENTLOG_SOURCENAME_DEFAULT;
				eventLogTraceLevel = EVENTLOG_TRACELEVEL_DEFAULT;
				userAccountSource = USERACCOUNT_SOURCE_DEFAULT;
			}
			else 
			{
				tracingEnabled = ReadSetting( TRACING_ENABLED, TRACING_ENABLED_DEFAULT );
				tracingTraceFile = ReadSetting( TRACING_TRACEFILE, TRACING_TRACEFILE_DEFAULT );
				tracingTraceLevel = ReadSetting( TRACING_TRACELEVEL, TRACING_TRACELEVEL_DEFAULT );
				tracingSwitchName = ReadSetting( TRACING_SWITCHNAME, TRACING_SWITCHNAME_DEFAULT );
				tracingSwitchDescription = ReadSetting( TRACING_SWITCHDESCRIPTION, TRACING_SWITCHDESCRIPTION_DEFAULT );
				eventLogEnabled = ReadSetting( EVENTLOG_ENABLED, EVENTLOG_ENABLED_DEFAULT );
				eventLogMachineName = ReadSetting( EVENTLOG_MACHINENAME, EVENTLOG_MACHINENAME_DEFAULT );
				eventLogSourceName = ReadSetting( EVENTLOG_SOURCENAME, EVENTLOG_SOURCENAME_DEFAULT );
				eventLogTraceLevel = ReadSetting( EVENTLOG_TRACELEVEL, EVENTLOG_TRACELEVEL_DEFAULT );
				userAccountSource = ReadSetting( USERACCOUNT_SOURCE, USERACCOUNT_SOURCE_DEFAULT );
			}

		}
		*/
		#endregion

		public static String ReadSetting( String key, String defaultValue ) 
		{
			try 
			{
				object setting = AppSettings[ key ];
                
				return ( setting == null ) ? defaultValue : ( string )setting;
			}
			catch(Exception e) 
			{
				//Debug.WriteLine(e.Message);
				return defaultValue;
			}
		}
        

		public static bool ReadSetting( String key, bool defaultValue ) 
		{
			try 
			{
				object setting = AppSettings[ key ];
                
				return ( setting == null ) ? defaultValue : Convert.ToBoolean( ( string )setting );
			}
			catch 
			{
				return defaultValue;
			}
		}
        

		public static int ReadSetting( String key, int defaultValue ) 
		{
			try 
			{
				object setting = AppSettings[ key ];
                
				return ( setting == null ) ? defaultValue : Convert.ToInt32( ( string )setting );
			}
			catch 
			{
				return defaultValue;
			}
		}

        
		public static TraceLevel ReadSetting( String key, TraceLevel defaultValue ) 
		{
			try 
			{
				object setting = AppSettings[ key ];
                
				return ( setting == null ) ? defaultValue : ( TraceLevel )Convert.ToInt32( ( string )setting );
			}
			catch 
			{
				return defaultValue;
			}
		}
        
		public static bool TracingEnabled 
		{
			get 
			{ 
				return tracingEnabled; 
			}
		}
        
		public static String TracingTraceFile 
		{
			get 
			{ 
				
				return tracingTraceFile; 
			}
		}
        
		public static TraceLevel TracingTraceLevel 
		{
			get 
			{ 
				return tracingTraceLevel; 
			}
		}
        
		public static String TracingSwitchName 
		{
			get 
			{ 
				return tracingSwitchName; 
			}
		}
        
		public static String TracingSwitchDescription 
		{
			get 
			{ 
				return tracingSwitchDescription; 
			}
		}
        
		public static bool EventLogEnabled 
		{
			get 
			{ 
				return eventLogEnabled; 
			}
		}

		public static String EventLogMachineName 
		{
			get 
			{ 
				return eventLogMachineName; 
			}
		}
        
		public static String EventLogSourceName 
		{
			get 
			{ 
				return eventLogSourceName; 
			}
		}
		public static string ConnectionString
		{
			get
			{
				return connectionString;
			}
			set 
			{
				connectionString = value;
			}
		}
		public static string ConnectionStringVisible
		{
			get
			{
				return connectionStringVisible;
			}
			set  
			{
				connectionStringVisible = value;
			}
		}

		public static TraceLevel EventLogTraceLevel 
		{
			get 
			{
				return eventLogTraceLevel; 
			}
		}

		public static string UserAccountSource 
		{
			get 
			{ 
				return userAccountSource; 
			}
		}

		public static string Sucursal
		{
			get
			{
				return sucursal;
			}
		}

		public static string Puesto
		{
			get
			{
				return puesto;
			}
		}

		public static string Empresa
		{
			get
			{
				return empresa;
			}
		}
		public static string GetDatabase()
		{
			string db = "";
			if (ConnectionStringVisible != "")
			{
				SqlConnection connec = new SqlConnection(connectionStringVisible);
				db = connec.Database;
			}
			return db;						
		}
		public static string GetServidor()
		{
			string db = "";
			if (ConnectionStringVisible != "")
			{
				SqlConnection connec = new SqlConnection(connectionStringVisible);
				db = connec.DataSource.ToUpper();
			}
			return db;						
		}
        //Cristian Tarea 0000122 02052011
        /*Actualiza la base de datos del connectionString actual. Retorna el connectionString modificado*/
        public static string updateConnectionString(String dataBaseName)
        {  
            String connectionStringActualizado = connectionStringVisible.Replace(GetDatabase(),dataBaseName);
            
            //Eliminamos la conexion que no utilizamos
            SqlConnection connec = new SqlConnection(connectionStringVisible);
            SqlConnection.ClearPool(connec);
            
            
            //Asignamos el nuevo connectionString
            ConnectionStringVisible = connectionStringActualizado;
            return ConnectionStringVisible;
        }	
        //Fin Cristian Tarea 0000122
	}
}
