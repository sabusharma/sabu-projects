using System;

namespace FinalProject_Group1
{
	/// <summary>
	/// Summary description for Transaction.
	/// </summary>
	public class Transaction
	{
		private static decimal decAccountBalance = 0.0M;

		public Transaction()
		{
		}

		/// <summary>
		/// Account Balance
		/// </summary>
		public decimal AccountBalance
		{
			get
			{
				return decAccountBalance;
			}
			set
			{
				decAccountBalance = value;
			}
		}


	}
}
