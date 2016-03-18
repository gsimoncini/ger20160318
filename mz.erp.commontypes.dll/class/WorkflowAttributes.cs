using System;
using System.Reflection;

namespace mz.erp.commontypes
{
	/// <summary>
	/// Descripción breve de WorkflowAttributes.
	/// </summary>
	public class WorkflowAttributes
	{
		public WorkflowAttributes()
		{
			//
			// TODO: agregar aquí la lógica del constructor
			//
		}


	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atInitialize:Attribute
	{
		
	}
}
