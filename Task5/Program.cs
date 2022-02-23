using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Не совсем понимаю в чем цель задания, может я что то не то сделал?
            Calculator calculator = new();
            try
            {
                Console.WriteLine(calculator.Add(10, 10));
                Console.WriteLine(calculator.Sub(10, 10));
                Console.WriteLine(calculator.Mul(10, 10));
                Console.WriteLine(calculator.Div(10, 10));
                Console.WriteLine(calculator.Div(10, 0));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
