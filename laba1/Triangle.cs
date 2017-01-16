using System;
namespace laba1
{
	public class Triangle
	{
		int a;
		int b;
		int c;

		public Triangle(int a, int b, int c)
		{
			if (a + b > c && a + c > b && b + c > a)
			{
				this.a = a;
				this.b = b;
				this.c = c;
			}
			else Console.WriteLine("Треугольник не существует!");
		}
		public void Print()
		{
			Console.WriteLine("Длины сторон: {0}, {1}, {2},", a, b, c);
		}
		public void Perim()
		{
			Console.WriteLine("Периметр равен {0}", a + b + c);
		}
		public void Plos()
		{
			double p = (a + b + c) / 2;
			double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			Console.WriteLine("Площадь треугольника равна {0:F4}", S);
		}
	}
}
