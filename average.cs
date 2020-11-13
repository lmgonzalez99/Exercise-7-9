using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Average
{
	public static void Main()
	{
		double CountNumber = 0, SumAllNotes , NumberTimes = 0, average;
		string ValueInsert;
		Console.Write("Insert a mark (write end to end): ");
		ValueInsert = Console.ReadLine();
		while (ValueInsert != "end")
			{
			SumAllNotes = Convert.ToDouble(ValueInsert);
			NumberTimes++;
			CountNumber += SumAllNotes;  // sum of all the notes
			Console.Write("Insert a mark (write end to end): ");
			ValueInsert = Console.ReadLine();
			}
			if (NumberTimes != 0)
			{
				average = CountNumber / NumberTimes;
				Console.WriteLine("The average is {0}.", average);
				Console.ReadLine();
			}
	}
}
