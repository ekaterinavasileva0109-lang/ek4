using System;

namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "привет";
            string b = "привет";
            string c = "пока";

            Console.WriteLine("== и !=");
            Console.WriteLine("a == b: " + (a == b));
            Console.WriteLine("a != c: " + (a != c));

            Console.WriteLine("equals");
            Console.WriteLine("a.Equals(b): " + a.Equals(b));
            Console.WriteLine("a.Equals(c): " + a.Equals(c));
            Console.WriteLine("a.Equals(c, игнор регистр): " + a.Equals(c, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("compare");
            int r1 = string.Compare(a, b);
            int r2 = string.Compare(a, c);
            Console.WriteLine("Compare(a, b): " + r1);
            Console.WriteLine("Compare(a, c): " + r2);

            Console.WriteLine("compareordinal");
            int r3 = string.CompareOrdinal(a, c);
            Console.WriteLine("CompareOrdinal(a, c): " + r3);

            Console.WriteLine("поиск");
            string text = "программирование на c# это круто";
            Console.WriteLine("есть ли c#? " + text.Contains("c#"));
            Console.WriteLine("индекс c#: " + text.IndexOf("c#"));
            Console.WriteLine("индекс java: " + text.IndexOf("java"));

            Console.WriteLine("проверка ввода");
            Console.Write("напиши что-нибудь: ");
            string input = Console.ReadLine();

                if (input.Contains("плохо") || input.Contains("мат"))
                {
                    Console.WriteLine("не пиши такие слова!");
                }
                else
                {
                    Console.WriteLine("ок, сообщение принято.");
                }

                Console.ReadKey();
        }
    }
}