using System;
using System.Reflection;

namespace mz.erp.ui.controllers
{
	[ AttributeUsage( AttributeTargets.Method ) ]
	public class IsShowFormMember : Attribute
	{
	}
	[ AttributeUsage( AttributeTargets.Method ) ]
	public class IsShowWithParametersValueFormMember : Attribute
	{
	}


	[ AttributeUsage( AttributeTargets.Method ) ]
	public class IsEditFormMember : Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class IsViewFormMember : Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class IsNextStepMember : Attribute
	{
	}

	[ AttributeUsage( AttributeTargets.Method ) ]
	public class IsSaveChangesMember : Attribute
	{
	}
}
