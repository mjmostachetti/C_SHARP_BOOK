using System;

public class Counter
{
	public int Data = 0;
	public void Count()
	{
		this.Data = Data + 1;
	}

	static void Main()
	{
		Counter c = new Counter ();
		c.Count ();
		string s1 = "Rob";
		string s2 = s1;
		s2 = "different";
		string s3 = "tom";
		string s4 = "tom";
		if(s3.Equals(s4))
		{
			Console.WriteLine("They are the same");
		}
		Console.WriteLine (s1 + " " + s2);
	}


	// if you need to do string editing, check out string builder

	public class StaffMember
	{
		private int age;
		public int GetAge()
		{
			return this.age;
		}

		public void SetAge(int inAge)
		{
			if ((inAge > 0) && (inAge < 120)) {
				this.age = inAge;
			}
		}
	}

	// Or....

	public class StaffMember
	{
		private int ageValue;

		public int Age
		{
			set
			{ 
				if((value > 0) && (value < 120))
				{
					this.ageValue = value;
				}
			}
			get
			{ 
				return this.ageValue;
			}
		}

		public int AgeInMonths
		{
			get
			{ 
				return this.ageValue * 12;
			}
		}
	}

	// with interfaces you can use get and set for
	interface IStaff
	{
		int Age
		{
			get;
			set;
		}
	}

	// a delegate is a stand in for a method
	// created like this

	public delegate decimal CalculateFee(decimal balance);

	// now it needs a method that returns a decimal and takes  a decimal as it's first argument

	public decimal RipOffFee(decimal balance)
	{
		if (balance < 0) {
			return 100;
		} else {
			return 1;
		}
	}

	CalculateFee calc = new CalculateFee(RipOffFee);

	fees = CalculateFee(100);

	calc = new CalculateFee(FriendlyFee);


}

