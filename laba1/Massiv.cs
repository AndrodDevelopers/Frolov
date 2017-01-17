using System;
namespace laba1
{
	public class Massiv
	{
		int[] IntArray;
		int n;

		public Massiv(){ }
		public Massiv(int n)
		{
			this.n = n;
			IntArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				IntArray[i] = 0;
			}
		}
		public Massiv(int n, int a, int b)
		{ 
			this.n = n;
			Random r = new Random();
			IntArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				IntArray[i] = r.Next(a, b);
			}
		}
		public Massiv(int a, int b)
		{
			n = b - a + 1;
			IntArray = new int[n];
			for (int i = 0; i < n; i++)
			{
				IntArray[i] = a;
				a++;
			}
		}
		public int[] CreateMass()
		{ 
			Console.Write("Введите размерность массива:");
			n = int.Parse(Console.ReadLine());
			IntArray = new int[n];
			for (int i = 0; i < IntArray.Length; i++)
			{
				Console.Write("Введите элемент №" + (i + 1) + ":");
				IntArray[i] = int.Parse(Console.ReadLine());
			}
			return IntArray;
		}
		public void PrintMass()
		{
			for (int i = 0; i < IntArray.Length; i++)
			{
				Console.Write(" " + IntArray[i]);
			}
			Console.WriteLine();
		}
		public void SortMass()
		{
			Array.Sort(IntArray);
			Array.Reverse(IntArray);
			for (int i = 0; i < IntArray.Length; i++)
			{
				Console.Write(" " + IntArray[i]);
			}
			Console.WriteLine();
		}
		public void plusminus()
		{
			for (int i = 0; i < IntArray.Length; i++)
			{
				IntArray[i] += 1;
				Console.Write(" " + IntArray[i]);
			}
			Console.WriteLine();
			for (int i = 0; i < IntArray.Length; i++)
			{
				IntArray[i] -= 1;
				Console.Write(" " + IntArray[i]);
			}
		}
		public void proverka()
		{
			int sum = 0;
			for (int i = 1; i < IntArray.Length; i++)
			{
				if (IntArray[i] > IntArray[i - 1])
				{
					sum++;
				}
			}
			if (sum == IntArray.Length - 1)
			{
				Console.WriteLine("Упорядочен");
			}
			else Console.WriteLine("Не Упорядочен");
		}
		public void mnoj()
		{
			Console.WriteLine("Введите число: ");
			int t = int.Parse(Console.ReadLine());
			for (int i = 0; i < IntArray.Length; i++)
			{
				IntArray[i] *= t;
				Console.Write(" " + IntArray[i]);
			}
		}
	}
}
