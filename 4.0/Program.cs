using System;

//enum
enum AccountState
{
	New,
	Active,
	UnderAudit,
	Frozen,
	Closed
};

//structure
struct Account 
{
	public AccountState State;
	public string Name;
	public string Address;
	public int AccountNumber;
	public int Balance;
	public int Overdraft;
};

class BankProgram
{
	public static void Main()
	{
		Account RobsAccount;
		RobsAccount.State = AccountState.Active;
		RobsAccount.Name = "Rob Miles";
		RobsAccount.Address = "His house";
		RobsAccount.AccountNumber = 1234;
		RobsAccount.Balance = 0;
		RobsAccount.Overdraft = -1000;
		Console.WriteLine ("Name is : " + RobsAccount.Name);
		Console.WriteLine ("Balance is : " + RobsAccount.Balance);
	}
		
}

class Account
{
	public string Name;
}

class StructsAndObjectsDemo
{
	public static void Main()
	{
		//reference to RobsAccount
		Account RobsAccount;
		//actually creating RobsAccount
		RobsAccount = new Account ();
		RobsAccount.Name = "Rob";
		Console.WriteLine (RobsAccount.Name);
	}
}

class Account
{
	//can be modified
	//public decimal Balance;
	// can't be modified
	private decimal balance;

	//this is how you can change it
	public bool WithdrawFunds(decimal amount)
	{
		if (balance < amount) {
			return false;
		}
		balance = balance - amount;
		return true;
	}

	public void PayInFunds(decimal amount)
	{
		balance = balance + amount;
	}

	public decimal GetBalance()
	{
		return balance;
	}
}

class Bank
{
	public static void Main()
	{
		Account RobsAccount;
		RobsAccount = new Account ();
		if (RobsAccount.WithdrawFunds (5)) {
			Console.WriteLine ("Cash Withdrawn");
		} else {
			Console.WriteLine ("Insufficient Funds");
		}

		//test
		Account test = new Account();
		test.PayInFunds (50);
		if (test.GetBalance () != 50) {
			Console.WriteLine ("Pay In test failed");
		}
	}
}

// A STATIC MEMEBER IS A MEMBER OF THE CLASS, BUT NOT A MEMBER OF
// AN INSTANCE OF THE CLASS
	

public class Account
{
	public decimal Balance;
	public static decimal InterestRateCharged;
}

Account RobsAccount = new Account();
RobsAccount.Balance = 100;
Account.InterestRateCharged = 10;
	
// Static methods are useful since you don't need an instance of the object

if(Account.AccountAllowed(25000,21))
{
	Console.WriteLine("Allowed Account");
}

//always make sure static methods are only accessing static variables
public class Account 
{ 
	private static decimal minIncome ; 
	private static int minAge ; 
	public static bool AccountAllowed(decimal income, int age) 
	{ 
		if ( ( income >= minIncome) && ( age >= minAge) ) 
		{ 
			return true; 
		} else 
		{ 
			return false; 
		} 
	} 
}