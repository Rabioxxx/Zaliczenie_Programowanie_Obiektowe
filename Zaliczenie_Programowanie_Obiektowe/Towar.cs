using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_Programowanie_Obiektowe
{
    public abstract class Towar : IInfo, IInfoTowar
    {
        protected string nazwa;
        protected float cena;
        protected float sprzedanychSztuk;

        protected Towar(string nazwa, float cena)
        {
            Nazwa = nazwa;
            Cena = cena;
        }

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public float Cena { get => cena; set => cena = value; }
        public float SprzedanychSztuk { get => sprzedanychSztuk; set => sprzedanychSztuk = value; }

        public float Sprzedano()
        {
            return SprzedanychSztuk;
        }
        public virtual void Wypisz()
        {
            Console.Write("Nazwa: " + Nazwa + "\n" + "Cena: " + Cena + " zł\n" + "Sprzedanych sztuk: " + SprzedanychSztuk + "\n");
        }
        public float Zysk()
        {
            return Cena * SprzedanychSztuk;
        }
    }
}
