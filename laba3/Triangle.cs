using System;
namespace laba3
{
	class Triangle:Figure
	{
		protected int a;
		protected int b;
		protected int c;
		public Triangle(int a, int b, int c)
		{
			this.a = a;
			this.b = b;
			this.c = c;
		}
		public override double Plos()
		{
			double p = (a + b + c) / 2;
			double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			return S;
		}
		public override double Perim()
		{
			return a + b + c;
		}
		public override void Inf()
		{
			Console.WriteLine("Стороны треугольника: {0}, {1}, {2}", a, b, c);
		}
	}
}
