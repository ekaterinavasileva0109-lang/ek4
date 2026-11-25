using System;
using System.Globalization;

namespace тема_6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strictLogDate = "2023-10-25 14:30:00";
            string strictFormat = "yyyy-MM-dd HH:mm:ss";

            //по шаблон
            try
            {
                DateTime parsedExact = DateTime.ParseExact(strictLogDate, strictFormat, CultureInfo.InvariantCulture);
                Console.WriteLine($"[ParseExact] строгий формат успешно распознан: {parsedExact}");
            }
            catch (FormatException)
            {
                Console.WriteLine("[ParseExact] ошибка: формат не соответствует стандарту!");
            }

            //гибкий но нужны разделители и цифры, при ошибке вылетит программа
            string humanLogDate = "12/11/2023 23:59:59";
            try
            {
                DateTime parsedFlex = DateTime.Parse(humanLogDate);
                Console.WriteLine($"[Parse] гибкий формат распознан: {parsedFlex}");
            }
            catch (FormatException)
            {
                Console.WriteLine("[Parse] не удалось распознать дату.");
            }

            Console.Write("\nвведите дату события для проверки (например, 25.12.2023): ");
            string userInput = Console.ReadLine();

            if (DateTime.TryParse(userInput, out DateTime userDate))
            {
                Console.WriteLine($"[TryParse] отлично! дата '{userInput}' валидна. день недели: {userDate.DayOfWeek}");
            }
            else
            {
                Console.WriteLine($"[TryParse] ошибка! строка '{userInput}' не является датой.");
            }

            Console.Write("\nвведите дату релиза в формате ДД.ММ.ГГГГ (например, 01.01.2024): ");
            string releaseInput = Console.ReadLine();
            string releaseFormat = "dd.MM.yyyy";

            if (DateTime.TryParseExact(releaseInput, releaseFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime releaseDate))
            {
                Console.WriteLine($"[TryParseExact] дата релиза принята: {releaseDate.ToLongDateString()}");
            }
            else
            {
                Console.WriteLine($"[TryParseExact] ошибка! введенная строка не соответствует формату {releaseFormat}");
            }

            Console.WriteLine("\nнажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}