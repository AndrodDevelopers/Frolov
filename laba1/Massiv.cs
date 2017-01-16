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
	}
}
