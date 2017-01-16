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
	}
}
