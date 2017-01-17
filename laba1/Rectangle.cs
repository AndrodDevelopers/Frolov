using System;
namespace laba1
{
	public class Rectangle
	{
		int a, b;
		public Rectangle(int a, int b)
		{
			this.a = a;
			this.b = b;
		}
		public void Print()
		{
			Console.WriteLine("Длины сторон прямоугольника: {0}, {1}", a, b);
		}
		public void Perim()
		{
			Console.WriteLine("Периметр равен {0}", (a + b) * 2);
		}
		public void Plos()
		{
			Console.WriteLine("Площадь треугольника равна {0}", a * b);
		}
		public void plusminus()
		{
			a++;
			b++;
			Console.WriteLine("Длины сторон: {0}, {1}", a, b);
			a--;
			b--;
			Console.WriteLine("Длины сторон: {0}, {1}", a, b);
		}
		public void proverka()
		{
			if (a == b)
			{
				Console.WriteLine("Квадрат!");
			}
			else Console.WriteLine("Не квадрат!");
		}
		public void mnoj()
		{
			Console.WriteLine("Введите число: ");
			int t = int.Parse(Console.ReadLine());
			a *= t;
			b *= t;
			Console.WriteLine("Домножили: {0}, {1}", a, b);
		}
		public string KString()
		{
			return "Стороны: " + a + ", " + b + " ";
		}
	}
}
