#define SQUARE
#define TRIANGLE_1
#define TRIANGLE_2
#define TRIANGLE_3
#define TRIANGLE_4
#define CHESS_LITE
#define ROMBS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите размер фигуры: ");
			int size = Convert.ToInt32(Console.ReadLine());
#if SQUARE
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif //SQUARE

#if TRIANGLE_1
			for (int i = 1; i <= size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif//TRIANGLE_1

#if TRIANGLE_2
			for (int i = size; i > 0; i--)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif//TRIANGLE_2

#if TRIANGLE_3
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write("  ");
				}
				for (int k = size; k > i; k--)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif//TRIANGLE_3

#if TRIANGLE_4
			for (int i = 1; i <= size; i++)
			{
				for (int j = size; j > i; j--)
				{
					Console.Write("  ");
				}
				for (int k = 0; k < i; k++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif//TRIANGLE_

#if CHESS_LITE
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write(i % 2 == j % 2 ? "+ " : "- ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
#endif //CHESS_LITE

#if ROMBS
			int size1 = size;
			if(size%2!=0)//если число не четное
			{
				size1++;
			}
			for (int i = 0; i < size1; i++)
			{
				for (int j = 0; j < size1; j++)
				{
					// Главная диагональ верх
					if (i + j == (size1 - 1) / 2) Console.Write("/");
					// Побочная диагональ верх
					else if (i + size1 / 2 == j) Console.Write("\\");
					// Побочная диагональ низ
					else if (i - size1 / 2 == j) Console.Write("\\");
					// Главная диагональ низ
					else if (i + j - size1 / 2 == size1 - 1) Console.Write("/");
					// Пустое пространство
					else Console.Write(" ");
				}
				Console.WriteLine();
			} 
#endif //ROMBS
		}
	}
}
