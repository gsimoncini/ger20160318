using System;
using System.Reflection;

namespace mz.erp.businessrules
{

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atMethodSaveRowWithValidation : Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atMethodSaveRow : Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atMethodNewRow : Attribute
	{
	}
	
	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atMethodGetByPkRow : Attribute
	{
	}
	[ AttributeUsage( AttributeTargets.Method ) ]
	public class atMethodDeleteRow : Attribute
	{
	}

	


}
