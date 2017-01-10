using System;
using System.Text;

namespace laba11
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
			}	
		}
		static void first()
		{
			Console.WriteLine("Введите строку: ");
			StringBuilder a = new StringBuilder(Console.ReadLine());
			//Console.WriteLine("Полученная строка: " + a);
			//1.1 Подсчитывает количество букв в строке
			int summa = 0;
			for (int i = 0; i < a.Length;)
			{
				if (char.IsLetter(a[i]))
				{
					summa++;
					i++;
				}
				else
				{
					i++;
				}
			}
			Console.WriteLine("Букв в строке:" + summa);
			//1.2 Удваивает каждое вхождние заданного символа X
			Console.WriteLine("Введите символ, который будем удваивать: ");
			char x = char.Parse(Console.ReadLine());
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == x)
				{
					a.Insert(i + 1, x);
					i++;
				}
			}
			Console.WriteLine("Измененная строка: " + a);
			//1.3 Удаляет все символы Y
			Console.WriteLine("Введите сивмол, который будем удалять: ");
			char y = char.Parse(Console.ReadLine());
			for (int i = 0; i < a.Length;)
			{
				if (a[i] == y)
				{
					a.Remove(i, 1);
				}
				else
				{
					i++;
				}
			}
			Console.WriteLine("Измененная строка: " + a);
			//1.4 заменяет все вхождения подстроки substr1 на подстроку substr2
			Console.WriteLine("Введите строку: ");
			StringBuilder b = new StringBuilder(Console.ReadLine());
			Console.WriteLine("Введите подстроку, КОТОРУЮ будем заменять: ");
			string str1 = Console.ReadLine();
			Console.WriteLine("Введите подстроку, НА которую будем заменять: ");
			string str2 = Console.ReadLine();
			b = b.Replace(str1, str2);
			Console.WriteLine("Измененная строка: " + b);
			//1.5 Подсчитывает цифры
			Console.WriteLine("Введите строку с цифрами: ");
			StringBuilder c = new StringBuilder(Console.ReadLine());
			summa = 0;
			for (int i = 0; i < c.Length; i++)
			{
				if (char.IsNumber(c[i]))
				{
					summa++;
				}
			}
			Console.WriteLine("Количество цифр в строке: " + summa);
			vibor();
		}

		static void second()
		{ 
			Console.WriteLine("Введите строку: ");
			StringBuilder a = new StringBuilder(Console.ReadLine());
			//2.1 Вывести только те слова сообщения, которые содержат не более чем n букв
			string b = a.ToString();
			Console.WriteLine("Вывести только те слова сообщения, которые содержат не более чем n букв");
			Console.WriteLine("Введите n: ");
			int n = int.Parse(Console.ReadLine());
			char[] div = { '!', ' ', ',', '.', ':', '?'};
			string[] mass = b.Split(div);
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i].Length <= n && mass[i].Length != 0) 
				{
					Console.Write(" " + mass[i]);
				}
			}
			Console.WriteLine();
			//2.2 Вывести только те слова, которые начинаются с прописной буквы 
			Console.WriteLine("Вывести только те слова, которые начинаются с прописной буквы");
			for (int i = 0; i < mass.Length; i++)
			{
				if (char.IsLower(mass[i][0]) && mass[i].Length != 0)
				{
					Console.Write(" " + mass[i]);
				}
			}
			Console.WriteLine();
			//2.3 Подсчитать сколько слов, состоящих только из прописных букв, содержится в сообщении.
			Console.WriteLine("Подсчитать сколько слов, состоящих только из прописных букв, содержится в сообщении.");
			int summa1 = 0;
			int summa2 = 0;
			for (int i = 0; i < mass.Length; i++)
			{
				for (int j = 0; j < mass[i].Length; j++)
				{
					if (char.IsLower(mass[i][j]))
					{
						summa1++;
					}
					else 
					{
						summa1 = 0;
						break;
					}
				}
				if (summa1 == mass[i].Length)
				{
					summa2++;
					summa1 = 0;
				}
			}
			Console.WriteLine(summa2);
			//2.4 Найти самое длинное слово сообщения
			Console.WriteLine("Найти самое длинное слово сообщения:");
			int dlina = mass[0].Length;
			int k = 0;
			for (int i = 0; i < mass.Length; i++)
			{
				if (dlina < mass[i].Length)
				{
					k = i;
					dlina = mass[i].Length;
				}
			}
			Console.WriteLine(mass[k]);
			//2.5 Найти самое короткое слово сообщения
			Console.WriteLine("Найти самое короткое слово сообщения:");
			int korot = mass[0].Length;
			int l = 0;
			for (int i = 0; i < mass.Length; i++)
			{
				if (korot > mass[i].Length)
				{
					l = i;
					korot = mass[i].Length;
				}
			}
			Console.WriteLine(mass[l]);
		}

		static void third()
		{ 
			Console.WriteLine("Введите имя: ");
			StringBuilder a = new StringBuilder(Console.ReadLine());
			string aname = a.ToString();
			Console.WriteLine("Введите фамилию: ");
			StringBuilder b = new StringBuilder(Console.ReadLine());
			string bname = b.ToString();
			Console.WriteLine("Введите отчество: ");
			StringBuilder c = new StringBuilder(Console.ReadLine());
			string cname = c.ToString();
			string[,] alf = new string[2, 32] 
			{ 
				{ "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" },
				{ "1", "2", "3", "4", "5", "6", "7", "8", "9","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32" } 
			};
			char [] aname1 = aname.ToCharArray();
			char [] bname1 = bname.ToCharArray();
			char [] cname1 = cname.ToCharArray();
			int summa = 0;
			for (int i = 0; i < aname1.Length; i++)
			{
				for (int j = 0; j < alf.Length / 2; j++)
				{
					if (char.ToLower(aname1[i]) == char.Parse(alf[0, j])) 
					{
						summa += int.Parse(alf[1, j]);
					}
				}
			}
			for (int i = 0; i < bname.Length; i++)
			{
				for (int j = 0; j < alf.Length / 2; j++)
				{
					if (char.ToLower(bname1[i]) == char.Parse(alf[0, j]))
					{
						summa += int.Parse(alf[1, j]);
					}
				}
			}
			for (int i = 0; i < cname1.Length; i++)
			{
				for (int j = 0; j < alf.Length / 2; j++)
				{
					if (char.ToLower(cname1[i]) == char.Parse(alf[0, j]))
					{
						summa += int.Parse(alf[1, j]);
					}
				}
			}
			string summa2;
			char[] summa3;
			while (summa > 9)
			{
				summa2 = summa.ToString();
				summa3 = summa2.ToCharArray();
				summa = 0;
				for (int i = 0; i < summa3.Length; i++)
				{
					summa += summa3[i] - 48;

				}
			}
			Console.WriteLine(summa);
		}

		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
