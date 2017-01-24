using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;

namespace lab555
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			StreamReader fileIn = new StreamReader(new FileStream("text.txt", FileMode.Open));
			string line = string.Empty;
			List <Word> words = new List <Word>();
			int numbStroka = 1;
			Regex r = new Regex(@"\w+");
			while ((line = fileIn.ReadLine()) != null) //пока поток не пуст
			{
				Match newWord = r.Match(line);
				while (newWord.Success)
				{
					Boolean temp = false;
					foreach (Word word in words)
					{
						if (word.getName().Equals(newWord.ToString().ToLower()))
						{
							temp = true;
							word.setCount(word.getCount() + 1);
							Boolean temp2 = false;
							foreach (int nomerS in word.getStroki())
							{
								if (nomerS == numbStroka)
								{
									temp2 = true;
								}
							}
							if (temp2 == false)
							{
								word.getStroki().Add(numbStroka);
							}

						}
					}
					if (temp.Equals(false))
					{
						words.Add(new Word(newWord.ToString().ToLower(), numbStroka));
					}
					newWord = newWord.NextMatch();
				}
				numbStroka++;
			}
			words.Sort(delegate (Word x, Word y)
			{
				if (x.getName() == null && y.getName() == null) return 0;
				else if (x.getName() == null) return -1;
				else if (y.getName() == null) return 1;
				else return x.getName().CompareTo(y.getName());
			});/*
			for (int i = 0; i < words.Count - 1; i++)
			{
				for (int j = i + 1; j < words.Count; j++)
				{
					if (words[j].getName().CompareTo(words[i].getName()) < 0)
					{
						Word tmp = words[i];
						words[i] = words[j];
						words[j] = tmp;
					}
				}
			}*/
			Char temps = words[0].getName()[0];
			Console.WriteLine(temps);
			foreach (Word wor in words)
			{
				if (!wor.getName()[0].Equals(temps))
				{
					temps = wor.getName()[0];
					Console.WriteLine(temps);
				}

				Console.Write(wor.getName() + " " + wor.getCount()+" | ");
				foreach (int numer in wor.getStroki())
				{
					Console.Write(numer + " ");
				}
				Console.Write("\n\r");
			}
		}
	}
}
