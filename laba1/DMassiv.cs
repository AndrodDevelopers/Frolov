using System;
namespace laba1
{
	public class DMassiv
	{
		int[,] IntArray;
		int n;

		public DMassiv(int n)
		{
			this.n = n;
			IntArray = new int[n, n];
		}
		public int[,] vvod()
		{ 
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("Введите a[" + i + "," + j + "]: ");
					IntArray[i, j] = int.Parse(Console.ReadLine());
				}
			}
			return IntArray;
		}
		public void vivod()
		{ 
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + IntArray[i, j]);
				}
			}
		}
		public void chislo()
		{
			Console.Write("Введите столбец: ");
			int stolb = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(" " + IntArray[i, stolb - 1]);
			}
		}
	}
}
