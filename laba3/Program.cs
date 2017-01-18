using System;

namespace laba3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Figure[] fi = new Figure[3];
			fi[0] = new Rectangle(3, 5);
			fi[1] = new Circle(2);
			fi[2] = new Triangle(3, 3, 2);
			foreach (Figure x in fi)
			{
				x.Inf();
				Console.WriteLine("Площадь: {0:F2}", x.Plos());
				Console.WriteLine("Периметр: {0:F2}", x.Perim());
			}
		}
	}
}
