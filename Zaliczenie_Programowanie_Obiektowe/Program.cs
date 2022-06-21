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
            Console.WriteLine("Testy:");

            Napoje napojTest = new Napoje("Kubus PLAY", 2.95f, 2024, 500.0f);
            napojTest.Wypisz();
            Console.WriteLine("Czy " + napojTest.Nazwa + " jest przeterminowany? " + napojTest.Przeterminowany()); ;

            Napoje napojTest2 = new Napoje("Kubus PLAY", 2.95f, 2021, 500.0f);
            napojTest2.Wypisz();
            Console.WriteLine("Czy " + napojTest2.Nazwa + " jest przeterminowany? " + napojTest2.Przeterminowany());

            Chemia chemiaTest = new Chemia("płyn do zmywania", 10.99f, 1.5f, false);
            chemiaTest.Wypisz();
            Console.WriteLine("Czy " + chemiaTest.Nazwa + " jest niebezpieczny? " + chemiaTest.Niebezpieczny);
            Console.WriteLine();

            // App command line.
            List<Napoje> napojeList = new List<Napoje> { napojTest, napojTest2 };
            List<Chemia> chemiaList = new List<Chemia>() { chemiaTest };
            List<Owoce> owoceList = new List<Owoce>();

            bool flagExit = false;

            while (!flagExit)
            {
                Console.WriteLine("Manager Zarządzania Składem");
                Console.WriteLine("Dostępne komendy:");
                Console.WriteLine();
                Console.WriteLine("show - wypisz obecny towar na magazynie.");
                Console.WriteLine("add - dodaj towar.");
                Console.WriteLine("remove - usuń towar.");
                Console.WriteLine("terminate - zakończ działanie programu.");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "show":
                        Console.WriteLine("Chemia na stanie:");
                        if (chemiaList.Count == 0)
                        {
                            Console.WriteLine("<brak>");
                            Console.WriteLine();
                        }
                        for (int i = 0; i < chemiaList.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". ");
                            chemiaList[i].Wypisz();

                            Console.WriteLine();
                        }

                        Console.WriteLine("Napoje na stanie:");
                        if (napojeList.Count == 0)
                        {
                            Console.WriteLine("<brak>");
                            Console.WriteLine();
                        }
                        for (int i = 0; i < napojeList.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". ");
                            napojeList[i].Wypisz();
                            Console.WriteLine();
                        }
        
                        Console.WriteLine("Owoce na stanie:");
                        if (owoceList.Count == 0)
                        {
                            Console.WriteLine("<brak>");
                            Console.WriteLine();
                        }
                        for (int i = 0; i < owoceList.Count; i++)
                        {
                            Console.WriteLine(i + 1 + ". ");
                            owoceList[i].Wypisz();
                            Console.WriteLine();
                        }
                        break;
                    case "add":
                        bool flag = true;
                        while (flag)
                        {
                            Console.WriteLine("Jakiego typu towar chciałbyś dodać?");
                            Console.WriteLine("chemia");
                            Console.WriteLine("napoje");
                            Console.WriteLine("owoce");

                            input = Console.ReadLine();

                            switch (input)
                            {
                                case "chemia":
                                    Console.WriteLine("Podaj: nazwa cena masa czyNiebezpieczny(true/false):");
                                    string[] inputSplitted;

                                    input = Console.ReadLine();
                                    if (input == null)
                                    {
                                        input = "";
                                    }

                                    inputSplitted = input.Split(" ");

                                    if (inputSplitted.Length < 4)
                                    {
                                        Console.WriteLine("Error.");
                                    }
                                    else
                                    {
                                        Chemia chemia = new Chemia(inputSplitted[0], float.Parse(inputSplitted[1]), float.Parse(inputSplitted[2]), bool.Parse(inputSplitted[3]));
                                        chemiaList.Add(chemia);
                                    }
                                    Console.WriteLine("Pomyślnie dodano towar.");
                                    flag = false;
                                    break;
                                case "napoje":
                                    Console.WriteLine("Podaj: nazwa cena terminWażności(rok) pojemność:");

                                    input = Console.ReadLine();
                                    if (input == null)
                                    {
                                        input = "";
                                    }

                                    inputSplitted = input.Split(" ");

                                    if (inputSplitted.Length < 4)
                                    {
                                        Console.WriteLine("Error.");
                                    }
                                    else
                                    {
                                        Napoje napoj = new Napoje(inputSplitted[0], float.Parse(inputSplitted[1]), int.Parse(inputSplitted[2]), float.Parse(inputSplitted[3]));
                                        napojeList.Add(napoj);
                                    }
                                    Console.WriteLine("Pomyślnie dodano towar.");
                                    flag = false;
                                    break;
                                case "owoce":
                                    Console.WriteLine("Podaj: nazwa cena terminWażności(rok) masa:");

                                    input = Console.ReadLine();
                                    if (input == null)
                                    {
                                        input = "";
                                    }

                                    inputSplitted = input.Split(" ");

                                    if (inputSplitted.Length < 4)
                                    {
                                        Console.WriteLine("Error.");
                                    }
                                    else
                                    {
                                        Owoce owoc = new Owoce(inputSplitted[0], float.Parse(inputSplitted[1]), int.Parse(inputSplitted[2]), float.Parse(inputSplitted[3]));
                                        owoceList.Add(owoc);
                                    }
                                    Console.WriteLine("Pomyślnie dodano towar.");
                                    flag = false;
                                    break;
                                default:
                                    Console.WriteLine("Spróbuj jeszcze raz.");
                                    break;
                            }
                        }

                        break;
                    case "remove":
                        Console.WriteLine("Z jakiej kategorii chcesz usunąć towar?");
                        Console.WriteLine("chemia");
                        Console.WriteLine("napoje");
                        Console.WriteLine("owoce");

                        string categoryInput = Console.ReadLine();

                        Console.WriteLine("Podaj indeks towaru, który chcesz usunąć:");

                        int indexInput = int.Parse(Console.ReadLine());

                        switch (categoryInput)
                        {
                            case "chemia":
                                if (indexInput > chemiaList.Count || 
                                    indexInput < 1 ||
                                    chemiaList.Count == 0)
                                {
                                    Console.WriteLine("\nError, nie ma takiego towaru.\n");
                                }
                                else 
                                { 
                                    chemiaList.RemoveAt(indexInput - 1);
                                    Console.WriteLine("\nPoprawnie usunięto towar\n");
                                }
                                break;
                            case "napoje":
                                if (indexInput > napojeList.Count ||
                                    indexInput < 1 ||
                                    napojeList.Count == 0)
                                {
                                    Console.WriteLine("\nError, nie ma takiego towaru.\n");
                                }
                                else
                                {
                                    napojeList.RemoveAt(indexInput - 1);
                                    Console.WriteLine("\nPoprawnie usunięto towar\n");
                                }
                                break;
                            case "owoce":
                                if (indexInput > owoceList.Count ||
                                    indexInput < 1 ||
                                    owoceList.Count == 0)
                                {
                                    Console.WriteLine("\nError, nie ma takiego towaru.\n");
                                }
                                else
                                {
                                    owoceList.RemoveAt(indexInput - 1);
                                    Console.WriteLine("\nPoprawnie usunięto towar\n");
                                }
                                break;
                            default:
                                break;
                        }
                        break;
                    case "terminate":
                        flagExit = true;
                        break;
                    default:
                        Console.WriteLine("Nie rozumiem polecenia. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
