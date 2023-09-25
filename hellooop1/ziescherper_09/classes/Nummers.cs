using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
    internal class Nummers
    {
        public int nummer1 { get; set; }
        public int nummer2 { get; set; }

        public int Som()
        {
            Console.WriteLine("som");
            int antwoord1 = nummer1 += nummer2;
            //Console.WriteLine(antwoord1);
            return antwoord1;
        }
        public int Verschil()
        {
            Console.WriteLine("verschil");
            int antwoord2 = nummer1 -= nummer2;
            if (antwoord2 < 0)
            {
                antwoord2 = antwoord2 * -1;
            }
            //Console.WriteLine(antwoord2);
            return antwoord2;
        }
        public int Product()
        {
            Console.WriteLine("product");
            int anwoord3 = nummer1 * nummer2;
            //Console.WriteLine(anwoord3);
            return anwoord3;
        }
        public float quotient()
        {
            Console.WriteLine("quotient");
            
            if (nummer2 == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                var antwoord4 = (float)nummer1 / nummer2;
                //Console.WriteLine(antwoord4);
                return antwoord4;
            }
            return 0;
        }
    }
}
