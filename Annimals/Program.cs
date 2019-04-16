using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annimals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>()
            {
                new Dog ("Sarko", Color.Green, 4,Race.Canecorso),
                new Dog("Jony", Color.Red, 10, Race.Irisseter),
                new Dog("Pero", Color.Yellow, 6, Race.Rotvailer)
            };

            List<Cat> Cats = new List<Cat>()
            {
                new Cat ("Tom", Color.Blue,7, true),
                new Cat ("Chappy",  Color.Green,8, false),
                new Cat ("Kia", Color.Yellow,12, false)
            };

            List<Bird> Birds = new List<Bird>()
            {
                new Bird ("Pipi",  Color.Red, 15, true),
                new Bird ("Mappy",  Color.Blue,45 ,false),
                new Bird ("Jinx",  Color.Blue, 22,true)
            };

            //            Get all dogs of a particular race
            //Get the last lazy cat
            //Get the all wild birds that are younger than 3 and are ordered by their name

            var AllDogs = Dogs.Where(x => x.Race == Race.Canecorso).ToList();
            // Where
            // Select
            // FirstOrDefault
            // LastOrDefault
            // ToList() - ne e link ama go koristime vo sklop na link

            //1. SITE METODI RABOTAT SO IEnumerable tip
            // IEnumerable tip e abstraktna kolekcija koja pamti pravila izvrseni na nekoja kolekcija
            // IEnumerable cuva uslovi/baranja
            // Koga ke dojde moment da go iskoristime IEnumerable kako vrednost, TOGAS se izvrsuva baranjeto i ja dobivame vrednosta
            //2. First/last/default vrakaat EDNINA od tipot sto e listata ( pr. List<Cat> ako imame First ke ni vrati Cat, List<string> ke ni vrati string )

            IEnumerable<Cat> catRules = Cats.Where(x => x.Islazy == false).Where(x => x.Age < 5); // Ovde se cuva baranje do Cats lista kade ke se zemat samo ne mrzlivite objekti od Cat
            List<Cat> notLazyCats = catRules.ToList(); // Ovde so ToList() go izvrsuvame baranjeto ( query-to ) ke gi dobieme site objekti od Cat sto ne se mrzlivi vo nova lista
            Cat notLazyCat = catRules.FirstOrDefault(); 
            foreach (var notlazy in notLazyCats)
            {
                Console.WriteLine(notlazy.Name);
            }
            foreach (var cat in catRules) // Koga ke vidi pravilnikot deka barame vrednosti od nego
            {
                Console.WriteLine(cat.Name);
            }
            var LasyCat = Cats.LastOrDefault(x => x.Islazy == true);
            var WildBirds = Birds.Where(x => x.Age < 3).OrderBy(x => x.Name).ToList();


            LasyCat.PrintAllProp();
            foreach (var dog in AllDogs)
            {
                dog.PrintAllProp();
            }


            Console.ReadLine();
        }
    }
}
