using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
    internal class mens
    {
        private int geboortejaar = 2000;
        private string lief = "niemand";
        public void VeranderLief(string nieuwLief)
        {
            lief = nieuwLief;
        }
        public void Praat()
        {
            Console.WriteLine("Ik ben een mens!");
            VertelGeheim();
            Console.WriteLine($"ik ben geboren in {geboortejaar}");
        }
        private void VertelGeheim()
        {
            if (lief != "niemand")
            {
                Console.WriteLine($"Ik ben verliefd op {lief}");
            }
            else
            {
                Console.WriteLine("ik hou van niemand");
            }
            

        }
        public void StartVerjongingskuur()
        {
            Console.WriteLine("Jeee. Ik word jonger!");
            geboortejaar++;
        }
        public void VeranderGeboortejaar(int geboorteJaarIn)
        {
            if (geboorteJaarIn >= 1900)
                geboortejaar = geboorteJaarIn;
        }

    }
}
