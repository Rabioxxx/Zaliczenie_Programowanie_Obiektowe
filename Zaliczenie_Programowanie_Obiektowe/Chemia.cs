using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_Programowanie_Obiektowe
{
    public class Chemia : Towar
    {
        private float masa;
        private bool niebezpieczny;

        public Chemia(float cena, string nazwa, float masa, bool niebezpieczny) : base(nazwa, cena)
        {
            Masa = masa;
            Niebezpieczny = niebezpieczny;
        }

        public float Masa { get => masa; set => masa = value; }

        public bool Niebezpieczny { get => niebezpieczny; set => niebezpieczny = value; }

        public override void Wypisz()
        {
            base.Wypisz();
            Console.Write(Masa + "," + Niebezpieczny + "\n");
        }
    }
}
