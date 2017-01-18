using System;
namespace laba33
{
	class Friend:Person
	{
		protected int day;
		protected int month;
		protected int year;

		public Friend(string name, string adress, int number, int day, int month, int year):base(name, adress, number)
		{
			this.day = day;
			this.month = month;
			this.year = year;
		}
		public override void Inf()
		{
			Console.WriteLine("Фамилия друга: {0}", name);
			Console.WriteLine("Адрес друга: {0}", adress);
			Console.WriteLine("Номер телефона: {0}", number);
			Console.WriteLine("Дата рождения: {0}.{1}.{2}", day, month, year);
			Console.WriteLine();
		}
		public override string Search(string searchname)
		{
			char[] mass1 = name.ToCharArray();
			char[] mass2 = searchname.ToCharArray();
			int k = 0;
			if (mass1.Length == mass2.Length)
			{
				for (int i = 0; i < mass1.Length; i++)
				{
					if (char.ToLower(mass1[i]) == char.ToLower(mass2[i]))
					{
						k++;
					}
				}
			}
			if (k == mass1.Length)
			{
				return "МЫ НАШЛИ!!!\nФамилия: " + name + "\nАдрес: " + adress + "\nНомер телефона: " + number + "\nДата рождения " + day + "." + month + "." + year + "\n";
			}
			else return "";
		}
	}
}
