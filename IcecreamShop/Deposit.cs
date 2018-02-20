using System;

namespace FinalProject_Group1
{
	/// <summary>
	/// Summary description for Deposit.
	/// </summary>
	public class Deposit : Transaction
	{
		static decimal decTotalDepositAmount  = 0.0M;
		static int     intTotalNumberDeposits = 0;

		public Deposit(decimal decDeposit)
		{
			/*
			 * Add to balance and increment number of deposits.
			 */
			AccountBalance += decDeposit;

			decTotalDepositAmount += decDeposit;

			intTotalNumberDeposits++;

		}

		public Deposit()
		{
			Reset();
		}

		public void Reset()
		{
			decTotalDepositAmount  = 0.0M;
			intTotalNumberDeposits = 0;

		}

		/// <summary>
		/// Total amount of deposit
		/// </summary>
		public static decimal TotalDepositAmount
		{
			get
			{
				return decTotalDepositAmount;
			}
		}

		/// <summary>
		/// Total Number of Deposits
		/// </summary>
		public static int TotalNumberDeposits
		{
			get
			{
				return intTotalNumberDeposits;
			}
		}
	}
}
