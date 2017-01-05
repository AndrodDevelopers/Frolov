using System;

namespace laba5
{
	class MainClass
	{
		static void vibor()
		{ 
			Console.WriteLine("Выбери номер задачи ( Начиная со второй ) или выбирете 0 если хотите закончить:");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 2: second(); break;
				case 3: third(); break;
				case 4: fourth(); break;
				case 5: fifth(); break;
				case 6: sixth(); break;
				case 7: seventh(); break;
				case 8: eighth(); break;
				case 9: ninth(); break;
				case 0: break;
			}
		}

		static void second()
		{
			Console.WriteLine("Введите x=");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите y=");
			int y = int.Parse(Console.ReadLine());
			Console.WriteLine("Результат: {0}+{1}={1}+{0}", x, y);
			vibor();
		}
		static void third()
		{
			Console.WriteLine("Введите x=");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите y=");
			int y = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите z=");
			int z = int.Parse(Console.ReadLine());
			Console.WriteLine("{0}+{1}+{2}={3}", x, y, z, x+y+z);
			vibor();
		}
		static void fourth()
		{
			Console.WriteLine("Введите x=");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите y=");
			double y = double.Parse(Console.ReadLine());
			Console.WriteLine("{0}*{1}={2:.#}", x, y, x * y);
			vibor();
		}
		static void fifth()
		{
			Console.WriteLine("Введите x=");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите y=");
			double y = double.Parse(Console.ReadLine());
			Console.WriteLine("{0}/{1}={2:.###}", x, y, x / y);
			vibor();
		}
		static void sixth()
		{
			Console.WriteLine("Введите x=");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите y=");
			double y = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите z=");
			double z = double.Parse(Console.ReadLine());
			Console.WriteLine("<{0}+{1}>+{2}={0}+<{1}+{2}>", x, y, z);
			vibor();
		}
		static void seventh()
		{
			Console.WriteLine("C format: 99 989.99 руб"); 
			Console.WriteLine("D9 format: 000099999"); 
			Console.WriteLine("E format: 3,141593E+000"); 
			Console.WriteLine("F format: 55555.667"); 
			Console.WriteLine("N format: 99 999,00"); 
			Console.WriteLine("X format: 1869f"); 
			Console.WriteLine("x format: 1869F"); 
			vibor();
		}
		static void eighth()
		{
			Console.WriteLine("X format: 12 -> {0:X}", 12);
			Console.WriteLine("X format: 12 -> {0:X}", 256);
			Console.WriteLine("X format: 12 -> {0:X}", 1001);
			Console.WriteLine("X format: 12 -> {0:X}", 123456789);
			vibor();
		}
		static void ninth()
		{
			Console.WriteLine("Однажды в студеную зимнюю пору\nЯ из лесу вышел\nБыл сильный мороз...\n           А.С. Пушкин");
			vibor();

		}

		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
