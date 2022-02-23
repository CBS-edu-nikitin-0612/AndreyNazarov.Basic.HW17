using System;

namespace Task2
{
    internal class Car
    {
        public Car(string tradeMark, string model, string color, string year)
        {
            TradeMark = tradeMark;
            Model = model;
            Color = color;
            Year = DateTime.Parse(year);
        }

        public string TradeMark { get; private set; }
        public string Model { get; private set; }
        public string Color { get; private set; }
        public DateTime Year { get; private set; }
        public override string ToString()
        {
            return $"Марка: {TradeMark}, Модель: {Model}, Цвет: {Color}, Год выпуска: {Year.Year}";
        }
    }
}
