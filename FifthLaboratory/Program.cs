using System;
using System.Collections.Generic;
using System.Linq;

namespace FifthLaboratory
{
    class Program
    {
        static void Main(string[] args)
        {
            var listAvto = new List<Avto>()
            {
                new("Юрий", "БМВ", 0),
                new("Тимофей", "Мерседес", 1),
                new("Артем", "Жигули", 2),
            };

            foreach (var auto in listAvto)
            {
                auto.PrintOwner();
                
                auto.PrintType();
                auto.PrintNumber();
            }

            Console.WriteLine("Введите номер авто с клавиатуры");
            var num = int.Parse(Console.ReadLine());
            var autoByNum = listAvto.FirstOrDefault(a => a.GetNumber() == num);
            Console.WriteLine(autoByNum is not { }
                ? "Авто не найдено"
                : $"Найден автомобиль с номером: {autoByNum.GetNumber()}, Владелец: {autoByNum.GetOwner()}, Марка: {autoByNum.GetType()}");
        }
    }

    class Avto
    {
        private string _owner;
        private string _type;
        private int _number;
        
        public Avto(string owner, string type, int number)
        {
            this._owner = owner;
            this._type = type;
            this._number = number;
        }

        public void PrintOwner()
        {
            Console.WriteLine($"Владелец: {this._owner}");
        }

        public void PrintType()
        {
            Console.WriteLine($"Тип: {this._type}");
        }

        public void PrintNumber()
        {
            Console.WriteLine($"Номер: {this._number}");
        }

        public void SetOwner(string owner)
        {
            this._owner = owner;
        }

        public void SetType(string type)
        {
            this._type = type;
        }

        public void SetNumber(int number)
        {
            this._number = number;
        }
        
        public string GetOwner()
        {
            return this._owner;
        }

        public string GetType()
        {
            return this._type;
        }

        public int GetNumber()
        {
            return this._number;
        }
    }
}