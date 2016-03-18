using System;
using System.Collections;

namespace mz.erp.businessrules
{
	/// <summary>
	/// Descripci�n breve de ReportParameter.
	/// </summary>
	public class ReportParameter:IComparable
	{
		#region Constructores
		
		public ReportParameter()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
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
			set
			{
				_parameterName = value;
			}
			
		}

		public string ParameterValue
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



		#endregion

		#region Miembros de IComparable

		public int CompareTo( object obj )
		{	
			return 0;
		}

		#endregion


	}

	public class ReportParameterCollection : CollectionBase
	{
		public virtual void Add( ReportParameter param )
		{
			List.Add ( param );
		}
		public virtual ReportParameter GetValue(int index)
		{
			return (ReportParameter)List[index];
	    }

	}

	


}
