using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ziescherper_09.classes
{
        
        public class balletje
        {
            
        //Eigenschappen
            public int X { get; set; }
            public int Y { get; set; }
            public int VectorX { get; set; }
            public int VectorY { get; set; }

            //Methoden
            public void Update()
            {
                if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
                {
                    VectorX = -VectorX;
                }
                X = X + VectorX;


                if (Y + VectorY >= Console.WindowHeight || Y + VectorY < 0)
                {
                    VectorY = -VectorY;
                }
                Y = Y + VectorY;
            }
            
            public void TekenOpScherm()
            {

                var w = Console.WindowWidth;
                var h = Console.WindowHeight;
                if (w > 0 && h > 0)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.Write($"0");
                }
                   



        }
        }
    
}
s