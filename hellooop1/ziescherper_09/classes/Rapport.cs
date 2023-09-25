using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
    internal class Rapport
    {

        public int percentage { get; set; }

        public void printgraad()
        {
            Console.WriteLine("printgraad");

            
            switch(percentage){
                case (< 50):
                    Console.WriteLine("onvoldoende");
                    break;
                case (<=68):
                    Console.WriteLine("voldoende");
                    break;
                case (<= 75):
                    Console.WriteLine("onderscheiding");
                    break;
                case (<= 85):
                    Console.WriteLine("grooteonderscheiding");
                    break;
                case (> 85):
                    Console.WriteLine("grootsteonderscheiding");
                    break;
                default:
                    Console.WriteLine("dnf");
                    break;
            }
        }
    }
}
