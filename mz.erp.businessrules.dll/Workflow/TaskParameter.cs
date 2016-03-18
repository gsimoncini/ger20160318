using System;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripción breve de TaskParameter.
	/// </summary>
	public class TaskParameter
	{
		public TaskParameter()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		#region Variables Privadas
			private string _parameterName;
			private object _parameterValue;
			private Type _parameterValueType;
		#endregion

		#region Variables Publicas
		public string ParameterName
		{
			get
			{
				return _parameterName;
			}
			set
			{
				_parameterName = value;
			}
		}

		public object ParameterValue
		{
			get
			{
				return _parameterValue;
			}
			set
			{
				_parameterValue = value;
			}
		}

		public Type ParameterValueType 
		{
			get
			{
				return _parameterValueType;
			}
			set
			{
				_parameterValueType = value;
			}
		}
		
		#endregion

	}
}
