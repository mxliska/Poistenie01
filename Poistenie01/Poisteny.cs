using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poistenie01
{
    internal class Poisteny
    {   
        public DateTime DatumNarozeni {  get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Vek { get; set; }
        public string Telefon { get; set; }

        //Konstruktor triedy Poisteny pre incializaciu objektu
        public Poisteny(string jmeno, string prijmeni, DateTime datumNarozeni, string tlelefon) 
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            Telefon = tlelefon;

            Vek = VypocitajVek(DatumNarozeni);
        }

        public override string ToString()
        {
            return $"Jmeno: {Jmeno}, Prijmeni: {Prijmeni}, Vek: {Vek}, Telefon: +420 {Telefon}";
        }

        // metoda pre vypocet veku
        private int VypocitajVek(DateTime datumNarozeni)
        {
            DateTime dnes = DateTime.Today;
            int vek = dnes.Year - datumNarozeni.Year;

            //znizenie veku o jeden ak ma narozeniny az pozdeji tento rok
            if (datumNarozeni.Date > dnes.Date)
            {
                vek--;
            }
            return vek;
        }
    }
}
