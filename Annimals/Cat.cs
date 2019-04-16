using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annimals
{
    public class Cat : Annimals
    {
        public bool Islazy { get; set; }

        public Cat(string name, Color color, int age, bool isLazy)
            : base(name, color, age)
        {
            Islazy = isLazy;
        }

        public void Meowing()
        {
            Console.WriteLine("MAOOOOW MAAOOWW");
        }
            

        public override void PrintAllProp()
        {
            Console.WriteLine(
                $"Animal name:{Name}\n" +
                $"Animal Age :{Age}\n" +
                $"Animal Color:{Color}\n" +
                $"Is animal Lazy:{Islazy}\n"
                );
        }
    }
}
