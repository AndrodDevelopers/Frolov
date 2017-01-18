using System;
namespace laba3
{
	class Circle:Figure
	{
		protected int r;
		public Circle(int r)
		{
			this.r = r;
		}
		public override double Plos()
		{
			return Math.PI * Math.Pow(r, 2);
		}
		public override double Perim()
		{
			return 2 * Math.PI * r;
		}
		public override void Inf()
		{
			Console.WriteLine("Радиус круга: {0}", r);
		}
	}
}
