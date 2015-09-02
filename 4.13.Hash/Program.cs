using System;
using System.Collections;

namespace Hash
{
	class HashBank : IBank
	{
		Hashtable bankHashtable = new Hashtable();

		public IAccount FindAccount(string name)
		{
			return bankHashtable [name] as IAccount;
		}

		public bool StoreAccount(IAccount account)
		{
			bankHashtable.Add(account.GetName(),account)
			return true;
		}
	}
}
