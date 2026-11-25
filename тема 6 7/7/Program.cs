using System;

namespace _7
{
    public class ArrayProcessor
    {
        public static int[] SortAscending(int[] arr)
        {
            int[] copy = (int[])arr.Clone();
            Array.Sort(copy);
            return copy;
        }

        public static int[] SortDescending(int[] arr)
        {
            int[] copy = (int[])arr.Clone();
            Array.Sort(copy);
            Array.Reverse(copy);
            return copy;
        }

        public static int[] MergeArrays(int[] arr1, int[] arr2)
        {
            int[] result = new int[arr1.Length + arr2.Length];
            arr1.CopyTo(result, 0);
            arr2.CopyTo(result, arr1.Length);
            return result;
        }
    }

    public class MathCalculator
    {
        public static int CalculateDifference(int n)
        {
            int difference = Math.Abs(n - 123); //модуль

            if (n > 123)
            {
                return difference * 3;
            }
            return difference;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("утилита обработки данных");
                Console.WriteLine("1. тест методов для массивов");
                Console.WriteLine("2. тест математической задачи (n и 123)");
                Console.WriteLine("0. выход");
                Console.Write("\nвыберите пункт меню: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TestArrays();
                        break;
                    case "2":
                        TestMath();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("неверный ввод. нажмите Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void TestArrays()
        {
            Console.Clear();
            Console.WriteLine("тест массивов");

            int[] arrayA = { 5, 2, 9, 1, 7 };
            int[] arrayB = { 8, 3, 6, 4 };

            Console.WriteLine($"исходный массив A: [{string.Join(", ", arrayA)}]");
            Console.WriteLine($"исходный массив B: [{string.Join(", ", arrayB)}]");

            Console.WriteLine($"\nсортировка A по возрастанию: [{string.Join(", ", ArrayProcessor.SortAscending(arrayA))}]");
            Console.WriteLine($"сортировка A по убыванию:   [{string.Join(", ", ArrayProcessor.SortDescending(arrayA))}]");
            Console.WriteLine($"объединение A и B:          [{string.Join(", ", ArrayProcessor.MergeArrays(arrayA, arrayB))}]");

            Console.WriteLine("\nнажмите Enter для возврата в меню...");
            Console.ReadLine();
        }

        static void TestMath()
        {
            Console.Clear();
            Console.WriteLine("математическая задача");
            Console.Write("введите целое число n: ");

            if (int.TryParse(Console.ReadLine(), out int n))
            {
                int result = MathCalculator.CalculateDifference(n);
                Console.WriteLine($"результат для n={n}: {result}");

                if (n > 123)
                    Console.WriteLine("(применено условие: n > 123, разность утроена)");
            }
            else
            {
                Console.WriteLine("ошибка: нужно ввести целое число!");
            }

            Console.WriteLine("\nнажмите Enter для возврата в меню...");
            Console.ReadLine();
        }
    }
}