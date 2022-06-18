using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaliczenie_Programowanie_Obiektowe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Napoje napojTest = new Napoje("Kubus PLAY", 2.95f, 2024, 500.0f);
            napojTest.Wypisz();
            Console.WriteLine("Czy " + napojTest.Nazwa + " jest przeterminowany? " + napojTest.Przeterminowany()); ;
            napojTest.Sprzedano();

            Napoje napojTest2 = new Napoje("Kubus PLAY", 2.95f, 2021, 500.0f);
            napojTest2.Wypisz();
            Console.WriteLine("Czy " + napojTest2.Nazwa + " jest przeterminowany? " + napojTest2.Przeterminowany());


        }
    }
}
