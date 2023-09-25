using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_10.classes
{
    internal class Meting
    {
        public int Temperatuur { get; set; }
        public string OpgemetenDoor { get; set; }
        public void ToonMetingInKleur(ConsoleColor kleur)
        {
            Console.ForegroundColor = kleur;
            Console.WriteLine($"{Temperatuur}°C gemeten door: {OpgemetenDoor}");
            Console.ResetColor();
        }
        public void VoegMetingToeEnVerwijder(ref Meting inMeting)
        {
            Temperatuur += inMeting.Temperatuur;
            inMeting = new Meting();
        }

    }
}
