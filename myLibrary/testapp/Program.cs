using myLibrary;
using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethods methods = new MyMethods();

            methods.SayHello();
            methods.PrintNumber(42);

            int sum = methods.Add(10, 5);
            Console.WriteLine($"Сумма: {sum}"); 

            string greeting = methods.GetGreeting("Студент");
            Console.WriteLine(greeting); 

            double quotient = methods.Divide(10.0, 2.0);
            Console.WriteLine($"Частное: {quotient}"); 

            Console.ReadLine();
        }
    }
}