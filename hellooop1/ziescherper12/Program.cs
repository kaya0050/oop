﻿using ziescherper_10.classes;
namespace ziescherper_12

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hoofdstuk12");
            Opdracht12_1();

            List<int> alleGetallen = new List<int>();
            alleGetallen.Add(69);
            alleGetallen.Add(420);
            List<bool> binaryList = new List<bool>();
            binaryList.Add(true);
            binaryList.Add(false);
            List<Student> pokeDex = new List<Student>();
            Student pikachu = new Student("pikachu");
 
            pokeDex.Add(pikachu);
            Student charmander = new Student("charmander");
            pokeDex.Add(charmander);
            List<string[]> listOfStringarrays = new List<string[]>();


            for (int i = 0; i < pokeDex.Count; i++)
            {
                Console.WriteLine(pokeDex[i].Naam);
                Console.WriteLine(pokeDex[i].geboortejaar);

            }
            for (int i = 0; i < alleGetallen.Count; i++)
            {
                Console.WriteLine(alleGetallen[i]);
            }
            for (int i = 0; i < binaryList.Count; i++)
            {
                Console.WriteLine(binaryList[i]);
            }

        }
        private static void Opdracht12_1()
        {
            Console.WriteLine("12.1");

            Student student = new Student();

            Student student1 = new Student("papaya");
            Console.WriteLine(student.Naam);
            Console.WriteLine(student1.Naam);

            Student[] students = new Student[] { student, student1 };
            students[1].Naam = "petronella";
            Console.WriteLine(student1.Naam);
        }


    }
}