using System;

namespace laba9
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбирете номер задачи:");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 1:
					Console.WriteLine("Введите x=");
					double x = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите y=");
					double y = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите z=");
					double z = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите v=");
					double v = double.Parse(Console.ReadLine());
					Console.WriteLine(min(min(x, y), min(z, v)));
					vibor();
					break;
				case 2:
					Console.WriteLine("Введите q=");
					double q = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите w=");
					double w = double.Parse(Console.ReadLine());
					Console.WriteLine("Максимум - {0}", max(q, w));
					double e = max(q, 2 * w - q) + max(5 * q + 3 * w, w);
					Console.WriteLine("Z=" + e);
					vibor();
					break;
				case 3:
					Console.WriteLine("Введите a=");
					double p = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите b=");
					double o = double.Parse(Console.ReadLine());
					Console.WriteLine(max(f(p), f(o)));
					vibor();
					break;
				case 4:
					Console.WriteLine("Введите a=");
					double l = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите b=");
					double k = double.Parse(Console.ReadLine());
					Console.WriteLine(min(f2(l), f2(k)));
					vibor();
					break;
				case 5:
					Console.WriteLine("Введите a=");
					double n = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите b=");
					double m = double.Parse(Console.ReadLine());
					Console.WriteLine("Введите h=");
					double h = double.Parse(Console.ReadLine());
					for (double i = n; i <= m; i += h)
					{
						Console.WriteLine("{0}={1:f4}", i, f3(i));
					}
					vibor();
					break;
				case 6:
					Console.WriteLine("Ничего вводить не нужно. Тут задание с перегрузкой так что я присвоил значения сам.");
					double u = 10, c;
					Console.WriteLine(f3(u, out c));
					vibor();
					break;
			}
		}
		static double min(double a, double b)
		{
			if (a > b) return b;
			else return a;
		}
		static double max(double a, double b)
		{
			if (a > b) return a;
			else return b;
		}
		static double f(double a)
		{
			return Math.Pow(a, 3) - Math.Sin(a);
		}
		static double f2(double a)
		{
			return Math.Cos(2 * a) + Math.Sin(a - 3);
		}
		static double f3(double a)
		{
			double y;
			if (Math.Abs(a) < 3) y = Math.Sin(a);
			else if (Math.Abs(a) >= 3 && Math.Abs(a) <= 9) y = Math.Sqrt(Math.Pow(a, 2) + 1) / Math.Sqrt(Math.Pow(a, 2) + 5);
			else y = Math.Sqrt(Math.Pow(a, 2) + 1) - Math.Sqrt(Math.Pow(a, 2) + 5);
			return y;
		}
		static double f3(double a, out double b)
		{
			double y = b = 10;
			//if (Math.Abs(a) < 3) y = Math.Sin(a);
			//else if (Math.Abs(a) >= 3 && Math.Abs(a) <= 9) y = Math.Sqrt(Math.Pow(a, 2) + 1) / Math.Sqrt(Math.Pow(a, 2) + 5);
			//else y = Math.Sqrt(Math.Pow(a, 2) + 1) - Math.Sqrt(Math.Pow(a, 2) + 5);
			return y;
		}

		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
