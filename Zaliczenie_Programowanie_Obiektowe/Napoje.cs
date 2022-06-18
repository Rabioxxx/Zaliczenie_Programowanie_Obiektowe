using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_Programowanie_Obiektowe
{
    public class Napoje : Spozywczy
    {
        private float pojemnosc;

        public Napoje(string nazwa, float cena, int rok_termin, float pojemnosc) : base(nazwa, cena, rok_termin)
        {
            Pojemnosc = pojemnosc;
        }

        public float Pojemnosc { get => pojemnosc; set => pojemnosc = value; }

        public new void Wypisz()
        {
            base.Wypisz();
            Console.Write(Pojemnosc + "\n");
        }
    }
}
