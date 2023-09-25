using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
    internal class Rekening
    {

        private int balans;
        public string NaamKlant { get; set; }
        public string RekeningNummer { get; set; }
        public int balansCheck
        {
            get
            {
                return balans;
            }
        }
        public enum State { Geldig, Ongeldig }
        
        public void veranderstate(State state)
        {

            if (state == State.Geldig)
            {
                state = State.Ongeldig;

            }
            if (state == State.Ongeldig)
            {
                state = State.Geldig;
            }
        }

        public int haalgeldaf(State state)
        {
            if (state == State.Geldig)
            {
                Console.WriteLine("geldig");
                Console.WriteLine(balansCheck);
                Console.WriteLine("hoeveel moet er af");
                int aftrek = Int16.Parse(Console.ReadLine());

                if (balans < aftrek)
                {
                    Console.WriteLine("brokeboi niet genoeg geld");
                    return balans;
                }
                else
                {
                    balans -= aftrek;
                    return balans;
                }

            }
            else
            {
                Console.WriteLine("ongeldig");
                return balans;
            }

        }
        public int stortGeld(int plus)
        {
            Console.WriteLine(balansCheck);
            balans += plus;
            return balans;



        }
        public void tooninfo()
        {
            Console.WriteLine(NaamKlant);
            Console.WriteLine(RekeningNummer);
            Console.WriteLine("\n");
            Console.WriteLine("balans = " + balansCheck);
            Console.WriteLine("\n");


        }
        public void overschrijfen(Rekening rekening)
        {
            Console.WriteLine(balansCheck);
            Console.WriteLine("hoeveel overschrijfen");
            int over = Int16.Parse(Console.ReadLine());
            if (balans < over)
            {
                Console.WriteLine("brokeboi niet genoeg geld");
            }
            else
            {
                balans -= over;
                rekening.balans += over;
            }


        }
    }
}
