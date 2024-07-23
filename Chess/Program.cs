using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int size = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < size * size; i++)
			{
				for (int j = 0; j < size * size; j++)
				{
					if (i / size % 2 == j / size % 2)
					{
						Console.Write("* ");
					}
					else
					{
						Console.Write("  ");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
