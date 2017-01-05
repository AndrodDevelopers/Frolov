using System;

namespace laba6
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбирете номер задачи (1 или 2):");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{ 
				case 1: first(); break;
				case 2: second(); break;
			}
		}
		static void first()
		{
			Console.WriteLine("Введите x=");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите t=");
			double t = double.Parse(Console.ReadLine());
			double z1 = (Math.Sin(Math.PI / 2 + 3 * a)) / (t - Math.Sin(3 * a - Math.PI));
			double z2 = 1 / Math.Tan(5 * Math.PI / 4 + 3 * a / 2);
			Console.WriteLine("z1={0}", z1);
			Console.WriteLine("z2={0}", z2);
			vibor();
		}
		static void second()
		{
			Console.WriteLine("Введите номер карты (6 - 14):");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine("Ввидете масть (1 - черви, 2 - пики, 3 - бубны, 4 - кресты): ");
			int mast = int.Parse(Console.ReadLine());
			String result = string.Empty;
			switch (number)
			{
				case 14: result += "Туз "; break;
				case 13: result += "Король "; break;
				case 12: result += "Дама "; break;
				case 11: result += "Валет "; break;
				case 10: result += "Десятка "; break;
				case 9: result += "Девятка "; break;
				case 8: result += "Восьмерка "; break;
				case 7: result += "Семерка "; break;
				case 6: result += "Шесть "; break;
			}
			switch (mast)
			{
				case 1: result += "червей"; break;
				case 2: result += "пик"; break;
				case 3: result += "бубен"; break;
				case 4: result += "крести"; break;
			}
			Console.WriteLine(result);
			vibor();
		}


		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
