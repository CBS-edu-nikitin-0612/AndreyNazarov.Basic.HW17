using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>() {
                { new("VAZ", "NIVA", "BLACK", "01/01/2000")},
                { new("TAZ", "VIVA", "WHITE", "01/01/2001") },
                { new("VAZ", "NIVA", "YELLOW", "01/01/2002" )},
                { new("VAZ", "NIVA", "BLACK", "01/01/2003") }
            };
            List<Customer> customers = new List<Customer>()
            {
                {new Customer("FORD", "BOB","952-456-45-45") },
                {new Customer("JEEP", "JACK","952-456-45-45") },
                {new Customer("VIVA", "KATE","952-456-45-45") },
                {new Customer("NIVA", "JOHN","952-456-45-45") },
            };
            var result = customers
                .Join(cars, cu => cu.Model, ca => ca.Model, (cu, ca) => new { Cu = cu, Car = ca })
                .Where(i => i.Cu.Name == "KATE")
                .Select(i => new { Customer = i.Cu, Car = i.Car })
                .Last();
            Console.WriteLine($"Покупатель: {result.Customer} \nВладеет машиной: {result.Car}");

            var result2 = cars
                .Join(customers, ca => ca.Model, cu => cu.Model, (ca, cu) => new { Customer = cu, Car = ca })
                .Where(i => i.Car.Model == "NIVA")
                .Select(i => new { Customer = i.Customer, Car = i.Car });
            Console.WriteLine("Владельцы автомобилей NIVA");
            foreach (var item in result2)
            {
                Console.WriteLine(item.Customer + " - " + item.Car);
            }
        }
    }

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
    internal class Customer
    {
        public Customer(string model, string name, string phoneNumber)
        {
            Model = model;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public string Model { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }

        public override string ToString()
        {
            return $"Имя: {Name}, Телефоный номер: {PhoneNumber}";
        }
    }
}
