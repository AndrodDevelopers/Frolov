using System;

namespace laba1
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбери номер задачи:");
			int number = int.Parse(Console.ReadLine());
			switch (number)
			{
				case 1: first(); break;
				case 2: second(); break;
				case 3: third(); break;
				case 4: fourth(); break;
			}
		}

		static void first()
		{ 
			Console.WriteLine("Введите размер первой стороны:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите размер второй стороны:");
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите размер третькй стороны:");
			int c = int.Parse(Console.ReadLine());
			Triangle tri = new Triangle(a, b, c);
			tri.Print();
			tri.Perim();
			tri.Plos();
			tri.plusminus();
			tri.proverka();
			tri.mnoj();
			string stroka = tri.KString();
			Console.WriteLine(stroka);
			vibor();
		}
		static void second()
		{
			Console.WriteLine("Введите размер первой стороны:");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите размер второй стороны:");
			int b = int.Parse(Console.ReadLine());
			Rectangle rec = new Rectangle(a, b);
			rec.Print();
			rec.Perim();
			rec.Plos();
			rec.plusminus();
			rec.proverka();
			rec.mnoj();
			string stroka = rec.KString();
			Console.WriteLine(stroka);
			vibor();
		}
		static void third()
		{
			Console.Write("Введите размерность массива:");
			int n = int.Parse(Console.ReadLine());
			Console.Write("Введите a:");
			int a = int.Parse(Console.ReadLine());
			Console.Write("Введите b:");
			int b = int.Parse(Console.ReadLine());
			Massiv mass1 = new Massiv(n);
			Massiv mass2 = new Massiv(n, a, b);
			Massiv mass3 = new Massiv(a, b);
			Massiv mass4 = new Massiv();
			mass1.PrintMass();
			mass2.PrintMass();
			mass3.PrintMass();
			mass4.CreateMass();
			mass4.PrintMass();
			Console.Write("Отсортированные массивы:");
			mass1.SortMass();
			mass2.SortMass();
			mass3.SortMass();
			mass4.SortMass();
			mass3.plusminus();
			mass3.proverka();
			mass3.mnoj();
			vibor();
		}
		static void fourth()
		{
			Console.WriteLine("Введите размер массива:");
			int n = int.Parse(Console.ReadLine());
			DMassiv dmass = new DMassiv(n);
			dmass.vvod();
			dmass.vivod();
			dmass.chislo();
			dmass.plusminus();
			dmass.mnoj();
			vibor();
		}

		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
