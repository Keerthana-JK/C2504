using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInterface
{
	internal class Program
	{
		interface IA 
		{
			void Show();
		}
		interface IB : IA { }
		interface IC : IA { }
		public class X : IB, IC
		{
			public void Show()
			{
				System.Console.WriteLine("from IA");
			}
		}
		static void Main(string[] args)
		{
			X x = new X();
			x.Show();
		}
	}
}
