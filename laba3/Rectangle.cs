using System;
namespace laba3
{
	class Rectangle:Figure
	{
		protected int x;
		protected int y;
		public Rectangle(int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public override double Plos()
		{
			return x * y;
		}
		public override double Perim()
		{
			return (x + y) * 2;
		}
		public override void Inf()
		{
			Console.WriteLine("Длины сторон прямоугольника: {0}, {1}", x, y);
		}
	}
}
