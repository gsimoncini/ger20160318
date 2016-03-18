using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de Variables.
	/// </summary>
	public class Variables
	{
		public Variables()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		/*
		public static void Load()
		{
			System.Data.DataSet data = sy_Variables.GetList();
			foreach(System.Data.DataRow row in data.Tables[0].Rows)
			{
				string IdVariable = Convert.ToString(row["IdVariable"]);
				GetValue(IdVariable);
			}
		}
		*/
		private static Hashtable _variables = new Hashtable();
		private static Hashtable _variablesPerfiles = new Hashtable();
		private static Hashtable _variablesPuestos = new Hashtable();
		private static Hashtable _variablesUsuarios = new Hashtable();
		private static Hashtable _variablesEmpresas = new Hashtable();


		public static void Reset()
		{
			_variables.Clear();
			_variablesPerfiles.Clear();
			_variablesPuestos.Clear();
			_variablesUsuarios.Clear();
			_variablesEmpresas.Clear();
			dataaccess.Variables.Reset();
			ComprobantesRules.Reset();
		}

		public static void ModifyVariable(string idVariable , object value)
		{
			if (_variables.ContainsKey( idVariable ))

				_variables[idVariable] = value;
		}

		public static void ModifyVariablePerfil(string idVariable, long idperfil , object value)
		{
			string key = idVariable + Convert.ToString(idperfil);
			if (_variables.ContainsKey( key ))

				_variables[idVariable] = value;
		}

		/// <summary>
		/// Devuelve una variable de tipo objeto buscandola jerarquicamente. Primero busca por puesto, si no
		/// esta definida busca por usuario, luego por perfil, empresa y por ultimo por variable general
		/// </summary>
		/// <param name="IdVariable"></param>
		/// <returns></returns>
		/// 
		/*Solo busca en Sy_variables, no busca en forma jerarquica*/
		public static object GetVariablesValue( string IdVariable )
		{
			object value = null;
			if (!_variables.ContainsKey( IdVariable ) )
			{
				value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
				_variables.Add(IdVariable,value);
			}
			else
			{
				value = _variables[ IdVariable ];
			}
			return value;
		}

		public static long GetVariablesValueLong( string IdVariable )
		{
			object value = null;
			if (!_variables.ContainsKey( IdVariable ) )
			{
				value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
				_variables.Add(IdVariable,value);
			}
			else
			{
				value = _variables[ IdVariable ];
			}
			if(value != null)
			{
				return Convert.ToInt64(value);
			}
			return long.MinValue;
		}

		public static bool GetVariablesValueBool( string IdVariable )
		{
			object value = null;
			if (!_variables.ContainsKey( IdVariable ) )
			{
				value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
				_variables.Add(IdVariable,value);
			}
			else
			{
				value = _variables[ IdVariable ];
			}
			if(value != null)
			{
				return Convert.ToBoolean(value);
			}
			return false;
		}
		public static bool GetVariablesUsuariosValueBool( string IdVariable, string IdUsuario)
		{
			object value = null;
			if (!_variablesUsuarios.ContainsKey( IdVariable ) )
			{
				value = mz.erp.businessrules.sy_VariablesUsuarios.GetValue(IdVariable, IdUsuario);
				_variablesUsuarios.Add(IdVariable,value);
			}
			else
			{
				value = _variablesUsuarios[ IdVariable ];
			}
			if(value != null)
			{
				return Convert.ToBoolean(value);
			}
			return false;
		}

		//Silvina 20100512 - Tarea 748
		public static string GetVariablesUsuariosValueString( string IdVariable, string IdUsuario)
		{
			object value = null;
			value = mz.erp.businessrules.sy_VariablesUsuarios.GetValuePK( IdVariable,IdUsuario );
			if (value != null)
				return value.ToString();
			else
			{
				value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
				if (value != null)
					return value.ToString();
			}				
			return string.Empty;
		}

		public static decimal GetValueDecimal( string Proceso, string Tarea, string ColaDeVariable )
		{
			decimal result = decimal.MinValue;
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
					result = Convert.ToDecimal(value);

			}	
			else
				result = Convert.ToDecimal(value);
			return result;
		}



		public static object GetValue( string IdVariable )
		{
			object value = null;
			DateTime fecha = DateTime.Now;
			if(_variablesPuestos.ContainsKey(IdVariable + Convert.ToString(Security.IdPuesto)))
					value = _variablesPuestos[ IdVariable + Convert.ToString(Security.IdPuesto) ];	
				else
				{
					value = mz.erp.businessrules.sy_VariablesPuestos.GetValuePK( IdVariable );
					_variablesPuestos.Add(IdVariable + Convert.ToString(Security.IdPuesto),value);
				}
			if (value == null)
			{
				if(_variablesUsuarios.ContainsKey(IdVariable + Convert.ToString(Security.IdUsuario)))
					value = _variablesUsuarios[ IdVariable + Convert.ToString(Security.IdUsuario) ];	
				else
				{
					value = mz.erp.businessrules.sy_VariablesUsuarios.GetValuePK( IdVariable );
					_variablesUsuarios.Add(IdVariable + Convert.ToString(Security.IdUsuario),value);
				}
				if (value == null)
					{
						
						if(_variablesPerfiles.ContainsKey(IdVariable + Convert.ToString(Security.IdPerfil)))
							value = _variablesPerfiles[ IdVariable + Convert.ToString(Security.IdPerfil) ];
						else 
						{
						
							value = mz.erp.businessrules.sy_VariablesPerfiles.GetValuePK( IdVariable );
							_variablesPerfiles.Add(IdVariable + Convert.ToString(Security.IdPerfil),value);
						
						}
						
						if (value == null)
						{
							if(_variablesEmpresas.ContainsKey(IdVariable + Convert.ToString(Security.IdEmpresa)))
								value = _variablesEmpresas[ IdVariable + Convert.ToString(Security.IdEmpresa) ];
							else 
							{
						
								value = mz.erp.businessrules.sy_VariablesEmpresas.GetValuePK( IdVariable );
								_variablesEmpresas.Add(IdVariable + Convert.ToString(Security.IdEmpresa),value);
						
							}
							if (value == null)
							{
								if (!_variables.ContainsKey( IdVariable ) )
								{
									value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
									_variables.Add(IdVariable,value);
								}
								else
								{
									value = _variables[ IdVariable ];
								}
							}
						}
					}
				}
			if(IdVariable.Equals("Momentos.Prevender.Cuenta.Default"))
			{
				TimeSpan  diff = DateTime.Now.Subtract(fecha);
				Console.WriteLine("GetValue ***********************************" + diff.TotalSeconds + " " + DateTime.Now);
			}
				
				
				return value;
		}

		public static object GetValue( string IdVariable, string IdPerfil )
		{
			object value = null;
			value = mz.erp.businessrules.sy_VariablesPerfiles.GetValue( IdVariable , Convert.ToInt16(IdPerfil));
			if (value == null)
			{
				if (!_variables.ContainsKey( IdVariable ) )
				{
					value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
					_variables.Add(IdVariable,value);
				}
				else
				{
					value = _variables[ IdVariable ];
				}
			}
			return value;
		}

		public static bool GetValueBool( string Proceso, string Tarea, string ColaDeVariable )
		{
			bool result = false;
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable);
            if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
					result = Convert.ToBoolean(value);

			}	
			else
			result = Convert.ToBoolean(value);
            return result;
		}
		//Busca por proceso tarea sino esta, entonces devuelve el valor de la variable default
		public static bool GetValueBool( string Proceso, string Tarea, string ColaDeVariable, string VariableDefault )
		{
			bool result = false;
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
					result = Convert.ToBoolean(value);
				else
				{
					value=GetValue(VariableDefault);
					if(value != null)
						result = Convert.ToBoolean(value);
				}

			}	
			else
				result = Convert.ToBoolean(value);
			return result;
		}

		/*German 20090325*/
		//Busca por proceso tarea sino esta, entonces devuelve el valor de la variable default
		public static bool GetValueBool( string Proceso, string Tarea, string ColaDeVariable, string VariableDefault, bool ValorDefault )
		{
			bool result = ValorDefault;
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
					result = Convert.ToBoolean(value);
				else
				{
					value=GetValue(VariableDefault);
					if(value != null)
						result = Convert.ToBoolean(value);
				}

			}	
			else
				result = Convert.ToBoolean(value);
			return result;
		}
		/*Fin German 20090325*/
		
		public static long GetValueLong( string Proceso, string Tarea, string ColaDeVariable )
		{
			long result = long.MinValue;
			object value = GetValue("Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
				{
					try
					{
						result = Convert.ToInt64(value);
					}
					catch(Exception e)
					{
						result = long.MinValue;
					}
				}	

			}	
			else
			{
				try
				{
					result = Convert.ToInt64(value);
				}
				catch(Exception e)
				{
					result = long.MinValue;
				}
			}	
			return result;
		}
		public static long GetValueLong( string Proceso, string Tarea, string ColaDeVariable, long Default)
		{
			long result = Default;
			object value = GetValue("Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
				{
					try
					{
						result = Convert.ToInt64(value);
					}
					catch(Exception e)
					{
						result = long.MinValue;
					}
				}	

			}	
			else
			{
				try
				{
					result = Convert.ToInt64(value);
				}
				catch(Exception e)
				{
					result = long.MinValue;
				}
			}	
			return result;
		}

		public static bool GetValueBool( string Proceso, string Tarea, string ColaDeVariable, bool Default )
		{
			bool result = Default;
			object value = GetValue("Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
					result = Convert.ToBoolean(value);

			}	
			else
				result = Convert.ToBoolean(value);
			return result;
		}

		public static string GetValueStringDefault( string Proceso, string Tarea, string ColaDeVariable, string Default )
		{
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if (value != null)
					return (string)value;
				else
					return Default;
			}
			else
				return (string) value;
		}


		public static string GetValueString( string Proceso, string Tarea, string ColaDeVariable )
		{
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if (value != null)
					return (string)value;
				else
					return string.Empty;
			}
			else
				return (string) value;
		}

		public static string GetValueString( string Proceso, string Tarea, string ColaDeVariable , string IdPerfil)
		{
			string variable = "Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable;
			object value = GetValue(variable, IdPerfil);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable, IdPerfil);
				if (value != null)
					return (string)value;
				else
					return string.Empty;
			}
			else
				return (string) value;
		}



		public static string GetValueString( string IdVariable )
		{
			object value = GetValue(IdVariable);
			if (value != null)
			{
				return (string)value;
			}
			else
			{
				return string.Empty;
			}
			
		}

		public static string GetValueString( string IdVariable, string Default )
		{
			object value = GetValue(IdVariable);
			if (value != null)
			{
				return (string)value;
			}
			else
			{
				return Default;
			}
			
		}
		
		public static bool GetValueBool( string IdVariable )
		{
			object value = GetValue( IdVariable );
			if (value != null) 
			{
				return Convert.ToBoolean( value );
			}
			else
			{
				return false;
			}
		}

		public static bool GetValueBool( string IdVariable, string VariableDefault)
		{
			object value = GetValue( IdVariable );
			if (value != null) 
			{
				return Convert.ToBoolean( value );
			}
			else
			{
				value=GetValue(VariableDefault);
				if(value != null)
					return Convert.ToBoolean(value);
				else
                    return false;
			}
		}


		public static bool GetValueBool( string IdVariable, bool Default)
		{
			object value = GetValue( IdVariable );
			if (value != null) 
			{
				return Convert.ToBoolean( value );
			}
			else
			{
				return Default;
			}
		}
		
		public static long GetValueLong( string IdVariable )
		{
			object value = GetValue( IdVariable );
			if (value != null)
			{
				return Convert.ToInt32( value );
			}
			else
			{
				return long.MinValue;
			}
		}

		public static decimal GetValueDecimal( string IdVariable )
		{
			object value = GetValue( IdVariable );
			if (value != null)
			{
				return Convert.ToDecimal( value );
			}
			else
			{
				return decimal.MinValue;
			}
		
		}

		public static object GetValueWithoutCache( string IdVariable, string IdTransaction )
		{
			object value = null;
			value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable,IdTransaction);
			return value;
		}

		public static object GetValueWithoutCache( string IdVariable)
		{
			object value = null;
			value = mz.erp.businessrules.sy_Variables.GetValue(IdVariable);
			return value;
		}

		//German 20090804
		public static object GetValuePerfilesWithoutCache( string IdVariable,long IdPerfil, string IdTransaction )
		{
			object value = null;
			value = mz.erp.businessrules.sy_VariablesPerfiles.GetValue(IdVariable, Convert.ToInt32(IdPerfil) ,IdTransaction);
			return value;
		}

		public static object GetValuePerfilesWithoutCache( string IdVariable,long IdPerfil)
		{
			object value = null;
			value = mz.erp.businessrules.sy_VariablesPerfiles.GetValue(IdVariable, Convert.ToInt32(IdPerfil));
			return value;
		}
        
        /* Silvina 20111230 - Tarea 0000245 */
        public static string GetValueStringUsuariosWithoutCache(string IdVariable, string IdUsuario)
        {
            object value = null;
            value = mz.erp.businessrules.sy_VariablesUsuarios.GetValue(IdVariable, IdUsuario);
            if (value != null)
                return (string)value;
            return string.Empty;
        }

        public static string GetValueStringUsuariosWithoutCache(string IdVariable, string IdUsuario, string IdTransaction)
        {
            object value = null;
            value = mz.erp.businessrules.sy_VariablesUsuarios.GetValue(IdVariable, IdUsuario, IdTransaction);
            if (value != null)
                return (string)value;
            return string.Empty;
        }

        /* Fin Silvina 20111230 - Tarea 0000245 */

		public static string GetValueStringPerfilesWithoutCache(string IdVariable, long IdPerfil)
		{
			object value = GetValuePerfilesWithoutCache(IdVariable, IdPerfil );
			if (value != null)
			{
				return (string)value;
			}
			else
			{
				return GetValueStringWithoutCache(IdVariable);
			}
		}


		public static string GetValueStringPerfilesWithoutCache(string IdVariable, long IdPerfil, string IdTransaction)
		{
			object value = GetValuePerfilesWithoutCache(IdVariable, IdPerfil ,IdTransaction);
			if (value != null)
			{
				return (string)value;
			}
			else
			{
				return GetValueStringWithoutCache(IdVariable, IdTransaction);
			}
		}

		//Fin German 20090804



		public static string GetValueStringWithoutCache(string IdVariable, string IdTransaction)
		{
			object value = GetValueWithoutCache(IdVariable,IdTransaction);
			if (value != null)
			{
				return (string)value;
			}
			else
			{
				return string.Empty;
			}
		}
		public static string GetValueStringWithoutCache( string IdVariable )
		{
			object value = GetValueWithoutCache(IdVariable);
			if (value != null)
			{
				return (string)value;
			}
			else
			{
				return string.Empty;
			}
			
		}

		public static bool GetValueBoolWithoutCache( string IdVariable )
		{
			object value = GetValueWithoutCache(IdVariable);
			if (value != null)
			{				
				return Convert.ToBoolean( value );
			}
			else
			{
				return false;
			}			
		}

		public static bool GetValueBoolWithoutCache( string IdVariable, bool Default)
		{
			object value = GetValueWithoutCache(IdVariable);
			if (value != null)
			{				
				return Convert.ToBoolean( value );
			}
			else
			{
				return Default;
			}			
		}
	}
}
