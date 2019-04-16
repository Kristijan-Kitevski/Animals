using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annimals
{
    public class Dog : Annimals
    {
        public Race Race { get; set; }

        public Dog(string name, Color color, int age,  Race race) 
            : base(name, color, age)
        {
            Race = race;

        }
        public void Bark()
        {
            Console.WriteLine("WOF WOF WOF (Lick You face) WOF WOF" );
        }

        public override void PrintAllProp()
        {
            Console.WriteLine(
               $"Animal name:{Name}\n" +
                $"Animal Age :{Age}\n" +
                $"Animal Color:{Color}\n" +
                $"Animal Race:{Race}"
                );
        }
    }
}
