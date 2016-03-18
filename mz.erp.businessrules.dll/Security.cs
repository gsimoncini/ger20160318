
namespace mz.erp.businessrules
{
	using System;
	using System.Data;
	using System.Collections;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;
	using mz.erp.systemframework;
	using Infragistics.Win;

	using Infragistics.Win.UltraWinToolbars;

	public class Security
	{
		private static long _idPerfil;
		private static string _perfil = string.Empty;
		private static long _idIdioma;
		private static string _idUsuario = string.Empty;
		private static bool _loguinOk = false;
		private static string _nombre = string.Empty;
		private static long _idConexion = 0;
		private static long _idEmpresa = 1;
		private static long _idSucursal = Security.IdSucursal;
		private static string _idPersona = string.Empty;
		private static string _password = string.Empty;
		private static long _idPuesto = 0;
		private static string _puesto = string.Empty;
		private static string _separadorDeMiles;
		private static string _separadorDecimal;
		private static string _cultureName;
		private static long _grupo = -1;
		private static ArrayList _perfilesSuperioresList = new ArrayList();
		private static string _cajasNivelControl = "A";

		
		public static bool LogInXPersona( string IdPersona, string Password )
		{						
			string UserName = businessrules.sy_Usuarios.GetUsuario(IdPersona);
			sy_UsuariosDataset.sy_UsuariosRow _row = sy_Usuarios.GetByPk( UserName );
			if ( _row != null )
			{
				string keyEcrypted = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64(_row.Clave);
				if (Password.CompareTo( keyEcrypted )==0 )
				{
					return true;
				}
			}
			return false;
				
		}

		public static bool LogIn( string UserName, string Password )
		{
			sy_UsuariosDataset.sy_UsuariosRow _row = sy_Usuarios.GetByPk( UserName );
			if ( _row != null )
			{
				string keyEcrypted = new mz.erp.security.dll.Encryption.Symmetric().DecryptStringBase64(_row.Clave);
				//string keyEcrypted = new mz.erp.security.dll.Encryption.Symmetric().EncryptStringBase64(Password);
				//Console.WriteLine(keyEcrypted);
				if (Password.CompareTo( keyEcrypted )==0 )
					//if (Password.CompareTo(_row.Clave)==0 )
				{
					_loguinOk = true;
					_nombre = _row.Nombre;
					//ARREGLAR!!!!
					_idConexion = 1;
					_idEmpresa = 1;
					_idPersona = _row.IdPersona;
					_idSucursal = Variables.GetValueLong("Debug.IdSucursal");
					_password = Password;
					_idPuesto = Convert.ToInt32(systemframework.ApplicationConfiguration.Puesto);					
					DataRow row = mz.erp.businessrules.sy_Puestos.GetByPk(_idPuesto);
					if(row != null)
						_puesto = Convert.ToString(row["Descripcion"]);
					else
						_puesto = string.Empty;
					_grupo = _row.Equipo;

					string perfilesSuperiores = Variables.GetValueString("Seguridad.Perfiles.PerfilesSuperiores");
					_perfilesSuperioresList = mz.erp.systemframework.Util.Parse(perfilesSuperiores,",");
					_cajasNivelControl = Variables.GetValueString("Cajas.Seguridad.NivelControl", _cajasNivelControl).ToUpper();
					

					dataaccess.Variables.SetSecurity(_idEmpresa, _idSucursal, _idPerfil, _idPuesto, _idUsuario);
					ClaseTarea.Load();
					ControllerTarea.Load();
					return _loguinOk;
				}
			}
			return false;
		}

		public static bool CajasNivelControlAlto
		{
			get
			{
				return _cajasNivelControl.Equals("A");
			}
		}

		public static bool CajasNivelControlMedio
		{
			get
			{
				return _cajasNivelControl.Equals("M");
			}
		}

		public static bool CajasNivelControlBajo
		{
			get
			{
				return _cajasNivelControl.Equals("B");
			}
		}
		/*
		public static string CajasNivelControl
		{
			get
			{
				return _cajasNivelControl;
			}
		}
		*/

		public static string SeparadorDecimal
		{
			get{return _separadorDecimal;	}
			set{_separadorDecimal = value;}
		}


		public static string SeparadorDeMiles
		{
			get{return _separadorDeMiles;	}
			set{_separadorDeMiles = value;}
		}

		public static string CultureName
		{
			get{return _cultureName;	}
			set{_cultureName = value;}
		}

		public static string IdPersona
		{
			get{return _idPersona;	}
			set{_idPersona = value;}
		}

