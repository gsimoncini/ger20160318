using System;
using System.Data;
using mz.erp.commontypes.data;
using mz.erp.dataaccess;
using System.Collections;


namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Util.
	/// </summary>
	public class Sistema
	{
		
        
        public class DateTime
		{
			public DateTime()
			{

			}
			
			public static System.DateTime Now
			{
				get
				{
					System.DateTime dbTime = mz.erp.dataaccess.Sistema.GetDbTime();
					if (dbTime != System.DateTime.MinValue)
					{
						//mz.erp.systemframework.SystemTime.GetTime()
						return dbTime;
					}
					else
						return mz.erp.businessrules.Sistema.DateTime.Now;
				}
			}

			public static System.DateTime FillDateTime(System.DateTime date)
			{
				return new System.DateTime(date.Year, date.Month, date.Day, Now.Hour, Now.Minute, Now.Second);
			}
		}
		
		public Sistema()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}
		private static string _currentBDVersion = String.Empty;
		private static string _currentBDAppVersion = String.Empty;
		public static string CurrentBDVersion
		{
			get
			{
				if (_currentBDVersion == String.Empty )
				{
					GetBDCurrentVersion();
				}
				return _currentBDVersion;
			}
		}
		public static string CurrentBDAppVersion
		{
			get
			{
				return _currentBDAppVersion;
			}
		}
		private static void GetBDCurrentVersion()
		{
			System.Data.DataRow row = mz.erp.dataaccess.Sistema.GetBDCurrentVersion();
			if (row != null)
			{
				_currentBDVersion = Convert.ToString(row["IdScript"]);
				_currentBDAppVersion = Convert.ToString(row["VersionApp"]);
			} 

		}

		public static DataTable GetStoredProceduresList()
		{
			return mz.erp.dataaccess.Sistema.GetStoredProceduresList();
		}

		
		public static DataTable GetStoredProcedureColumnsList(string SPName)
		{
			return mz.erp.dataaccess.Sistema.GetStoredProcedureColumnsList(SPName);
		}
		public static DataTable ExecuteSQLStatement(string SQL)
		{
			return mz.erp.dataaccess.Sistema.ExecuteSQLStatement(SQL);
		}
		

		#region ReplicationMonitor
		
		private static int _idLevelError = 0;
		private static int _gravedad = 0;
		private static string  _fileNameImage = null;
		private static string _descripcion = null;
		private static System.DateTime _lastProcessed ;

		public static int Gravedad
		{
			get
			{
				//GetLastProcessedInfo();
				return _gravedad;
			}
		}

		public static int IdLevelError
		{
			get
			{
				
				//GetLastProcessedInfo();
				return _idLevelError;
				
			}
	
		}

		public  static string FileNameImage
		{
			get
			{
				return _fileNameImage;
			}
		}

		public static string Descripcion
		{
			get
			{
				return _descripcion;
			}
	
		}

		public static System.DateTime LastProcessed
		{
			get
			{
				return _lastProcessed;
			}
		}

		public  static void  GetLastProcessedInfo()
		{
			System.Data.DataRow row = mz.erp.dataaccess.Sistema.GetLastProcessedInfo();
			if(row != null)
			{
				_idLevelError = Convert.ToInt32(row["IdLevelError"]);
				_gravedad = Convert.ToInt32(row["Gravedad"]);
				_fileNameImage = Convert.ToString(row["NombreImagen"]);
				_descripcion = Convert.ToString(row["Descripcion"]);
				_lastProcessed = Convert.ToDateTime(row["fechaUltimaModificacion"]);
			}
		}


		public static  void SetApplicactionState(int levelError)
		{
			mz.erp.dataaccess.Sistema.SetApplicationState(levelError);
		}

		public static System.DateTime GetLastProcessedDateTime()
		{
			return mz.erp.dataaccess.Sistema.GetLastProcessed();
		}



		#endregion

        //Cristian Tarea 0000051 20110408
        #region Filtros

        //Variable que maneja todos los valores actuales de los filtros de consultas
        //Guarda valores de tipo String
        public static Hashtable managerFiltersProcess = new Hashtable();

        public static string GetValueFilter(string proceso,string tarea, string property)
        {
            string valor = String.Empty;
            Hashtable tareas = (Hashtable) managerFiltersProcess[proceso];
            if (tareas != null)
            {
                Hashtable propiedades = (Hashtable)tareas[tarea];
                if (propiedades != null)
                {
                    Object valorPropiedad = propiedades[property];
                    if (valorPropiedad == null)
                    {
                        return String.Empty;
                    }
                    else { return valorPropiedad.ToString(); }
                }
            }
            return valor;
        }

        public static System.DateTime  GetValueFilterDate(string proceso, string tarea, string property)
        {
            System.DateTime valor = mz.erp.businessrules.Sistema.DateTime.Now;
            Hashtable tareas = (Hashtable)managerFiltersProcess[proceso];
            if (tareas != null)
            {
                Hashtable propiedades = (Hashtable)tareas[tarea];
                if (propiedades != null)
                {
                    System.DateTime valorPropiedad = (System.DateTime)propiedades[property];
                    if (valorPropiedad == null)
                    {
                        return valor;
                    }
                    else { return valorPropiedad; }
                }
            }
            return valor;
        }

        public static void AddValueFilter(string proceso, string tarea, string property, string value)
        {
            String valor = GetValueFilter(proceso, tarea, property);
            //if (!managerFiltersProcess.ContainsKey(proceso))
            if(valor == String.Empty)
            {
                Hashtable tareas = new Hashtable();
                Hashtable propiedades = new Hashtable();
                propiedades.Add(property, value);
                tareas.Add(tarea, propiedades);
                managerFiltersProcess.Add(proceso, tareas);
            }
        }
        #endregion
        //Fin Cristian Tarea 0000051 20110408

	}
}
