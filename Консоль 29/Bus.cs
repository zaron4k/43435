using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_29
{
    internal class Bus
    {
        string model;
        int number;
        int price;
        public string Model
        {
            get => model;
            set => model = value;
        }
        public int Number
        {
            get => number;
            set => number = value;
        }
        public int Price
        {
            get => price;
            set => price = value;
        }
        public Bus() { }
        public Bus(string model, int number, int price)
        {
            this.Model = model;
            this.Number = number;
            this.Price = price;
        }
        

        
        public virtual void Output()
        {
            Console.WriteLine($"Марка: {Model,-10}Номер: {Number,-10}Цена: {Price,-5}");
        }
        public override string ToString()
        {
            return $"Имя: {Model,-10}Фамилия: {Number,-10}Возраст: {Price,-5}";
        }
    }
}
