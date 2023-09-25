using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
    public class Sithlord
    {

        public int Geboortejaar { get; set; }

        private int energie;
        private string sithName;


        public int Energie
        {
            get
            {
                return energie;
            }
            private set
            {
                if (value >= 0)
                    energie = value;
            }
        }
        public string email
        {
            get
            {
                return $"{sithName}@gmail.com";
            }
        }

        public void ResetLord(int resetWaarde)
        {
            Energie = resetWaarde;
        }
        public Sithlord(string name)
        {
            this.sithName = name;
        }
    }
}
