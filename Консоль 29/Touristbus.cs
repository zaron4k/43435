using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль_29
{
    internal class Touristbus : Bus
    {
        string excursioncost;
        string number;
        public string Excursioncost { get => excursioncost; set => excursioncost= value; }
        public string Number { get => number; set => number = value; }
        public Touristbus() { }
        public Touristbus(string model, string number, int price, string excursioncost) : base(model, number, price)
        {
            Model = model ;
            Number = number ;
        }

        new public void Output()
        {
            Console.WriteLine($"{base.ToString()}Марка: {Model,-15}Количество мест: {Number,-10}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}Марка: {Model,-15}Количество мест: {Number,-10}";
        }
    }
}
