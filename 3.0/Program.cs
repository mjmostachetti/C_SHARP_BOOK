using System;

class ReturnDemo
{
	static int sillyReturnPlus(int i)
	{
		i = i + 1;
		Console.WriteLine ("i is : " + i);
		return i;
	}

	public static void Main()
	{
		int res;
		res = sillyReturnPlus (5);
		Console.WriteLine ("res is : " + res);

		for (int i = 1; i < 10; i++) 
		{
			Console.WriteLine ("Hello");
		}
	}

	//this allos the parameter to create
	static void addOneToRefParam(ref int i)
	{
		i = i + 1;
		Console.WriteLine ("i is : " + i);
	}

	static void arrayz()
	{
		const int SCORE_SIZE = 1000;
		int[] scores = new int[SCORE_SIZE];
		for (int i = 0; i < 11; i++) {
			scores [i] = readInt ("Score : ", 0, 1000);
		}
		//2-d arrays
		int[,] board = new int[,] [3,10];
		string[] monthNames = new string[]
		{
			null,
			"Jan", "feb", 'march', 'april',
			'may','june','july','august',
			'september','october','november','december'
		};
		int[,] squareWeights = new int[3,3]
		{
			{1,0,1},
			{0,2,0},
			{1,0,1}
		};

		//convert string to int
		int age = int.Parse(ageString);

		//catching exceptions, when exception occurs, an exception object is created
		int age;
		try
		{
			age = int.Parse(ageString);
			Console.WriteLine("Thank You");
		}
		catch(Exception e)
		{
			Console.WriteLine("Invalid age value");
			Console.WriteLine(e.Message);
		}

		//nest try-catch, added a finally - always run whether or not exception is thrown
		try
		{
			try
			{
				
			}
			catch
			{
				throw new Exception("Boom");
			}
		}
		catch
		{
			
		}
		finally
		{
			
		}

		//swtich construction instead of multiple if statements
		switch(selection)
		{
			case 1:
				handleCasemend();
				break;
			case 2 :
				handleStandard();
				break;
			case 3 :
			handlePatio();
			break;
		default:
			Console.WriteLine("Invalid number");
			break;
		}

		//also this way with multiple cases that act as || type
		switch(command)
		{
		case "casemend" :
		case "c" :
			handleCasement();
			break;
		}

		//creating output stream
		StreamWriter writer;
		writer = new StreamWriter("test.txt");
		//write to file
		writer.WriteLine("Hello World");
		//close
		writer.Close();

		// tells us when we've reached the end of the file
		TextReader reader = new StreamReader("Test.txt");
		string line = reader.ReadLine();
		while(reader.EndOfStream == false)
		{
			string line = reader.ReadLine();
			Console.WriteLine(line);
		}
		reader.Close();

		//do this to stop C# from interpretting \ as control characters
		string path;
		path = @"c:\data\2009\November\sales.txt";

		//enums, good for storing state of things...
		enum SeaState
		{
			EmptySea,
			Attacked,
			Battleship,
			Cruiser,
			Submarine,
			RowingBoat
		};

		SeaState openSea;
		openSea = SeaState.EmptySea;

		enum AccountState
		{
			New,
			Active,
			UnderAudit,
			Frozen,
			Closed
		};

	}
}