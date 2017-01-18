using System;

namespace laba33
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Telefon[] tel = new Telefon[7];
			tel[0] = new Person("Фролов", "Врублевского", 6201310);
			tel[1] = new Ogr("ЗОВ", "Держинского", 556677, 12345678, "Иванов");
			tel[2] = new Friend("Митюков", "Домбровского", 7778800, 1, 4, 1995);
			tel[3] = new Person("Говин", "Поповича", 4343543);
			tel[4] = new Friend("Микевич", "Советская", 6666666, 6, 12, 2000);
			tel[5] = new Friend("Сухотская", "Кабяка", 1234567, 14, 9, 1990);
			tel[6] = new Friend("Мальчик", "Щерса", 7654321, 28, 2, 1993);
			Console.WriteLine("КОГО БУДЕМ ИСКАТЬ? ");
			string searchname = Console.ReadLine();
			string result = string.Empty;
			foreach (Telefon x in tel)
			{
				x.Inf();
				if (result == string.Empty)
				{
					result = x.Search(searchname);
				}
			}
			Console.WriteLine(result);

		}
	}
}
