using System;

namespace laba8
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбирете номер задачи(1-12):");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 1: first(); break;
				case 2: second(); break;
				case 3: third(); break;
				case 4: fourth(); break;
				case 5: fifth(); break;
				case 6: sixth(); break;
				case 7: seventh(); break;
				case 8: eighth(); break;
				case 9: ninth(); break;
				case 10: tenth(); break;
				case 11: eleventh(); break;
				case 12: twelfth(); break;

			}
		}
		static void first()
		{
			for (int i = 1; i <= 10; i++, Console.WriteLine())
			{
				for (int j = 1; j <= 10; j++)
				{
					Console.Write(" " + j);
				}
			}
			vibor();
		}
		static void second()
		{
			for (int i = -10; i <= 12; i++, Console.WriteLine())
			{
				for (int j = -10; j <= 12; j++)
				{
					Console.Write(" " + j);
				}
			}
			vibor();
		}
		static void third()
		{
			int a = 41;
			for (int i = 0; i <= 3; i++, Console.WriteLine())
			{
				for (int j = a; j <= a + 9; j++)
				{
					Console.Write(" " + j);
				}
				a += 10;
			}
			vibor();
		}
		static void fourth()
		{
			int p = 5;
			for (int i = 1; i <= p; i++, Console.WriteLine())
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(p);
				}
			}
			vibor();
		}
		static void fifth()
		{
			int p = 1;
			for (int i = 1; i <= 5; i++, Console.WriteLine())
			{
				for (int j = 5; j >= i; j--)
				{
					Console.Write(p);
				}
			}
			vibor();
		}
		static void sixth()
		{
			for (int i = 1; i <= 5; i++, Console.WriteLine())
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" " + i);
				}
			}
			vibor();
		}
		static void seventh()
		{
			for (int i = 1; i <= 5; i++, Console.WriteLine())
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" " + i);
				}
			}
			vibor();
		}
		static void eighth()
		{
			for (int i = 1; i <= 5; i++, Console.WriteLine())
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" " + j);
				}
			}
			vibor();
		}
		static void ninth()
		{
			Console.WriteLine("Введите размерность доски:");
			int n = int.Parse(Console.ReadLine());
			int result = 0;
			for (int i = 1; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 2; j <= n; j += 2)
					{
						result += 1;
					}
				}
				else
				{
					for (int j = 1; j <= n; j += 2)
					{
						result += 1;
					}
				}
			}
			Console.WriteLine("Черных ячеек - " + result);
			vibor();
		}
		static void tenth()
		{
			Console.WriteLine("Введите номер ячейки:");
			int k = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите номер ячейки:");
			int m = int.Parse(Console.ReadLine());
			if (k % 2 == 0 && m % 2 == 0)
			{
				Console.WriteLine("Цвет ячейки - белый");
			}
			else
			{ 
				Console.WriteLine("Цвет ячейки - черный");
			}
			vibor();
		}
		static void eleventh()
		{
			Console.WriteLine("Введите номер первой ячейки:");
			int k1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите номер первой ячейки:");
			int m1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите номер второй ячейки:");
			int k2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите номер второй ячейки:");
			int m2 = int.Parse(Console.ReadLine());
			if (k1 % 2 == 0 && m1 % 2 == 0 && k2 % 2 == 0 && m2 % 2 == 0)
			{
				Console.WriteLine("Обе белые");
			}
			else if (k1 % 2 != 0 && m1 % 2 != 0 && k2 % 2 != 0 && m2 % 2 != 0)
			{
				Console.WriteLine("Обе черные");
			}
			else 
			{ 
				Console.WriteLine("Разного цвета");
			}
			vibor();
		}
		static void twelfth()
		{
			Console.WriteLine("Введите день:");
			int d = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите месяц:");
			int m = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите год:");
			int g = int.Parse(Console.ReadLine());
			Console.WriteLine("Наша дата " + d + "." + m + "." + g);
			Console.WriteLine("<3 <3 <3");
			vibor();
		}


		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
