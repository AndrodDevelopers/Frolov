using System;
namespace laba33
{
	class Person:Telefon
	{
		protected string name;
		protected string adress;
		protected int number;

		public Person(string name, string adress, int number)
		{
			this.name = name;
			this.adress = adress;
			this.number = number;
		}
		public override void Inf()
		{
			Console.WriteLine("Фамилия: {0}", name);
			Console.WriteLine("Адрес: {0}", adress);
			Console.WriteLine("Номер телефона: {0}", number);
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
				return "МЫ НАШЛИ!!!\nФамилия: " + name + "\nАдрес: " + adress + "\nНомер телефона: " + number;
			}
			else return "";
		}
	}
}
