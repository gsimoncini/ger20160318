using System;
using System.Reflection;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripci�n breve de WorkflowAttributes.
	/// </summary>
	public class WorkflowAttributes
	{
		public WorkflowAttributes()
		{
			//
			// TODO: agregar aqu� la l�gica del constructor
			//
		}


	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atInitialize:Attribute
	{
		
	}
}
