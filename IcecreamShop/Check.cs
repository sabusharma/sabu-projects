using System;
using System.Windows.Forms;


namespace FinalProject_Group1
{
	/// <summary>
	/// Summary description for Check.
	/// </summary>
	public class Check : Transaction
	{
		static decimal decTotalCheckAmount  = 0.0M;
		static int     intTotalNumberChecks = 0;

		public Check(decimal decCheck)
		{
			/*
			 * Check to see if check will cause account balance to go
			 * below zero.  If check ammount cause account balance to
			 * go below zero then deduct a service charge of $10.00.
			 */
			if ( (AccountBalance - decCheck) < 0 )
			{
				MessageBox.Show("Insufficient Funds.",
					"OverDraft Error", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);

				AccountBalance -= 10.0M;

			}
			else
			{
				AccountBalance -= decCheck;

				decTotalCheckAmount += decCheck;

				intTotalNumberChecks++;
			}

		}

		public Check()
		{
			Reset();
		}

		public void Reset()
		{
			decTotalCheckAmount  = 0.0M;
			intTotalNumberChecks = 0;
		}

		/// <summary>
		/// Total check amount
		/// </summary>
		public static decimal TotalCheckAmount
		{
			get
			{
				return decTotalCheckAmount;
			}
		}

		/// <summary>
		/// Total Number of Checks
		/// </summary>
		public static int TotalNumberChecks
		{
			get
			{
				return intTotalNumberChecks;
			}
		}


	}
}
