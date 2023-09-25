using System;
using System.ComponentModel.Design;
using ziescherper_09.classes;

namespace ziescherper_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            //Opdracht9_1();
            //Opdracht9_2();
            //Opdracht9_3();
            //Opdracht9_4();
            //Opdracht9_5();
            //Opdracht9_6a();
            //Opdracht9_6b();
            //Opdracht9_6c();
            //Opdracht9_6d();
            Opdracht9_6e();
            Console.WriteLine("goodbye world");
        }
        public static void Opdracht9_1()
        {


            const int AANTAL_BALLETJES = 1000;
            Random r = new Random();
            balletje[] veelBalletjes = new balletje[AANTAL_BALLETJES];
            for (int i = 0; i < veelBalletjes.Length; i++) //balletjes aanmaken
            {
                veelBalletjes[i] = new balletje();
                veelBalletjes[i].X = r.Next(10, 20);
                veelBalletjes[i].Y = r.Next(10, 20);
                veelBalletjes[i].VectorX = r.Next(-2, 3);
                veelBalletjes[i].VectorY = r.Next(-2, 3);
            }

            while (true)
            {
                for (int i = 0; i < veelBalletjes.Length; i++)
                {
                    veelBalletjes[i].Update(); //update alle balletjes
                }
                for (int i = 0; i < veelBalletjes.Length; i++)
                {
                    veelBalletjes[i].TekenOpScherm(); //teken alle balletjes
                }
                System.Threading.Thread.Sleep(50);
                var w = Console.WindowWidth;
                var h = Console.WindowHeight;
                if (w > 1 && h > 1)
                    Console.Clear();



            }
        }

        private static void Opdracht9_2()
        {
            Auto mijnEersteAuto = new Auto();
            //Auto mijnAndereAuto;
            Console.WriteLine(mijnEersteAuto);
            //Console.WriteLine(mijnAndereAuto);


        }
        
        private static void Opdracht9_3()
        {
            mens mens1 = new mens();
            mens mens2 = new mens();
            mens1.StartVerjongingskuur();
            mens1.Praat();
            mens2.VeranderLief("benny");
            mens2.Praat();
        }

        private static void Opdracht9_4()
        {
            Sithlord palpatine = new Sithlord("palpatine");
            //Console.WriteLine(palpatine.sithName);

            Sithlord Vader = new Sithlord("vader");
            //Vader.Energie = 20; //set
            Console.WriteLine($"Vaders energie is {Vader.Energie}"); //get
            Vader.ResetLord(20);
            Console.WriteLine($"Vaders energie is {Vader.Energie}"); //get

            Console.WriteLine($"Vaders email is {Vader.email}");
            Vader.Geboortejaar = 2000;
            Console.WriteLine($"Vaders geboortejaar is {Vader.Geboortejaar}");
        }

        private static void Opdracht9_5()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            DateTime trouwMoment = new DateTime(2017, 4, 21, 10, 00, 34);
            Console.WriteLine(trouwMoment);
            
            Console.WriteLine(trouwMoment.AddDays(50) + "plus 50 dagen.");
            Console.WriteLine($"het trouwmoment is op {trouwMoment.DayOfWeek}.");
            if (DateTime.IsLeapYear(trouwMoment.Year))
            {
                Console.WriteLine("het trouwmoment is op een shrikkeljaar");
            }
            else
            {
                Console.WriteLine("het trouwmoment is niet op een shrikkeljaar");
            }
        }

        private static void Opdracht9_6a()
        {
            Rapport mijnrapport = new Rapport();
            mijnrapport.percentage = 45;
            mijnrapport.printgraad();
        }

        private static void Opdracht9_6b()
        {
            Nummers nummers = new Nummers();
            nummers.nummer1 = 5;
            nummers.nummer2 = 34;

            Console.WriteLine($"Som = {nummers.Som()}");
            Console.WriteLine($"Verschil = {nummers.Verschil()}");
            Console.WriteLine($"Product = {nummers.Product()}");
            Console.WriteLine($"Quotient = {nummers.quotient()}");
        }
        private static void Opdracht9_6c()
        {
            Persoon persoon = new Persoon();
            persoon.Birthdate = new DateTime(2000, 1, 1);

            Console.WriteLine(persoon.Birthdate);

            persoon.BerekenLeeftijd();

        } 

        private static void Opdracht9_6d()
        {
            Console.WriteLine("Voer uw geboortedatum in (dd-mm-jjjj): ");
            string input = Console.ReadLine();
            DateTime geboortedatum;

            if (DateTime.TryParse(input, out geboortedatum))
            {
                DateTime huidigeDatum = DateTime.Now;
                DateTime volgendJaar = new DateTime(huidigeDatum.Year + 1, geboortedatum.Month, geboortedatum.Day);

                if (volgendJaar < huidigeDatum)
                {
                    volgendJaar = volgendJaar.AddYears(1);
                }

                string dagVanDeWeek = volgendJaar.ToString("dddd");
                TimeSpan dagenOver = volgendJaar - huidigeDatum;

                Console.WriteLine($"dag {dagVanDeWeek}");
                Console.WriteLine($"dagen over {dagenOver.Days}");
            }
            else
            {
                Console.WriteLine("Ongeldige invoer");
            }
        } 

        private static void Opdracht9_6e()
        {
            Console.WriteLine("\n");
            Rekening rekening = new Rekening();
            rekening.stortGeld(555);
            rekening.RekeningNummer = "9999";
            rekening.NaamKlant = "tim";
            rekening.tooninfo();
            //rekening.haalgeldaf(Rekening.State.Geldig);


            Rekening rekening2 = new Rekening();
            rekening2.stortGeld(666);
            rekening2.RekeningNummer = "8888";
            rekening2.NaamKlant = "tom";
            rekening.overschrijfen(rekening2);
            
            rekening.tooninfo();
            rekening2.tooninfo();

            
        }
    }
    

}
