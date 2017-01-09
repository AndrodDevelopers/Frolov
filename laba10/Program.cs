using System;

namespace laba10
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбери номер задачи:");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 1: first(); break;
				case 2: second(); break;
				case 3: third(); break;
					
			}
		}

		static void first()
		{
			Console.WriteLine("Введите размерность одномерного массива:");
			int n = int.Parse(Console.ReadLine());
			int[] mass = new int[n];
			Random rand = new Random();
			Console.WriteLine("Заполним массив рандомными значениями. Вот что у нас получилось:");
			for (int i = 0; i < n; i++)
			{
				mass[i] = rand.Next(-99, 99);
				Console.Write(" " + mass[i]);
			}
			//Начало 1.1
			Console.WriteLine();
			//Массив интервала
			Console.WriteLine("Введите интервал от:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("До:");
			int b = int.Parse(Console.ReadLine());
			int[] chisla = new int[b - a + 1];
			for (int i = a; i <= b; i++)
			{
				chisla[i - a] = i;
			}
			//Конец массив интервала
			Console.WriteLine();
			Console.WriteLine("Заменим все значения на 0 которые попадают в интервал от " + a + " до " + b + ":");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < chisla.Length - 1; j++)
				{
					if (mass[i] == chisla[j])
					{
						mass[i] = 0;
					}
				}
				Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			//Конец 1.1; Начало 1.2
			Console.WriteLine("Заполним массив рандомными значениями. Вот что у нас получилось:");
			for (int i = 0; i < n; i++)
			{
				mass[i] = rand.Next(-99, 99);
				Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			Console.WriteLine("Заменим все отрицательные элементы не кратные 3 на противоположные:");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] < 0 && mass[i] % 3 != 0)
				{
					mass[i] -= mass[i] * 2;
					Console.Write(" " + mass[i]);
				} else Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			//Конец 1.2; Начало 1.3
			Console.WriteLine("Введите число:");
			int q = int.Parse(Console.ReadLine());
			Console.WriteLine("Все элементы которые меньше заданного числа увеличели в 2 раза:");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] < q)
				{
					mass[i] *= 2;
					Console.Write(" " + mass[i]);
				}
				else Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			//Конец 1.3; Начало 1.4
			double result = 0;
			Console.WriteLine("Считаем среднее арифметическое элементов:");
			for (int i = 0; i < n; i++)
			{
				result += mass[i];
			}
			result = result / n;
			Console.WriteLine(result);
			Console.WriteLine();
			//Конец 1.4; Начало 1.5
			double result2 = 0;
			int kol = 0;
			Console.WriteLine("Считаем среднее арифметическое отрицательных элементов:");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] < 0)
				{
					result2 += mass[i];
					kol++;
				}
			}
			result2 = result2 / kol;
			Console.WriteLine(result2);
			Console.WriteLine();
			//Конец 1.5; Начало 1.6
			int kol2 = 0;
			Console.WriteLine("Считаем количество нечетных элементов:");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] % 2 != 0) kol2++;
			}
			Console.WriteLine(kol2);
			Console.WriteLine();
			//Конец 1.6; Начало 1.7
			int result3 = 0;
			Console.WriteLine("Сумма элементов в интервале от " + a + " до " + b + ":");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] >= a && mass[i] <= b)
				{
					result3 += mass[i];
				}
			}
			Console.WriteLine(result3);
			Console.WriteLine();
			//Конец 1.7; Начало 1.8
			int result4 = 0;
			Console.WriteLine("Подсчитать сумму элементов, кратных 9:");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] % 9 == 0)
				{
					result4 += mass[i];
				}
			}
			Console.WriteLine(result4);
			Console.WriteLine();
			//Конец 1.8; Начало 1.9
			int result5 = 0;
			Console.WriteLine("Сумма элементов вне интервала от " + a + " до " + b + ":");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] <= a || mass[i] >= b)
				{
					result5 += mass[i];
				}
			}
			Console.WriteLine(result5);
			Console.WriteLine();
			//Конец 1.9; Начало 1.10
			Console.WriteLine("Вывести на экран номера всех элементов больших заданного числа:");
			for (int i = 0; i < n; i++)
			{
				if (mass[i] > q)
				{
					Console.Write(" " + i);
				}
			}
			Console.WriteLine();
		}
		static void second()
		{
			Console.WriteLine("Введите размерность одномерного массива:");
			int n = int.Parse(Console.ReadLine());
			double[] mass = new double[n];
			Random rand = new Random();
			Console.WriteLine("Заполним массив рандомными значениями. Вот что у нас получилось:");
			for (int i = 0; i < n; i++)
			{
				mass[i] = rand.Next(-2, 2);
				Console.Write(" " + mass[i]);
			}
			//Задача 2.1;
			Console.WriteLine();
			Console.WriteLine("Вывести на экран номера всех минимальных элементов:");
			double minel = mass[0];
			int j = 0;
			for (int i = 0; i < n; i++)
			{
				if (minel > mass[i])
				{
					minel = mass[i];
					j = i;
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (mass[j] == mass[i]) 
				{
					Console.Write(" " + (i + 1));
				}
			}
			Console.WriteLine();
			//Задача 2.2;
			Console.WriteLine("Заменить все максимальные элементы на 0:");
			double maxel = mass[0];
			int p = 0;
			for (int i = 0; i < n; i++)
			{
				if (maxel < mass[i])
				{
					p = i;
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (mass[p] == mass[i])
				{
					mass[i] = 0;
				}
			}
			for (int i = 0; i < n; i++)
			{
				Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			//Задача 2.3;
			Console.WriteLine("Заменить все минимальные элементы на противоположные:");
			double min = mass[0];
			int l = 0;
			for (int i = 0; i < n; i++)
			{
				if (min > mass[i])
				{
					l = i;
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (mass[l] == mass[i])
				{
					mass[i] *= -1;
				}
			}
			for (int i = 0; i < n; i++)
			{
				Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			//Задача 2.4;
			Console.WriteLine("Поменять местами максимальный и первый:");
			double max = mass[0];
			int k = 0;
			for (int i = 0; i < n; i++)
			{
				if (max < mass[i])
				{
					max = mass[i];
					k = i;
				}
			}
			mass[k] = mass[0];
			mass[0] = max;
			for (int i = 0; i < n; i++)
			{
				Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			//Задача 2.5;
			Console.WriteLine("Заполним массив рандомными значениями. Вот что у нас получилось:");
			for (int i = 0; i < n; i++)
			{
				mass[i] = rand.Next(-2, 2);
				Console.Write(" " + mass[i]);
			}
			Console.WriteLine();
			Console.WriteLine("Вывести на экран номера всех элементов, не совпадающих с максимальным:");
			double max2 = mass[0];
			int o = 0;
			for (int i = 0; i < n; i++)
			{
				if (max2 < mass[i])
				{
					max2 = mass[i];
					o = i;
				}
			}
			for (int i = 0; i < n; i++)
			{
				if (mass[o] != mass[i]) Console.Write(" " + (i + 1));
			}
			Console.WriteLine();
			//Задача 2.6;
			Console.WriteLine("Найти номер первого минимального элемента:");
			double fmin = mass[0];
			int h = 0;
			for (int i = 0; i < n; i++)
			{ 
				if (fmin > mass[i])
				{
					fmin = mass[i];
					h = i;
				}
			}
			Console.WriteLine(h + 1);
			//Задача 2.7;
			Console.WriteLine("Найти номер последнего максимального элемента:");
			double lmax = mass[0];
			int y = 0;
			for (int i = 0; i < n; i++)
			{
				if (lmax <= mass[i])
				{
					lmax = mass[i];
					y = i;
				}
			}
			Console.WriteLine(y + 1);
			//Задача 2.8;
			Console.WriteLine("Найти номер первого максимального элемента:");
			double fmax = mass[0];
			int x = 0;
			for (int i = 0; i < n; i++)
			{
				if (fmax < mass[i])
				{
					fmax = mass[i];
					x = i;
				}
			}
			Console.WriteLine(x + 1);
			//Задача 2.9;
			Console.WriteLine("Найти номер последнего минимального элемента:");
			double lmin = mass[0];
			int f = 0;
			for (int i = 0; i < n; i++)
			{
				if (lmin >= mass[i])
				{
					lmin = mass[i];
					f = i;
				}
			}
			Console.WriteLine(f + 1);
			//Задача 2.10;
			Console.WriteLine("Найти максимум из отрицательных:");
			double maxotr = mass[0];
			int g = 0;
			for (int i = 0; i < n; i++)
			{
				if (maxotr <= mass[i] && mass[i] < 0)
				{
					maxotr = mass[i];
					g = i;
				}
			}
			Console.WriteLine(mass[g]);

		}
		static void third()
		{
			Console.WriteLine("Введите размерность массива nxn:");
			int n = int.Parse(Console.ReadLine());
			int[,] mass = new int [n,n];
			Random rand = new Random();
			Console.WriteLine("Заполним массив рандомными значениями. Вот что у нас получилось:");
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					mass[i, j] = rand.Next(-99, 99);
					Console.Write(" " + mass[i, j]);
				}
			}
			//Задача 3.1;
			int summa = 0;
			int sr = 0;
			Console.WriteLine("Подсчитать среднее арифметическое четных элементов, расположенных ниже главной диагонали.");
			for (int i = 0; i < n; i++)
			{
				for (int j= 0; j < n; j++)
				{
					if (j < i && mass[i, j] % 2 == 0)
					{
						summa += mass[i, j];
						sr += 1;
					}
				}
			}
			Console.WriteLine(summa/sr);
			//Задача 3.2;
			int summa1 = 0;
			Console.WriteLine("Подсчитать сумму элементов, расположенных на побочной диагонали.");
			for (int i = 0; i < n; i++)
			{
				summa1 += mass[i, n - i - 1];
			}
			Console.WriteLine(summa1);
			//Задача 3.3;
			Console.WriteLine("Среднее арифметическое элементов, над побочной диагональю.");
			int summa2 = 0;
			int sr1 = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (j < (n - i - 1))
					{
						summa2 += mass[i, j];
						sr1++;
					}
				}
			}
			Console.WriteLine(summa2/sr1);
			//Задача 3.4;
			int[,] masschange = new int[n, n];
			Console.WriteLine("Поменять столбцы местами(первый с последним, 2ой с предпоследним и т д).");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					masschange[j, i] = mass[j, n - i - 1];
				}
			}
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + masschange[i, j]);
				}
			}
			//Задача 3.5;
			Console.WriteLine("Поменять местами 2 строки. Если четное - то 2 средних, если нет то 1-ую и центральную.");
			int save = 0;
			if (n % 2 == 0)
			{
				for (int i = 0; i < n; i++)
				{
					save = mass[(n / 2 - 1), i];
					mass[(n / 2 - 1), i] = mass[(n / 2), i];
					mass[(n / 2), i] = save;
				}
			}
			else
			{
				for (int i = 0; i < n; i++)
				{
					save = mass[0, i];
					mass[0, i] = mass[(n / 2), i];
					mass[(n / 2), i] = save;
				}
			}
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + mass[i, j]);
				}
			}
			//Задача 3.6;
			Console.WriteLine("Вывести матрицу змейкой(1ую строку начиная с 1-го элемента, 2ую - с последнего, 3 - с 1-го и т д).");
			for (int i = 0; i < n; i++)
			{
				if (i == 0 || i % 2 == 0)
				{
					for (int j = 0; j < n; j++)
					{
						Console.Write(" " + mass[i, j]);
					}
				}
				else {
					for (int j = 0; j < n; j++)
					{
						Console.Write(" " + mass[i, (n - j - 1)]);
					}
				}
			}
			Console.WriteLine();
			//Задача 3.7;
			int hz = 0;
			string result = string.Empty;
			Console.WriteLine("Определить есть ли строка только с положительными элементами.");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (mass[i, j] > 0) hz+=1;
				}
				if (hz == n) result = "Есть!";
				hz = 0;
			}
			if (result == string.Empty)
			{
				Console.WriteLine("Нету");
			} else Console.WriteLine("Есть");
			//Задача 3.8;
			int hz1 = 0;
			string result1 = string.Empty;
			Console.WriteLine("Определить есть ли столбец только с отрицательными элементами.");
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (mass[j, i] < 0) hz1 += 1;
				}
				if (hz1 == n) result1 = "Есть!";
				hz1 = 0;
			}
			if (result1 == string.Empty)
			{
				Console.WriteLine("Нету");
			}
			else Console.WriteLine("Есть");
			//Задача 3.9;
			Console.WriteLine("В каждой строке найти максимум и заменить на противоположный.");
			int max = mass[0,0];
			int k = 0;
			int l = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (mass[i, j] >= max)
					{
						k = i;
						l = j;
						max = mass[i, j];
					}
				}
				mass[k, l] = mass[k, l] - mass[k, l] * 2;
				max = mass[i, 0];
			}
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + mass[i, j]);
				}
			}
			Console.WriteLine();
			//Задача 3.10;
			Console.WriteLine("В каждом столбце найти минимум и заменить на 0.");
			int min = mass[0, 0];
			int x = 0;
			int y = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (mass[j, i] <= min)
					{
						x = i;
						y = j;
						min = mass[j, i];
					}
				}
				mass[y, x] = 0;
				min = mass[0, i];
			}
			for (int i = 0; i < n; i++, Console.WriteLine())
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(" " + mass[i, j]);
				}
			}
		}




		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
