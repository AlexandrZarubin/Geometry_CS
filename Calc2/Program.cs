using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double FirstValue, SecondValue;
			string action;
			Console.WriteLine("Введите число 1");
			FirstValue = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите число 2");
			SecondValue = double.Parse(Console.ReadLine());
			Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
			action = Console.ReadLine();


			if (action == "+")
				Console.WriteLine(FirstValue + SecondValue);
			else if (action == "-")
				Console.WriteLine(FirstValue - SecondValue);
			else if (action == "*")
				Console.WriteLine(FirstValue * SecondValue);
			else if (action == "/")
			{
				if (SecondValue == 0)
				{
					Console.WriteLine(0);
				}
				else
				{
					Console.WriteLine(FirstValue / SecondValue);
				}
			}
			else
			{
				Console.WriteLine("Ошибка! Неизвестное действие!");
			}
		}
	}
}
