using System;

namespace laba12
{
	class MainClass
	{
		static void vibor()
		{ 
			Console.WriteLine("Выбирете номер задачи(1 или 2):");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 1: first(); break;
				case 2: second(); break;
			}
		}
		static int[,] createmass(int n)
		{
			int[,] mass = new int[n, n];
			Console.WriteLine("Введите элементы матрицы:");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("Элемент с индексами[" + i + "," + j + "]=");
					mass[i, j] = int.Parse(Console.ReadLine());
				}
			}
			return mass;
		}

		static void first()
		{ 
			Console.WriteLine("Введите размерность квадратной матрицы:");
			int n = int.Parse(Console.ReadLine());
			int[,] mass = createmass(n);
			int max = mass[0,0];
			int x = 0;
			int y = 0;
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + mass[i, j]);
				}
			}
			Console.WriteLine();
			for (int i = 0; i < n/2; i++)
			{
				for (int j = i; j <= n - 1 - i; j++)
				{
					if (max < mass[i, j])
					{
						max = mass[i, j];
						x = i;
						y = j;
					}
				}
			}
			for (int i = n / 2; i < n; i++)
			{
				for (int j = n - 1 - i; j <= i; j++)
				{
					if (max < mass[i, j])
					{
						max = mass[i, j];
						x = i;
						y = j;
					}
				}
			}
			Console.WriteLine("Наибольший элемент в заштрихованной области: " + mass[x, y]);
			vibor();
		}
		static void second()
		{ 
			Console.WriteLine("Введите размерность квадратной матрицы:");
			int n = int.Parse(Console.ReadLine());
			int[,] mass = createmass(n);
			int summa = 0;
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + mass[i, j]);
				}
			}
			Console.WriteLine();
			for (int i = 0; i < n / 2; i++)
			{
				for (int j = i; j <= n - 1 - i; j++)
				{
					summa += mass[j, i];
				}
			}
			for (int i = n / 2; i < n; i++)
			{
				for (int j = n - 1 - i; j <= i; j++)
				{
					summa += mass[j, i];
				}
			}
			Console.WriteLine("Сумма элементовв заштрихованной области - " + summa);
		}


		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
