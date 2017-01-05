using System;

namespace laba7
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбирете номер задачи (1-5):");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 1: first(); break;
				case 2: second(); break;
				case 3: third(); break;
				case 4: fourth(); break;
				case 5: fifth(); break;
			}
		}
		static void first()
		{
			Console.WriteLine("FOR");
			for (int i = 60; i >= 10; i-=2)
			{
				Console.WriteLine(i);
			}
			Console.WriteLine("WHILE");
			int x = 60;
			while (x >= 10)
			{ 
				Console.WriteLine(x);
				x -= 2;
			}
			Console.WriteLine("DO | WHILE");
			int y = 60;
			do
			{
				Console.WriteLine(y);
				y -= 2;
			}
			while (y >= 10);
			vibor();
		}
		static void second()
		{
			Console.WriteLine("FOR");
			for (int i = 25; i <= 35; i++)
			{
				Console.WriteLine("{0} {1} {2}", i, i + 0.5, i - 0.2);
			}
			Console.WriteLine("WHILE");
			int x = 25;
			while (x <= 35)
			{
				Console.WriteLine("{0} {1} {2}", x, x + 0.5, x - 0.2);
				x++;
			}
			Console.WriteLine("DO | WHILE");
			int y = 25;
			do
			{
				Console.WriteLine("{0} {1} {2}", y, y + 0.5, y - 0.2);
				y++;
			}
			while (y <= 35);
			vibor();
		}
		static void third()
		{
			Console.WriteLine("Введите A:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите B:");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("FOR");
			for (int x = b; x >= a; x--)
			{
				Console.WriteLine("{0}", x * x * x);
			}
			Console.WriteLine("WHILE");
			int t = b;
			while (t >= a)
			{
				Console.WriteLine("{0}", t * t * t);
				t--;
			}
			Console.WriteLine("DO | WHILE");
			do
			{
				Console.WriteLine("{0}", b * b * b);
				b--;
			} while (b >= a);
			vibor();
		}
		static void fourth()
		{
			Console.WriteLine("Диапазон от:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("до:");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Которые оканчиваются на - ");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("или - ");
			int y = int.Parse(Console.ReadLine());
			Console.WriteLine("FOR");
			for (int i = a; i <= b; i++)
			{
				if (((i - x) % 10) == 0 || ((i - y) % 10) == 0)
				{
					Console.WriteLine(i);
				}
			}
			Console.WriteLine("WHILE");
			int t = a;
			while (t < b)
			{
				if (((t - x) % 10) == 0 || ((t - y) % 10) == 0)
				{
					Console.WriteLine(t);
				}
				t++;
			}
			Console.WriteLine("DO | WHILE");
			{
				do
				{
					if (((a - x) % 10) == 0 || ((a - y) % 10) == 0)
					{
						Console.WriteLine(a);
					}
					a++;
				} while (a <= b);
			}
			vibor();
		}
		static void fifth()
		{
			Console.WriteLine("FOR");
			for (int i = 100; i <= 999; i++)
			{
				int del = i / 100;
				if ((i - del) % 10 == 0)
				{
					Console.WriteLine(i);
				}
			}
			Console.WriteLine("WHILE");
			int t = 100;
			while (t <= 999)
			{ 
				int del = t / 100;
				if ((t - del) % 10 == 0)
				{
					Console.WriteLine(t);
				}
				t++;
			}
			Console.WriteLine("DO | WHILE");
			int o = 100;
			do
			{
				int del = o / 100;
				if ((o - del) % 10 == 0)
				{
					Console.WriteLine(o);
				}
				o++;
			} while (o <= 999);
			vibor();
		}


		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
