using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_10.classes
{
    public class Student
    {
        public string Naam { get; set; }
        public Student(string Naam)
        {
            this.Naam = Naam;
        }
        public Student()
        {
            this.Naam = "kaya";
        }  
        public static Student ZoekStudent(Student[] array, string naam)
        {
            Student gevonden = null;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Naam == naam)
                    gevonden = array[i];
            }

            return gevonden;
        }

    }
}
