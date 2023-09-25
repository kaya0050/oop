using System;
using ziescherper_10.classes;

namespace ziesherper_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoofdstuk_10");
            Opdracht10_1();
            Opdracht10_2();
            Opdracht10_3();



        }


        private static void VerhoogParameter(int a)
        {
            a++;
            Console.WriteLine($"In methode {a}");
        }
        private static void Opdracht10_1()
        {
            int getal = 5;
            VerhoogParameter(getal);
            Console.WriteLine($"Na methode {getal}");


            Student a = new Student("Abba");
            Student b = new Student("Queen");

            Console.WriteLine(a.Naam);
            Console.WriteLine(b.Naam);

            b = a;

            Console.WriteLine(a.Naam);
            Console.WriteLine(b.Naam);
        }
        private static void Opdracht10_2()
        {
            Meting m1 = new Meting();
            m1.Temperatuur = 26;
            m1.OpgemetenDoor = "Lieven Scheire";
            Meting m2 = new Meting();
            m2.Temperatuur = 34;
            m2.OpgemetenDoor = "Ann Dooms";

            m1.ToonMetingInKleur(ConsoleColor.Red);
            m2.ToonMetingInKleur(ConsoleColor.Cyan);

            m1.Temperatuur = 26;
            m1.OpgemetenDoor = "Lieven Scheire";
            m2.Temperatuur = 5;
            m2.OpgemetenDoor = "Lieven Scheire";
            m1.VoegMetingToeEnVerwijder(ref m2);
            Console.WriteLine($"{m1.Temperatuur} en {m2.Temperatuur}");
        }
        private static void Opdracht10_3()
        {
        
            Student stud2;
  
            Student stud1 = null;
    
            if (stud1 == null)
                Console.WriteLine("bestaat niet.");
            if (stud1 != null)
                Console.WriteLine(stud1.Naam);

           
            Console.WriteLine(stud1?.Naam);

           
            Student[] studenten = { new Student("een"), new Student("twee") };
            Student stud3 = Student.ZoekStudent(studenten, "een");
            Student stud4 = Student.ZoekStudent(studenten, "twee");
           
            Console.WriteLine(stud3 != null ? $"Naam {stud3.Naam}" : " niet gevonden");
            Console.WriteLine(stud4 != null ? $"Naam {stud4.Naam}": " niet gevonden");

            Mens mama = new Mens();
            mama.Geslacht = Mens.Geslachten.Vrouw; 
            mama.MaxLengte = 180;

            Mens papa = new Mens();
            papa.Geslacht = Mens.Geslachten.Man;
            papa.MaxLengte = 169;

            
            Mens baby = mama.PlantVoort(papa);
            Console.WriteLine(baby == null ? $"beeby geslacht {baby.Geslacht}  lengte {baby.MaxLengte}" : "miskraam（>_<）");
        }

    }
     
}