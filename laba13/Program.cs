using System;
using System.Text;
using System.IO;

namespace laba13
{
	class MainClass
	{
		static void vibor()
		{
			Console.WriteLine("Выбери номер задачи(1 = 1.1; 2 = 1.2; 3 = 2.1; 4 = 2.2):");
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
			BinaryWriter fileOut = new BinaryWriter(new FileStream("1.dat", FileMode.OpenOrCreate));
			Console.WriteLine("Введите размерность последовательности вещественных чисел:");
			int n = int.Parse(Console.ReadLine());
			int[] mass = new int[n];
			Console.WriteLine("Введите последовательность:");
			for (int i = 0; i < n; i++)
			{
				Console.Write("Число №" + (i + 1) + " :");
				mass[i] = int.Parse(Console.ReadLine());
				fileOut.Write(mass[i]);
			}
			fileOut.Close();
			//1.1 
			Console.WriteLine("Зайдайте число и я выведу все числа из файла, которые меньше введенного числа:");
			int small = int.Parse(Console.ReadLine());
			FileStream f = new FileStream("1.dat", FileMode.Open);
			BinaryReader fileIn = new BinaryReader(f);
			long kol = f.Length/4;
			for (int i = 0; i < kol; i++)
			{
				int p = fileIn.ReadInt32();
				if (p < small)
				{
					Console.Write(" " + p);
				}
			}
			fileIn.Close();
			f.Close();
			//End 1.1
			Console.WriteLine();
			//1.2
			f = new FileStream("1.dat", FileMode.Open);
			fileIn = new BinaryReader(f);
			kol = f.Length / 4;
			for (int i = 0; i < kol; i++)
			{
				int p = fileIn.ReadInt32();
				if (p > 0)
				{
					Console.Write(" " + p);
				}
			}
			f.Close();
			fileIn.Close();
			//End 1.2
			Console.WriteLine();
			//1.3
			f = new FileStream("1.dat", FileMode.Open);
			fileIn = new BinaryReader(f);
			kol = f.Length / 4;
			int summa = 0;
			int kol2 = 0;
			for (int i = 0; i < kol; i++)
			{
				int p = fileIn.ReadInt32();
				if (i % 2 == 0)
				{
					summa += p;
					kol2++;
				}
			}
			Console.Write(summa / kol2);
			f.Close();
			fileIn.Close();
		}

