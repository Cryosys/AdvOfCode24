using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
	internal class Advent2
	{
		public static void Run()
		{
			Console.WriteLine("Advent2");

			var lines = File.ReadAllLines("1\\Advent1.txt");

			Dictionary<int, int> rightCol = new Dictionary<int, int>();
			List<int> leftList            = [];

			string[] split = [];
			foreach (var line in lines)
			{
				split = line.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
				leftList.Add(int.Parse(split[0]));
				int rightVal = int.Parse(split[1]);
				rightCol.TryGetValue(rightVal, out int dicVal);
				rightCol[rightVal] = ++dicVal;
			}

			int simScore = 0;
			foreach (int val in leftList)
			{
				rightCol.TryGetValue(val, out int rightVal);
				simScore += val * rightVal;
			}

			Console.WriteLine(simScore);
		}
	}
}
