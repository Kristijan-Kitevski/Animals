using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annimals
{
    public class Bird : Annimals
    {
        public bool IsWild { get; set; }


        public Bird(string name, Color color, int age, bool isWild)
            : base(name, color, age)
        {
            IsWild = isWild;

        }

        public void Fly()
        {
            //FlySouth(method) - Print's in the console that is flying south if IsWild is true or print's that it's a domesticated bird if its false
            if (IsWild == true)
            {
                Console.WriteLine($"{Name}is flying south");
            
            }
            else Console.WriteLine($"{Name} is domesticated bird");

        }

        public override void PrintAllProp()
        {
            Console.WriteLine(
               $"Animal name:{Name}\n" +
                $"Animal Age :{Age}\n" +
                $"Animal Color:{Color}\n" +
               $"Is animal Wild:{IsWild}"
               );
        }
    }
}
