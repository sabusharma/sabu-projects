using System;

namespace FinalProject_Group1
{
	/// <summary>
	/// Summary description for ServiceCharge.
	/// </summary>
	public class ServiceCharge : Transaction
	{
		public ServiceCharge()
		{
			AccountBalance -= 10.0M;
		}
	}
}