		public static void LogOut()
		{
			_idPerfil = 0;
			_idIdioma = 0;
			_idUsuario = string.Empty;
			_nombre = string.Empty;
			_loguinOk = false;
			_password = string.Empty;
			_grupo = -1;
			dataaccess.Variables.SetSecurity(_idEmpresa, _idSucursal, _idPerfil, _idPuesto, _idUsuario);	
			
		}

		public static long Grupo
		{
			get{return _grupo;}
		}

		public static bool LoginOk
		{
			get
			{
				return _loguinOk;
			}
		}
		public static long IdEmpresa
		{
			get
			{
				return _idEmpresa;
			}
			set
			{
				_idEmpresa = value;
			}
		}

		public static long IdSucursal
		{
			get
			{
				if(_idSucursal == 0)
					return Variables.GetVariablesValueLong("Debug.IdSucursal");
				return _idSucursal;
			}
			set
			{
				_idSucursal = value;
			}
		}

		public static long IdConexion
		{
			get
			{
				return _idConexion;
			}
			set
			{
				_idConexion = value;
			}
		}

		public static string IdUsuario
		{
			get
			{
				return _idUsuario;
			}

			set
			{
				_idUsuario = value;
			}
		}

		public static string Password
		{
			get
			{
				return _password;
			}
		}

		public static long IdPuesto
		{
			get
			{
				return _idPuesto;
			}
		}

		public static string Puesto
		{

			get
			{
				return _puesto;
			}
		}

		public static long IdPerfil
		{
			get
			{
				return _idPerfil;
			}

			set
			{
				_idPerfil = value;
			}
		}

		public static string Perfil
		{
			get
			{
				return _perfil;
			}

			set
			{
				_perfil = value;
			}
		}

		public static long IdIdioma
		{
			get
			{
				return _idIdioma;
			}

			set
			{
				_idIdioma = value;
			}
		}

		public static bool PerteneceAPerfilSuperior
		{
			get 
			{  
				return _perfilesSuperioresList.Contains(_idPerfil.ToString());
			}
		}

		public static ArrayList PerfilesSuperioresList
		{
			get 
			{  
				return _perfilesSuperioresList;
			}
		}

		public Security()
		{
		}

		public static bool AllowFunction(string IdVariable) 
		{
			///Como primer paso me fijo si tiene permiso definida por la variable (Sy_variables)
			///En caso contrario: Tomo el usuario (_idUsuario)
			///Con este dato busco los perfiles
			///con los perfiles busco la IdVariable
			///Si no la encuentro AllowFuncion devuelve false
			
			///
			bool resultVariable = Variables.GetValueBool(IdVariable);				
			if (resultVariable) 
			{
				return true;
			}
			else 
			{
				bool resultPerfil = false;
				sy_PerfilesUsuariosEmpresasDataset perfiles = sy_PerfilesUsuariosEmpresas.GetList(_idUsuario, _idEmpresa);
				foreach(sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row in perfiles.sy_PerfilesUsuariosEmpresas.Rows)			
				{				
					long IdPerfil = row.IdPerfil;
					sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowVP = sy_VariablesPerfiles.GetByPk(IdVariable, IdPerfil);
					if (rowVP != null) 
					{
						resultPerfil = Convert.ToBoolean(rowVP.Valor);
					}
					if (resultPerfil) 
					{
						return true;
					}				
				}		
				return resultPerfil;
			}
		}
		public static bool AllowFunction(string IdVariable, string IdUsuario) 
		{
			///Como primer paso me fijo si tiene permiso definida por la variable (Sy_variables)
			///En caso contrario: Tomo el usuario (_idUsuario)
			///Con este dato busco los perfiles
			///con los perfiles busco la IdVariable
			///Si no la encuentro AllowFuncion devuelve false
			
			///
			bool resultVariable = Variables.GetVariablesValueBool(IdVariable);				
			if (resultVariable) 
			{
				return true;
			}
			resultVariable = Variables.GetVariablesUsuariosValueBool(IdVariable, IdUsuario);
			if (resultVariable) 
			{
				return true;
			}
			bool resultPerfil = false;
			sy_PerfilesUsuariosEmpresasDataset perfiles = sy_PerfilesUsuariosEmpresas.GetList(IdUsuario, _idEmpresa);
			foreach(sy_PerfilesUsuariosEmpresasDataset.sy_PerfilesUsuariosEmpresasRow row in perfiles.sy_PerfilesUsuariosEmpresas.Rows)			
			{				
				long IdPerfil = row.IdPerfil;
				sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow rowVP = sy_VariablesPerfiles.GetByPk(IdVariable, IdPerfil);
				if (rowVP != null) 
				{
					resultPerfil = Convert.ToBoolean(rowVP.Valor);
				}
				if (resultPerfil) 
				{
					return true;
				}				
			}		
			return resultPerfil;
		}
	}
}
