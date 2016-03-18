using System;
using System.Collections;

namespace mz.erp.ui
{
	/// <summary>
	/// Descripción breve de ReportParameter.
	/// </summary>
	public class ReportParameter
	{
		#region Constructores
		
		public ReportParameter()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}

		public ReportParameter(string parameterName, string parameterValue)
		{
			_parameterName = parameterName;
			_parameterValue = parameterValue;

		}

		#endregion

		#region Variables privadas
		
		private string _parameterName;
		private string _parameterValue;

		#endregion
		
		#region Propiedades
			
		public string ParameterName
		{
			get
			{
				return _parameterName;
			}
			
		}

		public string ParameterValue
		{
			get
			{
				return _parameterValue;
			}
			

		}



		#endregion


	}

	public class ReportParameterCollection : CollectionBase
	{
		public virtual void Add( ReportParameter param )
		{
			List.Add ( param );
			
		}

	}

}
