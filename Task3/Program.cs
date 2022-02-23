using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<dynamic> dictionary = new()
            {
                new { Eng = "Apple", Rus = "Яблоко" },
                new { Eng = "Table", Rus = "Стол" },
                new { Eng = "Label", Rus = "Наклейка" },
                new { Eng = "Sun", Rus = "Солнце" },
                new { Eng = "Run", Rus = "Бежать" },
                new { Eng = "Jamp", Rus = "Прыгать" },
                new { Eng = "Watch", Rus = "Часы" },
                new { Eng = "Screen", Rus = "Монитор" },
                new { Eng = "Plate", Rus = "Тарелка" },
                new { Eng = "Keyboard", Rus = "Клавиатура" }
            };

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Eng} - {item.Rus}");
            }
        }
    }
}
