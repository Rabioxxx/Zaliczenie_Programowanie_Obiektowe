using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_Programowanie_Obiektowe
{
    public abstract class Spozywczy : Towar, IInfoSpozywcze
    {
        private int rok_termin;

        protected Spozywczy(string nazwa, float cena, int rok_termin) : base(nazwa, cena)
        {
            Rok_termin = rok_termin;
        }

        public int Rok_termin { get => rok_termin; set => rok_termin = value; }

        public new virtual void Wypisz()
        {
            base.Wypisz();
            Console.Write(Rok_termin + ",");
        }

        public bool Przeterminowany()
        {
            // Year now is greater than validity? True - not valid to eat.
            return DateTime.Now.Year > Rok_termin;
        }
    }
}
