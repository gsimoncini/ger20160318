namespace mz.erp.dataaccess 
{
	using System;
	using System.Data;
	using System.Collections;
	using System.Data.SqlClient;
	using System.Text.RegularExpressions;
    
	using mz.erp.dbhelper;
	using mz.erp.systemframework;
	using mz.erp.commontypes;
	using mz.erp.commontypes.data;

	public class Variables 
	{
		public Variables()
		{
		}
		public static void Load()
		{
			System.Data.DataSet data = sy_Variables.GetList();
			foreach(System.Data.DataRow row in data.Tables[0].Rows)
			{
				string IdVariable = Convert.ToString(row["IdVariable"]);
				GetValue(IdVariable);
			}
		}
	
		private static Hashtable _variables = new Hashtable();
		private static Hashtable _variablesPerfiles = new Hashtable();
		private static Hashtable _variablesPuestos = new Hashtable();
		private static Hashtable _variablesUsuarios = new Hashtable();
		private static Hashtable _variablesEmpresas = new Hashtable();

		private static long _idPerfil;
		private static string _idUsuario = string.Empty;
		private static long _idEmpresa = 1;		
		private static long _idPuesto = 0;
		private static long _idSucursal = 1;



		public static void Reset()
		{
			_variables.Clear();
			_variablesPerfiles.Clear();
			_variablesPuestos.Clear();
			_variablesUsuarios.Clear();
			_variablesEmpresas.Clear();
		}

		public static void SetSecurity(long IdEmpresa, long IdSucursal, long IdPerfil, long IdPuesto, string IdUsuario) 
		{
			_idUsuario = IdUsuario;
			_idPerfil = IdPerfil;
			_idSucursal = IdSucursal;
			_idPuesto = IdPuesto;
			_idEmpresa = IdEmpresa;
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
				value = sy_Variables_GetValue(IdVariable);
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
				value = sy_Variables_GetValue(IdVariable);
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

		public static object GetValue( string IdVariable )
		{
			object value = null;
			DateTime fecha = DateTime.Now;
			if(_variablesPuestos.ContainsKey(IdVariable + Convert.ToString(_idPuesto)))
				value = _variablesPuestos[ IdVariable + Convert.ToString(_idPuesto) ];	
			else
			{
				value = sy_VariablesPuestos_GetValuePK( IdVariable );
				_variablesPuestos.Add(IdVariable + Convert.ToString(_idPuesto),value);
			}
			if (value == null)
			{
				if(_variablesUsuarios.ContainsKey(IdVariable + Convert.ToString(_idUsuario)))
					value = _variablesUsuarios[ IdVariable + Convert.ToString(_idUsuario) ];	
				else
				{
					value = sy_VariablesUsuarios_GetValuePK( IdVariable );
					_variablesUsuarios.Add(IdVariable + Convert.ToString(_idUsuario),value);
				}
				if (value == null)
				{
						
					if(_variablesPerfiles.ContainsKey(IdVariable + Convert.ToString(_idPerfil)))
						value = _variablesPerfiles[ IdVariable + Convert.ToString(_idPerfil) ];
					else 
					{
						
						value = sy_VariablesPerfiles_GetValuePK( IdVariable );
						_variablesPerfiles.Add(IdVariable + Convert.ToString(_idPerfil),value);
						
					}
						
					if (value == null)
					{
						if(_variablesEmpresas.ContainsKey(IdVariable + Convert.ToString(_idEmpresa)))
							value = _variablesEmpresas[ IdVariable + Convert.ToString(_idEmpresa) ];
						else 
						{
						
							value = sy_VariablesEmpresas_GetValuePK( IdVariable );
							_variablesEmpresas.Add(IdVariable + Convert.ToString(_idEmpresa),value);
						
						}
						if (value == null)
						{
							if (!_variables.ContainsKey( IdVariable ) )
							{
								value = sy_Variables_GetValue(IdVariable);
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
			value = sy_VariablesPerfiles_GetValue( IdVariable , Convert.ToInt16(IdPerfil));
			if (value == null)
			{
				if (!_variables.ContainsKey( IdVariable ) )
				{
					value = sy_Variables_GetValue(IdVariable);
					_variables.Add(IdVariable,value);
				}
				else
				{
					value = _variables[ IdVariable ];
				}
			}
			return value;
		}

		/*public static bool GetValueBool( string Proceso, string Tarea, string ColaDeVariable )
		{
			bool result = false;
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
		}*/


		/*public static long GetValueLong( string Proceso, string Tarea, string ColaDeVariable )
		{
			long result = long.MinValue;
			object value = GetValue("Momentos."+Tarea+"."+Proceso+"."+ColaDeVariable);
			if (value == null)
			{
				value = GetValue("Momentos."+Tarea+"."+ColaDeVariable);
				if(value != null)
					result = Convert.ToInt64(value);

			}	
			else
				result = Convert.ToInt64(value);
			return result;
		}*/

		/*public static bool GetValueBool( string Proceso, string Tarea, string ColaDeVariable, bool Default )
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
		}*/

		/*public static string GetValueStringDefault( string Proceso, string Tarea, string ColaDeVariable, string Default )
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
		}*/



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

		public static Int32 GetValueInt( string IdVariable )
		{
			object value = GetValue( IdVariable );
			if (value != null)
			{
				return Convert.ToInt32( value );
			}
			else
			{
				return Int32.MinValue;
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

		/*public static object GetValueWithoutCache( string IdVariable, string IdTransaction )
		{
			object value = null;
			value = sy_Variables_GetValue(IdVariable,IdTransaction);
			return value;
		}

		public static object GetValueWithoutCache( string IdVariable)
		{
			object value = null;
			value = sy_Variables_GetValue(IdVariable);
			return value;
		}*/


		/*public static string GetValueStringWithoutCache(string IdVariable, string IdTransaction)
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
		}*/

		/*public static bool GetValueBoolWithoutCache( string IdVariable )
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
		}*/


		//sy_variables
		public static object sy_Variables_GetValue( string IdVariable )
		{
			sy_VariablesDataset.sy_VariablesRow row = sy_Variables_GetByPk( IdVariable );
			if (row != null) 
			{
				return row.ValorDefault;				
			}
			else 
			{
				return null;
			}
		}
		public static sy_VariablesDataset.sy_VariablesRow sy_Variables_GetByPk( string IdVariable )
		{
			sy_VariablesDataset.sy_VariablesRow row = mz.erp.dataaccess.sy_Variables.GetByPk( IdVariable  );
			if (row!=null)
			{
				foreach ( DataColumn dc in row.Table.Columns ) 
				{
					if (row[dc] == System.DBNull.Value)
					{
						if (dc.Caption != "RowId" && !dc.Caption.ToUpper().Equals("ULTIMAMODIFICACION"))
							row[dc] = Util.DefaultValue( dc.DataType );

					}
				}
			}
			return row;
		}


		public static object sy_Variables_GetValue( string IdVariable, int IdPerfil )
		{
			sy_VariablesPerfilesDataset data = sy_Variables_GetList( IdVariable, IdPerfil );
			
			if ( data != null && data.sy_VariablesPerfiles.Rows.Count == 1 )
			{
				return ( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow ) data.sy_VariablesPerfiles.Rows[ 0 ] ).Valor;
			}
			else
			{
				//throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
				return null;
			}
		}
		public static sy_VariablesPerfilesDataset sy_Variables_GetList( string IdVariable, long IdPerfil )
		{
			return mz.erp.dataaccess.sy_VariablesPerfiles.GetList( IdVariable, IdPerfil );
		}

		//sy_VariablesPuestos
		public static object sy_VariablesPuestos_GetValuePK( string IdVariable )
		{
			return sy_VariablesPuestos_GetValuePK( IdVariable, _idEmpresa, _idSucursal, _idPuesto );
		}
		public static object sy_VariablesPuestos_GetValuePK( string IdVariable, long IdEmpresa, long IdSucursal, long IdPuesto )
		{
			sy_VariablesPuestosDataset.sy_VariablesPuestosRow row = dataaccess.sy_VariablesPuestos.GetByPk( IdVariable, IdEmpresa, IdSucursal, IdPuesto );
			if (row != null) 
			{
				return row.Valor;				
			}
			else 
			{
				return null;
			}						
		}

		//sy_VariablesUsuarios
		public static object sy_VariablesUsuarios_GetValuePK( string IdVariable )
		{
			return sy_VariablesUsuarios_GetValuePK( IdVariable, _idUsuario );

		}
		public static object sy_VariablesUsuarios_GetValuePK( string IdVariable, string IdUsuario )
		{
			sy_VariablesUsuariosDataset.sy_VariablesUsuariosRow row = sy_VariablesUsuarios.GetByPk(IdVariable, IdUsuario );
			if ( row != null)
			{
				return row.Valor;
			}
			else
			{
				return null;
			}
		}
		
		//sy_VariablesPerfiles
		public static object sy_VariablesPerfiles_GetValuePK( string IdVariable )
		{
			return sy_VariablesPerfiles_GetValuePK( IdVariable, _idPerfil );
		}

		public static object sy_VariablesPerfiles_GetValuePK( string IdVariable, long IdPerfil )
		{
			sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow row = sy_VariablesPerfiles.GetByPk( IdVariable, IdPerfil );
			
			if ( row != null )
			{
				return row.Valor;
			}
			else
			{
				return null;
			}
		}

		public static object sy_VariablesPerfiles_GetValue( string IdVariable, int IdPerfil )
		{
			sy_VariablesPerfilesDataset data = sy_VariablesPerfiles.GetList( IdVariable, IdPerfil );
			
			if ( data != null && data.sy_VariablesPerfiles.Rows.Count == 1 )
			{
				return ( ( sy_VariablesPerfilesDataset.sy_VariablesPerfilesRow ) data.sy_VariablesPerfiles.Rows[ 0 ] ).Valor;
			}
			else
			{
				//throw new ArgumentException( "No se ha encontrado el parámetro indicado" );
				return null;
			}
		}


		//sy_VariablesEmpresas
		public static object sy_VariablesEmpresas_GetValuePK( string IdVariable)
		{
			return sy_VariablesEmpresas_GetValuePK( IdVariable, _idEmpresa );
		}
		public static object sy_VariablesEmpresas_GetValuePK( string IdVariable, long IdEmpresa )
		{
			sy_VariablesEmpresasDataset.sy_VariablesEmpresasRow  row = sy_VariablesEmpresas.GetByPk( IdVariable, IdEmpresa );
			if ( row != null )
			{
				return row.Valor;
			}
			else
			{
				return null;
			}
		}		

	}
}

