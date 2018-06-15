using System;
using System.Collections.Generic;

namespace NumberToBinary
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("please enter a whole number between 1 & 255 you wish to convert into binary");

			int Entry = 0;
			string BinaryAnswer = string.Empty;

			try
			{
				Entry = int.Parse(Console.ReadLine());
			}
			catch
			{
				Console.WriteLine("Invalid input");
			}

			int Number = Entry;

			List<int> BinaryList = new List<int> { };

			while (Number >= 1)
			{
				int remainder = Number % 2;
				Number = Number / 2;

				BinaryAnswer = remainder + BinaryAnswer;
			}

			Console.WriteLine(BinaryAnswer);
		}
	}
}