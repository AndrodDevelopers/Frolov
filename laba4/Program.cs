using System;
using System.Text;
using System.IO;
using System.Collections;


namespace laba4
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
			}
		}
		static void first()
		{
			//1.1
			StreamWriter f = new StreamWriter(new FileStream("chislain.txt", FileMode.Create));
			Random ran = new Random();
			for (int i = 0; i < 10; i++)
			{
				f.WriteLine(ran.Next(-100, 100));
			}
			f.Close();
			FileStream fiOut = new FileStream("chislain.txt", FileMode.Open);
			StreamReader fileOut = new StreamReader(fiOut);
			Stack stck = new Stack();
			string line = string.Empty;
			while ((line = fileOut.ReadLine()) != null)
			{
				stck.Push(line);
			}
			fileOut.Close();
			fiOut.Close();
			f = new StreamWriter(new FileStream("chislaout.txt", FileMode.Create));
			while (stck.Count != 0)
			{
				f.WriteLine(stck.Pop());
			}
			f.Close();
			//1.2
			Console.WriteLine("Введите предложение: ");
			string a = Console.ReadLine();
			f = new StreamWriter(new FileStream("slova.txt", FileMode.Create));
			f.Write(a);
			f.Close();
			fileOut = new StreamReader(new FileStream("slova.txt", FileMode.Open));
			char[] bukvi = fileOut.ReadLine().ToCharArray();
			stck = new Stack();
			char[] glas = { 'а', 'о', 'у', 'э', 'ы', 'я', 'ю', 'е', 'и' };
			for (int i = 0; i < bukvi.Length; i++)
			{
				for (int j = 0; j < glas.Length; j++)
				{
					if (char.ToLower(bukvi[i]) == glas[j])
					{
						stck.Push(bukvi[i]);
					}
				}
			}
			while (stck.Count != 0)
			{
				Console.Write(stck.Pop() + " ");
			}
			vibor();
		}
		static void second()
		{ 
			//2.1
			Console.WriteLine("Введите предложение: ");
			string a = Console.ReadLine();
			StreamWriter f = new StreamWriter(new FileStream("slova2.txt", FileMode.Create));
			f.Write(a);
			f.Close();
			StreamReader fr = new StreamReader(new FileStream("slova2.txt", FileMode.Open));
			char[] sim = fr.ReadLine().ToCharArray();
			Queue qu = new Queue();
			for (int i = 0; i < sim.Length; i++) 
			{
				if (sim[i] != ' ' && !char.IsNumber(sim[i]))
				{
					Console.Write(sim[i] + " ");
				}
				else if (char.IsNumber(sim[i]))
				{
					qu.Enqueue(sim[i]);
				}
			}
			Console.WriteLine();
			while (qu.Count != 0)
			{
				Console.Write(qu.Dequeue() + " ");
			}
			//2.2
			f = new StreamWriter(new FileStream("chislaab.txt", FileMode.Create));
			Random ran = new Random();
			for (int i = 0; i < 10; i++)
			{
				f.Write(ran.Next(-100, 100) + " ");
			}
			f.Close();
			fr = new StreamReader(new FileStream("chislaab.txt", FileMode.Open));
			Console.WriteLine("Введите a: ");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите b: ");
			int y = int.Parse(Console.ReadLine());
			string[] l = (fr.ReadLine()).Split(' ');
			Queue q1 = new Queue();
			Queue q2 = new Queue();
			for (int i = 0; i < l.Length - 1; i++)
			{
				if (Int32.Parse(l[i]) > x && Int32.Parse(l[i]) < y)
				{
					Console.Write(Int32.Parse(l[i]) + " ");
				}
				else if (Int32.Parse(l[i]) < x)
				{
					q1.Enqueue(Int32.Parse(l[i]));
				}
				else if (Int32.Parse(l[i]) > y)
				{
					q2.Enqueue(Int32.Parse(l[i]));
				}
			}
			Console.WriteLine();
			while (q1.Count != 0)
			{
				Console.Write(q1.Dequeue() + " ");
			}
			Console.WriteLine();
			while (q2.Count != 0)
			{
				Console.Write(q2.Dequeue() + " ");
			}
			vibor();
		}


		public static void Main(string[] args)
		{
			vibor();
		}
	}
}
