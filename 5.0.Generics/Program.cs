using System;

namespace Generics
{
	class MainClass
	{
		// arrarylists allow us to add and remove array elements without specifying
		// 

		ArrayList store = new ArrayList();
		// can also do this without disrupting the min/max size
		ArrayList storeFifty = new ArrayList(50);

		Account robsAccount = new Account();
		store.Add(robsAccount);

		// this won't work as we don't type cast it, it just thinks it is a generic object
		Account a = store[0];
		a.PayInFunds(50);

		// this would work though
		Account a = (Account) store[0];
		a.PayInFunds(50);

		// this would cause problems as we don't know that all objects
		// in the arraylist are of the object type that we want
		KitchenSink k = new KitchenSink();
		store.Add(k);

		// find out how many items are in the arraylist
		if(store.Count == 0)
		{
			Console.WriteLine("The bank is empty");
		}

		// another trick to check if something is in the arraylist
		if(a.Contains(robsAccount)){
			Console.WriteLine("Rob is in the bank");
		}

		// Lists are like arraylists but they are also TYPESAFE!!!
		// The thing between the < > tells us what type is being stored
		List<Account> accountList = new List<Account>();
		List<int> scores = new List<int>();

		// no need to cast the results
		accountList[0].PayInFunds(50);

		// you can add, count, remove itmes from Lists

		// Just like Arraylist has Lists, Hashtable has a more powerful cousin Dictionary
		Dictionary<string,Account> accountDictionary = new Dictionary<string, Account>();

		accountDictionary.Add("Rob", robsAccount);

		// again no need to type case
		d['Rob'].PayInFunds(50);

	}
}
