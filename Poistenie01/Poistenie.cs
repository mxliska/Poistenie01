using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poistenie01
{
    internal class Poistenie
    {
        //Metodu na pridani poistence do seznamu
        public void PridatPoisteneho(List<Poisteny> poistenci) 
        {
            Console.WriteLine("Zadejte jmeno pojisteneho: ");
            string jmeno = Console.ReadLine();

            //kontrola vstupu ci su to len pisamena
            while (!jmeno.All(char.IsLetter)) 
            {
                Console.WriteLine("Jmeno musi obsahovat jenom pismena. Znovu: ");
                jmeno = Console.ReadLine();
            }

            Console.WriteLine("Zadejte prijmeni pojisteneho: ");
            string prijmeni = Console.ReadLine();

            while (!prijmeni.All(char.IsLetter))
            {
                Console.WriteLine("Prijmeni musi obsahovat jenom pismena. Znovu: ");
            }


            //Zadani datumu narozeni
            int den, mesic, rok;
            do
            {
                Console.WriteLine("Zadejte den narozeni pojisteneho: ");
            } while (!int.TryParse(Console.ReadLine(), out den) || den < 1 || den > 31);

            do
            {
                Console.WriteLine("Zadejte mesic narozeni pojisteneho: ");
            } while (!int.TryParse(Console.ReadLine(), out mesic) || mesic < 1 || mesic > 12);

            do
            {
                Console.WriteLine("Zadejte rok narozeni pojisteneho: ");
            } while (!int.TryParse(Console.ReadLine(), out rok) || rok < 1900 || rok > DateTime.Now.Year);

            DateTime datumNarozeni = new DateTime(rok, mesic, den);


            //zadani tel. cisla 
            string telefon;
            do
            {
                Console.WriteLine("Zadejte telefonne cislo pojisteneho(9znaku): ");
                telefon = Console.ReadLine();
                if (telefon.Length != 9)
                {
                    Console.WriteLine("Telefonne cislo poistenca musi obsahovat 9 cislic.");
                }

            } while (telefon.Length != 9);
            
            
            //tvorba instance a nasledne pridani poistence do seznamu
            Poisteny poisteny = new Poisteny(jmeno, prijmeni, datumNarozeni, telefon); 
            poistenci.Add(poisteny);

            Console.WriteLine("Pojistenec byl uspesne pridan");
            Console.WriteLine();
        }


        //metoda na vypisanie vsetkych poistencov
        public void ZobrazitPojistenych(List<Poisteny> poistenci)
        {
            Console.WriteLine("Seznam vsech pojistenych: ");

            foreach (var c in poistenci)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine();
        }


        // vyhledani konkretniho poistence na zaklade jmena a prijmeni
        public void VyhledatPoisteneho(List<Poisteny> poistenci)
        {
            Console.WriteLine("Zadejte jmeno poisteneho: ");
            string hledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadejte prijmeni poisteneho: ");
            string hledanePrijmeni = Console.ReadLine();

            Poisteny nalezenyPoisteny = poistenci.Find(p => p.Jmeno == hledaneJmeno && p.Prijmeni == hledanePrijmeni);

            if (nalezenyPoisteny != null)
            {
                Console.WriteLine("Nalezeny poisteny: ");
                Console.WriteLine(nalezenyPoisteny);
                Console.WriteLine();
            }

            else
                Console.WriteLine("Poisteny nebyl nalezen.");
        }


    }
}
