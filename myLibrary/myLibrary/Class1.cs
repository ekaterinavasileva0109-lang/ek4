namespace myLibrary
{
    public class MyMethods
    {
        public void SayHello()
        {
            Console.WriteLine("привет из DLL!");
        }

        public void PrintNumber(int number)
        {
            Console.WriteLine($"переданное число: {number}");
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public string GetGreeting(string name)
        {
            return $"здравствуйте, {name}!";
        }

        public double Divide(double a, double b)
        {
            if (b == 0) return 0; 
            return a / b;
        }
    }
}
