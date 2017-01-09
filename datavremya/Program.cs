using System;

namespace datavremya
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] vis = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			int[] niz = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			Console.WriteLine("Введите год:");
			int year = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите месяц:");
			int mon = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите день:");
			int day = int.Parse(Console.ReadLine());
			//Сколько с начала
			int sum = 0;
			if (year % 4 == 0)
			{
				for (int i = 0; i < mon - 1; i++)
				{
					sum += vis[i];
				}
			}
			else
			{ 
				for (int i = 0; i < mon - 1; i++)
				{
					sum += niz[i];
				}
			}
			Console.WriteLine("С начала года прошло дней: " + (sum + day - 1));
			//Сколько до конца
			int sum1 = 0;
			if (year % 4 == 0)
			{
				for (int i = mon - 1; i < vis.Length - 1; i++)
				{
					sum1 += vis[i];
				}
				sum1 += vis[mon - 1] - day + 1;
			}
			else
			{
				for (int i = mon - 1; i < niz.Length - 1; i++)
				{
					sum1 += niz[i];
				}
				sum1 += niz[mon - 1] - day + 1;
			}
			Console.WriteLine("До конца года осталось дней: " + sum1);
			//Дата пред дня
			int predday;
			int predmon;
			int predyear;
			if (year % 4 == 0)
			{
				predday = day - 1;
				if (predday == 0)
				{
					predmon = mon - 1;
					if (predmon == 0)
					{
						predmon = 11;
						predday = vis[predmon];
						predyear = year - 1;
						Console.WriteLine("День: " + predday + "Месяц: " + (predmon + 1) + "Год: " + predyear);
					}
					else
					{
						predday = vis[predmon - 1];
						Console.WriteLine("День: " + predday + "Месяц: " + predmon + "Год: " + year);
					}
				}
				else
				{
					Console.WriteLine("День: " + (day-1) + "Месяц: " + mon + "Год: " + year);
				}

			}
			else
			{
				predday = day - 1;
				if (predday == 0)
				{
					predmon = mon - 1;
					if (predmon == 0)
					{
						predmon = 11;
						predday = niz[predmon];
						predyear = year - 1;
						Console.WriteLine("День: " + predday + " Месяц: " + (predmon + 1) + " Год: " + predyear);
					}
					else
					{
						predday = niz[predmon - 1];
						Console.WriteLine("День: " + predday + " Месяц: " + predmon + " Год: " + year);
					}
				}
				else
				{
					Console.WriteLine("День: " + (day - 1) + " Месяц: " + mon + " Год: " + year);
				}

			}
			//Дата след дня
			int nextday;
			int nextmon;
			int nextyear;
			if (year % 4 == 0)
			{
				nextday = day + 1;
				if (nextday > vis[mon - 1])
				{
					nextmon = mon + 1;
					if (nextmon > 11)
					{
						nextmon = 1;
						nextday = 1;
						nextyear = year + 1;
						Console.WriteLine("День: " + nextday + " Месяц: " + nextmon + " Год: " + nextyear);
					}
					else
					{
						nextday = 1;
						Console.WriteLine("День: " + nextday + " Месяц: " + nextmon + " Год: " + year);
					}
				}
				else
				{
					Console.WriteLine("День: " + nextday + " Месяц: " + mon + " Год: " + year);
				}

			}
			else
			{
				nextday = day + 1;
				if (nextday > niz[mon - 1])
				{
					nextmon = mon + 1;
					if (nextmon > 11)
					{
						nextmon = 1;
						nextday = 1;
						nextyear = year + 1;
						Console.WriteLine("День: " + nextday + " Месяц: " + nextmon + " Год: " + nextyear);
					}
					else
					{
						nextday = 1;
						Console.WriteLine("День: " + nextday + " Месяц: " + nextmon + " Год: " + year);
					}
				}
				else
				{
					Console.WriteLine("День: " + nextday + " Месяц: " + mon + " Год: " + year);
				}

			}
		}
	}
}
