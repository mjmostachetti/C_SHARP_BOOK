using System;

namespace Application
{
	class MainClass
	{
		static void BigDood()
		{
			int i = 150;
			double f = 1234.56789;
			Console.WriteLine ("i: {0:0000} f: {1:00000.00}", i, f);
			Console.WriteLine ("i: {1} f: {0}", f, i);
		}

		static void doit()
		{
			Console.WriteLine ("Hello");
		}
		public static void Main()
		{
			doit ();
			doit ();
		}
	}
}
