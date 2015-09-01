using System;

namespace Constructor
{
	public class Account
	{
		//private member data
		private string name;
		private string address;
		private decimal balance;

		// this is like currying in javascript
		public Account(string inName, string inAddress,
			decimal inBalance)
		{
			name = inName;
			address = inAddress;
			balance = inBalance;
			Console.WriteLine ("We just made an account");
		}
		public Account(string inName, string inAddress) :
		this(inName, inAddress, 0)
		{
			
		}
		public Account(string inName) :
		this(inName, "Not Supplied", 0)
		{
		}

		static void Main()
		{
			new Account ();
			new Account ();
		}

	}


}
