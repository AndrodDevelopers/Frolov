using System;
using System.Collections;

namespace lab555
{
	public class Word
	{
		string name;
		int count;
		ArrayList stroki = new ArrayList();

		public Word(string name, int stroka)
		{
			this.name = name;
			this.count = 1;
			this.stroki.Add(stroka);
		}
		public String getName()
		{
			return name;
		}
		public void setName(String name)
		{
			this.name = name;
		}
		public int getCount()
		{
			return count;
		}
		public void setCount(int count)
		{
			this.count = count;
		}
		public ArrayList getStroki()
		{
			return stroki;
		}
		public void setStroki(ArrayList stroki)
		{
			this.stroki = stroki;
		}

	}
	}