		static void second()
		{
			Console.WriteLine("Сколько будет целых чисел в первом файле?");
			int n1 = int.Parse(Console.ReadLine());
			BinaryWriter fIn1 = new BinaryWriter(new FileStream("f1.dat", FileMode.Create));
			Console.WriteLine("Введите эти числа:");
			for (int i = 0; i < n1; i++)
			{
				Console.Write("Число №" + (i + 1) + " :");
				fIn1.Write(int.Parse(Console.ReadLine()));
			}
			fIn1.Close();
			Console.WriteLine("Сколько будет целых чисел во втором файле?");
			int n2 = int.Parse(Console.ReadLine());
			BinaryWriter fIn2 = new BinaryWriter(new FileStream("f2.dat", FileMode.Create));
			Console.WriteLine("Введите эти числа:");
			for (int i = 0; i < n2; i++)
			{
				Console.Write("Число №" + (i + 1) + " :");
				fIn2.Write(int.Parse(Console.ReadLine()));
			}
			fIn2.Close();
			//Start 2.1
			FileStream f2 = new FileStream("f2.dat", FileMode.Open);
			BinaryReader fOut2 = new BinaryReader(f2);
			long dlina2 = f2.Length / 4;
			int[] mass2 = new int[dlina2];
			//Перепишем значения из файла в массив
			for (int i = 0; i < dlina2; i++)
			{
				mass2[i] = fOut2.ReadInt32();
			}
			int x = mass2[0];
			//Найдем минимальный элемент
			for (int i = 0; i < mass2.Length; i++)
			{
				if (x > mass2[i])
				{
					x = mass2[i];
				}
			}
			//Определим ближайшее значение элемента к минимальному
			int raznica = mass2[0] - x;
			int g = 0;
			if (raznica == 0)
			{
				do
				{
					g++;
					raznica = mass2[g] - x;
				} while (raznica == 0);
			}
			int j = 0;
			if (raznica != 0)
			{
				for (int i = 0; i < mass2.Length; i++)
				{
					if (raznica >= (mass2[i] - x) && (mass2[i] - x) != 0)
					{
						raznica = mass2[i] - x;
						j = i;
					}
				}
				Console.WriteLine("Минимальный элемент " + x);
				Console.WriteLine("Ближний к нему " + mass2[j]);
			}
			else 
			{ 
				Console.WriteLine("Все элементы одинаковые");
			}
			f2.Close();
			fOut2.Close();
			//End 2.1
			//Start 2.2
			FileStream f1 = new FileStream("f1.dat", FileMode.Open);
			BinaryReader fOut1 = new BinaryReader(f1);
			long dlina1 = f1.Length / 4;
			int poli = 0;
			int otr = 0;
			int nuli = 0;
			for (int i = 0; i < dlina1; i++)
			{
				int b = fOut1.ReadInt32();
				if (b > 0)
				{
					poli++;
				}
				else if (b == 0)
				{
					nuli++;
				}
				else if (b < 0)
				{
					otr++;
				}
			}
			f1.Close();
			fOut1.Close();
			f2 = new FileStream("f2.dat", FileMode.Open);
			fOut2 = new BinaryReader(f2);
			dlina2 = f2.Length / 4;
			for (int i = 0; i < dlina2; i++)
			{
				int y = fOut2.ReadInt32();
				if (y > 0)
				{
					poli--;
				}
				else if (y == 0)
				{
					nuli--;
				}
				else if (y < 0)
				{
					otr--;
				}

			}
			//Положительные
			if (poli > 0)
			{
				Console.WriteLine("Положительных больше в первом файле");
			}
			else if (poli == 0)
			{
				Console.WriteLine("Положительных одинаковое количество или их не существует вовсе");
			}
			else if (poli < 0)
			{ 
				Console.WriteLine("Положительных больше во втором файле");
			}
			//Отрицательные
			if (otr > 0)
			{
				Console.WriteLine("Отрицательных больше в первом файле");
			}
			else if (otr == 0)
			{
				Console.WriteLine("Отрицательных одинаковое количество или их не существует вовсе");
			}
			else if (otr < 0)
			{
				Console.WriteLine("Отрицательных больше во втором файле");
			}
			//Нули
			if (nuli > 0)
			{
				Console.WriteLine("Нулей больше в первом файле");
			}
			else if (nuli == 0)
			{
				Console.WriteLine("Нулей одинаковое количество или их не существует вовсе");
			}
			else if (nuli < 0)
			{
				Console.WriteLine("Нулей больше во втором файле");
			}
			f2.Close();
			fOut2.Close();
			//End 2.2
			//Start 2.3
			f1 = new FileStream("f1.dat", FileMode.Open);
			fOut1 = new BinaryReader(f1);
			dlina1 = f1.Length / 4;
			int[] mass1 = new int[dlina1];
			for (int i = 0; i < dlina1; i++)
			{
				mass1[i] = fOut1.ReadInt32();
			}
			int cset = 0;
			if (mass1[0] < mass1[1])
			{ 
				cset = 1;
			}
			for (int i = 1; i < mass1.Length; i++)
			{ 
				if (mass1[i] > mass1[i - 1])
				{
					cset++;
				}
			}
			if (cset == dlina1)
			{
				Console.WriteLine("Упорядоченны");
			}
			else
			{ 
				Console.WriteLine("Не Упорядоченны");
			}
			f1.Close();
			fOut1.Close();
			//End 2.3
			//Start 2.4
			f1 = new FileStream("f1.dat", FileMode.Open);
			fOut1 = new BinaryReader(f1);
			dlina1 = f1.Length / 4;
			int znak = 0;
			int znak1 = 0;
			int[] mass3 = new int[dlina1];
			for (int i = 0; i < dlina1; i++)
			{
				mass3[i] = fOut1.ReadInt32();
			}
			for (int i = 0; i < mass3.Length; i++)
			{
				if (mass3.Length > 1)
				{
					if (i % 2 == 0 && mass3[i] < 0 || i % 2 != 0 && mass3[i] >= 0)
					{
						znak++;
					}
					else if (i % 2 == 0 && mass3[i] >= 0 || i % 2 != 0 && mass3[i] < 0)
					{
						znak1++;
					}
				}
				else
				{
					Console.WriteLine("Последовательность должна быть больше 1 числа");
				}
			}
			if (znak == dlina1)
			{
				Console.WriteLine("Последовательность знакопеременная");
			}
			else if (znak1 == dlina1)
			{
				Console.WriteLine("Последовательность знакопеременная");
			}
			else
			{ 
				Console.WriteLine("Последовательность не знакопеременная");
			}
			f1.Close();
			fOut1.Close();
		}
		static void third()
		{
			Console.WriteLine("Введите предложение: ");
			StringBuilder predl = new StringBuilder(Console.ReadLine());
			StreamWriter pr = new StreamWriter(new FileStream("2(1).txt", FileMode.Create));
			string str = predl.ToString();
			char[] mass = str.ToCharArray();
			for (int i = 0; i < mass.Length; i++)
			{
				if (!char.IsNumber(mass[i]))
				pr.Write(mass[i]);
			}
			pr.Close();
			FileStream f = new FileStream("2(1).txt", FileMode.Open);
			StreamReader chit = new StreamReader(f);
			string text = chit.ReadToEnd();
			Console.WriteLine(text);
		}
		static void fourth()
		{
			//Есть файл slova.txt
			//1.1
			FileStream f = new FileStream("slova.txt", FileMode.Open);
			StreamReader slova = new StreamReader(f);
			string text = slova.ReadToEnd();
			Console.WriteLine(text);
			char[] sim = { ' ', ',', '!', '?', '.' };
			string[] mass = text.Split(sim);
			Console.Write("Введите букву, на которую начинаются слова: ");
			char b = char.Parse(Console.ReadLine());
			if (char.IsLetter(b))
			{
				for (int i = 0; i < mass.Length; i++)
				{
					if (char.ToLower(b) == char.ToLower(mass[i][0]))
					{
						Console.WriteLine(mass[i]);
					}
				}
			}
			else
			{
				Console.WriteLine(b + " не является буквой!!!");
			}
			slova.Close();
			f.Close();
			//Конец 1.1
			//Начало 1.2
			f = new FileStream("slova.txt", FileMode.Open);
			slova = new StreamReader(f);
			text = slova.ReadToEnd();
			Console.WriteLine(text);
			char[] sim1 = { ' ', ',', '!', '?', '.' };
			mass = text.Split(sim1);
			Console.Write("Введите число: ");
			int l = int.Parse(Console.ReadLine());
			for (int i = 0; i < mass.Length; i++)
			{
				if (l == mass[i].Length)
				{
					Console.WriteLine(mass[i]);
				}
			}
			slova.Close();
			f.Close();
			//1.2 Конец
			//1.3 Начало
			f = new FileStream("slova.txt", FileMode.Open);
			slova = new StreamReader(f);
			text = slova.ReadToEnd();
			Console.WriteLine(text);
			char[] sim2 = { ' ', ',', '!', '?', '.' };
			mass = text.Split(sim2);
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i][0] == mass[i][mass[i].Length - 1]) 
				{
					Console.WriteLine(mass[i]);
				}
			}
			slova.Close();
			f.Close();
			//1.3 Конец
			//1.4 Начало
			f = new FileStream("slova.txt", FileMode.Open);
			slova = new StreamReader(f);
			text = slova.ReadToEnd();
			Console.WriteLine(text);
			char[] sim3 = { ' ', ',', '!', '?', '.' };
			mass = text.Split(sim3);
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i][0] == mass[mass.Length - 1][0]) 
				{
					Console.WriteLine(mass[i]);
				}
			}
			slova.Close();
			f.Close();
		}

		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
