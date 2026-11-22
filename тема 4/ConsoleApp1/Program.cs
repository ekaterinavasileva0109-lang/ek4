using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("умный калькулятор\n");

                try
                {
                    Console.Write("Введите первое число: ");
                    string input1 = Console.ReadLine();
                    double num1 = double.Parse(input1);

                    Console.Write("введите операцию (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    Console.Write("введите второе число: ");
                    string input2 = Console.ReadLine();
                    double num2 = double.Parse(input2); 

                    double result = 0;

                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                throw new DivideByZeroException("на ноль делить нельзя!");
                            }
                            result = num1 / num2;
                            break;
                        default:
                            throw new ArgumentException($"операция '{operation}' не поддерживается. введите +, -, *, /.");
                    }

                    Console.WriteLine($"\nрезультат: {num1} {operation} {num2} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine($"\n[ОШИБКА] {ex.Message}");
                    Console.WriteLine($"[где произошло]: {ex.TargetSite}");
                    
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"\n[ОШИБКА ВВОДА] вы ввели не число. пожалуйста, используйте цифры.");
                    Console.WriteLine($"[сообщение системы]: {ex.Message}");
                    
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"\n[ОШИБКА ОПЕРАЦИИ] {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\n[НЕИЗВЕСТНАЯ ОШИБКА] {ex.Message}");
                }
                finally
                {
                    Console.WriteLine("\nработа программы завершена. нажмите любую клавишу");
                    Console.ReadKey();
                }
            }
        }
    
}
