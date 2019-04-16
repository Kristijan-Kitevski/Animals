using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annimals
{
    public abstract class Annimals
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        private int _age; // ima rabota SAMO da cuva i da dava vrednost
        public int Age { // ima rabota SAMO da povikuva get i set metodi

            get
            {
                return _age;

            }
            set
            {
                if (value < 0 || value > 175)
                    Console.WriteLine($"This age {value} is invalid input(noi such annimal) :) ");
                else _age = value;
            }
        }
        //public int Age2
        //{
        //    get
        //    {
        //        return Age2;
        //    }
        //    set
        //    {
        //        Age2 = value;
        //    }
        //}
        // sharko.Age2 -> Animal.Age2.get()
        // sharko.Age2 = 2 -> Animal.Age2.set(2)
        public Annimals(string name, Color color, int age)
        {
            Name = name;
            Color = color;
            Age = age;


        }
        public abstract void PrintAllProp();
    }


}
