using System;

namespace ComponentsInterfaces
{
	public interface IAccount
	{
		void PayInFunds(decimal amount);
		bool WithdrawFunds(decimal amount);
		decimal GetBalance();
	}

	// this means that CustomerAccount inherits methods from IAccount, and must 
	// implement them or a compilation error will occur
	public class CustomerAccount : IAccount
	{
		private decimal balance = 0;

		public bool WithdrawFunds ( decimal amount ) 
		{ 
			if ( balance < amount ) 
			{ 
				return false ; 
			} 
			balance = balance - amount ; 
			return true; 
		} 

		public void PayInFunds ( decimal amount ) 
		{ 
			balance = balance + amount ; 
		} 

		public decimal GetBalance () 
		{ 
			return balance; 
		}
	}

	// IAccount checks program for Constructor that implements that interface
	IAccount account = new CustomerAccount();
	account.PayInFunds(50);

	//now you can implement new class objects
	public class BabyAccount : IAccount
	{
		private decimal balance = 0;

		public bool WithdrawFunds(decimal amount)
		{
			if(amount > 10)
			{
				return false;
			}
			if(balance < amount)
			{
				return false;
			}
			balance = balance - amount;
			return true;
		}
		// implement PayInFunds nad GetBalance()....

		// you can also implement as many interfaces as you want

		// public class BabyAccount : IAccount, IPrintToPaper

		// same goes from inheritance 
		// public class BabyAccount : CustomerAccount, IAccount


		// if we use the sealed keyword then no one can extend the baby account
		public sealed class BabyAccount : CustomerAccount, IAccount
		{
			public override bool WithdrawFunds (decimal amount)
			{
				if(amount > 10)
				{
					return false;
				}
				//  this runs the parent method instead of rewriting it
				return base.WithdrawFunds(amount);
			}
		}

		public class CustomerAccount : IAccount
		{
			// private decimal balance = 0;
			// need to make this protected rather than private so children can access it
			protected decimal balance = 0;

			// virtual is needed in the parent class to tell the child class that 
			// this method may be overridden in the future
			public virtual bool WithdrawFunds(decimal amount)
			{
				if(balance < amount)
				{
					return false;
				}
				balance = balance - amount;
				return true;
			}

			// base calls the parent class Account to run that constructor
			public CustomerAccount(string inName, string inAddress) :
			base(inName, inAddress)
			{
				
			}
		}

		// abstract classes cannot be intantiated and must if they are inherited from
		// the child class must define all methods/etc

		public abstract class Account
		{
			public abstract string RudeLetterString();
		}

	}
}
