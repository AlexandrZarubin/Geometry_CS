using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HardChess
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Console.OutputEncoding = System.Text.Encoding.UTF8;
#if false
			for (int symbolCode = 0; symbolCode < 10000; symbolCode++)
			{
				char symbol = (char)symbolCode;

				// Выводим символ для проверки
				Console.WriteLine($"Символ: {(char)symbolCode} (Код: {symbolCode})");
			} 
#endif
#if true
			//https://symbl.cc/ru/unicode-table/#box-drawing
			char UPPER_LEFT_ANGLE = (char)9484; 
			char UPPER_RIGHT_ANGLE = (char)9488;
			char LOWER_LEFT_ANGLE = (char)9492;
			char LOWER_RIGHT_ANGLE = (char)9496;
			char HORIZONTAL_LINE = (char)9472; 
			char VERTICAL_LINE = (char)9474;
			char BLACK_BOX = (char)9608;
			char WHITE_BOX = ' ';

			Console.Write("Введите размер фигуры: ");
			int size = Convert.ToInt32(Console.ReadLine());
			// Вывод шахматной доски
			for (int i = 0; i <= size * size; i++)
			{
				for (int j = 0; j <= size * size; j++)
				{
					// Вывод углов
					if (i == 0 && j == 0) Console.Write(UPPER_LEFT_ANGLE);
					else if (i == 0 && j == size * size) Console.Write(UPPER_RIGHT_ANGLE);
					else if (i == size * size && j == 0) Console.Write(LOWER_LEFT_ANGLE);
					else if (i == size * size && j == size * size) Console.Write(LOWER_RIGHT_ANGLE);
					// Вывод горизонтальных и вертикальных линий
					else if (i == 0 || i == size * size)
					{
						Console.Write(HORIZONTAL_LINE);
						Console.Write(HORIZONTAL_LINE);
					}
					else if (j == 0 || j == size * size)
					{
						Console.Write(VERTICAL_LINE);
					}
					// Вывод клеток
					else
					{
						// Определяем цвет клетки

						if(i / size % 2 == j / size % 2)
						{
							Console.BackgroundColor = ConsoleColor.White;
							Console.ForegroundColor = ConsoleColor.White;
							Console.Write(WHITE_BOX);
							Console.Write(WHITE_BOX);
							Console.ResetColor();
						}
						else
						{
							Console.BackgroundColor = ConsoleColor.Green;
							Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(BLACK_BOX);
                            Console.Write(BLACK_BOX);
							Console.ResetColor();
                        }
						
					}
				}
				Console.WriteLine();
			} 
#endif

		}
	}
}
