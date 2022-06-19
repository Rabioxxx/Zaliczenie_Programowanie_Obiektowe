using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_Programowanie_Obiektowe
{
    public class Owoce : Spozywczy
    {
        private float masa;

        public Owoce(string nazwa, float cena, int rok_termin, float masa) : base(nazwa, cena, rok_termin)
        {
            Masa = masa;
        }

        public float Masa { get => masa; set => masa = value; }

        public override void Wypisz()
        {
            base.Wypisz();
            Console.Write("Masa: " + Masa + "\n");
        }
    }
}
