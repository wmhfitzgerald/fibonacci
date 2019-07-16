using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Fibonacci
{
	public class Program
	{
		public String[] Source(int len)  
		{  
			ArrayList ar = new ArrayList();
			int a = 0;
			int b = 1;
			int c = 0;  
			
			ar.Add(a.ToString());
			ar.Add(b.ToString());
			
			for (int i = 2; i < len; i++)  
			{  
				c= a + b;  
				ar.Add(c.ToString()); 
				a= b;  
				b= c;  
			}  
			
			string[] strArray = ar.ToArray(typeof(string)) as string[];
			return strArray;
		}

		public static void Main()
		{
			Program p = new Program();
			string[] strArray = p.Source(31);
			foreach (string value in strArray)
			{
				Console.Write(" {0}", value); 
			}
		}
	}
}
