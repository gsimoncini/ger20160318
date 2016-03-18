using System;

namespace mz.erp.commontypes.CommonInterfaces
{
	/// <summary>
	/// Descripción breve de IPredicate.
	/// </summary>
	public interface IPredicate
	{
		bool  Evaluate (object parameters);	
	}
}
