using System;

// if implemented, must create methods for all below
public interface IAccount 
{
	void PayInFunds(decimal amount);
	bool WithdrawFunds(decimal amount);
	decimal GetBalance();
	string RudeLetterString();
}

// 'abstract' can't be instantiated, only inherited
public abstract class Account : IAccount
{
	private decimal balance = 0;

	public abstract string RudeLetterString();

	// remember virtual means it can be overridden
	public virtual bool WithdrawFunds(decimal amount)
	{
		if (balance < amount) {
			return false;
		}
		balance = balance - amount;
		return true;
	}

	public decimal GetBalance()
	{
		return balance;
	}

	public void PayInFunds(decimal amount)
	{
		balance = balance + amount;
	}
}

public class CustomerAccount : Account
{
	public override string RudeLetterString ()
	{
		return "You are overdrawn";
	}
}

public class BabyAccount : Account
{
	public override bool WithdrawFunds(decimal amount)
	{
		if (amount > 10) {
			return false;
		}
		return base.WithdrawFunds (amount);
	}

	public override string RudeLetterString ()
	{
		return "Tell daddy you are overdrawn";
	}
}

// if you can create an equals and a ToString method for each class that you write