using System;

namespace test.hi
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine(string.Format("{0}hi.", Environment.NewLine));
			
			Console.Write(string.Format("{0}hit any key to exit.{0}", Environment.NewLine));
			Console.Read();
		}
	}
}