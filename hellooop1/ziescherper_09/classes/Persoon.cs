using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
    internal class Persoon
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        DateTime reftime = new DateTime(1990, 1, 1, 0, 00, 0);

        private DateTime birthdate;
        public DateTime Birthdate
        {
            get
            {
                return birthdate;
            }
            set
            {
                if (value < reftime || value > DateTime.Today)
                {
                    birthdate = DateTime.Today;
                }
                else
                {
                    birthdate = value;
                }
            }

        }

        public void BerekenLeeftijd()
        {
            DateTime tijd = DateTime.Today;
            int leeftijd = tijd.Year - Birthdate.Year;
            if (Birthdate.Month > tijd.Month)
            {
                if (birthdate.Day > tijd.Day)
                {
                    leeftijd--;
                }
            }
            else
            {
                leeftijd = leeftijd;
            }
            Console.WriteLine(leeftijd);
        }

    }
}
