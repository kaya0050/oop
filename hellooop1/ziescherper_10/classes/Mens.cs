using System;

namespace ziescherper_10.classes
{
    public class Mens
    {
        public enum Geslachten { Man, Vrouw };
        public int MaxLengte { get; set; }
        public Geslachten Geslacht { get; set; }
        public Mens PlantVoort(Mens dePapa)
        {
            if (Geslacht == Geslachten.Vrouw && dePapa.Geslacht == Geslachten.Man)
            {
                Mens baby = new Mens();
                baby.MaxLengte = MaxLengte;
                if (dePapa.MaxLengte >= MaxLengte)
                    baby.MaxLengte = dePapa.MaxLengte;
                return baby;
            }
            return null;
        }

    }
}

