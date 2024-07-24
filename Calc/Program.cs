using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true) { 
			Console.Clear();
			double FirstValue, SecondValue;
			string action;
				try
				{
					Console.WriteLine("Введите число 1");
					FirstValue = double.Parse(Console.ReadLine());

					Console.WriteLine("Введите число 2");
					SecondValue = double.Parse(Console.ReadLine());
				}
				catch (Exception)
				{
                    Console.WriteLine("Не удалосб преоброзовать строку в число!");
					Console.ReadLine();
					continue;
                }
            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
			action = Console.ReadLine();

				switch (action)
				{
					case "+":
						Console.WriteLine($"{ FirstValue} + { SecondValue} = {FirstValue+SecondValue}") ;
						break;
					case "-":
						Console.WriteLine($"{ FirstValue} - { SecondValue} = {FirstValue-SecondValue}") ;
						
						break;
					case "*":
						Console.WriteLine($"{ FirstValue} * { SecondValue} = {FirstValue*SecondValue}") ;
						
						break;
					case "/":
						try
						{
							if (SecondValue == 0)
							{
								throw new DivideByZeroException();
							}
							Console.WriteLine($"{FirstValue} / {SecondValue} = {FirstValue / SecondValue}");
						}
						catch 
						{
							Console.WriteLine("Ошибка! Деление на ноль невозможно.");
						}
						
						break;
					default:
						Console.WriteLine("Ошибка! Неизвестное действие!");
						break;
				}
				Console.ReadLine();
			}
        }
	}
}
