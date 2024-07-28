using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Move
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random(); // Создание экземпляра класса Random для генерации случайных чисел
			int width = Console.WindowWidth;// Ширина области перемещения + получение размер кончсоли
			int height = Console.WindowHeight;// Высота области перемещения + получение размер кончсоли
			Console.SetBufferSize(width, height);
			int x = rand.Next(0, width);// Установка позиции курсора в координаты (x, y)
			int y = rand.Next(0, height);
			char BLACK_BOX = (char)9608;//Квадратик
			Console.CursorVisible = false;// Отключение видимости курсора в консоли
			while (true)
			{
				width = Console.WindowWidth;
				height = Console.WindowHeight;
				Console.Clear();// Очистка экрана перед каждым обновлением
				Console.SetCursorPosition(x, y);// Установка позиции курсора в координаты (x, y)
				Console.Write(BLACK_BOX);// Вывод символа квадратика на текущей позиции курсора
				Console.Write(BLACK_BOX);// Вывод символа квадратика на текущей позиции курсора
				Console.SetCursorPosition(0, Console.WindowHeight-1);
				Console.Write($"Coordinates: ({x}, {y})");
				ConsoleKey consolekey = Console.ReadKey(true).Key;// Считывание нажатой клавиши без отображения символа на экране
				switch (consolekey)
				{
					case ConsoleKey.W:
					case ConsoleKey.UpArrow:
						if (y > 0) y--;
						break;
					case ConsoleKey.S:
					case ConsoleKey.DownArrow:
						if (y < height - 1) y++;
						break;
					case ConsoleKey.A:
					case ConsoleKey.LeftArrow:
						if (x > 0) x--;
						break;
					case ConsoleKey.D:
					case ConsoleKey.RightArrow:
						if (x < width - 1) x++;
						break;
				}
			}
		}
	}
}


