namespace AdventOfCode
{
	internal class Advent1
	{
		public static void Run()
		{
			Console.WriteLine("Advent 1");

			var lines = File.ReadAllLines("1\\Advent1.txt");

			List<int> leftList  = [];
			List<int> rightList = [];

			string[] split = [];
			foreach (var line in lines)
			{
				split = line.Split(' ', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);
				leftList.Add(int.Parse(split[0]));
				rightList.Add(int.Parse(split[1]));
			}

			leftList.Sort();
			rightList.Sort();

			int val   = 0;
			int total = 0;
			for (int i = 0; i < leftList.Count; i++)
			{
				val = leftList[i] - rightList[i];
				if (val < 0)
					val = -val;

				total += val;
			}

			Console.WriteLine(total);
		}
	}
}
